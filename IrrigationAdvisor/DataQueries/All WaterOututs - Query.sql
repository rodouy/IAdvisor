/****** Script for SelectTopNRows command from SSMS  ******/
SELECT  
      ciw.[CropIrrigationWeatherName] As 'Nombre'
      ,wo.[Output] AS 'Egreso TOTAL'
      , wo.[Date] AS 'Fecha'
	  --,wo.[Output]
      --,wo.[Date]
      --,wo.[ExtraOutput]
      --,wo.[ExtraDate]
      ,wo.[WaterOutputId] AS 'Id'
      ,wo.[CropIrrigationWeatherId] AS 'CIW Id'
  FROM [IrrigationAdvisor-DEMO].[dbo].[WaterOutput] wo
  INNER JOIN [IrrigationAdvisor-DEMO].[dbo].[CropIrrigationWeather] ciw 
	ON ciw.CropIrrigationWeatherId = wo.CropIrrigationWeatherId
  ORDER BY ciw.CropIrrigationWeatherName, wo.Date desc
	