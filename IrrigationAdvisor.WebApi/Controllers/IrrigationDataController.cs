using IrrigationAdvisor.Controllers;
using IrrigationAdvisor.ViewModels.Water;
using IrrigationAdvisor.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IrrigationAdvisor.WebApi.Controllers
{
    [RoutePrefix("api/IrrigationData")]
    public class IrrigationDataController : ApiController
    {
        [Route("token/{token}/farmId/{farmId:int}")]
        public OperationResult<IrrigationDataViewModel> Get(string token, int farmId)
        {
            OperationResult<IrrigationDataViewModel> result = new OperationResult<IrrigationDataViewModel>();

            IrrigationAdvisorWebApiEntities1 context = new IrrigationAdvisorWebApiEntities1();

            try
            {
                IrrigationDataViewModel irrigationDataViewModel = new IrrigationDataViewModel();

                var farm = context.Farms.Where(n => n.FarmId == farmId).Single();

                irrigationDataViewModel.Farm = new FarmViewModel()
                {
                    FarmId = farmId,
                    Description = farm.Name
                };

                var status = context.Status.Where(n => n.Name == "Production").Single();

                irrigationDataViewModel.ReferenceDate = status.DateOfReference;

                var irrigationRows = (from ciw in context.CropIrrigationWeathers
                                     join iu in context.IrrigationUnits
                                     on ciw.IrrigationUnitId equals iu.IrrigationUnitId
                                     join f in context.Farms
                                     on iu.FarmId equals f.FarmId
                                     join c in context.Crops
                                     on ciw.CropId equals c.CropId
                                     join p in context.PhenologicalStages
                                     on ciw.PhenologicalStageId equals p.PhenologicalStageId
                                     join s in context.Stages
                                     on p.StageId equals s.StageId
                                     where  f.FarmId == farmId
                                     select new {   IrrigationUnit = iu,
                                                    CropIrrigationWeather = ciw,
                                                    Crop = c,
                                                    Stage = s}).ToList();

                foreach (var row in irrigationRows)
                {                  
                    IrrigationRow irrigationRow = new IrrigationRow()
                    {
                        IrrigationUnitId = row.IrrigationUnit.IrrigationUnitId,
                        Crop = row.Crop.Name,
                        HarvestDate = row.CropIrrigationWeather.HarvestDate,
                        HydricBalance = Math.Round(row.CropIrrigationWeather.HydricBalance, 2),
                        Kc = 0,
                        Phenology = row.Stage.Name,
                        Name = row.IrrigationUnit.Name
                    };

                    DateTime minorDate = status.DateOfReference.AddDays(-3);
                    DateTime mayorDate = status.DateOfReference.AddDays(5);

                    var dailyRecords = context.DailyRecords.Where(n => n.CropIrrigationWeatherId == row.CropIrrigationWeather.CropIrrigationWeatherId && 
                                                                 (n.DailyRecordDateTime <= mayorDate && 
                                                                 n.DailyRecordDateTime >= minorDate)).Distinct().ToList();
                    irrigationRow.Kc = dailyRecords
                                        .OrderByDescending(n => n.DailyRecordDateTime)
                                        .First().CropCoefficient;

                    foreach (var daily in dailyRecords)
                    {
                        if (daily.RainId > 0)
                        {
                            var rain = context.WaterInputs.SingleOrDefault(n => n.WaterInputId == daily.RainId);

                            if (rain != null && (rain.Input > 0 || rain.ExtraInput > 0))
                            {
                                irrigationRow.Advices.Add(new AdviceViewModel()
                                {
                                    Date = daily.DailyRecordDateTime,
                                    IrrigationType = "Rain",
                                    Quantity = rain.Input > 0 ? rain.Input : rain.ExtraInput
                                });
                            }                          
                        }
                        else if (daily.IrrigationId > 0)
                        {
                            var irrigation = context.WaterInputs.SingleOrDefault(n => n.WaterInputId == daily.IrrigationId);

                            if (irrigation != null && (irrigation.Input > 0 || irrigation.ExtraInput > 0))
                            {                               
                                irrigationRow.Advices.Add(new AdviceViewModel()
                                {
                                    Date = daily.DailyRecordDateTime,
                                    IrrigationType = "Irrigation",
                                    Quantity = irrigation.Input > 0 ? irrigation.Input : irrigation.ExtraInput
                                });
                            }                     
                        }                    
                    }
                    
                    irrigationDataViewModel.IrrigationRows.Add(irrigationRow);
                }

                result.IsOk = true;
                result.Data = irrigationDataViewModel;

            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        [HttpPost]
        [Route("AddIrrigation")]
        public OperationResult<string> AddIrrigation([FromBody] AddIrrigationOrRainValues values)
        {
            OperationResult<string> result = new OperationResult<string>();

            try
            {
                HomeController home = new HomeController();

                foreach (var irrigationUnitId in values.IrrigationUnitId)
                {
                    home.AddIrrigation(values.Milimeters, irrigationUnitId, values.Date.Day, values.Date.Month, values.Date.Year, false, true);
                }
                
                result.IsOk = true;    
            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        [HttpPost]
        [Route("AddRain")]
        public OperationResult<string> AddRain([FromBody] AddIrrigationOrRainValues values)
        {
            OperationResult<string> result = new OperationResult<string>();

            try
            {
                HomeController home = new HomeController();

                foreach (var irrigationUnitId in values.IrrigationUnitId)
                {
                    home.AddRain(values.Milimeters, irrigationUnitId, values.Date.Day, values.Date.Month, values.Date.Year, true);
                }

                result.IsOk = true;
            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        [HttpPost]
        [Route("AddIrrigationAndRain")]
        public OperationResult<string> AddIrrigationAndRain([FromBody] WebApiIrrigationRainViewModel values)
        {
            OperationResult<string> result = new OperationResult<string>();

            try
            {
                if (values != null)
                {
                    HomeController home = new HomeController();
                    home.AddIrrigationAndRain(values);
                }

                result.IsOk = true;
            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }
    }
}
