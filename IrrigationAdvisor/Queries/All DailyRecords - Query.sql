/****** Script for SelectTopNRows command from SSMS  ******/
SELECT dr.[DailyRecordId] As 'Id'
      , Convert(date, [DailyRecordDateTime]) As 'Fecha'
      ,dr.[MainWeatherDataId] As 'ClimaPpalId'
      ,CASE WHEN ISNULL(dr.[MainWeatherDataId],0) > 0 THEN
		mwd.[Temperature] ELSE 0 END As 'Temp PPAL'
      ,CASE WHEN ISNULL(dr.[MainWeatherDataId],0) > 0 THEN
		mwd.[Evapotranspiration] ELSE 0 END As 'ET PPAL'
      ,CASE WHEN ISNULL(dr.[MainWeatherDataId],0) > 0 THEN
		mwd.[UVRadiation] ELSE 0 END As 'Radiacion PPAL'
      ,dr.[AlternativeWeatherDataId] As 'ClimaAltId'
      ,CASE WHEN ISNULL(dr.[AlternativeWeatherDataId],0) > 0 THEN
		awd.[Temperature] ELSE 0 END As 'Temp ALT'
      ,CASE WHEN ISNULL(dr.[AlternativeWeatherDataId],0) > 0 THEN
		awd.[Evapotranspiration] ELSE 0 END As 'ET ALT'
      ,CASE WHEN ISNULL(dr.[AlternativeWeatherDataId],0) > 0 THEN
		awd.[UVRadiation] ELSE 0 END As 'Radiacion ALT'
      ,dr.[DaysAfterSowing] As 'DDS'
      ,dr.[DaysAfterSowingModified] As 'DDS Mod'
      ,ROUND(dr.[GrowingDegreeDays],2) As 'GDD'
      ,ROUND(dr.[GrowingDegreeDaysAccumulated],2) As 'GDD Ac'
      ,ROUND(dr.[GrowingDegreeDaysModified],2) As 'GDD Mod'
      ,CASE WHEN ISNULL(dr.[RainId],0) > 0 THEN
		ISNULL(wiR.[Input],0) + ISNULL(wiR.[ExtraInput],0) 
		ELSE 0 END AS 'Agua Lluvia'
      ,CASE WHEN ISNULL(dr.[IrrigationId],0) > 0 THEN
		ISNULL(wiI.[Input],0) + ISNULL(wiI.[ExtraInput],0)
		ELSE 0 END AS 'Agua Riego'
      ,Convert(date, dr.[LastWaterInputDate]) As 'Ultimo Ingreso de Agua'
      ,Convert(date, dr.[LastBigWaterInputDate]) As 'Ultimo Gran ingreso de agua'
      ,Convert(date, dr.[LastPartialWaterInputDate]) As 'Ultimo Ingreso Parcial de Agua'
      ,dr.[LastPartialWaterInput] As 'Cantidad de Agua Parcial'
      ,Convert(date, dr.[LastBigGapWaterInputDate]) As 'Ultimo gran aumento de agua'
      ,CASE WHEN ISNULL(dr.[EvapotranspirationCropId],0) > 0 THEN
		ISNULL(woE.[Output],0) + ISNULL(woE.[ExtraOutput],0)
		ELSE 0 END AS 'ETc ' 
      ,dr.[TotalEffectiveInputWater] As 'Ingreso de Agua Efectiva'
      ,dr.[PercentageOfHydricBalance] As 'Porcentaje de BH'
      ,ROUND([GAPPercentageOfHydricBalance], 2) As 'Aumento de BH'
      ,st.Name 'Estadio Fenologico'
      ,dr.[HydricBalance] As 'Balance Hidrico'
      ,dr.[SoilHydricVolume] As 'Volumen Hidrico del Suelo'
      ,dr.[TotalEvapotranspirationCropFromLastWaterInput] As 'Evapotranspiracion Total desde el ultimo ingreso de agua'
      ,dr.[CropCoefficient] As 'KC'
      ,dr.[Observations] As 'Observaciones'
      ,dr.[TotalEvapotranspirationCrop] As 'Evapotranspiracion Total'
      ,dr.[TotalEffectiveRain] As 'Total Lluvia Efectiva'
      ,dr.[TotalRealRain] As 'Total Lluvia Real'
      ,dr.[TotalIrrigation] As 'Total Riego'
      ,dr.[TotalIrrigationInHydricBalance] As 'Total Riego en BH'
      ,dr.[TotalExtraIrrigation] As 'Total Riego Extra'
      ,dr.[TotalExtraIrrigationInHydricBalance] As 'Total Riego Extra en BH'
      --,[AlternativeWeatherData_WeatherDataId] As ''
      --,[EvapotranspirationCrop_WaterOutputId] As ''
      --,[Irrigation_WaterInputId] As ''
      --,[MainWeatherData_WeatherDataId] As ''
      --,[Rain_WaterInputId] As ''
      ,dr.[CropIrrigationWeatherId] As 'CIW'
      ,ciw.[CropIrrigationWeatherName] As 'Nombre'
      ,c.ShortName As 'Nombre Cultivo'
      --,
  FROM [IrrigationAdvisor].[dbo].[DailyRecord] dr
  INNER JOIN [IrrigationAdvisor].[dbo].[PhenologicalStage] ps
    ON ps.PhenologicalStageId = dr.[PhenologicalStageId]
  INNER JOIN [IrrigationAdvisor].[dbo].[Stage] st
	ON st.StageId = ps.[StageId]
  INNER JOIN [IrrigationAdvisor].[dbo].[CropIrrigationWeather] ciw
    ON dr.[CropIrrigationWeatherId] = ciw.[CropIrrigationWeatherId]
  INNER JOIN [IrrigationAdvisor].[dbo].[Crop] c
    ON c.CropId = ciw.CropId
  LEFT JOIN [IrrigationAdvisor].[dbo].[WeatherData] mwd 
	ON dr.[MainWeatherDataId] = mwd.[WeatherDataId]
  LEFT JOIN [IrrigationAdvisor].[dbo].[WeatherData] awd 
	ON dr.[AlternativeWeatherDataId] = awd.[WeatherDataId]
  LEFT JOIN [IrrigationAdvisor].[dbo].[WaterInput] wiR
	ON dr.[RainId] = wiR.[WaterInputId]
  LEFT JOIN [IrrigationAdvisor].[dbo].[WaterInput] wiI
	ON dr.[IrrigationId] = wiI.[WaterInputId]
  LEFT JOIN [IrrigationAdvisor].[dbo].[WaterOutput] woE
	ON dr.[EvapotranspirationCropId] = woE.[WaterOutputId]
WHERE dr.[CropIrrigationWeatherId] = 1
ORDER BY dr.[CropIrrigationWeatherId], dr.[DailyRecordDateTime]
  