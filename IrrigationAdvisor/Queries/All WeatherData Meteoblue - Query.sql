SELECT 
	  WS.Name  AS 'Estacion'
	  ,Case WS.StationType
		  when 1 then 'INIA'
		  when 2 then 'WeatherLink'
		  else 'NoWebInformation' end  AS 'Tipo'
	  ,WS.UpdateTime  AS 'Ultimo acceso Estacion'
	  ,WD.[WeatherDate] AS 'Fecha Datos'
      ,WD.[TemperatureMean] AS 'Temperatura'
      ,WD.[TemperatureMax] AS 'Max Temp'
      ,WD.[TemperatureMin] AS 'Min Temp'
      ,WD.[DewPointTemperatureMean] AS 'Temp Rocio'
      ,WD.[DewPointTemperatureMax] AS 'Max Temp Rocio'
      ,WD.[DewPointTemperatureMin] AS 'Min Temp Rocio'
      ,WD.[Precipitation] AS 'Lluvia'
      ,WD.[PrecipitationProbability] AS 'Prob Lluvia'
      ,WD.[Evapotranspiration] AS 'Evapotranspiracion'
      ,WD.[RelativeHumidityMean] AS 'Humedad'
      ,WD.[RelativeHumidityMax] AS 'Max Hum'
      ,WD.[RelativeHumidityMin] AS 'Min Hum'
      ,WD.[SealevelPressureMean] AS 'Presion'
      ,WD.[SealevelPressureMax] AS 'Max Pre'
      ,WD.[SealevelPressureMin] AS 'Min Pre'
      ,WD.[UVIndex] AS 'Indice UV'
      ,WD.[WindSpeedMean] AS 'Viento'
	  ,WD.BasicUrl AS 'Web'
      
      ,WD.[MeteoblueWeatherDataId] AS 'WD Id'
      ,WD.[WeatherStationId] AS 'WS Id'
      
  FROM [IrrigationAdvisor-DEMO].[dbo].[MeteoblueWeatherData] WD
  INNER JOIN [IrrigationAdvisor-DEMO].[dbo].[WeatherStation] WS
	ON WD.WeatherStationId = WS.WeatherStationId
  WHERE wd.WeatherDate > '2016-09-15'
  AND ws.WeatherStationId = 1
  ORDER BY wd.WeatherDate desc