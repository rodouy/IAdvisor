/****** Script for Select Specie  ******/
SELECT  s.[SpecieId] As 'Id'
      ,s.[Name] As 'Nombre'
      ,s.[ShortName] As 'Nombre corto'
      ,sc.Name As 'Ciclo'
      ,[BaseTemperature] As 'Temperatura Base'
      ,[StressTemperature] As 'Temperatura de estres'
      ,r.Name As 'Region'
  FROM [IrrigationAdvisor].[dbo].[Specie] s
  INNER JOIN [IrrigationAdvisor].[dbo].[SpecieCycle] sc
  ON sc.SpecieCycleId = s.SpecieCycleId
  INNER JOIN [IrrigationAdvisor].[dbo].[Region] r
  ON r.RegionId = s.Region_RegionId
  
  /*
  Select *
  From [IrrigationAdvisor].[dbo].[SpecieCycle]
  
  Select *
  From [IrrigationAdvisor].[dbo].[Region]
  
  */
  
  
  