using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.DBContext.Security;
using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.ViewModels.Reports;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.DBContext.Management;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.Models.Reports;
using IrrigationAdvisor.Models.Management;

using IrrigationAdvisor.Models.Utilities;
using System.Web.Helpers;
using System.Collections;
using IrrigationAdvisor.Models;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;
using System.IO;


using System.Text;


namespace IrrigationAdvisor.Controllers.Reports.ReportIrrigationUnit
{
    public class ReportIrrigationUnitController : Controller
    {

        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        ReportPivotStateViewModel vm = new ReportPivotStateViewModel();
        private static long ciwId = 0;


        public ActionResult Index()
        {
            try
            {
                #region userdata
                User lLoggedUser;
                UserConfiguration uc;
                LoginViewModel lLoginViewModel;
                uc = new UserConfiguration();

                LoginViewModel localLgM = ManageSession.GetLoginViewModel();

                if (localLgM == null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    lLoginViewModel = ManageSession.GetLoginViewModel();
                }
                lLoggedUser = uc.GetUserByName(lLoginViewModel.UserName);
                vm.IsUserAdministrator = (lLoggedUser.RoleId == (int)Utils.UserRoles.Administrator);
                #endregion

                DailyRecordConfiguration drc = new DailyRecordConfiguration();
                CropIrrigationWeatherConfiguration ciwc = new CropIrrigationWeatherConfiguration();
                List<DailyRecord> lDailyRecordList = new List<DailyRecord>();
                double lHydricBalancePercentage = 0;
                double lSumTotalEffectiveRain = 0;
                double lSumTotalEffectiveInputWater = 0;
                double lSumTotalEvapotranspirationCrop = 0;
                string lCropIrrigationWeatherTitle = "";

                ciwId = GetCropIrrigationWeatherIdFromURL();

                lDailyRecordList = drc.GetDailyRecordsListDataUntilDateBy(ciwId, Utils.GetDateOfReference().Value);

                #region get ciw
                List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
                List<long> lListciw = new List<long>();
                lListciw.Add(ciwId);

                lCropIrrigationWeatherList = ciwc.GetCropIrrigationWeatherByIds(lListciw, Utils.GetDateOfReference().Value);

                foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
                {
                    lHydricBalancePercentage = lCropIrrigationWeather.GetPercentageOfHydricBalance();
                }
                #endregion


                foreach (DailyRecord item in lDailyRecordList)
                {
                    if (item.Rain != null)
                        lSumTotalEffectiveRain = lSumTotalEffectiveRain + item.Rain.Input + item.Rain.ExtraInput; ;

                    if (item.Irrigation != null)
                        lSumTotalEffectiveInputWater = lSumTotalEffectiveInputWater + item.Irrigation.Input + item.Irrigation.ExtraInput;

                    lSumTotalEvapotranspirationCrop = item.TotalEvapotranspirationCrop;
                    lCropIrrigationWeatherTitle = item.CropIrrigationWeather.ToString();
                }
                vm.TotalEffectiveRain = lSumTotalEffectiveRain;
                vm.TotalEffectiveInputWater = lSumTotalEffectiveInputWater;
                vm.TotalEvapotranspirationCrop = lSumTotalEvapotranspirationCrop;
                vm.Title = lCropIrrigationWeatherTitle;
                vm.CropIrrigationWeatherId = ciwId;
                vm.HydricBalancePercentage = lHydricBalancePercentage;
                return View("~/Views/ReportPivotState/ReportPivotState.cshtml", vm);
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in ReportPivotState.Index \n {0} ");
                return null;

            }
       }

        
      /// <summary>
      /// Allow export and download info abaout CIW
      /// </summary>
      /// <returns>stream to save file</returns>
        public FileStreamResult CreateAndDownloadFileXLS() 
        {
            try
            {
                CropIrrigationWeatherConfiguration ciwc = new CropIrrigationWeatherConfiguration();

                string lDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                string lOutPut = ciwc.GetOutputByCropIrrigationWeatherId(ciwId);
                string lFileName = ciwc.GetNameByCropIrrigationWeatherId(ciwId);

                lFileName = lFileName + "_" + ".csv";

                var byteArray = Encoding.ASCII.GetBytes(lOutPut);
                var stream = new MemoryStream(byteArray);

                return File(stream, "application/vnd.ms-excel", lFileName);
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in ReportPivotState.CreateAndDownloadFileXLS \n {0} ");
                return null;
            }
        }



        [ChildActionOnly]
        public PartialViewResult ReportPivotStateHeaderPartial()
        {
            return PartialView("_ReportPivotStateHeaderPartial", GetGridDailyRecordIrrigationResumeTitles());
        }

        [ChildActionOnly]
        public PartialViewResult ReportPivotStatePartial()
        {
            return PartialView("_ReportPivotStatePartial", GetGridDailyRecordIrrigationResume());
        }

        /// <summary>
        /// Return Grid Datail from dailyrecord days
        /// </summary>
        /// <returns></returns>
        public List<GridDailyRecordIrrigationResume> GetGridDailyRecordIrrigationResumeTitles()
        {

            #region Local Variables
            List<GridDailyRecordIrrigationResume> lGridDailyRecordIrrigationResumeList = new List<GridDailyRecordIrrigationResume>();
            GridDailyRecordIrrigationResume lGridDailyRecordIrrigationResume;
            #endregion

            #region Configuration Variables
            UserConfiguration uc;
            #endregion

            try
            {

                #region Configuration - Instance
                uc = new UserConfiguration();
                #endregion

                lGridDailyRecordIrrigationResume = new GridDailyRecordIrrigationResume("Día", "Fecha", "Riego", "Lluvia");
                lGridDailyRecordIrrigationResumeList.Add(lGridDailyRecordIrrigationResume);

            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in ReportPivotState.GetGridDailyRecordIrrigationResumeTitles");
                return null;
            }

            return lGridDailyRecordIrrigationResumeList;

        }


        /// <summary>
        /// Return Grid Datail from dailyrecord days
        /// </summary>
        /// <returns></returns>
        public List<GridDailyRecordIrrigationResume> GetGridDailyRecordIrrigationResume()
        {
            #region Local Variables

            List<GridDailyRecordIrrigationResume> lGridIrrigationUnitList = new List<GridDailyRecordIrrigationResume>();
            List<GridDailyRecordIrrigationResume> lGridDailyRecordIrrigationResumeList = new List<GridDailyRecordIrrigationResume>();
            GridDailyRecordIrrigationResume lGridDailyRecordIrrigationResume = null;

            string lEffectiveRain;
            string lEffectiveInputWater;
            double lEffectiveRainDouble;
            double lEffectiveInputWaterDouble;

            List<DailyRecord> lDailyRecordList;
            DailyRecordConfiguration drc;
            #endregion

            try
            {
                drc = new DailyRecordConfiguration();

                lDailyRecordList = drc.GetDailyRecordsListDataUntilDateBy(ciwId, Utils.GetDateOfReference().Value);

                foreach (var lDailyRecordUnit in lDailyRecordList)
                {
                    lEffectiveRain = "";
                    lEffectiveInputWater = "";
                    lEffectiveRainDouble = 0;
                    lEffectiveInputWaterDouble = 0;

                    if (lDailyRecordUnit.Rain != null)
                    {
                        lEffectiveRainDouble = lDailyRecordUnit.Rain.ExtraInput + lDailyRecordUnit.Rain.Input;
                    }

                    if (lDailyRecordUnit.Irrigation != null)
                    {
                        lEffectiveInputWaterDouble = lDailyRecordUnit.Irrigation.ExtraInput + lDailyRecordUnit.Irrigation.Input;
                    }
                    if (lEffectiveRainDouble + lEffectiveInputWaterDouble > 0) // not input
                    {
                        if (lEffectiveRainDouble != 0)
                            lEffectiveRain = lEffectiveRainDouble.ToString();

                        if (lEffectiveInputWaterDouble != 0)
                            lEffectiveInputWater = lEffectiveInputWaterDouble.ToString();

                        lGridDailyRecordIrrigationResume = new GridDailyRecordIrrigationResume(lDailyRecordUnit.DaysAfterSowing.ToString(), lDailyRecordUnit.DailyRecordDateTime.ToShortDateString(), lEffectiveRain, lEffectiveInputWater);
                        lGridDailyRecordIrrigationResumeList.Add(lGridDailyRecordIrrigationResume);

                    }
                }
            }


            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in ReportPivotState.GetGridDailyRecordIrrigationResume \n {0} ");
                return null;
            }

            return lGridDailyRecordIrrigationResumeList;

        }

        private long GetCropIrrigationWeatherIdFromURL()
        {
            try
            {
                long retorno = 0;

                string lURL = System.Web.HttpContext.Current.Request.Url.AbsoluteUri;
                Uri lMyUri = new Uri(lURL);
                string lcurrentCiwViaUrl = System.Web.HttpUtility.ParseQueryString(lMyUri.Query).Get("ciw");

                if (!String.IsNullOrEmpty(lcurrentCiwViaUrl))
                {
                    ciwId = Convert.ToInt32(lcurrentCiwViaUrl);
                    retorno = ciwId;
                }
                else
                {
                    retorno = ciwId;
                }
                return ciwId;
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in ReportPivotState.GetGridDailyRecordIrrigationResume \n {0} ");
                return 0;
            }
        }

    }
}
