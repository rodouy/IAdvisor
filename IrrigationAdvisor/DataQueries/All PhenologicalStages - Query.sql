/****** Script for Select PhenologicalStage  ******/
SELECT [PhenologicalStageId] As 'Id'
      ,[SpecieId]
      ,[StageId]
      ,[MinDegree]
      ,[MaxDegree]
      ,[RootDepth]
      ,[HydricBalanceDepth]
      ,[CropInformationByDate_CropInformationByDateId]
      ,[Crop_CropId]
  FROM [IrrigationAdvisor].[dbo].[PhenologicalStage] ps
  
  
  /*
  
  
  
  */