/****** Script for Select Horizons  ******/
SELECT h.[HorizonId] As 'Id'
      ,h.[Name] As 'Nombre'
      ,h.[Order] As 'Orden'
      ,h.[HorizonLayer] As 'Capa'
      ,h.[HorizonLayerDepth] As 'Profundidad Capa'
      ,h.[Sand] As 'Arena'
      ,h.[Limo] As 'Limo'
      ,h.[Clay] As 'Arcilla'
      ,h.[OrganicMatter] As 'Materia Organica'
      ,h.[NitrogenAnalysis] As 'Nitrogeno'
      ,h.[BulkDensitySoil] As 'Densidad'
      ,s.[Description] As 'Descripcion'
  FROM [IrrigationAdvisor].[dbo].[Horizon] h
  INNER JOIN [IrrigationAdvisor].[dbo].[Soil] s
  ON s.SoilId = h.[Soil_SoilId]
  
  
  /*
  
  Select *
  From [IrrigationAdvisor].[dbo].[Soil]
  
  */
  
  