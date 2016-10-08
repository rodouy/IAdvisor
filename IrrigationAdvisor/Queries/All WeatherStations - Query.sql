/****** Script for SelectTopNRows command from SSMS  ******/
SELECT 
	  WS.Name  AS 'Estacion'
	  ,WS.Model AS 'Modelo'
	  ,Case WS.StationType
	  when 1 then 'INIA'
	  when 2 then 'WeatherLink'
	  else 'NoWebInformation' end  AS 'Tipo'
	  ,WS.UpdateTime  AS 'Ultima actualizacion'
	  ,WS.DateOfInstallation  AS 'Instalacion'
	  ,WS.DateOfService  AS 'Servicio'
      ,P.Latitude As 'Latitud'
      ,P.Longitude As 'Longitud'
	  ,WS.WebAddress AS 'Web'
	  ,WD.[Date] AS 'Fecha Ultimo Dato'
      ,WD.[WeatherStationId] AS 'WS Id'
      --,WS.*
  FROM [IrrigationAdvisor-DEMO].[dbo].[WeatherStation] WS
  INNER JOIN [IrrigationAdvisor-DEMO].[dbo].[WeatherData] WD
	ON WS.WeatherStationId = WD.WeatherStationId
	AND WD.Date = (SELECT MAX(W.Date) 
					FROM [IrrigationAdvisor-DEMO].[dbo].[WeatherData] W
					WHERE W.WeatherStationId = WD.WeatherStationId)
  INNER JOIN [IrrigationAdvisor-DEMO].[dbo].[Position] P
  ON WS.PositionId = P.PositionId
      WHERE WD.Date >= '2016-09-01'  
  ORDER BY WD.Date DESC, WS.WeatherDataType, WD.WeatherStationId
