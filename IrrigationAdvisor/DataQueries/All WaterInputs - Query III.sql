SELECT 
      ciw.[CropIrrigationWeatherName] As 'Nombre'
      ,wi.[Input]  AS 'Agua'
      ,wi.[ExtraInput] AS 'Agua Extra'
      ,wi.[Input] + wi.[ExtraInput] AS 'Agua TOTAL'
      ,CASE WHEN wi.Input > 0 THEN wi.[Date]
			WHEN wi.ExtraInput = 0 THEN wi.Date
			ELSE wi.[ExtraDate] END AS 'Fecha'
      --,wi.[Date] AS 'Fecha Input'
      --,wi.[ExtraDate] AS 'Fecha Extra'
      --, ir.WaterInputId 'Irrigation'
      --, ra.WaterInputId 'Rain'
	  ,CASE WHEN (ir.WaterInputId) > 0 THEN
		   CASE WHEN ra.WaterInputId > 0 THEN 'ERROR' 
				ELSE ir.Observations END
			ELSE 'Lluvia' END
        AS 'Reason'
      ,CASE WHEN (ir.WaterInputId) > 0 THEN
		   CASE WHEN ra.WaterInputId > 0 THEN 'ERROR' 
				ELSE 'Riego' END
			ELSE 'Lluvia' END
        AS 'Ingreso de Agua'
      ,wi.[WaterInputId] AS 'Input Id'
      ,ciw.[CropIrrigationWeatherId] As 'CIW Id'
	  , CASE WHEN ir.Type = 0 THEN 'Rain'
			WHEN ir.Type = 1 THEN 'Irrigation'
			WHEN ir.Type = 2 THEN 'IrrigationByETCAcumulated'
			WHEN ir.Type = 3 THEN 'IrrigationByHydricBalance'
			WHEN ir.Type = 4 THEN 'CantIrrigate'
			WHEN ir.Type = 5 THEN 'IrrigationWasNotDecided'
			WHEN ir.Type = 6 THEN 'Confirmation'
		ELSE 'Rain' END
	    AS 'Type'
  FROM [IrrigationAdvisor].[dbo].[WaterInput] wi
  INNER JOIN [IrrigationAdvisor].[dbo].[CropIrrigationWeather] ciw 
	ON ciw.CropIrrigationWeatherId = wi.CropIrrigationWeatherId
  LEFT JOIN [IrrigationAdvisor].[dbo].[Irrigation] ir
	ON ir.WaterInputId = wi.WaterInputId
  LEFT JOIN [IrrigationAdvisor].[dbo].[Rain] ra
	ON ra.WaterInputId = wi.WaterInputId