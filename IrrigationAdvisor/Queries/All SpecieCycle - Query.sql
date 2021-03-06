/****** Script for Select SpecieCycle  ******/
SELECT sc.[SpecieCycleId] As 'Id'
      ,sc.[Name] As 'Nombre'
      ,sc.[Duration] As 'Duración'
      ,r.Name As 'Region'
  FROM [IrrigationAdvisor].[dbo].[SpecieCycle] sc
  INNER JOIN [IrrigationAdvisor].[dbo].[Region] r
  ON r.RegionId = sc.Region_RegionId
  
  
  /*
  Select *
  From [IrrigationAdvisor].[dbo].[SpecieCycle]
  
  Select *
  From [IrrigationAdvisor].[dbo].[Region]
  */