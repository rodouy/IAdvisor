using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Weather;

namespace IrrigationAdvisor.Tests.Models.Weather
{
    [TestClass]
    public class SeasonTest
    {
        [TestMethod]
        public void seasonTest()
        {
            DateTime lDateToTest;
            Utils.WeatherSeason lSpring = Utils.WeatherSeason.Spring;
            Utils.WeatherSeason lSummer = Utils.WeatherSeason.Summer;
            Utils.WeatherSeason lFall = Utils.WeatherSeason.Fall;
            Utils.WeatherSeason lWinter = Utils.WeatherSeason.Winter;

            Season lSeason = new Season();

            lDateToTest = new DateTime(DateTime.Now.Year, 9, 21, 2, 1, 1);
            Assert.IsTrue(lSpring == lSeason.DefaultWeatherSeasonBy(lDateToTest));
            lDateToTest = new DateTime(DateTime.Now.Year, 12, 20, 2, 1, 1);
            Assert.IsTrue(lSpring == lSeason.DefaultWeatherSeasonBy(lDateToTest));

            lDateToTest = new DateTime(DateTime.Now.Year, 12, 21, 2, 1, 1);
            Assert.IsTrue(lSummer == lSeason.DefaultWeatherSeasonBy(lDateToTest));
            lDateToTest = new DateTime(DateTime.Now.Year, 3, 20, 2, 1, 1);
            Assert.IsTrue(lSummer == lSeason.DefaultWeatherSeasonBy(lDateToTest));

            lDateToTest = new DateTime(DateTime.Now.Year, 3, 21, 2, 1, 1);
            Assert.IsTrue(lFall == lSeason.DefaultWeatherSeasonBy(lDateToTest));
            lDateToTest = new DateTime(DateTime.Now.Year, 6, 20, 2, 1, 1);
            Assert.IsTrue(lFall == lSeason.DefaultWeatherSeasonBy(lDateToTest));


            lDateToTest = new DateTime(DateTime.Now.Year, 6, 21, 2, 1, 1);
            Assert.IsTrue(lWinter == lSeason.DefaultWeatherSeasonBy(lDateToTest));
            lDateToTest = new DateTime(DateTime.Now.Year, 9, 20, 2, 1, 1);
            Assert.IsTrue(lWinter == lSeason.DefaultWeatherSeasonBy(lDateToTest));


        }
    }
}
