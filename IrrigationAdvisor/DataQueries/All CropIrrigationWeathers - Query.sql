/****** Script for Select CropIrrigationWeather  ******/
SELECT ciw.[CropIrrigationWeatherId] As 'Id'
      ,ciw.[CropIrrigationWeatherName] As 'Nombre'
      ,c.ShortName As 'Nombre Cultivo'
      ,s.Name As 'Nombre Suelo'
      ,ciw.[SowingDate] As 'Fecha de Siembra'
      ,ciw.[HarvestDate] As 'Fecha de Cosecha'
      ,ciw.[CropDate] As 'Fecha ultimo calculo'
      ,ciw.[StartAdvisorDate] As 'Empieza consultoria'
      ,st.Name 'Estadio Fenologico'
      ,ciw.[HydricBalance] As 'Balance Hidrico'
      ,ciw.[SoilHydricVolume] As 'Volumen Hidrico del Suelo'
      ,ciw.[TotalEvapotranspirationCropFromLastWaterInput] As 'Evapotranspiracion Total'
      ,ciw.[CalculusMethodForPhenologicalAdjustment] As 'Metodo de Calculo'
      ,cid.Name As 'Informacion diaria del Cultivo'
      ,ciw.[DaysAfterSowing] As 'DDS'
      ,ciw.[DaysAfterSowingModified] As 'DDS Modificados'
      ,ciw.[GrowingDegreeDaysAccumulated] As 'GDD Acumulados'
      ,ciw.[GrowingDegreeDaysModified] As 'GDD Modificados'
      ,iu.Name As 'Unidad de Riego'
      ,ciw.[PredeterminatedIrrigationQuantity] As 'Cantidad predeterminada de Riego'
      ,p.Latitude As 'Latitud'
      ,p.Longitude As 'Longitud'
      ,ciw.[LastWaterInputDate] As 'Ultima Fecha de Ingreso'
      ,ciw.[LastBigWaterInputDate] As 'Ultima Fecha de Ingreso Grande'
      ,ciw.[LastPartialWaterInputDate] As 'Ultima Fecha de Ingreso Parcial '
      ,ciw.[LastPartialWaterInput] As 'Ultimo Ingreso Parcial'
      ,ciw.[LastBigGapWaterInputDate] As 'Ultima Fecha del GAP'
      ,mws.Name As 'Estacion Principal'
      ,aws.Name As 'Estacion Alternativa'
      ,ciw.[UsingMainWeatherStation] As 'Utilizando Main WS'
      ,ciw.[TotalEvapotranspirationCrop] As 'Evapotranspiracion Total'
      ,ciw.[TotalEffectiveRain] As 'Lluvia Efectiva Total'
      ,ciw.[TotalRealRain] As 'Lluvia Real Total'
      ,ciw.[TotalIrrigation] As 'Riego Total'
      ,ciw.[TotalIrrigationInHydricBalance] As 'Riego Total en BH'
      ,ciw.[TotalExtraIrrigation] As 'Riego Extra Total'
      ,ciw.[TotalExtraIrrigationInHydricBalance] As 'Riego Extra en BH Total'
      --,ciw.[OutPut] As 'Output'
      --,ciw.[TotalMessageLines] As 'Total de lineas'
      --,ciw.[TotalMessageDailyLines] As 'Total de lineas diarias'
      --,ciw.[TextLog] As 'Log'
  FROM [IrrigationAdvisor].[dbo].[CropIrrigationWeather] ciw
  INNER JOIN [IrrigationAdvisor].[dbo].[Crop] c
  ON c.CropId = ciw.CropId
  INNER JOIN [IrrigationAdvisor].[dbo].[Soil] s
  ON c.CropId = ciw.CropId
  INNER JOIN [IrrigationAdvisor].[dbo].[PhenologicalStage] ps
  ON ps.PhenologicalStageId = ciw.PhenologicalStageId
  INNER JOIN [IrrigationAdvisor].[dbo].[Stage] st
  ON st.StageId = ps.StageId
  INNER JOIN [IrrigationAdvisor].[dbo].[CropInformationByDate] cid
  ON cid.CropInformationByDateId = ciw.CropInformationByDateId
  INNER JOIN [IrrigationAdvisor].[dbo].[IrrigationUnit] iu
  ON s.SoilId = ciw.SoilId
  INNER JOIN [IrrigationAdvisor].[dbo].[Position] p
  ON p.PositionId = ciw.PositionId
  INNER JOIN [IrrigationAdvisor].[dbo].[WeatherStation] mws
  ON mws.WeatherStationId = ciw.MainWeatherStationId
  INNER JOIN [IrrigationAdvisor].[dbo].[WeatherStation] aws
  ON aws.WeatherStationId = ciw.AlternativeWeatherStationId
  
  /*
  
  
  Select *
  From [IrrigationAdvisor].[dbo].[Crop]
 
  Select *
  From [IrrigationAdvisor].[dbo].[Soil]
 
  Select *
  From [IrrigationAdvisor].[dbo].[PhenologicalStage]
 
  Select *
  From [IrrigationAdvisor].[dbo].[CropInformationByDate]
 
  Select *
  From [IrrigationAdvisor].[dbo].[IrrigationUnit]
 
  Select *
  From [IrrigationAdvisor].[dbo].[Position]
 
  Select *
  From [IrrigationAdvisor].[dbo].[WeatherStation]
 
  
  
  SELECT DISTINCT
	  ciw.[CropIrrigationWeatherName] As 'Nombre'
      ,c.ShortName As 'Nombre Cultivo'
      ,s.Name As 'Nombre Suelo'
      ,ciw.[SowingDate] As 'Fecha de Siembra'
      ,ciw.[HarvestDate] As 'Fecha de Cosecha'
      ,[PhenologicalStageId]
      ,ciw.[HydricBalance] As 'Balance Hidrico'
      ,ciw.[SoilHydricVolume] As 'Volumen Hidrico del Suelo'
      ,ciw.[TotalEvapotranspirationCropFromLastWaterInput] As 'Evapotranspiracion Total'
      ,ciw.[CalculusMethodForPhenologicalAdjustment] As 'Metodo de Calculo'
      ,cid.Name As 'Informacion diaria del Cultivo'
      ,ciw.[DaysAfterSowing] As 'DDS'
      ,ciw.[DaysAfterSowingModified] As 'DDS Modificados'
      ,ciw.[GrowingDegreeDaysAccumulated] As 'GDD Acumulados'
      ,ciw.[GrowingDegreeDaysModified] As 'GDD Modificados'
      ,iu.Name As 'Unidad de Riego'
      ,ciw.[PredeterminatedIrrigationQuantity] As 'Cantidad predeterminada de Riego'
      ,p.Latitude As 'Latitud'
      ,p.Longitude As 'Longitud'
      ,ciw.[LastWaterInputDate] As 'Ultima Fecha de Ingreso'
      ,ciw.[LastBigWaterInputDate] As 'Ultima Fecha de Ingreso Grande'
      ,ciw.[LastPartialWaterInputDate] As 'Ultima Fecha de Ingreso Parcial '
      ,ciw.[LastPartialWaterInput] As 'Ultimo Ingreso Parcial'
      ,ciw.[LastBigGapWaterInputDate] As 'Ultima Fecha del GAP'
      ,mws.Name As 'Estacion Principal'
      ,aws.Name As 'Estacion Alternativa'
      ,ciw.[UsingMainWeatherStation] As 'Utilizando Main WS'
      ,ciw.[TotalEvapotranspirationCrop] As 'Evapotranspiracion Total'
      ,ciw.[TotalEffectiveRain] As 'Lluvia Efectiva Total'
      ,ciw.[TotalRealRain] As 'Lluvia Real Total'
      ,ciw.[TotalIrrigation] As 'Riego Total'
      ,ciw.[TotalIrrigationInHydricBalance] As 'Riego Total en BH'
      ,ciw.[TotalExtraIrrigation] As 'Riego Extra Total'
      ,ciw.[TotalExtraIrrigationInHydricBalance] As 'Riego Extra en BH Total'
      --,ciw.[OutPut] As 'Output'
      --,ciw.[TotalMessageLines] As 'Total de lineas'
      --,ciw.[TotalMessageDailyLines] As 'Total de lineas diarias'
      --,ciw.[TextLog] As 'Log'
  FROM [IrrigationAdvisor].[dbo].[CropIrrigationWeather] ciw
  INNER JOIN [IrrigationAdvisor].[dbo].[Crop] c
  ON c.CropId = ciw.CropId
  INNER JOIN [IrrigationAdvisor].[dbo].[Soil] s
  ON c.CropId = ciw.CropId
  INNER JOIN [IrrigationAdvisor].[dbo].[PhenologicalStage] ps
  ON ps.PhenologicalStageId = ciw.PhenologicalStageId
  INNER JOIN [IrrigationAdvisor].[dbo].[Stage] st
  ON st.StageId = ps.StageId
  INNER JOIN [IrrigationAdvisor].[dbo].[CropInformationByDate] cid
  ON cid.CropInformationByDateId = ciw.CropInformationByDateId
  INNER JOIN [IrrigationAdvisor].[dbo].[IrrigationUnit] iu
  ON s.SoilId = ciw.SoilId
  INNER JOIN [IrrigationAdvisor].[dbo].[Position] p
  ON p.PositionId = ciw.PositionId
  INNER JOIN [IrrigationAdvisor].[dbo].[WeatherStation] mws
  ON mws.WeatherStationId = ciw.MainWeatherStationId
  INNER JOIN [IrrigationAdvisor].[dbo].[WeatherStation] aws
  ON aws.WeatherStationId = ciw.AlternativeWeatherStationId
  
  
  */
  