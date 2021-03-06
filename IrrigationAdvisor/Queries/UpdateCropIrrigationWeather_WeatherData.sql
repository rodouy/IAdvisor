/****** Script for SelectTopNRows command from SSMS  ******/
SELECT [WeatherDataId]
      ,[WeatherStationId]
      ,[Date]
      ,[Temperature]
      ,[TemperatureMax]
      ,[TemperatureMin]
      ,[TemperatureDewPoint]
      ,[Humidity]
      ,[HumidityMax]
      ,[HumidityMin]
      ,[Barometer]
      ,[BarometerMax]
      ,[BarometerMin]
      ,[SolarRadiation]
      ,[UVRadiation]
      ,[RainDay]
      ,[RainStorm]
      ,[RainMonth]
      ,[RainYear]
      ,[Evapotranspiration]
      ,[EvapotranspirationMonth]
      ,[EvapotranspirationYear]
      ,[WeatherDataType]
      ,[Observations]
  FROM [IrrigationAdvisor].[dbo].[WeatherData]
  WHERE WeatherStationId = 6
  
  SELECT wd.WeatherDataId, ciw.CropIrrigationWeatherId
  , dr.DailyRecordId, dr.DailyRecordDateTime
  , dr.MainWeatherDataId
  FROM [IrrigationAdvisor].[dbo].[WeatherData] wd
  INNER JOIN IrrigationAdvisor.dbo.WeatherStation ws ON ws.WeatherStationId = wd.WeatherStationId
  INNER JOIN IrrigationAdvisor.dbo.CropIrrigationWeather ciw ON ciw.MainWeatherStation_WeatherStationId = ws.WeatherStationId
  INNER JOIN dbo.DailyRecord dr ON dr.CropIrrigationWeather_CropIrrigationWeatherId = ciw.CropIrrigationWeatherId
  WHERE wd.WeatherStationId = 11
  AND YEAR(dr.DailyRecordDateTime) = YEAR(wd.Date)
  AND MONTH(dr.DailyRecordDateTime) = MONTH(wd.Date)
  AND DAY(dr.DailyRecordDateTime) = DAY(wd.Date)

	UPDATE dbo.DailyRecord
	SET MainWeatherDataId = wd.WeatherDataId
	FROM [IrrigationAdvisor].[dbo].[WeatherData] wd 
  INNER JOIN IrrigationAdvisor.dbo.WeatherStation ws ON ws.WeatherStationId = wd.WeatherStationId
  INNER JOIN IrrigationAdvisor.dbo.CropIrrigationWeather ciw ON ciw.MainWeatherStation_WeatherStationId = ws.WeatherStationId
  WHERE --wd.WeatherStationId = 11 AND
   dbo.DailyRecord.CropIrrigationWeather_CropIrrigationWeatherId  = ciw.CropIrrigationWeatherId
  AND YEAR(dbo.DailyRecord.DailyRecordDateTime) = YEAR(wd.Date)
  AND MONTH(dbo.DailyRecord.DailyRecordDateTime) = MONTH(wd.Date)
  AND DAY(dbo.DailyRecord.DailyRecordDateTime) = DAY(wd.Date)
  
  SELECT *
  FROM dbo.DailyRecord