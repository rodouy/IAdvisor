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

namespace IrrigationAdvisor.Controllers.Reports
{
    public class ReportPivotStatePrintableController : Controller
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
                vm.HydricBalancePercentage = lHydricBalancePercentage;
                return View("~/Views/ReportPivotState/ReportPivotStatePrintable.cshtml", vm);
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in ReportPivotStatePrintableController.Index \n {0} ");
                return null;

            }
        }

        #region manage chart

        public ActionResult GetChart()
        {

            DailyRecordConfiguration drc = new DailyRecordConfiguration();
            List<DailyRecord> lDailyRecordList = new List<DailyRecord>();
            double lRain;
            double lIrrigation;

            lDailyRecordList = drc.GetDailyRecordsListDataUntilDateBy(ciwId, Utils.GetDateOfReference().Value);

            try
            {
                ArrayList yArrayRain = new ArrayList();
                ArrayList yArrayIrrigation = new ArrayList();
                ArrayList yArrayETC = new ArrayList();
                ArrayList xDaysAfterSowing = new ArrayList();

                foreach (DailyRecord item in lDailyRecordList)
                {
                    lRain = 0;
                    lIrrigation = 0;
                    if (item.Rain != null)
                        lRain = item.Rain.Input + item.Rain.ExtraInput;
                    if (item.Irrigation != null)
                        lIrrigation = item.Irrigation.ExtraInput + item.Irrigation.Input;

                    yArrayIrrigation.Add(lIrrigation);
                    yArrayRain.Add(lRain);
                    yArrayETC.Add(Math.Round(item.TotalEvapotranspirationCrop, 1));
                    xDaysAfterSowing.Add(item.DaysAfterSowing);
                }

                System.Web.UI.DataVisualization.Charting.Chart chart = new System.Web.UI.DataVisualization.Charting.Chart();
                chart.Width = 1000;
                chart.Height = 450;
                chart.Titles.Add("Evolución de la ETc acumulada y distribucion de las lluvias y riegos, expresadas en mm de lámina bruta");
                chart.BackColor = Color.FromArgb(210, 240, 204);
                chart.BorderlineDashStyle = ChartDashStyle.Solid;
                chart.BackSecondaryColor = Color.White;
                chart.BackGradientStyle = GradientStyle.TopBottom;
                chart.BorderlineWidth = 1;
                chart.Palette = ChartColorPalette.BrightPastel;
                chart.BorderlineColor = Color.FromArgb(26, 59, 105);
                chart.RenderType = RenderType.BinaryStreaming;
                chart.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
                chart.AntiAliasing = AntiAliasingStyles.All;
                chart.TextAntiAliasingQuality = TextAntiAliasingQuality.Normal;
                chart.Series.Add(CreateSeries(yArrayETC, xDaysAfterSowing, "ETc acumulada", SeriesChartType.Line, Color.FromArgb(246, 134, 36), AxisType.Primary));
                chart.Series.Add(CreateSeries(yArrayRain, xDaysAfterSowing, "Lluvia", SeriesChartType.Column, Color.FromArgb(74, 164, 209), AxisType.Secondary));
                chart.Series.Add(CreateSeries(yArrayIrrigation, xDaysAfterSowing, "Riego", SeriesChartType.Column, Color.FromArgb(97, 209, 74), AxisType.Secondary));
                chart.ChartAreas.Add(CreateChartArea());

                chart.Legends.Add("d");
                chart.Legends["d"].Docking = Docking.Bottom;

                MemoryStream ms = new MemoryStream();
                chart.SaveImage(ms);
                return File(ms.GetBuffer(), @"image/png");
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in ReportPivotStatePrintableController.GetChart \n {0} ");
                return null;

            }

        }

        private Series CreateSeries(ArrayList pYArray, ArrayList pXArray, string pTitle, SeriesChartType pChartType, Color pColor, AxisType pAxisType)
        {
            Series seriesDetail = new Series();
            seriesDetail.Name = pTitle;

            seriesDetail.Color = pColor;
            seriesDetail.ChartType = pChartType;
            seriesDetail.BorderWidth = 2;

            DataPoint point;
            int i = 0;
            foreach (var item in pYArray)
            {
                point = new DataPoint();
                point.AxisLabel = pXArray[i].ToString();
                point.YValues = new double[] { double.Parse(item.ToString().ToString()) };
                seriesDetail.Points.Add(point);
                i++;
            }

            //hide label value if zero in the chart
            if (pAxisType == AxisType.Primary)
            {
                seriesDetail.IsValueShownAsLabel = false;
            }
            else
            {
                foreach (System.Web.UI.DataVisualization.Charting.DataPoint p in seriesDetail.Points)
                {
                    p.IsValueShownAsLabel = true;
                    if (p.YValues.Length > 0 && (double)p.YValues.GetValue(0) == 0)
                    {
                        p.IsValueShownAsLabel = false;

                    }
                }
            }
            seriesDetail.YAxisType = pAxisType;
            return seriesDetail;
        }


        private ChartArea CreateChartArea()
        {
            ChartArea chartArea = new ChartArea();
            chartArea.Name = "ResultChart";
            chartArea.BackColor = Color.Transparent;
            chartArea.AxisX.IsLabelAutoFit = true;
            chartArea.AxisX.LabelStyle.Font = new Font("Verdana,Arial,Helvetica,sans-serif", 8F, FontStyle.Regular);
            chartArea.AxisX.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.Title = "Días desde la siembra";


            chartArea.AxisY.IsLabelAutoFit = true;
            chartArea.AxisY.LabelStyle.Font = new Font("Verdana,Arial,Helvetica,sans-serif", 8F, FontStyle.Regular);
            chartArea.AxisY.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(250, 250, 254);
            chartArea.AxisY.Interval = 10;
            chartArea.AxisY.Title = "Evotranspiración acumulada (mm)";

            chartArea.AxisY2.IsLabelAutoFit = true;
            chartArea.AxisY2.LabelStyle.Font = new Font("Verdana,Arial,Helvetica,sans-serif", 8F, FontStyle.Regular);
            chartArea.AxisY2.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea.AxisY2.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea.AxisY2.Title = "Distribución de lluvias y riegos (mm)";
            chartArea.AxisY2.Interval = 10;
            chartArea.AxisY2.Enabled = AxisEnabled.True;

            return chartArea;
        }
        #endregion

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
               
                lGridDailyRecordIrrigationResume = new GridDailyRecordIrrigationResume("Día","Fecha", "Riego", "Lluvia");
                lGridDailyRecordIrrigationResumeList.Add(lGridDailyRecordIrrigationResume);

            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in ReportPivotStatePrintableController.GetGridDailyRecordIrrigationResumeTitles");
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

                lDailyRecordList = drc.GetDailyRecordsListDataUntilDateBy(ciwId, Utils.GetDateOfReference().Value); ;

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

                        lGridDailyRecordIrrigationResume = new GridDailyRecordIrrigationResume(lDailyRecordUnit.DaysAfterSowing.ToString(),lDailyRecordUnit.DailyRecordDateTime.ToShortDateString(), lEffectiveRain, lEffectiveInputWater);
                        lGridDailyRecordIrrigationResumeList.Add(lGridDailyRecordIrrigationResume);

                    }
                }
            }


            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in ReportPivotStatePrintableController.GetGridDailyRecordIrrigationResume \n {0} ");
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
                Utils.LogError(ex, "Exception in ReportPivotStatePrintableController.GetGridDailyRecordIrrigationResume \n {0} ");
                return 0;
            }
        }

    }
}
