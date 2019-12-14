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
                    RainData2016.AddRainDataDCAElParaisoPivot1_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDCAElParaisoPivot2_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region DCA La Perdiz
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
                {
                    RainData2016.AddRainDataDCALaPerdizPivot1_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDCALaPerdizPivot2_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDCALaPerdizPivot3_2016(context, Program.DateOfReference);
                    //RainData2016.AddRainDataDCALaPerdizPivot4_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDCALaPerdizPivot5_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDCALaPerdizPivot6_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDCALaPerdizPivot7_2016(context, Program.DateOfReference);
                    //RainData2016.AddRainDataDCALaPerdizPivot10a_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDCALaPerdizPivot10b_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDCALaPerdizPivot14_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDCALaPerdizPivot15_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region DCA San Jose
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
                {
                    RainData2016.AddRainDataDCASanJosePivot1_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDCASanJosePivot2_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDCASanJosePivot3_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDCASanJosePivot4_2016(context, Program.DateOfReference);
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
                    RainData2016.AddRainDataDelLagoElMiradorPivot1_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot2_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot3_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot4_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot5_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot6_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot7_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot8_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot9_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot10_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot11_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot12_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot13_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot14_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot15_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivotChaja1_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivotChaja2_2016(context, Program.DateOfReference);

                    RainData2016.AddRainDataDelLagoElMiradorPivot1_2016b(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot2_2016b(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot3_2016b(context, Program.DateOfReference);
                    RainData2016.AddRainDataDelLagoElMiradorPivot4_2016b(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Tres Marias
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
                {

                    RainData2016.AddRainDataTresMariasPivot1_2016(context, Program.DateOfReference);
                    //RainData2016.AddRainDataTresMariasPivot2_2016(context, Program.DateOfReference);
                    //RainData2016.AddRainDataTresMariasPivot3_2016(context, Program.DateOfReference);
                    //RainData2016.AddRainDataTresMariasPivot4_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region GMO - La Palma
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
                {
                    RainData2016.AddRainDataGMOLaPalmaPivot2_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataGMOLaPalmaPivot3_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataGMOLaPalmaPivot4_2016(context, Program.DateOfReference);
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
                    //RainData2016.AddRainDataGMOElTacuruPivot1a_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataGMOElTacuruPivot1b_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataGMOElTacuruPivot2a_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataGMOElTacuruPivot2b_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataGMOElTacuruPivot3a_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataGMOElTacuruPivot3b_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataGMOElTacuruPivot4_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataGMOElTacuruPivot5_2016(context, Program.DateOfReference);
                    //RainData2016.AddRainDataGMOElTacuruPivot6_2016(context, Program.DateOfReference);
                    //RainData2016.AddRainDataGMOElTacuruPivot7_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataGMOElTacuruPivot8_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataGMOElTacuruPivot9_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataGMOElTacuruPivot10_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region La Rinconada
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
                {

                    //RainData2016.AddRainDataLaRinconadaPivot1_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataLaRinconadaPivot2_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataLaRinconadaPivot3_1_2016(context, Program.DateOfReference);
                    RainData2016.AddRainDataLaRinconadaPivot13_1_2016(context, Program.DateOfReference);
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
                    IrrigationData2016.AddIrrigationDataDCAElParaisoPivot1_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDCAElParaisoPivot2_2016(context, Program.DateOfReference);
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
                    IrrigationData2016.AddIrrigationDataDCASanJosePivot1_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDCASanJosePivot2_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDCASanJosePivot3_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDCASanJosePivot4_2016(context, Program.DateOfReference);
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
                    IrrigationData2016.AddIrrigationDataDCALaPerdizPivot1_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDCALaPerdizPivot2_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDCALaPerdizPivot3_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDCALaPerdizPivot5_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDCALaPerdizPivot6_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDCALaPerdizPivot7_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDCALaPerdizPivot10b_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDCALaPerdizPivot14_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDCALaPerdizPivot15_2016(context, Program.DateOfReference);
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
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot1_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot2_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot3_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot4_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot5_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot6_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot7_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot8_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot9_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot10_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot11_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot12_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot13_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot14_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot15_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivotChaja1_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivotChaja2_2016(context, Program.DateOfReference);

                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot1_2016b(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot2_2016b(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot3_2016b(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataDelLagoElMiradorPivot4_2016b(context, Program.DateOfReference);

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
                    IrrigationData2016.AddIrrigationDataTresMariasPivot1_2016(context, Program.DateOfReference);
                    //IrrigationData2016.AddIrrigationDataTresMariasPivot2_2016(context, Program.DateOfReference);
                    //IrrigationData2016.AddIrrigationDataTresMariasPivot3_2016(context, Program.DateOfReference);
                    //IrrigationData2016.AddIrrigationDataTresMariasPivot4_2016(context, Program.DateOfReference);
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
                    //IrrigationData2016.AddIrrigationDataGMOLaPalmaPivot1_2016(context, DateTime pProgram.DateOfReference);
                    IrrigationData2016.AddIrrigationDataGMOLaPalmaPivot2_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataGMOLaPalmaPivot3_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataGMOLaPalmaPivot4_2016(context, Program.DateOfReference);
                    //IrrigationData2016.AddIrrigationDataGMOLaPalmaPivot5_2016(context);
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
                    //IrrigationData2016.AddIrrigationDataGMOElTacuruPivot1a_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataGMOElTacuruPivot1b_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataGMOElTacuruPivot2a_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataGMOElTacuruPivot2b_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataGMOElTacuruPivot3a_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataGMOElTacuruPivot3b_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataGMOElTacuruPivot4_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataGMOElTacuruPivot5_2016(context, Program.DateOfReference);
                    //IrrigationData2016.AddIrrigationDataGMOElTacuruPivot6_2016(context, Program.DateOfReference);
                    //IrrigationData2016.AddIrrigationDataGMOElTacuruPivot7_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataGMOElTacuruPivot8_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataGMOElTacuruPivot9_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataGMOElTacuruPivot10_2016(context, Program.DateOfReference);
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
                    //IrrigationData2016.AddIrrigationDataLaRinconadaPivot1_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataLaRinconadaPivot2_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataLaRinconadaPivot3_1_2016(context, Program.DateOfReference);
                    IrrigationData2016.AddIrrigationDataLaRinconadaPivot13_1_2016(context, Program.DateOfReference);
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
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
                {
                    //RainData2017.AddRainDataDCAElParaisoPivot1_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDCAElParaisoPivot2_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region DCA La Perdiz
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
                {
                    //RainData2017.AddRainDataDCALaPerdizPivot1_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDCALaPerdizPivot2_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDCALaPerdizPivot3_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDCALaPerdizPivot4_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDCALaPerdizPivot5_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDCALaPerdizPivot6_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDCALaPerdizPivot7_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDCALaPerdizPivot10a_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDCALaPerdizPivot10b_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDCALaPerdizPivot14_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDCALaPerdizPivot15_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region DCA San Jose
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
                {
                    RainData2017.AddRainDataDCASanJosePivot1_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDCASanJosePivot2_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDCASanJosePivot3_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDCASanJosePivot4_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Del Lago - San Pedro
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
                {

                    //RainData2017.AddRainDataDelLagoSanPedroPivot1_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDelLagoSanPedroPivot2_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDelLagoSanPedroPivot3_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDelLagoSanPedroPivot4_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoSanPedroPivot5_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoSanPedroPivot6_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoSanPedroPivot7_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoSanPedroPivot8_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDelLagoSanPedroPivot9_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDelLagoSanPedroPivot10_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDelLagoSanPedroPivot11_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDelLagoSanPedroPivot12_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDelLagoSanPedroPivot13_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDelLagoSanPedroPivot14_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDelLagoSanPedroPivot15_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDelLagoSanPedroPivot16_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDelLagoSanPedroPivot17_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region Del Lago - El Mirador
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
                {
                    RainData2017.AddRainDataDelLagoElMiradorPivot1_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoElMiradorPivot2_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoElMiradorPivot3_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoElMiradorPivot4_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoElMiradorPivot5_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoElMiradorPivot6_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDelLagoElMiradorPivot7_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoElMiradorPivot8_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoElMiradorPivot9_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoElMiradorPivot10_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoElMiradorPivot11_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoElMiradorPivot12_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoElMiradorPivot13_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoElMiradorPivot14_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoElMiradorPivot15_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoElMiradorPivotChaja1_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataDelLagoElMiradorPivotChaja2_2017(context, Program.DateOfReference);

                    //RainData2017.AddRainDataDelLagoElMiradorPivot1_2017b(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDelLagoElMiradorPivot2_2017b(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDelLagoElMiradorPivot3_2017b(context, Program.DateOfReference);
                    //RainData2017.AddRainDataDelLagoElMiradorPivot4_2017b(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Tres Marias
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
                {

                    //RainData2017.AddRainDataTresMariasPivot1_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataTresMariasPivot2_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataTresMariasPivot3_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataTresMariasPivot4_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region El Rincon
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElRincon)
                {

                    RainData2017.AddRainDataElRinconPivot1a_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataElRinconPivot1b_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region El Desafio
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElDesafio)
                {

                    RainData2017.AddRainDataElDesafioPivot1_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataElDesafioPivot2_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Los Naranjales
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LosNaranjales)
                {

                    RainData2017.AddRainDataLosNaranjalesPivot6aT3_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataLosNaranjalesPivot6bT3_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataLosNaranjalesPivot5aT5_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataLosNaranjalesPivot5bT5_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Santa Emilia
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaEmilia)
                {

                    //RainData2017.AddRainDataSantaEmiliaPivot1_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataSantaEmiliaPivot2_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataSantaEmiliaPivot3_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataSantaEmiliaPivot4_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataSantaEmiliaPivot5_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataSantaEmiliaPivot7_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Gran Molino
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GranMolino)
                {

                    RainData2017.AddRainDataGranMolinoPivot1_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGranMolinoPivot2_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGranMolinoPivot3_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGranMolinoPivot4_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGranMolinoPivot5_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGranMolinoPivot2b_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGranMolinoPivot5b_2017(context, Program.DateOfReference);
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
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
                {
                    RainData2017.AddRainDataGMOElTacuruPivot1a_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOElTacuruPivot1b_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOElTacuruPivot2a_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOElTacuruPivot2b_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOElTacuruPivot3a_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOElTacuruPivot3b_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOElTacuruPivot4_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOElTacuruPivot5_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataGMOElTacuruPivot6_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataGMOElTacuruPivot7_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOElTacuruPivot8_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOElTacuruPivot9_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOElTacuruPivot10_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region GMO - La Palma
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
                {
                    RainData2017.AddRainDataGMOLaPalmaPivot1_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOLaPalmaPivot2_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOLaPalmaPivot3_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOLaPalmaPivot4_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOLaPalmaPivot1_1_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOLaPalmaPivot2_1_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOLaPalmaPivot3_1_2017(context, Program.DateOfReference);
                    RainData2017.AddRainDataGMOLaPalmaPivot4_1_2017(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region La Rinconada
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
                {

                    //RainData2017.AddRainDataLaRinconadaPivot1_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataLaRinconadaPivot2_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataLaRinconadaPivot3_1_2017(context, Program.DateOfReference);
                    //RainData2017.AddRainDataLaRinconadaPivot13_1_2017(context, Program.DateOfReference);
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2017.AddIrrigationDataDCAElParaisoPivot1_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDCAElParaisoPivot2_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion
            #region DCA San Jose
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2017.AddIrrigationDataDCASanJosePivot1_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDCASanJosePivot2_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDCASanJosePivot3_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDCASanJosePivot4_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion
            #region DCA La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2017.AddIrrigationDataDCALaPerdizPivot1_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDCALaPerdizPivot2_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDCALaPerdizPivot3_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDCALaPerdizPivot5_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDCALaPerdizPivot6_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDCALaPerdizPivot7_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDCALaPerdizPivot10b_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDCALaPerdizPivot14_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDCALaPerdizPivot15_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Del Lago - San Pedro
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    //IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot1_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot2_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot3_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot4_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot5_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot6_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot7_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot8_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot9_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot10_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot11_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot12_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot13_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot14_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot15_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot16_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDelLagoSanPedroPivot17_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion
            #region Del Lago - El Mirador
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                ;
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot1_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot2_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot3_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot4_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot5_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot6_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot7_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot8_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot9_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot10_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot11_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot12_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot13_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot14_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot15_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivotChaja1_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivotChaja2_2017(context, Program.DateOfReference);

                    //IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot1_2017b(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot2_2017b(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot3_2017b(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataDelLagoElMiradorPivot4_2017b(context, Program.DateOfReference);

                    context.SaveChanges();

                }
            }
            #endregion

            #region Tres Marias
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2017.AddIrrigationDataTresMariasPivot1_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataTresMariasPivot2_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataTresMariasPivot3_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataTresMariasPivot4_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region El Rincon
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElRincon)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2017.AddIrrigationDataElRinconPivot1a_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataElRinconPivot1b_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region El Desafio
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElDesafio)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2017.AddIrrigationDataElDesafioPivot1_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataElDesafioPivot2_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Los Naranjales
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LosNaranjales)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2017.AddIrrigationDataLosNaranjalesPivot6aT3_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataLosNaranjalesPivot6bT3_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataLosNaranjalesPivot5aT5_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataLosNaranjalesPivot5bT5_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Santa Emilia
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaEmilia)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2017.AddIrrigationDataSantaEmiliaPivot1_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataSantaEmiliaPivot2_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataSantaEmiliaPivot3_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataSantaEmiliaPivot4_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataSantaEmiliaPivot5_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataSantaEmiliaPivot7_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Gran Molino
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GranMolino)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2017.AddIrrigationDataGranMolinoPivot1_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGranMolinoPivot2_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGranMolinoPivot3_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGranMolinoPivot4_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGranMolinoPivot5_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGranMolinoPivot2b_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGranMolinoPivot5b_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #endregion

            #region North

            #region GMO - El Tacuru
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2017.AddIrrigationDataGMOElTacuruPivot1a_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOElTacuruPivot1b_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOElTacuruPivot2a_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOElTacuruPivot2b_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOElTacuruPivot3a_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOElTacuruPivot3b_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOElTacuruPivot4_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOElTacuruPivot5_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataGMOElTacuruPivot6_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataGMOElTacuruPivot7_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOElTacuruPivot8_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOElTacuruPivot9_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOElTacuruPivot10_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion
            #region GMO - La Palma
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2017.AddIrrigationDataGMOLaPalmaPivot1_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOLaPalmaPivot2_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOLaPalmaPivot3_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOLaPalmaPivot4_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOLaPalmaPivot1_1_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOLaPalmaPivot2_1_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOLaPalmaPivot3_1_2017(context, Program.DateOfReference);
                    IrrigationData2017.AddIrrigationDataGMOLaPalmaPivot4_1_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region La Rinconada
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2017.AddIrrigationDataLaRinconadaPivot1_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataLaRinconadaPivot2_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataLaRinconadaPivot3_1_2017(context, Program.DateOfReference);
                    //IrrigationData2017.AddIrrigationDataLaRinconadaPivot13_1_2017(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #endregion

        }

        #endregion

        #region Season_2018_2019

        /// <summary>
        /// Add Rain Data to Pivots in Farms
        /// </summary>
        public static void UpdateInformationOfRain2018()
        {

            #region South

            using (var context = new IrrigationAdvisorContext())
            {
                #region DCA El Paraiso
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
                {
                    //RainData2018.AddRainDataDCAElParaisoPivot1_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDCAElParaisoPivot2_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDCAElParaisoPivot3_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDCAElParaisoPivot4_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region DCA La Perdiz
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
                {
                    RainData2018.AddRainDataDCALaPerdizPivot1_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDCALaPerdizPivot2_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDCALaPerdizPivot3_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDCALaPerdizPivot4_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDCALaPerdizPivot5_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDCALaPerdizPivot6_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDCALaPerdizPivot7_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDCALaPerdizPivot10a_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDCALaPerdizPivot10b_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDCALaPerdizPivot14_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDCALaPerdizPivot15_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region DCA San Jose
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
                {
                    //RainData2018.AddRainDataDCASanJosePivot1_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDCASanJosePivot2_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDCASanJosePivot3_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDCASanJosePivot4_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Del Lago - San Pedro
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
                {

                    //RainData2018.AddRainDataDelLagoSanPedroPivot1_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoSanPedroPivot2_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoSanPedroPivot3_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoSanPedroPivot4_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDelLagoSanPedroPivot5_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDelLagoSanPedroPivot6_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDelLagoSanPedroPivot7_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDelLagoSanPedroPivot8_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoSanPedroPivot9_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoSanPedroPivot10_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoSanPedroPivot11_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoSanPedroPivot12_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoSanPedroPivot13_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoSanPedroPivot14_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoSanPedroPivot15_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoSanPedroPivot16_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoSanPedroPivot17_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region Del Lago - El Mirador
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
                {
                    RainData2018.AddRainDataDelLagoElMiradorPivot1_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDelLagoElMiradorPivot2_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDelLagoElMiradorPivot3_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDelLagoElMiradorPivot4_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDelLagoElMiradorPivot5_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataDelLagoElMiradorPivot6_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoElMiradorPivot7_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoElMiradorPivot8_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoElMiradorPivot9_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoElMiradorPivot10_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoElMiradorPivot11_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoElMiradorPivot12_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoElMiradorPivot13_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoElMiradorPivot14_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoElMiradorPivot15_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoElMiradorPivotChaja1_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoElMiradorPivotChaja2_2018(context, Program.DateOfReference);

                    //RainData2018.AddRainDataDelLagoElMiradorPivot1_2018b(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoElMiradorPivot2_2018b(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoElMiradorPivot3_2018b(context, Program.DateOfReference);
                    //RainData2018.AddRainDataDelLagoElMiradorPivot4_2018b(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Tres Marias
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
                {

                    //RainData2018.AddRainDataTresMariasPivot1_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataTresMariasPivot2_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataTresMariasPivot3_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataTresMariasPivot4_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region El Rincon
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElRincon)
                {

                    //RainData2018.AddRainDataElRinconPivot1a_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataElRinconPivot1b_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataElRinconPivot2a_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataElRinconPivot2b_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region El Desafio
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElDesafio)
                {

                    RainData2018.AddRainDataElDesafioPivot1_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataElDesafioPivot2_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Los Naranjales
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LosNaranjales)
                {

                    RainData2018.AddRainDataLosNaranjalesPivot6aT3_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataLosNaranjalesPivot6bT3_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataLosNaranjalesPivot5aT5_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataLosNaranjalesPivot5bT5_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Santa Emilia
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaEmilia)
                {

                    //RainData2018.AddRainDataSantaEmiliaPivot1_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataSantaEmiliaPivot2_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataSantaEmiliaPivot3_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataSantaEmiliaPivot4_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataSantaEmiliaPivot5_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataSantaEmiliaPivot7_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataSantaEmiliaPivotZP_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Gran Molino
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GranMolino)
                {

                    RainData2018.AddRainDataGranMolinoPivot1_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGranMolinoPivot2_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGranMolinoPivot3_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGranMolinoPivot4_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGranMolinoPivot5_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGranMolinoPivot2b_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGranMolinoPivot5b_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region La Portuguesa
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPortuguesa)
                {

                    RainData2018.AddRainDataLaPortuguesaPivot1_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataLaPortuguesaPivot2_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Cassarino - La Perdiz
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.CassarinoLaPerdiz)
                {

                    RainData2018.AddRainDataCassarinoLaPerdizPivot11_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataCassarinoLaPerdizPivot12_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataCassarinoLaPerdizPivot13_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Santo Domingo
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantoDomingo)
                {

                    RainData2018.AddRainDataSantoDomingoPivot1_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataSantoDomingoPivot2_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Cecchini
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Cecchini)
                {

                    RainData2018.AddRainDataCecchiniPivot1_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataCecchiniPivot2_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region El Alba
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElAlba)
                {

                    RainData2018.AddRainDataElAlbaPivot32_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataElAlbaPivot33_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }

                #endregion

                #region La Zenaida
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaZenaida)
                {

                    RainData2018.AddRainDataLaZenaidaPivot1_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataLaZenaidaPivot2_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataLaZenaidaPivot3_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataLaZenaidaPivot4_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataLaZenaidaPivot5_2018(context, Program.DateOfReference);

                    RainData2018.AddRainDataLaZenaidaPivot1a_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataLaZenaidaPivot4a_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataLaZenaidaPivot5a_2018(context, Program.DateOfReference);
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
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
                {
                    RainData2018.AddRainDataGMOElTacuruPivot1a_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOElTacuruPivot1b_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOElTacuruPivot2a_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOElTacuruPivot2b_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOElTacuruPivot3a_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOElTacuruPivot3b_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOElTacuruPivot4_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOElTacuruPivot5_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataGMOElTacuruPivot6_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataGMOElTacuruPivot7_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOElTacuruPivot8_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOElTacuruPivot9_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOElTacuruPivot10_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region GMO - La Palma
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
                {
                    RainData2018.AddRainDataGMOLaPalmaPivot1_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOLaPalmaPivot2_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOLaPalmaPivot3_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOLaPalmaPivot4_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOLaPalmaPivot1_1_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOLaPalmaPivot2_1_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOLaPalmaPivot3_1_2018(context, Program.DateOfReference);
                    RainData2018.AddRainDataGMOLaPalmaPivot4_1_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region La Rinconada
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
                {

                    //RainData2018.AddRainDataLaRinconadaPivot1_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataLaRinconadaPivot2_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataLaRinconadaPivot3_1_2018(context, Program.DateOfReference);
                    //RainData2018.AddRainDataLaRinconadaPivot13_1_2018(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
            }
            #endregion

        }

        /// <summary>
        /// Add Irrigation Data to Pivots in Farms
        /// </summary>
        public static void UpdateInformationOfIrrigation2018()
        {

            #region South

            #region DCA El Paraiso
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2018.AddIrrigationDataDCAElParaisoPivot1_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDCAElParaisoPivot2_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDCAElParaisoPivot3_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDCAElParaisoPivot4_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion
            #region DCA San Jose
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2018.AddIrrigationDataDCASanJosePivot1_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDCASanJosePivot2_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDCASanJosePivot3_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDCASanJosePivot4_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion
            #region DCA La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2018.AddIrrigationDataDCALaPerdizPivot1_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDCALaPerdizPivot2_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDCALaPerdizPivot3_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDCALaPerdizPivot5_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDCALaPerdizPivot6_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDCALaPerdizPivot7_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDCALaPerdizPivot10a_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDCALaPerdizPivot10b_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDCALaPerdizPivot14_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDCALaPerdizPivot15_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Del Lago - San Pedro
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    //IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot1_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot2_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot3_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot4_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot5_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot6_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot7_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot8_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot9_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot10_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot11_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot12_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot13_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot14_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot15_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot16_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDelLagoSanPedroPivot17_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion
            #region Del Lago - El Mirador
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                ;
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot1_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot2_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot3_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot4_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot5_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot6_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot7_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot8_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot9_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot10_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot11_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot12_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot13_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot14_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot15_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivotChaja1_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivotChaja2_2018(context, Program.DateOfReference);

                    //IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot1_2018b(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot2_2018b(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot3_2018b(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataDelLagoElMiradorPivot4_2018b(context, Program.DateOfReference);

                    context.SaveChanges();

                }
            }
            #endregion

            #region Tres Marias
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2018.AddIrrigationDataTresMariasPivot1_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataTresMariasPivot2_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataTresMariasPivot3_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataTresMariasPivot4_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region El Rincon
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElRincon)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2018.AddIrrigationDataElRinconPivot1a_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataElRinconPivot1b_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataElRinconPivot2a_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataElRinconPivot2b_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region El Desafio
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElDesafio)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2018.AddIrrigationDataElDesafioPivot1_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataElDesafioPivot2_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Los Naranjales
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LosNaranjales)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2018.AddIrrigationDataLosNaranjalesPivot6aT3_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataLosNaranjalesPivot6bT3_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataLosNaranjalesPivot5aT5_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataLosNaranjalesPivot5bT5_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Santa Emilia
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaEmilia)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2018.AddIrrigationDataSantaEmiliaPivot1_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataSantaEmiliaPivot2_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataSantaEmiliaPivot3_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataSantaEmiliaPivot4_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataSantaEmiliaPivot5_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataSantaEmiliaPivot7_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataSantaEmiliaPivotZP_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Gran Molino
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GranMolino)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2018.AddIrrigationDataGranMolinoPivot1_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGranMolinoPivot2_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGranMolinoPivot3_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGranMolinoPivot4_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGranMolinoPivot5_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGranMolinoPivot2b_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGranMolinoPivot5b_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region La Portuguesa
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPortuguesa)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2018.AddIrrigationDataLaPortuguesaPivot1_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataLaPortuguesaPivot2_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Cassarino - La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.CassarinoLaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2018.AddIrrigationDataCassarinoLaPerdizPivot11_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataCassarinoLaPerdizPivot12_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataCassarinoLaPerdizPivot13_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Santo Domingo
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantoDomingo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2018.AddIrrigationDataSantoDomingoPivot1_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataSantoDomingoPivot2_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Cecchini
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Cecchini)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2018.AddIrrigationDataCecchiniPivot1_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataCecchiniPivot2_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region El Alba
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElAlba)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2018.AddIrrigationDataElAlbaPivot32_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataElAlbaPivot33_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region La Zenaida
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaZenaida)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2018.AddIrrigationDataLaZenaidaPivot1_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataLaZenaidaPivot2_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataLaZenaidaPivot3_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataLaZenaidaPivot4_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataLaZenaidaPivot5_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataLaZenaidaPivot1a_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataLaZenaidaPivot4a_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataLaZenaidaPivot5a_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #endregion

            #region North

            #region GMO - El Tacuru
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2018.AddIrrigationDataGMOElTacuruPivot1a_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOElTacuruPivot1b_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOElTacuruPivot2a_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOElTacuruPivot2b_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOElTacuruPivot3a_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOElTacuruPivot3b_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOElTacuruPivot4_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOElTacuruPivot5_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataGMOElTacuruPivot6_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataGMOElTacuruPivot7_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOElTacuruPivot8_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOElTacuruPivot9_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOElTacuruPivot10_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion
            #region GMO - La Palma
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2018.AddIrrigationDataGMOLaPalmaPivot1_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOLaPalmaPivot2_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOLaPalmaPivot3_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOLaPalmaPivot4_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOLaPalmaPivot1_1_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOLaPalmaPivot2_1_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOLaPalmaPivot3_1_2018(context, Program.DateOfReference);
                    IrrigationData2018.AddIrrigationDataGMOLaPalmaPivot4_1_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region La Rinconada
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2018.AddIrrigationDataLaRinconadaPivot1_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataLaRinconadaPivot2_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataLaRinconadaPivot3_1_2018(context, Program.DateOfReference);
                    //IrrigationData2018.AddIrrigationDataLaRinconadaPivot13_1_2018(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #endregion

        }

        #endregion

        #region Season_2019_2020

        /// <summary>
        /// Add Rain Data to Pivots in Farms
        /// </summary>
        public static void UpdateInformationOfRain2019()
        {

            #region South

            using (var context = new IrrigationAdvisorContext())
            {
                #region DCA El Paraiso
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
                {
                    //RainData2019.AddRainDataDCAElParaisoPivot1_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDCAElParaisoPivot2_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDCAElParaisoPivot3_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDCAElParaisoPivot4_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region DCA La Perdiz
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
                {
                    RainData2019.AddRainDataDCALaPerdizPivot1_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDCALaPerdizPivot2_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDCALaPerdizPivot3_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDCALaPerdizPivot4_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDCALaPerdizPivot5_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDCALaPerdizPivot6_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDCALaPerdizPivot7_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDCALaPerdizPivot10a_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDCALaPerdizPivot10b_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDCALaPerdizPivot14_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDCALaPerdizPivot15_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region DCA San Jose
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
                {
                    RainData2019.AddRainDataDCASanJosePivot1_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDCASanJosePivot2_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDCASanJosePivot3_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDCASanJosePivot4_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Del Lago - San Pedro
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
                {

                    //RainData2019.AddRainDataDelLagoSanPedroPivot1_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoSanPedroPivot2_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoSanPedroPivot3_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoSanPedroPivot4_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDelLagoSanPedroPivot5_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDelLagoSanPedroPivot6_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDelLagoSanPedroPivot7_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDelLagoSanPedroPivot8_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoSanPedroPivot9_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoSanPedroPivot10_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoSanPedroPivot11_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoSanPedroPivot12_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoSanPedroPivot13_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoSanPedroPivot14_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoSanPedroPivot15_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoSanPedroPivot16_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoSanPedroPivot17_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region Del Lago - El Mirador
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
                {
                    RainData2019.AddRainDataDelLagoElMiradorPivot1_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDelLagoElMiradorPivot2_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDelLagoElMiradorPivot3_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDelLagoElMiradorPivot4_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDelLagoElMiradorPivot5_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataDelLagoElMiradorPivot6_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoElMiradorPivot7_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoElMiradorPivot8_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoElMiradorPivot9_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoElMiradorPivot10_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoElMiradorPivot11_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoElMiradorPivot12_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoElMiradorPivot13_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoElMiradorPivot14_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoElMiradorPivot15_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoElMiradorPivotChaja1_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoElMiradorPivotChaja2_2019(context, Program.DateOfReference);

                    //RainData2019.AddRainDataDelLagoElMiradorPivot1_2019b(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoElMiradorPivot2_2019b(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoElMiradorPivot3_2019b(context, Program.DateOfReference);
                    //RainData2019.AddRainDataDelLagoElMiradorPivot4_2019b(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Tres Marias
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
                {

                    //RainData2019.AddRainDataTresMariasPivot1_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataTresMariasPivot2_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataTresMariasPivot3_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataTresMariasPivot4_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region El Rincon
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElRincon)
                {

                    //RainData2019.AddRainDataElRinconPivot1a_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataElRinconPivot1b_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataElRinconPivot2a_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataElRinconPivot2b_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region El Desafio
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElDesafio)
                {

                    RainData2019.AddRainDataElDesafioPivot1_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataElDesafioPivot2_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Los Naranjales
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LosNaranjales)
                {

                    RainData2019.AddRainDataLosNaranjalesPivot6aT3_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataLosNaranjalesPivot6bT3_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataLosNaranjalesPivot5aT5_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataLosNaranjalesPivot5bT5_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Santa Emilia
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaEmilia)
                {

                    //RainData2019.AddRainDataSantaEmiliaPivot1_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataSantaEmiliaPivot2_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataSantaEmiliaPivot3_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataSantaEmiliaPivot4_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataSantaEmiliaPivot5_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataSantaEmiliaPivot7_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataSantaEmiliaPivotZP_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Gran Molino
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GranMolino)
                {

                    RainData2019.AddRainDataGranMolinoPivot1_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGranMolinoPivot2_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGranMolinoPivot3_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGranMolinoPivot4_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGranMolinoPivot5_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGranMolinoPivot2b_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGranMolinoPivot5b_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region La Portuguesa
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPortuguesa)
                {

                    RainData2019.AddRainDataLaPortuguesaPivot1_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataLaPortuguesaPivot2_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Cassarino - La Perdiz
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.CassarinoLaPerdiz)
                {

                    RainData2019.AddRainDataCassarinoLaPerdizPivot11_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataCassarinoLaPerdizPivot12_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataCassarinoLaPerdizPivot13_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Santo Domingo
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantoDomingo)
                {

                    RainData2019.AddRainDataSantoDomingoPivot1_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataSantoDomingoPivot2_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region Cecchini
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Cecchini)
                {

                    RainData2019.AddRainDataCecchiniPivot1_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataCecchiniPivot2_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region El Alba
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElAlba)
                {

                    //RainData2019.AddRainDataElAlbaPivot32_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataElAlbaPivot33_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataElAlbaPivot38_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataElAlbaPivot40_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }

                #endregion

                #region La Zenaida
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaZenaida)
                {

                    //RainData2019.AddRainDataLaZenaidaPivot1_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataLaZenaidaPivot2_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataLaZenaidaPivot3_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataLaZenaidaPivot4_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataLaZenaidaPivot5_2019(context, Program.DateOfReference);

                    //RainData2019.AddRainDataLaZenaidaPivot1a_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataLaZenaidaPivot4a_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataLaZenaidaPivot5a_2019(context, Program.DateOfReference);
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
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
                {
                    RainData2019.AddRainDataGMOElTacuruPivot1a_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOElTacuruPivot1b_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOElTacuruPivot2a_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOElTacuruPivot2b_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOElTacuruPivot3a_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOElTacuruPivot3b_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOElTacuruPivot4_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOElTacuruPivot5_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataGMOElTacuruPivot6_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataGMOElTacuruPivot7_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOElTacuruPivot8_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOElTacuruPivot9_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOElTacuruPivot10_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
                #region GMO - La Palma
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
                {
                    RainData2019.AddRainDataGMOLaPalmaPivot1_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOLaPalmaPivot2_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOLaPalmaPivot3_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOLaPalmaPivot4_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOLaPalmaPivot1_1_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOLaPalmaPivot2_1_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOLaPalmaPivot3_1_2019(context, Program.DateOfReference);
                    RainData2019.AddRainDataGMOLaPalmaPivot4_1_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion

                #region La Rinconada
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
                {

                    //RainData2019.AddRainDataLaRinconadaPivot1_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataLaRinconadaPivot2_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataLaRinconadaPivot3_1_2019(context, Program.DateOfReference);
                    //RainData2019.AddRainDataLaRinconadaPivot13_1_2019(context, Program.DateOfReference);
                    context.SaveChanges();
                }
                #endregion
            }
            #endregion

        }

        /// <summary>
        /// Add Irrigation Data to Pivots in Farms
        /// </summary>
        public static void UpdateInformationOfIrrigation2019()
        {

            #region South

            #region DCA El Paraiso
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2019.AddIrrigationDataDCAElParaisoPivot1_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDCAElParaisoPivot2_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDCAElParaisoPivot3_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDCAElParaisoPivot4_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion
            #region DCA San Jose
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2019.AddIrrigationDataDCASanJosePivot1_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDCASanJosePivot2_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDCASanJosePivot3_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDCASanJosePivot4_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion
            #region DCA La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2019.AddIrrigationDataDCALaPerdizPivot1_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDCALaPerdizPivot2_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDCALaPerdizPivot3_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDCALaPerdizPivot5_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDCALaPerdizPivot6_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDCALaPerdizPivot7_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDCALaPerdizPivot10a_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDCALaPerdizPivot10b_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDCALaPerdizPivot14_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDCALaPerdizPivot15_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Del Lago - San Pedro
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    //IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot1_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot2_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot3_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot4_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot5_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot6_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot7_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot8_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot9_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot10_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot11_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot12_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot13_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot14_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot15_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot16_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDelLagoSanPedroPivot17_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion
            #region Del Lago - El Mirador
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                ;
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot1_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot2_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot3_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot4_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot5_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot6_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot7_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot8_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot9_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot10_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot11_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot12_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot13_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot14_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot15_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivotChaja1_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivotChaja2_2019(context, Program.DateOfReference);

                    //IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot1_2019b(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot2_2019b(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot3_2019b(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataDelLagoElMiradorPivot4_2019b(context, Program.DateOfReference);

                    context.SaveChanges();

                }
            }
            #endregion

            #region Tres Marias
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2019.AddIrrigationDataTresMariasPivot1_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataTresMariasPivot2_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataTresMariasPivot3_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataTresMariasPivot4_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region El Rincon
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElRincon)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2019.AddIrrigationDataElRinconPivot1a_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataElRinconPivot1b_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataElRinconPivot2a_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataElRinconPivot2b_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region El Desafio
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElDesafio)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2019.AddIrrigationDataElDesafioPivot1_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataElDesafioPivot2_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Los Naranjales
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LosNaranjales)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2019.AddIrrigationDataLosNaranjalesPivot6aT3_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataLosNaranjalesPivot6bT3_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataLosNaranjalesPivot5aT5_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataLosNaranjalesPivot5bT5_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Santa Emilia
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaEmilia)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2019.AddIrrigationDataSantaEmiliaPivot1_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataSantaEmiliaPivot2_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataSantaEmiliaPivot3_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataSantaEmiliaPivot4_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataSantaEmiliaPivot5_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataSantaEmiliaPivot7_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataSantaEmiliaPivotZP_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Gran Molino
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GranMolino)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2019.AddIrrigationDataGranMolinoPivot1_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGranMolinoPivot2_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGranMolinoPivot3_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGranMolinoPivot4_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGranMolinoPivot5_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGranMolinoPivot2b_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGranMolinoPivot5b_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region La Portuguesa
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPortuguesa)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2019.AddIrrigationDataLaPortuguesaPivot1_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataLaPortuguesaPivot2_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Cassarino - La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.CassarinoLaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2019.AddIrrigationDataCassarinoLaPerdizPivot11_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataCassarinoLaPerdizPivot12_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataCassarinoLaPerdizPivot13_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Santo Domingo
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantoDomingo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2019.AddIrrigationDataSantoDomingoPivot1_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataSantoDomingoPivot2_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region Cecchini
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Cecchini)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2019.AddIrrigationDataCecchiniPivot1_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataCecchiniPivot2_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region El Alba
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElAlba)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2019.AddIrrigationDataElAlbaPivot32_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataElAlbaPivot33_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataElAlbaPivot38_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataElAlbaPivot40_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region La Zenaida
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaZenaida)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2019.AddIrrigationDataLaZenaidaPivot1_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataLaZenaidaPivot2_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataLaZenaidaPivot3_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataLaZenaidaPivot4_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataLaZenaidaPivot5_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataLaZenaidaPivot1a_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataLaZenaidaPivot4a_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataLaZenaidaPivot5a_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #endregion

            #region North

            #region GMO - El Tacuru
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2019.AddIrrigationDataGMOElTacuruPivot1a_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOElTacuruPivot1b_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOElTacuruPivot2a_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOElTacuruPivot2b_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOElTacuruPivot3a_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOElTacuruPivot3b_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOElTacuruPivot4_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOElTacuruPivot5_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataGMOElTacuruPivot6_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataGMOElTacuruPivot7_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOElTacuruPivot8_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOElTacuruPivot9_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOElTacuruPivot10_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion
            #region GMO - La Palma
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    IrrigationData2019.AddIrrigationDataGMOLaPalmaPivot1_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOLaPalmaPivot2_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOLaPalmaPivot3_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOLaPalmaPivot4_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOLaPalmaPivot1_1_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOLaPalmaPivot2_1_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOLaPalmaPivot3_1_2019(context, Program.DateOfReference);
                    IrrigationData2019.AddIrrigationDataGMOLaPalmaPivot4_1_2019(context, Program.DateOfReference);
                    context.SaveChanges();

                }
            }
            #endregion

            #region La Rinconada
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //IrrigationData2019.AddIrrigationDataLaRinconadaPivot1_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataLaRinconadaPivot2_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataLaRinconadaPivot3_1_2019(context, Program.DateOfReference);
                    //IrrigationData2019.AddIrrigationDataLaRinconadaPivot13_1_2019(context, Program.DateOfReference);
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
