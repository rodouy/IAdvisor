/****** Script for Select KC  ******/
SELECT  kc.[KCId] As 'Id'
      ,s.Name As 'Especie'
      ,kc.[DayAfterSowing] As 'Dias despues de Siembra'
      ,kc.[Coefficient] As 'Coeficiente'
      --,cc.Name As 'Nombre Coeficiente del Cultivo'
  FROM [IrrigationAdvisor].[dbo].[KC] kc
  INNER JOIN [IrrigationAdvisor].[dbo].[Specie] s
  ON s.SpecieId = kc.SpecieId
  INNER JOIN [IrrigationAdvisor].[dbo].[CropCoefficient] cc
  ON cc.CropCoefficientId = kc.[CropCoefficient_CropCoefficientId]
  
  
  /*
  
  Select *
  From [IrrigationAdvisor].[dbo].[Specie] s
  
  Select *
  From [IrrigationAdvisor].[dbo].[CropCoefficient] cc
  
  
  
  */
  
  