/****** Script for SelectTopNRows command from SSMS  ******/
SELECT 
      ciw.[CropIrrigationWeatherName] As 'Nombre'
      --,wi.[Input]  AS 'Agua'
      --,wi.[ExtraInput] AS 'Agua Extra'
      ,wi.[Input] + wi.[ExtraInput] AS 'Agua TOTAL'
      ,CASE WHEN wi.Input > 0 
			THEN wi.[Date]
			ELSE wi.[ExtraDate] END AS 'Fecha'
      --,wi.[ExtraDate] AS 'Fecha Extra'
      --, ir.WaterInputId 'Irrigation'
      --, ra.WaterInputId 'Rain'
      ,CASE WHEN (ir.WaterInputId) > 0 THEN
		   CASE WHEN ra.WaterInputId > 0 THEN 'ERROR' 
				ELSE 'Riego' END
			ELSE 'Lluvia' END
        AS 'Ingreso de Agua'
      ,wi.[WaterInputId] AS 'Input Id'
      ,ciw.[CropIrrigationWeatherId] As 'CIW Id'

  FROM [IrrigationAdvisor-DEMO].[dbo].[WaterInput] wi
  INNER JOIN [IrrigationAdvisor].[dbo].[CropIrrigationWeather] ciw 
	ON ciw.CropIrrigationWeatherId = wi.CropIrrigationWeatherId
  LEFT JOIN [IrrigationAdvisor-DEMO].[dbo].[Irrigation] ir
	ON ir.WaterInputId = wi.WaterInputId
  LEFT JOIN [IrrigationAdvisor-DEMO].[dbo].[Rain] ra
	ON ra.WaterInputId = wi.WaterInputId
  
  
  /*********************************************************/
  --Rains
  SELECT wi.[WaterInputId] AS 'Id'
      ,wi.[Input] AS 'Agua'
      ,wi.[Date] AS 'Fecha'
      ,wi.[ExtraInput] AS 'Agua Extra'
      ,wi.[ExtraDate] AS 'Fecha Extra'
      --, ra.WaterInputId 'Rain'
      ,CASE WHEN ra.WaterInputId > 0 
			THEN 'Lluvia' END
        AS 'Ingreso de Agua'
      ,ciw.[CropIrrigationWeatherName] As 'Nombre'
      ,ciw.[CropIrrigationWeatherId] As 'Id'

  FROM [IrrigationAdvisor].[dbo].[WaterInput] wi
  INNER JOIN [IrrigationAdvisor].[dbo].[CropIrrigationWeather] ciw 
	ON ciw.CropIrrigationWeatherId = wi.CropIrrigationWeatherId
  INNER JOIN [IrrigationAdvisor].[dbo].[Rain] ra
	ON ra.WaterInputId = wi.WaterInputId
  
  -- Irrigation
  SELECT wi.[WaterInputId] AS 'Id'
      ,wi.[Input] AS 'Agua'
      ,wi.[Date] AS 'Fecha'
      ,wi.[ExtraInput] AS 'Agua Extra'
      ,wi.[ExtraDate] AS 'Fecha Extra'
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
  
  