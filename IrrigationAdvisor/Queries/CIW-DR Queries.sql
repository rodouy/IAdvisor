SELECT
	ciw.CropId 
	, ciw.*
  FROM [IrrigationAdvisor].[dbo].[CropIrrigationWeather] ciw

SELECT
	dr.DailyRecordDateTime
	, dr.DaysAfterSowing
	, dr.RainId
	, dr.Rain_WaterInputId
	, dr.IrrigationId
	, dr.Irrigation_WaterInputId 
	, dr.*
  FROM [IrrigationAdvisor].[dbo].[DailyRecord] dr
  Where dr.DailyRecordDateTime > '2019-10-08'
  and dr.CropIrrigationWeatherId = 9
order by dr.DailyRecordDateTime desc
, dr.CropIrrigationWeatherId

select i.*
from IrrigationAdvisor.dbo.Irrigation i
where i.CropIrrigationWeather_CropIrrigationWeatherId = 1

select wi.*
  FROM [IrrigationAdvisor].[dbo].[WaterInput] wi
where wi.CropIrrigationWeatherId = 1


