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
using IrrigationAdvisor.Models.Localization;

namespace IrrigationAdvisor.ViewModels.Reports
{
    public class CropIrrigationWeathersActiveViewModel
    {

        #region Consts
        #endregion

        #region Fields
        private List<Farm> farmList;
        #endregion

        #region Properties

        public List<Farm> FarmList
        {
            get { return farmList; }
            set { farmList = value; }
        }

        #endregion

        #region Construction


        #endregion




    }
}