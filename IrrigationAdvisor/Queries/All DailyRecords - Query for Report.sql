SELECT --dr.[DailyRecordId] As 'Id'
      --,dr.[CropIrrigationWeatherId] As 'CIW'
      --,
      ciw.[CropIrrigationWeatherName] As 'Nombre'
      ,c.ShortName As 'Nombre Cultivo'
      , Convert(date, [DailyRecordDateTime]) As 'Fecha'
      ,CASE WHEN ISNULL(dr.[MainWeatherDataId],0) > 0 THEN 'PPAL'
		    WHEN ISNULL(dr.[AlternativeWeatherDataId],0) > 0 THEN 'ALT' 
	    ELSE 'NO DATA' END As 'Tipo Clima'
      ,CASE WHEN ISNULL(dr.[MainWeatherDataId],0) > 0 THEN mwd.[Temperature] 
			WHEN ISNULL(dr.[AlternativeWeatherDataId],0) > 0 THEN awd.[Temperature] 
		ELSE 0 END As 'Temp '
      ,CASE WHEN ISNULL(dr.[MainWeatherDataId],0) > 0 THEN mwd.[Evapotranspiration] 
			WHEN ISNULL(dr.[AlternativeWeatherDataId],0) > 0 THEN awd.[Evapotranspiration] 
		ELSE 0 END As 'ET '
      ,CASE WHEN ISNULL(dr.[MainWeatherDataId],0) > 0 THEN mwd.[UVRadiation] 
			WHEN ISNULL(dr.[AlternativeWeatherDataId],0) > 0 THEN awd.[UVRadiation] 
		ELSE 0 END As 'Radiacion '
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
      ,dr.[LastPartialWaterInput] As 'Agua Parcial'
      ,Convert(date, dr.[LastWaterInputDate]) As 'Ultimo Ingreso de Agua'
      ,Convert(date, dr.[LastBigWaterInputDate]) As 'Ultimo Gran ingreso de agua'
      ,Convert(date, dr.[LastPartialWaterInputDate]) As 'Ultimo Ingreso Parcial de Agua'
      ,Convert(date, dr.[LastBigGapWaterInputDate]) As 'Ultimo gran aumento de agua'
  --    ,CASE WHEN ISNULL(dr.[EvapotranspirationCropId],0) > 0 THEN
		--ISNULL(woE.[Output],0) + ISNULL(woE.[ExtraOutput],0)
		--ELSE 0 END AS 'ETc ' 
      ,dr.[TotalEffectiveInputWater] As 'Ingreso de Agua Efectiva'
      ,dr.[PercentageOfHydricBalance] As 'Porcentaje de BH'
      ,ROUND([GAPPercentageOfHydricBalance], 2) As 'Aumento de BH'
      ,st.Name 'Estadio Fenologico'
      ,dr.[HydricBalance] As 'Balance Hidrico'
      --,dr.[SoilHydricVolume] As 'Volumen Hidrico del Suelo'
      ,dr.[TotalEvapotranspirationCropFromLastWaterInput] As 'Evapotranspiracion Total desde el ultimo ingreso de agua'
      ,dr.[CropCoefficient] As 'KC'
      ,dr.[Observations] As 'Observaciones'
      ,ROUND(dr.[TotalEvapotranspirationCrop],2) As 'Evapotranspiracion Total'
      ,ROUND(dr.[TotalEffectiveRain],2) As 'Total Lluvia Efectiva'
      ,ROUND(dr.[TotalRealRain],2) As 'Total Lluvia Real'
      ,ROUND(dr.[TotalIrrigation],2) As 'Total Riego'
      ,ROUND(dr.[TotalIrrigationInHydricBalance],2) As 'Total Riego en BH'
      ,ROUND(dr.[TotalExtraIrrigation],2) As 'Total Riego Extra'
      ,ROUND(dr.[TotalExtraIrrigationInHydricBalance],2) As 'Total Riego Extra en BH'
      --,[AlternativeWeatherData_WeatherDataId] As ''
      --,[EvapotranspirationCrop_WaterOutputId] As ''
      --,[Irrigation_WaterInputId] As ''
      --,[MainWeatherData_WeatherDataId] As ''
      --,[Rain_WaterInputId] As ''
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
  