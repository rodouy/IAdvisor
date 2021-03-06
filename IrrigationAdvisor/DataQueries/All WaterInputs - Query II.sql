
  -- Irrigation
  SELECT wi.[WaterInputId] AS 'Id'
      ,wi.[Input] AS 'Agua'
      ,wi.[Date] AS 'Fecha'
      ,wi.[ExtraInput] AS 'Agua Extra'
      ,wi.[ExtraDate] AS 'Fecha Extra'
      ,ir.[Observations] AS 'Observations'
      ,ir.[Type] AS 'Type'
	  , CASE WHEN ir.Type = 0 THEN 'Rain'
			WHEN ir.Type = 1 THEN 'Irrigation'
			WHEN ir.Type = 2 THEN 'IrrigationByETCAcumulated'
			WHEN ir.Type = 3 THEN 'IrrigationByHydricBalance'
			WHEN ir.Type = 4 THEN 'CantIrrigate'
			WHEN ir.Type = 5 THEN 'IrrigationWasNotDecided'
			WHEN ir.Type = 6 THEN 'Confirmation'
		ELSE 'Rain' END
	    AS 'Type Desc'
      --, ir.WaterInputId 'Irrigation'
      ,CASE WHEN (ir.WaterInputId) > 0 THEN
		    'Riego' END
        AS 'Ingreso de Agua'
      ,ciw.[CropIrrigationWeatherName] As 'Nombre'
      ,ciw.[CropIrrigationWeatherId] As 'Id'

  FROM [IrrigationAdvisor].[dbo].[WaterInput] wi
  INNER JOIN [IrrigationAdvisor].[dbo].[CropIrrigationWeather] ciw 
	ON ciw.CropIrrigationWeatherId = wi.CropIrrigationWeatherId
  INNER JOIN [IrrigationAdvisor].[dbo].[Irrigation] ir
	ON ir.WaterInputId = wi.WaterInputId

	--Where ciw.CropIrrigationWeatherId = 12

	--Add Extra Irrigation. Before: FertigationConfirmación de riego 11/19/2018 00:00:00 Tipo de Riego: Riego por ETc Acumulado.  Updated Irrigation. Tipo de Riego: Riego extra.  Updated Irrigation.
