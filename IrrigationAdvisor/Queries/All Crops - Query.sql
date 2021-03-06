/****** Script for Select Crop  ******/
SELECT c.[CropId] As 'Id'
      ,c.[Name] As 'Nombre'
      ,c.[ShortName] As 'Nom'
      ,r.Name As 'Region' 
      ,s.Name As 'Especie'
      ,cc.Name As 'Coeficiente del Cultivo'
      ,c.[Density] As 'Densidad'
      ,c.[MaxEvapotranspirationToIrrigate] 
			As 'MAX ET para Riego'
      ,c.[MinEvapotranspirationToIrrigate]
			As 'MIN ET para Riego'
      ,st.Name As 'Fenologia que PARA el Riego'
  FROM [IrrigationAdvisor].[dbo].[Crop] c
  INNER JOIN [IrrigationAdvisor].[dbo].[Region] r
  ON r.RegionId = c.RegionId
  INNER JOIN [IrrigationAdvisor].[dbo].[Specie] s
  ON s.SpecieId = c.SpecieId
  INNER JOIN [IrrigationAdvisor].[dbo].[CropCoefficient] cc
  ON c.CropCoefficientId = cc.CropCoefficientId
  INNER JOIN [IrrigationAdvisor].[dbo].[Stage] st
  ON st.StageId = c.StopIrrigationStageId

  
  /*
  
  Select *
  From [IrrigationAdvisor].[dbo].[Region]
  
  Select *
  From [IrrigationAdvisor].[dbo].[Specie] s
  
  Select *
  From [IrrigationAdvisor].[dbo].[CropCoefficient] cc
  
  Select *
  From [IrrigationAdvisor].[dbo].[Stage] st
  
  
  */
  
  