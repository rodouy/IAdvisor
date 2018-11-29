using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Utilities;

using IrrigationAdvisorConsole.Data;

using IrrigationAdvisor.DBContext;
using NLog;

namespace IrrigationAdvisorConsole.Insert._06_Agriculture
{
    public static class SoilInsert
    {
        
        #region Agriculture
#if true

        public static void InsertHorizons()
        {
            Soil lSoil = new Soil();
            #region Base
            var lBase = new Horizon
            {
                Name = Utils.NameBase,
                Order = 0,
                HorizonLayer = "",
                HorizonLayerDepth = 0,
                Sand = 0,
                Limo = 0,
                Clay = 0,
                OrganicMatter = 0,
                NitrogenAnalysis = 0,
                BulkDensitySoil = 0,
                SoilId = 0,
            };
            #endregion

            #region Horizons Demo1 - La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 11
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo11
                             select soil).FirstOrDefault();
                    var lDemo1Pivot_11_1 = new Horizon
                    {
                        Name = Utils.NamePivotDemo11 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo1Pivot_11_2 = new Horizon
                    {
                        Name = Utils.NamePivotDemo11 + " 2",
                        Order = 1,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 20,
                        Sand = 25,
                        Limo = 36,
                        Clay = 39,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo1Pivot_11_3 = new Horizon
                    {
                        Name = Utils.NamePivotDemo11 + " 3",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 19,
                        Limo = 35,
                        Clay = 46,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };

                    lSoil.HorizonList.Add(lDemo1Pivot_11_1);
                    lSoil.HorizonList.Add(lDemo1Pivot_11_2);
                    lSoil.HorizonList.Add(lDemo1Pivot_11_3);
                    #endregion
                    #region Pivot 12
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo12
                             select soil).FirstOrDefault();
                    var lDemo1Pivot_12_1 = new Horizon
                    {
                        Name = Utils.NamePivotDemo12 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo1Pivot_12_2 = new Horizon
                    {
                        Name = Utils.NamePivotDemo12 + " 2",
                        Order = 1,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 20,
                        Sand = 25,
                        Limo = 36,
                        Clay = 39,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo1Pivot_12_3 = new Horizon
                    {
                        Name = Utils.NamePivotDemo12 + " 3",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 19,
                        Limo = 35,
                        Clay = 46,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };

                    lSoil.HorizonList.Add(lDemo1Pivot_12_1);
                    lSoil.HorizonList.Add(lDemo1Pivot_12_2);
                    lSoil.HorizonList.Add(lDemo1Pivot_12_3);
                    #endregion
                    #region Pivot 13
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo13
                             select soil).FirstOrDefault();
                    var lDemo1Pivot_13_1 = new Horizon
                    {
                        Name = Utils.NamePivotDemo13 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo1Pivot_13_2 = new Horizon
                    {
                        Name = Utils.NamePivotDemo13 + " 2",
                        Order = 1,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 20,
                        Sand = 25,
                        Limo = 36,
                        Clay = 39,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo1Pivot_13_3 = new Horizon
                    {
                        Name = Utils.NamePivotDemo13 + " 3",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 19,
                        Limo = 35,
                        Clay = 46,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };

                    lSoil.HorizonList.Add(lDemo1Pivot_13_1);
                    lSoil.HorizonList.Add(lDemo1Pivot_13_2);
                    lSoil.HorizonList.Add(lDemo1Pivot_13_3);
                    #endregion
                    #region Pivot 15
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo15
                             select soil).FirstOrDefault();
                    var lDemo1Pivot_15_1 = new Horizon
                    {
                        Name = Utils.NamePivotDemo15 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo1Pivot_15_2 = new Horizon
                    {
                        Name = Utils.NamePivotDemo15 + " 2",
                        Order = 1,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 20,
                        Sand = 25,
                        Limo = 36,
                        Clay = 39,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo1Pivot_15_3 = new Horizon
                    {
                        Name = Utils.NamePivotDemo15 + " 3",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 19,
                        Limo = 35,
                        Clay = 46,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };

                    lSoil.HorizonList.Add(lDemo1Pivot_15_1);
                    lSoil.HorizonList.Add(lDemo1Pivot_15_2);
                    lSoil.HorizonList.Add(lDemo1Pivot_15_3);
                    #endregion
                
                    #region Horizons Demo1
                    context.Horizons.Add(lDemo1Pivot_11_1);
                    context.Horizons.Add(lDemo1Pivot_11_2);
                    context.Horizons.Add(lDemo1Pivot_11_3);
                    context.Horizons.Add(lDemo1Pivot_12_1);
                    context.Horizons.Add(lDemo1Pivot_12_2);
                    context.Horizons.Add(lDemo1Pivot_12_3);
                    context.Horizons.Add(lDemo1Pivot_13_1);
                    context.Horizons.Add(lDemo1Pivot_13_2);
                    context.Horizons.Add(lDemo1Pivot_13_3);
                    context.Horizons.Add(lDemo1Pivot_15_1);
                    context.Horizons.Add(lDemo1Pivot_15_2);
                    context.Horizons.Add(lDemo1Pivot_15_3);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion
            #region Horizons Demo2 - Santa Lucia
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 21
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo21
                             select soil).FirstOrDefault();
                    var lDemo2Pivot_21_1 = new Horizon
                    {
                        Name = Utils.NamePivotDemo21 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 14,
                        Sand = 19,
                        Limo = 53,
                        Clay = 28,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo2Pivot_21_2 = new Horizon
                    {
                        Name = Utils.NamePivotDemo21 + " 2",
                        Order = 1,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 23,
                        Sand = 18,
                        Limo = 45,
                        Clay = 37,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo2Pivot_21_3 = new Horizon
                    {
                        Name = Utils.NamePivotDemo21 + " 3",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 19,
                        Limo = 37,
                        Clay = 44,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    lSoil.HorizonList.Add(lDemo2Pivot_21_1);
                    lSoil.HorizonList.Add(lDemo2Pivot_21_2);
                    lSoil.HorizonList.Add(lDemo2Pivot_21_3);
                    #endregion
                    #region Pivot 22
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo22
                             select soil).FirstOrDefault();
                    var lDemo2Pivot_22_1 = new Horizon
                    {
                        Name = Utils.NamePivotDemo22 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo2Pivot_22_2 = new Horizon
                    {
                        Name = Utils.NamePivotDemo22 + " 2",
                        Order = 1,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 20,
                        Sand = 25,
                        Limo = 36,
                        Clay = 39,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo2Pivot_22_3 = new Horizon
                    {
                        Name = Utils.NamePivotDemo22 + " 3",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 19,
                        Limo = 35,
                        Clay = 46,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };

                    lSoil.HorizonList.Add(lDemo2Pivot_22_1);
                    lSoil.HorizonList.Add(lDemo2Pivot_22_2);
                    lSoil.HorizonList.Add(lDemo2Pivot_22_3);
                    #endregion
                    #region Pivot 23
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo23
                             select soil).FirstOrDefault();
                    var lDemo2Pivot_23_1 = new Horizon
                    {
                        Name = Utils.NamePivotDemo23 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 0,
                        Sand = 0,
                        Limo = 0,
                        Clay = 0,
                        OrganicMatter = 0,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 0,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo2Pivot_23_2 = new Horizon
                    {
                        Name = Utils.NamePivotDemo23 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    lSoil.HorizonList.Add(lDemo2Pivot_23_1);
                    lSoil.HorizonList.Add(lDemo2Pivot_23_2);
                    #endregion
                    #region Pivot 24
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo24
                             select soil).FirstOrDefault();
                    var lDemo2Pivot_24_1 = new Horizon
                    {
                        Name = Utils.NamePivotDemo24 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 15,
                        Sand = 33,
                        Limo = 40,
                        Clay = 26,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo2Pivot_24_2 = new Horizon
                    {
                        Name = Utils.NamePivotDemo24 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    lSoil.HorizonList.Add(lDemo2Pivot_24_1);
                    lSoil.HorizonList.Add(lDemo2Pivot_24_2);
                    #endregion
                    #region Pivot 25
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo25
                             select soil).FirstOrDefault();
                    var lDemo2Pivot_25_1 = new Horizon
                    {
                        Name = Utils.NamePivotDemo25 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 14,
                        Sand = 19,
                        Limo = 53,
                        Clay = 28,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo2Pivot_25_2 = new Horizon
                    {
                        Name = Utils.NamePivotDemo25 + " 2",
                        Order = 1,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 23,
                        Sand = 18,
                        Limo = 45,
                        Clay = 37,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo2Pivot_25_3 = new Horizon
                    {
                        Name = Utils.NamePivotDemo25 + " 3",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 19,
                        Limo = 37,
                        Clay = 44,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    lSoil.HorizonList.Add(lDemo2Pivot_25_1);
                    lSoil.HorizonList.Add(lDemo2Pivot_25_2);
                    lSoil.HorizonList.Add(lDemo2Pivot_25_3);
                    #endregion
                
                    #region Horizons Demo
                    context.Horizons.Add(lDemo2Pivot_21_1);
                    context.Horizons.Add(lDemo2Pivot_21_2);
                    context.Horizons.Add(lDemo2Pivot_21_3);
                    context.Horizons.Add(lDemo2Pivot_22_1);
                    context.Horizons.Add(lDemo2Pivot_22_2);
                    context.Horizons.Add(lDemo2Pivot_22_3);
                    context.Horizons.Add(lDemo2Pivot_23_1);
                    context.Horizons.Add(lDemo2Pivot_23_2);
                    context.Horizons.Add(lDemo2Pivot_24_1);
                    context.Horizons.Add(lDemo2Pivot_24_2);
                    context.Horizons.Add(lDemo2Pivot_25_1);
                    context.Horizons.Add(lDemo2Pivot_25_2);
                    context.Horizons.Add(lDemo2Pivot_25_3);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion
            #region Horizons Demo3 - La Palma
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 31
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo31
                             select soil).FirstOrDefault();
                    var lDemo3Pivot_31_1 = new Horizon
                    {
                        Name = Utils.NamePivotDemo31 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 13,
                        Sand = 43,
                        Limo = 31,
                        Clay = 26,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.30,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo3Pivot_31_2 = new Horizon
                    {
                        Name = Utils.NamePivotDemo31 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 60,
                        Sand = 31,
                        Limo = 25,
                        Clay = 44,
                        OrganicMatter = 1.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.39,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 32
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo32A
                             select soil).FirstOrDefault();
                    var lDemo3Pivot_32A_1 = new Horizon
                    {
                        Name = Utils.NamePivotDemo32A + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 13,
                        Sand = 43,
                        Limo = 31,
                        Clay = 26,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.30,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo3Pivot_32A_2 = new Horizon
                    {
                        Name = Utils.NamePivotDemo32A + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 60,
                        Sand = 31,
                        Limo = 25,
                        Clay = 44,
                        OrganicMatter = 1.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.39,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 33
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo33
                             select soil).FirstOrDefault();
                    var lDemo3Pivot_33_1 = new Horizon
                    {
                        Name = Utils.NamePivotDemo33 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 13,
                        Sand = 43,
                        Limo = 31,
                        Clay = 26,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.30,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo3Pivot_33_2 = new Horizon
                    {
                        Name = Utils.NamePivotDemo33 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 60,
                        Sand = 31,
                        Limo = 25,
                        Clay = 44,
                        OrganicMatter = 1.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.39,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 34
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo34
                             select soil).FirstOrDefault();
                    var lDemo3Pivot_34_1 = new Horizon
                    {
                        Name = Utils.NamePivotDemo34 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 13,
                        Sand = 43,
                        Limo = 31,
                        Clay = 26,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.30,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo3Pivot_34_2 = new Horizon
                    {
                        Name = Utils.NamePivotDemo34 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 60,
                        Sand = 31,
                        Limo = 25,
                        Clay = 44,
                        OrganicMatter = 1.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.39,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 35
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo35
                             select soil).FirstOrDefault();
                    var lDemo3Pivot_35_1 = new Horizon
                    {
                        Name = Utils.NamePivotDemo35 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 13,
                        Sand = 43,
                        Limo = 31,
                        Clay = 26,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.30,
                        SoilId = lSoil.SoilId,
                    };
                    var lDemo3Pivot_35_2 = new Horizon
                    {
                        Name = Utils.NamePivotDemo35 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 60,
                        Sand = 31,
                        Limo = 25,
                        Clay = 44,
                        OrganicMatter = 1.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.39,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                
                    #region Horizons Demo
                    context.Horizons.Add(lDemo3Pivot_31_1);
                    context.Horizons.Add(lDemo3Pivot_31_2);
                    context.Horizons.Add(lDemo3Pivot_32A_1);
                    context.Horizons.Add(lDemo3Pivot_32A_2);
                    context.Horizons.Add(lDemo3Pivot_33_1);
                    context.Horizons.Add(lDemo3Pivot_33_2);
                    context.Horizons.Add(lDemo3Pivot_34_1);
                    context.Horizons.Add(lDemo3Pivot_34_2);
                    context.Horizons.Add(lDemo3Pivot_35_1);
                    context.Horizons.Add(lDemo3Pivot_35_2);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion

            #region Horizons Santa Lucia
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotSantaLucia1
                             select soil).FirstOrDefault();
                    var lSantaLuciaPivot_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotSantaLucia1 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 14,
                        Sand = 19,
                        Limo = 53,
                        Clay = 28,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaLuciaPivot_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotSantaLucia1 + " 2",
                        Order = 1,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 23,
                        Sand = 18,
                        Limo = 45,
                        Clay = 37,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaLuciaPivot_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotSantaLucia1 + " 3",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 19,
                        Limo = 37,
                        Clay = 44,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotSantaLucia2
                             select soil).FirstOrDefault();
                    var lSantaLuciaPivot_2_1 = new Horizon
                    {
                        Name = Utils.NamePivotSantaLucia2 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaLuciaPivot_2_2 = new Horizon
                    {
                        Name = Utils.NamePivotSantaLucia2 + " 2",
                        Order = 1,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 20,
                        Sand = 25,
                        Limo = 36,
                        Clay = 39,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaLuciaPivot_2_3 = new Horizon
                    {
                        Name = Utils.NamePivotSantaLucia2 + " 3",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 19,
                        Limo = 35,
                        Clay = 46,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 3
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotSantaLucia3
                             select soil).FirstOrDefault();
                    var lSantaLuciaPivot_3_1 = new Horizon
                    {
                        Name = Utils.NamePivotSantaLucia3 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 0,
                        Sand = 0,
                        Limo = 0,
                        Clay = 0,
                        OrganicMatter = 0,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 0,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaLuciaPivot_3_2 = new Horizon
                    {
                        Name = Utils.NamePivotSantaLucia3 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 4
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotSantaLucia4
                             select soil).FirstOrDefault();
                    var lSantaLuciaPivot_4_1 = new Horizon
                    {
                        Name = Utils.NamePivotSantaLucia4 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 15,
                        Sand = 33,
                        Limo = 40,
                        Clay = 26,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaLuciaPivot_4_2 = new Horizon
                    {
                        Name = Utils.NamePivotSantaLucia4 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 5
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotSantaLucia5
                             select soil).FirstOrDefault();
                    var lSantaLuciaPivot_5_1 = new Horizon
                    {
                        Name = Utils.NamePivotSantaLucia5 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 14,
                        Sand = 19,
                        Limo = 53,
                        Clay = 28,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaLuciaPivot_5_2 = new Horizon
                    {
                        Name = Utils.NamePivotSantaLucia5 + " 2",
                        Order = 1,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 23,
                        Sand = 18,
                        Limo = 45,
                        Clay = 37,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaLuciaPivot_5_3 = new Horizon
                    {
                        Name = Utils.NamePivotSantaLucia5 + " 3",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 19,
                        Limo = 37,
                        Clay = 44,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Horizons Santa Lucia
                    context.Horizons.Add(lSantaLuciaPivot_1_1);
                    context.Horizons.Add(lSantaLuciaPivot_1_2);
                    context.Horizons.Add(lSantaLuciaPivot_1_3);
                    context.Horizons.Add(lSantaLuciaPivot_2_1);
                    context.Horizons.Add(lSantaLuciaPivot_2_2);
                    context.Horizons.Add(lSantaLuciaPivot_2_3);
                    context.Horizons.Add(lSantaLuciaPivot_3_1);
                    context.Horizons.Add(lSantaLuciaPivot_3_2);
                    context.Horizons.Add(lSantaLuciaPivot_4_1);
                    context.Horizons.Add(lSantaLuciaPivot_4_2);
                    context.Horizons.Add(lSantaLuciaPivot_5_1);
                    context.Horizons.Add(lSantaLuciaPivot_5_2);
                    context.Horizons.Add(lSantaLuciaPivot_5_3);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion

            #region Horizons DCA El Paraiso
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCAElParaiso1
                             select soil).FirstOrDefault();
                    var lDCAElParaisoPivot_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 15,
                        Sand = 24,
                        Limo = 45,
                        Clay = 31,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCAElParaisoPivot_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso1 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 46,
                        Clay = 34,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCAElParaisoPivot_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso1 + " 3",
                        Order = 3,
                        HorizonLayer = "BC",
                        HorizonLayerDepth = 20,
                        Sand = 12,
                        Limo = 48,
                        Clay = 40,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCAElParaiso2
                             select soil).FirstOrDefault();
                    var lDCAElParaisoPivot_2_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso2 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 15,
                        Sand = 24,
                        Limo = 45,
                        Clay = 31,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCAElParaisoPivot_2_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso2 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 46,
                        Clay = 34,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCAElParaisoPivot_2_3 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso2 + " 3",
                        Order = 3,
                        HorizonLayer = "BC",
                        HorizonLayerDepth = 20,
                        Sand = 12,
                        Limo = 48,
                        Clay = 40,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 3
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCAElParaiso3
                             select soil).FirstOrDefault();
                    var lDCAElParaisoPivot_3_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso3 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 15,
                        Sand = 24,
                        Limo = 45,
                        Clay = 31,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCAElParaisoPivot_3_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso3 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 46,
                        Clay = 34,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCAElParaisoPivot_3_3 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso3 + " 3",
                        Order = 3,
                        HorizonLayer = "BC",
                        HorizonLayerDepth = 20,
                        Sand = 12,
                        Limo = 48,
                        Clay = 40,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 4
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCAElParaiso4
                             select soil).FirstOrDefault();
                    var lDCAElParaisoPivot_4_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso4 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 15,
                        Sand = 24,
                        Limo = 45,
                        Clay = 31,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCAElParaisoPivot_4_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso4 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 46,
                        Clay = 34,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCAElParaisoPivot_4_3 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso4 + " 3",
                        Order = 3,
                        HorizonLayer = "BC",
                        HorizonLayerDepth = 20,
                        Sand = 12,
                        Limo = 48,
                        Clay = 40,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 5
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCAElParaiso5
                             select soil).FirstOrDefault();
                    var lDCAElParaisoPivot_5_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso5 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 10,
                        Sand = 25,
                        Limo = 45,
                        Clay = 30,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCAElParaisoPivot_5_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso5 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 22,
                        Limo = 46,
                        Clay = 32,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 6
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCAElParaiso6
                             select soil).FirstOrDefault();
                    var lDCAElParaisoPivot_6_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso6 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 10,
                        Sand = 25,
                        Limo = 45,
                        Clay = 30,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCAElParaisoPivot_6_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso6 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 22,
                        Limo = 46,
                        Clay = 32,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 7
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCAElParaiso7
                             select soil).FirstOrDefault();
                    var lDCAElParaisoPivot_7_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso7 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 10,
                        Sand = 25,
                        Limo = 45,
                        Clay = 30,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCAElParaisoPivot_7_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCAElParaiso7 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 22,
                        Limo = 46,
                        Clay = 32,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Horizons DCA El Paraiso
                    context.Horizons.Add(lDCAElParaisoPivot_1_1);
                    context.Horizons.Add(lDCAElParaisoPivot_1_2);
                    context.Horizons.Add(lDCAElParaisoPivot_1_3);
                    context.Horizons.Add(lDCAElParaisoPivot_2_1);
                    context.Horizons.Add(lDCAElParaisoPivot_2_2);
                    context.Horizons.Add(lDCAElParaisoPivot_2_3);
                    context.Horizons.Add(lDCAElParaisoPivot_3_1);
                    context.Horizons.Add(lDCAElParaisoPivot_3_2);
                    context.Horizons.Add(lDCAElParaisoPivot_3_3);
                    context.Horizons.Add(lDCAElParaisoPivot_4_1);
                    context.Horizons.Add(lDCAElParaisoPivot_4_2);
                    context.Horizons.Add(lDCAElParaisoPivot_4_3);
                    context.Horizons.Add(lDCAElParaisoPivot_5_1);
                    context.Horizons.Add(lDCAElParaisoPivot_5_2);
                    context.Horizons.Add(lDCAElParaisoPivot_6_1);
                    context.Horizons.Add(lDCAElParaisoPivot_6_2);
                    context.Horizons.Add(lDCAElParaisoPivot_7_1);
                    context.Horizons.Add(lDCAElParaisoPivot_7_2);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion
            #region Horizons DCA San Jose
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCASanJose1
                             select soil).FirstOrDefault();
                    var lDCASanJosePivot_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCASanJose1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 30,
                        Sand = 21,
                        Limo = 43,
                        Clay = 33,
                        OrganicMatter = 4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCASanJosePivot_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCASanJose1 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 23,
                        Sand = 18,
                        Limo = 46,
                        Clay = 36,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCASanJosePivot_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotDCASanJose1 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 28,
                        Sand = 10,
                        Limo = 48,
                        Clay = 42,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCASanJose2
                             select soil).FirstOrDefault();
                    var lDCASanJosePivot_2_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCASanJose2 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 30,
                        Sand = 21,
                        Limo = 43,
                        Clay = 33,
                        OrganicMatter = 4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCASanJosePivot_2_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCASanJose2 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 23,
                        Sand = 18,
                        Limo = 46,
                        Clay = 36,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCASanJosePivot_2_3 = new Horizon
                    {
                        Name = Utils.NamePivotDCASanJose2 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 28,
                        Sand = 10,
                        Limo = 48,
                        Clay = 42,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 3
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCASanJose3
                             select soil).FirstOrDefault();
                    var lDCASanJosePivot_3_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCASanJose3 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 30,
                        Sand = 21,
                        Limo = 43,
                        Clay = 33,
                        OrganicMatter = 4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCASanJosePivot_3_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCASanJose3 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 23,
                        Sand = 18,
                        Limo = 46,
                        Clay = 36,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCASanJosePivot_3_3 = new Horizon
                    {
                        Name = Utils.NamePivotDCASanJose3 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 28,
                        Sand = 10,
                        Limo = 48,
                        Clay = 42,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 4
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCASanJose4
                             select soil).FirstOrDefault();
                    var lDCASanJosePivot_4_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCASanJose4 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 30,
                        Sand = 21,
                        Limo = 43,
                        Clay = 33,
                        OrganicMatter = 4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCASanJosePivot_4_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCASanJose4 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 23,
                        Sand = 18,
                        Limo = 46,
                        Clay = 36,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCASanJosePivot_4_3 = new Horizon
                    {
                        Name = Utils.NamePivotDCASanJose4 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 28,
                        Sand = 10,
                        Limo = 48,
                        Clay = 42,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Horizons DCA San Jose
                    context.Horizons.Add(lDCASanJosePivot_1_1);
                    context.Horizons.Add(lDCASanJosePivot_1_2);
                    context.Horizons.Add(lDCASanJosePivot_1_3);
                    context.Horizons.Add(lDCASanJosePivot_2_1);
                    context.Horizons.Add(lDCASanJosePivot_2_2);
                    context.Horizons.Add(lDCASanJosePivot_2_3);
                    context.Horizons.Add(lDCASanJosePivot_3_1);
                    context.Horizons.Add(lDCASanJosePivot_3_2);
                    context.Horizons.Add(lDCASanJosePivot_3_3);
                    context.Horizons.Add(lDCASanJosePivot_4_1);
                    context.Horizons.Add(lDCASanJosePivot_4_2);
                    context.Horizons.Add(lDCASanJosePivot_4_3);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion
            #region Horizons DCA La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCALaPerdiz1
                             select soil).FirstOrDefault();
                    var lDCALaPerdizPivot_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz1 + " 2",
                        Order = 2,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 20,
                        Sand = 25,
                        Limo = 36,
                        Clay = 39,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz1 + " 3",
                        Order = 3,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 19,
                        Limo = 35,
                        Clay = 46,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCALaPerdiz2
                             select soil).FirstOrDefault();
                    var lDCALaPerdizPivot_2_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz2 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_2_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz2 + " 2",
                        Order = 2,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 20,
                        Sand = 25,
                        Limo = 36,
                        Clay = 39,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_2_3 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz2 + " 3",
                        Order = 3,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 19,
                        Limo = 35,
                        Clay = 46,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 3
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCALaPerdiz3
                             select soil).FirstOrDefault();
                    var lDCALaPerdizPivot_3_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz3 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_3_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz3 + " 2",
                        Order = 2,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 20,
                        Sand = 25,
                        Limo = 36,
                        Clay = 39,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_3_3 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz3 + " 3",
                        Order = 3,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 19,
                        Limo = 35,
                        Clay = 46,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 4
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCALaPerdiz4
                             select soil).FirstOrDefault();
                    var lDCALaPerdizPivot_4_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz4 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_4_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz4 + " 2",
                        Order = 2,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 20,
                        Sand = 25,
                        Limo = 36,
                        Clay = 39,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_4_3 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz4 + " 3",
                        Order = 3,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 19,
                        Limo = 35,
                        Clay = 46,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 5
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCALaPerdiz5
                             select soil).FirstOrDefault();
                    var lDCALaPerdizPivot_5_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz5 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_5_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz5 + " 2",
                        Order = 2,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 20,
                        Sand = 25,
                        Limo = 36,
                        Clay = 39,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_5_3 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz5 + " 3",
                        Order = 3,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 19,
                        Limo = 35,
                        Clay = 46,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 6
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCALaPerdiz6
                             select soil).FirstOrDefault();
                    var lDCALaPerdizPivot_6_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz6 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_6_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz6 + " 2",
                        Order = 2,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 20,
                        Sand = 25,
                        Limo = 36,
                        Clay = 39,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_6_3 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz6 + " 3",
                        Order = 3,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 19,
                        Limo = 35,
                        Clay = 46,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 7
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCALaPerdiz7
                             select soil).FirstOrDefault();
                    var lDCALaPerdizPivot_7_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz7 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 12,
                        Sand = 30,
                        Limo = 36,
                        Clay = 34,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_7_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz7 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 28,
                        Sand = 25,
                        Limo = 38,
                        Clay = 37,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 8
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCALaPerdiz8
                             select soil).FirstOrDefault();
                    var lDCALaPerdizPivot_8_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz8 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 12,
                        Sand = 30,
                        Limo = 36,
                        Clay = 34,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_8_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz8 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 28,
                        Sand = 25,
                        Limo = 38,
                        Clay = 37,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 9
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCALaPerdiz9
                             select soil).FirstOrDefault();
                    var lDCALaPerdizPivot_9_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz9 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 12,
                        Sand = 30,
                        Limo = 36,
                        Clay = 34,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_9_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz9 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 28,
                        Sand = 25,
                        Limo = 38,
                        Clay = 37,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 10a
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCALaPerdiz10a
                             select soil).FirstOrDefault();
                    var lDCALaPerdizPivot_10a_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz10a + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_10a_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz10a + " 2",
                        Order = 2,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 20,
                        Sand = 25,
                        Limo = 36,
                        Clay = 39,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_10a_3 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz10a + " 3",
                        Order = 3,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 19,
                        Limo = 35,
                        Clay = 46,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 10b
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCALaPerdiz10b
                             select soil).FirstOrDefault();
                    var lDCALaPerdizPivot_10b_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz10b + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 12,
                        Sand = 30,
                        Limo = 36,
                        Clay = 34,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_10b_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz10b + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 28,
                        Sand = 25,
                        Limo = 38,
                        Clay = 37,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 11
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCALaPerdiz11
                             select soil).FirstOrDefault();
                    var lDCALaPerdizPivot_11_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz11 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 12,
                        Sand = 30,
                        Limo = 36,
                        Clay = 34,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_11_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz11 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 28,
                        Sand = 25,
                        Limo = 38,
                        Clay = 37,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 12
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCALaPerdiz12
                             select soil).FirstOrDefault();
                    var lDCALaPerdizPivot_12_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz12 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 12,
                        Sand = 30,
                        Limo = 36,
                        Clay = 34,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_12_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz12 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 28,
                        Sand = 25,
                        Limo = 38,
                        Clay = 37,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 13
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCALaPerdiz13
                             select soil).FirstOrDefault();
                    var lDCALaPerdizPivot_13_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz13 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 12,
                        Sand = 30,
                        Limo = 36,
                        Clay = 34,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_13_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz13 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 28,
                        Sand = 25,
                        Limo = 38,
                        Clay = 37,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 14
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCALaPerdiz14
                             select soil).FirstOrDefault();
                    var lDCALaPerdizPivot_14_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz14 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 12,
                        Sand = 30,
                        Limo = 36,
                        Clay = 34,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_14_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz14 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 28,
                        Sand = 25,
                        Limo = 38,
                        Clay = 37,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 15
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDCALaPerdiz15
                             select soil).FirstOrDefault();
                    var lDCALaPerdizPivot_15_1 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz15 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_15_2 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz15 + " 2",
                        Order = 2,
                        HorizonLayer = "AB",
                        HorizonLayerDepth = 20,
                        Sand = 25,
                        Limo = 36,
                        Clay = 39,
                        OrganicMatter = 3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDCALaPerdizPivot_15_3 = new Horizon
                    {
                        Name = Utils.NamePivotDCALaPerdiz15 + " 3",
                        Order = 3,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 25,
                        Sand = 19,
                        Limo = 35,
                        Clay = 46,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Horizons DCA La Perdiz
                    context.Horizons.Add(lDCALaPerdizPivot_1_1);
                    context.Horizons.Add(lDCALaPerdizPivot_1_2);
                    context.Horizons.Add(lDCALaPerdizPivot_1_3);
                    context.Horizons.Add(lDCALaPerdizPivot_2_1);
                    context.Horizons.Add(lDCALaPerdizPivot_2_2);
                    context.Horizons.Add(lDCALaPerdizPivot_2_3);
                    context.Horizons.Add(lDCALaPerdizPivot_3_1);
                    context.Horizons.Add(lDCALaPerdizPivot_3_2);
                    context.Horizons.Add(lDCALaPerdizPivot_3_3);
                    context.Horizons.Add(lDCALaPerdizPivot_4_1);
                    context.Horizons.Add(lDCALaPerdizPivot_4_2);
                    context.Horizons.Add(lDCALaPerdizPivot_4_3);
                    context.Horizons.Add(lDCALaPerdizPivot_5_1);
                    context.Horizons.Add(lDCALaPerdizPivot_5_2);
                    context.Horizons.Add(lDCALaPerdizPivot_5_3);
                    context.Horizons.Add(lDCALaPerdizPivot_6_1);
                    context.Horizons.Add(lDCALaPerdizPivot_6_2);
                    context.Horizons.Add(lDCALaPerdizPivot_6_3);
                    context.Horizons.Add(lDCALaPerdizPivot_7_1);
                    context.Horizons.Add(lDCALaPerdizPivot_7_2);
                    context.Horizons.Add(lDCALaPerdizPivot_8_1);
                    context.Horizons.Add(lDCALaPerdizPivot_8_2);
                    context.Horizons.Add(lDCALaPerdizPivot_9_1);
                    context.Horizons.Add(lDCALaPerdizPivot_9_2);
                    context.Horizons.Add(lDCALaPerdizPivot_10a_1);
                    context.Horizons.Add(lDCALaPerdizPivot_10a_2);
                    context.Horizons.Add(lDCALaPerdizPivot_10a_3);
                    context.Horizons.Add(lDCALaPerdizPivot_10b_1);
                    context.Horizons.Add(lDCALaPerdizPivot_10b_2);
                    context.Horizons.Add(lDCALaPerdizPivot_11_1);
                    context.Horizons.Add(lDCALaPerdizPivot_11_2);
                    context.Horizons.Add(lDCALaPerdizPivot_12_1);
                    context.Horizons.Add(lDCALaPerdizPivot_12_2);
                    context.Horizons.Add(lDCALaPerdizPivot_13_1);
                    context.Horizons.Add(lDCALaPerdizPivot_13_2);
                    context.Horizons.Add(lDCALaPerdizPivot_14_1);
                    context.Horizons.Add(lDCALaPerdizPivot_14_2);
                    context.Horizons.Add(lDCALaPerdizPivot_15_1);
                    context.Horizons.Add(lDCALaPerdizPivot_15_2);
                    context.Horizons.Add(lDCALaPerdizPivot_15_3);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion

            #region Horizons Del Lago - San Pedro
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro1
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro1 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro1 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro2
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_2_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro2 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_2_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro2 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 3
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro3
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_3_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro3 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_3_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro3 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 4
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro4
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_4_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro4 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_4_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro4 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 5
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro5
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_5_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro5 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_5_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro5 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 6
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro6
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_6_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro6 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_6_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro6 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 7
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro7
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_7_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro7 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_7_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro7 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 8
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro8
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_8_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro8 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_8_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro8 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 9
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro9
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_9_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro9 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_9_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro9 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 10
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro10
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_10_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro10 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_10_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro10 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 11
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro11
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_11_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro11 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_11_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro11 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 12
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro12
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_12_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro12 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_12_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro12 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 13
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro13
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_13_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro13 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_13_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro13 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 14
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro14
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_14_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro14 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_14_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro14 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 15
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro15
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_15_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro15 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_15_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro15 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 16
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro16
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_16_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro16 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_16_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro16 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 17
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoSanPedro17
                             select soil).FirstOrDefault();
                    var lDelLagoSanPedroPivot_17_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro17 + " 1",
                        Order = 0,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 21,
                        Sand = 31,
                        Limo = 31,
                        Clay = 38,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoSanPedroPivot_17_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoSanPedro17 + " 2",
                        Order = 1,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 28,
                        Clay = 52,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion

                    #region Horizons Del Lago - San Pedro
                    context.Horizons.Add(lDelLagoSanPedroPivot_1_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_1_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_2_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_2_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_3_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_3_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_4_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_4_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_5_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_5_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_6_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_6_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_7_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_7_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_8_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_8_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_9_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_9_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_10_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_10_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_11_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_11_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_12_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_12_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_13_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_13_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_14_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_14_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_15_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_15_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_16_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_16_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_17_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_17_2);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion
            #region Horizons Del Lago - El Mirador
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {

                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador1
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador1 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador1 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador1 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_1_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador1 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador2
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_2_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador2 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_2_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador2 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_2_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador2 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_2_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador2 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 3
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador3
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_3_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador3 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_3_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador3 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_3_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador3 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_3_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador3 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 4
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador4
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_4_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador4 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_4_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador4 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_4_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador4 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_4_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador4 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 5
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador5
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_5_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador5 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_5_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador5 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_5_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador5 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_5_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador5 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 6
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador6
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_6_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador6 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_6_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador6 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_6_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador6 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_6_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador6 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 7
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador7
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_7_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador7 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_7_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador7 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_7_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador7 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_7_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador7 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 8
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador8
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_8_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador8 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_8_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador8 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_8_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador8 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_8_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador8 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 9
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador9
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_9_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador9 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_9_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador9 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_9_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador9 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_9_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador9 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 10
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador10
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_10_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador10 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_10_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador10 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_10_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador10 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_10_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador10 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 11
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador11
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_11_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador11 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_11_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador11 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_11_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador11 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_11_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador11 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 12
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador12
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_12_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador12 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_12_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador12 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_12_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador12 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_12_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador12 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 13
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador13
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_13_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador13 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_13_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador13 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_13_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador13 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_13_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador13 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 14
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador14
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_14_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador14 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_14_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador14 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_14_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador14 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_14_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador14 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 15
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador15
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_15_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador15 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_15_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador15 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_15_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador15 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_15_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador15 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot Chaja 1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMiradorChaja1
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivotChaja_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMiradorChaja1 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivotChaja_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMiradorChaja1 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivotChaja_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMiradorChaja1 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivotChaja_1_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMiradorChaja1 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot Chaja 2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMiradorChaja2
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivotChaja_2_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMiradorChaja2 + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivotChaja_2_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMiradorChaja2 + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivotChaja_2_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMiradorChaja2 + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivotChaja_2_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMiradorChaja2 + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Pivot 1b
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador1b
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_1b_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador1b + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_1b_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador1b + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_1b_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador1b + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_1b_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador1b + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2b
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador2b
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_2b_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador2b + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_2b_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador2b + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_2b_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador2b + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_2b_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador2b + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 3b
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador3b
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_3b_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador3b + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_3b_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador3b + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_3b_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador3b + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_3b_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador3b + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 4b
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotDelLagoElMirador4b
                             select soil).FirstOrDefault();
                    var lDelLagoElMiradorPivot_4b_1 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador4b + " A",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 26,
                        Sand = 22,
                        Limo = 44,
                        Clay = 34,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.16,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_4b_2 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador4b + " Bt",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 58,
                        Sand = 14,
                        Limo = 29,
                        Clay = 57,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_4b_3 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador4b + " BCk",
                        Order = 3,
                        HorizonLayer = "BCk",
                        HorizonLayerDepth = 80,
                        Sand = 13,
                        Limo = 28,
                        Clay = 59,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lDelLagoElMiradorPivot_4b_4 = new Horizon
                    {
                        Name = Utils.NamePivotDelLagoElMirador4b + " Ck",
                        Order = 4,
                        HorizonLayer = "Ck",
                        HorizonLayerDepth = 120,
                        Sand = 19,
                        Limo = 29,
                        Clay = 52,
                        OrganicMatter = 0.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion


                    #region Horizons Del Lago - El Mirador
                    context.Horizons.Add(lDelLagoElMiradorPivot_1_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_1_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_1_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_1_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_2_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_2_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_2_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_2_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_3_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_3_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_3_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_3_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_4_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_4_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_4_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_4_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_5_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_5_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_5_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_5_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_6_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_6_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_6_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_6_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_7_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_7_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_7_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_7_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_8_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_8_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_8_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_8_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_9_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_9_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_9_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_9_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_10_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_10_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_10_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_10_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_11_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_11_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_11_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_11_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_12_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_12_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_12_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_12_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_13_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_13_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_13_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_13_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_14_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_14_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_14_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_14_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_15_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_15_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_15_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_15_4);
                    context.Horizons.Add(lDelLagoElMiradorPivotChaja_1_1);
                    context.Horizons.Add(lDelLagoElMiradorPivotChaja_1_2);
                    context.Horizons.Add(lDelLagoElMiradorPivotChaja_1_3);
                    context.Horizons.Add(lDelLagoElMiradorPivotChaja_1_4);
                    context.Horizons.Add(lDelLagoElMiradorPivotChaja_2_1);
                    context.Horizons.Add(lDelLagoElMiradorPivotChaja_2_2);
                    context.Horizons.Add(lDelLagoElMiradorPivotChaja_2_3);
                    context.Horizons.Add(lDelLagoElMiradorPivotChaja_2_4);

                    context.Horizons.Add(lDelLagoElMiradorPivot_1b_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_1b_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_1b_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_1b_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_2b_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_2b_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_2b_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_2b_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_3b_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_3b_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_3b_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_3b_4);
                    context.Horizons.Add(lDelLagoElMiradorPivot_4b_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_4b_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_4b_3);
                    context.Horizons.Add(lDelLagoElMiradorPivot_4b_4);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion

            #region Horizons GMO - La Palma
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
            {

                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOLaPalma1
                             select soil).FirstOrDefault();
                    var lGMOLaPalmaPivot_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 36,
                        Limo = 11,
                        Clay = 53,
                        OrganicMatter = 4.3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma1 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 15,
                        Sand = 32,
                        Limo = 13,
                        Clay = 55,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.24,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma1 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 25,
                        Sand = 28,
                        Limo = 15,
                        Clay = 57,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.34,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_1_4 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma1 + " 4",
                        Order = 4,
                        HorizonLayer = "B3",
                        HorizonLayerDepth = 30,
                        Sand = 21,
                        Limo = 19,
                        Clay = 60,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.38,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOLaPalma2
                             select soil).FirstOrDefault();
                    var lGMOLaPalmaPivot_2_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma2 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 36,
                        Limo = 11,
                        Clay = 53,
                        OrganicMatter = 4.3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_2_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma2 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 15,
                        Sand = 32,
                        Limo = 13,
                        Clay = 55,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.24,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_2_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma2 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 25,
                        Sand = 28,
                        Limo = 15,
                        Clay = 57,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.34,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_2_4 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma2 + " 4",
                        Order = 4,
                        HorizonLayer = "B3",
                        HorizonLayerDepth = 30,
                        Sand = 21,
                        Limo = 19,
                        Clay = 60,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.38,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 3
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOLaPalma3
                             select soil).FirstOrDefault();
                    var lGMOLaPalmaPivot_3_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma3 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 25,
                        Sand = 42,
                        Limo = 33,
                        Clay = 25,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.15,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_3_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma3 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 20,
                        Sand = 35,
                        Limo = 35,
                        Clay = 30,
                        OrganicMatter = 2.0,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_3_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma3 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 30,
                        Sand = 29,
                        Limo = 37,
                        Clay = 34,
                        OrganicMatter = 1.3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 4
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOLaPalma4
                             select soil).FirstOrDefault();
                    var lGMOLaPalmaPivot_4_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma4 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 36,
                        Limo = 11,
                        Clay = 53,
                        OrganicMatter = 4.3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_4_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma4 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 15,
                        Sand = 32,
                        Limo = 13,
                        Clay = 55,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.24,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_4_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma4 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 25,
                        Sand = 28,
                        Limo = 15,
                        Clay = 57,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.34,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_4_4 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma4 + " 4",
                        Order = 4,
                        HorizonLayer = "B3",
                        HorizonLayerDepth = 30,
                        Sand = 21,
                        Limo = 19,
                        Clay = 60,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.38,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 5
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOLaPalma5
                             select soil).FirstOrDefault();
                    var lGMOLaPalmaPivot_5_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma5 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 25,
                        Sand = 23,
                        Limo = 45,
                        Clay = 32,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_5_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma5 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 20,
                        Sand = 17,
                        Limo = 48,
                        Clay = 35,
                        OrganicMatter = 3.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_5_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma5 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 30,
                        Sand = 10,
                        Limo = 52,
                        Clay = 38,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 1.1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOLaPalma1_1
                             select soil).FirstOrDefault();
                    var lGMOLaPalmaPivot_1_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma1_1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 36,
                        Limo = 11,
                        Clay = 53,
                        OrganicMatter = 4.3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_1_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma1_1 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 15,
                        Sand = 32,
                        Limo = 13,
                        Clay = 55,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.24,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_1_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma1_1 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 25,
                        Sand = 28,
                        Limo = 15,
                        Clay = 57,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.34,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_1_1_4 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma1_1 + " 4",
                        Order = 4,
                        HorizonLayer = "B3",
                        HorizonLayerDepth = 30,
                        Sand = 21,
                        Limo = 19,
                        Clay = 60,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.38,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2.1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOLaPalma2_1
                             select soil).FirstOrDefault();
                    var lGMOLaPalmaPivot_2_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma2_1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 36,
                        Limo = 11,
                        Clay = 53,
                        OrganicMatter = 4.3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_2_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma2_1 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 15,
                        Sand = 32,
                        Limo = 13,
                        Clay = 55,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.24,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_2_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma2_1 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 25,
                        Sand = 28,
                        Limo = 15,
                        Clay = 57,
                        OrganicMatter = 2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.34,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_2_1_4 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma2_1 + " 4",
                        Order = 4,
                        HorizonLayer = "B3",
                        HorizonLayerDepth = 30,
                        Sand = 21,
                        Limo = 19,
                        Clay = 60,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.38,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 3.1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOLaPalma3_1
                             select soil).FirstOrDefault();
                    var lGMOLaPalmaPivot_3_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma3_1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 25,
                        Sand = 42,
                        Limo = 33,
                        Clay = 25,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.15,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_3_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma3_1 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 20,
                        Sand = 35,
                        Limo = 35,
                        Clay = 30,
                        OrganicMatter = 2.0,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_3_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma3_1 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 30,
                        Sand = 29,
                        Limo = 37,
                        Clay = 34,
                        OrganicMatter = 1.3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 4.1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOLaPalma4_1
                             select soil).FirstOrDefault();
                    var lGMOLaPalmaPivot_4_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma4_1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 25,
                        Sand = 42,
                        Limo = 33,
                        Clay = 25,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.15,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_4_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma4_1 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 20,
                        Sand = 35,
                        Limo = 35,
                        Clay = 30,
                        OrganicMatter = 2.0,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOLaPalmaPivot_4_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOLaPalma4_1 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 30,
                        Sand = 29,
                        Limo = 37,
                        Clay = 34,
                        OrganicMatter = 1.3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Horizons La Palma
                    context.Horizons.Add(lGMOLaPalmaPivot_1_1);
                    context.Horizons.Add(lGMOLaPalmaPivot_1_2);
                    context.Horizons.Add(lGMOLaPalmaPivot_1_3);
                    context.Horizons.Add(lGMOLaPalmaPivot_1_4);
                    context.Horizons.Add(lGMOLaPalmaPivot_2_1);
                    context.Horizons.Add(lGMOLaPalmaPivot_2_2);
                    context.Horizons.Add(lGMOLaPalmaPivot_2_3);
                    context.Horizons.Add(lGMOLaPalmaPivot_2_4);
                    context.Horizons.Add(lGMOLaPalmaPivot_3_1);
                    context.Horizons.Add(lGMOLaPalmaPivot_3_2);
                    context.Horizons.Add(lGMOLaPalmaPivot_3_3);
                    context.Horizons.Add(lGMOLaPalmaPivot_4_1);
                    context.Horizons.Add(lGMOLaPalmaPivot_4_2);
                    context.Horizons.Add(lGMOLaPalmaPivot_4_3);
                    context.Horizons.Add(lGMOLaPalmaPivot_4_4);
                    context.Horizons.Add(lGMOLaPalmaPivot_5_1);
                    context.Horizons.Add(lGMOLaPalmaPivot_5_2);
                    context.Horizons.Add(lGMOLaPalmaPivot_5_3);
                    context.Horizons.Add(lGMOLaPalmaPivot_1_1_1);
                    context.Horizons.Add(lGMOLaPalmaPivot_1_1_2);
                    context.Horizons.Add(lGMOLaPalmaPivot_1_1_3);
                    context.Horizons.Add(lGMOLaPalmaPivot_1_1_4);
                    context.Horizons.Add(lGMOLaPalmaPivot_2_1_1);
                    context.Horizons.Add(lGMOLaPalmaPivot_2_1_2);
                    context.Horizons.Add(lGMOLaPalmaPivot_2_1_3);
                    context.Horizons.Add(lGMOLaPalmaPivot_2_1_4);
                    context.Horizons.Add(lGMOLaPalmaPivot_3_1_1);
                    context.Horizons.Add(lGMOLaPalmaPivot_3_1_2);
                    context.Horizons.Add(lGMOLaPalmaPivot_3_1_3);
                    context.Horizons.Add(lGMOLaPalmaPivot_4_1_1);
                    context.Horizons.Add(lGMOLaPalmaPivot_4_1_2);
                    context.Horizons.Add(lGMOLaPalmaPivot_4_1_3);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion
            #region Horizons GMO - El Tacuru
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
            {

                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1a
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru1a
                             select soil).FirstOrDefault();
                    var lGMOElTacuruPivot_1a_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru1a + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 19,
                        Sand = 13.1,
                        Limo = 46.3,
                        Clay = 40.6,
                        OrganicMatter = 3.99,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.11,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_1a_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru1a + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 51,
                        Sand = 7.4,
                        Limo = 27.4,
                        Clay = 65.2,
                        OrganicMatter = 1.81,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_1a_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru1a + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 78,
                        Sand = 7.1,
                        Limo = 28.4,
                        Clay = 64.5,
                        OrganicMatter = 1.01,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.42,
                        SoilId = lSoil.SoilId,
                    };

                    lSoil.HorizonList.Add(lGMOElTacuruPivot_1a_1);
                    lSoil.HorizonList.Add(lGMOElTacuruPivot_1a_2);
                    lSoil.HorizonList.Add(lGMOElTacuruPivot_1a_3);
                    #endregion
                    #region Pivot 1b
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru1b
                             select soil).FirstOrDefault();
                    var lGMOElTacuruPivot_1b_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru1b + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 19,
                        Sand = 13.1,
                        Limo = 46.3,
                        Clay = 40.6,
                        OrganicMatter = 3.99,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.11,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_1b_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru1b + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 51,
                        Sand = 7.4,
                        Limo = 27.4,
                        Clay = 65.2,
                        OrganicMatter = 1.81,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_1b_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru1b + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 78,
                        Sand = 7.1,
                        Limo = 28.4,
                        Clay = 64.5,
                        OrganicMatter = 1.01,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.42,
                        SoilId = lSoil.SoilId,
                    };

                    lSoil.HorizonList.Add(lGMOElTacuruPivot_1b_1);
                    lSoil.HorizonList.Add(lGMOElTacuruPivot_1b_2);
                    lSoil.HorizonList.Add(lGMOElTacuruPivot_1b_3);
                    #endregion
                    #region Pivot 2a
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru2a
                             select soil).FirstOrDefault();
                    var lGMOElTacuruPivot_2a_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru2a + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 19,
                        Sand = 13.1,
                        Limo = 46.3,
                        Clay = 40.6,
                        OrganicMatter = 3.99,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.11,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_2a_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru2a + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 51,
                        Sand = 7.4,
                        Limo = 27.4,
                        Clay = 65.2,
                        OrganicMatter = 1.81,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_2a_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru2a + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 78,
                        Sand = 7.1,
                        Limo = 28.4,
                        Clay = 64.5,
                        OrganicMatter = 1.01,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.42,
                        SoilId = lSoil.SoilId,
                    };

                    lSoil.HorizonList.Add(lGMOElTacuruPivot_2a_1);
                    lSoil.HorizonList.Add(lGMOElTacuruPivot_2a_2);
                    lSoil.HorizonList.Add(lGMOElTacuruPivot_2a_3);
                    #endregion
                    #region Pivot 2b
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru2b
                             select soil).FirstOrDefault();
                    var lGMOElTacuruPivot_2b_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru2b + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 19,
                        Sand = 13.1,
                        Limo = 46.3,
                        Clay = 40.6,
                        OrganicMatter = 3.99,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.11,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_2b_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru2b + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 51,
                        Sand = 7.4,
                        Limo = 27.4,
                        Clay = 65.2,
                        OrganicMatter = 1.81,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_2b_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru2b + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 78,
                        Sand = 7.1,
                        Limo = 28.4,
                        Clay = 64.5,
                        OrganicMatter = 1.01,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.42,
                        SoilId = lSoil.SoilId,
                    };

                    lSoil.HorizonList.Add(lGMOElTacuruPivot_2b_1);
                    lSoil.HorizonList.Add(lGMOElTacuruPivot_2b_2);
                    lSoil.HorizonList.Add(lGMOElTacuruPivot_2b_3);
                    #endregion
                    #region Pivot 3a
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru3a
                             select soil).FirstOrDefault();
                    var lGMOElTacuruPivot_3a_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru3a + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 19,
                        Sand = 13.1,
                        Limo = 46.3,
                        Clay = 40.6,
                        OrganicMatter = 3.99,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.11,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_3a_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru3a + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 51,
                        Sand = 7.4,
                        Limo = 27.4,
                        Clay = 65.2,
                        OrganicMatter = 1.81,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_3a_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru3a + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 78,
                        Sand = 7.1,
                        Limo = 28.4,
                        Clay = 64.5,
                        OrganicMatter = 1.01,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.42,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 3b
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru3b
                             select soil).FirstOrDefault();
                    var lGMOElTacuruPivot_3b_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru3b + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 19,
                        Sand = 13.1,
                        Limo = 46.3,
                        Clay = 40.6,
                        OrganicMatter = 3.99,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.11,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_3b_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru3b + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 51,
                        Sand = 7.4,
                        Limo = 27.4,
                        Clay = 65.2,
                        OrganicMatter = 1.81,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_3b_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru3b + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 78,
                        Sand = 7.1,
                        Limo = 28.4,
                        Clay = 64.5,
                        OrganicMatter = 1.01,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.42,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 4
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru4
                             select soil).FirstOrDefault();
                    var lGMOElTacuruPivot_4_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru4 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 19,
                        Sand = 13.1,
                        Limo = 46.3,
                        Clay = 40.6,
                        OrganicMatter = 3.99,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.11,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_4_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru4 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 51,
                        Sand = 7.4,
                        Limo = 27.4,
                        Clay = 65.2,
                        OrganicMatter = 1.81,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_4_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru4 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 78,
                        Sand = 7.1,
                        Limo = 28.4,
                        Clay = 64.5,
                        OrganicMatter = 1.01,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.42,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 5
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru5
                             select soil).FirstOrDefault();
                    var lGMOElTacuruPivot_5_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru5 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 19,
                        Sand = 13.1,
                        Limo = 46.3,
                        Clay = 40.6,
                        OrganicMatter = 3.99,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.11,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_5_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru5 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 51,
                        Sand = 7.4,
                        Limo = 27.4,
                        Clay = 65.2,
                        OrganicMatter = 1.81,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_5_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru5 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 78,
                        Sand = 7.1,
                        Limo = 28.4,
                        Clay = 64.5,
                        OrganicMatter = 1.01,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.42,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 6
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru6
                             select soil).FirstOrDefault();
                    var lGMOElTacuruPivot_6_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru6 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 19,
                        Sand = 13.1,
                        Limo = 46.3,
                        Clay = 40.6,
                        OrganicMatter = 3.99,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.11,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_6_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru6 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 51,
                        Sand = 7.4,
                        Limo = 27.4,
                        Clay = 65.2,
                        OrganicMatter = 1.81,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_6_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru6 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 78,
                        Sand = 7.1,
                        Limo = 28.4,
                        Clay = 64.5,
                        OrganicMatter = 1.01,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.42,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 7
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru7
                             select soil).FirstOrDefault();
                    var lGMOElTacuruPivot_7_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru7 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 19,
                        Sand = 13.1,
                        Limo = 46.3,
                        Clay = 40.6,
                        OrganicMatter = 3.99,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.11,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_7_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru7 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 51,
                        Sand = 7.4,
                        Limo = 27.4,
                        Clay = 65.2,
                        OrganicMatter = 1.81,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_7_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru7 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 78,
                        Sand = 7.1,
                        Limo = 28.4,
                        Clay = 64.5,
                        OrganicMatter = 1.01,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.42,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 8
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru8
                             select soil).FirstOrDefault();
                    var lGMOElTacuruPivot_8_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru8 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 19,
                        Sand = 13.1,
                        Limo = 46.3,
                        Clay = 40.6,
                        OrganicMatter = 3.99,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.11,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_8_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru8 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 51,
                        Sand = 7.4,
                        Limo = 27.4,
                        Clay = 65.2,
                        OrganicMatter = 1.81,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_8_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru8 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 78,
                        Sand = 7.1,
                        Limo = 28.4,
                        Clay = 64.5,
                        OrganicMatter = 1.01,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.42,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 9
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru9
                             select soil).FirstOrDefault();
                    var lGMOElTacuruPivot_9_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru9 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 19,
                        Sand = 13.1,
                        Limo = 46.3,
                        Clay = 40.6,
                        OrganicMatter = 3.99,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.11,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_9_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru9 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 51,
                        Sand = 7.4,
                        Limo = 27.4,
                        Clay = 65.2,
                        OrganicMatter = 1.81,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_9_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru9 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 78,
                        Sand = 7.1,
                        Limo = 28.4,
                        Clay = 64.5,
                        OrganicMatter = 1.01,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.42,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 10
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru10
                             select soil).FirstOrDefault();
                    var lGMOElTacuruPivot_10_1 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru10 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 19,
                        Sand = 13.1,
                        Limo = 46.3,
                        Clay = 40.6,
                        OrganicMatter = 3.99,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.11,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_10_2 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru10 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 51,
                        Sand = 7.4,
                        Limo = 27.4,
                        Clay = 65.2,
                        OrganicMatter = 1.81,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lGMOElTacuruPivot_10_3 = new Horizon
                    {
                        Name = Utils.NamePivotGMOElTacuru10 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 78,
                        Sand = 7.1,
                        Limo = 28.4,
                        Clay = 64.5,
                        OrganicMatter = 1.01,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.42,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion

                    #region Horizons El Tacuru
                    context.Horizons.Add(lGMOElTacuruPivot_1a_1);
                    context.Horizons.Add(lGMOElTacuruPivot_1a_2);
                    context.Horizons.Add(lGMOElTacuruPivot_1a_3);
                    context.Horizons.Add(lGMOElTacuruPivot_1b_1);
                    context.Horizons.Add(lGMOElTacuruPivot_1b_2);
                    context.Horizons.Add(lGMOElTacuruPivot_1b_3);
                    context.Horizons.Add(lGMOElTacuruPivot_2a_1);
                    context.Horizons.Add(lGMOElTacuruPivot_2a_2);
                    context.Horizons.Add(lGMOElTacuruPivot_2a_3);
                    context.Horizons.Add(lGMOElTacuruPivot_2b_1);
                    context.Horizons.Add(lGMOElTacuruPivot_2b_2);
                    context.Horizons.Add(lGMOElTacuruPivot_2b_3);
                    context.Horizons.Add(lGMOElTacuruPivot_3a_1);
                    context.Horizons.Add(lGMOElTacuruPivot_3a_2);
                    context.Horizons.Add(lGMOElTacuruPivot_3a_3);
                    context.Horizons.Add(lGMOElTacuruPivot_3b_1);
                    context.Horizons.Add(lGMOElTacuruPivot_3b_2);
                    context.Horizons.Add(lGMOElTacuruPivot_3b_3);
                    context.Horizons.Add(lGMOElTacuruPivot_4_1);
                    context.Horizons.Add(lGMOElTacuruPivot_4_2);
                    context.Horizons.Add(lGMOElTacuruPivot_4_3);
                    context.Horizons.Add(lGMOElTacuruPivot_5_1);
                    context.Horizons.Add(lGMOElTacuruPivot_5_2);
                    context.Horizons.Add(lGMOElTacuruPivot_5_3);
                    context.Horizons.Add(lGMOElTacuruPivot_6_1);
                    context.Horizons.Add(lGMOElTacuruPivot_6_2);
                    context.Horizons.Add(lGMOElTacuruPivot_6_3);
                    context.Horizons.Add(lGMOElTacuruPivot_7_1);
                    context.Horizons.Add(lGMOElTacuruPivot_7_2);
                    context.Horizons.Add(lGMOElTacuruPivot_7_3);
                    context.Horizons.Add(lGMOElTacuruPivot_8_1);
                    context.Horizons.Add(lGMOElTacuruPivot_8_2);
                    context.Horizons.Add(lGMOElTacuruPivot_8_3);
                    context.Horizons.Add(lGMOElTacuruPivot_9_1);
                    context.Horizons.Add(lGMOElTacuruPivot_9_2);
                    context.Horizons.Add(lGMOElTacuruPivot_9_3);
                    context.Horizons.Add(lGMOElTacuruPivot_10_1);
                    context.Horizons.Add(lGMOElTacuruPivot_10_2);
                    context.Horizons.Add(lGMOElTacuruPivot_10_3);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion

            #region Horizons Tres Marias
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
            {

                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotTresMarias1
                             select soil).FirstOrDefault();
                    var lTresMariasPivot_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotTresMarias1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 15,
                        Sand = 41.4,
                        Limo = 33.5,
                        Clay = 25.1,
                        OrganicMatter = 2.71,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lTresMariasPivot_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotTresMarias1 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 18,
                        Sand = 29.7,
                        Limo = 30.8,
                        Clay = 39.5,
                        OrganicMatter = 1.58,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lTresMariasPivot_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotTresMarias1 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 9,
                        Sand = 25,
                        Limo = 29,
                        Clay = 46,
                        OrganicMatter = 1.15,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotTresMarias2
                             select soil).FirstOrDefault();
                    var lTresMariasPivot_2_1 = new Horizon
                    {
                        Name = Utils.NamePivotTresMarias2 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 15,
                        Sand = 41.4,
                        Limo = 33.5,
                        Clay = 25.1,
                        OrganicMatter = 2.71,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lTresMariasPivot_2_2 = new Horizon
                    {
                        Name = Utils.NamePivotTresMarias2 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 18,
                        Sand = 29.7,
                        Limo = 30.8,
                        Clay = 39.5,
                        OrganicMatter = 1.58,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lTresMariasPivot_2_3 = new Horizon
                    {
                        Name = Utils.NamePivotTresMarias2 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 9,
                        Sand = 25,
                        Limo = 29,
                        Clay = 46,
                        OrganicMatter = 1.15,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 3
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotTresMarias3
                             select soil).FirstOrDefault();
                    var lTresMariasPivot_3_1 = new Horizon
                    {
                        Name = Utils.NamePivotTresMarias3 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 15,
                        Sand = 41.4,
                        Limo = 33.5,
                        Clay = 25.1,
                        OrganicMatter = 2.71,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lTresMariasPivot_3_2 = new Horizon
                    {
                        Name = Utils.NamePivotTresMarias3 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 18,
                        Sand = 29.7,
                        Limo = 30.8,
                        Clay = 39.5,
                        OrganicMatter = 1.58,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lTresMariasPivot_3_3 = new Horizon
                    {
                        Name = Utils.NamePivotTresMarias3 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 9,
                        Sand = 25,
                        Limo = 29,
                        Clay = 46,
                        OrganicMatter = 1.15,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 4
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotTresMarias4
                             select soil).FirstOrDefault();
                    var lTresMariasPivot_4_1 = new Horizon
                    {
                        Name = Utils.NamePivotTresMarias4 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 15,
                        Sand = 41.4,
                        Limo = 33.5,
                        Clay = 25.1,
                        OrganicMatter = 2.71,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lTresMariasPivot_4_2 = new Horizon
                    {
                        Name = Utils.NamePivotTresMarias4 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 18,
                        Sand = 29.7,
                        Limo = 30.8,
                        Clay = 39.5,
                        OrganicMatter = 1.58,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lTresMariasPivot_4_3 = new Horizon
                    {
                        Name = Utils.NamePivotTresMarias4 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 9,
                        Sand = 25,
                        Limo = 29,
                        Clay = 46,
                        OrganicMatter = 1.15,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Horizons Tres Marias
                    context.Horizons.Add(lTresMariasPivot_1_1);
                    context.Horizons.Add(lTresMariasPivot_1_2);
                    context.Horizons.Add(lTresMariasPivot_1_3);
                    context.Horizons.Add(lTresMariasPivot_2_1);
                    context.Horizons.Add(lTresMariasPivot_2_2);
                    context.Horizons.Add(lTresMariasPivot_2_3);
                    context.Horizons.Add(lTresMariasPivot_3_1);
                    context.Horizons.Add(lTresMariasPivot_3_2);
                    context.Horizons.Add(lTresMariasPivot_3_3);
                    context.Horizons.Add(lTresMariasPivot_4_1);
                    context.Horizons.Add(lTresMariasPivot_4_2);
                    context.Horizons.Add(lTresMariasPivot_4_3);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion
            #region Horizons La Rinconada
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
            {

                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotLaRinconada1
                             select soil).FirstOrDefault();
                    var lLaRinconadaPivot_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotLaRinconada1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 18,
                        Sand = 39,
                        Limo = 27,
                        Clay = 34,
                        OrganicMatter = 6.0,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lLaRinconadaPivot_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotLaRinconada1 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 14,
                        Sand = 38,
                        Limo = 24,
                        Clay = 38,
                        OrganicMatter = 4.6,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lLaRinconadaPivot_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotLaRinconada1 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 10,
                        Sand = 35,
                        Limo = 15,
                        Clay = 50,
                        OrganicMatter = 3.9,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotLaRinconada2
                             select soil).FirstOrDefault();
                    var lLaRinconadaPivot_2_1 = new Horizon
                    {
                        Name = Utils.NamePivotLaRinconada2 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 18,
                        Sand = 39,
                        Limo = 27,
                        Clay = 34,
                        OrganicMatter = 6.0,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lLaRinconadaPivot_2_2 = new Horizon
                    {
                        Name = Utils.NamePivotLaRinconada2 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 14,
                        Sand = 38,
                        Limo = 24,
                        Clay = 38,
                        OrganicMatter = 4.6,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lLaRinconadaPivot_2_3 = new Horizon
                    {
                        Name = Utils.NamePivotLaRinconada2 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 10,
                        Sand = 35,
                        Limo = 15,
                        Clay = 50,
                        OrganicMatter = 3.9,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 3.1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotLaRinconada3_1
                             select soil).FirstOrDefault();
                    var lLaRinconadaPivot_3_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotLaRinconada3_1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 18,
                        Sand = 39,
                        Limo = 27,
                        Clay = 34,
                        OrganicMatter = 6.0,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lLaRinconadaPivot_3_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotLaRinconada3_1 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 14,
                        Sand = 38,
                        Limo = 24,
                        Clay = 38,
                        OrganicMatter = 4.6,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lLaRinconadaPivot_3_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotLaRinconada3_1 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 10,
                        Sand = 35,
                        Limo = 15,
                        Clay = 50,
                        OrganicMatter = 3.9,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };

                    #endregion
                    #region Pivot 13.1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotLaRinconada13_1
                             select soil).FirstOrDefault();
                    var lLaRinconadaPivot_13_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotLaRinconada13_1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 18,
                        Sand = 63,
                        Limo = 20,
                        Clay = 17,
                        OrganicMatter = 4.0,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.15,
                        SoilId = lSoil.SoilId,
                    };
                    var lLaRinconadaPivot_13_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotLaRinconada13_1 + " 2",
                        Order = 2,
                        HorizonLayer = "BA",
                        HorizonLayerDepth = 20,
                        Sand = 55,
                        Limo = 12,
                        Clay = 33,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lLaRinconadaPivot_13_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotLaRinconada13_1 + " 3",
                        Order = 3,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 09,
                        Sand = 42,
                        Limo = 20,
                        Clay = 38,
                        OrganicMatter = 1.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    var lLaRinconadaPivot_13_1_4 = new Horizon
                    {
                        Name = Utils.NamePivotLaRinconada13_1 + " 4",
                        Order = 4,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 13,
                        Sand = 39,
                        Limo = 17,
                        Clay = 48,
                        OrganicMatter = 0.9,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.38,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Horizons La Rinconada
                    context.Horizons.Add(lLaRinconadaPivot_1_1);
                    context.Horizons.Add(lLaRinconadaPivot_1_2);
                    context.Horizons.Add(lLaRinconadaPivot_1_3);
                    context.Horizons.Add(lLaRinconadaPivot_2_1);
                    context.Horizons.Add(lLaRinconadaPivot_2_2);
                    context.Horizons.Add(lLaRinconadaPivot_2_3);
                    context.Horizons.Add(lLaRinconadaPivot_3_1_1);
                    context.Horizons.Add(lLaRinconadaPivot_3_1_2);
                    context.Horizons.Add(lLaRinconadaPivot_3_1_3);
                    context.Horizons.Add(lLaRinconadaPivot_13_1_1);
                    context.Horizons.Add(lLaRinconadaPivot_13_1_2);
                    context.Horizons.Add(lLaRinconadaPivot_13_1_3);
                    context.Horizons.Add(lLaRinconadaPivot_13_1_4);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion
            #region Horizons El Rincon
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElRincon)
            {

                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1a
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotElRincon1a
                             select soil).FirstOrDefault();
                    var lElRinconPivot_1a_1 = new Horizon
                    {
                        Name = Utils.NamePivotElRincon1a + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 16.67,
                        Limo = 72.19,
                        Clay = 11.14,
                        OrganicMatter = 3.99,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lElRinconPivot_1a_2 = new Horizon
                    {
                        Name = Utils.NamePivotElRincon1a + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 20,
                        Sand = 15.73,
                        Limo = 73.72,
                        Clay = 10.55,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lElRinconPivot_1a_3 = new Horizon
                    {
                        Name = Utils.NamePivotElRincon1a + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 20,
                        Sand = 15.08,
                        Limo = 68.22,
                        Clay = 16.7,
                        OrganicMatter = 1.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.34,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 1b
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotElRincon1b
                             select soil).FirstOrDefault();
                    var lElRinconPivot_1b_1 = new Horizon
                    {
                        Name = Utils.NamePivotElRincon1b + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 30.01,
                        Limo = 58.59,
                        Clay = 11.4,
                        OrganicMatter = 3.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.31,
                        SoilId = lSoil.SoilId,
                    };
                    var lElRinconPivot_1b_2 = new Horizon
                    {
                        Name = Utils.NamePivotElRincon1b + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 20,
                        Sand = 25.5,
                        Limo = 57.92,
                        Clay = 16.58,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.5,
                        SoilId = lSoil.SoilId,
                    };
                    var lElRinconPivot_1b_3 = new Horizon
                    {
                        Name = Utils.NamePivotElRincon1b + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 20,
                        Sand = 27.07,
                        Limo = 50.61,
                        Clay = 27.32,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2a
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotElRincon2a
                             select soil).FirstOrDefault();
                    var lElRinconPivot_2a_1 = new Horizon
                    {
                        Name = Utils.NamePivotElRincon2a + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 16.67,
                        Limo = 72.19,
                        Clay = 11.14,
                        OrganicMatter = 3.99,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lElRinconPivot_2a_2 = new Horizon
                    {
                        Name = Utils.NamePivotElRincon2a + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 20,
                        Sand = 15.73,
                        Limo = 73.72,
                        Clay = 10.55,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lElRinconPivot_2a_3 = new Horizon
                    {
                        Name = Utils.NamePivotElRincon2a + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 20,
                        Sand = 15.08,
                        Limo = 68.22,
                        Clay = 16.7,
                        OrganicMatter = 1.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.34,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2b
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotElRincon2b
                             select soil).FirstOrDefault();
                    var lElRinconPivot_2b_1 = new Horizon
                    {
                        Name = Utils.NamePivotElRincon2b + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 30.01,
                        Limo = 58.59,
                        Clay = 11.4,
                        OrganicMatter = 3.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.31,
                        SoilId = lSoil.SoilId,
                    };
                    var lElRinconPivot_2b_2 = new Horizon
                    {
                        Name = Utils.NamePivotElRincon2b + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 20,
                        Sand = 25.5,
                        Limo = 57.92,
                        Clay = 16.58,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.5,
                        SoilId = lSoil.SoilId,
                    };
                    var lElRinconPivot_2b_3 = new Horizon
                    {
                        Name = Utils.NamePivotElRincon2b + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 20,
                        Sand = 27.07,
                        Limo = 50.61,
                        Clay = 27.32,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Horizons El Rincon
                    context.Horizons.Add(lElRinconPivot_1a_1);
                    context.Horizons.Add(lElRinconPivot_1a_2);
                    context.Horizons.Add(lElRinconPivot_1a_3);
                    context.Horizons.Add(lElRinconPivot_1b_1);
                    context.Horizons.Add(lElRinconPivot_1b_2);
                    context.Horizons.Add(lElRinconPivot_1b_3);
                    context.Horizons.Add(lElRinconPivot_2a_1);
                    context.Horizons.Add(lElRinconPivot_2a_2);
                    context.Horizons.Add(lElRinconPivot_2a_3);
                    context.Horizons.Add(lElRinconPivot_2b_1);
                    context.Horizons.Add(lElRinconPivot_2b_2);
                    context.Horizons.Add(lElRinconPivot_2b_3);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion
            #region Horizons El Desafio
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElDesafio)
            {

                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotElDesafio1
                             select soil).FirstOrDefault();
                    var lElDesafioPivot_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotElDesafio1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 16.67,
                        Limo = 72.19,
                        Clay = 11.14,
                        OrganicMatter = 3.99,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.48,
                        SoilId = lSoil.SoilId,
                    };
                    var lElDesafioPivot_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotElDesafio1 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 20,
                        Sand = 15.73,
                        Limo = 73.72,
                        Clay = 10.55,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.51,
                        SoilId = lSoil.SoilId,
                    };
                    var lElDesafioPivot_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotElDesafio1 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 20,
                        Sand = 15.08,
                        Limo = 68.22,
                        Clay = 16.7,
                        OrganicMatter = 1.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.40,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotElDesafio2
                             select soil).FirstOrDefault();
                    var lElDesafioPivot_2_1 = new Horizon
                    {
                        Name = Utils.NamePivotElDesafio2 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 30.01,
                        Limo = 58.59,
                        Clay = 11.4,
                        OrganicMatter = 3.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.44,
                        SoilId = lSoil.SoilId,
                    };
                    var lElDesafioPivot_2_2 = new Horizon
                    {
                        Name = Utils.NamePivotElDesafio2 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 20,
                        Sand = 25.5,
                        Limo = 57.92,
                        Clay = 16.58,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.46,
                        SoilId = lSoil.SoilId,
                    };
                    var lElDesafioPivot_2_3 = new Horizon
                    {
                        Name = Utils.NamePivotElDesafio2 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 20,
                        Sand = 27.07,
                        Limo = 50.61,
                        Clay = 27.32,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.47,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Horizons El Desafio
                    context.Horizons.Add(lElDesafioPivot_1_1);
                    context.Horizons.Add(lElDesafioPivot_1_2);
                    context.Horizons.Add(lElDesafioPivot_1_3);
                    context.Horizons.Add(lElDesafioPivot_2_1);
                    context.Horizons.Add(lElDesafioPivot_2_2);
                    context.Horizons.Add(lElDesafioPivot_2_3);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion
            #region Horizons Los Naranjales
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LosNaranjales)
            {

                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 6aT3
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotLosNaranjales6aT3
                             select soil).FirstOrDefault();
                    var lLosNaranjalesPivot_6aT3_1 = new Horizon
                    {
                        Name = Utils.NamePivotLosNaranjales6aT3 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 39,
                        Limo = 40,
                        Clay = 21,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };
                    var lLosNaranjalesPivot_6aT3_2 = new Horizon
                    {
                        Name = Utils.NamePivotLosNaranjales6aT3 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 20,
                        Sand = 37,
                        Limo = 40,
                        Clay = 23,
                        OrganicMatter = 2.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.38,
                        SoilId = lSoil.SoilId,
                    };
                    var lLosNaranjalesPivot_6aT3_3 = new Horizon
                    {
                        Name = Utils.NamePivotLosNaranjales6aT3 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 20,
                        Sand = 35,
                        Limo = 37,
                        Clay = 28,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.35,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 6bT3
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotLosNaranjales6bT3
                             select soil).FirstOrDefault();
                    var lLosNaranjalesPivot_6bT3_1 = new Horizon
                    {
                        Name = Utils.NamePivotLosNaranjales6bT3 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 42,
                        Limo = 35,
                        Clay = 23,
                        OrganicMatter = 3.0,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };
                    var lLosNaranjalesPivot_6bT3_2 = new Horizon
                    {
                        Name = Utils.NamePivotLosNaranjales6bT3 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 20,
                        Sand = 40,
                        Limo = 30,
                        Clay = 30,
                        OrganicMatter = 2.7,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.42,
                        SoilId = lSoil.SoilId,
                    };
                    var lLosNaranjalesPivot_6bT3_3 = new Horizon
                    {
                        Name = Utils.NamePivotLosNaranjales6bT3 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 20,
                        Sand = 36,
                        Limo = 26,
                        Clay = 38,
                        OrganicMatter = 2.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.38,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 5aT5
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotLosNaranjales5aT5
                             select soil).FirstOrDefault();
                    var lLosNaranjalesPivot_5aT5_1 = new Horizon
                    {
                        Name = Utils.NamePivotLosNaranjales5aT5 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 42,
                        Limo = 21,
                        Clay = 37,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.37,
                        SoilId = lSoil.SoilId,
                    };
                    var lLosNaranjalesPivot_5aT5_2 = new Horizon
                    {
                        Name = Utils.NamePivotLosNaranjales5aT5 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 20,
                        Sand = 44,
                        Limo = 23,
                        Clay = 33,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.38,
                        SoilId = lSoil.SoilId,
                    };
                    var lLosNaranjalesPivot_5aT5_3 = new Horizon
                    {
                        Name = Utils.NamePivotLosNaranjales5aT5 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 20,
                        Sand = 40,
                        Limo = 30,
                        Clay = 30,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 5bT5
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotLosNaranjales5bT5
                             select soil).FirstOrDefault();
                    var lLosNaranjalesPivot_5bT5_1 = new Horizon
                    {
                        Name = Utils.NamePivotLosNaranjales5bT5 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 42,
                        Limo = 21,
                        Clay = 37,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.37,
                        SoilId = lSoil.SoilId,
                    };
                    var lLosNaranjalesPivot_5bT5_2 = new Horizon
                    {
                        Name = Utils.NamePivotLosNaranjales5bT5 + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 20,
                        Sand = 44,
                        Limo = 23,
                        Clay = 33,
                        OrganicMatter = 2.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.38,
                        SoilId = lSoil.SoilId,
                    };
                    var lLosNaranjalesPivot_5bT5_3 = new Horizon
                    {
                        Name = Utils.NamePivotLosNaranjales5bT5 + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 20,
                        Sand = 40,
                        Limo = 30,
                        Clay = 30,
                        OrganicMatter = 1.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Horizons Los Naranjales
                    context.Horizons.Add(lLosNaranjalesPivot_6aT3_1);
                    context.Horizons.Add(lLosNaranjalesPivot_6aT3_2);
                    context.Horizons.Add(lLosNaranjalesPivot_6aT3_3);
                    context.Horizons.Add(lLosNaranjalesPivot_6bT3_1);
                    context.Horizons.Add(lLosNaranjalesPivot_6bT3_2);
                    context.Horizons.Add(lLosNaranjalesPivot_6bT3_3);
                    context.Horizons.Add(lLosNaranjalesPivot_5aT5_1);
                    context.Horizons.Add(lLosNaranjalesPivot_5aT5_2);
                    context.Horizons.Add(lLosNaranjalesPivot_5aT5_3);
                    context.Horizons.Add(lLosNaranjalesPivot_5bT5_1);
                    context.Horizons.Add(lLosNaranjalesPivot_5bT5_2);
                    context.Horizons.Add(lLosNaranjalesPivot_5bT5_3);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion
            #region Horizons Santa Emilia
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaEmilia)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotSantaEmilia1
                             select soil).FirstOrDefault();
                    var lSantaEmiliaPivot_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia1 + " 1",
                        Order = 1,
                        HorizonLayer = "Ap",
                        HorizonLayerDepth = 23,
                        Sand = 30,
                        Limo = 35,
                        Clay = 35,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaEmiliaPivot_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia1 + " 2",
                        Order = 2,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 24,
                        Sand = 30,
                        Limo = 25,
                        Clay = 45,
                        OrganicMatter = 3.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaEmiliaPivot_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia1 + " 3",
                        Order = 3,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 22,
                        Sand = 20,
                        Limo = 25,
                        Clay = 55,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.34,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotSantaEmilia2
                             select soil).FirstOrDefault();
                    var lSantaEmiliaPivot_2_1 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia2 + " 1",
                        Order = 1,
                        HorizonLayer = "Ap",
                        HorizonLayerDepth = 23,
                        Sand = 30,
                        Limo = 35,
                        Clay = 35,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaEmiliaPivot_2_2 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia2 + " 2",
                        Order = 2,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 24,
                        Sand = 30,
                        Limo = 25,
                        Clay = 45,
                        OrganicMatter = 3.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaEmiliaPivot_2_3 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia2 + " 3",
                        Order = 3,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 22,
                        Sand = 20,
                        Limo = 25,
                        Clay = 55,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.34,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 3
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotSantaEmilia3
                             select soil).FirstOrDefault();
                    var lSantaEmiliaPivot_3_1 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia3 + " 1",
                        Order = 1,
                        HorizonLayer = "Ap",
                        HorizonLayerDepth = 23,
                        Sand = 30,
                        Limo = 35,
                        Clay = 35,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaEmiliaPivot_3_2 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia3 + " 2",
                        Order = 2,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 24,
                        Sand = 30,
                        Limo = 25,
                        Clay = 45,
                        OrganicMatter = 3.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaEmiliaPivot_3_3 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia3 + " 3",
                        Order = 3,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 22,
                        Sand = 20,
                        Limo = 25,
                        Clay = 55,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.34,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 4
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotSantaEmilia4
                             select soil).FirstOrDefault();
                    var lSantaEmiliaPivot_4_1 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia4 + " 1",
                        Order = 1,
                        HorizonLayer = "Ap",
                        HorizonLayerDepth = 23,
                        Sand = 30,
                        Limo = 35,
                        Clay = 35,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaEmiliaPivot_4_2 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia4 + " 2",
                        Order = 2,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 24,
                        Sand = 30,
                        Limo = 25,
                        Clay = 45,
                        OrganicMatter = 3.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaEmiliaPivot_4_3 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia4 + " 3",
                        Order = 3,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 22,
                        Sand = 20,
                        Limo = 25,
                        Clay = 55,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.34,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 5
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotSantaEmilia5
                             select soil).FirstOrDefault();
                    var lSantaEmiliaPivot_5_1 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia5 + " 1",
                        Order = 1,
                        HorizonLayer = "Ap",
                        HorizonLayerDepth = 23,
                        Sand = 30,
                        Limo = 35,
                        Clay = 35,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaEmiliaPivot_5_2 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia5 + " 2",
                        Order = 2,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 24,
                        Sand = 30,
                        Limo = 25,
                        Clay = 45,
                        OrganicMatter = 3.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaEmiliaPivot_5_3 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia5 + " 3",
                        Order = 3,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 22,
                        Sand = 20,
                        Limo = 25,
                        Clay = 55,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.34,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 7
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotSantaEmilia7
                             select soil).FirstOrDefault();
                    var lSantaEmiliaPivot_7_1 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia7 + " 1",
                        Order = 1,
                        HorizonLayer = "Ap",
                        HorizonLayerDepth = 23,
                        Sand = 30,
                        Limo = 35,
                        Clay = 35,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaEmiliaPivot_7_2 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia7 + " 2",
                        Order = 2,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 24,
                        Sand = 30,
                        Limo = 25,
                        Clay = 45,
                        OrganicMatter = 3.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaEmiliaPivot_7_3 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmilia7 + " 3",
                        Order = 3,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 22,
                        Sand = 20,
                        Limo = 25,
                        Clay = 55,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.34,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot ZP - ALPINO
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotSantaEmiliaZP
                             select soil).FirstOrDefault();
                    var lSantaEmiliaPivot_ZP_1 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmiliaZP + " 1",
                        Order = 1,
                        HorizonLayer = "Ap",
                        HorizonLayerDepth = 23,
                        Sand = 30,
                        Limo = 35,
                        Clay = 35,
                        OrganicMatter = 4.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaEmiliaPivot_ZP_2 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmiliaZP + " 2",
                        Order = 2,
                        HorizonLayer = "B1",
                        HorizonLayerDepth = 47,
                        Sand = 30,
                        Limo = 25,
                        Clay = 45,
                        OrganicMatter = 3.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.25,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantaEmiliaPivot_ZP_3 = new Horizon
                    {
                        Name = Utils.NamePivotSantaEmiliaZP + " 3",
                        Order = 3,
                        HorizonLayer = "B2",
                        HorizonLayerDepth = 69,
                        Sand = 20,
                        Limo = 25,
                        Clay = 55,
                        OrganicMatter = 1.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.34,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Horizons Santa Emilia
                    context.Horizons.Add(lSantaEmiliaPivot_1_1);
                    context.Horizons.Add(lSantaEmiliaPivot_1_2);
                    context.Horizons.Add(lSantaEmiliaPivot_1_3);
                    context.Horizons.Add(lSantaEmiliaPivot_2_1);
                    context.Horizons.Add(lSantaEmiliaPivot_2_2);
                    context.Horizons.Add(lSantaEmiliaPivot_2_3);
                    context.Horizons.Add(lSantaEmiliaPivot_3_1);
                    context.Horizons.Add(lSantaEmiliaPivot_3_2);
                    context.Horizons.Add(lSantaEmiliaPivot_3_3);
                    context.Horizons.Add(lSantaEmiliaPivot_4_1);
                    context.Horizons.Add(lSantaEmiliaPivot_4_2);
                    context.Horizons.Add(lSantaEmiliaPivot_4_3);
                    context.Horizons.Add(lSantaEmiliaPivot_5_1);
                    context.Horizons.Add(lSantaEmiliaPivot_5_2);
                    context.Horizons.Add(lSantaEmiliaPivot_5_3);
                    context.Horizons.Add(lSantaEmiliaPivot_7_1);
                    context.Horizons.Add(lSantaEmiliaPivot_7_2);
                    context.Horizons.Add(lSantaEmiliaPivot_7_3);
                    context.Horizons.Add(lSantaEmiliaPivot_ZP_1);
                    context.Horizons.Add(lSantaEmiliaPivot_ZP_2);
                    context.Horizons.Add(lSantaEmiliaPivot_ZP_3);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion
            #region Horizons Gran Molino
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GranMolino)
            {

                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGranMolino1
                             select soil).FirstOrDefault();
                    var lGranMolinoPivot_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 30,
                        Sand = 15,
                        Limo = 50,
                        Clay = 35,
                        OrganicMatter = 3.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lGranMolinoPivot_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino1 + " 2",
                        Order = 2,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 17,
                        Sand = 12,
                        Limo = 49,
                        Clay = 39,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.24,
                        SoilId = lSoil.SoilId,
                    };
                    var lGranMolinoPivot_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino1 + " 3",
                        Order = 3,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 22,
                        Sand = 11,
                        Limo = 47,
                        Clay = 42,
                        OrganicMatter = 2.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGranMolino2
                             select soil).FirstOrDefault();
                    var lGranMolinoPivot_2_1 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino2 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 30,
                        Sand = 15,
                        Limo = 50,
                        Clay = 35,
                        OrganicMatter = 3.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lGranMolinoPivot_2_2 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino2 + " 2",
                        Order = 2,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 17,
                        Sand = 12,
                        Limo = 49,
                        Clay = 39,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.24,
                        SoilId = lSoil.SoilId,
                    };
                    var lGranMolinoPivot_2_3 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino2 + " 3",
                        Order = 3,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 22,
                        Sand = 11,
                        Limo = 47,
                        Clay = 42,
                        OrganicMatter = 2.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 3
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGranMolino3
                             select soil).FirstOrDefault();
                    var lGranMolinoPivot_3_1 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino3 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 30,
                        Sand = 15,
                        Limo = 50,
                        Clay = 35,
                        OrganicMatter = 3.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lGranMolinoPivot_3_2 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino3 + " 2",
                        Order = 2,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 17,
                        Sand = 12,
                        Limo = 49,
                        Clay = 39,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.24,
                        SoilId = lSoil.SoilId,
                    };
                    var lGranMolinoPivot_3_3 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino3 + " 3",
                        Order = 3,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 22,
                        Sand = 11,
                        Limo = 47,
                        Clay = 42,
                        OrganicMatter = 2.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 4
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGranMolino4
                             select soil).FirstOrDefault();
                    var lGranMolinoPivot_4_1 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino4 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 30,
                        Sand = 15,
                        Limo = 50,
                        Clay = 35,
                        OrganicMatter = 3.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lGranMolinoPivot_4_2 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino4 + " 2",
                        Order = 2,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 17,
                        Sand = 12,
                        Limo = 49,
                        Clay = 39,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.24,
                        SoilId = lSoil.SoilId,
                    };
                    var lGranMolinoPivot_4_3 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino4 + " 3",
                        Order = 3,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 22,
                        Sand = 11,
                        Limo = 47,
                        Clay = 42,
                        OrganicMatter = 2.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 5
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGranMolino5
                             select soil).FirstOrDefault();
                    var lGranMolinoPivot_5_1 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino5 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 30,
                        Sand = 15,
                        Limo = 50,
                        Clay = 35,
                        OrganicMatter = 3.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lGranMolinoPivot_5_2 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino5 + " 2",
                        Order = 2,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 17,
                        Sand = 12,
                        Limo = 49,
                        Clay = 39,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.24,
                        SoilId = lSoil.SoilId,
                    };
                    var lGranMolinoPivot_5_3 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino5 + " 3",
                        Order = 3,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 22,
                        Sand = 11,
                        Limo = 47,
                        Clay = 42,
                        OrganicMatter = 2.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Pivot 2b
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGranMolino2b
                             select soil).FirstOrDefault();
                    var lGranMolinoPivot_2b_1 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino2b + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 30,
                        Sand = 15,
                        Limo = 50,
                        Clay = 35,
                        OrganicMatter = 3.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lGranMolinoPivot_2b_2 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino2b + " 2",
                        Order = 2,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 17,
                        Sand = 12,
                        Limo = 49,
                        Clay = 39,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.24,
                        SoilId = lSoil.SoilId,
                    };
                    var lGranMolinoPivot_2b_3 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino2b + " 3",
                        Order = 3,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 22,
                        Sand = 11,
                        Limo = 47,
                        Clay = 42,
                        OrganicMatter = 2.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 5b
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGranMolino5b
                             select soil).FirstOrDefault();
                    var lGranMolinoPivot_5b_1 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino5b + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 30,
                        Sand = 15,
                        Limo = 50,
                        Clay = 35,
                        OrganicMatter = 3.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lGranMolinoPivot_5b_2 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino5b + " 2",
                        Order = 2,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 17,
                        Sand = 12,
                        Limo = 49,
                        Clay = 39,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.24,
                        SoilId = lSoil.SoilId,
                    };
                    var lGranMolinoPivot_5b_3 = new Horizon
                    {
                        Name = Utils.NamePivotGranMolino5b + " 3",
                        Order = 3,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 22,
                        Sand = 11,
                        Limo = 47,
                        Clay = 42,
                        OrganicMatter = 2.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Horizons Gran Molino
                    context.Horizons.Add(lGranMolinoPivot_1_1);
                    context.Horizons.Add(lGranMolinoPivot_1_2);
                    context.Horizons.Add(lGranMolinoPivot_1_3);
                    context.Horizons.Add(lGranMolinoPivot_2_1);
                    context.Horizons.Add(lGranMolinoPivot_2_2);
                    context.Horizons.Add(lGranMolinoPivot_2_3);
                    context.Horizons.Add(lGranMolinoPivot_3_1);
                    context.Horizons.Add(lGranMolinoPivot_3_2);
                    context.Horizons.Add(lGranMolinoPivot_3_3);
                    context.Horizons.Add(lGranMolinoPivot_4_1);
                    context.Horizons.Add(lGranMolinoPivot_4_2);
                    context.Horizons.Add(lGranMolinoPivot_4_3);
                    context.Horizons.Add(lGranMolinoPivot_5_1);
                    context.Horizons.Add(lGranMolinoPivot_5_2);
                    context.Horizons.Add(lGranMolinoPivot_5_3);
                    context.Horizons.Add(lGranMolinoPivot_2b_1);
                    context.Horizons.Add(lGranMolinoPivot_2b_2);
                    context.Horizons.Add(lGranMolinoPivot_2b_3);
                    context.Horizons.Add(lGranMolinoPivot_5b_1);
                    context.Horizons.Add(lGranMolinoPivot_5b_2);
                    context.Horizons.Add(lGranMolinoPivot_5b_3);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion
            
            #region Horizons La Portuguesa
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPortuguesa)
            {

                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotLaPortuguesa1
                             select soil).FirstOrDefault();
                    var lLaPortuguesaPivot_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotLaPortuguesa1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 50,
                        Clay = 30,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    var lLaPortuguesaPivot_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotLaPortuguesa1 + " 2",
                        Order = 2,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 40,
                        Sand = 28,
                        Limo = 32,
                        Clay = 40,
                        OrganicMatter = 2.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotLaPortuguesa2
                             select soil).FirstOrDefault();
                    var lLaPortuguesaPivot_2_1 = new Horizon
                    {
                        Name = Utils.NamePivotLaPortuguesa2 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 20,
                        Sand = 20,
                        Limo = 50,
                        Clay = 30,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.3,
                        SoilId = lSoil.SoilId,
                    };
                    var lLaPortuguesaPivot_2_2 = new Horizon
                    {
                        Name = Utils.NamePivotLaPortuguesa2 + " 2",
                        Order = 2,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 40,
                        Sand = 28,
                        Limo = 32,
                        Clay = 40,
                        OrganicMatter = 2.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Horizons La Portuguesa
                    context.Horizons.Add(lLaPortuguesaPivot_1_1);
                    context.Horizons.Add(lLaPortuguesaPivot_1_2);
                    context.Horizons.Add(lLaPortuguesaPivot_2_1);
                    context.Horizons.Add(lLaPortuguesaPivot_2_2);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion
            #region Horizons Cassarino - La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.CassarinoLaPerdiz)
            {

                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1.1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotCassarinoLaPerdiz11
                             select soil).FirstOrDefault();
                    var lCassarinoLaPerdizPivot_11_1 = new Horizon
                    {
                        Name = Utils.NamePivotCassarinoLaPerdiz11 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 30,
                        Sand = 14.7,
                        Limo = 55.8,
                        Clay = 29.5,
                        OrganicMatter = 5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.2,
                        SoilId = lSoil.SoilId,
                    };
                    var lCassarinoLaPerdizPivot_11_2 = new Horizon
                    {
                        Name = Utils.NamePivotCassarinoLaPerdiz11 + " 2",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 54,
                        Sand = 12.9,
                        Limo = 41.1,
                        Clay = 40,
                        OrganicMatter = 3.6,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.24,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 1.2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotCassarinoLaPerdiz12
                             select soil).FirstOrDefault();
                    var lCassarinoLaPerdizPivot_12_1 = new Horizon
                    {
                        Name = Utils.NamePivotCassarinoLaPerdiz12 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 30,
                        Sand = 17,
                        Limo = 57.2,
                        Clay = 25.8,
                        OrganicMatter = 4.4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.22,
                        SoilId = lSoil.SoilId,
                    };
                    var lCassarinoLaPerdizPivot_12_2 = new Horizon
                    {
                        Name = Utils.NamePivotCassarinoLaPerdiz12 + " 2",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 48,
                        Sand = 14,
                        Limo = 51.7,
                        Clay = 34.3,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.24,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 1.3
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotCassarinoLaPerdiz13
                             select soil).FirstOrDefault();
                    var lCassarinoLaPerdizPivot_13_1 = new Horizon
                    {
                        Name = Utils.NamePivotCassarinoLaPerdiz13 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 32,
                        Sand = 12.6,
                        Limo = 53.8,
                        Clay = 33.6,
                        OrganicMatter = 4,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.18,
                        SoilId = lSoil.SoilId,
                    };
                    var lCassarinoLaPerdizPivot_13_2 = new Horizon
                    {
                        Name = Utils.NamePivotCassarinoLaPerdiz13 + " 2",
                        Order = 2,
                        HorizonLayer = "Bt",
                        HorizonLayerDepth = 52,
                        Sand = 13.9,
                        Limo = 46.6,
                        Clay = 39.5,
                        OrganicMatter = 3.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.22,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Horizons Cassarino - La Perdiz
                    context.Horizons.Add(lCassarinoLaPerdizPivot_11_1);
                    context.Horizons.Add(lCassarinoLaPerdizPivot_11_2);
                    context.Horizons.Add(lCassarinoLaPerdizPivot_12_1);
                    context.Horizons.Add(lCassarinoLaPerdizPivot_12_2);
                    context.Horizons.Add(lCassarinoLaPerdizPivot_13_1);
                    context.Horizons.Add(lCassarinoLaPerdizPivot_13_2);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion
            #region Horizons Santo Domingo
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantoDomingo)
            {

                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotSantoDomingo1
                             select soil).FirstOrDefault();
                    var lSantoDomingoPivot_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotSantoDomingo1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 18,
                        Sand = 63,
                        Limo = 12.2,
                        Clay = 17,
                        OrganicMatter = 2.7,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantoDomingoPivot_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotSantoDomingo1 + " 2",
                        Order = 2,
                        HorizonLayer = "BA",
                        HorizonLayerDepth = 38,
                        Sand = 55,
                        Limo = 21.1,
                        Clay = 33,
                        OrganicMatter = 1.7,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.5,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantoDomingoPivot_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotSantoDomingo1 + " 3",
                        Order = 3,
                        HorizonLayer = "Btu1",
                        HorizonLayerDepth = 47,
                        Sand = 42,
                        Limo = 23,
                        Clay = 38,
                        OrganicMatter = 0.7,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.5,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantoDomingoPivot_1_4 = new Horizon
                    {
                        Name = Utils.NamePivotSantoDomingo1 + " 4",
                        Order = 4,
                        HorizonLayer = "Btu2",
                        HorizonLayerDepth = 60,
                        Sand = 39,
                        Limo = 26.4,
                        Clay = 44,
                        OrganicMatter = 0.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.5,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotSantoDomingo2
                             select soil).FirstOrDefault();
                    var lSantoDomingoPivot_2_1 = new Horizon
                    {
                        Name = Utils.NamePivotSantoDomingo2 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 18,
                        Sand = 63,
                        Limo = 12.2,
                        Clay = 17,
                        OrganicMatter = 2.7,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantoDomingoPivot_2_2 = new Horizon
                    {
                        Name = Utils.NamePivotSantoDomingo2 + " 2",
                        Order = 2,
                        HorizonLayer = "BA",
                        HorizonLayerDepth = 38,
                        Sand = 55,
                        Limo = 21.1,
                        Clay = 33,
                        OrganicMatter = 1.7,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.5,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantoDomingoPivot_2_3 = new Horizon
                    {
                        Name = Utils.NamePivotSantoDomingo2 + " 3",
                        Order = 3,
                        HorizonLayer = "Btu1",
                        HorizonLayerDepth = 47,
                        Sand = 42,
                        Limo = 23,
                        Clay = 38,
                        OrganicMatter = 0.7,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.5,
                        SoilId = lSoil.SoilId,
                    };
                    var lSantoDomingoPivot_2_4 = new Horizon
                    {
                        Name = Utils.NamePivotSantoDomingo2 + " 4",
                        Order = 4,
                        HorizonLayer = "Btu2",
                        HorizonLayerDepth = 60,
                        Sand = 39,
                        Limo = 26.4,
                        Clay = 44,
                        OrganicMatter = 0.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.5,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Horizons Santo Domingo
                    context.Horizons.Add(lSantoDomingoPivot_1_1);
                    context.Horizons.Add(lSantoDomingoPivot_1_2);
                    context.Horizons.Add(lSantoDomingoPivot_1_3);
                    context.Horizons.Add(lSantoDomingoPivot_1_4);
                    context.Horizons.Add(lSantoDomingoPivot_2_1);
                    context.Horizons.Add(lSantoDomingoPivot_2_2);
                    context.Horizons.Add(lSantoDomingoPivot_2_3);
                    context.Horizons.Add(lSantoDomingoPivot_2_4);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion

            #region Horizons Cecchini
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Cecchini)
            {

                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 1
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotCecchini1
                             select soil).FirstOrDefault();
                    var lCecchiniPivot_1_1 = new Horizon
                    {
                        Name = Utils.NamePivotCecchini1 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 15,
                        Sand = 43,
                        Limo = 31,
                        Clay = 26,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.28,
                        SoilId = lSoil.SoilId,
                    };
                    var lCecchiniPivot_1_2 = new Horizon
                    {
                        Name = Utils.NamePivotCecchini1 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 32,
                        Sand = 40,
                        Limo = 30,
                        Clay = 30,
                        OrganicMatter = 2.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.33,
                        SoilId = lSoil.SoilId,
                    };
                    var lCecchiniPivot_1_3 = new Horizon
                    {
                        Name = Utils.NamePivotCecchini1 + " 3",
                        Order = 3,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 45,
                        Sand = 37,
                        Limo = 29,
                        Clay = 34,
                        OrganicMatter = 1.3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.42,
                        SoilId = lSoil.SoilId,
                    };
                    var lCecchiniPivot_1_4 = new Horizon
                    {
                        Name = Utils.NamePivotCecchini1 + " 4",
                        Order = 4,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 60,
                        Sand = 35,
                        Limo = 27,
                        Clay = 38,
                        OrganicMatter = 0.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.46,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 2
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotCecchini2
                             select soil).FirstOrDefault();
                    var lCecchiniPivot_2_1 = new Horizon
                    {
                        Name = Utils.NamePivotCecchini2 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 15,
                        Sand = 43,
                        Limo = 31,
                        Clay = 26,
                        OrganicMatter = 2.8,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.28,
                        SoilId = lSoil.SoilId,
                    };
                    var lCecchiniPivot_2_2 = new Horizon
                    {
                        Name = Utils.NamePivotCecchini2 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 32,
                        Sand = 40,
                        Limo = 30,
                        Clay = 30,
                        OrganicMatter = 2.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.33,
                        SoilId = lSoil.SoilId,
                    };
                    var lCecchiniPivot_2_3 = new Horizon
                    {
                        Name = Utils.NamePivotCecchini2 + " 3",
                        Order = 3,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 45,
                        Sand = 37,
                        Limo = 29,
                        Clay = 34,
                        OrganicMatter = 1.3,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.42,
                        SoilId = lSoil.SoilId,
                    };
                    var lCecchiniPivot_2_4 = new Horizon
                    {
                        Name = Utils.NamePivotCecchini2 + " 4",
                        Order = 4,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 60,
                        Sand = 35,
                        Limo = 27,
                        Clay = 38,
                        OrganicMatter = 0.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.46,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Horizons Cecchini
                    context.Horizons.Add(lCecchiniPivot_1_1);
                    context.Horizons.Add(lCecchiniPivot_1_2);
                    context.Horizons.Add(lCecchiniPivot_1_3);
                    context.Horizons.Add(lCecchiniPivot_1_4);
                    context.Horizons.Add(lCecchiniPivot_2_1);
                    context.Horizons.Add(lCecchiniPivot_2_2);
                    context.Horizons.Add(lCecchiniPivot_2_3);
                    context.Horizons.Add(lCecchiniPivot_2_4);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion
            #region Horizons El Alba
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElAlba)
            {

                using (var context = new IrrigationAdvisorContext())
                {
                    #region Pivot 32
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotElAlba32
                             select soil).FirstOrDefault();
                    var lElAlbaPivot_32_1 = new Horizon
                    {
                        Name = Utils.NamePivotElAlba32 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 18,
                        Sand = 30,
                        Limo = 50,
                        Clay = 20,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };
                    var lElAlbaPivot_32_2 = new Horizon
                    {
                        Name = Utils.NamePivotElAlba32 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 36,
                        Sand = 28,
                        Limo = 44,
                        Clay = 28,
                        OrganicMatter = 2.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.5,
                        SoilId = lSoil.SoilId,
                    };
                    var lElAlbaPivot_32_3 = new Horizon
                    {
                        Name = Utils.NamePivotElAlba32 + " 3",
                        Order = 3,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 45,
                        Sand = 25,
                        Limo = 37,
                        Clay = 38,
                        OrganicMatter = 0.7,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.5,
                        SoilId = lSoil.SoilId,
                    };
                    var lElAlbaPivot_32_4 = new Horizon
                    {
                        Name = Utils.NamePivotElAlba32 + " 4",
                        Order = 4,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 60,
                        Sand = 22,
                        Limo = 35,
                        Clay = 43,
                        OrganicMatter = 0.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.5,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion
                    #region Pivot 33
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotElAlba33
                             select soil).FirstOrDefault();
                    var lElAlbaPivot_33_1 = new Horizon
                    {
                        Name = Utils.NamePivotElAlba33 + " 1",
                        Order = 1,
                        HorizonLayer = "A",
                        HorizonLayerDepth = 18,
                        Sand = 30,
                        Limo = 50,
                        Clay = 20,
                        OrganicMatter = 3.2,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.4,
                        SoilId = lSoil.SoilId,
                    };
                    var lElAlbaPivot_33_2 = new Horizon
                    {
                        Name = Utils.NamePivotElAlba33 + " 2",
                        Order = 2,
                        HorizonLayer = "B",
                        HorizonLayerDepth = 36,
                        Sand = 28,
                        Limo = 44,
                        Clay = 28,
                        OrganicMatter = 2.1,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.5,
                        SoilId = lSoil.SoilId,
                    };
                    var lElAlbaPivot_33_3 = new Horizon
                    {
                        Name = Utils.NamePivotElAlba33 + " 3",
                        Order = 3,
                        HorizonLayer = "Bt1",
                        HorizonLayerDepth = 45,
                        Sand = 25,
                        Limo = 37,
                        Clay = 38,
                        OrganicMatter = 0.7,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.5,
                        SoilId = lSoil.SoilId,
                    };
                    var lElAlbaPivot_33_4 = new Horizon
                    {
                        Name = Utils.NamePivotElAlba33 + " 4",
                        Order = 4,
                        HorizonLayer = "Bt2",
                        HorizonLayerDepth = 60,
                        Sand = 22,
                        Limo = 35,
                        Clay = 43,
                        OrganicMatter = 0.5,
                        NitrogenAnalysis = 0,
                        BulkDensitySoil = 1.5,
                        SoilId = lSoil.SoilId,
                    };
                    #endregion

                    #region Horizons El Alba
                    context.Horizons.Add(lElAlbaPivot_32_1);
                    context.Horizons.Add(lElAlbaPivot_32_2);
                    context.Horizons.Add(lElAlbaPivot_32_3);
                    context.Horizons.Add(lElAlbaPivot_32_4);
                    context.Horizons.Add(lElAlbaPivot_33_1);
                    context.Horizons.Add(lElAlbaPivot_33_2);
                    context.Horizons.Add(lElAlbaPivot_33_3);
                    context.Horizons.Add(lElAlbaPivot_33_4);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion

            #region Horizons

            using (var context = new IrrigationAdvisorContext())
            {
                //context.Horizons.Add(lBase);

                context.SaveChanges();
            }

            #endregion

        }

        public static void InsertSoils()
        {
            Farm lFarm = null;
            Position lPosition = null;
            Horizon lHorizon1 = null;
            Horizon lHorizon2 = null;
            Horizon lHorizon3 = null;
            Horizon lHorizon4 = null;

            #region Base
            var lBase = new Soil
            {
                Name = Utils.NameBase,
                ShortName = Utils.NameBase,
                Description = "",
                PositionId = 0,
                TestDate = Utils.MIN_DATETIME,
                DepthLimit = 0,
                FarmId = 0,
            };
            #endregion

            #region Demo1 Soils - La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmDemo1
                             select far).FirstOrDefault();

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo11
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo11 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo11 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo11 + " 3"
                                 select hor).FirstOrDefault();
                    var lDemoPivot1 = new Soil
                    {
                        Name = Utils.NamePivotDemo11,
                        Description = "Suelo del Pivot 1 en Demo - La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDemo11,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDemoPivot1.HorizonList.Add(lHorizon1);
                    lDemoPivot1.HorizonList.Add(lHorizon2);
                    lDemoPivot1.HorizonList.Add(lHorizon3);
                    #endregion

                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo12
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo12 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo12 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo12 + " 3"
                                 select hor).FirstOrDefault();
                    var lDemoPivot2 = new Soil
                    {
                        Name = Utils.NamePivotDemo12,
                        Description = "Suelo del Pivot 2 en Demo - La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDemo12,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDemoPivot2.HorizonList.Add(lHorizon1);
                    lDemoPivot2.HorizonList.Add(lHorizon2);
                    lDemoPivot2.HorizonList.Add(lHorizon3);
                    #endregion

                    #region Pivot 3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo13
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo13 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo13 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo13 + " 3"
                                 select hor).FirstOrDefault();
                    var lDemoPivot3 = new Soil
                    {
                        Name = Utils.NamePivotDemo13,
                        Description = "Suelo del Pivot 3 en Demo - La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 7),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDemo13,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDemoPivot3.HorizonList.Add(lHorizon1);
                    lDemoPivot3.HorizonList.Add(lHorizon2);
                    lDemoPivot3.HorizonList.Add(lHorizon3);
                    #endregion

                    #region Pivot 5
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo15
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo15 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo15 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo15 + " 3"
                                 select hor).FirstOrDefault();
                    var lDemoPivot5 = new Soil
                    {
                        Name = Utils.NamePivotDemo15,
                        Description = "Suelo del Pivot 5 en Demo - La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 8),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDemo15,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDemoPivot5.HorizonList.Add(lHorizon1);
                    lDemoPivot5.HorizonList.Add(lHorizon2);
                    lDemoPivot5.HorizonList.Add(lHorizon3);
                    #endregion

                    context.Soils.Add(lDemoPivot1);
                    context.Soils.Add(lDemoPivot2);
                    context.Soils.Add(lDemoPivot3);
                    context.Soils.Add(lDemoPivot5);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Demo2 Soils - Santa Lucia
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmDemo2
                             select far).FirstOrDefault();

                    #region Pivot 21
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo21
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo21 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo21 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo21 + " 3"
                                 select hor).FirstOrDefault();
                    var lDemo2Pivot21 = new Soil
                    {
                        Name = Utils.NamePivotDemo21,
                        Description = "Suelo del Pivot 1 en Demo - Santa Lucia. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDemo21,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDemo2Pivot21.HorizonList.Add(lHorizon1);
                    lDemo2Pivot21.HorizonList.Add(lHorizon2);
                    lDemo2Pivot21.HorizonList.Add(lHorizon3);
                    #endregion

                    #region Pivot 22
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo22
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo22 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo22 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo22 + " 3"
                                 select hor).FirstOrDefault();
                    var lDemo2Pivot22 = new Soil
                    {
                        Name = Utils.NamePivotDemo22,
                        Description = "Suelo del Pivot 2 en Demo - Santa Lucia. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDemo22,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDemo2Pivot22.HorizonList.Add(lHorizon1);
                    lDemo2Pivot22.HorizonList.Add(lHorizon2);
                    lDemo2Pivot22.HorizonList.Add(lHorizon3);
                    #endregion

                    #region Pivot 23
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo23
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo23 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo23 + " 2"
                                 select hor).FirstOrDefault();
                    var lDemo2Pivot23 = new Soil
                    {
                        Name = Utils.NamePivotDemo23,
                        Description = "Suelo del Pivot 3 en Demo - Santa Lucia. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 7),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDemo23,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDemo2Pivot23.HorizonList.Add(lHorizon1);
                    lDemo2Pivot23.HorizonList.Add(lHorizon2);
                    #endregion

                    #region Pivot 24
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo24
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo24 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo24 + " 2"
                                 select hor).FirstOrDefault();
                    var lDemo2Pivot24 = new Soil
                    {
                        Name = Utils.NamePivotDemo24,
                        Description = "Suelo del Pivot 4 en Demo - Santa Lucia. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 8),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDemo24,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDemo2Pivot24.HorizonList.Add(lHorizon1);
                    lDemo2Pivot24.HorizonList.Add(lHorizon2);
                    #endregion

                    #region Pivot 25
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo25
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo25 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo25 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo25 + " 3"
                                 select hor).FirstOrDefault();
                    var lDemo2Pivot25 = new Soil
                    {
                        Name = Utils.NamePivotDemo25,
                        Description = "Suelo del Pivot 5 en Demo - Santa Lucia. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 8),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDemo25,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDemo2Pivot25.HorizonList.Add(lHorizon1);
                    lDemo2Pivot25.HorizonList.Add(lHorizon2);
                    lDemo2Pivot25.HorizonList.Add(lHorizon3);
                    #endregion

                    context.Soils.Add(lDemo2Pivot21);
                    context.Soils.Add(lDemo2Pivot22);
                    context.Soils.Add(lDemo2Pivot23);
                    context.Soils.Add(lDemo2Pivot24);
                    context.Soils.Add(lDemo2Pivot25);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Demo3 Soils - La Palma
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmDemo3
                             select far).FirstOrDefault();

                    #region Pivot 31
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo31
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo31 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo31 + " 2"
                                 select hor).FirstOrDefault();
                    var lDemo3Pivot31 = new Soil
                    {
                        Name = Utils.NamePivotDemo31,
                        Description = "Suelo del Pivot 1 en Demo - La Palma. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDemo31,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDemo3Pivot31.HorizonList.Add(lHorizon1);
                    lDemo3Pivot31.HorizonList.Add(lHorizon2);
                    #endregion

                    #region Pivot 32
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo32A
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo32A + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo32A + " 2"
                                 select hor).FirstOrDefault();
                    var lDemo3Pivot32A = new Soil
                    {
                        Name = Utils.NamePivotDemo32A,
                        Description = "Suelo del Pivot 2 en Demo - La Palma. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDemo32A,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDemo3Pivot32A.HorizonList.Add(lHorizon1);
                    lDemo3Pivot32A.HorizonList.Add(lHorizon2);
                    #endregion

                    #region Pivot 33
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo33
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo33 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo33 + " 2"
                                 select hor).FirstOrDefault();
                    var lDemo3Pivot33 = new Soil
                    {
                        Name = Utils.NamePivotDemo33,
                        Description = "Suelo del Pivot 3 en Demo - La Palma. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 7),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDemo33,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDemo3Pivot33.HorizonList.Add(lHorizon1);
                    lDemo3Pivot33.HorizonList.Add(lHorizon2);
                    #endregion

                    #region Pivot 34
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo34
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo34 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo34 + " 2"
                                 select hor).FirstOrDefault();
                    var lDemo3Pivot34 = new Soil
                    {
                        Name = Utils.NamePivotDemo34,
                        Description = "Suelo del Pivot 5 en Demo - La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 8),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDemo34,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDemo3Pivot34.HorizonList.Add(lHorizon1);
                    lDemo3Pivot34.HorizonList.Add(lHorizon2);
                    #endregion

                    #region Pivot 35
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo35
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo35 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDemo35 + " 2"
                                 select hor).FirstOrDefault();
                    var lDemo3Pivot35 = new Soil
                    {
                        Name = Utils.NamePivotDemo35,
                        Description = "Suelo del Pivot 5 en Demo - La Palma. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 8),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDemo35,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDemo3Pivot35.HorizonList.Add(lHorizon1);
                    lDemo3Pivot35.HorizonList.Add(lHorizon2);
                    #endregion

                    context.Soils.Add(lDemo3Pivot31);
                    context.Soils.Add(lDemo3Pivot32A);
                    context.Soils.Add(lDemo3Pivot33);
                    context.Soils.Add(lDemo3Pivot34);
                    context.Soils.Add(lDemo3Pivot35);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Santa Lucia Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmSantaLucia
                             select far).FirstOrDefault();

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaLucia1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaLucia1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaLucia1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaLucia1 + " 3"
                                 select hor).FirstOrDefault();
                    var lSantaLuciaPivot1 = new Soil
                    {
                        Name = Utils.NamePivotSantaLucia1,
                        Description = "Suelo del Pivot 1 en Santa Lucia",
                        PositionId = lPosition.PositionId,
                        TestDate = Utils.MIN_DATETIME,
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotSantaLucia1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lSantaLuciaPivot1.HorizonList.Add(lHorizon1);
                    lSantaLuciaPivot1.HorizonList.Add(lHorizon2);
                    lSantaLuciaPivot1.HorizonList.Add(lHorizon3);
                    #endregion

                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaLucia2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaLucia2 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaLucia2 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaLucia2 + " 3"
                                 select hor).FirstOrDefault();
                    var lSantaLuciaPivot2 = new Soil
                    {
                        Name = Utils.NamePivotSantaLucia2,
                        Description = "Suelo del Pivot 2 en Santa Lucia",
                        PositionId = lPosition.PositionId,
                        TestDate = Utils.MIN_DATETIME,
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotSantaLucia2,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lSantaLuciaPivot2.HorizonList.Add(lHorizon1);
                    lSantaLuciaPivot2.HorizonList.Add(lHorizon2);
                    lSantaLuciaPivot2.HorizonList.Add(lHorizon3);
                    #endregion

                    #region Pivot 3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaLucia3
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaLucia3 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaLucia3 + " 2"
                                 select hor).FirstOrDefault();
                    var lSantaLuciaPivot3 = new Soil
                    {
                        Name = Utils.NamePivotSantaLucia3,
                        Description = "Suelo del Pivot 3 en Santa Lucia",
                        PositionId = lPosition.PositionId,
                        TestDate = Utils.MIN_DATETIME,
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotSantaLucia3,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lSantaLuciaPivot3.HorizonList.Add(lHorizon1);
                    lSantaLuciaPivot3.HorizonList.Add(lHorizon2);
                    #endregion

                    #region Pivot 4
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaLucia4
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaLucia4 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaLucia4 + " 2"
                                 select hor).FirstOrDefault();
                    var lSantaLuciaPivot4 = new Soil
                    {
                        Name = Utils.NamePivotSantaLucia4,
                        Description = "Suelo del Pivot 4 en Santa Lucia",
                        PositionId = lPosition.PositionId,
                        TestDate = Utils.MIN_DATETIME,
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotSantaLucia4,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lSantaLuciaPivot4.HorizonList.Add(lHorizon1);
                    lSantaLuciaPivot4.HorizonList.Add(lHorizon2);
                    #endregion

                    #region Pivot 5
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaLucia5
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaLucia5 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaLucia5 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaLucia5 + " 3"
                                 select hor).FirstOrDefault();
                    var lSantaLuciaPivot5 = new Soil
                    {
                        Name = Utils.NamePivotSantaLucia5,
                        Description = "Suelo del Pivot 5 en Santa Lucia",
                        PositionId = lPosition.PositionId,
                        TestDate = Utils.MIN_DATETIME,
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotSantaLucia5,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lSantaLuciaPivot5.HorizonList.Add(lHorizon1);
                    lSantaLuciaPivot5.HorizonList.Add(lHorizon2);
                    lSantaLuciaPivot5.HorizonList.Add(lHorizon3);
                    #endregion

                    //context.Soils.Add(lBase);
                    context.Soils.Add(lSantaLuciaPivot1);
                    context.Soils.Add(lSantaLuciaPivot2);
                    context.Soils.Add(lSantaLuciaPivot3);
                    context.Soils.Add(lSantaLuciaPivot4);
                    context.Soils.Add(lSantaLuciaPivot5);
                    context.SaveChanges();
                }
            }
            #endregion

            #region DCA El Paraiso Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmDCAElParaiso
                             select far).FirstOrDefault();

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCAElParaiso1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso1 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCAElParaisoPivot1 = new Soil
                    {
                        Name = Utils.NamePivotDCAElParaiso1,
                        Description = "Suelo del Pivot 1 en El Paraiso. Brunosoles profundos.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotDCAElParaiso1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCAElParaisoPivot1.HorizonList.Add(lHorizon1);
                    lDCAElParaisoPivot1.HorizonList.Add(lHorizon2);
                    lDCAElParaisoPivot1.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCAElParaiso2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso2 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso2 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso2 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCAElParaisoPivot2 = new Soil
                    {
                        Name = Utils.NamePivotDCAElParaiso2,
                        Description = "Suelo del Pivot 2 en El Paraiso. Brunosoles profundos.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotDCAElParaiso2,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCAElParaisoPivot2.HorizonList.Add(lHorizon1);
                    lDCAElParaisoPivot2.HorizonList.Add(lHorizon2);
                    lDCAElParaisoPivot2.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCAElParaiso3
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso3 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso3 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso3 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCAElParaisoPivot3 = new Soil
                    {
                        Name = Utils.NamePivotDCAElParaiso3,
                        Description = "Suelo del Pivot 3 en El Paraiso. Brunosoles profundos.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotDCAElParaiso3,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCAElParaisoPivot3.HorizonList.Add(lHorizon1);
                    lDCAElParaisoPivot3.HorizonList.Add(lHorizon2);
                    lDCAElParaisoPivot3.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 4
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCAElParaiso4
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso4 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso4 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso4 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCAElParaisoPivot4 = new Soil
                    {
                        Name = Utils.NamePivotDCAElParaiso4,
                        Description = "Suelo del Pivot 4 en El Paraiso. Brunosoles profundos.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotDCAElParaiso4,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCAElParaisoPivot4.HorizonList.Add(lHorizon1);
                    lDCAElParaisoPivot4.HorizonList.Add(lHorizon2);
                    lDCAElParaisoPivot4.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 5
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCAElParaiso5
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso5 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso5 + " 2"
                                 select hor).FirstOrDefault();
                    var lDCAElParaisoPivot5 = new Soil
                    {
                        Name = Utils.NamePivotDCAElParaiso5,
                        Description = "Suelo del Pivot 5 en El Paraiso. Suelo superficial con mucha grava.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 30,
                        ShortName = Utils.NamePivotDCAElParaiso5,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCAElParaisoPivot5.HorizonList.Add(lHorizon1);
                    lDCAElParaisoPivot5.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 6
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCAElParaiso6
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso6 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso6 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso6 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCAElParaisoPivot6 = new Soil
                    {
                        Name = Utils.NamePivotDCAElParaiso6,
                        Description = "Suelo del Pivot 6 en El Paraiso. Brunosoles profundos.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotDCAElParaiso6,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCAElParaisoPivot6.HorizonList.Add(lHorizon1);
                    lDCAElParaisoPivot6.HorizonList.Add(lHorizon2);
                    lDCAElParaisoPivot6.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 7
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCAElParaiso7
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso7 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso7 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCAElParaiso7 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCAElParaisoPivot7 = new Soil
                    {
                        Name = Utils.NamePivotDCAElParaiso7,
                        Description = "Suelo del Pivot 7 en El Paraiso. Brunosoles profundos.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 40,
                        HorizonList = new List<Horizon>(),
                        ShortName = Utils.NamePivotDCAElParaiso7,
                        FarmId = lFarm.FarmId,
                    };
                    lDCAElParaisoPivot7.HorizonList.Add(lHorizon1);
                    lDCAElParaisoPivot7.HorizonList.Add(lHorizon2);
                    lDCAElParaisoPivot7.HorizonList.Add(lHorizon3);
                    #endregion

                    context.Soils.Add(lDCAElParaisoPivot1);
                    context.Soils.Add(lDCAElParaisoPivot2);
                    context.Soils.Add(lDCAElParaisoPivot3);
                    context.Soils.Add(lDCAElParaisoPivot4);
                    context.Soils.Add(lDCAElParaisoPivot5);
                    context.Soils.Add(lDCAElParaisoPivot6);
                    context.Soils.Add(lDCAElParaisoPivot7);
                    context.SaveChanges();
                }
            }
            #endregion
            #region DCA San Jose Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmDCASanJose
                             select far).FirstOrDefault();

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCASanJose1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCASanJose1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCASanJose1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCASanJose1 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCASanJosePivot1 = new Soil
                    {
                        Name = Utils.NamePivotDCASanJose1,
                        Description = "Suelo del Pivot 1 en San Jose. Unidad Bequlo con incidencia de Villa Soriano.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 55,
                        ShortName = Utils.NamePivotDCASanJose1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCASanJosePivot1.HorizonList.Add(lHorizon1);
                    lDCASanJosePivot1.HorizonList.Add(lHorizon2);
                    lDCASanJosePivot1.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCASanJose2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCASanJose2 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCASanJose2 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCASanJose2 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCASanJosePivot2 = new Soil
                    {
                        Name = Utils.NamePivotDCASanJose2,
                        Description = "Suelo del Pivot 2 en San Jose. Unidad Bequlo con incidencia de Villa Soriano.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 55,
                        ShortName = Utils.NamePivotDCASanJose2,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCASanJosePivot2.HorizonList.Add(lHorizon1);
                    lDCASanJosePivot2.HorizonList.Add(lHorizon2);
                    lDCASanJosePivot2.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCASanJose3
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCASanJose3 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCASanJose3 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCASanJose3 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCASanJosePivot3 = new Soil
                    {
                        Name = Utils.NamePivotDCASanJose3,
                        Description = "Suelo del Pivot 3 en San Jose. Unidad Bequlo con incidencia de Villa Soriano.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 55,
                        ShortName = Utils.NamePivotDCASanJose3,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCASanJosePivot3.HorizonList.Add(lHorizon1);
                    lDCASanJosePivot3.HorizonList.Add(lHorizon2);
                    lDCASanJosePivot3.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 4
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCASanJose4
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCASanJose4 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCASanJose4 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCASanJose4 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCASanJosePivot4 = new Soil
                    {
                        Name = Utils.NamePivotDCASanJose4,
                        Description = "Suelo del Pivot 4 en San Jose. Unidad Bequlo con incidencia de Villa Soriano.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 55,
                        ShortName = Utils.NamePivotDCASanJose4,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCASanJosePivot4.HorizonList.Add(lHorizon1);
                    lDCASanJosePivot4.HorizonList.Add(lHorizon2);
                    lDCASanJosePivot4.HorizonList.Add(lHorizon3);
                    #endregion

                    context.Soils.Add(lDCASanJosePivot1);
                    context.Soils.Add(lDCASanJosePivot2);
                    context.Soils.Add(lDCASanJosePivot3);
                    context.Soils.Add(lDCASanJosePivot4);
                    context.SaveChanges();
                }
            }
            #endregion
            #region DCA La Perdiz Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmDCALaPerdiz
                             select far).FirstOrDefault();
                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz1 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCALaPerdizPivot1 = new Soil
                    {
                        Name = Utils.NamePivotDCALaPerdiz1,
                        Description = "Suelo del Pivot 1 en La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDCALaPerdiz1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCALaPerdizPivot1.HorizonList.Add(lHorizon1);
                    lDCALaPerdizPivot1.HorizonList.Add(lHorizon2);
                    lDCALaPerdizPivot1.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz2 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz2 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz2 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCALaPerdizPivot2 = new Soil
                    {
                        Name = Utils.NamePivotDCALaPerdiz2,
                        Description = "Suelo del Pivot 2 en La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDCALaPerdiz2,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCALaPerdizPivot2.HorizonList.Add(lHorizon1);
                    lDCALaPerdizPivot2.HorizonList.Add(lHorizon2);
                    lDCALaPerdizPivot2.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz3
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz3 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz3 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz3 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCALaPerdizPivot3 = new Soil
                    {
                        Name = Utils.NamePivotDCALaPerdiz3,
                        Description = "Suelo del Pivot 3 en La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDCALaPerdiz3,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCALaPerdizPivot3.HorizonList.Add(lHorizon1);
                    lDCALaPerdizPivot3.HorizonList.Add(lHorizon2);
                    lDCALaPerdizPivot3.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 4
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz4
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz4 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz4 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz4 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCALaPerdizPivot4 = new Soil
                    {
                        Name = Utils.NamePivotDCALaPerdiz4,
                        Description = "Suelo del Pivot 4 en La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDCALaPerdiz4,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCALaPerdizPivot4.HorizonList.Add(lHorizon1);
                    lDCALaPerdizPivot4.HorizonList.Add(lHorizon2);
                    lDCALaPerdizPivot4.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 5
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz5
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz5 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz5 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz5 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCALaPerdizPivot5 = new Soil
                    {
                        Name = Utils.NamePivotDCALaPerdiz5,
                        Description = "Suelo del Pivot 5 en La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDCALaPerdiz5,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCALaPerdizPivot5.HorizonList.Add(lHorizon1);
                    lDCALaPerdizPivot5.HorizonList.Add(lHorizon2);
                    lDCALaPerdizPivot5.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 6
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz6
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz6 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz6 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz6 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCALaPerdizPivot6 = new Soil
                    {
                        Name = Utils.NamePivotDCALaPerdiz6,
                        Description = "Suelo del Pivot 6 en La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDCALaPerdiz6,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCALaPerdizPivot6.HorizonList.Add(lHorizon1);
                    lDCALaPerdizPivot6.HorizonList.Add(lHorizon2);
                    lDCALaPerdizPivot6.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 7
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz7
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz7 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz7 + " 2"
                                 select hor).FirstOrDefault();
                    var lDCALaPerdizPivot7 = new Soil
                    {
                        Name = Utils.NamePivotDCALaPerdiz7,
                        Description = "Suelo del Pivot 7 en La Perdiz. Brunosoles superficiales c/grava.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotDCALaPerdiz7,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCALaPerdizPivot7.HorizonList.Add(lHorizon1);
                    lDCALaPerdizPivot7.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 8
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz8
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz8 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz8 + " 2"
                                 select hor).FirstOrDefault();
                    var lDCALaPerdizPivot8 = new Soil
                    {
                        Name = Utils.NamePivotDCALaPerdiz8,
                        Description = "Suelo del Pivot 8 en La Perdiz. Brunosoles superficiales c/grava.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotDCALaPerdiz8,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCALaPerdizPivot8.HorizonList.Add(lHorizon1);
                    lDCALaPerdizPivot8.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 9
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz9
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz9 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz9 + " 2"
                                 select hor).FirstOrDefault();
                    var lDCALaPerdizPivot9 = new Soil
                    {
                        Name = Utils.NamePivotDCALaPerdiz9,
                        Description = "Suelo del Pivot 9 en La Perdiz. Brunosoles superficiales c/grava.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotDCALaPerdiz9,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCALaPerdizPivot9.HorizonList.Add(lHorizon1);
                    lDCALaPerdizPivot9.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 10a
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz10a
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz10a + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz10a + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz10a + " 3"
                                 select hor).FirstOrDefault();
                    var lDCALaPerdizPivot10a = new Soil
                    {
                        Name = Utils.NamePivotDCALaPerdiz10a,
                        Description = "Suelo del Pivot 10a en La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDCALaPerdiz10a,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCALaPerdizPivot10a.HorizonList.Add(lHorizon1);
                    lDCALaPerdizPivot10a.HorizonList.Add(lHorizon2);
                    lDCALaPerdizPivot10a.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 10b
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz10b
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz10b + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz10b + " 2"
                                 select hor).FirstOrDefault();
                    var lDCALaPerdizPivot10b = new Soil
                    {
                        Name = Utils.NamePivotDCALaPerdiz10b,
                        Description = "Suelo del Pivot 10b en La Perdiz. Brunosoles superficiales c/grava.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 40,
                        HorizonList = new List<Horizon>(),
                        ShortName = Utils.NamePivotDCALaPerdiz10b,
                        FarmId = lFarm.FarmId,
                    };
                    lDCALaPerdizPivot10b.HorizonList.Add(lHorizon1);
                    lDCALaPerdizPivot10b.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 11
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz11
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz11 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz11 + " 2"
                                 select hor).FirstOrDefault();
                    var lDCALaPerdizPivot11 = new Soil
                    {
                        Name = Utils.NamePivotDCALaPerdiz11,
                        Description = "Suelo del Pivot 11 en La Perdiz. Brunosoles superficiales c/grava.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotDCALaPerdiz11,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCALaPerdizPivot11.HorizonList.Add(lHorizon1);
                    lDCALaPerdizPivot11.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 12
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz12
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz12 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz12 + " 2"
                                 select hor).FirstOrDefault();
                    var lDCALaPerdizPivot12 = new Soil
                    {
                        Name = Utils.NamePivotDCALaPerdiz12,
                        Description = "Suelo del Pivot 12 en La Perdiz. Brunosoles superficiales c/grava.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotDCALaPerdiz12,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCALaPerdizPivot12.HorizonList.Add(lHorizon1);
                    lDCALaPerdizPivot12.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 13
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz13
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz13 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz13 + " 2"
                                 select hor).FirstOrDefault();
                    var lDCALaPerdizPivot13 = new Soil
                    {
                        Name = Utils.NamePivotDCALaPerdiz13,
                        Description = "Suelo del Pivot 13 en La Perdiz. Brunosoles superficiales c/grava.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotDCALaPerdiz13,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCALaPerdizPivot13.HorizonList.Add(lHorizon1);
                    lDCALaPerdizPivot13.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 14
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz14
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz14 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz14 + " 2"
                                 select hor).FirstOrDefault();
                    var lDCALaPerdizPivot14 = new Soil
                    {
                        Name = Utils.NamePivotDCALaPerdiz14,
                        Description = "Suelo del Pivot 14 en La Perdiz. Brunosoles superficiales c/grava.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotDCALaPerdiz14,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCALaPerdizPivot14.HorizonList.Add(lHorizon1);
                    lDCALaPerdizPivot14.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 15
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz15
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz15 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz15 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDCALaPerdiz15 + " 3"
                                 select hor).FirstOrDefault();
                    var lDCALaPerdizPivot15 = new Soil
                    {
                        Name = Utils.NamePivotDCALaPerdiz15,
                        Description = "Suelo del Pivot 15 en La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDCALaPerdiz15,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDCALaPerdizPivot15.HorizonList.Add(lHorizon1);
                    lDCALaPerdizPivot15.HorizonList.Add(lHorizon2);
                    lDCALaPerdizPivot15.HorizonList.Add(lHorizon3);
                    #endregion

                    context.Soils.Add(lDCALaPerdizPivot1);
                    context.Soils.Add(lDCALaPerdizPivot2);
                    context.Soils.Add(lDCALaPerdizPivot3);
                    context.Soils.Add(lDCALaPerdizPivot4);
                    context.Soils.Add(lDCALaPerdizPivot5);
                    context.Soils.Add(lDCALaPerdizPivot6);
                    context.Soils.Add(lDCALaPerdizPivot7);
                    context.Soils.Add(lDCALaPerdizPivot8);
                    context.Soils.Add(lDCALaPerdizPivot9);
                    context.Soils.Add(lDCALaPerdizPivot10a);
                    context.Soils.Add(lDCALaPerdizPivot10b);
                    context.Soils.Add(lDCALaPerdizPivot11);
                    context.Soils.Add(lDCALaPerdizPivot12);
                    context.Soils.Add(lDCALaPerdizPivot13);
                    context.Soils.Add(lDCALaPerdizPivot14);
                    context.Soils.Add(lDCALaPerdizPivot15);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Del Lago - San Pedro Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmDelLagoSanPedro
                             select far).FirstOrDefault();

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro1 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot1 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro1,
                        Description = "Suelo del Pivot 1 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot1.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot1.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro2 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro2 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot2 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro2,
                        Description = "Suelo del Pivot 2 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro2,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot2.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot2.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro3
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro3 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro3 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot3 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro3,
                        Description = "Suelo del Pivot 3 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro3,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot3.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot3.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 4
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro4
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro4 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro4 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot4 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro4,
                        Description = "Suelo del Pivot 4 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro4,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot4.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot4.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 5
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro5
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro5 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro5 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot5 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro5,
                        Description = "Suelo del Pivot 5 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro5,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot5.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot5.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 6
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro6
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro6 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro6 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot6 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro6,
                        Description = "Suelo del Pivot 6 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro6,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot6.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot6.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 7
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro7
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro7 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro7 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot7 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro7,
                        Description = "Suelo del Pivot 7 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 7),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro7,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot7.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot7.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 8
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro8
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro8 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro8 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot8 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro8,
                        Description = "Suelo del Pivot 8 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 8),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro8,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot8.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot8.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 9
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro9
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro9 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro9 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot9 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro9,
                        Description = "Suelo del Pivot 9 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro9,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot9.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot9.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 10
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro10
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro10 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro10 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot10 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro10,
                        Description = "Suelo del Pivot 10 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro10,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot10.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot10.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 11
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro11
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro11 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro11 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot11 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro11,
                        Description = "Suelo del Pivot 11 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro11,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot11.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot11.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 12
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro12
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro12 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro12 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot12 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro12,
                        Description = "Suelo del Pivot 12 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro12,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot12.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot12.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 13
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro13
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro13 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro13 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot13 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro13,
                        Description = "Suelo del Pivot 13 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro13,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot13.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot13.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 14
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro14
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro14 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro14 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot14 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro14,
                        Description = "Suelo del Pivot 14 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro14,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot14.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot14.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 15
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro15
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro15 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro15 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot15 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro15,
                        Description = "Suelo del Pivot 15 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro15,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot15.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot15.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 16
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro16
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro16 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro16 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot16 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro16,
                        Description = "Suelo del Pivot 16 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro16,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot16.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot16.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 17
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro17
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro17 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoSanPedro17 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoSanPedroPivot17 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoSanPedro17,
                        Description = "Suelo del Pivot 17 en Del Lago - San Pedro.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoSanPedro17,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot17.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot17.HorizonList.Add(lHorizon2);
                    #endregion

                    //context.Soils.Add(lBase);
                    context.Soils.Add(lDelLagoSanPedroPivot1);
                    context.Soils.Add(lDelLagoSanPedroPivot2);
                    context.Soils.Add(lDelLagoSanPedroPivot3);
                    context.Soils.Add(lDelLagoSanPedroPivot4);
                    context.Soils.Add(lDelLagoSanPedroPivot5);
                    context.Soils.Add(lDelLagoSanPedroPivot6);
                    context.Soils.Add(lDelLagoSanPedroPivot7);
                    context.Soils.Add(lDelLagoSanPedroPivot8);
                    context.Soils.Add(lDelLagoSanPedroPivot9);
                    context.Soils.Add(lDelLagoSanPedroPivot10);
                    context.Soils.Add(lDelLagoSanPedroPivot11);
                    context.Soils.Add(lDelLagoSanPedroPivot12);
                    context.Soils.Add(lDelLagoSanPedroPivot13);
                    context.Soils.Add(lDelLagoSanPedroPivot14);
                    context.Soils.Add(lDelLagoSanPedroPivot15);
                    context.Soils.Add(lDelLagoSanPedroPivot16);
                    context.Soils.Add(lDelLagoSanPedroPivot17);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Del Lago - El Mirador Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmDelLagoElMirador
                             select far).FirstOrDefault();

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador1 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador1 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador1 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador1 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot1 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador1,
                        Description = "Suelo del Pivot 1 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot1.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot1.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot1.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot1.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador2 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador2 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador2 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador2 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot2 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador2,
                        Description = "Suelo del Pivot 2 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador2,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot2.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot2.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot2.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot2.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador3
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador3 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador3 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador3 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador3 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot3 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador3,
                        Description = "Suelo del Pivot 3 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador3,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot3.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot3.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot3.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot3.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 4
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador4
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador4 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador4 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador4 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador4 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot4 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador4,
                        Description = "Suelo del Pivot 4 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador4,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot4.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot4.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot4.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot4.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 5
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador5
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador5 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador5 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador5 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador5 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot5 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador5,
                        Description = "Suelo del Pivot 5 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador5,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot5.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot5.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot5.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot5.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 6
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador6
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador6 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador6 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador6 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador6 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot6 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador6,
                        Description = "Suelo del Pivot 6 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador6,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot6.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot6.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot6.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot6.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 7
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador7
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador7 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador7 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador7 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador7 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot7 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador7,
                        Description = "Suelo del Pivot 7 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador7,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot7.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot7.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot7.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot7.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 8
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador8
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador8 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador8 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador8 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador8 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot8 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador8,
                        Description = "Suelo del Pivot 8 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador8,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot8.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot8.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot8.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot8.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 9
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador9
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador9 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador9 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador9 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador9 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot9 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador9,
                        Description = "Suelo del Pivot 9 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador9,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot9.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot9.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot9.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot9.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 10
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador10
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador10 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador10 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador10 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador10 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot10 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador10,
                        Description = "Suelo del Pivot 10 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador10,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot10.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot10.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot10.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot10.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 11
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador11
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador11 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador11 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador11 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador11 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot11 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador11,
                        Description = "Suelo del Pivot 11 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador11,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot11.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot11.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot11.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot11.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 12
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador12
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador12 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador12 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador12 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador12 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot12 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador12,
                        Description = "Suelo del Pivot 12 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador12,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot12.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot12.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot12.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot12.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 13
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador13
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador13 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador13 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador13 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador13 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot13 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador13,
                        Description = "Suelo del Pivot 13 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador13,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot13.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot13.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot13.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot13.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 14
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador14
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador14 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador14 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador14 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador14 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot14 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador14,
                        Description = "Suelo del Pivot 14 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador14,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot14.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot14.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot14.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot14.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 15
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador15
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador15 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador15 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador15 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador15 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot15 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador15,
                        Description = "Suelo del Pivot 15 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador15,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot15.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot15.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot15.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot15.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot Chaja 01
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMiradorChaja1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMiradorChaja1 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMiradorChaja1 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMiradorChaja1 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMiradorChaja1 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivotChaja1 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMiradorChaja1,
                        Description = "Suelo del Pivot Chaja 1 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMiradorChaja1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivotChaja1.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivotChaja1.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivotChaja1.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivotChaja1.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot Chaja 02
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMiradorChaja2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMiradorChaja2 + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMiradorChaja2 + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMiradorChaja2 + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMiradorChaja2 + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivotChaja2 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMiradorChaja2,
                        Description = "Suelo del Pivot Chaja 2 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMiradorChaja2,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivotChaja2.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivotChaja2.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivotChaja2.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivotChaja2.HorizonList.Add(lHorizon4);
                    #endregion

                    #region Pivot 1b
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador1b
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador1b + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador1b + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador1b + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador1b + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot1b = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador1b,
                        Description = "Suelo del Pivot 1 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador1b,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot1b.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot1b.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot1b.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot1b.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 2b
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador2b
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador2b + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador2b + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador2b + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador2b + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot2b = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador2b,
                        Description = "Suelo del Pivot 2 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador2b,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot2b.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot2b.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot2b.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot2b.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 3b
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador3b
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador3b + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador3b + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador3b + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador3b + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot3b = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador3b,
                        Description = "Suelo del Pivot 3 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador3b,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot3b.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot3b.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot3b.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot3b.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 4b
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador4b
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador4b + " A"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador4b + " Bt"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador4b + " BCk"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador4b + " Ck"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot4b = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador4b,
                        Description = "Suelo del Pivot 4 en Del Lago - El Mirador. Suelos profundos, Vertisoles de alto potencial productivo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 23),
                        DepthLimit = 50,
                        ShortName = Utils.NamePivotDelLagoElMirador4b,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot4b.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot4b.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivot4b.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivot4b.HorizonList.Add(lHorizon4);
                    #endregion


                    context.Soils.Add(lDelLagoElMiradorPivot1);
                    context.Soils.Add(lDelLagoElMiradorPivot2);
                    context.Soils.Add(lDelLagoElMiradorPivot3);
                    context.Soils.Add(lDelLagoElMiradorPivot4);
                    context.Soils.Add(lDelLagoElMiradorPivot5);
                    context.Soils.Add(lDelLagoElMiradorPivot6);
                    context.Soils.Add(lDelLagoElMiradorPivot7);
                    context.Soils.Add(lDelLagoElMiradorPivot8);
                    context.Soils.Add(lDelLagoElMiradorPivot9);
                    context.Soils.Add(lDelLagoElMiradorPivot10);
                    context.Soils.Add(lDelLagoElMiradorPivot11);
                    context.Soils.Add(lDelLagoElMiradorPivot12);
                    context.Soils.Add(lDelLagoElMiradorPivot13);
                    context.Soils.Add(lDelLagoElMiradorPivot14);
                    context.Soils.Add(lDelLagoElMiradorPivot15);
                    context.Soils.Add(lDelLagoElMiradorPivotChaja1);
                    context.Soils.Add(lDelLagoElMiradorPivotChaja2);
                    context.Soils.Add(lDelLagoElMiradorPivot1b);
                    context.Soils.Add(lDelLagoElMiradorPivot2b);
                    context.Soils.Add(lDelLagoElMiradorPivot3b);
                    context.Soils.Add(lDelLagoElMiradorPivot4b);
                    context.SaveChanges();
                }
            }
            #endregion

            #region GMO - La Palma Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmGMOLaPalma
                             select far).FirstOrDefault();
                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma1 + " 3"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma1 + " 4"
                                 select hor).FirstOrDefault();
                    var lGMOLaPalmaPivot1 = new Soil
                    {
                        Name = Utils.NamePivotGMOLaPalma1,
                        Description = "Suelo del Pivot 1 en GMO La Palma. "
                         + "Vertisol.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOLaPalma1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOLaPalmaPivot1.HorizonList.Add(lHorizon1);
                    lGMOLaPalmaPivot1.HorizonList.Add(lHorizon2);
                    lGMOLaPalmaPivot1.HorizonList.Add(lHorizon3);
                    lGMOLaPalmaPivot1.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma2 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma2 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma2 + " 3"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma2 + " 4"
                                 select hor).FirstOrDefault();
                    var lGMOLaPalmaPivot2 = new Soil
                    {
                        Name = Utils.NamePivotGMOLaPalma2,
                        Description = "Suelo del Pivot 2 en GMO - La Palma. "
                         + "Vertisol.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOLaPalma2,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOLaPalmaPivot2.HorizonList.Add(lHorizon1);
                    lGMOLaPalmaPivot2.HorizonList.Add(lHorizon2);
                    lGMOLaPalmaPivot2.HorizonList.Add(lHorizon3);
                    lGMOLaPalmaPivot2.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma3
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma3 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma3 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma3 + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOLaPalmaPivot3 = new Soil
                    {
                        Name = Utils.NamePivotGMOLaPalma3,
                        Description = "Suelo del Pivot 3 en La Palma. "
                         + "Vertisol.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOLaPalma3,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOLaPalmaPivot3.HorizonList.Add(lHorizon1);
                    lGMOLaPalmaPivot3.HorizonList.Add(lHorizon2);
                    lGMOLaPalmaPivot3.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 4
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma4
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma4 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma4 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma4 + " 3"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma4 + " 4"
                                 select hor).FirstOrDefault();
                    var lGMOLaPalmaPivot4 = new Soil
                    {
                        Name = Utils.NamePivotGMOLaPalma4,
                        Description = "Suelo del Pivot 4 en La Palma. "
                         + "Brunosol.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOLaPalma4,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOLaPalmaPivot4.HorizonList.Add(lHorizon1);
                    lGMOLaPalmaPivot4.HorizonList.Add(lHorizon2);
                    lGMOLaPalmaPivot4.HorizonList.Add(lHorizon3);
                    lGMOLaPalmaPivot4.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 5
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma5
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma5 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma5 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma5 + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOLaPalmaPivot5 = new Soil
                    {
                        Name = Utils.NamePivotGMOLaPalma5,
                        Description = "Suelo del Pivot 5 en GMO - La Palma. "
                         + "Brunosol.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOLaPalma5,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOLaPalmaPivot5.HorizonList.Add(lHorizon1);
                    lGMOLaPalmaPivot5.HorizonList.Add(lHorizon2);
                    lGMOLaPalmaPivot5.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 1.1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma1_1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma1_1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma1_1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma1_1 + " 3"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma1_1 + " 4"
                                 select hor).FirstOrDefault();
                    var lGMOLaPalmaPivot1_1 = new Soil
                    {
                        Name = Utils.NamePivotGMOLaPalma1_1,
                        Description = "Suelo del Pivot 1.1 en GMO La Palma. "
                         + "Vertisol.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOLaPalma1_1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOLaPalmaPivot1_1.HorizonList.Add(lHorizon1);
                    lGMOLaPalmaPivot1_1.HorizonList.Add(lHorizon2);
                    lGMOLaPalmaPivot1_1.HorizonList.Add(lHorizon3);
                    lGMOLaPalmaPivot1_1.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 2.1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma2_1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma2_1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma2_1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma2_1 + " 3"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma2_1 + " 4"
                                 select hor).FirstOrDefault();
                    var lGMOLaPalmaPivot2_1 = new Soil
                    {
                        Name = Utils.NamePivotGMOLaPalma2_1,
                        Description = "Suelo del Pivot 2.1 en GMO - La Palma. "
                         + "Vertisol.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOLaPalma2_1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOLaPalmaPivot2_1.HorizonList.Add(lHorizon1);
                    lGMOLaPalmaPivot2_1.HorizonList.Add(lHorizon2);
                    lGMOLaPalmaPivot2_1.HorizonList.Add(lHorizon3);
                    lGMOLaPalmaPivot2_1.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 3.1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma3_1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma3_1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma3_1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma3_1 + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOLaPalmaPivot3_1 = new Soil
                    {
                        Name = Utils.NamePivotGMOLaPalma3_1,
                        Description = "Suelo del Pivot 3.1 en La Palma. "
                         + "Vertisol.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOLaPalma3_1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOLaPalmaPivot3_1.HorizonList.Add(lHorizon1);
                    lGMOLaPalmaPivot3_1.HorizonList.Add(lHorizon2);
                    lGMOLaPalmaPivot3_1.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 4.1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma4_1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma4_1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma4_1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOLaPalma4_1 + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOLaPalmaPivot4_1 = new Soil
                    {
                        Name = Utils.NamePivotGMOLaPalma4_1,
                        Description = "Suelo del Pivot 4.1 en La Palma. "
                         + "Brunosol.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOLaPalma4_1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOLaPalmaPivot4_1.HorizonList.Add(lHorizon1);
                    lGMOLaPalmaPivot4_1.HorizonList.Add(lHorizon2);
                    lGMOLaPalmaPivot4_1.HorizonList.Add(lHorizon3);
                    #endregion

                    context.Soils.Add(lGMOLaPalmaPivot1);
                    context.Soils.Add(lGMOLaPalmaPivot2);
                    context.Soils.Add(lGMOLaPalmaPivot3);
                    context.Soils.Add(lGMOLaPalmaPivot4);
                    context.Soils.Add(lGMOLaPalmaPivot5);
                    context.Soils.Add(lGMOLaPalmaPivot1_1);
                    context.Soils.Add(lGMOLaPalmaPivot2_1);
                    context.Soils.Add(lGMOLaPalmaPivot3_1);
                    context.Soils.Add(lGMOLaPalmaPivot4_1);
                    context.SaveChanges();
                }
            }
            #endregion
            #region GMO - El Tacuru Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmGMOElTacuru
                             select far).FirstOrDefault();

                    #region Pivot 1a
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru1a
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru1a + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru1a + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru1a + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOElTacuruPivot1a = new Soil
                    {
                        Name = Utils.NamePivotGMOElTacuru1a,
                        Description = "Suelo del Pivot 1a en GMO - El Tacuru. "
                         + "Itapebi-TA. Vertisol Haplicos mod prof.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 30),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOElTacuru1a,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOElTacuruPivot1a.HorizonList.Add(lHorizon1);
                    lGMOElTacuruPivot1a.HorizonList.Add(lHorizon2);
                    lGMOElTacuruPivot1a.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 1b
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru1b
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru1b + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru1b + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru1b + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOElTacuruPivot1b = new Soil
                    {
                        Name = Utils.NamePivotGMOElTacuru1b,
                        Description = "Suelo del Pivot 1b en GMO - El Tacuru. "
                         + "Itapebi-TA. Vertisol Haplicos mod prof.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 30),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOElTacuru1b,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOElTacuruPivot1b.HorizonList.Add(lHorizon1);
                    lGMOElTacuruPivot1b.HorizonList.Add(lHorizon2);
                    lGMOElTacuruPivot1b.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 2a
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru2a
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru2a + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru2a + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru2a + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOElTacuruPivot2a = new Soil
                    {
                        Name = Utils.NamePivotGMOElTacuru2a,
                        Description = "Suelo del Pivot 2a en GMO - El Tacuru. "
                         + "Itapebi-TA. Vertisol Haplicos mod prof.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 30),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOElTacuru2a,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOElTacuruPivot2a.HorizonList.Add(lHorizon1);
                    lGMOElTacuruPivot2a.HorizonList.Add(lHorizon2);
                    lGMOElTacuruPivot2a.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 2b
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru2b
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru2b + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru2b + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru2b + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOElTacuruPivot2b = new Soil
                    {
                        Name = Utils.NamePivotGMOElTacuru2b,
                        Description = "Suelo del Pivot 2b en GMO - El Tacuru. "
                         + "Itapebi-TA. Vertisol Haplicos mod prof.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 30),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOElTacuru2b,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOElTacuruPivot2b.HorizonList.Add(lHorizon1);
                    lGMOElTacuruPivot2b.HorizonList.Add(lHorizon2);
                    lGMOElTacuruPivot2b.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 3a
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru3a
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru3a + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru3a + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru3a + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOElTacuruPivot3a = new Soil
                    {
                        Name = Utils.NamePivotGMOElTacuru3a,
                        Description = "Suelo del Pivot 3a en GMO - El Tacuru. "
                         + "Itapebi-TA. Vertisol Haplicos mod prof.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 30),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOElTacuru3a,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOElTacuruPivot3a.HorizonList.Add(lHorizon1);
                    lGMOElTacuruPivot3a.HorizonList.Add(lHorizon2);
                    lGMOElTacuruPivot3a.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 3b
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru3b
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru3b + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru3b + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru3b + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOElTacuruPivot3b = new Soil
                    {
                        Name = Utils.NamePivotGMOElTacuru3b,
                        Description = "Suelo del Pivot 3b en GMO - El Tacuru. "
                         + "Itapebi-TA. Vertisol Haplicos mod prof.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 30),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOElTacuru3b,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOElTacuruPivot3b.HorizonList.Add(lHorizon1);
                    lGMOElTacuruPivot3b.HorizonList.Add(lHorizon2);
                    lGMOElTacuruPivot3b.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 4
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru4
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru4 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru4 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru4 + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOElTacuruPivot4 = new Soil
                    {
                        Name = Utils.NamePivotGMOElTacuru4,
                        Description = "Suelo del Pivot 4 en GMO - El Tacuru. "
                         + "Itapebi-TA. Vertisol Haplicos mod prof.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 30),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOElTacuru4,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOElTacuruPivot4.HorizonList.Add(lHorizon1);
                    lGMOElTacuruPivot4.HorizonList.Add(lHorizon2);
                    lGMOElTacuruPivot4.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 5
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru5
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru5 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru5 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru5 + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOElTacuruPivot5 = new Soil
                    {
                        Name = Utils.NamePivotGMOElTacuru5,
                        Description = "Suelo del Pivot 5 en GMO - El Tacuru. "
                         + "Itapebi-TA. Vertisol Haplicos mod prof.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 30),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOElTacuru5,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOElTacuruPivot5.HorizonList.Add(lHorizon1);
                    lGMOElTacuruPivot5.HorizonList.Add(lHorizon2);
                    lGMOElTacuruPivot5.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 6
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru6
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru6 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru6 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru6 + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOElTacuruPivot6 = new Soil
                    {
                        Name = Utils.NamePivotGMOElTacuru6,
                        Description = "Suelo del Pivot 6 en GMO - El Tacuru. "
                         + "Itapebi-TA. Vertisol Haplicos mod prof.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 30),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOElTacuru6,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOElTacuruPivot6.HorizonList.Add(lHorizon1);
                    lGMOElTacuruPivot6.HorizonList.Add(lHorizon2);
                    lGMOElTacuruPivot6.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 7
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru7
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru7 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru7 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru7 + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOElTacuruPivot7 = new Soil
                    {
                        Name = Utils.NamePivotGMOElTacuru7,
                        Description = "Suelo del Pivot 7 en GMO - El Tacuru. "
                         + "Itapebi-TA. Vertisol Haplicos mod prof.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(7016, 09, 30),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOElTacuru7,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOElTacuruPivot7.HorizonList.Add(lHorizon1);
                    lGMOElTacuruPivot7.HorizonList.Add(lHorizon2);
                    lGMOElTacuruPivot7.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 8
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru8
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru8 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru8 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru8 + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOElTacuruPivot8 = new Soil
                    {
                        Name = Utils.NamePivotGMOElTacuru8,
                        Description = "Suelo del Pivot 8 en GMO - El Tacuru. "
                         + "Itapebi-TA. Vertisol Haplicos mod prof.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 30),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOElTacuru8,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOElTacuruPivot8.HorizonList.Add(lHorizon1);
                    lGMOElTacuruPivot8.HorizonList.Add(lHorizon2);
                    lGMOElTacuruPivot8.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 9
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru9
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru9 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru9 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru9 + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOElTacuruPivot9 = new Soil
                    {
                        Name = Utils.NamePivotGMOElTacuru9,
                        Description = "Suelo del Pivot 9 en GMO - El Tacuru. "
                         + "Itapebi-TA. Vertisol Haplicos mod prof.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 30),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOElTacuru9,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOElTacuruPivot9.HorizonList.Add(lHorizon1);
                    lGMOElTacuruPivot9.HorizonList.Add(lHorizon2);
                    lGMOElTacuruPivot9.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 10
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru10
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru10 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru10 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGMOElTacuru10 + " 3"
                                 select hor).FirstOrDefault();
                    var lGMOElTacuruPivot10 = new Soil
                    {
                        Name = Utils.NamePivotGMOElTacuru10,
                        Description = "Suelo del Pivot 10 en GMO - El Tacuru. "
                         + "Itapebi-TA. Vertisol Haplicos mod prof.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 30),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGMOElTacuru10,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOElTacuruPivot10.HorizonList.Add(lHorizon1);
                    lGMOElTacuruPivot10.HorizonList.Add(lHorizon2);
                    lGMOElTacuruPivot10.HorizonList.Add(lHorizon3);
                    #endregion

                    context.Soils.Add(lGMOElTacuruPivot1a);
                    context.Soils.Add(lGMOElTacuruPivot1b);
                    context.Soils.Add(lGMOElTacuruPivot2a);
                    context.Soils.Add(lGMOElTacuruPivot2b);
                    context.Soils.Add(lGMOElTacuruPivot3a);
                    context.Soils.Add(lGMOElTacuruPivot3b);
                    context.Soils.Add(lGMOElTacuruPivot4);
                    context.Soils.Add(lGMOElTacuruPivot5);
                    context.Soils.Add(lGMOElTacuruPivot6);
                    context.Soils.Add(lGMOElTacuruPivot7);
                    context.Soils.Add(lGMOElTacuruPivot8);
                    context.Soils.Add(lGMOElTacuruPivot9);
                    context.Soils.Add(lGMOElTacuruPivot10);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Tres Marias Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmTresMarias
                             select far).FirstOrDefault();

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotTresMarias1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotTresMarias1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotTresMarias1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotTresMarias1 + " 3"
                                 select hor).FirstOrDefault();
                    var lTresMariasPivot1 = new Soil
                    {
                        Name = Utils.NamePivotTresMarias1,
                        Description = "Suelo del Pivot 1 en Tres Marias. ",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 12, 19),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotTresMarias1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lTresMariasPivot1.HorizonList.Add(lHorizon1);
                    lTresMariasPivot1.HorizonList.Add(lHorizon2);
                    lTresMariasPivot1.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotTresMarias2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotTresMarias2 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotTresMarias2 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotTresMarias2 + " 3"
                                 select hor).FirstOrDefault();
                    var lTresMariasPivot2 = new Soil
                    {
                        Name = Utils.NamePivotTresMarias2,
                        Description = "Suelo del Pivot 2 en Tres Marias. ",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 12, 19),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotTresMarias2,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lTresMariasPivot2.HorizonList.Add(lHorizon1);
                    lTresMariasPivot2.HorizonList.Add(lHorizon2);
                    lTresMariasPivot2.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotTresMarias3
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotTresMarias3 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotTresMarias3 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotTresMarias3 + " 3"
                                 select hor).FirstOrDefault();
                    var lTresMariasPivot3 = new Soil
                    {
                        Name = Utils.NamePivotTresMarias3,
                        Description = "Suelo del Pivot 3 en Tres Marias.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 12, 19),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotTresMarias3,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lTresMariasPivot3.HorizonList.Add(lHorizon1);
                    lTresMariasPivot3.HorizonList.Add(lHorizon2);
                    lTresMariasPivot3.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 4
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotTresMarias4
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotTresMarias4 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotTresMarias4 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotTresMarias4 + " 3"
                                 select hor).FirstOrDefault();
                    var lTresMariasPivot4 = new Soil
                    {
                        Name = Utils.NamePivotTresMarias4,
                        Description = "Suelo del Pivot 4 en Tres Marias.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 12, 19),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotTresMarias4,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lTresMariasPivot4.HorizonList.Add(lHorizon1);
                    lTresMariasPivot4.HorizonList.Add(lHorizon2);
                    lTresMariasPivot4.HorizonList.Add(lHorizon3);
                    #endregion

                    context.Soils.Add(lTresMariasPivot1);
                    context.Soils.Add(lTresMariasPivot2);
                    context.Soils.Add(lTresMariasPivot3);
                    context.Soils.Add(lTresMariasPivot4);
                    context.SaveChanges();
                }
            }
            #endregion
            #region La Rinconada Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmLaRinconada
                             select far).FirstOrDefault();

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaRinconada1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaRinconada1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaRinconada1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaRinconada1 + " 3"
                                 select hor).FirstOrDefault();
                    var lLaRinconadaPivot1 = new Soil
                    {
                        Name = Utils.NamePivotLaRinconada1,
                        Description = "Suelo del Pivot 1 en La Rinconada. "
                         + "Suelos Franco Arcillosos. Unidad Young.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 11, 10),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotLaRinconada1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lLaRinconadaPivot1.HorizonList.Add(lHorizon1);
                    lLaRinconadaPivot1.HorizonList.Add(lHorizon2);
                    lLaRinconadaPivot1.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaRinconada2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaRinconada2 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaRinconada2 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaRinconada2 + " 3"
                                 select hor).FirstOrDefault();
                    var lLaRinconadaPivot2 = new Soil
                    {
                        Name = Utils.NamePivotLaRinconada2,
                        Description = "Suelo del Pivot 2 en La Rinconada. "
                         + "Suelos Franco Arcillosos. Unidad Young.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 11, 10),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotLaRinconada2,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lLaRinconadaPivot2.HorizonList.Add(lHorizon1);
                    lLaRinconadaPivot2.HorizonList.Add(lHorizon2);
                    lLaRinconadaPivot2.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 3.1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaRinconada3_1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaRinconada3_1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaRinconada3_1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaRinconada3_1 + " 3"
                                 select hor).FirstOrDefault();
                    var lLaRinconadaPivot3_1 = new Soil
                    {
                        Name = Utils.NamePivotLaRinconada3_1,
                        Description = "Suelo del Pivot 3.1 en La Rinconada. "
                         + "Suelos Franco Arcillosos. Unidad Young.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 11, 10),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotLaRinconada3_1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lLaRinconadaPivot3_1.HorizonList.Add(lHorizon1);
                    lLaRinconadaPivot3_1.HorizonList.Add(lHorizon2);
                    lLaRinconadaPivot3_1.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 13.1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaRinconada13_1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaRinconada13_1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaRinconada13_1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaRinconada13_1 + " 3"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaRinconada13_1 + " 4"
                                 select hor).FirstOrDefault();
                    var lLaRinconadaPivot13_1 = new Soil
                    {
                        Name = Utils.NamePivotLaRinconada13_1,
                        Description = "Suelo del Pivot 13.1 en La Rinconada. "
                         + "Suelos Franco Arcillo Arenosos. Unidad Tres Bocas.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 11, 10),
                        DepthLimit = 40,
                        ShortName = Utils.NamePivotLaRinconada13_1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lLaRinconadaPivot13_1.HorizonList.Add(lHorizon1);
                    lLaRinconadaPivot13_1.HorizonList.Add(lHorizon2);
                    lLaRinconadaPivot13_1.HorizonList.Add(lHorizon3);
                    lLaRinconadaPivot13_1.HorizonList.Add(lHorizon4);
                    #endregion

                    context.Soils.Add(lLaRinconadaPivot1);
                    context.Soils.Add(lLaRinconadaPivot2);
                    context.Soils.Add(lLaRinconadaPivot3_1);
                    context.Soils.Add(lLaRinconadaPivot13_1);
                    context.SaveChanges();
                }
            }
            #endregion
            #region El Rincon Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElRincon)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmElRincon
                             select far).FirstOrDefault();

                    #region Pivot 1a
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElRincon1a
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElRincon1a + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElRincon1a + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElRincon1a + " 3"
                                 select hor).FirstOrDefault();
                    var lElRinconPivot1a = new Soil
                    {
                        Name = Utils.NamePivotElRincon1a,
                        Description = "Suelo del Pivot 1a en El Rincon. "
                         + "Suelo Franco Limoso. CONEAT 10.8b.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 10, 09),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotElRincon1a,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lElRinconPivot1a.HorizonList.Add(lHorizon1);
                    lElRinconPivot1a.HorizonList.Add(lHorizon2);
                    lElRinconPivot1a.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 1b
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElRincon1b
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElRincon1b + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElRincon1b + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElRincon1b + " 3"
                                 select hor).FirstOrDefault();
                    var lElRinconPivot1b = new Soil
                    {
                        Name = Utils.NamePivotElRincon1b,
                        Description = "Suelo del Pivot 1b en El Rincon. "
                         + "Suelo Franco Arcilloso. CONEAT 10.8b.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 10, 09),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotElRincon1b,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lElRinconPivot1b.HorizonList.Add(lHorizon1);
                    lElRinconPivot1b.HorizonList.Add(lHorizon2);
                    lElRinconPivot1b.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 2a
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElRincon2a
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElRincon2a + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElRincon2a + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElRincon2a + " 3"
                                 select hor).FirstOrDefault();
                    var lElRinconPivot2a = new Soil
                    {
                        Name = Utils.NamePivotElRincon2a,
                        Description = "Suelo del Pivot 2a en El Rincon. "
                         + "Suelo Franco Limoso. CONEAT 10.8b.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 10, 09),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotElRincon2a,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lElRinconPivot2a.HorizonList.Add(lHorizon1);
                    lElRinconPivot2a.HorizonList.Add(lHorizon2);
                    lElRinconPivot2a.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 2b
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElRincon2b
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElRincon2b + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElRincon2b + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElRincon2b + " 3"
                                 select hor).FirstOrDefault();
                    var lElRinconPivot2b = new Soil
                    {
                        Name = Utils.NamePivotElRincon2b,
                        Description = "Suelo del Pivot 2b en El Rincon. "
                         + "Suelo Franco Arcilloso. CONEAT 10.8b.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 10, 09),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotElRincon2b,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lElRinconPivot2b.HorizonList.Add(lHorizon1);
                    lElRinconPivot2b.HorizonList.Add(lHorizon2);
                    lElRinconPivot2b.HorizonList.Add(lHorizon3);
                    #endregion


                    context.Soils.Add(lElRinconPivot1a);
                    context.Soils.Add(lElRinconPivot1b);
                    context.Soils.Add(lElRinconPivot2a);
                    context.Soils.Add(lElRinconPivot2b);
                    context.SaveChanges();
                }
            }
            #endregion
            #region El Desafio Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElDesafio)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmElDesafio
                             select far).FirstOrDefault();

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElDesafio1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElDesafio1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElDesafio1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElDesafio1 + " 3"
                                 select hor).FirstOrDefault();
                    var lElDesafioPivot1 = new Soil
                    {
                        Name = Utils.NamePivotElDesafio1,
                        Description = "Suelo del Pivot 1 en El Desafio. "
                         + "CONEAT 10.8b Suelo arcillo limoso.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 10, 10),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotElDesafio1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lElDesafioPivot1.HorizonList.Add(lHorizon1);
                    lElDesafioPivot1.HorizonList.Add(lHorizon2);
                    lElDesafioPivot1.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElDesafio2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElDesafio2 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElDesafio2 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElDesafio2 + " 3"
                                 select hor).FirstOrDefault();
                    var lElDesafioPivot2 = new Soil
                    {
                        Name = Utils.NamePivotElDesafio2,
                        Description = "Suelo del Pivot 2 en El Desafio. "
                         + "CONEAT 10.8b Suelo arcillo limoso.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 10, 09),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotElDesafio2,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lElDesafioPivot2.HorizonList.Add(lHorizon1);
                    lElDesafioPivot2.HorizonList.Add(lHorizon2);
                    lElDesafioPivot2.HorizonList.Add(lHorizon3);
                    #endregion

                    context.Soils.Add(lElDesafioPivot1);
                    context.Soils.Add(lElDesafioPivot2);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Los Naranjales Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LosNaranjales)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmLosNaranjales
                             select far).FirstOrDefault();

                    #region Pivot 6aT3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLosNaranjales6aT3
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLosNaranjales6aT3 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLosNaranjales6aT3 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLosNaranjales6aT3 + " 3"
                                 select hor).FirstOrDefault();
                    var lLosNaranjalesPivot6aT3 = new Soil
                    {
                        Name = Utils.NamePivotLosNaranjales6aT3,
                        Description = "Suelo del Pivot 6aT3 en Los Naranjales. "
                         + "CONEAT 5.4 Suelo arcillo limoso.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 10, 30),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotLosNaranjales6aT3,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lLosNaranjalesPivot6aT3.HorizonList.Add(lHorizon1);
                    lLosNaranjalesPivot6aT3.HorizonList.Add(lHorizon2);
                    lLosNaranjalesPivot6aT3.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 6bT3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLosNaranjales6bT3
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLosNaranjales6bT3 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLosNaranjales6bT3 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLosNaranjales6bT3 + " 3"
                                 select hor).FirstOrDefault();
                    var lLosNaranjalesPivot6bT3 = new Soil
                    {
                        Name = Utils.NamePivotLosNaranjales6bT3,
                        Description = "Suelo del Pivot 6bT3 en Los Naranjales. "
                         + "CONEAT 5.4 Suelo arcillo limoso.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 10, 30),
                        DepthLimit = 45,
                        ShortName = Utils.NamePivotLosNaranjales6bT3,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lLosNaranjalesPivot6bT3.HorizonList.Add(lHorizon1);
                    lLosNaranjalesPivot6bT3.HorizonList.Add(lHorizon2);
                    lLosNaranjalesPivot6bT3.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 5aT5
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLosNaranjales5aT5
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLosNaranjales5aT5 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLosNaranjales5aT5 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLosNaranjales5aT5 + " 3"
                                 select hor).FirstOrDefault();
                    var lLosNaranjalesPivot5aT5 = new Soil
                    {
                        Name = Utils.NamePivotLosNaranjales5aT5,
                        Description = "Suelo del Pivot 5aT5 en Los Naranjales. "
                         + "CONEAT 5.02b Suelo arcillo limoso.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 10, 30),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotLosNaranjales5aT5,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lLosNaranjalesPivot5aT5.HorizonList.Add(lHorizon1);
                    lLosNaranjalesPivot5aT5.HorizonList.Add(lHorizon2);
                    lLosNaranjalesPivot5aT5.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 5bT5
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLosNaranjales5bT5
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLosNaranjales5bT5 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLosNaranjales5bT5 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLosNaranjales5bT5 + " 3"
                                 select hor).FirstOrDefault();
                    var lLosNaranjalesPivot5bT5 = new Soil
                    {
                        Name = Utils.NamePivotLosNaranjales5bT5,
                        Description = "Suelo del Pivot 5bT5 en Los Naranjales. "
                         + "CONEAT 5.02b Suelo arcillo limoso.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 10, 30),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotLosNaranjales5bT5,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lLosNaranjalesPivot5bT5.HorizonList.Add(lHorizon1);
                    lLosNaranjalesPivot5bT5.HorizonList.Add(lHorizon2);
                    lLosNaranjalesPivot5bT5.HorizonList.Add(lHorizon3);
                    #endregion

                    context.Soils.Add(lLosNaranjalesPivot6aT3);
                    context.Soils.Add(lLosNaranjalesPivot6bT3);
                    context.Soils.Add(lLosNaranjalesPivot5aT5);
                    context.Soils.Add(lLosNaranjalesPivot5bT5);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Santa Emilia Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaEmilia)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmSantaEmilia
                             select far).FirstOrDefault();

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaEmilia1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia1 + " 3"
                                 select hor).FirstOrDefault();
                    var lSantaEmiliaPivot1 = new Soil
                    {
                        Name = Utils.NamePivotSantaEmilia1,
                        Description = "Suelo del Pivot 1 en Santa Emilia. "
                         + "Typic Argiudoll – Clase de capacidad de uso IIe.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 11, 23),
                        DepthLimit = 69,
                        ShortName = Utils.NamePivotSantaEmilia1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lSantaEmiliaPivot1.HorizonList.Add(lHorizon1);
                    lSantaEmiliaPivot1.HorizonList.Add(lHorizon2);
                    lSantaEmiliaPivot1.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaEmilia2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia2 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia2 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia2 + " 3"
                                 select hor).FirstOrDefault();
                    var lSantaEmiliaPivot2 = new Soil
                    {
                        Name = Utils.NamePivotSantaEmilia2,
                        Description = "Suelo del Pivot 1b en Santa Emilia. "
                         + "CONEAT 10.8b Suelo arcillo limoso.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 10, 09),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotSantaEmilia2,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lSantaEmiliaPivot2.HorizonList.Add(lHorizon1);
                    lSantaEmiliaPivot2.HorizonList.Add(lHorizon2);
                    lSantaEmiliaPivot2.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaEmilia3
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia3 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia3 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia3 + " 3"
                                 select hor).FirstOrDefault();
                    var lSantaEmiliaPivot3 = new Soil
                    {
                        Name = Utils.NamePivotSantaEmilia3,
                        Description = "Suelo del Pivot 3 en Santa Emilia. "
                         + "Typic Argiudoll – Clase de capacidad de uso IIe.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 11, 23),
                        DepthLimit = 69,
                        ShortName = Utils.NamePivotSantaEmilia3,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lSantaEmiliaPivot3.HorizonList.Add(lHorizon1);
                    lSantaEmiliaPivot3.HorizonList.Add(lHorizon2);
                    lSantaEmiliaPivot3.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 4
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaEmilia4
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia4 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia4 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia4 + " 3"
                                 select hor).FirstOrDefault();
                    var lSantaEmiliaPivot4 = new Soil
                    {
                        Name = Utils.NamePivotSantaEmilia4,
                        Description = "Suelo del Pivot 4 en Santa Emilia. "
                         + "Typic Argiudoll – Clase de capacidad de uso IIe.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 11, 23),
                        DepthLimit = 69,
                        ShortName = Utils.NamePivotSantaEmilia4,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lSantaEmiliaPivot4.HorizonList.Add(lHorizon1);
                    lSantaEmiliaPivot4.HorizonList.Add(lHorizon2);
                    lSantaEmiliaPivot4.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 5
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaEmilia5
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia5 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia5 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia5 + " 3"
                                 select hor).FirstOrDefault();
                    var lSantaEmiliaPivot5 = new Soil
                    {
                        Name = Utils.NamePivotSantaEmilia5,
                        Description = "Suelo del Pivot 5 en Santa Emilia. "
                         + "Typic Argiudoll – Clase de capacidad de uso IIe.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 11, 23),
                        DepthLimit = 69,
                        ShortName = Utils.NamePivotSantaEmilia5,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lSantaEmiliaPivot5.HorizonList.Add(lHorizon1);
                    lSantaEmiliaPivot5.HorizonList.Add(lHorizon2);
                    lSantaEmiliaPivot5.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 7
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaEmilia7
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia7 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia7 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmilia7 + " 3"
                                 select hor).FirstOrDefault();
                    var lSantaEmiliaPivot7 = new Soil
                    {
                        Name = Utils.NamePivotSantaEmilia7,
                        Description = "Suelo del Pivot 7 en Santa Emilia. "
                         + "Typic Argiudoll – Clase de capacidad de uso IIe.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 11, 23),
                        DepthLimit = 69,
                        ShortName = Utils.NamePivotSantaEmilia7,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lSantaEmiliaPivot7.HorizonList.Add(lHorizon1);
                    lSantaEmiliaPivot7.HorizonList.Add(lHorizon2);
                    lSantaEmiliaPivot7.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot ZP
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaEmiliaZP
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmiliaZP + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmiliaZP + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantaEmiliaZP + " 3"
                                 select hor).FirstOrDefault();
                    var lSantaEmiliaPivotZP = new Soil
                    {
                        Name = Utils.NamePivotSantaEmiliaZP,
                        Description = "Suelo del Pivot 5 en Santa Emilia. "
                         + "Typic Argiudoll – Clase de capacidad de uso IIe.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2017, 09, 10),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotSantaEmiliaZP,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lSantaEmiliaPivotZP.HorizonList.Add(lHorizon1);
                    lSantaEmiliaPivotZP.HorizonList.Add(lHorizon2);
                    lSantaEmiliaPivotZP.HorizonList.Add(lHorizon3);
                    #endregion
                    context.Soils.Add(lSantaEmiliaPivot1);
                    context.Soils.Add(lSantaEmiliaPivot2);
                    context.Soils.Add(lSantaEmiliaPivot3);
                    context.Soils.Add(lSantaEmiliaPivot4);
                    context.Soils.Add(lSantaEmiliaPivot5);
                    context.Soils.Add(lSantaEmiliaPivot7);
                    context.Soils.Add(lSantaEmiliaPivotZP);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Gran Molino Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GranMolino)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmGranMolino
                             select far).FirstOrDefault();

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGranMolino1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino1 + " 3"
                                 select hor).FirstOrDefault();
                    var lGranMolinoPivot1 = new Soil
                    {
                        Name = Utils.NamePivotGranMolino1,
                        Description = "Suelo del Pivot 1 en Gran Molino. "
                         + "Grupos 10.8a y 10.8b. Franco arcillo limosos.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 01, 02),
                        DepthLimit = 69,
                        ShortName = Utils.NamePivotGranMolino1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGranMolinoPivot1.HorizonList.Add(lHorizon1);
                    lGranMolinoPivot1.HorizonList.Add(lHorizon2);
                    lGranMolinoPivot1.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGranMolino2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino2 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino2 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino2 + " 3"
                                 select hor).FirstOrDefault();
                    var lGranMolinoPivot2 = new Soil
                    {
                        Name = Utils.NamePivotGranMolino2,
                        Description = "Suelo del Pivot 2 en Gran Molino. "
                         + "Grupos 10.8a y 10.8b. Franco arcillo limosos.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 01, 02),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGranMolino2,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGranMolinoPivot2.HorizonList.Add(lHorizon1);
                    lGranMolinoPivot2.HorizonList.Add(lHorizon2);
                    lGranMolinoPivot2.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGranMolino3
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino3 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino3 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino3 + " 3"
                                 select hor).FirstOrDefault();
                    var lGranMolinoPivot3 = new Soil
                    {
                        Name = Utils.NamePivotGranMolino3,
                        Description = "Suelo del Pivot 3 en Gran Molino. "
                         + "Grupos 10.8a y 10.8b. Franco arcillo limosos.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 01, 02),
                        DepthLimit = 69,
                        ShortName = Utils.NamePivotGranMolino3,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGranMolinoPivot3.HorizonList.Add(lHorizon1);
                    lGranMolinoPivot3.HorizonList.Add(lHorizon2);
                    lGranMolinoPivot3.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 4
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGranMolino4
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino4 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino4 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino4 + " 3"
                                 select hor).FirstOrDefault();
                    var lGranMolinoPivot4 = new Soil
                    {
                        Name = Utils.NamePivotGranMolino4,
                        Description = "Suelo del Pivot 4 en Gran Molino. "
                         + "Grupos 10.8a y 10.8b. Franco arcillo limosos.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 01, 02),
                        DepthLimit = 69,
                        ShortName = Utils.NamePivotGranMolino4,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGranMolinoPivot4.HorizonList.Add(lHorizon1);
                    lGranMolinoPivot4.HorizonList.Add(lHorizon2);
                    lGranMolinoPivot4.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 5
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGranMolino5
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino5 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino5 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino5 + " 3"
                                 select hor).FirstOrDefault();
                    var lGranMolinoPivot5 = new Soil
                    {
                        Name = Utils.NamePivotGranMolino5,
                        Description = "Suelo del Pivot 5 en Gran Molino. "
                         + "Grupos 10.8a y 10.8b. Franco arcillo limosos.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 01, 02),
                        DepthLimit = 69,
                        ShortName = Utils.NamePivotGranMolino5,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGranMolinoPivot5.HorizonList.Add(lHorizon1);
                    lGranMolinoPivot5.HorizonList.Add(lHorizon2);
                    lGranMolinoPivot5.HorizonList.Add(lHorizon3);
                    #endregion

                    #region Pivot 2b
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGranMolino2b
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino2b + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino2b + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino2b + " 3"
                                 select hor).FirstOrDefault();
                    var lGranMolinoPivot2b = new Soil
                    {
                        Name = Utils.NamePivotGranMolino2b,
                        Description = "Suelo del Pivot 2b en Gran Molino. "
                         + "Grupos 10.8a y 10.8b. Franco arcillo limosos.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 01, 02),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotGranMolino2b,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGranMolinoPivot2b.HorizonList.Add(lHorizon1);
                    lGranMolinoPivot2b.HorizonList.Add(lHorizon2);
                    lGranMolinoPivot2b.HorizonList.Add(lHorizon3);
                    #endregion
                    #region Pivot 5b
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGranMolino5b
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino5b + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino5b + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotGranMolino5b + " 3"
                                 select hor).FirstOrDefault();
                    var lGranMolinoPivot5b = new Soil
                    {
                        Name = Utils.NamePivotGranMolino5b,
                        Description = "Suelo del Pivot 5b en Gran Molino. "
                         + "Grupos 10.8a y 10.8b. Franco arcillo limosos.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 01, 02),
                        DepthLimit = 69,
                        ShortName = Utils.NamePivotGranMolino5b,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lGranMolinoPivot5b.HorizonList.Add(lHorizon1);
                    lGranMolinoPivot5b.HorizonList.Add(lHorizon2);
                    lGranMolinoPivot5b.HorizonList.Add(lHorizon3);
                    #endregion

                    context.Soils.Add(lGranMolinoPivot1);
                    context.Soils.Add(lGranMolinoPivot2);
                    context.Soils.Add(lGranMolinoPivot3);
                    context.Soils.Add(lGranMolinoPivot4);
                    context.Soils.Add(lGranMolinoPivot5);
                    context.Soils.Add(lGranMolinoPivot2b);
                    context.Soils.Add(lGranMolinoPivot5b);
                    context.SaveChanges();
                }
            }
            #endregion

            #region La Portuguesa Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPortuguesa)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmLaPortuguesa
                             select far).FirstOrDefault();

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPortuguesa1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPortuguesa1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPortuguesa1 + " 2"
                                 select hor).FirstOrDefault();
                    var lLaPortuguesaPivot1 = new Soil
                    {
                        Name = Utils.NamePivotLaPortuguesa1,
                        Description = "Suelo del Pivot 1 en La Portuguesa. "
                         + "CONEAT 12.22. Unidad Curtina.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 08, 24),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotLaPortuguesa1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lLaPortuguesaPivot1.HorizonList.Add(lHorizon1);
                    lLaPortuguesaPivot1.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPortuguesa2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPortuguesa2 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPortuguesa2 + " 2"
                                 select hor).FirstOrDefault();
                    var lLaPortuguesaPivot2 = new Soil
                    {
                        Name = Utils.NamePivotLaPortuguesa2,
                        Description = "Suelo del Pivot 2 en La Portuguesa. "
                         + "CONEAT 12.22. Unidad Curtina.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 08, 24),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotLaPortuguesa2,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lLaPortuguesaPivot2.HorizonList.Add(lHorizon1);
                    lLaPortuguesaPivot2.HorizonList.Add(lHorizon2);
                    #endregion

                    context.Soils.Add(lLaPortuguesaPivot1);
                    context.Soils.Add(lLaPortuguesaPivot2);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Cassarino - La Perdiz Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.CassarinoLaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmCassarinoLaPerdiz
                             select far).FirstOrDefault();

                    #region Pivot 1.1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotCassarinoLaPerdiz11
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotCassarinoLaPerdiz11 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotCassarinoLaPerdiz11 + " 2"
                                 select hor).FirstOrDefault();
                    var lCassarinoLaPerdizPivot11 = new Soil
                    {
                        Name = Utils.NamePivotCassarinoLaPerdiz11,
                        Description = "Suelo del Pivot 1 en Cassarino - La Perdiz. "
                         + "Brunosoles y Vertisoles Clase A.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 08, 24),
                        DepthLimit = 84,
                        ShortName = Utils.NamePivotCassarinoLaPerdiz11,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lCassarinoLaPerdizPivot11.HorizonList.Add(lHorizon1);
                    lCassarinoLaPerdizPivot11.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 1.2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotCassarinoLaPerdiz12
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotCassarinoLaPerdiz12 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotCassarinoLaPerdiz12 + " 2"
                                 select hor).FirstOrDefault();
                    var lCassarinoLaPerdizPivot12 = new Soil
                    {
                        Name = Utils.NamePivotCassarinoLaPerdiz12,
                        Description = "Suelo del Pivot 1.2 en Cassarino - La Perdiz. "
                         + "Brunosoles y Vertisoles Clase A.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 08, 24),
                        DepthLimit = 78,
                        ShortName = Utils.NamePivotCassarinoLaPerdiz12,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lCassarinoLaPerdizPivot12.HorizonList.Add(lHorizon1);
                    lCassarinoLaPerdizPivot12.HorizonList.Add(lHorizon2);
                    #endregion
                    #region Pivot 1.3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotCassarinoLaPerdiz13
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotCassarinoLaPerdiz13 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotCassarinoLaPerdiz13 + " 2"
                                 select hor).FirstOrDefault();
                    var lCassarinoLaPerdizPivot13 = new Soil
                    {
                        Name = Utils.NamePivotCassarinoLaPerdiz13,
                        Description = "Suelo del Pivot 1.3 en Cassarino - La Perdiz. "
                         + "Brunosoles y Vertisoles Clase A.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 08, 24),
                        DepthLimit = 84,
                        ShortName = Utils.NamePivotCassarinoLaPerdiz13,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lCassarinoLaPerdizPivot13.HorizonList.Add(lHorizon1);
                    lCassarinoLaPerdizPivot13.HorizonList.Add(lHorizon2);
                    #endregion

                    context.Soils.Add(lCassarinoLaPerdizPivot11);
                    context.Soils.Add(lCassarinoLaPerdizPivot12);
                    context.Soils.Add(lCassarinoLaPerdizPivot13);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Santo Domingo Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantoDomingo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmSantoDomingo
                             select far).FirstOrDefault();

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantoDomingo1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantoDomingo1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantoDomingo1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantoDomingo1 + " 3"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantoDomingo1 + " 4"
                                 select hor).FirstOrDefault();
                    var lSantoDomingoPivot1 = new Soil
                    {
                        Name = Utils.NamePivotSantoDomingo1,
                        Description = "Suelo del Pivot 1 en Santo Domingo. "
                         + "Grupos 10.6a Franco arcillo arenoso.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 08, 01),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotSantoDomingo1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lSantoDomingoPivot1.HorizonList.Add(lHorizon1);
                    lSantoDomingoPivot1.HorizonList.Add(lHorizon2);
                    lSantoDomingoPivot1.HorizonList.Add(lHorizon3);
                    lSantoDomingoPivot1.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantoDomingo2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantoDomingo2 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantoDomingo2 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantoDomingo2 + " 3"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotSantoDomingo2 + " 4"
                                 select hor).FirstOrDefault();
                    var lSantoDomingoPivot2 = new Soil
                    {
                        Name = Utils.NamePivotSantoDomingo2,
                        Description = "Suelo del Pivot 2 en Santo Domingo. "
                         + "Grupos 10.6a Franco arcillo arenoso.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 08, 01),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotSantoDomingo2,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lSantoDomingoPivot2.HorizonList.Add(lHorizon1);
                    lSantoDomingoPivot2.HorizonList.Add(lHorizon2);
                    lSantoDomingoPivot2.HorizonList.Add(lHorizon3);
                    lSantoDomingoPivot2.HorizonList.Add(lHorizon4);
                    #endregion

                    context.Soils.Add(lSantoDomingoPivot1);
                    context.Soils.Add(lSantoDomingoPivot2);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Cecchini Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Cecchini)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmCecchini
                             select far).FirstOrDefault();

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotCecchini1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotCecchini1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotCecchini1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotCecchini1 + " 3"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotCecchini1 + " 4"
                                 select hor).FirstOrDefault();
                    var lCecchiniPivot1 = new Soil
                    {
                        Name = Utils.NamePivotCecchini1,
                        Description = "Suelo del Pivot 1 en Cecchini. "
                         + "Suelo Franco Arcilloso. CONEAT 11.9.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 10, 25),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotCecchini1,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lCecchiniPivot1.HorizonList.Add(lHorizon1);
                    lCecchiniPivot1.HorizonList.Add(lHorizon2);
                    lCecchiniPivot1.HorizonList.Add(lHorizon3);
                    lCecchiniPivot1.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotCecchini2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotCecchini2 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotCecchini2 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotCecchini2 + " 3"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotCecchini2 + " 4"
                                 select hor).FirstOrDefault();
                    var lCecchiniPivot2 = new Soil
                    {
                        Name = Utils.NamePivotCecchini2,
                        Description = "Suelo del Pivot 2 en Cecchini. "
                         + "Suelo Franco Arcilloso. CONEAT 11.9.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 10, 25),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotCecchini2,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lCecchiniPivot2.HorizonList.Add(lHorizon1);
                    lCecchiniPivot2.HorizonList.Add(lHorizon2);
                    lCecchiniPivot2.HorizonList.Add(lHorizon3);
                    lCecchiniPivot2.HorizonList.Add(lHorizon4);
                    #endregion

                    context.Soils.Add(lCecchiniPivot1);
                    context.Soils.Add(lCecchiniPivot2);
                    context.SaveChanges();
                }
            }
            #endregion
            #region El Alba Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElAlba)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmElAlba
                             select far).FirstOrDefault();

                    #region Pivot 32
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElAlba32
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElAlba32 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElAlba32 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElAlba32 + " 3"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElAlba32 + " 4"
                                 select hor).FirstOrDefault();
                    var lElAlbaPivot32 = new Soil
                    {
                        Name = Utils.NamePivotElAlba32,
                        Description = "Suelo del Pivot 32 en El Alba. "
                         + "Brunosoles Éutricos Lúvicos. Grupo CONEAT 10.5.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 10, 24),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotElAlba32,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lElAlbaPivot32.HorizonList.Add(lHorizon1);
                    lElAlbaPivot32.HorizonList.Add(lHorizon2);
                    lElAlbaPivot32.HorizonList.Add(lHorizon3);
                    lElAlbaPivot32.HorizonList.Add(lHorizon4);
                    #endregion
                    #region Pivot 33
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElAlba33
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElAlba33 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElAlba33 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElAlba33 + " 3"
                                 select hor).FirstOrDefault();
                    lHorizon4 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotElAlba33 + " 4"
                                 select hor).FirstOrDefault();
                    var lElAlbaPivot33 = new Soil
                    {
                        Name = Utils.NamePivotElAlba33,
                        Description = "Suelo del Pivot 2 en El Alba. "
                         + "Brunosoles Éutricos Lúvicos. Grupo CONEAT 10.5.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2018, 10, 24),
                        DepthLimit = 60,
                        ShortName = Utils.NamePivotElAlba33,
                        FarmId = lFarm.FarmId,
                        HorizonList = new List<Horizon>(),
                    };
                    lElAlbaPivot33.HorizonList.Add(lHorizon1);
                    lElAlbaPivot33.HorizonList.Add(lHorizon2);
                    lElAlbaPivot33.HorizonList.Add(lHorizon3);
                    lElAlbaPivot33.HorizonList.Add(lHorizon4);
                    #endregion

                    context.Soils.Add(lElAlbaPivot32);
                    context.Soils.Add(lElAlbaPivot33);
                    context.SaveChanges();
                }
            }
            #endregion

        }

#endif
        #endregion
    }
}
