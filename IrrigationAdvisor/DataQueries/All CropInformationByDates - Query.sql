/****** Script for Select CropInformationByDate  ******/
SELECT 
		cid.[CropInformationByDateId] As 'Id'
      ,cid.[Name] As 'Nombre'
      ,cid.[SowingDate] As 'Fecha de Siembra'
      ,cid.[CurrentDate] As 'Fecha de Referencia'
      ,cid.[DaysAfterSowing] As 'Dias despues de Siembra'
      ,s.Name As 'Especie'
      ,cc.Name As 'Crop Coefficient'
      ,r.Name As 'Region'
      ,cid.[AccumulatedGrowingDegreeDays] As 'GDD Acumulados'
      ,st.Name As 'Fenologia'
      ,cid.[CropCoefficientValue] As 'Valor de KC'
      ,cid.[RootDepth] As 'Raiz'
  FROM [IrrigationAdvisor].[dbo].[CropInformationByDate] cid
  INNER JOIN [IrrigationAdvisor].[dbo].[Specie] s
  ON s.SpecieId = cid.SpecieId
  INNER JOIN [IrrigationAdvisor].[dbo].[CropCoefficient] cc
  ON cc.CropCoefficientId = cid.CropCoefficientId
  INNER JOIN [IrrigationAdvisor].[dbo].[Region] r
  ON r.RegionId = cid.RegionId
  INNER JOIN [IrrigationAdvisor].[dbo].[Stage] st
  ON st.StageId = cid.StageId
  
  /*
  
  Select *
  From [IrrigationAdvisor].[dbo].[Specie] s
  
  Select *
  From [IrrigationAdvisor].[dbo].[Region] r
  
  Select *
  From [IrrigationAdvisor].[dbo].[Stage] st
  
  
  
  */