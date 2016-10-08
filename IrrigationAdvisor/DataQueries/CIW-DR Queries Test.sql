/****** Script for SelectTopNRows command from SSMS  ******/
SELECT ciw.*
  FROM [IrrigationAdvisor].[dbo].CropIrrigationWeather ciw
  WHERE ciw.CropIrrigationWeatherId IN (1,2,3,4)
  
  SELECT dr.*
  FROM [IrrigationAdvisor].[dbo].[DailyRecord] dr
  WHERE dr.CropIrrigationWeather_CropIrrigationWeatherId IN(1,2,3,4)
  AND dr.DailyRecordDateTime BETWEEN '2015-12-08' AND '2015-12-12'
  ORDER BY dr.DailyRecordDateTime
  