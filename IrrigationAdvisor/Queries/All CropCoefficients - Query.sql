/****** Script for Select CropCoefficient  ******/
SELECT cc.[CropCoefficientId] As 'Id'
      ,cc.[Name] As 'Nombre'
      ,s.Name As 'Especie'
  FROM [IrrigationAdvisor].[dbo].[CropCoefficient] cc
  INNER JOIN [IrrigationAdvisor].[dbo].[Specie] s
  ON s.SpecieId = cc.SpecieId

  /*
  
  Select *
  From [IrrigationAdvisor].[dbo].[Specie] s
  
  
  */