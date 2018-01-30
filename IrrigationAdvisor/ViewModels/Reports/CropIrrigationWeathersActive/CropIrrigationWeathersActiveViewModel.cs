using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.ViewModels.Irrigation;
using IrrigationAdvisor.ViewModels.Localization;
using IrrigationAdvisor.ViewModels.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.ViewModels.Management;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.ViewModels.Water;
using IrrigationAdvisor.ViewModels.Agriculture;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Irrigation;

namespace IrrigationAdvisor.ViewModels.Home
{
    public class CropIrrigationWeathersActiveViewModel
    {

        #region Consts
        #endregion

        #region Fields

        #endregion

        #region Properties

        public List<FarmViewModel> FarmViewModelList { get; set; }

        public FarmViewModel DefaultFarmViewModel { get; set; }

        public String DefaultFarmLatitude { get; set; }

        public String DefaultFarmLongitude { get; set; }

        public List<IrrigationUnitViewModel> IrrigationUnitViewModelList { get; set; }

        public List<RainViewModel> RainViewModelList { get; set; }

        public List<IrrigationViewModel> IrrigationViewModelList { get; set; }

        public IrrigationUnitViewModel TestIrrigationUnitViewModel { get; set; }

        public List<CropIrrigationWeatherViewModel> CropIrrigationWeatherViewModelList { get; set; }

        public List<DailyRecordViewModel> DailyRecordViewModelList { get; set; }

        public ErrorViewModel ErrorViewModel { get; set; }

        public bool IsUserAdministrator { get; set; }

        public bool IsUserIntermediate { get; set; }

        public DateTime DateOfReference { get; set; }

        public DateTime MinDateOfReference { get; set; }

        public DateTime MaxDateOfReference { get; set; }

        #endregion

        #region Construction


        #endregion




    }
}