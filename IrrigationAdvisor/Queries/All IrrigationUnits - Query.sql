/****** Script for Select IrrigationUnit  ******/
SELECT iu.[IrrigationUnitId] As 'Id'
      ,iu.[Name] As 'Nombre'
      ,iu.[ShortName] As 'Nombre corto'
      ,Case iu.[IrrigationType]
      When 0 then 'Pivot'
      When 1 then 'Sprinkler'
      else 'Drip' end As 'Tipo de Riego'
      ,iu.[IrrigationEfficiency] As 'Eficiencia de Riego'
      ,iu.[Surface] As 'Superficie'
      ,b.Name As 'Bomba'
      ,p.Latitude As 'Latitud'
      ,p.Longitude As 'Longitud'
      ,[PredeterminatedIrrigationQuantity] As 'Cantidad predeterminada de Riego'
      ,f.Name As 'Establecimiento'
  FROM [IrrigationAdvisor].[dbo].[IrrigationUnit] iu
  INNER JOIN [IrrigationAdvisor].[dbo].[Bomb] b
  ON b.BombId = iu.BombId
  INNER JOIN [IrrigationAdvisor].[dbo].[Position] p
  ON p.PositionId = iu.PositionId
  INNER JOIN [IrrigationAdvisor].[dbo].[Farm] f
  ON f.FarmId = iu.Farm_FarmId
  
  /*
  Select *
  From [IrrigationAdvisor].[dbo].[Bomb]
  
  Select *
  From [IrrigationAdvisor].[dbo].[Farm]
  
  Select *
  From [IrrigationAdvisor].[dbo].[Position]
  
  */
  
  