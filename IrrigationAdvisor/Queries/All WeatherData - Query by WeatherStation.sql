/****** Script for Select All Weather Data by Weather Station  ******/
SELECT 
	  WS.Name  AS 'Estacion'
	  ,Case WS.StationType
		  when 1 then 'INIA'
		  when 2 then 'WeatherLink'
		  else 'NoWebInformation' end  AS 'Tipo'
	  ,WS.WebAddress AS 'Web'
	  ,WS.UpdateTime  AS 'Ultimo acceso Estacion'
	  ,WD.[Date] AS 'Fecha Datos'
      ,WD.[Temperature] AS 'Temperatura'
      ,WD.[TemperatureMax] AS 'Max Temp'
      ,WD.[TemperatureMin] AS 'Min Temp'
      ,WD.[TemperatureDewPoint] AS 'Temp Rocio'
      ,WD.[RainDay] AS 'Lluvia'
      ,WD.[RainStorm] AS 'Lluvia Tormenta'
      ,WD.[RainMonth] AS 'Lluvia Mes'
      ,WD.[RainYear] AS 'Lluvia Anio'
      ,WD.[Evapotranspiration] AS 'Evapotranspiracion'
      ,WD.[EvapotranspirationMonth] AS 'ET Mes'
      ,WD.[EvapotranspirationYear] AS 'ET Anio'
      ,WD.[Humidity] AS 'Humedad'
      ,WD.[HumidityMax] AS 'Max Hum'
      ,WD.[HumidityMin] AS 'Min Hum'
      ,WD.[Barometer] AS 'Presion'
      ,WD.[BarometerMax] AS 'Max Pre'
      ,WD.[BarometerMin] AS 'Min Pre'
      ,WD.[SolarRadiation] AS 'Radiacion Solar'
      ,WD.[UVRadiation] AS 'Radiacion UV'
      ,WD.[WeatherDataType] AS 'Tipo WD'
      ,WD.[Observations] AS 'Observaciones'
      ,WD.[WindSpeed] AS 'Viento'
      , Case WD.[WeatherDataInputType]
		  when 1 then 'Servicio'
		  when 2 then 'Web'
		  when 3 then 'Prediccion'
		  else 'Codigo' end  AS 'Ingreso desde'
      ,WD.[WeatherDataId] AS 'WD Id'
      ,WD.[WeatherStationId] AS 'WS Id'
      
  FROM [IrrigationAdvisor].[dbo].[WeatherData] WD
  INNER JOIN [IrrigationAdvisor].[dbo].[WeatherStation] WS
	ON WD.WeatherStationId = WS.WeatherStationId
  WHERE wd.Date > '2017-11-15'
  --AND ws.WeatherStationId = 6
  ORDER BY day(wd.Date) desc, ws.WeatherStationId


