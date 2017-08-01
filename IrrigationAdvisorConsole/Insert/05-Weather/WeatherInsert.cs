using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Language;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.ComplementedUtils;

using IrrigationAdvisor.DBContext;

using IrrigationAdvisorConsole.Data;

namespace IrrigationAdvisorConsole.Insert._05_Weather
{
    public static class WeatherInsert
    {
        #region Weather.Season
        #if true
        
        public static void InsertSeasons()
        {
            Region lRegion = null;
            int lYear = 0;

            using(var context = new IrrigationAdvisorContext())
            {
                #region Base
                var lBaseSouth  = new Season
                {
                    Name = Utils.NameBase,
                    Year = Utils.MIN_DATETIME.Year,
                    WeatherSeason = Utils.WeatherSeason.Spring,
                    RegionId = 0,
                    FromDate = Utils.MIN_DATETIME,
                    ToDate = Utils.MIN_DATETIME,
                };
                #endregion

                #region South
                lRegion = context.Regions.SingleOrDefault(region => region.Name == Utils.NameRegionSouth);
                
                #region 2014
                lYear = 2014;
                #region Summer
                var lSeason2014SummerSouth  = new Season
                {
                    Name = Utils.NameSeasonSummer + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Summer,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate =  new DateTime(lYear-1, 12, 22),
                    ToDate = new DateTime(lYear, 3, 20),
                };
                #endregion
                #region Fall
                var lSeason2014FallSouth  = new Season
                {
                    Name = Utils.NameSeasonFall + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Fall,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 3, 21),
                    ToDate = new DateTime(lYear, 6, 21),
                };
                #endregion
                #region Winter
                var lSeason2014WinterSouth  = new Season
                {
                    Name = Utils.NameSeasonWinter + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Winter,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 6, 22),
                    ToDate = new DateTime(lYear, 9, 20),
                };
                #endregion
                #region Spring
                var lSeason2014SpringSouth  = new Season
                {
                    Name = Utils.NameSeasonSpring + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Spring,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 9, 21),
                    ToDate = new DateTime(lYear, 12, 21),
                };
                #endregion
                #endregion
                #region 2015
                lYear = 2015;
                #region Summer
                var lSeason2015SummerSouth  = new Season
                {
                    Name = Utils.NameSeasonSummer + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Summer,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear - 1, 12, 22),
                    ToDate = new DateTime(lYear, 3, 20),
                };
                #endregion
                #region Fall
                var lSeason2015FallSouth  = new Season
                {
                    Name = Utils.NameSeasonFall + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Fall,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 3, 21),
                    ToDate = new DateTime(lYear, 6, 21),
                };
                #endregion
                #region Winter
                var lSeason2015WinterSouth  = new Season
                {
                    Name = Utils.NameSeasonWinter + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Winter,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 6, 22),
                    ToDate = new DateTime(lYear, 9, 20),
                };
                #endregion
                #region Spring
                var lSeason2015SpringSouth  = new Season
                {
                    Name = Utils.NameSeasonSpring + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Spring,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 9, 21),
                    ToDate = new DateTime(lYear, 12, 21),
                };
                #endregion
                #endregion
                #region 2016
                lYear = 2016;
                #region Summer
                var lSeason2016SummerSouth  = new Season
                {
                    Name = Utils.NameSeasonSummer + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Summer,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear - 1, 12, 22),
                    ToDate = new DateTime(lYear, 3, 20),
                };
                #endregion
                #region Fall
                var lSeason2016FallSouth  = new Season
                {
                    Name = Utils.NameSeasonFall + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Fall,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 3, 21),
                    ToDate = new DateTime(lYear, 6, 21),
                };
                #endregion
                #region Winter
                var lSeason2016WinterSouth  = new Season
                {
                    Name = Utils.NameSeasonWinter + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Winter,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 6, 22),
                    ToDate = new DateTime(lYear, 9, 20),
                };
                #endregion
                #region Spring
                var lSeason2016SpringSouth  = new Season
                {
                    Name = Utils.NameSeasonSpring + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Spring,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 9, 21),
                    ToDate = new DateTime(lYear, 12, 21),
                };
                #endregion
                #endregion
                #region 2017
                lYear = 2017;
                #region Summer
                var lSeason2017SummerSouth  = new Season
                {
                    Name = Utils.NameSeasonSummer + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Summer,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear - 1, 12, 22),
                    ToDate = new DateTime(lYear, 3, 20),
                };
                #endregion
                #region Fall
                var lSeason2017FallSouth  = new Season
                {
                    Name = Utils.NameSeasonFall + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Fall,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 3, 21),
                    ToDate = new DateTime(lYear, 6, 21),
                };
                #endregion
                #region Winter
                var lSeason2017WinterSouth  = new Season
                {
                    Name = Utils.NameSeasonWinter + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Winter,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 6, 22),
                    ToDate = new DateTime(lYear, 9, 20),
                };
                #endregion
                #region Spring
                var lSeason2017SpringSouth  = new Season
                {
                    Name = Utils.NameSeasonSpring + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Spring,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 9, 21),
                    ToDate = new DateTime(lYear, 12, 21),
                };
                #endregion
                #endregion
                #region 2018
                lYear = 2018;
                #region Summer
                var lSeason2018SummerSouth  = new Season
                {
                    Name = Utils.NameSeasonSummer + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Summer,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear - 1, 12, 22),
                    ToDate = new DateTime(lYear, 3, 20),
                };
                #endregion
                #region Fall
                var lSeason2018FallSouth  = new Season
                {
                    Name = Utils.NameSeasonFall + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Fall,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 3, 21),
                    ToDate = new DateTime(lYear, 6, 21),
                };
                #endregion
                #region Winter
                var lSeason2018WinterSouth  = new Season
                {
                    Name = Utils.NameSeasonWinter + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Winter,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 6, 22),
                    ToDate = new DateTime(lYear, 9, 20),
                };
                #endregion
                #region Spring
                var lSeason2018SpringSouth  = new Season
                {
                    Name = Utils.NameSeasonSpring + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Spring,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 9, 21),
                    ToDate = new DateTime(lYear, 12, 21),
                };
                #endregion
                #endregion
                #region 2019
                lYear = 2019;
                #region Summer
                var lSeason2019SummerSouth  = new Season
                {
                    Name = Utils.NameSeasonSummer + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Summer,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear - 1, 12, 22),
                    ToDate = new DateTime(lYear, 3, 20),
                };
                #endregion
                #region Fall
                var lSeason2019FallSouth  = new Season
                {
                    Name = Utils.NameSeasonFall + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Fall,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 3, 21),
                    ToDate = new DateTime(lYear, 6, 21),
                };
                #endregion
                #region Winter
                var lSeason2019WinterSouth  = new Season
                {
                    Name = Utils.NameSeasonWinter + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Winter,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 6, 22),
                    ToDate = new DateTime(lYear, 9, 20),
                };
                #endregion
                #region Spring
                var lSeason2019SpringSouth  = new Season
                {
                    Name = Utils.NameSeasonSpring + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Spring,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 9, 21),
                    ToDate = new DateTime(lYear, 12, 21),
                };
                #endregion
                #endregion
                #region 2020
                lYear = 2020;
                #region Summer
                var lSeason2020SummerSouth  = new Season
                {
                    Name = Utils.NameSeasonSummer + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Summer,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear - 1, 12, 22),
                    ToDate = new DateTime(lYear, 3, 20),
                };
                #endregion
                #region Fall
                var lSeason2020FallSouth  = new Season
                {
                    Name = Utils.NameSeasonFall + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Fall,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 3, 21),
                    ToDate = new DateTime(lYear, 6, 21),
                };
                #endregion
                #region Winter
                var lSeason2020WinterSouth  = new Season
                {
                    Name = Utils.NameSeasonWinter + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Winter,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 6, 22),
                    ToDate = new DateTime(lYear, 9, 20),
                };
                #endregion
                #region Spring
                var lSeason2020SpringSouth  = new Season
                {
                    Name = Utils.NameSeasonSpring + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Spring,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 9, 21),
                    ToDate = new DateTime(lYear, 12, 21),
                };
                #endregion
                #endregion

                context.Seasons.Add(lSeason2014SummerSouth);
                context.Seasons.Add(lSeason2014FallSouth);
                context.Seasons.Add(lSeason2014WinterSouth);
                context.Seasons.Add(lSeason2014SpringSouth);
                context.Seasons.Add(lSeason2015SummerSouth);
                context.Seasons.Add(lSeason2015FallSouth);
                context.Seasons.Add(lSeason2015WinterSouth);
                context.Seasons.Add(lSeason2015SpringSouth); 
                context.Seasons.Add(lSeason2016SummerSouth);
                context.Seasons.Add(lSeason2016FallSouth);
                context.Seasons.Add(lSeason2016WinterSouth);
                context.Seasons.Add(lSeason2016SpringSouth);
                context.Seasons.Add(lSeason2017SummerSouth);
                context.Seasons.Add(lSeason2017FallSouth);
                context.Seasons.Add(lSeason2017WinterSouth);
                context.Seasons.Add(lSeason2017SpringSouth);
                context.Seasons.Add(lSeason2018SummerSouth);
                context.Seasons.Add(lSeason2018FallSouth);
                context.Seasons.Add(lSeason2018WinterSouth);
                context.Seasons.Add(lSeason2018SpringSouth);
                context.Seasons.Add(lSeason2019SummerSouth);
                context.Seasons.Add(lSeason2019FallSouth);
                context.Seasons.Add(lSeason2019WinterSouth);
                context.Seasons.Add(lSeason2019SpringSouth);
                context.Seasons.Add(lSeason2020SummerSouth);
                context.Seasons.Add(lSeason2020FallSouth);
                context.Seasons.Add(lSeason2020WinterSouth);
                context.Seasons.Add(lSeason2020SpringSouth);

                #endregion

                #region North
                lRegion = context.Regions.SingleOrDefault(region => region.Name == Utils.NameRegionNorth);

                #region 2014
                lYear = 2014;
                #region Summer
                var lSeason2014SummerNorth = new Season
                {
                    Name = Utils.NameSeasonSummer + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Summer,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear - 1, 12, 22),
                    ToDate = new DateTime(lYear, 3, 20),
                };
                #endregion
                #region Fall
                var lSeason2014FallNorth = new Season
                {
                    Name = Utils.NameSeasonFall + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Fall,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 3, 21),
                    ToDate = new DateTime(lYear, 6, 21),
                };
                #endregion
                #region Winter
                var lSeason2014WinterNorth = new Season
                {
                    Name = Utils.NameSeasonWinter + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Winter,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 6, 22),
                    ToDate = new DateTime(lYear, 9, 20),
                };
                #endregion
                #region Spring
                var lSeason2014SpringNorth = new Season
                {
                    Name = Utils.NameSeasonSpring + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Spring,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 9, 21),
                    ToDate = new DateTime(lYear, 12, 21),
                };
                #endregion
                #endregion
                #region 2015
                lYear = 2015;
                #region Summer
                var lSeason2015SummerNorth = new Season
                {
                    Name = Utils.NameSeasonSummer + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Summer,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear - 1, 12, 22),
                    ToDate = new DateTime(lYear, 3, 20),
                };
                #endregion
                #region Fall
                var lSeason2015FallNorth = new Season
                {
                    Name = Utils.NameSeasonFall + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Fall,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 3, 21),
                    ToDate = new DateTime(lYear, 6, 21),
                };
                #endregion
                #region Winter
                var lSeason2015WinterNorth = new Season
                {
                    Name = Utils.NameSeasonWinter + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Winter,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 6, 22),
                    ToDate = new DateTime(lYear, 9, 20),
                };
                #endregion
                #region Spring
                var lSeason2015SpringNorth = new Season
                {
                    Name = Utils.NameSeasonSpring + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Spring,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 9, 21),
                    ToDate = new DateTime(lYear, 12, 21),
                };
                #endregion
                #endregion
                #region 2016
                lYear = 2016;
                #region Summer
                var lSeason2016SummerNorth = new Season
                {
                    Name = Utils.NameSeasonSummer + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Summer,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear - 1, 12, 22),
                    ToDate = new DateTime(lYear, 3, 20),
                };
                #endregion
                #region Fall
                var lSeason2016FallNorth = new Season
                {
                    Name = Utils.NameSeasonFall + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Fall,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 3, 21),
                    ToDate = new DateTime(lYear, 6, 21),
                };
                #endregion
                #region Winter
                var lSeason2016WinterNorth = new Season
                {
                    Name = Utils.NameSeasonWinter + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Winter,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 6, 22),
                    ToDate = new DateTime(lYear, 9, 20),
                };
                #endregion
                #region Spring
                var lSeason2016SpringNorth = new Season
                {
                    Name = Utils.NameSeasonSpring + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Spring,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 9, 21),
                    ToDate = new DateTime(lYear, 12, 21),
                };
                #endregion
                #endregion
                #region 2017
                lYear = 2017;
                #region Summer
                var lSeason2017SummerNorth = new Season
                {
                    Name = Utils.NameSeasonSummer + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Summer,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear - 1, 12, 22),
                    ToDate = new DateTime(lYear, 3, 20),
                };
                #endregion
                #region Fall
                var lSeason2017FallNorth = new Season
                {
                    Name = Utils.NameSeasonFall + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Fall,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 3, 21),
                    ToDate = new DateTime(lYear, 6, 21),
                };
                #endregion
                #region Winter
                var lSeason2017WinterNorth = new Season
                {
                    Name = Utils.NameSeasonWinter + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Winter,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 6, 22),
                    ToDate = new DateTime(lYear, 9, 20),
                };
                #endregion
                #region Spring
                var lSeason2017SpringNorth = new Season
                {
                    Name = Utils.NameSeasonSpring + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Spring,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 9, 21),
                    ToDate = new DateTime(lYear, 12, 21),
                };
                #endregion
                #endregion
                #region 2018
                lYear = 2018;
                #region Summer
                var lSeason2018SummerNorth = new Season
                {
                    Name = Utils.NameSeasonSummer + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Summer,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear - 1, 12, 22),
                    ToDate = new DateTime(lYear, 3, 20),
                };
                #endregion
                #region Fall
                var lSeason2018FallNorth = new Season
                {
                    Name = Utils.NameSeasonFall + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Fall,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 3, 21),
                    ToDate = new DateTime(lYear, 6, 21),
                };
                #endregion
                #region Winter
                var lSeason2018WinterNorth = new Season
                {
                    Name = Utils.NameSeasonWinter + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Winter,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 6, 22),
                    ToDate = new DateTime(lYear, 9, 20),
                };
                #endregion
                #region Spring
                var lSeason2018SpringNorth = new Season
                {
                    Name = Utils.NameSeasonSpring + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Spring,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 9, 21),
                    ToDate = new DateTime(lYear, 12, 21),
                };
                #endregion
                #endregion
                #region 2019
                lYear = 2019;
                #region Summer
                var lSeason2019SummerNorth = new Season
                {
                    Name = Utils.NameSeasonSummer + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Summer,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear - 1, 12, 22),
                    ToDate = new DateTime(lYear, 3, 20),
                };
                #endregion
                #region Fall
                var lSeason2019FallNorth = new Season
                {
                    Name = Utils.NameSeasonFall + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Fall,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 3, 21),
                    ToDate = new DateTime(lYear, 6, 21),
                };
                #endregion
                #region Winter
                var lSeason2019WinterNorth = new Season
                {
                    Name = Utils.NameSeasonWinter + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Winter,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 6, 22),
                    ToDate = new DateTime(lYear, 9, 20),
                };
                #endregion
                #region Spring
                var lSeason2019SpringNorth = new Season
                {
                    Name = Utils.NameSeasonSpring + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Spring,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 9, 21),
                    ToDate = new DateTime(lYear, 12, 21),
                };
                #endregion
                #endregion
                #region 2020
                lYear = 2020;
                #region Summer
                var lSeason2020SummerNorth = new Season
                {
                    Name = Utils.NameSeasonSummer + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Summer,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear - 1, 12, 22),
                    ToDate = new DateTime(lYear, 3, 20),
                };
                #endregion
                #region Fall
                var lSeason2020FallNorth = new Season
                {
                    Name = Utils.NameSeasonFall + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Fall,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 3, 21),
                    ToDate = new DateTime(lYear, 6, 21),
                };
                #endregion
                #region Winter
                var lSeason2020WinterNorth = new Season
                {
                    Name = Utils.NameSeasonWinter + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Winter,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 6, 22),
                    ToDate = new DateTime(lYear, 9, 20),
                };
                #endregion
                #region Spring
                var lSeason2020SpringNorth = new Season
                {
                    Name = Utils.NameSeasonSpring + lYear,
                    Year = lYear,
                    WeatherSeason = Utils.WeatherSeason.Spring,
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    FromDate = new DateTime(lYear, 9, 21),
                    ToDate = new DateTime(lYear, 12, 21),
                };
                #endregion
                #endregion

                context.Seasons.Add(lSeason2014SummerNorth);
                context.Seasons.Add(lSeason2014FallNorth);
                context.Seasons.Add(lSeason2014WinterNorth);
                context.Seasons.Add(lSeason2014SpringNorth);
                context.Seasons.Add(lSeason2015SummerNorth);
                context.Seasons.Add(lSeason2015FallNorth);
                context.Seasons.Add(lSeason2015WinterNorth);
                context.Seasons.Add(lSeason2015SpringNorth);
                context.Seasons.Add(lSeason2016SummerNorth);
                context.Seasons.Add(lSeason2016FallNorth);
                context.Seasons.Add(lSeason2016WinterNorth);
                context.Seasons.Add(lSeason2016SpringNorth);
                context.Seasons.Add(lSeason2017SummerNorth);
                context.Seasons.Add(lSeason2017FallNorth);
                context.Seasons.Add(lSeason2017WinterNorth);
                context.Seasons.Add(lSeason2017SpringNorth);
                context.Seasons.Add(lSeason2018SummerNorth);
                context.Seasons.Add(lSeason2018FallNorth);
                context.Seasons.Add(lSeason2018WinterNorth);
                context.Seasons.Add(lSeason2018SpringNorth);
                context.Seasons.Add(lSeason2019SummerNorth);
                context.Seasons.Add(lSeason2019FallNorth);
                context.Seasons.Add(lSeason2019WinterNorth);
                context.Seasons.Add(lSeason2019SpringNorth);
                context.Seasons.Add(lSeason2020SummerNorth);
                context.Seasons.Add(lSeason2020FallNorth);
                context.Seasons.Add(lSeason2020WinterNorth);
                context.Seasons.Add(lSeason2020SpringNorth);

                #endregion

                context.SaveChanges();
            }
        }

        #endif
        #endregion

        #region Weather.WeatherStation
        #if true

        public static void InsertWeatherStationsINIA()
        {
            Position lPosition = null;
            using (var context = new IrrigationAdvisorContext())
            {
                #region Base
                var lBase = new WeatherStation
                {
                    Name = Utils.NameBase,
                    Model = "",
                    StationType = Utils.WeatherStationType.NOWebInformation,
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService = Utils.MAX_DATETIME,
                    UpdateTime = Utils.MAX_DATETIME,
                    WirelessTransmission = 0,
                    PositionId = 0,
                    GiveET = false,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.NoData,
                    WebAddress = "",
                };
                #endregion

                #region Las Brujas

                /* CONTACTO
                 * Estación Experimental "Wilson Ferreira Aldunate"
                 * Ruta 48 Km. 10. Rincón del Colorado, Canelones, Uruguay. CP. 90.200
                 * Tel: +598 23677641
                 * Correo electrónico: inia_lb@inia.org.uy
                 */

                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionWeatherStationLasBrujas
                             select pos).FirstOrDefault();
                var lLasBrujasWS = new WeatherStation
                {
                    Name = Utils.NameWeatherStationLasBrujas,
                    Model = "Estación Experimental Wilson Ferreira Aldunate",
                    StationType = Utils.WeatherStationType.INIA,
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService = Utils.MAX_DATETIME,
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                    WebAddress = "",
                };

                #endregion

                #region La Estanzuela

                /*
                 * Contáctenos:
                 * INIA La Estanzuela
                 * Ruta 50, Km. 11
                 * Colonia, Uruguay
                 * Tel.: 598 4574 8000
                 * Fax: 598 4574 8012
                 * E-mail: iniale@inia.org.uy
                 */

                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionWeatherStationLaEstanzuela
                             select pos).FirstOrDefault();
                var lLaEstanzuelaWS = new WeatherStation
                {
                    Name = Utils.NameWeatherStationLaEstanzuela,
                    Model = "INIA La Estanzuela",
                    StationType = Utils.WeatherStationType.INIA,
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService = Utils.MAX_DATETIME,
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                    WebAddress = "",
                };
                #endregion

                #region Salto Grande
                /*
                 *Contáctenos:
                 * INIA Salto Grande
                 * Camino al Terrible
                 * Salto, Uruguay
                 * Tel.: 598 47335156
                 * Fax: 598 47329624
                 * iniasg@inia.org.uy
                 * www.inia.uy
                 */

                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionWeatherStationSaltoGrande
                             select pos).FirstOrDefault();
                var lSaltoGrandeWS = new WeatherStation
                {
                    Name = Utils.NameWeatherStationSaltoGrande,
                    Model = "INIA Salto Grande",
                    StationType = Utils.WeatherStationType.INIA,
                    DateOfInstallation = new DateTime(2015, 10, 01),
                    DateOfService = new DateTime(2015, 10, 01).AddMonths(6),
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                    WebAddress = "",
                };
                #endregion

                #region Tacuarembo

                /*
                 * Contáctenos:
                 *  INIA Tacuarembó 
                 *  Ruta 5 Km. 386 - Tacuarembó
                 *  Tel.: 598 4632 2407 
                 *  Fax: 598 4632 3969
                 *  E-mail: iniatbo@tb.inia.org.uy - iniatb@tb.inia.org.uy
                 *  www.inia.uy
                 */
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionWeatherStationTacuarembo
                             select pos).FirstOrDefault();
                var lTacuaremboWS = new WeatherStation
                {
                    Name = Utils.NameWeatherStationTacuarembo,
                    Model = "INIA Tacuarembó",
                    StationType = Utils.WeatherStationType.INIA,
                    DateOfInstallation = new DateTime(2015, 10, 01),
                    DateOfService = new DateTime(2015, 10, 01).AddMonths(6),
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                    WebAddress = "",
                };
                #endregion

                #region SantaLucia
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionWeatherStationSantaLucia
                             select pos).FirstOrDefault();
                var lSantaLuciaWS = new WeatherStation
                {
                    Name = Utils.NameWeatherStationSantaLucia,
                    Model = "INIA Santa Lucia",
                    StationType = Utils.WeatherStationType.INIA,
                    DateOfInstallation = new DateTime(2015, 10, 01),
                    DateOfService = new DateTime(2015, 10, 01).AddMonths(6),
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                    WebAddress = "",
                };
                #endregion

                //context.WeatherStations.Add(lBase);
                context.WeatherStations.Add(lLasBrujasWS);
                context.WeatherStations.Add(lLaEstanzuelaWS);
                context.WeatherStations.Add(lSaltoGrandeWS);
                context.WeatherStations.Add(lTacuaremboWS);
                context.WeatherStations.Add(lSantaLuciaWS);
                context.SaveChanges();
            };
        }

        public static void InsertWeatherStationsWeatherLink()
        {
            Position lPosition = null;
            using (var context = new IrrigationAdvisorContext())
            {
                #region Base
                var lBase = new WeatherStation
                {
                    Name = Utils.NameBase,
                    Model = "",
                    StationType = Utils.WeatherStationType.NOWebInformation,
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService = Utils.MAX_DATETIME,
                    UpdateTime = Utils.MAX_DATETIME,
                    WirelessTransmission = 0,
                    PositionId = 0,
                    GiveET = false,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.NoData,
                    WebAddress = "",
                };
                #endregion

                /*
                    La Tribu - florida
                    El Cure – rocha
                    JCS Servicios - ruta 2 Soriano
                    Maria Elena - Young
                    El Retiro - Paysandu
                    Zanja Honda - Salto
                "http://www.weatherlink.com/user/latribu/index.php?view=summary&headers=1&type=1",
                "http://www.weatherlink.com/user/lagunaderocha/index.php?view=summary&headers=1&type=1",
                "http://www.weatherlink.com/user/jcservicios/index.php?view=summary&headers=1&type=1",
                "http://www.weatherlink.com/user/mariaelena/index.php?view=summary&headers=1&type=1",
                "http://www.weatherlink.com/user/elretiro/index.php?view=summary&headers=1&type=1",
                "http://www.weatherlink.com/user/noridelzh/index.php?view=summary&headers=1&type=1"
                 */

                #region La Tribu - Florida

                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionWeatherStationLaTribu
                             select pos).FirstOrDefault();
                var lLaTribuWS = new WeatherStation
                {
                    Name = Utils.NameWeatherStationLaTribu,
                    Model = "Estación La Tribu",
                    StationType = Utils.WeatherStationType.WeatherLink,
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService = Utils.MAX_DATETIME,
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                    WebAddress = "http://www.weatherlink.com/user/latribu/index.php?view=summary&headers=1&type=1",
                };

                #endregion

                #region El Cure – Rocha

                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionWeatherStationElCure
                             select pos).FirstOrDefault();
                var lElCureWS = new WeatherStation
                {
                    Name = Utils.NameWeatherStationElCure,
                    Model = "Estacion Las Garzas CURE-UdelaR",
                    StationType = Utils.WeatherStationType.WeatherLink,
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService = Utils.MAX_DATETIME,
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                    WebAddress = "http://www.weatherlink.com/user/lagunaderocha/index.php?view=summary&headers=1&type=1",
                };
                #endregion

                #region JC Servicios - ruta 2 Soriano

                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionWeatherStationJCServicios
                             select pos).FirstOrDefault();
                var lJCServiciosWS = new WeatherStation
                {
                    Name = Utils.NameWeatherStationJCServicios,
                    Model = "JCServicios",
                    StationType = Utils.WeatherStationType.WeatherLink,
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService = Utils.MAX_DATETIME,
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                    WebAddress = "http://www.weatherlink.com/user/jcservicios/index.php?view=summary&headers=1&type=1",
                };
                #endregion

                #region Maria Elena - Young

                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionWeatherStationMariaElena
                             select pos).FirstOrDefault();
                var lMariaElenaWS = new WeatherStation
                {
                    Name = Utils.NameWeatherStationMariaElena,
                    Model = "Maria Elena",
                    StationType = Utils.WeatherStationType.WeatherLink,
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService = Utils.MAX_DATETIME,
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                    //2016-10-27 not used, does not have good data
                    //WebAddress = "http://www.weatherlink.com/user/mariaelena/index.php?view=summary&headers=1&type=1",
                };
                #endregion

                #region El Retiro - Paysandu
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionWeatherStationElRetiro
                             select pos).FirstOrDefault();
                var lElRetiroWS = new WeatherStation
                {
                    Name = Utils.NameWeatherStationElRetiro,
                    Model = "El Retiro",
                    StationType = Utils.WeatherStationType.WeatherLink,
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService = Utils.MAX_DATETIME,
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                    WebAddress = "http://www.weatherlink.com/user/elretiro/index.php?view=summary&headers=1&type=1",
                };
                #endregion

                #region Zanja Honda - Salto
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionWeatherStationZanjaHonda
                             select pos).FirstOrDefault();
                var lZanjaHondaWS = new WeatherStation
                {
                    Name = Utils.NameWeatherStationZanjaHonda,
                    Model = "Noridel S.A. Zanja Honda",
                    StationType = Utils.WeatherStationType.WeatherLink,
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService = Utils.MAX_DATETIME,
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                    WebAddress = "http://www.weatherlink.com/user/noridelzh/index.php?view=summary&headers=1&type=1",
                };
                #endregion

                #region Estacion vieja
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionWeatherStationEstacionVieja
                             select pos).FirstOrDefault();

                var lEstacionVieja = new WeatherStation
                {
                    Name = Utils.NameWeatherStationEstacionVieja,
                    Model = "Estación vieja",
                    StationType = Utils.WeatherStationType.WeatherLink,
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService = Utils.MAX_DATETIME,
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                    //2016-10-27 not used, does not have good data
                    //WebAddress = "http://www.weatherlink.com/user/eavieja/index.php?view=summary&headers=1&type=1",
                };
                #endregion

                #region San Fernando
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionWeatherStationSanFernando
                             select pos).FirstOrDefault();

                var lSanFernando = new WeatherStation
                {
                    Name = Utils.NameWeatherStationSanFernando,
                    Model = "San Fernando",
                    StationType = Utils.WeatherStationType.WeatherLink,
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService = Utils.MAX_DATETIME,
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                    WebAddress = "http://www.weatherlink.com/user/sanfernando/index.php?view=summary&headers=1&type=1",
                };

                #endregion

                #region Los Olivos
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionWeatherStationLosOlivos
                             select pos).FirstOrDefault();

                var lLosOlivos = new WeatherStation
                {
                    Name = Utils.NameWeatherStationLosOlivos,
                    Model = "Los Olivos",
                    StationType = Utils.WeatherStationType.WeatherLink,
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService = Utils.MAX_DATETIME,
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                    WebAddress = "http://www.weatherlink.com/user/losolivos/index.php?view=summary&headers=1&type=1",
                };
                #endregion

                #region Vivero San Francisco
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionWeatherStationViveroSanFrancisco
                             select pos).FirstOrDefault();

                var lSanFrancisco = new WeatherStation
                {
                    Name = Utils.NameWeatherStationViveroSanFrancisco,
                    Model = "Vivero San Francisco",
                    StationType = Utils.WeatherStationType.WeatherLink,
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService = Utils.MAX_DATETIME,
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                    WebAddress = "http://www.weatherlink.com/user/sanfrancisco/index.php?view=summary&headers=1&type=1",
                };
                #endregion

                //context.WeatherStations.Add(lBase);
                context.WeatherStations.Add(lLaTribuWS);
                context.WeatherStations.Add(lElCureWS);
                context.WeatherStations.Add(lJCServiciosWS);
                context.WeatherStations.Add(lMariaElenaWS);
                context.WeatherStations.Add(lElRetiroWS);
                context.WeatherStations.Add(lZanjaHondaWS);
                context.WeatherStations.Add(lEstacionVieja);
                context.WeatherStations.Add(lSanFernando);
                context.WeatherStations.Add(lLosOlivos);
                context.WeatherStations.Add(lSanFrancisco);
                context.SaveChanges();
            };
        }

        public static void InsertTemperatureData()
        {
            Region lRegion = null;

            using (var context = new IrrigationAdvisorContext())
            {

                #region Base
                var lBase = new TemperatureData
                {
                    Name = "noname",
                    Date = Utils.MIN_DATETIME,
                    RegionId = 0,
                    Min = 0,
                    Max = 0,
                    Average = 0,
                    ETC = 0,
                    Rain = 0,
                };
                #endregion

                #region South
                lRegion = (from region in context.Regions
                           where region.Name == Utils.NameRegionSouth
                           select region).FirstOrDefault();
                //DataEntryDataTemperatures.DataTemperatures_South_2014(context, lRegion);
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {
                    DataEntryDataTemperatures.DataTemperatures_South_2015(context, lRegion);
                }

                DataEntryDataTemperatures.DataTemperatures_South_2016(context, lRegion);

                DataEntryDataTemperatures.DataTemperatures_South_2017(context, lRegion);

                #endregion

                #region North
                lRegion = (from region in context.Regions
                           where region.Name == Utils.NameRegionNorth
                           select region).FirstOrDefault();
                //DataEntryDataTemperatures.DataTemperatures_North_2014(context, lRegion);
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {
                    DataEntryDataTemperatures.DataTemperatures_North_2015(context, lRegion);
                }

                DataEntryDataTemperatures.DataTemperatures_North_2016(context, lRegion);

                DataEntryDataTemperatures.DataTemperatures_North_2017(context, lRegion);

                #endregion

                //context.TemperatureDatas.Add(lBase);
                context.SaveChanges();
            }
        }

        public static void AddTemperatureDataToRegion()
        {
            Region lRegion = null;
            List<TemperatureData> lTemperatureDataList = null;

            using (var context = new IrrigationAdvisorContext())
            {
                #region South
                lRegion = (from region in context.Regions
                           where region.Name == Utils.NameRegionSouth
                           select region).FirstOrDefault();

                lTemperatureDataList = (from temperaturedata in context.TemperatureDatas
                                        where temperaturedata.Name.StartsWith(Utils.NameRegionSouth)
                                        select temperaturedata)
                                     .ToList<TemperatureData>();

                lRegion.TemperatureDataList = lTemperatureDataList;
                context.SaveChanges();
                #endregion

                #region North
                lRegion = (from region in context.Regions
                           where region.Name == Utils.NameRegionNorth
                           select region).FirstOrDefault();

                lTemperatureDataList = (from temperaturedata in context.TemperatureDatas
                                        where temperaturedata.Name.StartsWith(Utils.NameRegionNorth)
                                        select temperaturedata)
                                     .ToList<TemperatureData>();


                lRegion.TemperatureDataList = lTemperatureDataList;
                context.SaveChanges();
                #endregion
            }
        }

        public static void WetherStationsAddInformationOfWeather()
        {

#if false
            #region LasBrujas 2007
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntry.WeatherDataLasBrujas_2007(context);
                context.SaveChanges();
            }
            #endregion

            #region LasBrujas 2008
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntry.WeatherDataLasBrujas_2008(context);
                context.SaveChanges();
            }
            #endregion

            #region LasBrujas 2009
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntry.WeatherDataLasBrujas_2009(context);
                context.SaveChanges();
            }
            #endregion

            #region LasBrujas 2010
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntry.WeatherDataLasBrujas_2010(context);
                context.SaveChanges();
            }
            #endregion

            #region LasBrujas 2011
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntry.WeatherDataLasBrujas_2011(context);
                context.SaveChanges();
            }
            #endregion

            #region LasBrujas 2012
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntry.WeatherDataLasBrujas_2012(context);
                context.SaveChanges();
            }
            #endregion

            #region LasBrujas 2013
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntry.WeatherDataLasBrujas_2013(context);
                context.SaveChanges();
            }
            #endregion

            #region LasBrujas 2014
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntry.WeatherDataLasBrujas_2014(context);
                context.SaveChanges();
            }
            #endregion
#endif

            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                #region LasBrujas 2015
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntryWeatherData.WeatherDataLasBrujas_2015(context);
                    context.SaveChanges();
                }
                #endregion
                #region SaltoGrande 2015
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntryWeatherData.WeatherDataSaltoGrande_2015(context);
                    context.SaveChanges();
                }
                #endregion
                #region LaEstuanzuela 2015
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntryWeatherData.WeatherDataLaEstanzuela_2015(context);
                    context.SaveChanges();
                }
                #endregion
            }

            #region LasBrujas 2016-2017
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntryWeatherData.WeatherDataLasBrujas_2016(context);
                DataEntryWeatherData.WeatherDataLasBrujas_2017(context);
                DataEntryWeatherData.WeatherDataLasBrujas_Prediction(context);
                context.SaveChanges();
            }
            #endregion

            #region LaEstuanzuela 2016-2017
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntryWeatherData.WeatherDataLaEstanzuela_2016(context);
                DataEntryWeatherData.WeatherDataLaEstanzuela_2017(context);
                DataEntryWeatherData.WeatherDataLaEstanzuela_Prediction(context);
                context.SaveChanges();
            }
            #endregion

            #region SaltoGrande 2016-2017
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntryWeatherData.WeatherDataSaltoGrande_2016(context);
                DataEntryWeatherData.WeatherDataSaltoGrande_2017(context);
                DataEntryWeatherData.WeatherDataSaltoGrande_Prediction(context);
                context.SaveChanges();
            }
            #endregion

        }

        #endif
        #endregion

    }
}
