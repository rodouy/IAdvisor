/****** Script for Select PhenologicalStage  ******/
SELECT ps.[PhenologicalStageId] As 'Id'
      ,s.Name As 'Especie'
      ,st.Name As 'Estadio'
      ,ps.[MinDegree] As 'MIN Grados'
      ,ps.[MaxDegree] As 'MAX Grados'
      ,ps.[RootDepth] As 'Profundidad de Raiz'
      ,ps.[HydricBalanceDepth] As 'Profundidad por Balance Hidrico'
  FROM [IrrigationAdvisor].[dbo].[PhenologicalStage] ps
  INNER JOIN [IrrigationAdvisor].[dbo].[Specie] s
  ON s.SpecieId = ps.SpecieId
  INNER JOIN [IrrigationAdvisor].[dbo].[Stage] st
  ON st.StageId = ps.StageId

  /*
  
  Select *
  From [IrrigationAdvisor].[dbo].[Specie] s
  
  Select *
  From [IrrigationAdvisor].[dbo].[CropCoefficient] cc
  
  Select *
  From [IrrigationAdvisor].[dbo].[Stage] st
  
 
  
  */
  