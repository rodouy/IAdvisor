﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.Tests.Models.Agriculture
{
    [TestClass]
    public class HorizonTest
    {
        [TestMethod]
        public void horizonTest()
        {
            double sand = 17.3;
            double limo = 53.9;
            double clay =28.8;
            double organicMatter = 4.4;
            Horizon lHorizon = new Horizon();
            lHorizon.Sand = sand;
            lHorizon.Limo = limo;
            lHorizon.Clay = clay;
            lHorizon.OrganicMatter = organicMatter;
            lHorizon.HorizonLayer = "A";
            lHorizon.Order = 0;
            lHorizon.HorizonLayerDepth = 5.3;

            double pmp = lHorizon.GetPermanentWiltingPoint();
            double cc = lHorizon.GetFieldCapacity();
            double ad = lHorizon.GetAvailableWaterCapacity();

            Assert.AreEqual(pmp, 16.002069999999989);
            Assert.AreEqual(cc, 34.1726);
            Assert.AreEqual(ad, 18.170530000000014);


        }
    }
}
