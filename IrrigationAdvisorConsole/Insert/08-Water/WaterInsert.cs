using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;

using IrrigationAdvisorConsole.Data;

using IrrigationAdvisor.DBContext;
using NLog;

namespace IrrigationAdvisorConsole.Insert._08_Water
{
    public static class WaterInsert
    {

        #region Water
#if true

        public static void InsertEffectiveRainsSouth()
        {

            #region Base
            var lBase = new EffectiveRain
            {
                Name = Utils.NameBase,
                Month = 0,
                MinRain = 0,
                MaxRain = 0,
                Percentage = 0,
            };
            #endregion

            #region Region South
            //January, February, March, April, May, June, July, August, September, October, November and December

            #region September
            var l0900 = new EffectiveRain { Name = Utils.NameRegionSouth + "0900", Month = 09, MinRain = 0, MaxRain = 10, Percentage = 95 };
            var l0911 = new EffectiveRain { Name = Utils.NameRegionSouth + "0911", Month = 09, MinRain = 11, MaxRain = 20, Percentage = 90 };
            var l0921 = new EffectiveRain { Name = Utils.NameRegionSouth + "0921", Month = 09, MinRain = 21, MaxRain = 30, Percentage = 80 };
            var l0931 = new EffectiveRain { Name = Utils.NameRegionSouth + "0931", Month = 09, MinRain = 31, MaxRain = 40, Percentage = 75 };
            var l0941 = new EffectiveRain { Name = Utils.NameRegionSouth + "0941", Month = 09, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l0951 = new EffectiveRain { Name = Utils.NameRegionSouth + "0951", Month = 09, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l0961 = new EffectiveRain { Name = Utils.NameRegionSouth + "0961", Month = 09, MinRain = 61, MaxRain = 70, Percentage = 65 };
            var l0971 = new EffectiveRain { Name = Utils.NameRegionSouth + "0971", Month = 09, MinRain = 71, MaxRain = 80, Percentage = 60 };
            var l0981 = new EffectiveRain { Name = Utils.NameRegionSouth + "0981", Month = 09, MinRain = 81, MaxRain = 90, Percentage = 60 };
            var l0991 = new EffectiveRain { Name = Utils.NameRegionSouth + "0991", Month = 09, MinRain = 91, MaxRain = 100, Percentage = 55 };
            var l09101 = new EffectiveRain { Name = Utils.NameRegionSouth + "09101", Month = 09, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #region October
            var l1000 = new EffectiveRain { Name = Utils.NameRegionSouth + "1000", Month = 10, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l1011 = new EffectiveRain { Name = Utils.NameRegionSouth + "1011", Month = 10, MinRain = 11, MaxRain = 20, Percentage = 95 };
            var l1021 = new EffectiveRain { Name = Utils.NameRegionSouth + "1021", Month = 10, MinRain = 21, MaxRain = 30, Percentage = 80 };
            var l1031 = new EffectiveRain { Name = Utils.NameRegionSouth + "1031", Month = 10, MinRain = 31, MaxRain = 40, Percentage = 80 };
            var l1041 = new EffectiveRain { Name = Utils.NameRegionSouth + "1041", Month = 10, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l1051 = new EffectiveRain { Name = Utils.NameRegionSouth + "1051", Month = 10, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l1061 = new EffectiveRain { Name = Utils.NameRegionSouth + "1061", Month = 10, MinRain = 61, MaxRain = 70, Percentage = 70 };
            var l1071 = new EffectiveRain { Name = Utils.NameRegionSouth + "1071", Month = 10, MinRain = 71, MaxRain = 80, Percentage = 65 };
            var l1081 = new EffectiveRain { Name = Utils.NameRegionSouth + "1081", Month = 10, MinRain = 81, MaxRain = 90, Percentage = 65 };
            var l1091 = new EffectiveRain { Name = Utils.NameRegionSouth + "1091", Month = 10, MinRain = 91, MaxRain = 100, Percentage = 65 };
            var l10101 = new EffectiveRain { Name = Utils.NameRegionSouth + "10101", Month = 10, MinRain = 101, MaxRain = 1000, Percentage = 60 };
            #endregion

            #region November
            var l1100 = new EffectiveRain { Name = Utils.NameRegionSouth + "1100", Month = 10, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l1111 = new EffectiveRain { Name = Utils.NameRegionSouth + "1111", Month = 11, MinRain = 11, MaxRain = 20, Percentage = 95 };
            var l1121 = new EffectiveRain { Name = Utils.NameRegionSouth + "1121", Month = 11, MinRain = 21, MaxRain = 30, Percentage = 85 };
            var l1131 = new EffectiveRain { Name = Utils.NameRegionSouth + "1131", Month = 11, MinRain = 31, MaxRain = 40, Percentage = 80 };
            var l1141 = new EffectiveRain { Name = Utils.NameRegionSouth + "1141", Month = 11, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l1151 = new EffectiveRain { Name = Utils.NameRegionSouth + "1151", Month = 11, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l1161 = new EffectiveRain { Name = Utils.NameRegionSouth + "1161", Month = 11, MinRain = 61, MaxRain = 70, Percentage = 70 };
            var l1171 = new EffectiveRain { Name = Utils.NameRegionSouth + "1171", Month = 11, MinRain = 71, MaxRain = 80, Percentage = 65 };
            var l1181 = new EffectiveRain { Name = Utils.NameRegionSouth + "1181", Month = 11, MinRain = 81, MaxRain = 90, Percentage = 65 };
            var l1191 = new EffectiveRain { Name = Utils.NameRegionSouth + "1191", Month = 11, MinRain = 91, MaxRain = 100, Percentage = 65 };
            var l11101 = new EffectiveRain { Name = Utils.NameRegionSouth + "11101", Month = 11, MinRain = 101, MaxRain = 1000, Percentage = 60 };
            #endregion

            #region December
            var l1200 = new EffectiveRain { Name = Utils.NameRegionSouth + "1200", Month = 12, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l1211 = new EffectiveRain { Name = Utils.NameRegionSouth + "1211", Month = 12, MinRain = 11, MaxRain = 20, Percentage = 95 };
            var l1221 = new EffectiveRain { Name = Utils.NameRegionSouth + "1221", Month = 12, MinRain = 21, MaxRain = 30, Percentage = 85 };
            var l1231 = new EffectiveRain { Name = Utils.NameRegionSouth + "1231", Month = 12, MinRain = 31, MaxRain = 40, Percentage = 80 };
            var l1241 = new EffectiveRain { Name = Utils.NameRegionSouth + "1241", Month = 12, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l1251 = new EffectiveRain { Name = Utils.NameRegionSouth + "1251", Month = 12, MinRain = 51, MaxRain = 60, Percentage = 75 };
            var l1261 = new EffectiveRain { Name = Utils.NameRegionSouth + "1261", Month = 12, MinRain = 61, MaxRain = 70, Percentage = 75 };
            var l1271 = new EffectiveRain { Name = Utils.NameRegionSouth + "1271", Month = 12, MinRain = 71, MaxRain = 80, Percentage = 75 };
            var l1281 = new EffectiveRain { Name = Utils.NameRegionSouth + "1281", Month = 12, MinRain = 81, MaxRain = 90, Percentage = 70 };
            var l1291 = new EffectiveRain { Name = Utils.NameRegionSouth + "1291", Month = 12, MinRain = 91, MaxRain = 100, Percentage = 70 };
            var l12101 = new EffectiveRain { Name = Utils.NameRegionSouth + "12101", Month = 12, MinRain = 101, MaxRain = 1000, Percentage = 65 };
            #endregion

            #region January
            var l0100 = new EffectiveRain { Name = Utils.NameRegionSouth + "0100", Month = 01, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l0111 = new EffectiveRain { Name = Utils.NameRegionSouth + "0111", Month = 01, MinRain = 11, MaxRain = 20, Percentage = 95 };
            var l0121 = new EffectiveRain { Name = Utils.NameRegionSouth + "0121", Month = 01, MinRain = 21, MaxRain = 30, Percentage = 85 };
            var l0131 = new EffectiveRain { Name = Utils.NameRegionSouth + "0131", Month = 01, MinRain = 31, MaxRain = 40, Percentage = 80 };
            var l0141 = new EffectiveRain { Name = Utils.NameRegionSouth + "0141", Month = 01, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l0151 = new EffectiveRain { Name = Utils.NameRegionSouth + "0151", Month = 01, MinRain = 51, MaxRain = 60, Percentage = 75 };
            var l0161 = new EffectiveRain { Name = Utils.NameRegionSouth + "0161", Month = 01, MinRain = 61, MaxRain = 70, Percentage = 75 };
            var l0171 = new EffectiveRain { Name = Utils.NameRegionSouth + "0171", Month = 01, MinRain = 71, MaxRain = 80, Percentage = 75 };
            var l0181 = new EffectiveRain { Name = Utils.NameRegionSouth + "0181", Month = 01, MinRain = 81, MaxRain = 90, Percentage = 70 };
            var l0191 = new EffectiveRain { Name = Utils.NameRegionSouth + "0191", Month = 01, MinRain = 91, MaxRain = 100, Percentage = 70 };
            var l01101 = new EffectiveRain { Name = Utils.NameRegionSouth + "01101", Month = 01, MinRain = 101, MaxRain = 1000, Percentage = 65 };
            #endregion

            #region February
            var l0200 = new EffectiveRain { Name = Utils.NameRegionSouth + "0200", Month = 02, MinRain = 00, MaxRain = 10, Percentage = 100 };
            var l0211 = new EffectiveRain { Name = Utils.NameRegionSouth + "0211", Month = 02, MinRain = 11, MaxRain = 20, Percentage = 95 };
            var l0221 = new EffectiveRain { Name = Utils.NameRegionSouth + "0221", Month = 02, MinRain = 21, MaxRain = 30, Percentage = 85 };
            var l0231 = new EffectiveRain { Name = Utils.NameRegionSouth + "0231", Month = 02, MinRain = 31, MaxRain = 40, Percentage = 80 };
            var l0241 = new EffectiveRain { Name = Utils.NameRegionSouth + "0241", Month = 02, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l0251 = new EffectiveRain { Name = Utils.NameRegionSouth + "0251", Month = 02, MinRain = 51, MaxRain = 60, Percentage = 75 };
            var l0261 = new EffectiveRain { Name = Utils.NameRegionSouth + "0261", Month = 02, MinRain = 61, MaxRain = 70, Percentage = 70 };
            var l0271 = new EffectiveRain { Name = Utils.NameRegionSouth + "0271", Month = 02, MinRain = 71, MaxRain = 80, Percentage = 65 };
            var l0281 = new EffectiveRain { Name = Utils.NameRegionSouth + "0281", Month = 02, MinRain = 81, MaxRain = 90, Percentage = 65 };
            var l0291 = new EffectiveRain { Name = Utils.NameRegionSouth + "0291", Month = 02, MinRain = 91, MaxRain = 100, Percentage = 65 };
            var l02101 = new EffectiveRain { Name = Utils.NameRegionSouth + "02101", Month = 02, MinRain = 101, MaxRain = 1000, Percentage = 60 };
            #endregion

            #region March
            var l0300 = new EffectiveRain { Name = Utils.NameRegionSouth + "0300", Month = 03, MinRain = 00, MaxRain = 10, Percentage = 100 };
            var l0311 = new EffectiveRain { Name = Utils.NameRegionSouth + "0311", Month = 03, MinRain = 11, MaxRain = 20, Percentage = 95 };
            var l0321 = new EffectiveRain { Name = Utils.NameRegionSouth + "0321", Month = 03, MinRain = 21, MaxRain = 30, Percentage = 80 };
            var l0331 = new EffectiveRain { Name = Utils.NameRegionSouth + "0331", Month = 03, MinRain = 31, MaxRain = 40, Percentage = 75 };
            var l0341 = new EffectiveRain { Name = Utils.NameRegionSouth + "0341", Month = 03, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l0351 = new EffectiveRain { Name = Utils.NameRegionSouth + "0351", Month = 03, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l0361 = new EffectiveRain { Name = Utils.NameRegionSouth + "0361", Month = 03, MinRain = 61, MaxRain = 70, Percentage = 65 };
            var l0371 = new EffectiveRain { Name = Utils.NameRegionSouth + "0371", Month = 03, MinRain = 71, MaxRain = 80, Percentage = 60 };
            var l0381 = new EffectiveRain { Name = Utils.NameRegionSouth + "0381", Month = 03, MinRain = 81, MaxRain = 90, Percentage = 60 };
            var l0391 = new EffectiveRain { Name = Utils.NameRegionSouth + "0391", Month = 03, MinRain = 91, MaxRain = 100, Percentage = 55 };
            var l03101 = new EffectiveRain { Name = Utils.NameRegionSouth + "03101", Month = 03, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #region April
            var l0400 = new EffectiveRain { Name = Utils.NameRegionSouth + "0400", Month = 04, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l0411 = new EffectiveRain { Name = Utils.NameRegionSouth + "0411", Month = 04, MinRain = 11, MaxRain = 20, Percentage = 95 };
            var l0421 = new EffectiveRain { Name = Utils.NameRegionSouth + "0421", Month = 04, MinRain = 21, MaxRain = 30, Percentage = 75 };
            var l0431 = new EffectiveRain { Name = Utils.NameRegionSouth + "0431", Month = 04, MinRain = 31, MaxRain = 40, Percentage = 75 };
            var l0441 = new EffectiveRain { Name = Utils.NameRegionSouth + "0441", Month = 04, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l0451 = new EffectiveRain { Name = Utils.NameRegionSouth + "0451", Month = 04, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l0461 = new EffectiveRain { Name = Utils.NameRegionSouth + "0461", Month = 04, MinRain = 61, MaxRain = 70, Percentage = 65 };
            var l0471 = new EffectiveRain { Name = Utils.NameRegionSouth + "0471", Month = 04, MinRain = 71, MaxRain = 80, Percentage = 60 };
            var l0481 = new EffectiveRain { Name = Utils.NameRegionSouth + "0481", Month = 04, MinRain = 81, MaxRain = 90, Percentage = 60 };
            var l0491 = new EffectiveRain { Name = Utils.NameRegionSouth + "0491", Month = 04, MinRain = 91, MaxRain = 100, Percentage = 55 };
            var l04101 = new EffectiveRain { Name = Utils.NameRegionSouth + "04101", Month = 04, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #region May
            var l0500 = new EffectiveRain { Name = Utils.NameRegionSouth + "0500", Month = 05, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l0511 = new EffectiveRain { Name = Utils.NameRegionSouth + "0511", Month = 05, MinRain = 11, MaxRain = 20, Percentage = 90 };
            var l0521 = new EffectiveRain { Name = Utils.NameRegionSouth + "0521", Month = 05, MinRain = 21, MaxRain = 30, Percentage = 70 };
            var l0531 = new EffectiveRain { Name = Utils.NameRegionSouth + "0531", Month = 05, MinRain = 31, MaxRain = 40, Percentage = 70 };
            var l0541 = new EffectiveRain { Name = Utils.NameRegionSouth + "0541", Month = 05, MinRain = 41, MaxRain = 50, Percentage = 70 };
            var l0551 = new EffectiveRain { Name = Utils.NameRegionSouth + "0551", Month = 05, MinRain = 51, MaxRain = 60, Percentage = 65 };
            var l0561 = new EffectiveRain { Name = Utils.NameRegionSouth + "0561", Month = 05, MinRain = 61, MaxRain = 70, Percentage = 60 };
            var l0571 = new EffectiveRain { Name = Utils.NameRegionSouth + "0571", Month = 05, MinRain = 71, MaxRain = 80, Percentage = 55 };
            var l0581 = new EffectiveRain { Name = Utils.NameRegionSouth + "0581", Month = 05, MinRain = 81, MaxRain = 90, Percentage = 50 };
            var l0591 = new EffectiveRain { Name = Utils.NameRegionSouth + "0591", Month = 05, MinRain = 91, MaxRain = 100, Percentage = 50 };
            var l05101 = new EffectiveRain { Name = Utils.NameRegionSouth + "05101", Month = 05, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #region June
            var l0600 = new EffectiveRain { Name = Utils.NameRegionSouth + "0600", Month = 06, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l0611 = new EffectiveRain { Name = Utils.NameRegionSouth + "0611", Month = 06, MinRain = 11, MaxRain = 20, Percentage = 90 };
            var l0621 = new EffectiveRain { Name = Utils.NameRegionSouth + "0621", Month = 06, MinRain = 21, MaxRain = 30, Percentage = 70 };
            var l0631 = new EffectiveRain { Name = Utils.NameRegionSouth + "0631", Month = 06, MinRain = 31, MaxRain = 40, Percentage = 70 };
            var l0641 = new EffectiveRain { Name = Utils.NameRegionSouth + "0641", Month = 06, MinRain = 41, MaxRain = 50, Percentage = 70 };
            var l0651 = new EffectiveRain { Name = Utils.NameRegionSouth + "0651", Month = 06, MinRain = 51, MaxRain = 60, Percentage = 65 };
            var l0661 = new EffectiveRain { Name = Utils.NameRegionSouth + "0661", Month = 06, MinRain = 61, MaxRain = 70, Percentage = 60 };
            var l0671 = new EffectiveRain { Name = Utils.NameRegionSouth + "0671", Month = 06, MinRain = 71, MaxRain = 80, Percentage = 55 };
            var l0681 = new EffectiveRain { Name = Utils.NameRegionSouth + "0681", Month = 06, MinRain = 81, MaxRain = 90, Percentage = 50 };
            var l0691 = new EffectiveRain { Name = Utils.NameRegionSouth + "0691", Month = 06, MinRain = 91, MaxRain = 100, Percentage = 50 };
            var l06101 = new EffectiveRain { Name = Utils.NameRegionSouth + "06101", Month = 06, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #region July
            var l0700 = new EffectiveRain { Name = Utils.NameRegionSouth + "0700", Month = 07, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l0711 = new EffectiveRain { Name = Utils.NameRegionSouth + "0711", Month = 07, MinRain = 11, MaxRain = 20, Percentage = 90 };
            var l0721 = new EffectiveRain { Name = Utils.NameRegionSouth + "0721", Month = 07, MinRain = 21, MaxRain = 30, Percentage = 70 };
            var l0731 = new EffectiveRain { Name = Utils.NameRegionSouth + "0731", Month = 07, MinRain = 31, MaxRain = 40, Percentage = 70 };
            var l0741 = new EffectiveRain { Name = Utils.NameRegionSouth + "0741", Month = 07, MinRain = 41, MaxRain = 50, Percentage = 70 };
            var l0751 = new EffectiveRain { Name = Utils.NameRegionSouth + "0751", Month = 07, MinRain = 51, MaxRain = 60, Percentage = 65 };
            var l0761 = new EffectiveRain { Name = Utils.NameRegionSouth + "0761", Month = 07, MinRain = 61, MaxRain = 70, Percentage = 60 };
            var l0771 = new EffectiveRain { Name = Utils.NameRegionSouth + "0771", Month = 07, MinRain = 71, MaxRain = 80, Percentage = 55 };
            var l0781 = new EffectiveRain { Name = Utils.NameRegionSouth + "0781", Month = 07, MinRain = 81, MaxRain = 90, Percentage = 50 };
            var l0791 = new EffectiveRain { Name = Utils.NameRegionSouth + "0791", Month = 07, MinRain = 91, MaxRain = 100, Percentage = 50 };
            var l07101 = new EffectiveRain { Name = Utils.NameRegionSouth + "07101", Month = 07, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #region August
            var l0800 = new EffectiveRain { Name = Utils.NameRegionSouth + "0800", Month = 08, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l0811 = new EffectiveRain { Name = Utils.NameRegionSouth + "0811", Month = 08, MinRain = 11, MaxRain = 20, Percentage = 90 };
            var l0821 = new EffectiveRain { Name = Utils.NameRegionSouth + "0821", Month = 08, MinRain = 21, MaxRain = 30, Percentage = 70 };
            var l0831 = new EffectiveRain { Name = Utils.NameRegionSouth + "0831", Month = 08, MinRain = 31, MaxRain = 40, Percentage = 70 };
            var l0841 = new EffectiveRain { Name = Utils.NameRegionSouth + "0841", Month = 08, MinRain = 41, MaxRain = 50, Percentage = 70 };
            var l0851 = new EffectiveRain { Name = Utils.NameRegionSouth + "0851", Month = 08, MinRain = 51, MaxRain = 60, Percentage = 65 };
            var l0861 = new EffectiveRain { Name = Utils.NameRegionSouth + "0861", Month = 08, MinRain = 61, MaxRain = 70, Percentage = 60 };
            var l0871 = new EffectiveRain { Name = Utils.NameRegionSouth + "0871", Month = 08, MinRain = 71, MaxRain = 80, Percentage = 55 };
            var l0881 = new EffectiveRain { Name = Utils.NameRegionSouth + "0881", Month = 08, MinRain = 81, MaxRain = 90, Percentage = 50 };
            var l0891 = new EffectiveRain { Name = Utils.NameRegionSouth + "0891", Month = 08, MinRain = 91, MaxRain = 100, Percentage = 50 };
            var l08101 = new EffectiveRain { Name = Utils.NameRegionSouth + "08101", Month = 08, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #endregion

            using (var context = new IrrigationAdvisorContext())
            {
                //context.EffectiveRain.Add(lBase);

                #region September
                context.EffectiveRains.Add(l0900);
                context.EffectiveRains.Add(l0911);
                context.EffectiveRains.Add(l0921);
                context.EffectiveRains.Add(l0931);
                context.EffectiveRains.Add(l0941);
                context.EffectiveRains.Add(l0951);
                context.EffectiveRains.Add(l0961);
                context.EffectiveRains.Add(l0971);
                context.EffectiveRains.Add(l0981);
                context.EffectiveRains.Add(l0991);
                context.EffectiveRains.Add(l09101);
                #endregion

                #region October
                context.EffectiveRains.Add(l1000);
                context.EffectiveRains.Add(l1011);
                context.EffectiveRains.Add(l1021);
                context.EffectiveRains.Add(l1031);
                context.EffectiveRains.Add(l1041);
                context.EffectiveRains.Add(l1051);
                context.EffectiveRains.Add(l1061);
                context.EffectiveRains.Add(l1071);
                context.EffectiveRains.Add(l1081);
                context.EffectiveRains.Add(l1091);
                context.EffectiveRains.Add(l10101);
                #endregion

                #region November
                context.EffectiveRains.Add(l1100);
                context.EffectiveRains.Add(l1111);
                context.EffectiveRains.Add(l1121);
                context.EffectiveRains.Add(l1131);
                context.EffectiveRains.Add(l1141);
                context.EffectiveRains.Add(l1151);
                context.EffectiveRains.Add(l1161);
                context.EffectiveRains.Add(l1171);
                context.EffectiveRains.Add(l1181);
                context.EffectiveRains.Add(l1191);
                context.EffectiveRains.Add(l11101);
                #endregion

                #region December
                context.EffectiveRains.Add(l1200);
                context.EffectiveRains.Add(l1211);
                context.EffectiveRains.Add(l1221);
                context.EffectiveRains.Add(l1231);
                context.EffectiveRains.Add(l1241);
                context.EffectiveRains.Add(l1251);
                context.EffectiveRains.Add(l1261);
                context.EffectiveRains.Add(l1271);
                context.EffectiveRains.Add(l1281);
                context.EffectiveRains.Add(l1291);
                context.EffectiveRains.Add(l12101);
                #endregion

                #region January
                context.EffectiveRains.Add(l0100);
                context.EffectiveRains.Add(l0111);
                context.EffectiveRains.Add(l0121);
                context.EffectiveRains.Add(l0131);
                context.EffectiveRains.Add(l0141);
                context.EffectiveRains.Add(l0151);
                context.EffectiveRains.Add(l0161);
                context.EffectiveRains.Add(l0171);
                context.EffectiveRains.Add(l0181);
                context.EffectiveRains.Add(l0191);
                context.EffectiveRains.Add(l01101);
                #endregion

                #region February
                context.EffectiveRains.Add(l0200);
                context.EffectiveRains.Add(l0211);
                context.EffectiveRains.Add(l0221);
                context.EffectiveRains.Add(l0231);
                context.EffectiveRains.Add(l0241);
                context.EffectiveRains.Add(l0251);
                context.EffectiveRains.Add(l0261);
                context.EffectiveRains.Add(l0271);
                context.EffectiveRains.Add(l0281);
                context.EffectiveRains.Add(l0291);
                context.EffectiveRains.Add(l02101);
                #endregion

                #region March
                context.EffectiveRains.Add(l0300);
                context.EffectiveRains.Add(l0311);
                context.EffectiveRains.Add(l0321);
                context.EffectiveRains.Add(l0331);
                context.EffectiveRains.Add(l0341);
                context.EffectiveRains.Add(l0351);
                context.EffectiveRains.Add(l0361);
                context.EffectiveRains.Add(l0371);
                context.EffectiveRains.Add(l0381);
                context.EffectiveRains.Add(l0391);
                context.EffectiveRains.Add(l03101);
                #endregion

                #region April
                context.EffectiveRains.Add(l0400);
                context.EffectiveRains.Add(l0411);
                context.EffectiveRains.Add(l0421);
                context.EffectiveRains.Add(l0431);
                context.EffectiveRains.Add(l0441);
                context.EffectiveRains.Add(l0451);
                context.EffectiveRains.Add(l0461);
                context.EffectiveRains.Add(l0471);
                context.EffectiveRains.Add(l0481);
                context.EffectiveRains.Add(l0491);
                context.EffectiveRains.Add(l04101);
                #endregion

                #region May
                context.EffectiveRains.Add(l0500);
                context.EffectiveRains.Add(l0511);
                context.EffectiveRains.Add(l0521);
                context.EffectiveRains.Add(l0531);
                context.EffectiveRains.Add(l0541);
                context.EffectiveRains.Add(l0551);
                context.EffectiveRains.Add(l0561);
                context.EffectiveRains.Add(l0571);
                context.EffectiveRains.Add(l0581);
                context.EffectiveRains.Add(l0591);
                context.EffectiveRains.Add(l05101);
                #endregion

                #region June
                context.EffectiveRains.Add(l0600);
                context.EffectiveRains.Add(l0611);
                context.EffectiveRains.Add(l0621);
                context.EffectiveRains.Add(l0631);
                context.EffectiveRains.Add(l0641);
                context.EffectiveRains.Add(l0651);
                context.EffectiveRains.Add(l0661);
                context.EffectiveRains.Add(l0671);
                context.EffectiveRains.Add(l0681);
                context.EffectiveRains.Add(l0691);
                context.EffectiveRains.Add(l06101);
                #endregion

                #region July
                context.EffectiveRains.Add(l0700);
                context.EffectiveRains.Add(l0711);
                context.EffectiveRains.Add(l0721);
                context.EffectiveRains.Add(l0731);
                context.EffectiveRains.Add(l0741);
                context.EffectiveRains.Add(l0751);
                context.EffectiveRains.Add(l0761);
                context.EffectiveRains.Add(l0771);
                context.EffectiveRains.Add(l0781);
                context.EffectiveRains.Add(l0791);
                context.EffectiveRains.Add(l07101);
                #endregion

                #region August
                context.EffectiveRains.Add(l0800);
                context.EffectiveRains.Add(l0811);
                context.EffectiveRains.Add(l0821);
                context.EffectiveRains.Add(l0831);
                context.EffectiveRains.Add(l0841);
                context.EffectiveRains.Add(l0851);
                context.EffectiveRains.Add(l0861);
                context.EffectiveRains.Add(l0871);
                context.EffectiveRains.Add(l0881);
                context.EffectiveRains.Add(l0891);
                context.EffectiveRains.Add(l08101);
                #endregion

                context.SaveChanges();
            };
        }

        public static void InsertEffectiveRainsNorth()
        {

            #region Base
            var lBase = new EffectiveRain
            {
                Name = Utils.NameBase,
                Month = 0,
                MinRain = 0,
                MaxRain = 0,
                Percentage = 0,
            };
            #endregion

            #region Region South
            //January, February, March, April, May, June, July, August, September, October, November and December

            #region September
            var l0900 = new EffectiveRain { Name = Utils.NameRegionNorth + "0900", Month = 09, MinRain = 0, MaxRain = 10, Percentage = 95 };
            var l0911 = new EffectiveRain { Name = Utils.NameRegionNorth + "0911", Month = 09, MinRain = 11, MaxRain = 20, Percentage = 90 };
            var l0921 = new EffectiveRain { Name = Utils.NameRegionNorth + "0921", Month = 09, MinRain = 21, MaxRain = 30, Percentage = 80 };
            var l0931 = new EffectiveRain { Name = Utils.NameRegionNorth + "0931", Month = 09, MinRain = 31, MaxRain = 40, Percentage = 75 };
            var l0941 = new EffectiveRain { Name = Utils.NameRegionNorth + "0941", Month = 09, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l0951 = new EffectiveRain { Name = Utils.NameRegionNorth + "0951", Month = 09, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l0961 = new EffectiveRain { Name = Utils.NameRegionNorth + "0961", Month = 09, MinRain = 61, MaxRain = 70, Percentage = 65 };
            var l0971 = new EffectiveRain { Name = Utils.NameRegionNorth + "0971", Month = 09, MinRain = 71, MaxRain = 80, Percentage = 60 };
            var l0981 = new EffectiveRain { Name = Utils.NameRegionNorth + "0981", Month = 09, MinRain = 81, MaxRain = 90, Percentage = 60 };
            var l0991 = new EffectiveRain { Name = Utils.NameRegionNorth + "0991", Month = 09, MinRain = 91, MaxRain = 100, Percentage = 55 };
            var l09101 = new EffectiveRain { Name = Utils.NameRegionNorth + "09101", Month = 09, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #region October
            var l1000 = new EffectiveRain { Name = Utils.NameRegionNorth + "1000", Month = 10, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l1011 = new EffectiveRain { Name = Utils.NameRegionNorth + "1011", Month = 10, MinRain = 11, MaxRain = 20, Percentage = 95 };
            var l1021 = new EffectiveRain { Name = Utils.NameRegionNorth + "1021", Month = 10, MinRain = 21, MaxRain = 30, Percentage = 80 };
            var l1031 = new EffectiveRain { Name = Utils.NameRegionNorth + "1031", Month = 10, MinRain = 31, MaxRain = 40, Percentage = 80 };
            var l1041 = new EffectiveRain { Name = Utils.NameRegionNorth + "1041", Month = 10, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l1051 = new EffectiveRain { Name = Utils.NameRegionNorth + "1051", Month = 10, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l1061 = new EffectiveRain { Name = Utils.NameRegionNorth + "1061", Month = 10, MinRain = 61, MaxRain = 70, Percentage = 70 };
            var l1071 = new EffectiveRain { Name = Utils.NameRegionNorth + "1071", Month = 10, MinRain = 71, MaxRain = 80, Percentage = 65 };
            var l1081 = new EffectiveRain { Name = Utils.NameRegionNorth + "1081", Month = 10, MinRain = 81, MaxRain = 90, Percentage = 65 };
            var l1091 = new EffectiveRain { Name = Utils.NameRegionNorth + "1091", Month = 10, MinRain = 91, MaxRain = 100, Percentage = 65 };
            var l10101 = new EffectiveRain { Name = Utils.NameRegionNorth + "10101", Month = 10, MinRain = 101, MaxRain = 1000, Percentage = 60 };
            #endregion

            #region November
            var l1100 = new EffectiveRain { Name = Utils.NameRegionNorth + "1100", Month = 10, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l1111 = new EffectiveRain { Name = Utils.NameRegionNorth + "1111", Month = 11, MinRain = 11, MaxRain = 20, Percentage = 95 };
            var l1121 = new EffectiveRain { Name = Utils.NameRegionNorth + "1121", Month = 11, MinRain = 21, MaxRain = 30, Percentage = 85 };
            var l1131 = new EffectiveRain { Name = Utils.NameRegionNorth + "1131", Month = 11, MinRain = 31, MaxRain = 40, Percentage = 80 };
            var l1141 = new EffectiveRain { Name = Utils.NameRegionNorth + "1141", Month = 11, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l1151 = new EffectiveRain { Name = Utils.NameRegionNorth + "1151", Month = 11, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l1161 = new EffectiveRain { Name = Utils.NameRegionNorth + "1161", Month = 11, MinRain = 61, MaxRain = 70, Percentage = 70 };
            var l1171 = new EffectiveRain { Name = Utils.NameRegionNorth + "1171", Month = 11, MinRain = 71, MaxRain = 80, Percentage = 65 };
            var l1181 = new EffectiveRain { Name = Utils.NameRegionNorth + "1181", Month = 11, MinRain = 81, MaxRain = 90, Percentage = 65 };
            var l1191 = new EffectiveRain { Name = Utils.NameRegionNorth + "1191", Month = 11, MinRain = 91, MaxRain = 100, Percentage = 65 };
            var l11101 = new EffectiveRain { Name = Utils.NameRegionNorth + "11101", Month = 11, MinRain = 101, MaxRain = 1000, Percentage = 60 };
            #endregion

            #region December
            var l1200 = new EffectiveRain { Name = Utils.NameRegionNorth + "1200", Month = 12, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l1211 = new EffectiveRain { Name = Utils.NameRegionNorth + "1211", Month = 12, MinRain = 11, MaxRain = 20, Percentage = 95 };
            var l1221 = new EffectiveRain { Name = Utils.NameRegionNorth + "1221", Month = 12, MinRain = 21, MaxRain = 30, Percentage = 85 };
            var l1231 = new EffectiveRain { Name = Utils.NameRegionNorth + "1231", Month = 12, MinRain = 31, MaxRain = 40, Percentage = 80 };
            var l1241 = new EffectiveRain { Name = Utils.NameRegionNorth + "1241", Month = 12, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l1251 = new EffectiveRain { Name = Utils.NameRegionNorth + "1251", Month = 12, MinRain = 51, MaxRain = 60, Percentage = 75 };
            var l1261 = new EffectiveRain { Name = Utils.NameRegionNorth + "1261", Month = 12, MinRain = 61, MaxRain = 70, Percentage = 75 };
            var l1271 = new EffectiveRain { Name = Utils.NameRegionNorth + "1271", Month = 12, MinRain = 71, MaxRain = 80, Percentage = 75 };
            var l1281 = new EffectiveRain { Name = Utils.NameRegionNorth + "1281", Month = 12, MinRain = 81, MaxRain = 90, Percentage = 70 };
            var l1291 = new EffectiveRain { Name = Utils.NameRegionNorth + "1291", Month = 12, MinRain = 91, MaxRain = 100, Percentage = 70 };
            var l12101 = new EffectiveRain { Name = Utils.NameRegionNorth + "12101", Month = 12, MinRain = 101, MaxRain = 1000, Percentage = 65 };
            #endregion

            #region January
            var l0100 = new EffectiveRain { Name = Utils.NameRegionNorth + "0100", Month = 01, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l0111 = new EffectiveRain { Name = Utils.NameRegionNorth + "0111", Month = 01, MinRain = 11, MaxRain = 20, Percentage = 95 };
            var l0121 = new EffectiveRain { Name = Utils.NameRegionNorth + "0121", Month = 01, MinRain = 21, MaxRain = 30, Percentage = 85 };
            var l0131 = new EffectiveRain { Name = Utils.NameRegionNorth + "0131", Month = 01, MinRain = 31, MaxRain = 40, Percentage = 80 };
            var l0141 = new EffectiveRain { Name = Utils.NameRegionNorth + "0141", Month = 01, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l0151 = new EffectiveRain { Name = Utils.NameRegionNorth + "0151", Month = 01, MinRain = 51, MaxRain = 60, Percentage = 75 };
            var l0161 = new EffectiveRain { Name = Utils.NameRegionNorth + "0161", Month = 01, MinRain = 61, MaxRain = 70, Percentage = 75 };
            var l0171 = new EffectiveRain { Name = Utils.NameRegionNorth + "0171", Month = 01, MinRain = 71, MaxRain = 80, Percentage = 75 };
            var l0181 = new EffectiveRain { Name = Utils.NameRegionNorth + "0181", Month = 01, MinRain = 81, MaxRain = 90, Percentage = 70 };
            var l0191 = new EffectiveRain { Name = Utils.NameRegionNorth + "0191", Month = 01, MinRain = 91, MaxRain = 100, Percentage = 70 };
            var l01101 = new EffectiveRain { Name = Utils.NameRegionNorth + "01101", Month = 01, MinRain = 101, MaxRain = 1000, Percentage = 65 };
            #endregion

            #region February
            var l0200 = new EffectiveRain { Name = Utils.NameRegionNorth + "0200", Month = 02, MinRain = 00, MaxRain = 10, Percentage = 100 };
            var l0211 = new EffectiveRain { Name = Utils.NameRegionNorth + "0211", Month = 02, MinRain = 11, MaxRain = 20, Percentage = 95 };
            var l0221 = new EffectiveRain { Name = Utils.NameRegionNorth + "0221", Month = 02, MinRain = 21, MaxRain = 30, Percentage = 85 };
            var l0231 = new EffectiveRain { Name = Utils.NameRegionNorth + "0231", Month = 02, MinRain = 31, MaxRain = 40, Percentage = 80 };
            var l0241 = new EffectiveRain { Name = Utils.NameRegionNorth + "0241", Month = 02, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l0251 = new EffectiveRain { Name = Utils.NameRegionNorth + "0251", Month = 02, MinRain = 51, MaxRain = 60, Percentage = 75 };
            var l0261 = new EffectiveRain { Name = Utils.NameRegionNorth + "0261", Month = 02, MinRain = 61, MaxRain = 70, Percentage = 70 };
            var l0271 = new EffectiveRain { Name = Utils.NameRegionNorth + "0271", Month = 02, MinRain = 71, MaxRain = 80, Percentage = 65 };
            var l0281 = new EffectiveRain { Name = Utils.NameRegionNorth + "0281", Month = 02, MinRain = 81, MaxRain = 90, Percentage = 65 };
            var l0291 = new EffectiveRain { Name = Utils.NameRegionNorth + "0291", Month = 02, MinRain = 91, MaxRain = 100, Percentage = 65 };
            var l02101 = new EffectiveRain { Name = Utils.NameRegionNorth + "02101", Month = 02, MinRain = 101, MaxRain = 1000, Percentage = 60 };
            #endregion

            #region March
            var l0300 = new EffectiveRain { Name = Utils.NameRegionNorth + "0300", Month = 03, MinRain = 00, MaxRain = 10, Percentage = 100 };
            var l0311 = new EffectiveRain { Name = Utils.NameRegionNorth + "0311", Month = 03, MinRain = 11, MaxRain = 20, Percentage = 95 };
            var l0321 = new EffectiveRain { Name = Utils.NameRegionNorth + "0321", Month = 03, MinRain = 21, MaxRain = 30, Percentage = 80 };
            var l0331 = new EffectiveRain { Name = Utils.NameRegionNorth + "0331", Month = 03, MinRain = 31, MaxRain = 40, Percentage = 75 };
            var l0341 = new EffectiveRain { Name = Utils.NameRegionNorth + "0341", Month = 03, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l0351 = new EffectiveRain { Name = Utils.NameRegionNorth + "0351", Month = 03, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l0361 = new EffectiveRain { Name = Utils.NameRegionNorth + "0361", Month = 03, MinRain = 61, MaxRain = 70, Percentage = 65 };
            var l0371 = new EffectiveRain { Name = Utils.NameRegionNorth + "0371", Month = 03, MinRain = 71, MaxRain = 80, Percentage = 60 };
            var l0381 = new EffectiveRain { Name = Utils.NameRegionNorth + "0381", Month = 03, MinRain = 81, MaxRain = 90, Percentage = 60 };
            var l0391 = new EffectiveRain { Name = Utils.NameRegionNorth + "0391", Month = 03, MinRain = 91, MaxRain = 100, Percentage = 55 };
            var l03101 = new EffectiveRain { Name = Utils.NameRegionNorth + "03101", Month = 03, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #region April
            var l0400 = new EffectiveRain { Name = Utils.NameRegionNorth + "0400", Month = 04, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l0411 = new EffectiveRain { Name = Utils.NameRegionNorth + "0411", Month = 04, MinRain = 11, MaxRain = 20, Percentage = 95 };
            var l0421 = new EffectiveRain { Name = Utils.NameRegionNorth + "0421", Month = 04, MinRain = 21, MaxRain = 30, Percentage = 75 };
            var l0431 = new EffectiveRain { Name = Utils.NameRegionNorth + "0431", Month = 04, MinRain = 31, MaxRain = 40, Percentage = 75 };
            var l0441 = new EffectiveRain { Name = Utils.NameRegionNorth + "0441", Month = 04, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l0451 = new EffectiveRain { Name = Utils.NameRegionNorth + "0451", Month = 04, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l0461 = new EffectiveRain { Name = Utils.NameRegionNorth + "0461", Month = 04, MinRain = 61, MaxRain = 70, Percentage = 65 };
            var l0471 = new EffectiveRain { Name = Utils.NameRegionNorth + "0471", Month = 04, MinRain = 71, MaxRain = 80, Percentage = 60 };
            var l0481 = new EffectiveRain { Name = Utils.NameRegionNorth + "0481", Month = 04, MinRain = 81, MaxRain = 90, Percentage = 60 };
            var l0491 = new EffectiveRain { Name = Utils.NameRegionNorth + "0491", Month = 04, MinRain = 91, MaxRain = 100, Percentage = 55 };
            var l04101 = new EffectiveRain { Name = Utils.NameRegionNorth + "04101", Month = 04, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #region May
            var l0500 = new EffectiveRain { Name = Utils.NameRegionSouth + "0500", Month = 05, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l0511 = new EffectiveRain { Name = Utils.NameRegionSouth + "0511", Month = 05, MinRain = 11, MaxRain = 20, Percentage = 90 };
            var l0521 = new EffectiveRain { Name = Utils.NameRegionSouth + "0521", Month = 05, MinRain = 21, MaxRain = 30, Percentage = 70 };
            var l0531 = new EffectiveRain { Name = Utils.NameRegionSouth + "0531", Month = 05, MinRain = 31, MaxRain = 40, Percentage = 70 };
            var l0541 = new EffectiveRain { Name = Utils.NameRegionSouth + "0541", Month = 05, MinRain = 41, MaxRain = 50, Percentage = 70 };
            var l0551 = new EffectiveRain { Name = Utils.NameRegionSouth + "0551", Month = 05, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l0561 = new EffectiveRain { Name = Utils.NameRegionSouth + "0561", Month = 05, MinRain = 61, MaxRain = 70, Percentage = 65 };
            var l0571 = new EffectiveRain { Name = Utils.NameRegionSouth + "0571", Month = 05, MinRain = 71, MaxRain = 80, Percentage = 60 };
            var l0581 = new EffectiveRain { Name = Utils.NameRegionSouth + "0581", Month = 05, MinRain = 81, MaxRain = 90, Percentage = 55 };
            var l0591 = new EffectiveRain { Name = Utils.NameRegionSouth + "0591", Month = 05, MinRain = 91, MaxRain = 100, Percentage = 55 };
            var l05101 = new EffectiveRain { Name = Utils.NameRegionSouth + "05101", Month = 05, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #region June
            var l0600 = new EffectiveRain { Name = Utils.NameRegionSouth + "0600", Month = 06, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l0611 = new EffectiveRain { Name = Utils.NameRegionSouth + "0611", Month = 06, MinRain = 11, MaxRain = 20, Percentage = 90 };
            var l0621 = new EffectiveRain { Name = Utils.NameRegionSouth + "0621", Month = 06, MinRain = 21, MaxRain = 30, Percentage = 70 };
            var l0631 = new EffectiveRain { Name = Utils.NameRegionSouth + "0631", Month = 06, MinRain = 31, MaxRain = 40, Percentage = 70 };
            var l0641 = new EffectiveRain { Name = Utils.NameRegionSouth + "0641", Month = 06, MinRain = 41, MaxRain = 50, Percentage = 70 };
            var l0651 = new EffectiveRain { Name = Utils.NameRegionSouth + "0651", Month = 06, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l0661 = new EffectiveRain { Name = Utils.NameRegionSouth + "0661", Month = 06, MinRain = 61, MaxRain = 70, Percentage = 65 };
            var l0671 = new EffectiveRain { Name = Utils.NameRegionSouth + "0671", Month = 06, MinRain = 71, MaxRain = 80, Percentage = 60 };
            var l0681 = new EffectiveRain { Name = Utils.NameRegionSouth + "0681", Month = 06, MinRain = 81, MaxRain = 90, Percentage = 55 };
            var l0691 = new EffectiveRain { Name = Utils.NameRegionSouth + "0691", Month = 06, MinRain = 91, MaxRain = 100, Percentage = 55 };
            var l06101 = new EffectiveRain { Name = Utils.NameRegionSouth + "06101", Month = 06, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #region July
            var l0700 = new EffectiveRain { Name = Utils.NameRegionSouth + "0700", Month = 07, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l0711 = new EffectiveRain { Name = Utils.NameRegionSouth + "0711", Month = 07, MinRain = 11, MaxRain = 20, Percentage = 90 };
            var l0721 = new EffectiveRain { Name = Utils.NameRegionSouth + "0721", Month = 07, MinRain = 21, MaxRain = 30, Percentage = 70 };
            var l0731 = new EffectiveRain { Name = Utils.NameRegionSouth + "0731", Month = 07, MinRain = 31, MaxRain = 40, Percentage = 70 };
            var l0741 = new EffectiveRain { Name = Utils.NameRegionSouth + "0741", Month = 07, MinRain = 41, MaxRain = 50, Percentage = 70 };
            var l0751 = new EffectiveRain { Name = Utils.NameRegionSouth + "0751", Month = 07, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l0761 = new EffectiveRain { Name = Utils.NameRegionSouth + "0761", Month = 07, MinRain = 61, MaxRain = 70, Percentage = 65 };
            var l0771 = new EffectiveRain { Name = Utils.NameRegionSouth + "0771", Month = 07, MinRain = 71, MaxRain = 80, Percentage = 60 };
            var l0781 = new EffectiveRain { Name = Utils.NameRegionSouth + "0781", Month = 07, MinRain = 81, MaxRain = 90, Percentage = 55 };
            var l0791 = new EffectiveRain { Name = Utils.NameRegionSouth + "0791", Month = 07, MinRain = 91, MaxRain = 100, Percentage = 55 };
            var l07101 = new EffectiveRain { Name = Utils.NameRegionSouth + "07101", Month = 07, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #region August
            var l0800 = new EffectiveRain { Name = Utils.NameRegionSouth + "0800", Month = 08, MinRain = 0, MaxRain = 10, Percentage = 100 };
            var l0811 = new EffectiveRain { Name = Utils.NameRegionSouth + "0811", Month = 08, MinRain = 11, MaxRain = 20, Percentage = 90 };
            var l0821 = new EffectiveRain { Name = Utils.NameRegionSouth + "0821", Month = 08, MinRain = 21, MaxRain = 30, Percentage = 70 };
            var l0831 = new EffectiveRain { Name = Utils.NameRegionSouth + "0831", Month = 08, MinRain = 31, MaxRain = 40, Percentage = 70 };
            var l0841 = new EffectiveRain { Name = Utils.NameRegionSouth + "0841", Month = 08, MinRain = 41, MaxRain = 50, Percentage = 70 };
            var l0851 = new EffectiveRain { Name = Utils.NameRegionSouth + "0851", Month = 08, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l0861 = new EffectiveRain { Name = Utils.NameRegionSouth + "0861", Month = 08, MinRain = 61, MaxRain = 70, Percentage = 65 };
            var l0871 = new EffectiveRain { Name = Utils.NameRegionSouth + "0871", Month = 08, MinRain = 71, MaxRain = 80, Percentage = 60 };
            var l0881 = new EffectiveRain { Name = Utils.NameRegionSouth + "0881", Month = 08, MinRain = 81, MaxRain = 90, Percentage = 55 };
            var l0891 = new EffectiveRain { Name = Utils.NameRegionSouth + "0891", Month = 08, MinRain = 91, MaxRain = 100, Percentage = 55 };
            var l08101 = new EffectiveRain { Name = Utils.NameRegionSouth + "08101", Month = 08, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #endregion

            using (var context = new IrrigationAdvisorContext())
            {
                //context.EffectiveRain.Add(lBase);

                #region September
                context.EffectiveRains.Add(l0900);
                context.EffectiveRains.Add(l0911);
                context.EffectiveRains.Add(l0921);
                context.EffectiveRains.Add(l0931);
                context.EffectiveRains.Add(l0941);
                context.EffectiveRains.Add(l0951);
                context.EffectiveRains.Add(l0961);
                context.EffectiveRains.Add(l0971);
                context.EffectiveRains.Add(l0981);
                context.EffectiveRains.Add(l0991);
                context.EffectiveRains.Add(l09101);
                #endregion

                #region October
                context.EffectiveRains.Add(l1000);
                context.EffectiveRains.Add(l1011);
                context.EffectiveRains.Add(l1021);
                context.EffectiveRains.Add(l1031);
                context.EffectiveRains.Add(l1041);
                context.EffectiveRains.Add(l1051);
                context.EffectiveRains.Add(l1061);
                context.EffectiveRains.Add(l1071);
                context.EffectiveRains.Add(l1081);
                context.EffectiveRains.Add(l1091);
                context.EffectiveRains.Add(l10101);
                #endregion

                #region November
                context.EffectiveRains.Add(l1100);
                context.EffectiveRains.Add(l1111);
                context.EffectiveRains.Add(l1121);
                context.EffectiveRains.Add(l1131);
                context.EffectiveRains.Add(l1141);
                context.EffectiveRains.Add(l1151);
                context.EffectiveRains.Add(l1161);
                context.EffectiveRains.Add(l1171);
                context.EffectiveRains.Add(l1181);
                context.EffectiveRains.Add(l1191);
                context.EffectiveRains.Add(l11101);
                #endregion

                #region December
                context.EffectiveRains.Add(l1200);
                context.EffectiveRains.Add(l1211);
                context.EffectiveRains.Add(l1221);
                context.EffectiveRains.Add(l1231);
                context.EffectiveRains.Add(l1241);
                context.EffectiveRains.Add(l1251);
                context.EffectiveRains.Add(l1261);
                context.EffectiveRains.Add(l1271);
                context.EffectiveRains.Add(l1281);
                context.EffectiveRains.Add(l1291);
                context.EffectiveRains.Add(l12101);
                #endregion

                #region January
                context.EffectiveRains.Add(l0100);
                context.EffectiveRains.Add(l0111);
                context.EffectiveRains.Add(l0121);
                context.EffectiveRains.Add(l0131);
                context.EffectiveRains.Add(l0141);
                context.EffectiveRains.Add(l0151);
                context.EffectiveRains.Add(l0161);
                context.EffectiveRains.Add(l0171);
                context.EffectiveRains.Add(l0181);
                context.EffectiveRains.Add(l0191);
                context.EffectiveRains.Add(l01101);
                #endregion

                #region February
                context.EffectiveRains.Add(l0200);
                context.EffectiveRains.Add(l0211);
                context.EffectiveRains.Add(l0221);
                context.EffectiveRains.Add(l0231);
                context.EffectiveRains.Add(l0241);
                context.EffectiveRains.Add(l0251);
                context.EffectiveRains.Add(l0261);
                context.EffectiveRains.Add(l0271);
                context.EffectiveRains.Add(l0281);
                context.EffectiveRains.Add(l0291);
                context.EffectiveRains.Add(l02101);
                #endregion

                #region March
                context.EffectiveRains.Add(l0300);
                context.EffectiveRains.Add(l0311);
                context.EffectiveRains.Add(l0321);
                context.EffectiveRains.Add(l0331);
                context.EffectiveRains.Add(l0341);
                context.EffectiveRains.Add(l0351);
                context.EffectiveRains.Add(l0361);
                context.EffectiveRains.Add(l0371);
                context.EffectiveRains.Add(l0381);
                context.EffectiveRains.Add(l0391);
                context.EffectiveRains.Add(l03101);
                #endregion

                #region April
                context.EffectiveRains.Add(l0400);
                context.EffectiveRains.Add(l0411);
                context.EffectiveRains.Add(l0421);
                context.EffectiveRains.Add(l0431);
                context.EffectiveRains.Add(l0441);
                context.EffectiveRains.Add(l0451);
                context.EffectiveRains.Add(l0461);
                context.EffectiveRains.Add(l0471);
                context.EffectiveRains.Add(l0481);
                context.EffectiveRains.Add(l0491);
                context.EffectiveRains.Add(l04101);
                #endregion

                #region May
                context.EffectiveRains.Add(l0500);
                context.EffectiveRains.Add(l0511);
                context.EffectiveRains.Add(l0521);
                context.EffectiveRains.Add(l0531);
                context.EffectiveRains.Add(l0541);
                context.EffectiveRains.Add(l0551);
                context.EffectiveRains.Add(l0561);
                context.EffectiveRains.Add(l0571);
                context.EffectiveRains.Add(l0581);
                context.EffectiveRains.Add(l0591);
                context.EffectiveRains.Add(l05101);
                #endregion

                #region June
                context.EffectiveRains.Add(l0600);
                context.EffectiveRains.Add(l0611);
                context.EffectiveRains.Add(l0621);
                context.EffectiveRains.Add(l0631);
                context.EffectiveRains.Add(l0641);
                context.EffectiveRains.Add(l0651);
                context.EffectiveRains.Add(l0661);
                context.EffectiveRains.Add(l0671);
                context.EffectiveRains.Add(l0681);
                context.EffectiveRains.Add(l0691);
                context.EffectiveRains.Add(l06101);
                #endregion

                #region July
                context.EffectiveRains.Add(l0700);
                context.EffectiveRains.Add(l0711);
                context.EffectiveRains.Add(l0721);
                context.EffectiveRains.Add(l0731);
                context.EffectiveRains.Add(l0741);
                context.EffectiveRains.Add(l0751);
                context.EffectiveRains.Add(l0761);
                context.EffectiveRains.Add(l0771);
                context.EffectiveRains.Add(l0781);
                context.EffectiveRains.Add(l0791);
                context.EffectiveRains.Add(l07101);
                #endregion

                #region August
                context.EffectiveRains.Add(l0800);
                context.EffectiveRains.Add(l0811);
                context.EffectiveRains.Add(l0821);
                context.EffectiveRains.Add(l0831);
                context.EffectiveRains.Add(l0841);
                context.EffectiveRains.Add(l0851);
                context.EffectiveRains.Add(l0861);
                context.EffectiveRains.Add(l0871);
                context.EffectiveRains.Add(l0881);
                context.EffectiveRains.Add(l0891);
                context.EffectiveRains.Add(l08101);
                #endregion

                context.SaveChanges();
            };
        }

        public static void UpdateRegionSetEffectiveRainList()
        {
            List<EffectiveRain> lEffectiveRainList = null;
            Region lRegion = null;
            using (var context = new IrrigationAdvisorContext())
            {
                lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                      where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                      select effectiverain)
                                     .ToList<EffectiveRain>();

                lRegion = (from region in context.Regions
                           where region.Name == Utils.NameRegionSouth
                           select region).FirstOrDefault();

                lRegion = context.Regions.SingleOrDefault(
                                    region => region.Name == Utils.NameRegionSouth);
                lRegion.EffectiveRainList = lEffectiveRainList;

                context.SaveChanges();

                lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                      where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                      select effectiverain)
                                     .ToList<EffectiveRain>();

                lRegion = (from region in context.Regions
                           where region.Name == Utils.NameRegionNorth
                           select region).FirstOrDefault();

                lRegion = context.Regions.SingleOrDefault(
                                    region => region.Name == Utils.NameRegionNorth);
                lRegion.EffectiveRainList = lEffectiveRainList;

                context.SaveChanges();
            }

        }

        #region Season_2015_2016
        
        /// <summary>
        /// Add Rain Data to Pivots in Farms
        /// </summary>
        public static void UpdateInformationOfRain2015()
        {

            #region South

            using (var context = new IrrigationAdvisorContext())
            {

                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {
                    DataEntry2015.AddRainDataDemoPivot1_2015(context);
                    DataEntry2015.AddRainDataDemoPivot2_2015(context);
                    DataEntry2015.AddRainDataDemoPivot3_2015(context);
                    DataEntry2015.AddRainDataDemoPivot5_2015(context);
                    context.SaveChanges();
                }

                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
                {
                    DataEntry2015.AddRainDataDCALaPerdizPivot2_2015(context);
                    DataEntry2015.AddRainDataDCALaPerdizPivot3_2015(context);
                    DataEntry2015.AddRainDataDCALaPerdizPivot5_2015(context);
                    context.SaveChanges();
                }

                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
                {
                    DataEntry2015.AddRainDataDelLagoSanPedroPivot5_2015(context);
                    DataEntry2015.AddRainDataDelLagoSanPedroPivot6_2015(context);
                    DataEntry2015.AddRainDataDelLagoSanPedroPivot7_2015(context);
                    DataEntry2015.AddRainDataDelLagoSanPedroPivot8_2015(context);
                    context.SaveChanges();
                }

                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
                {
                    DataEntry2015.AddRainDataDelLagoElMiradorPivot6_2015(context);
                    DataEntry2015.AddRainDataDelLagoElMiradorPivot7_2015(context);
                    DataEntry2015.AddRainDataDelLagoElMiradorPivot8_2015(context);
                    DataEntry2015.AddRainDataDelLagoElMiradorPivot9_2015(context);
                    context.SaveChanges();
                }

                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
                {
                    DataEntry2015.AddRainDataLaPalmaPivot2A_2015(context);
                    DataEntry2015.AddRainDataLaPalmaPivot3_2015(context);
                    DataEntry2015.AddRainDataLaPalmaPivot4_2015(context);
                    context.SaveChanges();
                }

            }

            #endregion

            #region North
            using (var context = new IrrigationAdvisorContext())
            {
                context.SaveChanges();
            }
            #endregion


        }

        /// <summary>
        /// Add Irrigation Data to Pivots in Farms
        /// </summary>
        public static void UpdateInformationOfIrrigation2015()
        {

            #region South

            #region Demo - La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //TODO: se quitaron los riegos extras.
                    //DataEntry.AddIrrigationDataDemoPivot1_2015(context);
                    //DataEntry.AddIrrigationDataDemoPivot2_2015(context);
                    //DataEntry.AddIrrigationDataDemoPivot3_2015(context);
                    //DataEntry.AddIrrigationDataDemoPivot5_2015(context);
                    context.SaveChanges();

                }
            }
            #endregion

            #region DCA La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All)
                {
                    using (var context = new IrrigationAdvisorContext())
                    {
                        DataEntry2015.AddIrrigationDataDCALaPerdizPivot2_2015(context);
                        DataEntry2015.AddIrrigationDataDCALaPerdizPivot3_2015(context);
                        DataEntry2015.AddIrrigationDataDCALaPerdizPivot5_2015(context);
                        context.SaveChanges();

                    }
                }
            }
            #endregion

            #region Del Lago - San Pedro
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    context.SaveChanges();

                }
            }
            #endregion

            #region Del Lago - El Mirador
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    context.SaveChanges();

                }
            }
            #endregion

            #region GMO La Palma
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    context.SaveChanges();

                }
            }
            #endregion

            #endregion

            #region North
            using (var context = new IrrigationAdvisorContext())
            {
                context.SaveChanges();
            }
            #endregion

        }

        #endregion

        #region Season_2016_2017

        /// <summary>
        /// Add Rain Data to Pivots in Farms
        /// </summary>
        public static void UpdateInformationOfRain2016()
        {

            #region South

            using (var context = new IrrigationAdvisorContext())
            {
                #region DCA El Paraiso
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
                {
                    RainData.AddRainDataDCAElParaisoPivot1_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDCAElParaisoPivot2_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region DCA La Perdiz
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
                {
                    RainData.AddRainDataDCALaPerdizPivot1_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDCALaPerdizPivot2_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDCALaPerdizPivot3_2016(context, Program.DateOfReference);
                    //RainData.AddRainDataDCALaPerdizPivot4_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDCALaPerdizPivot5_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDCALaPerdizPivot6_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDCALaPerdizPivot7_2016(context, Program.DateOfReference);
                    //RainData.AddRainDataDCALaPerdizPivot10a_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDCALaPerdizPivot10b_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDCALaPerdizPivot14_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDCALaPerdizPivot15_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region DCA San Jose
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
                {
                    RainData.AddRainDataDCASanJosePivot1_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDCASanJosePivot2_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDCASanJosePivot3_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDCASanJosePivot4_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Del Lago - San Pedro
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
                {

                    //context.SaveChanges();
                }
                #endregion
                #region Del Lago - El Mirador
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
                {
                    RainData.AddRainDataDelLagoElMiradorPivot1_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot2_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot3_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot4_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot5_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot6_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot7_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot8_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot9_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot10_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot11_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot12_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot13_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot14_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot15_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivotChaja1_2016(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivotChaja2_2016(context, Program.DateOfReference);

                    RainData.AddRainDataDelLagoElMiradorPivot1_2016b(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot2_2016b(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot3_2016b(context, Program.DateOfReference);
                    RainData.AddRainDataDelLagoElMiradorPivot4_2016b(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Tres Marias
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
                {

                    RainData.AddRainDataTresMariasPivot1_2016(context, Program.DateOfReference);
                    //RainData.AddRainDataTresMariasPivot2_2016(context, Program.DateOfReference);
                    //RainData.AddRainDataTresMariasPivot3_2016(context, Program.DateOfReference);
                    //RainData.AddRainDataTresMariasPivot4_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region GMO - La Palma
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
                {
                    RainData.AddRainDataGMOLaPalmaPivot2_2016(context, Program.DateOfReference);
                    RainData.AddRainDataGMOLaPalmaPivot3_2016(context, Program.DateOfReference);
                    RainData.AddRainDataGMOLaPalmaPivot4_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

            }

            #endregion

            #region North
            using (var context = new IrrigationAdvisorContext())
            {
                #region GMO - El Tacuru
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
                {
                    //RainData.AddRainDataGMOElTacuruPivot1a_2016(context, Program.DateOfReference);
                    RainData.AddRainDataGMOElTacuruPivot1b_2016(context, Program.DateOfReference);
                    RainData.AddRainDataGMOElTacuruPivot2a_2016(context, Program.DateOfReference);
                    RainData.AddRainDataGMOElTacuruPivot2b_2016(context, Program.DateOfReference);
                    RainData.AddRainDataGMOElTacuruPivot3a_2016(context, Program.DateOfReference);
                    RainData.AddRainDataGMOElTacuruPivot3b_2016(context, Program.DateOfReference);
                    RainData.AddRainDataGMOElTacuruPivot4_2016(context, Program.DateOfReference);
                    RainData.AddRainDataGMOElTacuruPivot5_2016(context, Program.DateOfReference);
                    //RainData.AddRainDataGMOElTacuruPivot6_2016(context, Program.DateOfReference);
                    //RainData.AddRainDataGMOElTacuruPivot7_2016(context, Program.DateOfReference);
                    RainData.AddRainDataGMOElTacuruPivot8_2016(context, Program.DateOfReference);
                    RainData.AddRainDataGMOElTacuruPivot9_2016(context, Program.DateOfReference);
                    RainData.AddRainDataGMOElTacuruPivot10_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region La Rinconada
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
                {

                    //RainData.AddRainDataLaRinconadaPivot1_2016(context, Program.DateOfReference);
                    RainData.AddRainDataLaRinconadaPivot2_2016(context, Program.DateOfReference);
                    RainData.AddRainDataLaRinconadaPivot3_1_2016(context, Program.DateOfReference);
                    RainData.AddRainDataLaRinconadaPivot13_1_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
            }
            #endregion

        }

        /// <summary>
        /// Add Irrigation Data to Pivots in Farms
        /// </summary>
        public static void UpdateInformationOfIrrigation2016()
        {

            #region South

            #region DCA El Paraiso
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData.AddIrrigationDataDCAElParaisoPivot1_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDCAElParaisoPivot2_2016(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region DCA San Jose
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData.AddIrrigationDataDCASanJosePivot1_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDCASanJosePivot2_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDCASanJosePivot3_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDCASanJosePivot4_2016(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region DCA La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData.AddIrrigationDataDCALaPerdizPivot1_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDCALaPerdizPivot2_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDCALaPerdizPivot3_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDCALaPerdizPivot5_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDCALaPerdizPivot6_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDCALaPerdizPivot7_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDCALaPerdizPivot10b_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDCALaPerdizPivot14_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDCALaPerdizPivot15_2016(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Del Lago - San Pedro
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    context.SaveChanges();

                }
            }
            #endregion 

            #region Del Lago - El Mirador
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                ;
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot1_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot2_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot3_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot4_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot5_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot6_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot7_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot8_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot9_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot10_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot11_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot12_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot13_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot14_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot15_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivotChaja1_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivotChaja2_2016(context, Program.DateOfReference);

                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot1_2016b(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot2_2016b(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot3_2016b(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDelLagoElMiradorPivot4_2016b(context, Program.DateOfReference);

                    context.SaveChanges();

                }
            }
            #endregion

            #region Tres Marias
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData.AddIrrigationDataTresMariasPivot1_2016(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataTresMariasPivot2_2016(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataTresMariasPivot3_2016(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataTresMariasPivot4_2016(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region GMO - La Palma
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData.AddIrrigationDataGMOLaPalmaPivot1_2016(context, DateTime pProgram.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOLaPalmaPivot2_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOLaPalmaPivot3_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOLaPalmaPivot4_2016(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataGMOLaPalmaPivot5_2016(context);
                    context.SaveChanges();

                }
            }
            #endregion

            #endregion

            #region North

            #region GMO - El Tacuru
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData.AddIrrigationDataGMOElTacuruPivot1a_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOElTacuruPivot1b_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOElTacuruPivot2a_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOElTacuruPivot2b_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOElTacuruPivot3a_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOElTacuruPivot3b_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOElTacuruPivot4_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOElTacuruPivot5_2016(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataGMOElTacuruPivot6_2016(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataGMOElTacuruPivot7_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOElTacuruPivot8_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOElTacuruPivot9_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOElTacuruPivot10_2016(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region La Rinconada
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData.AddIrrigationDataLaRinconadaPivot1_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataLaRinconadaPivot2_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataLaRinconadaPivot3_1_2016(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataLaRinconadaPivot13_1_2016(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #endregion

        }

        #endregion

        #region Season_2017_2018

        /// <summary>
        /// Add Rain Data to Pivots in Farms
        /// </summary>
        public static void UpdateInformationOfRain2017()
        {

            #region South

            using (var context = new IrrigationAdvisorContext())
            {
                #region DCA El Paraiso
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
                {
                    //RainData.AddRainDataDCAElParaisoPivot1_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDCAElParaisoPivot2_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region DCA La Perdiz
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
                {
                    //RainData.AddRainDataDCALaPerdizPivot1_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDCALaPerdizPivot2_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDCALaPerdizPivot3_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDCALaPerdizPivot4_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDCALaPerdizPivot5_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDCALaPerdizPivot6_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDCALaPerdizPivot7_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDCALaPerdizPivot10a_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDCALaPerdizPivot10b_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDCALaPerdizPivot14_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDCALaPerdizPivot15_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region DCA San Jose
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
                {
                    //RainData.AddRainDataDCASanJosePivot1_2017(context, Program.DateOfReference);
                    RainData.AddRainDataDCASanJosePivot2_2017(context, Program.DateOfReference);
                    RainData.AddRainDataDCASanJosePivot3_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDCASanJosePivot4_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Del Lago - San Pedro
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
                {

                    //context.SaveChanges();
                }
                #endregion
                #region Del Lago - El Mirador
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
                {
                    //RainData.AddRainDataDelLagoElMiradorPivot1_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot2_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot3_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot4_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot5_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot6_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot7_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot8_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot9_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot10_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot11_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot12_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot13_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot14_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot15_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivotChaja1_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivotChaja2_2017(context, Program.DateOfReference);

                    //RainData.AddRainDataDelLagoElMiradorPivot1_2017b(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot2_2017b(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot3_2017b(context, Program.DateOfReference);
                    //RainData.AddRainDataDelLagoElMiradorPivot4_2017b(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Tres Marias
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
                {

                    //RainData.AddRainDataTresMariasPivot1_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataTresMariasPivot2_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataTresMariasPivot3_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataTresMariasPivot4_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region El Rincon
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElRincon)
                {

                    RainData.AddRainDataElRinconPivot1a_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataElRinconPivot1b_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

            }

            #endregion

            #region North
            using (var context = new IrrigationAdvisorContext())
            {
                #region GMO - El Tacuru
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
                {
                    //RainData.AddRainDataGMOElTacuruPivot1a_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataGMOElTacuruPivot1b_2017(context, Program.DateOfReference);
                    RainData.AddRainDataGMOElTacuruPivot2a_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataGMOElTacuruPivot2b_2017(context, Program.DateOfReference);
                    RainData.AddRainDataGMOElTacuruPivot3a_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataGMOElTacuruPivot3b_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataGMOElTacuruPivot4_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataGMOElTacuruPivot5_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataGMOElTacuruPivot6_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataGMOElTacuruPivot7_2017(context, Program.DateOfReference);
                    RainData.AddRainDataGMOElTacuruPivot8_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataGMOElTacuruPivot9_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataGMOElTacuruPivot10_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region GMO - La Palma
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
                {
                    //RainData.AddRainDataGMOLaPalmaPivot1_2017(context, Program.DateOfReference);
                    RainData.AddRainDataGMOLaPalmaPivot2_2017(context, Program.DateOfReference);
                    RainData.AddRainDataGMOLaPalmaPivot3_2017(context, Program.DateOfReference);
                    RainData.AddRainDataGMOLaPalmaPivot4_2017(context, Program.DateOfReference);
                    RainData.AddRainDataGMOLaPalmaPivot1_1_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataGMOLaPalmaPivot2_1_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataGMOLaPalmaPivot3_1_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataGMOLaPalmaPivot4_1_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region La Rinconada
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
                {

                    //RainData.AddRainDataLaRinconadaPivot1_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataLaRinconadaPivot2_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataLaRinconadaPivot3_1_2017(context, Program.DateOfReference);
                    //RainData.AddRainDataLaRinconadaPivot13_1_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
            }
            #endregion

        }

        /// <summary>
        /// Add Irrigation Data to Pivots in Farms
        /// </summary>
        public static void UpdateInformationOfIrrigation2017()
        {

            #region South

            #region DCA El Paraiso
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData.AddIrrigationDataDCAElParaisoPivot1_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDCAElParaisoPivot2_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion
            #region DCA San Jose
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData.AddIrrigationDataDCASanJosePivot1_2017(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDCASanJosePivot2_2017(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataDCASanJosePivot3_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDCASanJosePivot4_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion
            #region DCA La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData.AddIrrigationDataDCALaPerdizPivot1_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDCALaPerdizPivot2_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDCALaPerdizPivot3_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDCALaPerdizPivot5_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDCALaPerdizPivot6_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDCALaPerdizPivot7_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDCALaPerdizPivot10b_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDCALaPerdizPivot14_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDCALaPerdizPivot15_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Del Lago - San Pedro
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    context.SaveChanges();

                }
            }
            #endregion
            #region Del Lago - El Mirador
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                ;
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot1_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot2_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot3_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot4_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot5_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot6_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot7_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot8_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot9_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot10_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot11_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot12_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot13_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot14_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot15_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivotChaja1_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivotChaja2_2017(context, Program.DateOfReference);

                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot1_2017b(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot2_2017b(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot3_2017b(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataDelLagoElMiradorPivot4_2017b(context, Program.DateOfReference);

                    context.SaveChanges();

                }
            }
            #endregion

            #region Tres Marias
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData.AddIrrigationDataTresMariasPivot1_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataTresMariasPivot2_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataTresMariasPivot3_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataTresMariasPivot4_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region El Rincon
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElRincon)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData.AddIrrigationDataElRinconPivot1a_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataElRinconPivot1b_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #endregion

            #region North

            #region GMO - El Tacuru
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData.AddIrrigationDataGMOElTacuruPivot1a_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataGMOElTacuruPivot1b_2017(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOElTacuruPivot2a_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataGMOElTacuruPivot2b_2017(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOElTacuruPivot3a_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataGMOElTacuruPivot3b_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataGMOElTacuruPivot4_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataGMOElTacuruPivot5_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataGMOElTacuruPivot6_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataGMOElTacuruPivot7_2017(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOElTacuruPivot8_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataGMOElTacuruPivot9_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataGMOElTacuruPivot10_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion
            #region GMO - La Palma
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData.AddIrrigationDataGMOLaPalmaPivot1_2017(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOLaPalmaPivot2_2017(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOLaPalmaPivot3_2017(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOLaPalmaPivot4_2017(context, Program.DateOfReference);
                    IrrigationData.AddIrrigationDataGMOLaPalmaPivot1_1_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataGMOLaPalmaPivot2_1_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataGMOLaPalmaPivot3_1_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataGMOLaPalmaPivot4_1_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region La Rinconada
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData.AddIrrigationDataLaRinconadaPivot1_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataLaRinconadaPivot2_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataLaRinconadaPivot3_1_2017(context, Program.DateOfReference);
                    //IrrigationData.AddIrrigationDataLaRinconadaPivot13_1_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #endregion

        }

        #endregion

#endif
        #endregion

    }
}
