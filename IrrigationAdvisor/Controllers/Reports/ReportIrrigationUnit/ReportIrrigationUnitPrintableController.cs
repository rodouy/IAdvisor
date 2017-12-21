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
using IrrigationAdvisor.Models.Reports.ReportIrrigationUnit;
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
    public class ReportIrrigationUnitPrintableController : Controller
    {

        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        ReportIrrigationUnitViewModel vm = new ReportIrrigationUnitViewModel();
        private static long ciwId = 0;
        Farm lCurrentFarm;

        public ActionResult Index()
        {
            try
            {
               
                DailyRecordConfiguration drc = new DailyRecordConfiguration();

                List<DailyRecord> lDailyRecordList = new List<DailyRecord>();

                ciwId = GetCropIrrigationWeatherIdFromURL();
                
                lDailyRecordList = drc.GetDailyRecordsListDataUntilDateBy(ciwId, Utils.GetDateOfReference().Value);
                //fc.GetFarmBy (lDailyRecordList.)
                foreach (DailyRecord item in lDailyRecordList)
                {
                    vm.CropIrrigationWeatherId = ciwId;
                    vm.Title = item.CropIrrigationWeather.ToString();

                }

                return View("~/Views/Reports/ReportIrrigationUnit/ReportIrrigationUnitPrintable.cshtml", vm);
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in ReportIrrigationUnit.Index \n {0} ");
                return null;

            }
       }

        
        [ChildActionOnly]
        public PartialViewResult ReportIrrigationUnitHeaderPartial()
        {
            return PartialView("~/Views/Reports/ReportIrrigationUnit/_ReportIrrigationUnitHeaderPartial.cshtml", GetGridDailyRecordIrrigationResumeTitles());
        }

        [ChildActionOnly]
        public PartialViewResult ReportIrrigationUnitPartial()
        {
            return PartialView("~/Views/Reports/ReportIrrigationUnit/_ReportIrrigationUnitPartial.cshtml", GetGridDailyRecordIrrigationResume());
        }

        /// <summary>
        /// Return Grid Datail from dailyrecord days
        /// </summary>
        /// <returns></returns>
        public List<GridReportIrrigationUnit> GetGridDailyRecordIrrigationResumeTitles()
        {

            #region Local Variables
            List<GridReportIrrigationUnit> lGridDailyRecordIrrigationResumeList = new List<GridReportIrrigationUnit>();
            GridReportIrrigationUnit lGridReportIrrigationUnit;
            bool lIsUserAdministrator;
            #endregion

            #region Configuration Variables
            UserConfiguration uc;
            #endregion

            try
            {

                #region userdata
                User lLoggedUser;
                LoginViewModel lLoginViewModel;
                uc = new UserConfiguration();

                LoginViewModel localLgM = ManageSession.GetLoginViewModel();
                lLoginViewModel = ManageSession.GetLoginViewModel();
                lLoggedUser = uc.GetUserByName(lLoginViewModel.UserName);

                lIsUserAdministrator = (lLoggedUser.RoleId == (int)Utils.UserRoles.Administrator);
                #endregion

                #region Configuration - Instance
                uc = new UserConfiguration();
                              
                FarmConfiguration fc = new FarmConfiguration();
                #endregion

                lCurrentFarm = fc.GetFarmBy(ciwId);

                lGridReportIrrigationUnit = new GridReportIrrigationUnit("Día", "Fecha", "Riego", "Lluvia", "Temp. promedio", "ETC", "Balance hídrico", "Fenología", "KC", lCurrentFarm.IrrigationUnitReportShowEvapotranspiration, lCurrentFarm.IrrigationUnitReportShowTemperature, lCurrentFarm.IrrigationUnitReportShowAvailableWater, lIsUserAdministrator);

                lGridDailyRecordIrrigationResumeList.Add(lGridReportIrrigationUnit);

            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in ReportIrrigationUnit.GetGridDailyRecordIrrigationResumeTitles");
                return null;
            }

            return lGridDailyRecordIrrigationResumeList;

        }


        /// <summary>
        /// Return Grid Datail from dailyrecord days
        /// </summary>
        /// <returns></returns>
        public List<GridReportIrrigationUnit> GetGridDailyRecordIrrigationResume()
        {
         
            #region Local Variables

            List<GridReportIrrigationUnit> lGridIrrigationUnitList = new List<GridReportIrrigationUnit>();
            List<GridReportIrrigationUnit> lGridDailyRecordIrrigationResumeList = new List<GridReportIrrigationUnit>();
            GridReportIrrigationUnit lGridReportIrrigationUnit = null;

            string lEffectiveRain;
            string lEffectiveInputWater;
            double lEffectiveRainDouble;
            double lEffectiveInputWaterDouble;
            double lTemperature;
            double lStationTemperatureInDR; 
 
            List<DailyRecord> lDailyRecordList;


            bool lIsUserAdministrator;
            #endregion
             try
            {  


                #region Configuration Variables
                DailyRecordConfiguration drc;
                UserConfiguration uc;
                FarmConfiguration fc;
                #endregion

                #region userdata
                User lLoggedUser;
                LoginViewModel lLoginViewModel;
                uc = new UserConfiguration();

                LoginViewModel localLgM = ManageSession.GetLoginViewModel();
                lLoginViewModel = ManageSession.GetLoginViewModel();
                lLoggedUser = uc.GetUserByName(lLoginViewModel.UserName);

                lIsUserAdministrator = (lLoggedUser.RoleId == (int)Utils.UserRoles.Administrator);
                #endregion

                #region Configuration - Instance
                uc = new UserConfiguration();
                drc = new DailyRecordConfiguration();
                fc = new FarmConfiguration();
                #endregion

                lCurrentFarm = fc.GetFarmBy(ciwId);

                lDailyRecordList = drc.GetDailyRecordsListWithTemperatureDataUntilDateBy(ciwId, Utils.GetDateOfReference().Value);

                foreach (var lDailyRecordItem in lDailyRecordList)
                {
                    lEffectiveRain = "";
                    lEffectiveInputWater = "";
                    lEffectiveRainDouble = 0;
                    lEffectiveInputWaterDouble = 0;

                    if (lDailyRecordItem.Rain != null)
                    {
                        lEffectiveRainDouble = lDailyRecordItem.Rain.ExtraInput + lDailyRecordItem.Rain.Input;
                    }

                    if (lDailyRecordItem.Irrigation != null)
                    {
                        lEffectiveInputWaterDouble = lDailyRecordItem.Irrigation.ExtraInput + lDailyRecordItem.Irrigation.Input;
                    }
                    if (lEffectiveRainDouble + lEffectiveInputWaterDouble > 0) // not input
                    {
                        if (lEffectiveRainDouble != 0)
                            lEffectiveRain = lEffectiveRainDouble.ToString();
                        if (lEffectiveInputWaterDouble != 0)
                            lEffectiveInputWater = lEffectiveInputWaterDouble.ToString();

                        #region temperature to show
                                               
                        if (lDailyRecordItem.MainWeatherDataId > 0) // Get temperature from MainWeatherDataId
                            lStationTemperatureInDR = lDailyRecordItem.MainWeatherDataId;
                        else
                            lStationTemperatureInDR = lDailyRecordItem.AlternativeWeatherDataId;

                        lTemperature = db.WeatherDatas
                                .Where(wd => wd.WeatherDataId == lStationTemperatureInDR)
                                    .Select(wd => wd.Temperature).FirstOrDefault();
                        #endregion

                            lGridReportIrrigationUnit = new GridReportIrrigationUnit(lDailyRecordItem.DaysAfterSowing.ToString(),
                                                                                    lDailyRecordItem.DailyRecordDateTime.ToShortDateString(), 
                                                                                    lEffectiveRain, 
                                                                                    lEffectiveInputWater,
                                                                                    lTemperature.ToString(),
                                                                                    lDailyRecordItem.TotalEvapotranspirationCrop.ToString(),
                                                                                    lDailyRecordItem.PercentageOfHydricBalance.ToString(),
                                                                                    lDailyRecordItem.PhenologicalStage.Stage.ShortName,
                                                                                    lDailyRecordItem.CropCoefficient.ToString(),
                                                lCurrentFarm.IrrigationUnitReportShowEvapotranspiration, lCurrentFarm.IrrigationUnitReportShowTemperature, lCurrentFarm.IrrigationUnitReportShowAvailableWater, 
                                                lIsUserAdministrator);

                        lGridDailyRecordIrrigationResumeList.Add(lGridReportIrrigationUnit);
                    }
                }
            }


            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in ReportIrrigationUnitPrintable.GetGridDailyRecordIrrigationResume \n {0} ");
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
                Utils.LogError(ex, "Exception in ReportIrrigationUnitPrintable.GetGridDailyRecordIrrigationResume \n {0} ");
                return 0;
            }
        }

    }
}
