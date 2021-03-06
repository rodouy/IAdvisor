/****** Script for Select Bomb  ******/
SELECT  b.[BombId] As 'Id'
      ,b.[Name] As 'Nombre'
      ,b.[SerialNumber] As 'Numero de Serie'
      ,b.[ServiceDate] As 'Fecha de Servicio'
      ,b.[PurchaseDate] As 'Fecha de Compra'
      ,p.Latitude As 'Latitud'
      ,p.Longitude As 'Longitud'
      ,f.Name As 'Establecimiento'
  FROM [IrrigationAdvisor].[dbo].[Bomb] b
  INNER JOIN [IrrigationAdvisor].[dbo].[Position] p
  ON p.PositionId = b.PositionId
  INNER JOIN [IrrigationAdvisor].[dbo].[Farm] f
  ON f.FarmId = b.Farm_FarmId
  
  /*
  Select *
  From [IrrigationAdvisor].[dbo].[Farm]
  
  Select *
  From [IrrigationAdvisor].[dbo].[Position]
  
  */
  
  