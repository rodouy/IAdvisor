/****** Script for SelectTopNRows command from SSMS  ******/

TRUNCATE TABLE [IrrigationAdvisor].[dbo].DailyRecord
TRUNCATE TABLE [IrrigationAdvisor].dbo.WeatherInformation
TRUNCATE TABLE [IrrigationAdvisor].[dbo].[WeatherData]
SELECT * FROM [IrrigationAdvisor].dbo.WeatherStation

SELECT wd3.*
  FROM [IrrigationAdvisor-DEMO].[dbo].[WeatherData] wd3
  WHERE wd3.WeatherStationId IN(
  
  
SELECT  *
  FROM [IrrigationAdvisor].[dbo].[WeatherData] wd
  WHERE NOT EXISTS
  (SELECT wd2.WeatherDataId, wd2.Date
  FROM [IrrigationAdvisor-DEMO].[dbo].[WeatherData] wd2
  WHERE wd2.WeatherStationId = wd.WeatherStationId
  AND wd2.Date = wd.Date)
  --ORDER BY wd.Date 
)

SELECT *
  FROM [IrrigationAdvisor-DEMO].[dbo].[WeatherData] wd
  WHERE 
   NOT EXISTS
  (SELECT wd2.WeatherDataId, wd2.Date
  FROM [IrrigationAdvisor].[dbo].[WeatherData] wd2
  WHERE wd2.WeatherStationId = wd.WeatherStationId
  AND wd2.Date = wd.Date)
  ORDER BY wd.Date 

SELECT *
  FROM [IrrigationAdvisor-DEMO].[dbo].[WeatherData]
  WHERE WeatherStationId >=6
  AND Date BETWEEN '2016-09-17' AND '2016-10-10'
  ORDER BY month(Date) DESC, DAY(Date) DESC, WeatherStationId
  
  DELETE 
  FROM [IrrigationAdvisor-DEMO].[dbo].[WeatherData]
  WHERE WeatherStationId =6
  AND Date BETWEEN '2016-09-01' AND '2016-09-16'
  
  
  SELECT *
  FROM [IrrigationAdvisor].[dbo].[WeatherData]
  WHERE WeatherStationId >=6
  AND Date BETWEEN '2016-09-17' AND '2016-10-10'
  ORDER BY month(Date) DESC, DAY(Date) DESC, WeatherStationId
  