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

            try
            {
                IrrigationDataViewModel irrigationDataViewModel = new IrrigationDataViewModel();

                irrigationDataViewModel.Farm = new FarmViewModel()
                {
                    FarmId = 1,
                    Description = "El Venteveo"
                };

                irrigationDataViewModel.ReferenceDate = DateTime.Now;

                IrrigationRow irrigationRow = new IrrigationRow()
                {
                    Crop = "Soja",
                    HarvestDate = DateTime.Now.AddMonths(6),
                    HydricBalance = 51.29m,
                    Kc = 0.5m,
                    Phenology = "R6",
                    Name = "Pivot 1"
                };

                irrigationRow.Advices.Add(new AdviceViewModel()
                {
                    Date = DateTime.Now.AddDays(-2),
                    IrrigationType = "Rain",
                    Quantity = 10
                });

                irrigationRow.Advices.Add(new AdviceViewModel()
                {
                    Date = DateTime.Now.AddDays(3),
                    IrrigationType = "Irrigation",
                    Quantity = 15
                });

                irrigationDataViewModel.IrrigationRows.Add(irrigationRow);

                IrrigationRow irrigationRow2 = new IrrigationRow()
                {
                    Crop = "Soja",
                    HarvestDate = DateTime.Now.AddMonths(6),
                    HydricBalance = 25.32m,
                    Kc = 0.8m,
                    Phenology = "V0",
                    Name = "Pivot 2"
                };

                irrigationRow2.Advices.Add(new AdviceViewModel()
                {
                    Date = DateTime.Now.AddDays(-2),
                    IrrigationType = "Rain",
                    Quantity = 10
                });

                irrigationRow2.Advices.Add(new AdviceViewModel()
                {
                    Date = DateTime.Now.AddDays(4),
                    IrrigationType = "Irrigation",
                    Quantity = 15
                });

                irrigationDataViewModel.IrrigationRows.Add(irrigationRow2);

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
