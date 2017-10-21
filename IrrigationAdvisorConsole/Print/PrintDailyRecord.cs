using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Weather;

using IrrigationAdvisor.DBContext;

namespace IrrigationAdvisorConsole.Print
{
    public static class PrintDailyRecord
    {

        /// <summary>
        /// Layout of Daily Records
        /// </summary>
        public static void LayoutDailyRecords()
        {
            #region Local Variables
            TextFileLogger lTextFileLogger = new TextFileLogger();
            String lMethod = "LayoutDailyRecords";
            String lMessage = "";
            String lTime = System.DateTime.Now.ToString();
            String lDate = System.DateTime.Today.Year.ToString() +
                System.DateTime.Today.Month.ToString() +
                System.DateTime.Today.Day.ToString();
            String lFile;

            String lFilePath;
            String lFolderName;
            String lDataSplit;
            String lDescription;
            OutputFileCSV lOutputFile;

            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            List<Title> lTitles = null;
            List<Message> lMessages = null;
            List<Title> lTitlesDaily = null;
            List<Message> lMessagesDaily = null;
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {

                #region South

                #region Demo - La Perdiz
                if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
                {

                    #region Demo - La Perdiz Pivot 1 2015
                    lFile = "IrrigationSystem_Demo_Pivot_01_Maiz_2015";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo1
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort

                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo11
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                    && ciw.SowingDate <= Program.DateOfReference
                                                    && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo11
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo11)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.Titles;
                    lOutputFile.FileMessages = lCropIrrigationWeather.Messages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                    lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Demo - La Perdiz Pivot 2 2015
                    lFile = "IrrigationSystem_Demo_Pivot_02_Maiz_2015";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo1
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo12
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                    && ciw.SowingDate <= Program.DateOfReference
                                                    && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo12
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo12)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                    lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Demo - La Perdiz Pivot 3 2015
                    lFile = "IrrigationSystem_Demo_Pivot_03_Maiz_2015";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo1
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo13
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo13
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo13)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                    lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Demo - La Perdiz Pivot 5 2015
                    lFile = "IrrigationSystem_Demo_Pivot_05_Maiz_2015";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo1
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo15
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo15
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo15)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                }
                #endregion

                #region Santa Lucia
                if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.SantaLucia)
                {
                    if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All)
                    {
                        #region Santa Lucia Pivot 1 2015
                        lFile = "IrrigationSystem_SantaLucia_Pivot_01_Maiz_2015";

                        lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                              where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                              select effectiverain)
                                                 .ToList<EffectiveRain>();

                        lFarm = (from farm in context.Farms
                                 where farm.Name == Utils.NameFarmSantaLucia
                                 select farm).FirstOrDefault();
                        lWeatherStationMain = (from ws in context.WeatherStations
                                               where ws.Name == Utils.NameWeatherStationLasBrujas
                                               select ws).FirstOrDefault();
                        lWeatherStationAlternative = (from ws in context.WeatherStations
                                                      where ws.Name == Utils.NameWeatherStationSantaLucia
                                                      select ws).FirstOrDefault();

                        lCrop = (from crop in context.Crops
                                 where crop.Name == Utils.NameSpecieCornSouthShort
                                 select crop).FirstOrDefault();
                        lIrrigationUnit = (from iu in context.Pivots
                                           where iu.Name == Utils.NamePivotSantaLucia1
                                           select iu).FirstOrDefault();
                        lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                                  where ciw.CropId == lCrop.CropId
                                                      && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                          && ciw.SowingDate <= Program.DateOfReference
                                                          && ciw.HarvestDate >= Program.DateOfReference
                                                  select ciw).FirstOrDefault();
                        lCropInformationByDate = (from cid in context.CropInformationByDates
                                                  where cid.Name == Utils.NameSpecieCornSouthShort
                                                  select cid).FirstOrDefault();
                        lIrrigationList = (from ilist in context.Irrigations
                                           where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           select ilist).ToList<Irrigation>();
                        lRainList = (from rlist in context.Rains
                                     where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     select rlist).ToList<Rain>();
                        lSowingDate = lCropIrrigationWeather.SowingDate;
                        lHarvestDate = lCropIrrigationWeather.HarvestDate;
                        lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                                join weatherstation in context.WeatherStations
                                                on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                                select weatherdata).ToList<WeatherData>();
                        lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                       join weatherstation in context.WeatherStations
                                                       on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                       where (weatherdata.Date >= lSowingDate &&
                                                            weatherdata.Date <= lHarvestDate) &&
                                                            weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                       select weatherdata).ToList<WeatherData>();
                        lCropCoefficient = (from cc in context.CropCoefficients
                                            where cc.Name == Utils.NameSpecieCornSouthShort
                                            select cc).FirstOrDefault();
                        lKCList = (from cc in context.CropCoefficients
                                   where cc.Name == Utils.NameSpecieCornSouthShort
                                   select cc.KCList).FirstOrDefault();
                        lSoil = (from soil in context.Soils
                                 where soil.Name == Utils.NameSoilSantaLucia1
                                 select soil).FirstOrDefault();
                        lHorizonList = (from horizon in context.Horizons
                                        where horizon.Name.StartsWith(Utils.NamePivotSantaLucia1)
                                        select horizon)
                                        .ToList<Horizon>();

                        #region TextLog
                        lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                        lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                        if (String.IsNullOrEmpty(lFile))
                        {
                            lFile = "IrrigationSystem-" + lDate;
                        }
                        else
                        {
                            lFile = lFile + "-" + lDate;
                        }

                        lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);

                        //Print
                        /*
                        lTitles = (from ti in context.Titles
                                     where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                        && ti.Daily == false
                                     select ti).ToList<Title>();
                        lMessage = (from ms in context.Messages
                                     where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                         && ms.Daily == false
                                     select ms).ToList<Message>();

                        lTitlesDaily = (from ti in context.Titles
                                  where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ti.Daily == true
                                  select ti).ToList<Title>();
                        lMessagesDaily = (from ms in context.Messages
                                     where ms.TitleId == lTitle.TitleId
                                         && ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                         && ms.Daily == true
                                     select ms).ToList<Message>();
                         */
                        #endregion

                        #region CSV Data
                        //create the file
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lCropIrrigationWeather.Titles;
                        lOutputFile.FileMessages = lCropIrrigationWeather.Messages;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #region CSV Daily Record
                        //create the file
                        lFile += "-DailyRecord";
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                        lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #endregion
                    }
                }
                #endregion

                #region DCA San Jose
                if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCA
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCASanJose)
                {

                    #region 2016
                    #region DCA San Jose Pivot 1 2016
                    lFile = "IrrigationSystem_DCASanJose_Pivot_1_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCASanJose
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCASanJose1
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                    && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                    && ciw.SowingDate <= Program.DateOfReference
                                                    && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCASanJose1
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCASanJose1)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                    lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region DCA San Jose Pivot 4 2016
                    lFile = "IrrigationSystem_DCASanJose_Pivot_4_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCASanJose
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCASanJose4
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                    && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                    && ciw.SowingDate <= Program.DateOfReference
                                                    && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCASanJose4
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCASanJose4)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                    lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #endregion

                }
                #endregion

                #region DCA LaPerdiz
                if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCA
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCALaPerdiz)
                {
                    if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All)
                    {
                        #region 2015
#if false
                        #region La Perdiz Pivot 1 2015
                    lFile = "IrrigationSystem_LaPerdiz_Pivot_01_Maiz_2015";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();
                
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmLaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotLaPerdiz1
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilLaPerdiz1
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotLaPerdiz1)
                                    select horizon)
                                    .ToList<Horizon>();

                        #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordsList(lCropIrrigationWeather);

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                        #endregion

                        #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.Titles;
                    lOutputFile.FileMessages = lCropIrrigationWeather.Messages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                    lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #endregion
#endif

                        #region La Perdiz Pivot 2 2015
                        lFile = "IrrigationSystem_LaPerdiz_Pivot_02_Maiz_2015";

                        lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                              where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                              select effectiverain)
                                                 .ToList<EffectiveRain>();

                        lFarm = (from farm in context.Farms
                                 where farm.Name == Utils.NameFarmDCALaPerdiz
                                 select farm).FirstOrDefault();
                        lWeatherStationMain = (from ws in context.WeatherStations
                                               where ws.Name == Utils.NameWeatherStationLasBrujas
                                               select ws).FirstOrDefault();
                        lWeatherStationAlternative = (from ws in context.WeatherStations
                                                      where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                      select ws).FirstOrDefault();

                        lCrop = (from crop in context.Crops
                                 where crop.Name == Utils.NameSpecieCornSouthShort
                                 select crop).FirstOrDefault();
                        lCropInformationByDate = (from cid in context.CropInformationByDates
                                                  where cid.Name == Utils.NameSpecieCornSouthShort
                                                  select cid).FirstOrDefault();
                        lCropCoefficient = (from cc in context.CropCoefficients
                                            where cc.Name == Utils.NameSpecieCornSouthShort
                                            select cc).FirstOrDefault();
                        lKCList = (from cc in context.CropCoefficients
                                   where cc.Name == Utils.NameSpecieCornSouthShort
                                   select cc.KCList)
                                             .FirstOrDefault();

                        lIrrigationUnit = (from iu in context.Pivots
                                           where iu.Name == Utils.NamePivotDCALaPerdiz2
                                           select iu).FirstOrDefault();
                        lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                                  where ciw.CropId == lCrop.CropId
                                                      && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                          && ciw.SowingDate <= Program.DateOfReference
                                                          && ciw.HarvestDate >= Program.DateOfReference
                                                  select ciw).FirstOrDefault();
                        lIrrigationList = (from ilist in context.Irrigations
                                           where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           select ilist).ToList<Irrigation>();
                        lRainList = (from rlist in context.Rains
                                     where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     select rlist).ToList<Rain>();

                        lSowingDate = lCropIrrigationWeather.SowingDate;
                        lHarvestDate = lCropIrrigationWeather.HarvestDate;
                        lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                                join weatherstation in context.WeatherStations
                                                on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                                select weatherdata).ToList<WeatherData>();
                        lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                       join weatherstation in context.WeatherStations
                                                       on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                       where (weatherdata.Date >= lSowingDate &&
                                                            weatherdata.Date <= lHarvestDate) &&
                                                            weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                       select weatherdata).ToList<WeatherData>();
                        lSoil = (from soil in context.Soils
                                 where soil.Name == Utils.NameSoilDCALaPerdiz2
                                 select soil).FirstOrDefault();
                        lHorizonList = (from horizon in context.Horizons
                                        where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz2)
                                        select horizon)
                                        .ToList<Horizon>();

                        #region TextLog
                        lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                        lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                        #region Print Data - Titles & Messages
                        lTitles = (from ti in context.Titles
                                   where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      && ti.Daily == false
                                   select ti).ToList<Title>();
                        lMessages = (from ms in context.Messages
                                     where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                         && ms.Daily == false
                                     select ms).ToList<Message>();

                        lTitlesDaily = (from ti in context.Titles
                                        where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           && ti.Daily == true
                                        select ti).ToList<Title>();
                        lMessagesDaily = (from ms in context.Messages
                                          where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                              && ms.Daily == true
                                          select ms).ToList<Message>();
                        #endregion Print Data

                        if (String.IsNullOrEmpty(lFile))
                        {
                            lFile = "IrrigationSystem-" + lDate;
                        }
                        else
                        {
                            lFile = lFile + "-" + lDate;
                        }

                        lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                        #endregion

                        #region CSV Data
                        //create the file
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitles;
                        lOutputFile.FileMessages = lMessages;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #region CSV Daily Record
                        //create the file
                        lFile += "-DailyRecord-";
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                        lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #endregion

                        #region La Perdiz Pivot 3 2015
                        lFile = "IrrigationSystem_LaPerdiz_Pivot_03_Maiz_2015";

                        lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                              where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                              select effectiverain)
                                                 .ToList<EffectiveRain>();

                        lFarm = (from farm in context.Farms
                                 where farm.Name == Utils.NameFarmDCALaPerdiz
                                 select farm).FirstOrDefault();
                        lWeatherStationMain = (from ws in context.WeatherStations
                                               where ws.Name == Utils.NameWeatherStationLasBrujas
                                               select ws).FirstOrDefault();
                        lWeatherStationAlternative = (from ws in context.WeatherStations
                                                      where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                      select ws).FirstOrDefault();

                        lCrop = (from crop in context.Crops
                                 where crop.Name == Utils.NameSpecieCornSouthShort
                                 select crop).FirstOrDefault();
                        lCropInformationByDate = (from cid in context.CropInformationByDates
                                                  where cid.Name == Utils.NameSpecieCornSouthShort
                                                  select cid).FirstOrDefault();
                        lCropCoefficient = (from cc in context.CropCoefficients
                                            where cc.Name == Utils.NameSpecieCornSouthShort
                                            select cc).FirstOrDefault();
                        lKCList = (from cc in context.CropCoefficients
                                   where cc.Name == Utils.NameSpecieCornSouthShort
                                   select cc.KCList)
                                             .FirstOrDefault();

                        lIrrigationUnit = (from iu in context.Pivots
                                           where iu.Name == Utils.NamePivotDCALaPerdiz3
                                           select iu).FirstOrDefault();
                        lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                                  where ciw.CropId == lCrop.CropId
                                                      && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                          && ciw.SowingDate <= Program.DateOfReference
                                                          && ciw.HarvestDate >= Program.DateOfReference
                                                  select ciw).FirstOrDefault();
                        lIrrigationList = (from ilist in context.Irrigations
                                           where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           select ilist).ToList<Irrigation>();
                        lRainList = (from rlist in context.Rains
                                     where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     select rlist).ToList<Rain>();

                        lSowingDate = lCropIrrigationWeather.SowingDate;
                        lHarvestDate = lCropIrrigationWeather.HarvestDate;
                        lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                                join weatherstation in context.WeatherStations
                                                on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                                select weatherdata).ToList<WeatherData>();
                        lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                       join weatherstation in context.WeatherStations
                                                       on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                       where (weatherdata.Date >= lSowingDate &&
                                                            weatherdata.Date <= lHarvestDate) &&
                                                            weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                       select weatherdata).ToList<WeatherData>();
                        lSoil = (from soil in context.Soils
                                 where soil.Name == Utils.NameSoilDCALaPerdiz3
                                 select soil).FirstOrDefault();
                        lHorizonList = (from horizon in context.Horizons
                                        where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz3)
                                        select horizon)
                                        .ToList<Horizon>();

                        #region TextLog
                        lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                        lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                        #region Print Data - Titles & Messages
                        lTitles = (from ti in context.Titles
                                   where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      && ti.Daily == false
                                   select ti).ToList<Title>();
                        lMessages = (from ms in context.Messages
                                     where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                         && ms.Daily == false
                                     select ms).ToList<Message>();

                        lTitlesDaily = (from ti in context.Titles
                                        where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           && ti.Daily == true
                                        select ti).ToList<Title>();
                        lMessagesDaily = (from ms in context.Messages
                                          where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                              && ms.Daily == true
                                          select ms).ToList<Message>();
                        #endregion Print Data

                        if (String.IsNullOrEmpty(lFile))
                        {
                            lFile = "IrrigationSystem-" + lDate;
                        }
                        else
                        {
                            lFile = lFile + "-" + lDate;
                        }

                        lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                        #endregion

                        #region CSV Data
                        //create the file
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitles;
                        lOutputFile.FileMessages = lMessages;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #region CSV Daily Record
                        //create the file
                        lFile += "-DailyRecord-";
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                        lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #endregion

                        #region La Perdiz Pivot 5 2015
                        lFile = "IrrigationSystem_LaPerdiz_Pivot_05_Maiz_2015";

                        lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                              where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                              select effectiverain)
                                                 .ToList<EffectiveRain>();

                        lFarm = (from farm in context.Farms
                                 where farm.Name == Utils.NameFarmDCALaPerdiz
                                 select farm).FirstOrDefault();
                        lWeatherStationMain = (from ws in context.WeatherStations
                                               where ws.Name == Utils.NameWeatherStationLasBrujas
                                               select ws).FirstOrDefault();
                        lWeatherStationAlternative = (from ws in context.WeatherStations
                                                      where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                      select ws).FirstOrDefault();

                        lCrop = (from crop in context.Crops
                                 where crop.Name == Utils.NameSpecieCornSouthShort
                                 select crop).FirstOrDefault();
                        lCropInformationByDate = (from cid in context.CropInformationByDates
                                                  where cid.Name == Utils.NameSpecieCornSouthShort
                                                  select cid).FirstOrDefault();
                        lCropCoefficient = (from cc in context.CropCoefficients
                                            where cc.Name == Utils.NameSpecieCornSouthShort
                                            select cc).FirstOrDefault();
                        lKCList = (from cc in context.CropCoefficients
                                   where cc.Name == Utils.NameSpecieCornSouthShort
                                   select cc.KCList)
                                             .FirstOrDefault();

                        lIrrigationUnit = (from iu in context.Pivots
                                           where iu.Name == Utils.NamePivotDCALaPerdiz5
                                           select iu).FirstOrDefault();
                        lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                                  where ciw.CropId == lCrop.CropId
                                                      && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                          && ciw.SowingDate <= Program.DateOfReference
                                                          && ciw.HarvestDate >= Program.DateOfReference
                                                  select ciw).FirstOrDefault();
                        lIrrigationList = (from ilist in context.Irrigations
                                           where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           select ilist).ToList<Irrigation>();
                        lRainList = (from rlist in context.Rains
                                     where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     select rlist).ToList<Rain>();

                        lSowingDate = lCropIrrigationWeather.SowingDate;
                        lHarvestDate = lCropIrrigationWeather.HarvestDate;
                        lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                                join weatherstation in context.WeatherStations
                                                on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                                select weatherdata).ToList<WeatherData>();
                        lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                       join weatherstation in context.WeatherStations
                                                       on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                       where (weatherdata.Date >= lSowingDate &&
                                                            weatherdata.Date <= lHarvestDate) &&
                                                            weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                       select weatherdata).ToList<WeatherData>();
                        lSoil = (from soil in context.Soils
                                 where soil.Name == Utils.NameSoilDCALaPerdiz5
                                 select soil).FirstOrDefault();
                        lHorizonList = (from horizon in context.Horizons
                                        where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz5)
                                        select horizon)
                                        .ToList<Horizon>();

                        #region TextLog
                        lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                        lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                        #region Print Data - Titles & Messages
                        lTitles = (from ti in context.Titles
                                   where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      && ti.Daily == false
                                   select ti).ToList<Title>();
                        lMessages = (from ms in context.Messages
                                     where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                         && ms.Daily == false
                                     select ms).ToList<Message>();

                        lTitlesDaily = (from ti in context.Titles
                                        where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           && ti.Daily == true
                                        select ti).ToList<Title>();
                        lMessagesDaily = (from ms in context.Messages
                                          where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                              && ms.Daily == true
                                          select ms).ToList<Message>();
                        #endregion Print Data

                        if (String.IsNullOrEmpty(lFile))
                        {
                            lFile = "IrrigationSystem-" + lDate;
                        }
                        else
                        {
                            lFile = lFile + "-" + lDate;
                        }

                        lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                        #endregion

                        #region CSV Data
                        //create the file
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitles;
                        lOutputFile.FileMessages = lMessages;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #region CSV Daily Record
                        //create the file
                        lFile += "-DailyRecord-";
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitlesDaily;
                        lOutputFile.FileMessages = lMessagesDaily;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #endregion
                        #endregion
                    }

                    #region 2016
                    #region DCA La Perdiz Pivot 1 2016
                    lFile = "IrrigationSystem_DCALaPerdiz_Pivot_1_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCALaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCALaPerdiz1
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                    && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                    && ciw.SowingDate <= Program.DateOfReference
                                                    && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCALaPerdiz1
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz1)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                    lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region DCA La Perdiz Pivot 6 2016
                    lFile = "IrrigationSystem_DCALaPerdiz_Pivot_6_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCALaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCALaPerdiz6
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                    && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                    && ciw.SowingDate <= Program.DateOfReference
                                                    && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCALaPerdiz6
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz6)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                    lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region DCA La Perdiz Pivot 10b 2016
                    lFile = "IrrigationSystem_DCALaPerdiz_Pivot_10b_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCALaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCALaPerdiz10b
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                    && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                    && ciw.SowingDate <= Program.DateOfReference
                                                    && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCALaPerdiz10b
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz10b)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                    lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region DCA La Perdiz Pivot 15 2016
                    lFile = "IrrigationSystem_DCALaPerdiz_Pivot_15_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCALaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCALaPerdiz15
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                    && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                    && ciw.SowingDate <= Program.DateOfReference
                                                    && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCALaPerdiz15
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz15)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                    lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #endregion

                }
                #endregion

                #region Del Lago - San Pedro
                if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoSanPedro)
                {
                    if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All)
                    {
                        #region 2015
                        #region Del Lago - San Pedro Pivot 5 2015
                        lFile = "IrrigationSystem_DelLago_SanPedro_Pivot_05_Maiz_2015";

                        lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                              where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                              select effectiverain)
                                                 .ToList<EffectiveRain>();

                        lFarm = (from farm in context.Farms
                                 where farm.Name == Utils.NameFarmDelLagoSanPedro
                                 select farm).FirstOrDefault();
                        lWeatherStationMain = (from ws in context.WeatherStations
                                               where ws.Name == Utils.NameWeatherStationLasBrujas
                                               select ws).FirstOrDefault();
                        lWeatherStationAlternative = (from ws in context.WeatherStations
                                                      where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                      select ws).FirstOrDefault();

                        lCrop = (from crop in context.Crops
                                 where crop.Name == Utils.NameSpecieCornSouthShort
                                 select crop).FirstOrDefault();
                        lCropInformationByDate = (from cid in context.CropInformationByDates
                                                  where cid.Name == Utils.NameSpecieCornSouthShort
                                                  select cid).FirstOrDefault();
                        lCropCoefficient = (from cc in context.CropCoefficients
                                            where cc.Name == Utils.NameSpecieCornSouthShort
                                            select cc).FirstOrDefault();
                        lKCList = (from cc in context.CropCoefficients
                                   where cc.Name == Utils.NameSpecieCornSouthShort
                                   select cc.KCList)
                                             .FirstOrDefault();

                        lIrrigationUnit = (from iu in context.Pivots
                                           where iu.Name == Utils.NamePivotDelLagoSanPedro5
                                           select iu).FirstOrDefault();
                        lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                                  where ciw.CropId == lCrop.CropId
                                                      && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                          && ciw.SowingDate <= Program.DateOfReference
                                                          && ciw.HarvestDate >= Program.DateOfReference
                                                  select ciw).FirstOrDefault();
                        lIrrigationList = (from ilist in context.Irrigations
                                           where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           select ilist).ToList<Irrigation>();
                        lRainList = (from rlist in context.Rains
                                     where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     select rlist).ToList<Rain>();

                        lSowingDate = lCropIrrigationWeather.SowingDate;
                        lHarvestDate = lCropIrrigationWeather.HarvestDate;
                        lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                                join weatherstation in context.WeatherStations
                                                on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                                select weatherdata).ToList<WeatherData>();
                        lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                       join weatherstation in context.WeatherStations
                                                       on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                       where (weatherdata.Date >= lSowingDate &&
                                                            weatherdata.Date <= lHarvestDate) &&
                                                            weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                       select weatherdata).ToList<WeatherData>();
                        lSoil = (from soil in context.Soils
                                 where soil.Name == Utils.NameSoilDelLagoSanPedro5
                                 select soil).FirstOrDefault();
                        lHorizonList = (from horizon in context.Horizons
                                        where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro5)
                                        select horizon)
                                        .ToList<Horizon>();

                        #region TextLog
                        lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                        lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                        #region Print Data - Titles & Messages
                        lTitles = (from ti in context.Titles
                                   where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      && ti.Daily == false
                                   select ti).ToList<Title>();
                        lMessages = (from ms in context.Messages
                                     where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                         && ms.Daily == false
                                     select ms).ToList<Message>();

                        lTitlesDaily = (from ti in context.Titles
                                        where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           && ti.Daily == true
                                        select ti).ToList<Title>();
                        lMessagesDaily = (from ms in context.Messages
                                          where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                              && ms.Daily == true
                                          select ms).ToList<Message>();
                        #endregion Print Data

                        if (String.IsNullOrEmpty(lFile))
                        {
                            lFile = "IrrigationSystem-" + lDate;
                        }
                        else
                        {
                            lFile = lFile + "-" + lDate;
                        }

                        lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                        #endregion

                        #region CSV Data
                        //create the file
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitles;
                        lOutputFile.FileMessages = lMessages;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #region CSV Daily Record
                        //create the file
                        lFile += "-DailyRecord-";
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitlesDaily;
                        lOutputFile.FileMessages = lMessagesDaily;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #endregion

                        #region Del Lago - San Pedro Pivot 6 2015
                        lFile = "IrrigationSystem_DelLago_SanPedro_Pivot_06_Maiz_2015";

                        lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                              where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                              select effectiverain)
                                                 .ToList<EffectiveRain>();

                        lFarm = (from farm in context.Farms
                                 where farm.Name == Utils.NameFarmDelLagoSanPedro
                                 select farm).FirstOrDefault();
                        lWeatherStationMain = (from ws in context.WeatherStations
                                               where ws.Name == Utils.NameWeatherStationLasBrujas
                                               select ws).FirstOrDefault();
                        lWeatherStationAlternative = (from ws in context.WeatherStations
                                                      where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                      select ws).FirstOrDefault();

                        lCrop = (from crop in context.Crops
                                 where crop.Name == Utils.NameSpecieCornSouthShort
                                 select crop).FirstOrDefault();
                        lCropInformationByDate = (from cid in context.CropInformationByDates
                                                  where cid.Name == Utils.NameSpecieCornSouthShort
                                                  select cid).FirstOrDefault();
                        lCropCoefficient = (from cc in context.CropCoefficients
                                            where cc.Name == Utils.NameSpecieCornSouthShort
                                            select cc).FirstOrDefault();
                        lKCList = (from cc in context.CropCoefficients
                                   where cc.Name == Utils.NameSpecieCornSouthShort
                                   select cc.KCList)
                                             .FirstOrDefault();

                        lIrrigationUnit = (from iu in context.Pivots
                                           where iu.Name == Utils.NamePivotDelLagoSanPedro6
                                           select iu).FirstOrDefault();
                        lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                                  where ciw.CropId == lCrop.CropId
                                                      && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                          && ciw.SowingDate <= Program.DateOfReference
                                                          && ciw.HarvestDate >= Program.DateOfReference
                                                  select ciw).FirstOrDefault();
                        lIrrigationList = (from ilist in context.Irrigations
                                           where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           select ilist).ToList<Irrigation>();
                        lRainList = (from rlist in context.Rains
                                     where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     select rlist).ToList<Rain>();

                        lSowingDate = lCropIrrigationWeather.SowingDate;
                        lHarvestDate = lCropIrrigationWeather.HarvestDate;
                        lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                                join weatherstation in context.WeatherStations
                                                on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                                select weatherdata).ToList<WeatherData>();
                        lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                       join weatherstation in context.WeatherStations
                                                       on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                       where (weatherdata.Date >= lSowingDate &&
                                                            weatherdata.Date <= lHarvestDate) &&
                                                            weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                       select weatherdata).ToList<WeatherData>();
                        lSoil = (from soil in context.Soils
                                 where soil.Name == Utils.NameSoilDelLagoSanPedro6
                                 select soil).FirstOrDefault();
                        lHorizonList = (from horizon in context.Horizons
                                        where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro6)
                                        select horizon)
                                        .ToList<Horizon>();

                        #region TextLog
                        lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                        lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                        #region Print Data - Titles & Messages
                        lTitles = (from ti in context.Titles
                                   where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      && ti.Daily == false
                                   select ti).ToList<Title>();
                        lMessages = (from ms in context.Messages
                                     where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                         && ms.Daily == false
                                     select ms).ToList<Message>();

                        lTitlesDaily = (from ti in context.Titles
                                        where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           && ti.Daily == true
                                        select ti).ToList<Title>();
                        lMessagesDaily = (from ms in context.Messages
                                          where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                              && ms.Daily == true
                                          select ms).ToList<Message>();
                        #endregion Print Data

                        if (String.IsNullOrEmpty(lFile))
                        {
                            lFile = "IrrigationSystem-" + lDate;
                        }
                        else
                        {
                            lFile = lFile + "-" + lDate;
                        }

                        lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                        #endregion

                        #region CSV Data
                        //create the file
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitles;
                        lOutputFile.FileMessages = lMessages;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #region CSV Daily Record
                        //create the file
                        lFile += "-DailyRecord-";
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitlesDaily;
                        lOutputFile.FileMessages = lMessagesDaily;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #endregion

                        #region Del Lago - San Pedro Pivot 7 2015
                        lFile = "IrrigationSystem_DelLago_SanPedro_Pivot_07_Maiz_2015";

                        lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                              where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                              select effectiverain)
                                                 .ToList<EffectiveRain>();

                        lFarm = (from farm in context.Farms
                                 where farm.Name == Utils.NameFarmDelLagoSanPedro
                                 select farm).FirstOrDefault();
                        lWeatherStationMain = (from ws in context.WeatherStations
                                               where ws.Name == Utils.NameWeatherStationLasBrujas
                                               select ws).FirstOrDefault();
                        lWeatherStationAlternative = (from ws in context.WeatherStations
                                                      where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                      select ws).FirstOrDefault();

                        lCrop = (from crop in context.Crops
                                 where crop.Name == Utils.NameSpecieCornSouthShort
                                 select crop).FirstOrDefault();
                        lCropInformationByDate = (from cid in context.CropInformationByDates
                                                  where cid.Name == Utils.NameSpecieCornSouthShort
                                                  select cid).FirstOrDefault();
                        lCropCoefficient = (from cc in context.CropCoefficients
                                            where cc.Name == Utils.NameSpecieCornSouthShort
                                            select cc).FirstOrDefault();
                        lKCList = (from cc in context.CropCoefficients
                                   where cc.Name == Utils.NameSpecieCornSouthShort
                                   select cc.KCList)
                                             .FirstOrDefault();

                        lIrrigationUnit = (from iu in context.Pivots
                                           where iu.Name == Utils.NamePivotDelLagoSanPedro7
                                           select iu).FirstOrDefault();
                        lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                                  where ciw.CropId == lCrop.CropId
                                                      && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                          && ciw.SowingDate <= Program.DateOfReference
                                                          && ciw.HarvestDate >= Program.DateOfReference
                                                  select ciw).FirstOrDefault();
                        lIrrigationList = (from ilist in context.Irrigations
                                           where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           select ilist).ToList<Irrigation>();
                        lRainList = (from rlist in context.Rains
                                     where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     select rlist).ToList<Rain>();

                        lSowingDate = lCropIrrigationWeather.SowingDate;
                        lHarvestDate = lCropIrrigationWeather.HarvestDate;
                        lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                                join weatherstation in context.WeatherStations
                                                on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                                select weatherdata).ToList<WeatherData>();
                        lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                       join weatherstation in context.WeatherStations
                                                       on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                       where (weatherdata.Date >= lSowingDate &&
                                                            weatherdata.Date <= lHarvestDate) &&
                                                            weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                       select weatherdata).ToList<WeatherData>();
                        lSoil = (from soil in context.Soils
                                 where soil.Name == Utils.NameSoilDelLagoSanPedro7
                                 select soil).FirstOrDefault();
                        lHorizonList = (from horizon in context.Horizons
                                        where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro7)
                                        select horizon)
                                        .ToList<Horizon>();

                        #region TextLog
                        lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                        lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                        #region Print Data - Titles & Messages
                        lTitles = (from ti in context.Titles
                                   where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      && ti.Daily == false
                                   select ti).ToList<Title>();
                        lMessages = (from ms in context.Messages
                                     where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                         && ms.Daily == false
                                     select ms).ToList<Message>();

                        lTitlesDaily = (from ti in context.Titles
                                        where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           && ti.Daily == true
                                        select ti).ToList<Title>();
                        lMessagesDaily = (from ms in context.Messages
                                          where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                              && ms.Daily == true
                                          select ms).ToList<Message>();
                        #endregion Print Data

                        if (String.IsNullOrEmpty(lFile))
                        {
                            lFile = "IrrigationSystem-" + lDate;
                        }
                        else
                        {
                            lFile = lFile + "-" + lDate;
                        }

                        lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                        #endregion

                        #region CSV Data
                        //create the file
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitles;
                        lOutputFile.FileMessages = lMessages;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #region CSV Daily Record
                        //create the file
                        lFile += "-DailyRecord-";
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitlesDaily;
                        lOutputFile.FileMessages = lMessagesDaily;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #endregion

                        #region Del Lago - San Pedro Pivot 8 2015
                        lFile = "IrrigationSystem_DelLago_SanPedro_Pivot_08_Maiz_2015";

                        lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                              where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                              select effectiverain)
                                                 .ToList<EffectiveRain>();

                        lFarm = (from farm in context.Farms
                                 where farm.Name == Utils.NameFarmDelLagoSanPedro
                                 select farm).FirstOrDefault();
                        lWeatherStationMain = (from ws in context.WeatherStations
                                               where ws.Name == Utils.NameWeatherStationLasBrujas
                                               select ws).FirstOrDefault();
                        lWeatherStationAlternative = (from ws in context.WeatherStations
                                                      where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                      select ws).FirstOrDefault();

                        lCrop = (from crop in context.Crops
                                 where crop.Name == Utils.NameSpecieCornSouthShort
                                 select crop).FirstOrDefault();
                        lCropInformationByDate = (from cid in context.CropInformationByDates
                                                  where cid.Name == Utils.NameSpecieCornSouthShort
                                                  select cid).FirstOrDefault();
                        lCropCoefficient = (from cc in context.CropCoefficients
                                            where cc.Name == Utils.NameSpecieCornSouthShort
                                            select cc).FirstOrDefault();
                        lKCList = (from cc in context.CropCoefficients
                                   where cc.Name == Utils.NameSpecieCornSouthShort
                                   select cc.KCList)
                                             .FirstOrDefault();

                        lIrrigationUnit = (from iu in context.Pivots
                                           where iu.Name == Utils.NamePivotDelLagoSanPedro8
                                           select iu).FirstOrDefault();
                        lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                                  where ciw.CropId == lCrop.CropId
                                                      && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                          && ciw.SowingDate <= Program.DateOfReference
                                                          && ciw.HarvestDate >= Program.DateOfReference
                                                  select ciw).FirstOrDefault();
                        lIrrigationList = (from ilist in context.Irrigations
                                           where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           select ilist).ToList<Irrigation>();
                        lRainList = (from rlist in context.Rains
                                     where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     select rlist).ToList<Rain>();

                        lSowingDate = lCropIrrigationWeather.SowingDate;
                        lHarvestDate = lCropIrrigationWeather.HarvestDate;
                        lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                                join weatherstation in context.WeatherStations
                                                on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                                select weatherdata).ToList<WeatherData>();
                        lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                       join weatherstation in context.WeatherStations
                                                       on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                       where (weatherdata.Date >= lSowingDate &&
                                                            weatherdata.Date <= lHarvestDate) &&
                                                            weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                       select weatherdata).ToList<WeatherData>();
                        lSoil = (from soil in context.Soils
                                 where soil.Name == Utils.NameSoilDelLagoSanPedro8
                                 select soil).FirstOrDefault();
                        lHorizonList = (from horizon in context.Horizons
                                        where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro8)
                                        select horizon)
                                        .ToList<Horizon>();

                        #region TextLog
                        lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                        lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                        #region Print Data - Titles & Messages
                        lTitles = (from ti in context.Titles
                                   where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      && ti.Daily == false
                                   select ti).ToList<Title>();
                        lMessages = (from ms in context.Messages
                                     where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                         && ms.Daily == false
                                     select ms).ToList<Message>();

                        lTitlesDaily = (from ti in context.Titles
                                        where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           && ti.Daily == true
                                        select ti).ToList<Title>();
                        lMessagesDaily = (from ms in context.Messages
                                          where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                              && ms.Daily == true
                                          select ms).ToList<Message>();
                        #endregion Print Data

                        if (String.IsNullOrEmpty(lFile))
                        {
                            lFile = "IrrigationSystem-" + lDate;
                        }
                        else
                        {
                            lFile = lFile + "-" + lDate;
                        }

                        lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                        #endregion

                        #region CSV Data
                        //create the file
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitles;
                        lOutputFile.FileMessages = lMessages;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #region CSV Daily Record
                        //create the file
                        lFile += "-DailyRecord-";
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitlesDaily;
                        lOutputFile.FileMessages = lMessagesDaily;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #endregion
                        #endregion
                    }
                }
                #endregion

                #region Del Lago - El Mirador
                if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
                {
                    if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All)
                    {
                        #region 2015
                        #region Del Lago - El Mirador Pivot 6 2015
                        lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_06_Maiz_2015";

                        lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                              where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                              select effectiverain)
                                                 .ToList<EffectiveRain>();

                        lFarm = (from farm in context.Farms
                                 where farm.Name == Utils.NameFarmDelLagoElMirador
                                 select farm).FirstOrDefault();
                        lWeatherStationMain = (from ws in context.WeatherStations
                                               where ws.Name == Utils.NameWeatherStationLasBrujas
                                               select ws).FirstOrDefault();
                        lWeatherStationAlternative = (from ws in context.WeatherStations
                                                      where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                      select ws).FirstOrDefault();

                        lCrop = (from crop in context.Crops
                                 where crop.Name == Utils.NameSpecieCornSouthShort
                                 select crop).FirstOrDefault();
                        lCropInformationByDate = (from cid in context.CropInformationByDates
                                                  where cid.Name == Utils.NameSpecieCornSouthShort
                                                  select cid).FirstOrDefault();
                        lCropCoefficient = (from cc in context.CropCoefficients
                                            where cc.Name == Utils.NameSpecieCornSouthShort
                                            select cc).FirstOrDefault();
                        lKCList = (from cc in context.CropCoefficients
                                   where cc.Name == Utils.NameSpecieCornSouthShort
                                   select cc.KCList)
                                             .FirstOrDefault();

                        lIrrigationUnit = (from iu in context.Pivots
                                           where iu.Name == Utils.NamePivotDelLagoElMirador6
                                           select iu).FirstOrDefault();
                        lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                                  where ciw.CropId == lCrop.CropId
                                                      && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                          && ciw.SowingDate <= Program.DateOfReference
                                                          && ciw.HarvestDate >= Program.DateOfReference
                                                  select ciw).FirstOrDefault();
                        lIrrigationList = (from ilist in context.Irrigations
                                           where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           select ilist).ToList<Irrigation>();
                        lRainList = (from rlist in context.Rains
                                     where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     select rlist).ToList<Rain>();

                        lSowingDate = lCropIrrigationWeather.SowingDate;
                        lHarvestDate = lCropIrrigationWeather.HarvestDate;
                        lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                                join weatherstation in context.WeatherStations
                                                on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                                select weatherdata).ToList<WeatherData>();
                        lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                       join weatherstation in context.WeatherStations
                                                       on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                       where (weatherdata.Date >= lSowingDate &&
                                                            weatherdata.Date <= lHarvestDate) &&
                                                            weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                       select weatherdata).ToList<WeatherData>();
                        lSoil = (from soil in context.Soils
                                 where soil.Name == Utils.NameSoilDelLagoElMirador6
                                 select soil).FirstOrDefault();
                        lHorizonList = (from horizon in context.Horizons
                                        where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador6)
                                        select horizon)
                                        .ToList<Horizon>();

                        #region TextLog
                        lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                        lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                        #region Print Data - Titles & Messages
                        lTitles = (from ti in context.Titles
                                   where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      && ti.Daily == false
                                   select ti).ToList<Title>();
                        lMessages = (from ms in context.Messages
                                     where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                         && ms.Daily == false
                                     select ms).ToList<Message>();

                        lTitlesDaily = (from ti in context.Titles
                                        where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           && ti.Daily == true
                                        select ti).ToList<Title>();
                        lMessagesDaily = (from ms in context.Messages
                                          where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                              && ms.Daily == true
                                          select ms).ToList<Message>();
                        #endregion Print Data

                        if (String.IsNullOrEmpty(lFile))
                        {
                            lFile = "IrrigationSystem-" + lDate;
                        }
                        else
                        {
                            lFile = lFile + "-" + lDate;
                        }

                        lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                        #endregion

                        #region CSV Data
                        //create the file
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitles;
                        lOutputFile.FileMessages = lMessages;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #region CSV Daily Record
                        //create the file
                        lFile += "-DailyRecord-";
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitlesDaily;
                        lOutputFile.FileMessages = lMessagesDaily;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #endregion

                        #region Del Lago - El Mirador Pivot 7 2015
                        lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_07_Maiz_2015";

                        lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                              where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                              select effectiverain)
                                                 .ToList<EffectiveRain>();

                        lFarm = (from farm in context.Farms
                                 where farm.Name == Utils.NameFarmDelLagoElMirador
                                 select farm).FirstOrDefault();
                        lWeatherStationMain = (from ws in context.WeatherStations
                                               where ws.Name == Utils.NameWeatherStationLasBrujas
                                               select ws).FirstOrDefault();
                        lWeatherStationAlternative = (from ws in context.WeatherStations
                                                      where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                      select ws).FirstOrDefault();

                        lCrop = (from crop in context.Crops
                                 where crop.Name == Utils.NameSpecieCornSouthShort
                                 select crop).FirstOrDefault();
                        lCropInformationByDate = (from cid in context.CropInformationByDates
                                                  where cid.Name == Utils.NameSpecieCornSouthShort
                                                  select cid).FirstOrDefault();
                        lCropCoefficient = (from cc in context.CropCoefficients
                                            where cc.Name == Utils.NameSpecieCornSouthShort
                                            select cc).FirstOrDefault();
                        lKCList = (from cc in context.CropCoefficients
                                   where cc.Name == Utils.NameSpecieCornSouthShort
                                   select cc.KCList)
                                             .FirstOrDefault();

                        lIrrigationUnit = (from iu in context.Pivots
                                           where iu.Name == Utils.NamePivotDelLagoElMirador7
                                           select iu).FirstOrDefault();
                        lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                                  where ciw.CropId == lCrop.CropId
                                                      && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                          && ciw.SowingDate <= Program.DateOfReference
                                                          && ciw.HarvestDate >= Program.DateOfReference
                                                  select ciw).FirstOrDefault();
                        lIrrigationList = (from ilist in context.Irrigations
                                           where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           select ilist).ToList<Irrigation>();
                        lRainList = (from rlist in context.Rains
                                     where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     select rlist).ToList<Rain>();

                        lSowingDate = lCropIrrigationWeather.SowingDate;
                        lHarvestDate = lCropIrrigationWeather.HarvestDate;
                        lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                                join weatherstation in context.WeatherStations
                                                on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                                select weatherdata).ToList<WeatherData>();
                        lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                       join weatherstation in context.WeatherStations
                                                       on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                       where (weatherdata.Date >= lSowingDate &&
                                                            weatherdata.Date <= lHarvestDate) &&
                                                            weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                       select weatherdata).ToList<WeatherData>();
                        lSoil = (from soil in context.Soils
                                 where soil.Name == Utils.NameSoilDelLagoElMirador7
                                 select soil).FirstOrDefault();
                        lHorizonList = (from horizon in context.Horizons
                                        where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador7)
                                        select horizon)
                                        .ToList<Horizon>();

                        #region TextLog
                        lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                        lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                        #region Print Data - Titles & Messages
                        lTitles = (from ti in context.Titles
                                   where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      && ti.Daily == false
                                   select ti).ToList<Title>();
                        lMessages = (from ms in context.Messages
                                     where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                         && ms.Daily == false
                                     select ms).ToList<Message>();

                        lTitlesDaily = (from ti in context.Titles
                                        where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           && ti.Daily == true
                                        select ti).ToList<Title>();
                        lMessagesDaily = (from ms in context.Messages
                                          where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                              && ms.Daily == true
                                          select ms).ToList<Message>();
                        #endregion Print Data

                        if (String.IsNullOrEmpty(lFile))
                        {
                            lFile = "IrrigationSystem-" + lDate;
                        }
                        else
                        {
                            lFile = lFile + "-" + lDate;
                        }

                        lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                        #endregion

                        #region CSV Data
                        //create the file
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitles;
                        lOutputFile.FileMessages = lMessages;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #region CSV Daily Record
                        //create the file
                        lFile += "-DailyRecord-";
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitlesDaily;
                        lOutputFile.FileMessages = lMessagesDaily;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #endregion

                        #region Del Lago - El Mirador Pivot 8 2015
                        lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_08_Maiz_2015";

                        lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                              where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                              select effectiverain)
                                                 .ToList<EffectiveRain>();

                        lFarm = (from farm in context.Farms
                                 where farm.Name == Utils.NameFarmDelLagoElMirador
                                 select farm).FirstOrDefault();
                        lWeatherStationMain = (from ws in context.WeatherStations
                                               where ws.Name == Utils.NameWeatherStationLasBrujas
                                               select ws).FirstOrDefault();
                        lWeatherStationAlternative = (from ws in context.WeatherStations
                                                      where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                      select ws).FirstOrDefault();

                        lCrop = (from crop in context.Crops
                                 where crop.Name == Utils.NameSpecieCornSouthShort
                                 select crop).FirstOrDefault();
                        lCropInformationByDate = (from cid in context.CropInformationByDates
                                                  where cid.Name == Utils.NameSpecieCornSouthShort
                                                  select cid).FirstOrDefault();
                        lCropCoefficient = (from cc in context.CropCoefficients
                                            where cc.Name == Utils.NameSpecieCornSouthShort
                                            select cc).FirstOrDefault();
                        lKCList = (from cc in context.CropCoefficients
                                   where cc.Name == Utils.NameSpecieCornSouthShort
                                   select cc.KCList)
                                             .FirstOrDefault();

                        lIrrigationUnit = (from iu in context.Pivots
                                           where iu.Name == Utils.NamePivotDelLagoElMirador8
                                           select iu).FirstOrDefault();
                        lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                                  where ciw.CropId == lCrop.CropId
                                                      && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                          && ciw.SowingDate <= Program.DateOfReference
                                                          && ciw.HarvestDate >= Program.DateOfReference
                                                  select ciw).FirstOrDefault();
                        lIrrigationList = (from ilist in context.Irrigations
                                           where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           select ilist).ToList<Irrigation>();
                        lRainList = (from rlist in context.Rains
                                     where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     select rlist).ToList<Rain>();

                        lSowingDate = lCropIrrigationWeather.SowingDate;
                        lHarvestDate = lCropIrrigationWeather.HarvestDate;
                        lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                                join weatherstation in context.WeatherStations
                                                on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                                select weatherdata).ToList<WeatherData>();
                        lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                       join weatherstation in context.WeatherStations
                                                       on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                       where (weatherdata.Date >= lSowingDate &&
                                                            weatherdata.Date <= lHarvestDate) &&
                                                            weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                       select weatherdata).ToList<WeatherData>();
                        lSoil = (from soil in context.Soils
                                 where soil.Name == Utils.NameSoilDelLagoElMirador8
                                 select soil).FirstOrDefault();
                        lHorizonList = (from horizon in context.Horizons
                                        where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador8)
                                        select horizon)
                                        .ToList<Horizon>();

                        #region TextLog
                        lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                        lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                        #region Print Data - Titles & Messages
                        lTitles = (from ti in context.Titles
                                   where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      && ti.Daily == false
                                   select ti).ToList<Title>();
                        lMessages = (from ms in context.Messages
                                     where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                         && ms.Daily == false
                                     select ms).ToList<Message>();

                        lTitlesDaily = (from ti in context.Titles
                                        where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           && ti.Daily == true
                                        select ti).ToList<Title>();
                        lMessagesDaily = (from ms in context.Messages
                                          where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                              && ms.Daily == true
                                          select ms).ToList<Message>();
                        #endregion Print Data

                        if (String.IsNullOrEmpty(lFile))
                        {
                            lFile = "IrrigationSystem-" + lDate;
                        }
                        else
                        {
                            lFile = lFile + "-" + lDate;
                        }

                        lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                        #endregion

                        #region CSV Data
                        //create the file
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitles;
                        lOutputFile.FileMessages = lMessages;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #region CSV Daily Record
                        //create the file
                        lFile += "-DailyRecord-";
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitlesDaily;
                        lOutputFile.FileMessages = lMessagesDaily;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #endregion

                        #region Del Lago - El Mirador Pivot 9 2015
                        lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_09_Maiz_2015";

                        lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                              where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                              select effectiverain)
                                                 .ToList<EffectiveRain>();

                        lFarm = (from farm in context.Farms
                                 where farm.Name == Utils.NameFarmDelLagoElMirador
                                 select farm).FirstOrDefault();
                        lWeatherStationMain = (from ws in context.WeatherStations
                                               where ws.Name == Utils.NameWeatherStationLasBrujas
                                               select ws).FirstOrDefault();
                        lWeatherStationAlternative = (from ws in context.WeatherStations
                                                      where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                      select ws).FirstOrDefault();

                        lCrop = (from crop in context.Crops
                                 where crop.Name == Utils.NameSpecieCornSouthShort
                                 select crop).FirstOrDefault();
                        lCropInformationByDate = (from cid in context.CropInformationByDates
                                                  where cid.Name == Utils.NameSpecieCornSouthShort
                                                  select cid).FirstOrDefault();
                        lCropCoefficient = (from cc in context.CropCoefficients
                                            where cc.Name == Utils.NameSpecieCornSouthShort
                                            select cc).FirstOrDefault();
                        lKCList = (from cc in context.CropCoefficients
                                   where cc.Name == Utils.NameSpecieCornSouthShort
                                   select cc.KCList)
                                             .FirstOrDefault();

                        lIrrigationUnit = (from iu in context.Pivots
                                           where iu.Name == Utils.NamePivotDelLagoElMirador9
                                           select iu).FirstOrDefault();
                        lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                                  where ciw.CropId == lCrop.CropId
                                                      && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                          && ciw.SowingDate <= Program.DateOfReference
                                                          && ciw.HarvestDate >= Program.DateOfReference
                                                  select ciw).FirstOrDefault();
                        lIrrigationList = (from ilist in context.Irrigations
                                           where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           select ilist).ToList<Irrigation>();
                        lRainList = (from rlist in context.Rains
                                     where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     select rlist).ToList<Rain>();

                        lSowingDate = lCropIrrigationWeather.SowingDate;
                        lHarvestDate = lCropIrrigationWeather.HarvestDate;
                        lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                                join weatherstation in context.WeatherStations
                                                on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                                select weatherdata).ToList<WeatherData>();
                        lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                       join weatherstation in context.WeatherStations
                                                       on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                       where (weatherdata.Date >= lSowingDate &&
                                                            weatherdata.Date <= lHarvestDate) &&
                                                            weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                       select weatherdata).ToList<WeatherData>();
                        lSoil = (from soil in context.Soils
                                 where soil.Name == Utils.NameSoilDelLagoElMirador9
                                 select soil).FirstOrDefault();
                        lHorizonList = (from horizon in context.Horizons
                                        where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador9)
                                        select horizon)
                                        .ToList<Horizon>();

                        #region TextLog
                        lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                        lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                        #region Print Data - Titles & Messages
                        lTitles = (from ti in context.Titles
                                   where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      && ti.Daily == false
                                   select ti).ToList<Title>();
                        lMessages = (from ms in context.Messages
                                     where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                         && ms.Daily == false
                                     select ms).ToList<Message>();

                        lTitlesDaily = (from ti in context.Titles
                                        where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           && ti.Daily == true
                                        select ti).ToList<Title>();
                        lMessagesDaily = (from ms in context.Messages
                                          where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                              && ms.Daily == true
                                          select ms).ToList<Message>();
                        #endregion Print Data

                        if (String.IsNullOrEmpty(lFile))
                        {
                            lFile = "IrrigationSystem-" + lDate;
                        }
                        else
                        {
                            lFile = lFile + "-" + lDate;
                        }

                        lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                        #endregion

                        #region CSV Data
                        //create the file
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitles;
                        lOutputFile.FileMessages = lMessages;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #region CSV Daily Record
                        //create the file
                        lFile += "-DailyRecord-";
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitlesDaily;
                        lOutputFile.FileMessages = lMessagesDaily;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #endregion
                        #endregion
                    }

                    #region 2016

                    #region Del Lago - El Mirador Pivot 1 2016
                    lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_01_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLaTribu
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador1
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador1
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador1)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 2 2016
                    lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_02_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLaTribu
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador2
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador2
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador2)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 3 2016
                    lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_03_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLaTribu
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador3
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador3
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador3)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 4 2016
                    lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_04_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLaTribu
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador4
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador4
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador4)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 5 2016
                    lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_05_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLaTribu
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador5
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador5
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador5)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 6 2016
                    lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_06_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLaTribu
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador6
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador6
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador6)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 7 2016
                    lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_07_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLaTribu
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador7
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador7
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador7)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 8 2016
                    lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_08_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLaTribu
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador8
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador8
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador8)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 9 2016
                    lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_09_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLaTribu
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador9
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador9
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador9)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 10 2016
                    //lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_10_Maiz_2016";

                    //#region context
                    //lEffectiveRainList = (from effectiverain in context.EffectiveRains
                    //                      where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                    //                      select effectiverain)
                    //                         .ToList<EffectiveRain>();

                    //lFarm = (from farm in context.Farms
                    //         where farm.Name == Utils.NameFarmDelLagoElMirador
                    //         select farm).FirstOrDefault();
                    //lWeatherStationMain = (from ws in context.WeatherStations
                    //                       where ws.Name == Utils.NameWeatherStationLaTribu
                    //                       select ws).FirstOrDefault();
                    //lWeatherStationAlternative = (from ws in context.WeatherStations
                    //                              where ws.Name == Utils.NameWeatherStationLaEstanzuela
                    //                              select ws).FirstOrDefault();

                    //lCrop = (from crop in context.Crops
                    //         where crop.Name == Utils.NameSpecieCornSouthShort
                    //         select crop).FirstOrDefault();
                    //lCropInformationByDate = (from cid in context.CropInformationByDates
                    //                          where cid.Name == Utils.NameSpecieCornSouthShort
                    //                          select cid).FirstOrDefault();
                    //lCropCoefficient = (from cc in context.CropCoefficients
                    //                    where cc.Name == Utils.NameSpecieCornSouthShort
                    //                    select cc).FirstOrDefault();
                    //lKCList = (from cc in context.CropCoefficients
                    //           where cc.Name == Utils.NameSpecieCornSouthShort
                    //           select cc.KCList)
                    //                     .FirstOrDefault();

                    //lIrrigationUnit = (from iu in context.Pivots
                    //                   where iu.Name == Utils.NamePivotDelLagoElMirador10
                    //                   select iu).FirstOrDefault();
                    //lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                    //                          where ciw.CropId == lCrop.CropId
                    //                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                    //                                  && ciw.SowingDate <= Program.DateOfReference
                    //                                  && ciw.HarvestDate >= Program.DateOfReference
                    //                          select ciw).FirstOrDefault();
                    //lIrrigationList = (from ilist in context.Irrigations
                    //                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                   select ilist).ToList<Irrigation>();
                    //lRainList = (from rlist in context.Rains
                    //             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //             select rlist).ToList<Rain>();

                    //lSowingDate = lCropIrrigationWeather.SowingDate;
                    //lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    //lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                        join weatherstation in context.WeatherStations
                    //                        on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                        where (weatherdata.Date >= lSowingDate &&
                    //                                weatherdata.Date <= lHarvestDate) &&
                    //                                weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                    //                        select weatherdata).ToList<WeatherData>();
                    //lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                               join weatherstation in context.WeatherStations
                    //                               on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                               where (weatherdata.Date >= lSowingDate &&
                    //                                    weatherdata.Date <= lHarvestDate) &&
                    //                                    weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                    //                               select weatherdata).ToList<WeatherData>();
                    //lSoil = (from soil in context.Soils
                    //         where soil.Name == Utils.NameSoilDelLagoElMirador10
                    //         select soil).FirstOrDefault();
                    //lHorizonList = (from horizon in context.Horizons
                    //                where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador10)
                    //                select horizon)
                    //                .ToList<Horizon>();
                    //#endregion

                    //#region TextLog
                    //lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    //lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

                    //#region Print Data - Titles & Messages
                    //lTitles = (from ti in context.Titles
                    //           where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //              && ti.Daily == false
                    //           select ti).ToList<Title>();
                    //lMessages = (from ms in context.Messages
                    //             where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                 && ms.Daily == false
                    //             select ms).ToList<Message>();

                    //lTitlesDaily = (from ti in context.Titles
                    //                where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                   && ti.Daily == true
                    //                select ti).ToList<Title>();
                    //lMessagesDaily = (from ms in context.Messages
                    //                  where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                      && ms.Daily == true
                    //                  select ms).ToList<Message>();
                    //#endregion Print Data

                    //if (String.IsNullOrEmpty(lFile))
                    //{
                    //    lFile = "IrrigationSystem-" + lDate;
                    //}
                    //else
                    //{
                    //    lFile = lFile + "-" + lDate;
                    //}

                    //lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    //#endregion

                    //#region CSV Data
                    ////create the file
                    //lOutputFile = new OutputFileCSV(lFile);
                    //lFolderName = lOutputFile.FolderName;
                    //lFilePath = lOutputFile.FilePath;
                    //lDataSplit = lOutputFile.DataSplit;

                    //lMethod = "Layout Daily Records";
                    //lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    //lTime = System.DateTime.Now.ToString();
                    //lDate = System.DateTime.Today.Year.ToString() +
                    //    System.DateTime.Today.Month.ToString() +
                    //    System.DateTime.Today.Day.ToString();

                    ////Output of file information
                    //lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    //lOutputFile.FileTitles = lTitles;
                    //lOutputFile.FileMessages = lMessages;
                    //lOutputFile.FileFooter = "Finish all the information.";

                    ////Writes the CSV file in the FilePath
                    //lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    //#endregion

                    //#region CSV Daily Record
                    ////create the file
                    //lFile += "-DailyRecord-";
                    //lOutputFile = new OutputFileCSV(lFile);
                    //lFolderName = lOutputFile.FolderName;
                    //lFilePath = lOutputFile.FilePath;
                    //lDataSplit = lOutputFile.DataSplit;

                    //lMethod = "Layout Daily Records";
                    //lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    //lTime = System.DateTime.Now.ToString();
                    //lDate = System.DateTime.Today.Year.ToString() +
                    //    System.DateTime.Today.Month.ToString() +
                    //    System.DateTime.Today.Day.ToString();

                    ////Output of file information
                    //lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    //lOutputFile.FileTitles = lTitlesDaily;
                    //lOutputFile.FileMessages = lMessagesDaily;
                    //lOutputFile.FileFooter = "Finish all the information.";

                    ////Writes the CSV file in the FilePath
                    //lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    //#endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 11 2016
                    //lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_11_Maiz_2016";

                    //#region context
                    //lEffectiveRainList = (from effectiverain in context.EffectiveRains
                    //                      where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                    //                      select effectiverain)
                    //                         .ToList<EffectiveRain>();

                    //lFarm = (from farm in context.Farms
                    //         where farm.Name == Utils.NameFarmDelLagoElMirador
                    //         select farm).FirstOrDefault();
                    //lWeatherStationMain = (from ws in context.WeatherStations
                    //                       where ws.Name == Utils.NameWeatherStationLaTribu
                    //                       select ws).FirstOrDefault();
                    //lWeatherStationAlternative = (from ws in context.WeatherStations
                    //                              where ws.Name == Utils.NameWeatherStationLaEstanzuela
                    //                              select ws).FirstOrDefault();

                    //lCrop = (from crop in context.Crops
                    //         where crop.Name == Utils.NameSpecieCornSouthShort
                    //         select crop).FirstOrDefault();
                    //lCropInformationByDate = (from cid in context.CropInformationByDates
                    //                          where cid.Name == Utils.NameSpecieCornSouthShort
                    //                          select cid).FirstOrDefault();
                    //lCropCoefficient = (from cc in context.CropCoefficients
                    //                    where cc.Name == Utils.NameSpecieCornSouthShort
                    //                    select cc).FirstOrDefault();
                    //lKCList = (from cc in context.CropCoefficients
                    //           where cc.Name == Utils.NameSpecieCornSouthShort
                    //           select cc.KCList)
                    //                     .FirstOrDefault();

                    //lIrrigationUnit = (from iu in context.Pivots
                    //                   where iu.Name == Utils.NamePivotDelLagoElMirador11
                    //                   select iu).FirstOrDefault();
                    //lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                    //                          where ciw.CropId == lCrop.CropId
                    //                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                    //                                  && ciw.SowingDate <= Program.DateOfReference
                    //                                  && ciw.HarvestDate >= Program.DateOfReference
                    //                          select ciw).FirstOrDefault();
                    //lIrrigationList = (from ilist in context.Irrigations
                    //                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                   select ilist).ToList<Irrigation>();
                    //lRainList = (from rlist in context.Rains
                    //             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //             select rlist).ToList<Rain>();

                    //lSowingDate = lCropIrrigationWeather.SowingDate;
                    //lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    //lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                        join weatherstation in context.WeatherStations
                    //                        on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                        where (weatherdata.Date >= lSowingDate &&
                    //                                weatherdata.Date <= lHarvestDate) &&
                    //                                weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                    //                        select weatherdata).ToList<WeatherData>();
                    //lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                               join weatherstation in context.WeatherStations
                    //                               on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                               where (weatherdata.Date >= lSowingDate &&
                    //                                    weatherdata.Date <= lHarvestDate) &&
                    //                                    weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                    //                               select weatherdata).ToList<WeatherData>();
                    //lSoil = (from soil in context.Soils
                    //         where soil.Name == Utils.NameSoilDelLagoElMirador11
                    //         select soil).FirstOrDefault();
                    //lHorizonList = (from horizon in context.Horizons
                    //                where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador11)
                    //                select horizon)
                    //                .ToList<Horizon>();
                    //#endregion

                    //#region TextLog
                    //lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    //lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

                    //#region Print Data - Titles & Messages
                    //lTitles = (from ti in context.Titles
                    //           where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //              && ti.Daily == false
                    //           select ti).ToList<Title>();
                    //lMessages = (from ms in context.Messages
                    //             where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                 && ms.Daily == false
                    //             select ms).ToList<Message>();

                    //lTitlesDaily = (from ti in context.Titles
                    //                where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                   && ti.Daily == true
                    //                select ti).ToList<Title>();
                    //lMessagesDaily = (from ms in context.Messages
                    //                  where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                      && ms.Daily == true
                    //                  select ms).ToList<Message>();
                    //#endregion Print Data

                    //if (String.IsNullOrEmpty(lFile))
                    //{
                    //    lFile = "IrrigationSystem-" + lDate;
                    //}
                    //else
                    //{
                    //    lFile = lFile + "-" + lDate;
                    //}

                    //lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    //#endregion

                    //#region CSV Data
                    ////create the file
                    //lOutputFile = new OutputFileCSV(lFile);
                    //lFolderName = lOutputFile.FolderName;
                    //lFilePath = lOutputFile.FilePath;
                    //lDataSplit = lOutputFile.DataSplit;

                    //lMethod = "Layout Daily Records";
                    //lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    //lTime = System.DateTime.Now.ToString();
                    //lDate = System.DateTime.Today.Year.ToString() +
                    //    System.DateTime.Today.Month.ToString() +
                    //    System.DateTime.Today.Day.ToString();

                    ////Output of file information
                    //lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    //lOutputFile.FileTitles = lTitles;
                    //lOutputFile.FileMessages = lMessages;
                    //lOutputFile.FileFooter = "Finish all the information.";

                    ////Writes the CSV file in the FilePath
                    //lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    //#endregion

                    //#region CSV Daily Record
                    ////create the file
                    //lFile += "-DailyRecord-";
                    //lOutputFile = new OutputFileCSV(lFile);
                    //lFolderName = lOutputFile.FolderName;
                    //lFilePath = lOutputFile.FilePath;
                    //lDataSplit = lOutputFile.DataSplit;

                    //lMethod = "Layout Daily Records";
                    //lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    //lTime = System.DateTime.Now.ToString();
                    //lDate = System.DateTime.Today.Year.ToString() +
                    //    System.DateTime.Today.Month.ToString() +
                    //    System.DateTime.Today.Day.ToString();

                    ////Output of file information
                    //lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    //lOutputFile.FileTitles = lTitlesDaily;
                    //lOutputFile.FileMessages = lMessagesDaily;
                    //lOutputFile.FileFooter = "Finish all the information.";

                    ////Writes the CSV file in the FilePath
                    //lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    //#endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 12 2016
                    lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_12_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLaTribu
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador12
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador12
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador12)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 13 2016
                    //lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_13_Maiz_2016";

                    //#region context
                    //lEffectiveRainList = (from effectiverain in context.EffectiveRains
                    //                      where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                    //                      select effectiverain)
                    //                         .ToList<EffectiveRain>();

                    //lFarm = (from farm in context.Farms
                    //         where farm.Name == Utils.NameFarmDelLagoElMirador
                    //         select farm).FirstOrDefault();
                    //lWeatherStationMain = (from ws in context.WeatherStations
                    //                       where ws.Name == Utils.NameWeatherStationLaTribu
                    //                       select ws).FirstOrDefault();
                    //lWeatherStationAlternative = (from ws in context.WeatherStations
                    //                              where ws.Name == Utils.NameWeatherStationLaEstanzuela
                    //                              select ws).FirstOrDefault();

                    //lCrop = (from crop in context.Crops
                    //         where crop.Name == Utils.NameSpecieCornSouthShort
                    //         select crop).FirstOrDefault();
                    //lCropInformationByDate = (from cid in context.CropInformationByDates
                    //                          where cid.Name == Utils.NameSpecieCornSouthShort
                    //                          select cid).FirstOrDefault();
                    //lCropCoefficient = (from cc in context.CropCoefficients
                    //                    where cc.Name == Utils.NameSpecieCornSouthShort
                    //                    select cc).FirstOrDefault();
                    //lKCList = (from cc in context.CropCoefficients
                    //           where cc.Name == Utils.NameSpecieCornSouthShort
                    //           select cc.KCList)
                    //                     .FirstOrDefault();

                    //lIrrigationUnit = (from iu in context.Pivots
                    //                   where iu.Name == Utils.NamePivotDelLagoElMirador13
                    //                   select iu).FirstOrDefault();
                    //lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                    //                          where ciw.CropId == lCrop.CropId
                    //                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                    //                                  && ciw.SowingDate <= Program.DateOfReference
                    //                                  && ciw.HarvestDate >= Program.DateOfReference
                    //                          select ciw).FirstOrDefault();
                    //lIrrigationList = (from ilist in context.Irrigations
                    //                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                   select ilist).ToList<Irrigation>();
                    //lRainList = (from rlist in context.Rains
                    //             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //             select rlist).ToList<Rain>();

                    //lSowingDate = lCropIrrigationWeather.SowingDate;
                    //lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    //lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                        join weatherstation in context.WeatherStations
                    //                        on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                        where (weatherdata.Date >= lSowingDate &&
                    //                                weatherdata.Date <= lHarvestDate) &&
                    //                                weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                    //                        select weatherdata).ToList<WeatherData>();
                    //lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                               join weatherstation in context.WeatherStations
                    //                               on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                               where (weatherdata.Date >= lSowingDate &&
                    //                                    weatherdata.Date <= lHarvestDate) &&
                    //                                    weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                    //                               select weatherdata).ToList<WeatherData>();
                    //lSoil = (from soil in context.Soils
                    //         where soil.Name == Utils.NameSoilDelLagoElMirador13
                    //         select soil).FirstOrDefault();
                    //lHorizonList = (from horizon in context.Horizons
                    //                where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador13)
                    //                select horizon)
                    //                .ToList<Horizon>();
                    //#endregion

                    //#region TextLog
                    //lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    //lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

                    //#region Print Data - Titles & Messages
                    //lTitles = (from ti in context.Titles
                    //           where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //              && ti.Daily == false
                    //           select ti).ToList<Title>();
                    //lMessages = (from ms in context.Messages
                    //             where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                 && ms.Daily == false
                    //             select ms).ToList<Message>();

                    //lTitlesDaily = (from ti in context.Titles
                    //                where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                   && ti.Daily == true
                    //                select ti).ToList<Title>();
                    //lMessagesDaily = (from ms in context.Messages
                    //                  where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                      && ms.Daily == true
                    //                  select ms).ToList<Message>();
                    //#endregion Print Data

                    //if (String.IsNullOrEmpty(lFile))
                    //{
                    //    lFile = "IrrigationSystem-" + lDate;
                    //}
                    //else
                    //{
                    //    lFile = lFile + "-" + lDate;
                    //}

                    //lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    //#endregion

                    //#region CSV Data
                    ////create the file
                    //lOutputFile = new OutputFileCSV(lFile);
                    //lFolderName = lOutputFile.FolderName;
                    //lFilePath = lOutputFile.FilePath;
                    //lDataSplit = lOutputFile.DataSplit;

                    //lMethod = "Layout Daily Records";
                    //lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    //lTime = System.DateTime.Now.ToString();
                    //lDate = System.DateTime.Today.Year.ToString() +
                    //    System.DateTime.Today.Month.ToString() +
                    //    System.DateTime.Today.Day.ToString();

                    ////Output of file information
                    //lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    //lOutputFile.FileTitles = lTitles;
                    //lOutputFile.FileMessages = lMessages;
                    //lOutputFile.FileFooter = "Finish all the information.";

                    ////Writes the CSV file in the FilePath
                    //lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    //#endregion

                    //#region CSV Daily Record
                    ////create the file
                    //lFile += "-DailyRecord-";
                    //lOutputFile = new OutputFileCSV(lFile);
                    //lFolderName = lOutputFile.FolderName;
                    //lFilePath = lOutputFile.FilePath;
                    //lDataSplit = lOutputFile.DataSplit;

                    //lMethod = "Layout Daily Records";
                    //lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    //lTime = System.DateTime.Now.ToString();
                    //lDate = System.DateTime.Today.Year.ToString() +
                    //    System.DateTime.Today.Month.ToString() +
                    //    System.DateTime.Today.Day.ToString();

                    ////Output of file information
                    //lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    //lOutputFile.FileTitles = lTitlesDaily;
                    //lOutputFile.FileMessages = lMessagesDaily;
                    //lOutputFile.FileFooter = "Finish all the information.";

                    ////Writes the CSV file in the FilePath
                    //lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    //#endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 14 2016
                    lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_14_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLaTribu
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador14
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador14
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador14)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 15 2016
                    lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_15_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLaTribu
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador15
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador15
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador15)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot Chaja 1 2016
                    //lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_Chaja_01_Maiz_2016";

                    //#region context
                    //lEffectiveRainList = (from effectiverain in context.EffectiveRains
                    //                      where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                    //                      select effectiverain)
                    //                         .ToList<EffectiveRain>();

                    //lFarm = (from farm in context.Farms
                    //         where farm.Name == Utils.NameFarmDelLagoElMirador
                    //         select farm).FirstOrDefault();
                    //lWeatherStationMain = (from ws in context.WeatherStations
                    //                       where ws.Name == Utils.NameWeatherStationLaTribu
                    //                       select ws).FirstOrDefault();
                    //lWeatherStationAlternative = (from ws in context.WeatherStations
                    //                              where ws.Name == Utils.NameWeatherStationLaEstanzuela
                    //                              select ws).FirstOrDefault();

                    //lCrop = (from crop in context.Crops
                    //         where crop.Name == Utils.NameSpecieCornSouthShort
                    //         select crop).FirstOrDefault();
                    //lCropInformationByDate = (from cid in context.CropInformationByDates
                    //                          where cid.Name == Utils.NameSpecieCornSouthShort
                    //                          select cid).FirstOrDefault();
                    //lCropCoefficient = (from cc in context.CropCoefficients
                    //                    where cc.Name == Utils.NameSpecieCornSouthShort
                    //                    select cc).FirstOrDefault();
                    //lKCList = (from cc in context.CropCoefficients
                    //           where cc.Name == Utils.NameSpecieCornSouthShort
                    //           select cc.KCList)
                    //                     .FirstOrDefault();

                    //lIrrigationUnit = (from iu in context.Pivots
                    //                   where iu.Name == Utils.NamePivotDelLagoElMiradorChaja1
                    //                   select iu).FirstOrDefault();
                    //lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                    //                          where ciw.CropId == lCrop.CropId
                    //                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                    //                                  && ciw.SowingDate <= Program.DateOfReference
                    //                                  && ciw.HarvestDate >= Program.DateOfReference
                    //                          select ciw).FirstOrDefault();
                    //lIrrigationList = (from ilist in context.Irrigations
                    //                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                   select ilist).ToList<Irrigation>();
                    //lRainList = (from rlist in context.Rains
                    //             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //             select rlist).ToList<Rain>();

                    //lSowingDate = lCropIrrigationWeather.SowingDate;
                    //lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    //lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                        join weatherstation in context.WeatherStations
                    //                        on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                        where (weatherdata.Date >= lSowingDate &&
                    //                                weatherdata.Date <= lHarvestDate) &&
                    //                                weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                    //                        select weatherdata).ToList<WeatherData>();
                    //lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                               join weatherstation in context.WeatherStations
                    //                               on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                               where (weatherdata.Date >= lSowingDate &&
                    //                                    weatherdata.Date <= lHarvestDate) &&
                    //                                    weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                    //                               select weatherdata).ToList<WeatherData>();
                    //lSoil = (from soil in context.Soils
                    //         where soil.Name == Utils.NameSoilDelLagoElMiradorChaja1
                    //         select soil).FirstOrDefault();
                    //lHorizonList = (from horizon in context.Horizons
                    //                where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMiradorChaja1)
                    //                select horizon)
                    //                .ToList<Horizon>();
                    //#endregion

                    //#region TextLog
                    //lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    //lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

                    //#region Print Data - Titles & Messages
                    //lTitles = (from ti in context.Titles
                    //           where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //              && ti.Daily == false
                    //           select ti).ToList<Title>();
                    //lMessages = (from ms in context.Messages
                    //             where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                 && ms.Daily == false
                    //             select ms).ToList<Message>();

                    //lTitlesDaily = (from ti in context.Titles
                    //                where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                   && ti.Daily == true
                    //                select ti).ToList<Title>();
                    //lMessagesDaily = (from ms in context.Messages
                    //                  where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                      && ms.Daily == true
                    //                  select ms).ToList<Message>();
                    //#endregion Print Data

                    //if (String.IsNullOrEmpty(lFile))
                    //{
                    //    lFile = "IrrigationSystem-" + lDate;
                    //}
                    //else
                    //{
                    //    lFile = lFile + "-" + lDate;
                    //}

                    //lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    //#endregion

                    //#region CSV Data
                    ////create the file
                    //lOutputFile = new OutputFileCSV(lFile);
                    //lFolderName = lOutputFile.FolderName;
                    //lFilePath = lOutputFile.FilePath;
                    //lDataSplit = lOutputFile.DataSplit;

                    //lMethod = "Layout Daily Records";
                    //lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    //lTime = System.DateTime.Now.ToString();
                    //lDate = System.DateTime.Today.Year.ToString() +
                    //    System.DateTime.Today.Month.ToString() +
                    //    System.DateTime.Today.Day.ToString();

                    ////Output of file information
                    //lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    //lOutputFile.FileTitles = lTitles;
                    //lOutputFile.FileMessages = lMessages;
                    //lOutputFile.FileFooter = "Finish all the information.";

                    ////Writes the CSV file in the FilePath
                    //lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    //#endregion

                    //#region CSV Daily Record
                    ////create the file
                    //lFile += "-DailyRecord-";
                    //lOutputFile = new OutputFileCSV(lFile);
                    //lFolderName = lOutputFile.FolderName;
                    //lFilePath = lOutputFile.FilePath;
                    //lDataSplit = lOutputFile.DataSplit;

                    //lMethod = "Layout Daily Records";
                    //lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    //lTime = System.DateTime.Now.ToString();
                    //lDate = System.DateTime.Today.Year.ToString() +
                    //    System.DateTime.Today.Month.ToString() +
                    //    System.DateTime.Today.Day.ToString();

                    ////Output of file information
                    //lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    //lOutputFile.FileTitles = lTitlesDaily;
                    //lOutputFile.FileMessages = lMessagesDaily;
                    //lOutputFile.FileFooter = "Finish all the information.";

                    ////Writes the CSV file in the FilePath
                    //lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    //#endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot Chaja 2 2016
                    //lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_Chaja_02_Maiz_2016";

                    //#region context 
                    //lEffectiveRainList = (from effectiverain in context.EffectiveRains
                    //                      where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                    //                      select effectiverain)
                    //                         .ToList<EffectiveRain>();

                    //lFarm = (from farm in context.Farms
                    //         where farm.Name == Utils.NameFarmDelLagoElMirador
                    //         select farm).FirstOrDefault();
                    //lWeatherStationMain = (from ws in context.WeatherStations
                    //                       where ws.Name == Utils.NameWeatherStationLaTribu
                    //                       select ws).FirstOrDefault();
                    //lWeatherStationAlternative = (from ws in context.WeatherStations
                    //                              where ws.Name == Utils.NameWeatherStationLaEstanzuela
                    //                              select ws).FirstOrDefault();

                    //lCrop = (from crop in context.Crops
                    //         where crop.Name == Utils.NameSpecieCornSouthShort
                    //         select crop).FirstOrDefault();
                    //lCropInformationByDate = (from cid in context.CropInformationByDates
                    //                          where cid.Name == Utils.NameSpecieCornSouthShort
                    //                          select cid).FirstOrDefault();
                    //lCropCoefficient = (from cc in context.CropCoefficients
                    //                    where cc.Name == Utils.NameSpecieCornSouthShort
                    //                    select cc).FirstOrDefault();
                    //lKCList = (from cc in context.CropCoefficients
                    //           where cc.Name == Utils.NameSpecieCornSouthShort
                    //           select cc.KCList)
                    //                     .FirstOrDefault();

                    //lIrrigationUnit = (from iu in context.Pivots
                    //                   where iu.Name == Utils.NamePivotDelLagoElMiradorChaja2
                    //                   select iu).FirstOrDefault();
                    //lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                    //                          where ciw.CropId == lCrop.CropId
                    //                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                    //                                  && ciw.SowingDate <= Program.DateOfReference
                    //                                  && ciw.HarvestDate >= Program.DateOfReference
                    //                          select ciw).FirstOrDefault();
                    //lIrrigationList = (from ilist in context.Irrigations
                    //                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                   select ilist).ToList<Irrigation>();
                    //lRainList = (from rlist in context.Rains
                    //             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //             select rlist).ToList<Rain>();

                    //lSowingDate = lCropIrrigationWeather.SowingDate;
                    //lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    //lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                        join weatherstation in context.WeatherStations
                    //                        on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                        where (weatherdata.Date >= lSowingDate &&
                    //                                weatherdata.Date <= lHarvestDate) &&
                    //                                weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                    //                        select weatherdata).ToList<WeatherData>();
                    //lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                               join weatherstation in context.WeatherStations
                    //                               on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                               where (weatherdata.Date >= lSowingDate &&
                    //                                    weatherdata.Date <= lHarvestDate) &&
                    //                                    weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                    //                               select weatherdata).ToList<WeatherData>();
                    //lSoil = (from soil in context.Soils
                    //         where soil.Name == Utils.NameSoilDelLagoElMiradorChaja2
                    //         select soil).FirstOrDefault();
                    //lHorizonList = (from horizon in context.Horizons
                    //                where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMiradorChaja2)
                    //                select horizon)
                    //                .ToList<Horizon>();
                    //#endregion

                    //#region TextLog
                    //lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    //lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

                    //#region Print Data - Titles & Messages
                    //lTitles = (from ti in context.Titles
                    //           where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //              && ti.Daily == false
                    //           select ti).ToList<Title>();
                    //lMessages = (from ms in context.Messages
                    //             where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                 && ms.Daily == false
                    //             select ms).ToList<Message>();

                    //lTitlesDaily = (from ti in context.Titles
                    //                where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                   && ti.Daily == true
                    //                select ti).ToList<Title>();
                    //lMessagesDaily = (from ms in context.Messages
                    //                  where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                    //                      && ms.Daily == true
                    //                  select ms).ToList<Message>();
                    //#endregion Print Data

                    //if (String.IsNullOrEmpty(lFile))
                    //{
                    //    lFile = "IrrigationSystem-" + lDate;
                    //}
                    //else
                    //{
                    //    lFile = lFile + "-" + lDate;
                    //}

                    //lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    //#endregion

                    //#region CSV Data
                    ////create the file
                    //lOutputFile = new OutputFileCSV(lFile);
                    //lFolderName = lOutputFile.FolderName;
                    //lFilePath = lOutputFile.FilePath;
                    //lDataSplit = lOutputFile.DataSplit;

                    //lMethod = "Layout Daily Records";
                    //lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    //lTime = System.DateTime.Now.ToString();
                    //lDate = System.DateTime.Today.Year.ToString() +
                    //    System.DateTime.Today.Month.ToString() +
                    //    System.DateTime.Today.Day.ToString();

                    ////Output of file information
                    //lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    //lOutputFile.FileTitles = lTitles;
                    //lOutputFile.FileMessages = lMessages;
                    //lOutputFile.FileFooter = "Finish all the information.";

                    ////Writes the CSV file in the FilePath
                    //lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    //#endregion

                    //#region CSV Daily Record
                    ////create the file
                    //lFile += "-DailyRecord-";
                    //lOutputFile = new OutputFileCSV(lFile);
                    //lFolderName = lOutputFile.FolderName;
                    //lFilePath = lOutputFile.FilePath;
                    //lDataSplit = lOutputFile.DataSplit;

                    //lMethod = "Layout Daily Records";
                    //lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    //lTime = System.DateTime.Now.ToString();
                    //lDate = System.DateTime.Today.Year.ToString() +
                    //    System.DateTime.Today.Month.ToString() +
                    //    System.DateTime.Today.Day.ToString();

                    ////Output of file information
                    //lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    //lOutputFile.FileTitles = lTitlesDaily;
                    //lOutputFile.FileMessages = lMessagesDaily;
                    //lOutputFile.FileFooter = "Finish all the information.";

                    ////Writes the CSV file in the FilePath
                    //lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    //#endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 1b 2016
                    lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_01b_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == DataEntry.WeatherStationMainName_DelLagoElMirador_2016b
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == DataEntry.WeatherStationAlternativeName_DelLagoElMirador_2016b
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthMedium
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthMedium
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthMedium
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthMedium
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador1b
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador1b
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador1b)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 2b 2016
                    lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_02b_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLaTribu
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthMedium
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthMedium
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthMedium
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthMedium
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador2b
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador2b
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador2b)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 3b 2016
                    lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_03b_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLaTribu
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthMedium
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthMedium
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthMedium
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthMedium
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador3b
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador3b
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador3b)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region Del Lago - El Mirador Pivot 4b 2016
                    lFile = "IrrigationSystem_DelLago_ElMirador_Pivot_04b_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLaTribu
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthMedium
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthMedium
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthMedium
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthMedium
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador4b
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador4b
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador4b)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitlesDaily;
                    lOutputFile.FileMessages = lMessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #endregion
                }
                #endregion

                #region GMO - La Palma
                if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOLaPalma)
                {
                    if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All)
                    {
                        #region 2015

                        #region La Palma Pivot 2A 2015
                        lFile = "IrrigationSystem_LaPalma_Pivot_2A_Maiz_2015";

                        lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                              where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                              select effectiverain)
                                                 .ToList<EffectiveRain>();

                        lFarm = (from farm in context.Farms
                                 where farm.Name == Utils.NameFarmGMOLaPalma
                                 select farm).FirstOrDefault();
                        lWeatherStationMain = (from ws in context.WeatherStations
                                               where ws.Name == Utils.NameWeatherStationLasBrujas
                                               select ws).FirstOrDefault();
                        lWeatherStationAlternative = (from ws in context.WeatherStations
                                                      where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                      select ws).FirstOrDefault();

                        lCrop = (from crop in context.Crops
                                 where crop.Name == Utils.NameSpecieCornSouthShort
                                 select crop).FirstOrDefault();
                        lCropInformationByDate = (from cid in context.CropInformationByDates
                                                  where cid.Name == Utils.NameSpecieCornSouthShort
                                                  select cid).FirstOrDefault();
                        lCropCoefficient = (from cc in context.CropCoefficients
                                            where cc.Name == Utils.NameSpecieCornSouthShort
                                            select cc).FirstOrDefault();
                        lKCList = (from cc in context.CropCoefficients
                                   where cc.Name == Utils.NameSpecieCornSouthShort
                                   select cc.KCList)
                                             .FirstOrDefault();

                        lIrrigationUnit = (from iu in context.Pivots
                                           where iu.Name == Utils.NamePivotGMOLaPalma2
                                           select iu).FirstOrDefault();
                        lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                                  where ciw.CropId == lCrop.CropId
                                                      && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                                  select ciw).FirstOrDefault();
                        lIrrigationList = (from ilist in context.Irrigations
                                           where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           select ilist).ToList<Irrigation>();
                        lRainList = (from rlist in context.Rains
                                     where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     select rlist).ToList<Rain>();

                        lSowingDate = lCropIrrigationWeather.SowingDate;
                        lHarvestDate = lCropIrrigationWeather.HarvestDate;
                        lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                                join weatherstation in context.WeatherStations
                                                on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                                select weatherdata).ToList<WeatherData>();
                        lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                       join weatherstation in context.WeatherStations
                                                       on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                       where (weatherdata.Date >= lSowingDate &&
                                                            weatherdata.Date <= lHarvestDate) &&
                                                            weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                       select weatherdata).ToList<WeatherData>();
                        lSoil = (from soil in context.Soils
                                 where soil.Name == Utils.NameSoilGMOLaPalma2
                                 select soil).FirstOrDefault();
                        lHorizonList = (from horizon in context.Horizons
                                        where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma2)
                                        select horizon)
                                        .ToList<Horizon>();

                        #region TextLog
                        lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                        lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                        #region Print Data - Titles & Messages
                        lTitles = (from ti in context.Titles
                                   where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      && ti.Daily == false
                                   select ti).ToList<Title>();
                        lMessages = (from ms in context.Messages
                                     where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                         && ms.Daily == false
                                     select ms).ToList<Message>();

                        lTitlesDaily = (from ti in context.Titles
                                        where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           && ti.Daily == true
                                        select ti).ToList<Title>();
                        lMessagesDaily = (from ms in context.Messages
                                          where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                              && ms.Daily == true
                                          select ms).ToList<Message>();
                        #endregion Print Data

                        if (String.IsNullOrEmpty(lFile))
                        {
                            lFile = "IrrigationSystem-" + lDate;
                        }
                        else
                        {
                            lFile = lFile + "-" + lDate;
                        }

                        lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                        #endregion

                        #region CSV Data
                        //create the file
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitles;
                        lOutputFile.FileMessages = lMessages;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #region CSV Daily Record
                        //create the file
                        lFile += "-DailyRecord-";
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                        lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #endregion

                        #region La Palma Pivot 3 2015
                        lFile = "IrrigationSystem_LaPalma_Pivot_03_Maiz_2015";

                        lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                              where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                              select effectiverain)
                                                 .ToList<EffectiveRain>();

                        lFarm = (from farm in context.Farms
                                 where farm.Name == Utils.NameFarmGMOLaPalma
                                 select farm).FirstOrDefault();
                        lWeatherStationMain = (from ws in context.WeatherStations
                                               where ws.Name == Utils.NameWeatherStationLasBrujas
                                               select ws).FirstOrDefault();
                        lWeatherStationAlternative = (from ws in context.WeatherStations
                                                      where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                      select ws).FirstOrDefault();

                        lCrop = (from crop in context.Crops
                                 where crop.Name == Utils.NameSpecieCornSouthShort
                                 select crop).FirstOrDefault();
                        lCropInformationByDate = (from cid in context.CropInformationByDates
                                                  where cid.Name == Utils.NameSpecieCornSouthShort
                                                  select cid).FirstOrDefault();
                        lCropCoefficient = (from cc in context.CropCoefficients
                                            where cc.Name == Utils.NameSpecieCornSouthShort
                                            select cc).FirstOrDefault();
                        lKCList = (from cc in context.CropCoefficients
                                   where cc.Name == Utils.NameSpecieCornSouthShort
                                   select cc.KCList)
                                             .FirstOrDefault();

                        lIrrigationUnit = (from iu in context.Pivots
                                           where iu.Name == Utils.NamePivotGMOLaPalma3
                                           select iu).FirstOrDefault();
                        lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                                  where ciw.CropId == lCrop.CropId
                                                      && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                                  select ciw).FirstOrDefault();
                        lIrrigationList = (from ilist in context.Irrigations
                                           where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           select ilist).ToList<Irrigation>();
                        lRainList = (from rlist in context.Rains
                                     where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     select rlist).ToList<Rain>();

                        lSowingDate = lCropIrrigationWeather.SowingDate;
                        lHarvestDate = lCropIrrigationWeather.HarvestDate;
                        lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                                join weatherstation in context.WeatherStations
                                                on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                                select weatherdata).ToList<WeatherData>();
                        lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                       join weatherstation in context.WeatherStations
                                                       on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                       where (weatherdata.Date >= lSowingDate &&
                                                            weatherdata.Date <= lHarvestDate) &&
                                                            weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                       select weatherdata).ToList<WeatherData>();
                        lSoil = (from soil in context.Soils
                                 where soil.Name == Utils.NameSoilGMOLaPalma3
                                 select soil).FirstOrDefault();
                        lHorizonList = (from horizon in context.Horizons
                                        where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma3)
                                        select horizon)
                                        .ToList<Horizon>();

                        #region TextLog
                        lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                        lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                        #region Print Data - Titles & Messages
                        lTitles = (from ti in context.Titles
                                   where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      && ti.Daily == false
                                   select ti).ToList<Title>();
                        lMessages = (from ms in context.Messages
                                     where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                         && ms.Daily == false
                                     select ms).ToList<Message>();

                        lTitlesDaily = (from ti in context.Titles
                                        where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           && ti.Daily == true
                                        select ti).ToList<Title>();
                        lMessagesDaily = (from ms in context.Messages
                                          where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                              && ms.Daily == true
                                          select ms).ToList<Message>();
                        #endregion Print Data

                        if (String.IsNullOrEmpty(lFile))
                        {
                            lFile = "IrrigationSystem-" + lDate;
                        }
                        else
                        {
                            lFile = lFile + "-" + lDate;
                        }

                        lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                        #endregion

                        #region CSV Data
                        //create the file
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitles;
                        lOutputFile.FileMessages = lMessages;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #region CSV Daily Record
                        //create the file
                        lFile += "-DailyRecord-";
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                        lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #endregion

                        #region La Palma Pivot 4 2015
                        lFile = "IrrigationSystem_LaPalma_Pivot_04_Maiz_2015";

                        lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                              where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                              select effectiverain)
                                                 .ToList<EffectiveRain>();

                        lFarm = (from farm in context.Farms
                                 where farm.Name == Utils.NameFarmGMOLaPalma
                                 select farm).FirstOrDefault();
                        lWeatherStationMain = (from ws in context.WeatherStations
                                               where ws.Name == Utils.NameWeatherStationLasBrujas
                                               select ws).FirstOrDefault();
                        lWeatherStationAlternative = (from ws in context.WeatherStations
                                                      where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                      select ws).FirstOrDefault();

                        lCrop = (from crop in context.Crops
                                 where crop.Name == Utils.NameSpecieCornSouthShort
                                 select crop).FirstOrDefault();
                        lCropInformationByDate = (from cid in context.CropInformationByDates
                                                  where cid.Name == Utils.NameSpecieCornSouthShort
                                                  select cid).FirstOrDefault();
                        lCropCoefficient = (from cc in context.CropCoefficients
                                            where cc.Name == Utils.NameSpecieCornSouthShort
                                            select cc).FirstOrDefault();
                        lKCList = (from cc in context.CropCoefficients
                                   where cc.Name == Utils.NameSpecieCornSouthShort
                                   select cc.KCList)
                                             .FirstOrDefault();

                        lIrrigationUnit = (from iu in context.Pivots
                                           where iu.Name == Utils.NamePivotGMOLaPalma4
                                           select iu).FirstOrDefault();
                        lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                                  where ciw.CropId == lCrop.CropId
                                                      && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                      && ciw.SowingDate <= Program.DateOfReference
                                                      && ciw.HarvestDate >= Program.DateOfReference
                                                  select ciw).FirstOrDefault();
                        lIrrigationList = (from ilist in context.Irrigations
                                           where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           select ilist).ToList<Irrigation>();
                        lRainList = (from rlist in context.Rains
                                     where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     select rlist).ToList<Rain>();

                        lSowingDate = lCropIrrigationWeather.SowingDate;
                        lHarvestDate = lCropIrrigationWeather.HarvestDate;
                        lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                                join weatherstation in context.WeatherStations
                                                on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                                select weatherdata).ToList<WeatherData>();
                        lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                       join weatherstation in context.WeatherStations
                                                       on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                       where (weatherdata.Date >= lSowingDate &&
                                                            weatherdata.Date <= lHarvestDate) &&
                                                            weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                       select weatherdata).ToList<WeatherData>();
                        lSoil = (from soil in context.Soils
                                 where soil.Name == Utils.NameSoilGMOLaPalma4
                                 select soil).FirstOrDefault();
                        lHorizonList = (from horizon in context.Horizons
                                        where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma4)
                                        select horizon)
                                        .ToList<Horizon>();

                        #region TextLog
                        lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                        lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                        #region Print Data - Titles & Messages
                        lTitles = (from ti in context.Titles
                                   where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      && ti.Daily == false
                                   select ti).ToList<Title>();
                        lMessages = (from ms in context.Messages
                                     where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                         && ms.Daily == false
                                     select ms).ToList<Message>();

                        lTitlesDaily = (from ti in context.Titles
                                        where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                           && ti.Daily == true
                                        select ti).ToList<Title>();
                        lMessagesDaily = (from ms in context.Messages
                                          where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                              && ms.Daily == true
                                          select ms).ToList<Message>();
                        #endregion Print Data

                        if (String.IsNullOrEmpty(lFile))
                        {
                            lFile = "IrrigationSystem-" + lDate;
                        }
                        else
                        {
                            lFile = lFile + "-" + lDate;
                        }

                        lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                        #endregion

                        #region CSV Data
                        //create the file
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lTitles;
                        lOutputFile.FileMessages = lMessages;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #region CSV Daily Record
                        //create the file
                        lFile += "-DailyRecord-";
                        lOutputFile = new OutputFileCSV(lFile);
                        lFolderName = lOutputFile.FolderName;
                        lFilePath = lOutputFile.FilePath;
                        lDataSplit = lOutputFile.DataSplit;

                        lMethod = "Layout Daily Records";
                        lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                        lTime = System.DateTime.Now.ToString();
                        lDate = System.DateTime.Today.Year.ToString() +
                            System.DateTime.Today.Month.ToString() +
                            System.DateTime.Today.Day.ToString();

                        //Output of file information
                        lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                        lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                        lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                        lOutputFile.FileFooter = "Finish all the information.";

                        //Writes the CSV file in the FilePath
                        lOutputFile.WriteFile(lMethod, lDescription, lTime);
                        #endregion

                        #endregion

                        #endregion
                    }

                    #region 2016

                    #region GMO La Palma Pivot 2 2016
                    lFile = "IrrigationSystem_GMOLaPalma_Pivot_2_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOLaPalma
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOLaPalma2
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                    && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                    && ciw.SowingDate <= Program.DateOfReference
                                                    && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilGMOLaPalma2
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma2)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                    lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region GMO La Palma Pivot 3 2016
                    lFile = "IrrigationSystem_GMOLaPalma_Pivot_3_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOLaPalma
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOLaPalma3
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                    && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                    && ciw.SowingDate <= Program.DateOfReference
                                                    && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilGMOLaPalma3
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma3)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                    lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region GMO La Palma Pivot 4 2016
                    lFile = "IrrigationSystem_GMOLaPalma_Pivot_4_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOLaPalma
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOLaPalma4
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                    && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                    && ciw.SowingDate <= Program.DateOfReference
                                                    && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilGMOLaPalma4
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma4)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                    lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #endregion
                }
                #endregion

                #endregion

                #region North

                #region GMO - El Tacuru
                if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                    || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
                {

                    #region 2016

                    #region GMO El Tacuru Pivot 2 2016
                    lFile = "IrrigationSystem_GMOElTacuru_Pivot_2_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOElTacuru
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationSaltoGrande
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornNorthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornNorthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornNorthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornNorthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOElTacuru2a
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                    && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                    && ciw.SowingDate <= Program.DateOfReference
                                                    && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilGMOElTacuru2a
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru2a)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                    lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region GMO El Tacuru Pivot 3 2016
                    lFile = "IrrigationSystem_GMOElTacuru_Pivot_3_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOElTacuru
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationSaltoGrande
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornNorthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornNorthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornNorthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornNorthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOElTacuru3a
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                    && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                    && ciw.SowingDate <= Program.DateOfReference
                                                    && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilGMOElTacuru3a
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru3a)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                    lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #region GMO El Tacuru Pivot 4 2016
                    lFile = "IrrigationSystem_GMOElTacuru_Pivot_4_Maiz_2016";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOElTacuru
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationSaltoGrande
                                                  select ws).FirstOrDefault();

                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornNorthShort
                             select crop).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornNorthShort
                                              select cid).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornNorthShort
                                        select cc).FirstOrDefault();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornNorthShort
                               select cc.KCList)
                                         .FirstOrDefault();

                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOElTacuru4
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                    && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                    && ciw.SowingDate <= Program.DateOfReference
                                                    && ciw.HarvestDate >= Program.DateOfReference
                                              select ciw).FirstOrDefault();
                    lIrrigationList = (from ilist in context.Irrigations
                                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       select ilist).ToList<Irrigation>();
                    lRainList = (from rlist in context.Rains
                                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                 select rlist).ToList<Rain>();

                    lSowingDate = lCropIrrigationWeather.SowingDate;
                    lHarvestDate = lCropIrrigationWeather.HarvestDate;
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate &&
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilGMOElTacuru4
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru4)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + PrintDailyRecordList(lCropIrrigationWeather);

                    #region Print Data - Titles & Messages
                    lTitles = (from ti in context.Titles
                               where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                  && ti.Daily == false
                               select ti).ToList<Title>();
                    lMessages = (from ms in context.Messages
                                 where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                     && ms.Daily == false
                                 select ms).ToList<Message>();

                    lTitlesDaily = (from ti in context.Titles
                                    where ti.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                       && ti.Daily == true
                                    select ti).ToList<Title>();
                    lMessagesDaily = (from ms in context.Messages
                                      where ms.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                          && ms.Daily == true
                                      select ms).ToList<Message>();
                    #endregion Print Data

                    if (String.IsNullOrEmpty(lFile))
                    {
                        lFile = "IrrigationSystem-" + lDate;
                    }
                    else
                    {
                        lFile = lFile + "-" + lDate;
                    }

                    lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
                    #endregion

                    #region CSV Data
                    //create the file
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lTitles;
                    lOutputFile.FileMessages = lMessages;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #region CSV Daily Record
                    //create the file
                    lFile += "-DailyRecord-";
                    lOutputFile = new OutputFileCSV(lFile);
                    lFolderName = lOutputFile.FolderName;
                    lFilePath = lOutputFile.FilePath;
                    lDataSplit = lOutputFile.DataSplit;

                    lMethod = "Layout Daily Records";
                    lDescription = "All the data neccesary for doing a Irrigation Advisor.";
                    lTime = System.DateTime.Now.ToString();
                    lDate = System.DateTime.Today.Year.ToString() +
                        System.DateTime.Today.Month.ToString() +
                        System.DateTime.Today.Day.ToString();

                    //Output of file information
                    lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
                    lOutputFile.FileTitles = lCropIrrigationWeather.TitlesDaily;
                    lOutputFile.FileMessages = lCropIrrigationWeather.MessagesDaily;
                    lOutputFile.FileFooter = "Finish all the information.";

                    //Writes the CSV file in the FilePath
                    lOutputFile.WriteFile(lMethod, lDescription, lTime);
                    #endregion

                    #endregion

                    #endregion
                }

                #endregion

                #endregion
            }
        }

        /// <summary>
        /// Print Daily Record List
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <returns></returns>
        public static String PrintDailyRecordList(CropIrrigationWeather pCropIrrigationWeather)
        {
            String lReturn = Environment.NewLine + "DAILY RECORDS" + Environment.NewLine;
            lReturn += Environment.NewLine + Environment.NewLine;

            foreach (DailyRecord lDailyrecord in pCropIrrigationWeather.DailyRecordList.ToList())
            {
                lReturn += lDailyrecord.ToString() + Environment.NewLine;
            }
            //Add all the messages and titles to print the daily records
            pCropIrrigationWeather.AddToPrintDailyRecords(pCropIrrigationWeather.CropIrrigationWeatherId);
            return lReturn;
        }

    }
}
