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
using IrrigationAdvisor.Models.Reports.ReportPivotState;
using IrrigationAdvisor.Models.Management;

using IrrigationAdvisor.Models.Utilities;
using System.Web.Helpers;
using System.Collections;
using IrrigationAdvisor.Models;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;
using System.IO;


using System.Text;


namespace IrrigationAdvisor.Controllers.Reports.ReportPivotState
{
    public class ReportPivotStateController : Controller
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
                //List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
                //List<long> lListciw = new List<long>();
                //lListciw.Add(ciwId);

                //lCropIrrigationWeatherList = ciwc.GetCropIrrigationWeatherByIds(lListciw, Utils.GetDateOfReference().Value);

                //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
                //{
                //    lHydricBalancePercentage = lCropIrrigationWeather.GetPercentageOfHydricBalance();
                //}
                #endregion


                foreach (DailyRecord item in lDailyRecordList)
                {
                    if (item.Rain != null)
                        lSumTotalEffectiveRain = lSumTotalEffectiveRain + item.Rain.Input + item.Rain.ExtraInput; ;

                    if (item.Irrigation != null)
                        lSumTotalEffectiveInputWater = lSumTotalEffectiveInputWater + item.Irrigation.Input + item.Irrigation.ExtraInput;

                    lSumTotalEvapotranspirationCrop = item.TotalEvapotranspirationCrop;
                    lHydricBalancePercentage = item.PercentageOfHydricBalance;
                    lCropIrrigationWeatherTitle = item.CropIrrigationWeather.ToString();
                }
                vm.TotalEffectiveRain = lSumTotalEffectiveRain;
                vm.TotalEffectiveInputWater = lSumTotalEffectiveInputWater;
                vm.TotalEvapotranspirationCrop = lSumTotalEvapotranspirationCrop;
                vm.Title = lCropIrrigationWeatherTitle;
                vm.CropIrrigationWeatherId = ciwId;
                vm.HydricBalancePercentage = lHydricBalancePercentage;
                return View("~/Views/Reports/ReportPivotState/ReportPivotState.cshtml", vm);
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in ReportPivotState.Index \n {0} ");
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
                    if (item.DaysAfterSowing > 0) { 
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
                }

                System.Web.UI.DataVisualization.Charting.Chart chart = new System.Web.UI.DataVisualization.Charting.Chart();
                chart.Width = 1000;
                chart.Height = 450;

                
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
                chart.ChartAreas.Add(CreateChartArea());
                chart.Series.Add(CreateSeries(yArrayETC , xDaysAfterSowing, "ETc acumulada", SeriesChartType.Line, Color.FromArgb(246, 134, 36), AxisType.Primary));
                chart.Series.Add(CreateSeries(yArrayRain, xDaysAfterSowing, "Lluvia", SeriesChartType.Column, Color.FromArgb(74, 164, 209), AxisType.Secondary));
                chart.Series.Add(CreateSeries(yArrayIrrigation, xDaysAfterSowing, "Riego", SeriesChartType.Column, Color.FromArgb(97, 209, 74), AxisType.Secondary));

                System.Web.UI.DataVisualization.Charting.Title title = chart.Titles.Add("Evolución de la ETc acumulada y distribucion de las lluvias y riegos, expresadas en mm de lámina bruta");
                title.Font = new Font("Verdana,Arial,Helvetica,sans-serif", 10, FontStyle.Regular); 
                
                chart.Legends.Clear();
                chart.Legends.Add("Default");
                chart.Legends[0].Docking = Docking.Bottom;
                chart.Legends[0].TableStyle = LegendTableStyle.Wide;
                chart.Legends[0].Alignment = StringAlignment.Center;
           
                MemoryStream ms = new MemoryStream();
                chart.SaveImage(ms);
                return File(ms.GetBuffer(), @"image/png");
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in ReportPivotState.GetChart \n {0} ");
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
            
            //hide label value if zero in the chart or is ETc
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
            chartArea.AxisX.IsLabelAutoFit = false;
            chartArea.AxisX.LabelStyle.Font = new Font("Verdana,Arial,Helvetica,sans-serif", 8F, FontStyle.Regular);
            chartArea.AxisX.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea.AxisX.Interval = 5; 
            chartArea.AxisX.Title = "Días desde la siembra";
            chartArea.AxisX.TitleFont = new Font("Verdana,Arial,Helvetica,sans-serif", 10, FontStyle.Regular);

            chartArea.AxisY.IsLabelAutoFit = false;
            chartArea.AxisY.LabelStyle.Font = new Font("Verdana,Arial,Helvetica,sans-serif", 8F, FontStyle.Regular);
            chartArea.AxisY.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(250, 250, 254);  
            chartArea.AxisY.Interval = 10;
            chartArea.AxisY.Title = "Evapotranspiración acumulada (mm)";
            chartArea.AxisY.TitleFont = new Font("Verdana,Arial,Helvetica,sans-serif", 10, FontStyle.Regular);

            chartArea.AxisY2.IsLabelAutoFit = false; 
            chartArea.AxisY2.LabelStyle.Font = new Font("Verdana,Arial,Helvetica,sans-serif", 8F, FontStyle.Regular);
            chartArea.AxisY2.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea.AxisY2.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64); 
            chartArea.AxisY2.Title = "Distribución de lluvias y riegos (mm)";
            chartArea.AxisY2.Interval = 10;
            chartArea.AxisY2.Enabled = AxisEnabled.True;
            chartArea.AxisY2.TitleFont = new Font("Verdana,Arial,Helvetica,sans-serif", 10, FontStyle.Regular);
            chartArea.AxisY2.TextOrientation = TextOrientation.Rotated270;
     
            return chartArea;
        }
        #endregion

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
            return PartialView("~/Views/Reports/ReportPivotState/_ReportPivotStateHeaderPartial.cshtml", GetGridDailyRecordIrrigationResumeTitles());
        }

        [ChildActionOnly]
        public PartialViewResult ReportPivotStatePartial()
        {
            return PartialView("~/Views/Reports/ReportPivotState/_ReportPivotStatePartial.cshtml", GetGridDailyRecordIrrigationResume());
        }

        /// <summary>
        /// Return Grid Datail from dailyrecord days
        /// </summary>
        /// <returns></returns>
        public List<GridReportPivotState> GetGridDailyRecordIrrigationResumeTitles()
        {

            #region Local Variables
            List<GridReportPivotState> lGridDailyRecordIrrigationResumeList = new List<GridReportPivotState>();
            GridReportPivotState lGridDailyRecordIrrigationResume;
            #endregion

            #region Configuration Variables
            UserConfiguration uc;
            #endregion

            try
            {

                #region Configuration - Instance
                uc = new UserConfiguration();
                #endregion

                lGridDailyRecordIrrigationResume = new GridReportPivotState("Día", "Fecha", "Riego", "Lluvia");
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
        public List<GridReportPivotState> GetGridDailyRecordIrrigationResume()
        {
            #region Local Variables

            List<GridReportPivotState> lGridIrrigationUnitList = new List<GridReportPivotState>();
            List<GridReportPivotState> lGridDailyRecordIrrigationResumeList = new List<GridReportPivotState>();
            GridReportPivotState lGridDailyRecordIrrigationResume = null;

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

                        lGridDailyRecordIrrigationResume = new GridReportPivotState(lDailyRecordUnit.DaysAfterSowing.ToString(), lDailyRecordUnit.DailyRecordDateTime.ToShortDateString(), lEffectiveRain, lEffectiveInputWater);
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
