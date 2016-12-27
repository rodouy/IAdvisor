﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Utilities;

using IrrigationAdvisor.DBContext;
using NLog;

namespace IrrigationAdvisorConsole.Insert._06_Agriculture
{
    public static class AgricultureInsert
    {

        #region Agriculture
#if true

        public static void InsertSpecieCycles()
        {
            #region Base
            var lBase = new SpecieCycle
            {
                Name = Utils.NameBase,
                Duration = 0,
            };
            #endregion

            #region Sur
            var lSurCorto = new SpecieCycle
            {
                Name = Utils.NameSpecieCycleSouthShort,
                Duration = 145,
            };

            var lSurMedio = new SpecieCycle
            {
                Name = Utils.NameSpecieCycleSouthMedium,
                Duration = 160,
            };

            var lSurLargo = new SpecieCycle
            {
                Name = Utils.NameSpecieCycleSouthLong,
                Duration = 180,
            };

            #endregion

            #region Norte
            var lNorthShort = new SpecieCycle
            {
                Name = Utils.NameSpecieCycleNorthShort,
                Duration = 160,
            };

            var lNorthMedium = new SpecieCycle
            {
                Name = Utils.NameSpecieCycleNorthMedium,
                Duration = 180,
            };

            var lNorthLong = new SpecieCycle
            {
                Name = Utils.NameSpecieCycleNorthLong,
                Duration = 200,
            };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {
                //context.SpecieCycles.Add(lBase);
                context.SpecieCycles.Add(lSurCorto);
                context.SpecieCycles.Add(lSurMedio);
                context.SpecieCycles.Add(lSurLargo);
                context.SpecieCycles.Add(lNorthShort);
                context.SpecieCycles.Add(lNorthMedium);
                context.SpecieCycles.Add(lNorthLong);
                context.SaveChanges();
            }
        }

        public static void InsertSpecies()
        {
            SpecieCycle lSpecieCycle = null;

            #region Base
            var lBase = new Specie
            {
                Name = Utils.NameBase,
                ShortName = "NoName",
                SpecieCycleId = 0,
                BaseTemperature = 0,
                StressTemperature = 0,
                SpecieType = Utils.SpecieType.Default,

            };
            #endregion

            #region South

            #region CornSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                var lCornSouthShort = new Specie
                {
                    Name = Utils.NameSpecieCornSouthShort,
                    ShortName = "Maíz",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_CornSouth_2016,
                    StressTemperature = DataEntry.StressTemperature_CornSouth_2016,
                    SpecieType = Utils.SpecieType.Grains,
                };

                context.Species.Add(lCornSouthShort);
                context.SaveChanges();
            }
            #endregion

            #region SoyaSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                var lSoyaSouthShort = new Specie
                {
                    Name = Utils.NameSpecieSoyaSouthShort,
                    ShortName = "Soja",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_SoyaSouth_2016,
                    StressTemperature = DataEntry.StressTemperature_SoyaSouth_2016,
                    SpecieType = Utils.SpecieType.Grains,
                };

                context.Species.Add(lSoyaSouthShort);
                context.SaveChanges();
            }
            #endregion

            #region SoyaSouthMedium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthMedium);

                var lSoyaSouthMedium = new Specie
                {
                    Name = Utils.NameSpecieSoyaSouthMedium,
                    ShortName = "Soja",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_SoyaSouth_2016,
                    StressTemperature = DataEntry.StressTemperature_SoyaSouth_2016,
                    SpecieType = Utils.SpecieType.Grains,
                };

                context.Species.Add(lSoyaSouthMedium);
                context.SaveChanges();
            }
            #endregion

            #region SorghumForageSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                var lSorghumForageSouthShort = new Specie
                {
                    Name = Utils.NameSpecieSorghumForageSouthShort,
                    ShortName = "Sorgo Forrajero",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_SorghumForageSouth_2016,
                    StressTemperature = DataEntry.StressTemperature_SorghumForageSouth_2016,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lSorghumForageSouthShort);
                context.SaveChanges();
            }
            #endregion

            #region SorghumGrainSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                var lSorghumGrainSouthShort = new Specie
                {
                    Name = Utils.NameSpecieSorghumGrainSouthShort,
                    ShortName = "Sorgo Granifero",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_SorghumGrainSouth_2016,
                    StressTemperature = DataEntry.StressTemperature_SorghumGrainSouth_2016,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lSorghumGrainSouthShort);
                context.SaveChanges();
            }
            #endregion

            #region AlfalfaSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                var lAlfalfaSouthShort = new Specie
                {
                    Name = Utils.NameSpecieAlfalfaSouthShort,
                    ShortName = "Alfalfa",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_AlfalfaSouth_2016,
                    StressTemperature = DataEntry.StressTemperature_AlfalfaSouth_2016,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lAlfalfaSouthShort);
                context.SaveChanges();
            }
            #endregion

            #region RedCloverForageSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                var lRedCloverForageSouthShort = new Specie
                {
                    Name = Utils.NameSpecieRedCloverForageSouthShort,
                    ShortName = "Trebol Rojo Forraje",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_RedCloverForageSouth_2016,
                    StressTemperature = DataEntry.StressTemperature_RedCloverForageSouth_2016,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lRedCloverForageSouthShort);
                context.SaveChanges();
            }
            #endregion

            #region RedCloverSeedSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                var lRedCloverSeedSouthShort = new Specie
                {
                    Name = Utils.NameSpecieRedCloverSeedSouthShort,
                    ShortName = "Trebol Rojo Semilla",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_RedCloverSeedSouth_2016,
                    StressTemperature = DataEntry.StressTemperature_RedCloverSeedSouth_2016,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lRedCloverSeedSouthShort);
                context.SaveChanges();
            }
            #endregion

            #region FescueForageSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                var lFescueForageSouthShort = new Specie
                {
                    Name = Utils.NameSpecieFescueForageSouthShort,
                    ShortName = "Festuca Forraje",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_FescueForageSouth_2016,
                    StressTemperature = DataEntry.StressTemperature_FescueForageSouth_2016,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lFescueForageSouthShort);
                context.SaveChanges();
            }
            #endregion

            #region FescueSeedSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                var lFescueSeedSouthShort = new Specie
                {
                    Name = Utils.NameSpecieFescueSeedSouthShort,
                    ShortName = "Festuca Semilla",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_FescueSeedSouth_2016,
                    StressTemperature = DataEntry.StressTemperature_FescueSeedSouth_2016,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lFescueSeedSouthShort);
                context.SaveChanges();
            }
            #endregion

            #endregion

            #region North

            #region Corn North Short
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthShort);
                var lCornNorthShort = new Specie
                {
                    Name = Utils.NameSpecieCornNorthShort,
                    ShortName = "Maíz",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_CornNorth_2016,
                    StressTemperature = DataEntry.StressTemperature_CornNorth_2016,
                    SpecieType = Utils.SpecieType.Grains,
                };
                context.Species.Add(lCornNorthShort);
                context.SaveChanges();
            }
            #endregion

            #region Soya North Short
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthShort);

                var lSoyaNorthShort = new Specie
                {
                    Name = Utils.NameSpecieSoyaNorthShort,
                    ShortName = "Soja",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_SoyaNorth_2016,
                    StressTemperature = DataEntry.StressTemperature_SoyaNorth_2016,
                    SpecieType = Utils.SpecieType.Grains,
                };
                context.Species.Add(lSoyaNorthShort);
                context.SaveChanges();
            }
            #endregion

            #endregion

            using (var context = new IrrigationAdvisorContext())
            {
                //context.Species.Add(lBase);
                context.SaveChanges();
            };
        }

        public static void UpdateCountryRegionWithSpeciesSpeciesCycles()
        {
            Region lRegion = null;
            Country lCountry = null;
            IQueryable<SpecieCycle> lIQSpecieCycle = null;
            IQueryable<Specie> lIQSpecie = null;
            using (var context = new IrrigationAdvisorContext())
            {

                lCountry = context.Countries.SingleOrDefault(
                                    country => country.Name == Utils.NameCountryUruguay);

                #region Sur
                lIQSpecieCycle = context.SpecieCycles;
                lIQSpecie = context.Species;
                lRegion = context.Regions.SingleOrDefault(
                                    region => region.Name == Utils.NameRegionSouth);

                lIQSpecieCycle = lIQSpecieCycle.Where(b => b.Name.Contains("Sur"));
                foreach (SpecieCycle item in lIQSpecieCycle) lRegion.AddSpecieCycle(item);

                lIQSpecie = lIQSpecie.Where(b => b.Name.Contains("Sur"));
                foreach (Specie item in lIQSpecie) lRegion.AddSpecie(item);

                lCountry.RegionList.Add(lRegion);
                #endregion

                #region Norte
                lIQSpecieCycle = context.SpecieCycles;
                lIQSpecie = context.Species;
                lRegion = context.Regions.SingleOrDefault(
                                    region => region.Name == Utils.NameRegionNorth);
                //Add Cycles 
                lIQSpecieCycle = lIQSpecieCycle.Where(b => b.Name.Contains("Norte"));
                foreach (SpecieCycle item in lIQSpecieCycle) lRegion.AddSpecieCycle(item);
                //Add Species
                lIQSpecie = lIQSpecie.Where(b => b.Name.Contains("Norte"));
                foreach (Specie item in lIQSpecie) lRegion.AddSpecie(item);

                lCountry.RegionList.Add(lRegion);
                #endregion

                context.SaveChanges();
            }

        }

        #region Stages

        public static void InsertStagesCorn()
        {
            var lBase = new Stage
            {
                Name = Utils.NameBase,
                Description = "",
            };

            var lStageMv0 = new Stage { Name = Utils.NameStagesCorn + " V0", ShortName = "V0", Description = "Siembra", Order = 1, };
            var lStageMve = new Stage { Name = Utils.NameStagesCorn + " VE", ShortName = "VE", Description = "Emergencia", Order = 2, };
            var lStageMv1 = new Stage { Name = Utils.NameStagesCorn + " V1", ShortName = "V1", Description = "1 nudo", Order = 3, };
            var lStageMv2 = new Stage { Name = Utils.NameStagesCorn + " V2", ShortName = "V2", Description = "2 nudos", Order = 4, };
            var lStageMv3 = new Stage { Name = Utils.NameStagesCorn + " V3", ShortName = "V3", Description = "3 nudos", Order = 5, };
            var lStageMv4 = new Stage { Name = Utils.NameStagesCorn + " V4", ShortName = "V4", Description = "4 nudos", Order = 6, };
            var lStageMv5 = new Stage { Name = Utils.NameStagesCorn + " V5", ShortName = "V5", Description = "5 nudos", Order = 7, };
            var lStageMv6 = new Stage { Name = Utils.NameStagesCorn + " V6", ShortName = "V6", Description = "6 nudos", Order = 8, };
            var lStageMv7 = new Stage { Name = Utils.NameStagesCorn + " V7", ShortName = "V7", Description = "7 nudos", Order = 9, };
            var lStageMv8 = new Stage { Name = Utils.NameStagesCorn + " V8", ShortName = "V8", Description = "8 nudos", Order = 10, };
            var lStageMv9 = new Stage { Name = Utils.NameStagesCorn + " V9", ShortName = "V9", Description = "9 nudos", Order = 11, };
            var lStageMv10 = new Stage { Name = Utils.NameStagesCorn + " V10", ShortName = "V10", Description = "10 nudos", Order = 12, };
            var lStageMv11 = new Stage { Name = Utils.NameStagesCorn + " V11", ShortName = "V11", Description = "11 nudo", Order = 13, };
            var lStageMv12 = new Stage { Name = Utils.NameStagesCorn + " V12", ShortName = "V12", Description = "12 nudos", Order = 14, };
            var lStageMv13 = new Stage { Name = Utils.NameStagesCorn + " V13", ShortName = "V13", Description = "13 nudos", Order = 15, };
            var lStageMv14 = new Stage { Name = Utils.NameStagesCorn + " V14", ShortName = "V14", Description = "14 nudos", Order = 16, };
            var lStageMv15 = new Stage { Name = Utils.NameStagesCorn + " V15", ShortName = "V15", Description = "15 nudos", Order = 17, };
            var lStageMvt = new Stage { Name = Utils.NameStagesCorn + " VT", ShortName = "VT", Description = "Floracion", Order = 18, };
            var lStageMr1 = new Stage { Name = Utils.NameStagesCorn + " R1", ShortName = "R1", Description = "Estambres 50%", Order = 19, };
            var lStageMr2 = new Stage { Name = Utils.NameStagesCorn + " R2", ShortName = "R2", Description = "Granos hinchados", Order = 20, };
            var lStageMr3 = new Stage { Name = Utils.NameStagesCorn + " R3", ShortName = "R3", Description = "Estado lechoso", Order = 21, };
            var lStageMr4 = new Stage { Name = Utils.NameStagesCorn + " R4", ShortName = "R4", Description = "Estado pastoso", Order = 22, };
            var lStageMr5 = new Stage { Name = Utils.NameStagesCorn + " R5", ShortName = "R5", Description = "Estado de diente", Order = 23, };
            var lStageMr6 = new Stage { Name = Utils.NameStagesCorn + " R6", ShortName = "R6", Description = "Madurez fisiologica", Order = 24, };


            using (var context = new IrrigationAdvisorContext())
            {
                //context.Stages.Add(lBase);
                context.Stages.Add(lStageMv0);
                context.Stages.Add(lStageMve);
                context.Stages.Add(lStageMv1);
                context.Stages.Add(lStageMv2);
                context.Stages.Add(lStageMv3);
                context.Stages.Add(lStageMv4);
                context.Stages.Add(lStageMv5);
                context.Stages.Add(lStageMv6);
                context.Stages.Add(lStageMv7);
                context.Stages.Add(lStageMv8);
                context.Stages.Add(lStageMv9);
                context.Stages.Add(lStageMv10);
                context.Stages.Add(lStageMv11);
                context.Stages.Add(lStageMv12);
                context.Stages.Add(lStageMv13);
                context.Stages.Add(lStageMv14);
                context.Stages.Add(lStageMv15);
                context.Stages.Add(lStageMvt);
                context.Stages.Add(lStageMr1);
                context.Stages.Add(lStageMr2);
                context.Stages.Add(lStageMr3);
                context.Stages.Add(lStageMr4);
                context.Stages.Add(lStageMr5);
                context.Stages.Add(lStageMr6);

                context.SaveChanges();
            };
        }

        public static void InsertStagesSoya()
        {
            var lBase = new Stage
            {
                Name = Utils.NameBase,
                Description = "",
            };

            var lStageSv0 = new Stage { Name = Utils.NameStagesSoya + " V0", ShortName = "V0", Description = "Siembra", Order = 1, };
            var lStageSve = new Stage { Name = Utils.NameStagesSoya + " VE", ShortName = "VE", Description = "Emergencia", Order = 2, };
            var lStageSv1 = new Stage { Name = Utils.NameStagesSoya + " V1", ShortName = "V1", Description = "1 nudo", Order = 3, };
            var lStageSv2 = new Stage { Name = Utils.NameStagesSoya + " V2", ShortName = "V2", Description = "2 nudos", Order = 4, };
            var lStageSv3 = new Stage { Name = Utils.NameStagesSoya + " V3", ShortName = "V3", Description = "3 nudos", Order = 5, };
            var lStageSv4 = new Stage { Name = Utils.NameStagesSoya + " V4", ShortName = "V4", Description = "4 nudos", Order = 6, };
            var lStageSv5 = new Stage { Name = Utils.NameStagesSoya + " V5", ShortName = "V5", Description = "5 nudos", Order = 7, };
            var lStageSv6 = new Stage { Name = Utils.NameStagesSoya + " V6", ShortName = "V6", Description = "6 nudos", Order = 8, };
            var lStageSv7 = new Stage { Name = Utils.NameStagesSoya + " V7", ShortName = "V7", Description = "7 nudos", Order = 9, };
            var lStageSv8 = new Stage { Name = Utils.NameStagesSoya + " V8", ShortName = "V8", Description = "8 nudos", Order = 10, };
            var lStageSv9 = new Stage { Name = Utils.NameStagesSoya + " V9", ShortName = "V9", Description = "9 nudos", Order = 11, };
            var lStageSv10 = new Stage { Name = Utils.NameStagesSoya + " V10", ShortName = "V10", Description = "10 nudos", Order = 12, };
            var lStageSv11 = new Stage { Name = Utils.NameStagesSoya + " V11", ShortName = "V11", Description = "11 nudo", Order = 13, };
            var lStageSr1 = new Stage { Name = Utils.NameStagesSoya + " R1", ShortName = "R1", Description = "Inicio Floracion", Order = 14, };
            var lStageSr2 = new Stage { Name = Utils.NameStagesSoya + " R2", ShortName = "R2", Description = "Floracion Completa", Order = 15, };
            var lStageSr3 = new Stage { Name = Utils.NameStagesSoya + " R3", ShortName = "R3", Description = "Inicio Vainas", Order = 16, };
            var lStageSr4 = new Stage { Name = Utils.NameStagesSoya + " R4", ShortName = "R4", Description = "Vainas Completas", Order = 17, };
            var lStageSr5 = new Stage { Name = Utils.NameStagesSoya + " R5", ShortName = "R5", Description = "Formacion de semillas", Order = 18, };
            var lStageSr6 = new Stage { Name = Utils.NameStagesSoya + " R6", ShortName = "R6", Description = "Semillas Completas", Order = 19, };
            var lStageSr7 = new Stage { Name = Utils.NameStagesSoya + " R7", ShortName = "R7", Description = "Inicio Maduracion", Order = 20, };
            var lStageSr8 = new Stage { Name = Utils.NameStagesSoya + " R8", ShortName = "R8", Description = "Maduracion Completa", Order = 21, };


            using (var context = new IrrigationAdvisorContext())
            {
                //context.Stages.Add(lBase);
                context.Stages.Add(lStageSv0);
                context.Stages.Add(lStageSve);
                context.Stages.Add(lStageSv1);
                context.Stages.Add(lStageSv2);
                context.Stages.Add(lStageSv3);
                context.Stages.Add(lStageSv4);
                context.Stages.Add(lStageSv5);
                context.Stages.Add(lStageSv6);
                context.Stages.Add(lStageSv7);
                context.Stages.Add(lStageSv8);
                context.Stages.Add(lStageSv9);
                context.Stages.Add(lStageSv10);
                context.Stages.Add(lStageSv11);
                context.Stages.Add(lStageSr1);
                context.Stages.Add(lStageSr2);
                context.Stages.Add(lStageSr3);
                context.Stages.Add(lStageSr4);
                context.Stages.Add(lStageSr5);
                context.Stages.Add(lStageSr6);
                context.Stages.Add(lStageSr7);
                context.Stages.Add(lStageSr8);
                context.SaveChanges();
            };
        }

        public static void InsertStagesSorghumForage()
        {
            var lStageV0 = new Stage { Name = Utils.NameStagesSorghumForage + " V0", ShortName = "V0", Description = "Emergencia ", Order = 1, };
            var lStageV3 = new Stage { Name = Utils.NameStagesSorghumForage + " V3", ShortName = "V3", Description = "3 hojas ", Order = 2, };
            var lStageV5 = new Stage { Name = Utils.NameStagesSorghumForage + " V5", ShortName = "V5", Description = "5 hojas ", Order = 3, };
            var lStageV8 = new Stage { Name = Utils.NameStagesSorghumForage + " V8", ShortName = "V8", Description = "8 hojas ", Order = 4, };
            var lStageHF = new Stage { Name = Utils.NameStagesSorghumForage + " HF", ShortName = "HF", Description = "Hoja Final ", Order = 5, };
            var lStageEM = new Stage { Name = Utils.NameStagesSorghumForage + " EM", ShortName = "EM", Description = "Embuche ", Order = 6, };
            var lStageFF = new Stage { Name = Utils.NameStagesSorghumForage + " FF", ShortName = "FF", Description = "Floracion ", Order = 7, };
            var lStageGL = new Stage { Name = Utils.NameStagesSorghumForage + " GL", ShortName = "GL", Description = "Grano Lechoso ", Order = 8, };
            var lStageGP = new Stage { Name = Utils.NameStagesSorghumForage + " GP", ShortName = "GP", Description = "Grano pastoso ", Order = 9, };
            var lStageMF = new Stage { Name = Utils.NameStagesSorghumForage + " MF", ShortName = "MF", Description = "Madurez Fisiologica ", Order = 10, };

            using (var context = new IrrigationAdvisorContext())
            {
                context.Stages.Add(lStageV0);
                context.Stages.Add(lStageV3);
                context.Stages.Add(lStageV5);
                context.Stages.Add(lStageV8);
                context.Stages.Add(lStageHF);
                context.Stages.Add(lStageEM);
                context.Stages.Add(lStageFF);
                context.Stages.Add(lStageGL);
                context.Stages.Add(lStageGP);
                context.Stages.Add(lStageMF);
                context.SaveChanges();
            };
        }

        public static void InsertStagesSorghumGrain()
        {
            var lStageV0 = new Stage { Name = Utils.NameStagesSorghumForage + " V0", ShortName = "V0", Description = "Emergencia ", Order = 1, };
            var lStageV3 = new Stage { Name = Utils.NameStagesSorghumForage + " V3", ShortName = "V3", Description = "3 hojas ", Order = 2, };
            var lStageV5 = new Stage { Name = Utils.NameStagesSorghumForage + " V5", ShortName = "V5", Description = "5 hojas ", Order = 3, };
            var lStageV8 = new Stage { Name = Utils.NameStagesSorghumForage + " V8", ShortName = "V8", Description = "8 hojas ", Order = 4, };
            var lStageHF = new Stage { Name = Utils.NameStagesSorghumForage + " HF", ShortName = "HF", Description = "Hoja Final ", Order = 5, };
            var lStageEM = new Stage { Name = Utils.NameStagesSorghumForage + " EM", ShortName = "EM", Description = "Embuche ", Order = 6, };
            var lStageFF = new Stage { Name = Utils.NameStagesSorghumForage + " FF", ShortName = "FF", Description = "Floracion ", Order = 7, };
            var lStageGL = new Stage { Name = Utils.NameStagesSorghumForage + " GL", ShortName = "GL", Description = "Grano Lechoso ", Order = 8, };
            var lStageGP = new Stage { Name = Utils.NameStagesSorghumForage + " GP", ShortName = "GP", Description = "Grano pastoso ", Order = 9, };
            var lStageMF = new Stage { Name = Utils.NameStagesSorghumForage + " MF", ShortName = "MF", Description = "Madurez Fisiologica ", Order = 10, };

            using (var context = new IrrigationAdvisorContext())
            {
                context.Stages.Add(lStageV0);
                context.Stages.Add(lStageV3);
                context.Stages.Add(lStageV5);
                context.Stages.Add(lStageV8);
                context.Stages.Add(lStageHF);
                context.Stages.Add(lStageEM);
                context.Stages.Add(lStageFF);
                context.Stages.Add(lStageGL);
                context.Stages.Add(lStageGP);
                context.Stages.Add(lStageMF);
                context.SaveChanges();
            };
        }

        public static void InsertStagesAlfalfa()
        {
            var lBase = new Stage
            {
                Name = Utils.NameBase,
                Description = "",
            };

            var lStageSv0 = new Stage { Name = Utils.NameStagesAlfalfa + " V0", Description = "Siembra", Order = 1, };
            var lStageSve = new Stage { Name = Utils.NameStagesAlfalfa + " VE", Description = "Emergencia", Order = 2, };
            var lStageSv1 = new Stage { Name = Utils.NameStagesAlfalfa + " V1", Description = "1 nudo", Order = 3, };
            var lStageSv2 = new Stage { Name = Utils.NameStagesAlfalfa + " V2", Description = "2 nudos", Order = 4, };
            var lStageSv3 = new Stage { Name = Utils.NameStagesAlfalfa + " V3", Description = "3 nudos", Order = 5, };
            var lStageSv4 = new Stage { Name = Utils.NameStagesAlfalfa + " V4", Description = "4 nudos", Order = 6, };
            var lStageSv5 = new Stage { Name = Utils.NameStagesAlfalfa + " V5", Description = "5 nudos", Order = 7, };
            var lStageSv6 = new Stage { Name = Utils.NameStagesAlfalfa + " V6", Description = "6 nudos", Order = 8, };
            var lStageSv7 = new Stage { Name = Utils.NameStagesAlfalfa + " V7", Description = "7 nudos", Order = 9, };
            var lStageSv8 = new Stage { Name = Utils.NameStagesAlfalfa + " V8", Description = "8 nudos", Order = 10, };
            var lStageSv9 = new Stage { Name = Utils.NameStagesAlfalfa + " V9", Description = "9 nudos", Order = 11, };
            var lStageSv10 = new Stage { Name = Utils.NameStagesAlfalfa + " V10", Description = "10 nudos", Order = 12, };
            var lStageSv11 = new Stage { Name = Utils.NameStagesAlfalfa + " V11", Description = "11 nudo", Order = 13, };
            var lStageSr1 = new Stage { Name = Utils.NameStagesAlfalfa + " R1", ShortName = "R1", Description = "Inicio Floracion", Order = 14, };
            var lStageSr2 = new Stage { Name = Utils.NameStagesAlfalfa + " R2", ShortName = "R2", Description = "Floracion Completa", Order = 15, };
            var lStageSr3 = new Stage { Name = Utils.NameStagesAlfalfa + " R3", ShortName = "R3", Description = "Inicio Vainas", Order = 16, };
            var lStageSr4 = new Stage { Name = Utils.NameStagesAlfalfa + " R4", ShortName = "R4", Description = "Vainas Completas", Order = 17, };
            var lStageSr5 = new Stage { Name = Utils.NameStagesAlfalfa + " R5", ShortName = "R5", Description = "Formacion de semillas", Order = 18, };
            var lStageSr6 = new Stage { Name = Utils.NameStagesAlfalfa + " R6", ShortName = "R6", Description = "Semillas Completas", Order = 19, };
            var lStageSr7 = new Stage { Name = Utils.NameStagesAlfalfa + " R7", ShortName = "R7", Description = "Inicio Maduracion", Order = 20, };
            var lStageSr8 = new Stage { Name = Utils.NameStagesAlfalfa + " R8", ShortName = "R8", Description = "Maduracion Completa", Order = 21, };


            using (var context = new IrrigationAdvisorContext())
            {
                //context.Stages.Add(lBase);
                context.Stages.Add(lStageSv0);
                context.Stages.Add(lStageSve);
                context.Stages.Add(lStageSv1);
                context.Stages.Add(lStageSv2);
                context.Stages.Add(lStageSv3);
                context.Stages.Add(lStageSv4);
                context.Stages.Add(lStageSv5);
                context.Stages.Add(lStageSv6);
                context.Stages.Add(lStageSv7);
                context.Stages.Add(lStageSv8);
                context.Stages.Add(lStageSv9);
                context.Stages.Add(lStageSv10);
                context.Stages.Add(lStageSv11);
                context.Stages.Add(lStageSr1);
                context.Stages.Add(lStageSr2);
                context.Stages.Add(lStageSr3);
                context.Stages.Add(lStageSr4);
                context.Stages.Add(lStageSr5);
                context.Stages.Add(lStageSr6);
                context.Stages.Add(lStageSr7);
                context.Stages.Add(lStageSr8);
                context.SaveChanges();
            };
        }

        public static void InsertStagesRedCloverForage()
        {
            var lBase = new Stage
            {
                Name = Utils.NameBase,
                Description = "",
            };

            var lStageSv0 = new Stage { Name = Utils.NameStagesRedCloverForage + " V0", Description = "Siembra", Order = 1, };
            var lStageSve = new Stage { Name = Utils.NameStagesRedCloverForage + " VE", Description = "Emergencia", Order = 2, };
            var lStageSv1 = new Stage { Name = Utils.NameStagesRedCloverForage + " V1", Description = "1 nudo", Order = 3, };
            var lStageSv2 = new Stage { Name = Utils.NameStagesRedCloverForage + " V2", Description = "2 nudos", Order = 4, };
            var lStageSv3 = new Stage { Name = Utils.NameStagesRedCloverForage + " V3", Description = "3 nudos", Order = 5, };
            var lStageSv4 = new Stage { Name = Utils.NameStagesRedCloverForage + " V4", Description = "4 nudos", Order = 6, };
            var lStageSv5 = new Stage { Name = Utils.NameStagesRedCloverForage + " V5", Description = "5 nudos", Order = 7, };
            var lStageSv6 = new Stage { Name = Utils.NameStagesRedCloverForage + " V6", Description = "6 nudos", Order = 8, };
            var lStageSv7 = new Stage { Name = Utils.NameStagesRedCloverForage + " V7", Description = "7 nudos", Order = 9, };
            var lStageSv8 = new Stage { Name = Utils.NameStagesRedCloverForage + " V8", Description = "8 nudos", Order = 10, };
            var lStageSv9 = new Stage { Name = Utils.NameStagesRedCloverForage + " V9", Description = "9 nudos", Order = 11, };
            var lStageSv10 = new Stage { Name = Utils.NameStagesRedCloverForage + " V10", Description = "10 nudos", Order = 12, };
            var lStageSv11 = new Stage { Name = Utils.NameStagesRedCloverForage + " V11", Description = "11 nudo", Order = 13, };
            var lStageSr1 = new Stage { Name = Utils.NameStagesRedCloverForage + " R1", ShortName = "R1", Description = "Inicio Floracion", Order = 14, };
            var lStageSr2 = new Stage { Name = Utils.NameStagesRedCloverForage + " R2", ShortName = "R2", Description = "Floracion Completa", Order = 15, };
            var lStageSr3 = new Stage { Name = Utils.NameStagesRedCloverForage + " R3", ShortName = "R3", Description = "Inicio Vainas", Order = 16, };
            var lStageSr4 = new Stage { Name = Utils.NameStagesRedCloverForage + " R4", ShortName = "R4", Description = "Vainas Completas", Order = 17, };
            var lStageSr5 = new Stage { Name = Utils.NameStagesRedCloverForage + " R5", ShortName = "R5", Description = "Formacion de semillas", Order = 18, };
            var lStageSr6 = new Stage { Name = Utils.NameStagesRedCloverForage + " R6", ShortName = "R6", Description = "Semillas Completas", Order = 19, };
            var lStageSr7 = new Stage { Name = Utils.NameStagesRedCloverForage + " R7", ShortName = "R7", Description = "Inicio Maduracion", Order = 20, };
            var lStageSr8 = new Stage { Name = Utils.NameStagesRedCloverForage + " R8", ShortName = "R8", Description = "Maduracion Completa", Order = 21, };


            using (var context = new IrrigationAdvisorContext())
            {
                //context.Stages.Add(lBase);
                context.Stages.Add(lStageSv0);
                context.Stages.Add(lStageSve);
                context.Stages.Add(lStageSv1);
                context.Stages.Add(lStageSv2);
                context.Stages.Add(lStageSv3);
                context.Stages.Add(lStageSv4);
                context.Stages.Add(lStageSv5);
                context.Stages.Add(lStageSv6);
                context.Stages.Add(lStageSv7);
                context.Stages.Add(lStageSv8);
                context.Stages.Add(lStageSv9);
                context.Stages.Add(lStageSv10);
                context.Stages.Add(lStageSv11);
                context.Stages.Add(lStageSr1);
                context.Stages.Add(lStageSr2);
                context.Stages.Add(lStageSr3);
                context.Stages.Add(lStageSr4);
                context.Stages.Add(lStageSr5);
                context.Stages.Add(lStageSr6);
                context.Stages.Add(lStageSr7);
                context.Stages.Add(lStageSr8);
                context.SaveChanges();
            };
        }

        public static void InsertStagesRedCloverSeed()
        {
            var lBase = new Stage
            {
                Name = Utils.NameBase,
                Description = "",
            };

            var lStageSv0 = new Stage { Name = Utils.NameStagesRedCloverSeed + " V0", Description = "Siembra", Order = 1, };
            var lStageSve = new Stage { Name = Utils.NameStagesRedCloverSeed + " VE", Description = "Emergencia", Order = 2, };
            var lStageSv1 = new Stage { Name = Utils.NameStagesRedCloverSeed + " V1", Description = "1 nudo", Order = 3, };
            var lStageSv2 = new Stage { Name = Utils.NameStagesRedCloverSeed + " V2", Description = "2 nudos", Order = 4, };
            var lStageSv3 = new Stage { Name = Utils.NameStagesRedCloverSeed + " V3", Description = "3 nudos", Order = 5, };
            var lStageSv4 = new Stage { Name = Utils.NameStagesRedCloverSeed + " V4", Description = "4 nudos", Order = 6, };
            var lStageSv5 = new Stage { Name = Utils.NameStagesRedCloverSeed + " V5", Description = "5 nudos", Order = 7, };
            var lStageSv6 = new Stage { Name = Utils.NameStagesRedCloverSeed + " V6", Description = "6 nudos", Order = 8, };
            var lStageSv7 = new Stage { Name = Utils.NameStagesRedCloverSeed + " V7", Description = "7 nudos", Order = 9, };
            var lStageSv8 = new Stage { Name = Utils.NameStagesRedCloverSeed + " V8", Description = "8 nudos", Order = 10, };
            var lStageSv9 = new Stage { Name = Utils.NameStagesRedCloverSeed + " V9", Description = "9 nudos", Order = 11, };
            var lStageSv10 = new Stage { Name = Utils.NameStagesRedCloverSeed + " V10", Description = "10 nudos", Order = 12, };
            var lStageSv11 = new Stage { Name = Utils.NameStagesRedCloverSeed + " V11", Description = "11 nudo", Order = 13, };
            var lStageSr1 = new Stage { Name = Utils.NameStagesRedCloverSeed + " R1", ShortName = "R1", Description = "Inicio Floracion", Order = 14, };
            var lStageSr2 = new Stage { Name = Utils.NameStagesRedCloverSeed + " R2", ShortName = "R2", Description = "Floracion Completa", Order = 15, };
            var lStageSr3 = new Stage { Name = Utils.NameStagesRedCloverSeed + " R3", ShortName = "R3", Description = "Inicio Vainas", Order = 16, };
            var lStageSr4 = new Stage { Name = Utils.NameStagesRedCloverSeed + " R4", ShortName = "R4", Description = "Vainas Completas", Order = 17, };
            var lStageSr5 = new Stage { Name = Utils.NameStagesRedCloverSeed + " R5", ShortName = "R5", Description = "Formacion de semillas", Order = 18, };
            var lStageSr6 = new Stage { Name = Utils.NameStagesRedCloverSeed + " R6", ShortName = "R6", Description = "Semillas Completas", Order = 19, };
            var lStageSr7 = new Stage { Name = Utils.NameStagesRedCloverSeed + " R7", ShortName = "R7", Description = "Inicio Maduracion", Order = 20, };
            var lStageSr8 = new Stage { Name = Utils.NameStagesRedCloverSeed + " R8", ShortName = "R8", Description = "Maduracion Completa", Order = 21, };


            using (var context = new IrrigationAdvisorContext())
            {
                //context.Stages.Add(lBase);
                context.Stages.Add(lStageSv0);
                context.Stages.Add(lStageSve);
                context.Stages.Add(lStageSv1);
                context.Stages.Add(lStageSv2);
                context.Stages.Add(lStageSv3);
                context.Stages.Add(lStageSv4);
                context.Stages.Add(lStageSv5);
                context.Stages.Add(lStageSv6);
                context.Stages.Add(lStageSv7);
                context.Stages.Add(lStageSv8);
                context.Stages.Add(lStageSv9);
                context.Stages.Add(lStageSv10);
                context.Stages.Add(lStageSv11);
                context.Stages.Add(lStageSr1);
                context.Stages.Add(lStageSr2);
                context.Stages.Add(lStageSr3);
                context.Stages.Add(lStageSr4);
                context.Stages.Add(lStageSr5);
                context.Stages.Add(lStageSr6);
                context.Stages.Add(lStageSr7);
                context.Stages.Add(lStageSr8);
                context.SaveChanges();
            };
        }

        public static void InsertStagesFescueForage()
        {
            var lBase = new Stage
            {
                Name = Utils.NameBase,
                Description = "",
            };

            var lStageSv0 = new Stage { Name = Utils.NameStagesFescueForage + " V0", ShortName = "V0", Description = "Siembra", Order = 1, };
            var lStageSve = new Stage { Name = Utils.NameStagesFescueForage + " VE", ShortName = "VE", Description = "Emergencia", Order = 2, };
            var lStageSv1 = new Stage { Name = Utils.NameStagesFescueForage + " V1", ShortName = "V1", Description = "1 nudo", Order = 3, };
            var lStageSv2 = new Stage { Name = Utils.NameStagesFescueForage + " V2", ShortName = "V2", Description = "2 nudos", Order = 4, };
            var lStageSv3 = new Stage { Name = Utils.NameStagesFescueForage + " V3", ShortName = "V3", Description = "3 nudos", Order = 5, };
            var lStageSv4 = new Stage { Name = Utils.NameStagesFescueForage + " V4", ShortName = "V4", Description = "4 nudos", Order = 6, };
            var lStageSv5 = new Stage { Name = Utils.NameStagesFescueForage + " V5", ShortName = "V5", Description = "5 nudos", Order = 7, };
            var lStageSv6 = new Stage { Name = Utils.NameStagesFescueForage + " V6", ShortName = "V6", Description = "6 nudos", Order = 8, };
            var lStageSv7 = new Stage { Name = Utils.NameStagesFescueForage + " V7", ShortName = "V7", Description = "7 nudos", Order = 9, };
            var lStageSv8 = new Stage { Name = Utils.NameStagesFescueForage + " V8", ShortName = "V8", Description = "8 nudos", Order = 10, };
            var lStageSv9 = new Stage { Name = Utils.NameStagesFescueForage + " V9", ShortName = "V9", Description = "9 nudos", Order = 11, };
            var lStageSv10 = new Stage { Name = Utils.NameStagesFescueForage + " V10", ShortName = "V10", Description = "10 nudos", Order = 12, };
            var lStageSv11 = new Stage { Name = Utils.NameStagesFescueForage + " V11", ShortName = "V11", Description = "11 nudo", Order = 13, };
            var lStageSr1 = new Stage { Name = Utils.NameStagesFescueForage + " R1", ShortName = "R1", Description = "Inicio Floracion", Order = 14, };
            var lStageSr2 = new Stage { Name = Utils.NameStagesFescueForage + " R2", ShortName = "R2", Description = "Floracion Completa", Order = 15, };
            var lStageSr3 = new Stage { Name = Utils.NameStagesFescueForage + " R3", ShortName = "R3", Description = "Inicio Vainas", Order = 16, };
            var lStageSr4 = new Stage { Name = Utils.NameStagesFescueForage + " R4", ShortName = "R4", Description = "Vainas Completas", Order = 17, };
            var lStageSr5 = new Stage { Name = Utils.NameStagesFescueForage + " R5", ShortName = "R5", Description = "Formacion de semillas", Order = 18, };
            var lStageSr6 = new Stage { Name = Utils.NameStagesFescueForage + " R6", ShortName = "R6", Description = "Semillas Completas", Order = 19, };
            var lStageSr7 = new Stage { Name = Utils.NameStagesFescueForage + " R7", ShortName = "R7", Description = "Inicio Maduracion", Order = 20, };
            var lStageSr8 = new Stage { Name = Utils.NameStagesFescueForage + " R8", ShortName = "R8", Description = "Maduracion Completa", Order = 21, };


            using (var context = new IrrigationAdvisorContext())
            {
                //context.Stages.Add(lBase);
                context.Stages.Add(lStageSv0);
                context.Stages.Add(lStageSve);
                context.Stages.Add(lStageSv1);
                context.Stages.Add(lStageSv2);
                context.Stages.Add(lStageSv3);
                context.Stages.Add(lStageSv4);
                context.Stages.Add(lStageSv5);
                context.Stages.Add(lStageSv6);
                context.Stages.Add(lStageSv7);
                context.Stages.Add(lStageSv8);
                context.Stages.Add(lStageSv9);
                context.Stages.Add(lStageSv10);
                context.Stages.Add(lStageSv11);
                context.Stages.Add(lStageSr1);
                context.Stages.Add(lStageSr2);
                context.Stages.Add(lStageSr3);
                context.Stages.Add(lStageSr4);
                context.Stages.Add(lStageSr5);
                context.Stages.Add(lStageSr6);
                context.Stages.Add(lStageSr7);
                context.Stages.Add(lStageSr8);
                context.SaveChanges();
            };
        }

        public static void InsertStagesFescueSeed()
        {
            var lBase = new Stage
            {
                Name = Utils.NameBase,
                Description = "",
            };

            var lStageSv0 = new Stage { Name = Utils.NameStagesFescueSeed + " V0", ShortName = "V0", Description = "Siembra", Order = 1, };
            var lStageSve = new Stage { Name = Utils.NameStagesFescueSeed + " VE", ShortName = "VE", Description = "Emergencia", Order = 2, };
            var lStageSv1 = new Stage { Name = Utils.NameStagesFescueSeed + " V1", ShortName = "V1", Description = "1 nudo", Order = 3, };
            var lStageSv2 = new Stage { Name = Utils.NameStagesFescueSeed + " V2", ShortName = "V2", Description = "2 nudos", Order = 4, };
            var lStageSv3 = new Stage { Name = Utils.NameStagesFescueSeed + " V3", ShortName = "V3", Description = "3 nudos", Order = 5, };
            var lStageSv4 = new Stage { Name = Utils.NameStagesFescueSeed + " V4", ShortName = "V4", Description = "4 nudos", Order = 6, };
            var lStageSv5 = new Stage { Name = Utils.NameStagesFescueSeed + " V5", ShortName = "V5", Description = "5 nudos", Order = 7, };
            var lStageSv6 = new Stage { Name = Utils.NameStagesFescueSeed + " V6", ShortName = "V6", Description = "6 nudos", Order = 8, };
            var lStageSv7 = new Stage { Name = Utils.NameStagesFescueSeed + " V7", ShortName = "V7", Description = "7 nudos", Order = 9, };
            var lStageSv8 = new Stage { Name = Utils.NameStagesFescueSeed + " V8", ShortName = "V8", Description = "8 nudos", Order = 10, };
            var lStageSv9 = new Stage { Name = Utils.NameStagesFescueSeed + " V9", ShortName = "V9", Description = "9 nudos", Order = 11, };
            var lStageSv10 = new Stage { Name = Utils.NameStagesFescueSeed + " V10", ShortName = "V10", Description = "10 nudos", Order = 12, };
            var lStageSv11 = new Stage { Name = Utils.NameStagesFescueSeed + " V11", ShortName = "V11", Description = "11 nudo", Order = 13, };
            var lStageSr1 = new Stage { Name = Utils.NameStagesFescueSeed + " R1", ShortName = "R1", Description = "Inicio Floracion", Order = 14, };
            var lStageSr2 = new Stage { Name = Utils.NameStagesFescueSeed + " R2", ShortName = "R2", Description = "Floracion Completa", Order = 15, };
            var lStageSr3 = new Stage { Name = Utils.NameStagesFescueSeed + " R3", ShortName = "R3", Description = "Inicio Vainas", Order = 16, };
            var lStageSr4 = new Stage { Name = Utils.NameStagesFescueSeed + " R4", ShortName = "R4", Description = "Vainas Completas", Order = 17, };
            var lStageSr5 = new Stage { Name = Utils.NameStagesFescueSeed + " R5", ShortName = "R5", Description = "Formacion de semillas", Order = 18, };
            var lStageSr6 = new Stage { Name = Utils.NameStagesFescueSeed + " R6", ShortName = "R6", Description = "Semillas Completas", Order = 19, };
            var lStageSr7 = new Stage { Name = Utils.NameStagesFescueSeed + " R7", ShortName = "R7", Description = "Inicio Maduracion", Order = 20, };
            var lStageSr8 = new Stage { Name = Utils.NameStagesFescueSeed + " R8", ShortName = "R8", Description = "Maduracion Completa", Order = 21, };


            using (var context = new IrrigationAdvisorContext())
            {
                //context.Stages.Add(lBase);
                context.Stages.Add(lStageSv0);
                context.Stages.Add(lStageSve);
                context.Stages.Add(lStageSv1);
                context.Stages.Add(lStageSv2);
                context.Stages.Add(lStageSv3);
                context.Stages.Add(lStageSv4);
                context.Stages.Add(lStageSv5);
                context.Stages.Add(lStageSv6);
                context.Stages.Add(lStageSv7);
                context.Stages.Add(lStageSv8);
                context.Stages.Add(lStageSv9);
                context.Stages.Add(lStageSv10);
                context.Stages.Add(lStageSv11);
                context.Stages.Add(lStageSr1);
                context.Stages.Add(lStageSr2);
                context.Stages.Add(lStageSr3);
                context.Stages.Add(lStageSr4);
                context.Stages.Add(lStageSr5);
                context.Stages.Add(lStageSr6);
                context.Stages.Add(lStageSr7);
                context.Stages.Add(lStageSr8);
                context.SaveChanges();
            };
        }

        #endregion

        #region PhenologicalStages

        public static void InsertPhenologicalStagesCornSouthShort()
        {
            #region Base
            var lBase = new PhenologicalStage
            {
                SpecieId = 0,
                StageId = 0,
                MinDegree = 0,
                MaxDegree = 0,
                Coefficient = 0,
                RootDepth = 0,
                HydricBalanceDepth = 0,
            };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {

                #region Corn
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieCornSouthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V0") select stage).FirstOrDefault();
                var lPSCornV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VE") select stage).FirstOrDefault();
                var lPSCornVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 114.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V1") select stage).FirstOrDefault();
                var lPSCornV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V2") select stage).FirstOrDefault();
                var lPSCornV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 179.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V3") select stage).FirstOrDefault();
                var lPSCornV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 180, MaxDegree = 229.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V4") select stage).FirstOrDefault();
                var lPSCornV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 230, MaxDegree = 289.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V5") select stage).FirstOrDefault();
                var lPSCornV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 349.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V6") select stage).FirstOrDefault();
                var lPSCornV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 350, MaxDegree = 404.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V7") select stage).FirstOrDefault();
                var lPSCornV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 405, MaxDegree = 459.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V8") select stage).FirstOrDefault();
                var lPSCornV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 519.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V9") select stage).FirstOrDefault();
                var lPSCornV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 520, MaxDegree = 589.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V10") select stage).FirstOrDefault();
                var lPSCornV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 590, MaxDegree = 649.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V11") select stage).FirstOrDefault();
                var lPSCornV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 650, MaxDegree = 689.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V12") select stage).FirstOrDefault();
                var lPSCornV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 690, MaxDegree = 714.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V13") select stage).FirstOrDefault();
                var lPSCornV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 715, MaxDegree = 749.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V14") select stage).FirstOrDefault();
                var lPSCornV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 750, MaxDegree = 774.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V15") select stage).FirstOrDefault();
                var lPSCornV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 775, MaxDegree = 889.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VT") select stage).FirstOrDefault();
                var lPSCornVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 890, MaxDegree = 1049.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R1") select stage).FirstOrDefault();
                var lPSCornR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1050, MaxDegree = 1199.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R2") select stage).FirstOrDefault();
                var lPSCornR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R3") select stage).FirstOrDefault();
                var lPSCornR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R4") select stage).FirstOrDefault();
                var lPSCornR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 1599.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R5") select stage).FirstOrDefault();
                var lPSCornR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1600, MaxDegree = 1899.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R6") select stage).FirstOrDefault();
                var lPSCornR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1900, MaxDegree = 2500, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, };

                #endregion

                #region Add to Context - Corn
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSCornV0);
                context.PhenologicalStages.Add(lPSCornVe);
                context.PhenologicalStages.Add(lPSCornV1);
                context.PhenologicalStages.Add(lPSCornV2);
                context.PhenologicalStages.Add(lPSCornV3);
                context.PhenologicalStages.Add(lPSCornV4);
                context.PhenologicalStages.Add(lPSCornV5);
                context.PhenologicalStages.Add(lPSCornV6);
                context.PhenologicalStages.Add(lPSCornV7);
                context.PhenologicalStages.Add(lPSCornV8);
                context.PhenologicalStages.Add(lPSCornV9);
                context.PhenologicalStages.Add(lPSCornV10);
                context.PhenologicalStages.Add(lPSCornV11);
                context.PhenologicalStages.Add(lPSCornV12);
                context.PhenologicalStages.Add(lPSCornV13);
                context.PhenologicalStages.Add(lPSCornV14);
                context.PhenologicalStages.Add(lPSCornV15);
                context.PhenologicalStages.Add(lPSCornVt);
                context.PhenologicalStages.Add(lPSCornR1);
                context.PhenologicalStages.Add(lPSCornR2);
                context.PhenologicalStages.Add(lPSCornR3);
                context.PhenologicalStages.Add(lPSCornR4);
                context.PhenologicalStages.Add(lPSCornR5);
                context.PhenologicalStages.Add(lPSCornR6);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesSoyaSouthShort()
        {

            #region Base
            var lBase = new PhenologicalStage
            {
                SpecieId = 0,
                StageId = 0,
                MinDegree = 0,
                MaxDegree = 0,
                Coefficient = 0,
                RootDepth = 0,
                HydricBalanceDepth = 0,
            };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {

                #region Soya South Short
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieSoyaSouthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V0") select stage).FirstOrDefault();
                var lPSSoyaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 114.999, Coefficient = 0.30, RootDepth = 7, HydricBalanceDepth = 17, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " VE") select stage).FirstOrDefault();
                var lPSSoyaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 141.999, Coefficient = 0.37, RootDepth = 10, HydricBalanceDepth = 20, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V1") select stage).FirstOrDefault();
                var lPSSoyaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 142, MaxDegree = 191.999, Coefficient = 0.40, RootDepth = 10, HydricBalanceDepth = 20, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V2") select stage).FirstOrDefault();
                var lPSSoyaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 192, MaxDegree = 242.999, Coefficient = 0.43, RootDepth = 12, HydricBalanceDepth = 22, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V3") select stage).FirstOrDefault();
                var lPSSoyaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 243, MaxDegree = 313.999, Coefficient = 0.45, RootDepth = 15, HydricBalanceDepth = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V4") select stage).FirstOrDefault();
                var lPSSoyaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 314, MaxDegree = 348.999, Coefficient = 0.50, RootDepth = 20, HydricBalanceDepth = 30, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V5") select stage).FirstOrDefault();
                var lPSSoyaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 349, MaxDegree = 397.999, Coefficient = 0.52, RootDepth = 20, HydricBalanceDepth = 30, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V6") select stage).FirstOrDefault();
                var lPSSoyaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 398, MaxDegree = 445.999, Coefficient = 0.54, RootDepth = 25, HydricBalanceDepth = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V7") select stage).FirstOrDefault();
                var lPSSoyaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 446, MaxDegree = 471.999, Coefficient = 0.57, RootDepth = 25, HydricBalanceDepth = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V8") select stage).FirstOrDefault();
                var lPSSoyaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 472, MaxDegree = 515.999, Coefficient = 0.59, RootDepth = 30, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V9") select stage).FirstOrDefault();
                var lPSSoyaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 516, MaxDegree = 565.999, Coefficient = 0.61, RootDepth = 32, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V10") select stage).FirstOrDefault();
                var lPSSoyaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 566, MaxDegree = 653.999, Coefficient = 0.63, RootDepth = 35, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 654, MaxDegree = 741.999, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R1") select stage).FirstOrDefault();
                var lPSSoyaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 742, MaxDegree = 843.999, Coefficient = 0.72, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R2") select stage).FirstOrDefault();
                var lPSSoyaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 844, MaxDegree = 911.999, Coefficient = 0.75, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R3") select stage).FirstOrDefault();
                var lPSSoyaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 912, MaxDegree = 979.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R4") select stage).FirstOrDefault();
                var lPSSoyaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 980, MaxDegree = 1098.999, Coefficient = 0.83, RootDepth = 40, HydricBalanceDepth = 45, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R5") select stage).FirstOrDefault();
                var lPSSoyaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1099, MaxDegree = 1217.999, Coefficient = 0.88, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R6") select stage).FirstOrDefault();
                var lPSSoyaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1218, MaxDegree = 1608.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R7") select stage).FirstOrDefault();
                var lPSSoyaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1609, MaxDegree = 1999.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R8") select stage).FirstOrDefault();
                var lPSSoyaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2000, MaxDegree = 4000, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, };

                #endregion

                #region Add to Context - Soya
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSSoyaV0);
                context.PhenologicalStages.Add(lPSSoyaVe);
                context.PhenologicalStages.Add(lPSSoyaV1);
                context.PhenologicalStages.Add(lPSSoyaV2);
                context.PhenologicalStages.Add(lPSSoyaV3);
                context.PhenologicalStages.Add(lPSSoyaV4);
                context.PhenologicalStages.Add(lPSSoyaV5);
                context.PhenologicalStages.Add(lPSSoyaV6);
                context.PhenologicalStages.Add(lPSSoyaV7);
                context.PhenologicalStages.Add(lPSSoyaV8);
                context.PhenologicalStages.Add(lPSSoyaV9);
                context.PhenologicalStages.Add(lPSSoyaV10);
                context.PhenologicalStages.Add(lPSSoyaV11);
                context.PhenologicalStages.Add(lPSSoyaR1);
                context.PhenologicalStages.Add(lPSSoyaR2);
                context.PhenologicalStages.Add(lPSSoyaR3);
                context.PhenologicalStages.Add(lPSSoyaR4);
                context.PhenologicalStages.Add(lPSSoyaR5);
                context.PhenologicalStages.Add(lPSSoyaR6);
                context.PhenologicalStages.Add(lPSSoyaR7);
                context.PhenologicalStages.Add(lPSSoyaR8);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesSoyaSouthMedium()
        {

            #region Base
            var lBase = new PhenologicalStage
            {
                SpecieId = 0,
                StageId = 0,
                MinDegree = 0,
                MaxDegree = 0,
                RootDepth = 0,
                HydricBalanceDepth = 0,
            };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {

                #region Soya South Medium
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieSoyaSouthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V0") select stage).FirstOrDefault();
                var lPSSoyaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 114.999, Coefficient = 0.30, RootDepth = 7, HydricBalanceDepth = 17, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " VE") select stage).FirstOrDefault();
                var lPSSoyaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 141.999, Coefficient = 0.37, RootDepth = 10, HydricBalanceDepth = 20, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V1") select stage).FirstOrDefault();
                var lPSSoyaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 142, MaxDegree = 191.999, Coefficient = 0.40, RootDepth = 10, HydricBalanceDepth = 20, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V2") select stage).FirstOrDefault();
                var lPSSoyaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 192, MaxDegree = 242.999, Coefficient = 0.43, RootDepth = 12, HydricBalanceDepth = 22, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V3") select stage).FirstOrDefault();
                var lPSSoyaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 243, MaxDegree = 313.999, Coefficient = 0.45, RootDepth = 15, HydricBalanceDepth = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V4") select stage).FirstOrDefault();
                var lPSSoyaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 314, MaxDegree = 348.999, Coefficient = 0.50, RootDepth = 20, HydricBalanceDepth = 30, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V5") select stage).FirstOrDefault();
                var lPSSoyaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 349, MaxDegree = 397.999, Coefficient = 0.52, RootDepth = 20, HydricBalanceDepth = 30, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V6") select stage).FirstOrDefault();
                var lPSSoyaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 398, MaxDegree = 445.999, Coefficient = 0.54, RootDepth = 25, HydricBalanceDepth = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V7") select stage).FirstOrDefault();
                var lPSSoyaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 446, MaxDegree = 471.999, Coefficient = 0.57, RootDepth = 25, HydricBalanceDepth = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V8") select stage).FirstOrDefault();
                var lPSSoyaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 472, MaxDegree = 515.999, Coefficient = 0.59, RootDepth = 30, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V9") select stage).FirstOrDefault();
                var lPSSoyaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 516, MaxDegree = 565.999, Coefficient = 0.61, RootDepth = 32, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V10") select stage).FirstOrDefault();
                var lPSSoyaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 566, MaxDegree = 653.999, Coefficient = 0.63, RootDepth = 35, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 654, MaxDegree = 741.999, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R1") select stage).FirstOrDefault();
                var lPSSoyaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 742, MaxDegree = 843.999, Coefficient = 0.72, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R2") select stage).FirstOrDefault();
                var lPSSoyaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 844, MaxDegree = 911.999, Coefficient = 0.75, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R3") select stage).FirstOrDefault();
                var lPSSoyaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 912, MaxDegree = 979.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R4") select stage).FirstOrDefault();
                var lPSSoyaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 980, MaxDegree = 1098.999, Coefficient = 0.83, RootDepth = 40, HydricBalanceDepth = 45, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R5") select stage).FirstOrDefault();
                var lPSSoyaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1099, MaxDegree = 1217.999, Coefficient = 0.88, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R6") select stage).FirstOrDefault();
                var lPSSoyaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1218, MaxDegree = 1608.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R7") select stage).FirstOrDefault();
                var lPSSoyaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1609, MaxDegree = 1999.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R8") select stage).FirstOrDefault();
                var lPSSoyaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2000, MaxDegree = 4000, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, };

                #endregion

                #region Add to Context - Soya
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSSoyaV0);
                context.PhenologicalStages.Add(lPSSoyaVe);
                context.PhenologicalStages.Add(lPSSoyaV1);
                context.PhenologicalStages.Add(lPSSoyaV2);
                context.PhenologicalStages.Add(lPSSoyaV3);
                context.PhenologicalStages.Add(lPSSoyaV4);
                context.PhenologicalStages.Add(lPSSoyaV5);
                context.PhenologicalStages.Add(lPSSoyaV6);
                context.PhenologicalStages.Add(lPSSoyaV7);
                context.PhenologicalStages.Add(lPSSoyaV8);
                context.PhenologicalStages.Add(lPSSoyaV9);
                context.PhenologicalStages.Add(lPSSoyaV10);
                context.PhenologicalStages.Add(lPSSoyaV11);
                context.PhenologicalStages.Add(lPSSoyaR1);
                context.PhenologicalStages.Add(lPSSoyaR2);
                context.PhenologicalStages.Add(lPSSoyaR3);
                context.PhenologicalStages.Add(lPSSoyaR4);
                context.PhenologicalStages.Add(lPSSoyaR5);
                context.PhenologicalStages.Add(lPSSoyaR6);
                context.PhenologicalStages.Add(lPSSoyaR7);
                context.PhenologicalStages.Add(lPSSoyaR8);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesCornNorthShort()
        {
            #region Base
            var lBase = new PhenologicalStage
            {
                SpecieId = 0,
                StageId = 0,
                MinDegree = 0,
                MaxDegree = 0,
                RootDepth = 0,
                HydricBalanceDepth = 0,
            };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {

                #region Corn
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieCornNorthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V0") select stage).FirstOrDefault();
                var lPSCornV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VE") select stage).FirstOrDefault();
                var lPSCornVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 114.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V1") select stage).FirstOrDefault();
                var lPSCornV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V2") select stage).FirstOrDefault();
                var lPSCornV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 179.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V3") select stage).FirstOrDefault();
                var lPSCornV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 180, MaxDegree = 229.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V4") select stage).FirstOrDefault();
                var lPSCornV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 230, MaxDegree = 289.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V5") select stage).FirstOrDefault();
                var lPSCornV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 349.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V6") select stage).FirstOrDefault();
                var lPSCornV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 350, MaxDegree = 404.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V7") select stage).FirstOrDefault();
                var lPSCornV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 405, MaxDegree = 459.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V8") select stage).FirstOrDefault();
                var lPSCornV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 519.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V9") select stage).FirstOrDefault();
                var lPSCornV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 520, MaxDegree = 589.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V10") select stage).FirstOrDefault();
                var lPSCornV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 590, MaxDegree = 649.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V11") select stage).FirstOrDefault();
                var lPSCornV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 650, MaxDegree = 689.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V12") select stage).FirstOrDefault();
                var lPSCornV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 690, MaxDegree = 714.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V13") select stage).FirstOrDefault();
                var lPSCornV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 715, MaxDegree = 749.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V14") select stage).FirstOrDefault();
                var lPSCornV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 750, MaxDegree = 774.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V15") select stage).FirstOrDefault();
                var lPSCornV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 775, MaxDegree = 889.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VT") select stage).FirstOrDefault();
                var lPSCornVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 890, MaxDegree = 1049.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R1") select stage).FirstOrDefault();
                var lPSCornR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1050, MaxDegree = 1199.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R2") select stage).FirstOrDefault();
                var lPSCornR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R3") select stage).FirstOrDefault();
                var lPSCornR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R4") select stage).FirstOrDefault();
                var lPSCornR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 1599.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R5") select stage).FirstOrDefault();
                var lPSCornR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1600, MaxDegree = 1899.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R6") select stage).FirstOrDefault();
                var lPSCornR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1900, MaxDegree = 2500, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, };

                #endregion

                #region Add to Context - Corn
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSCornV0);
                context.PhenologicalStages.Add(lPSCornVe);
                context.PhenologicalStages.Add(lPSCornV1);
                context.PhenologicalStages.Add(lPSCornV2);
                context.PhenologicalStages.Add(lPSCornV3);
                context.PhenologicalStages.Add(lPSCornV4);
                context.PhenologicalStages.Add(lPSCornV5);
                context.PhenologicalStages.Add(lPSCornV6);
                context.PhenologicalStages.Add(lPSCornV7);
                context.PhenologicalStages.Add(lPSCornV8);
                context.PhenologicalStages.Add(lPSCornV9);
                context.PhenologicalStages.Add(lPSCornV10);
                context.PhenologicalStages.Add(lPSCornV11);
                context.PhenologicalStages.Add(lPSCornV12);
                context.PhenologicalStages.Add(lPSCornV13);
                context.PhenologicalStages.Add(lPSCornV14);
                context.PhenologicalStages.Add(lPSCornV15);
                context.PhenologicalStages.Add(lPSCornVt);
                context.PhenologicalStages.Add(lPSCornR1);
                context.PhenologicalStages.Add(lPSCornR2);
                context.PhenologicalStages.Add(lPSCornR3);
                context.PhenologicalStages.Add(lPSCornR4);
                context.PhenologicalStages.Add(lPSCornR5);
                context.PhenologicalStages.Add(lPSCornR6);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesSoyaNorthShort()
        {

            #region Base
            var lBase = new PhenologicalStage
            {
                SpecieId = 0,
                StageId = 0,
                MinDegree = 0,
                MaxDegree = 0,
                RootDepth = 0,
                HydricBalanceDepth = 0,
            };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {

                #region Soya North Short
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieSoyaNorthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V0") select stage).FirstOrDefault();
                var lPSSoyaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 114.999, Coefficient = 0.30, RootDepth = 7, HydricBalanceDepth = 17, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " VE") select stage).FirstOrDefault();
                var lPSSoyaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 141.999, Coefficient = 0.37, RootDepth = 10, HydricBalanceDepth = 20, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V1") select stage).FirstOrDefault();
                var lPSSoyaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 142, MaxDegree = 191.999, Coefficient = 0.40, RootDepth = 10, HydricBalanceDepth = 20, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V2") select stage).FirstOrDefault();
                var lPSSoyaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 192, MaxDegree = 242.999, Coefficient = 0.43, RootDepth = 12, HydricBalanceDepth = 22, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V3") select stage).FirstOrDefault();
                var lPSSoyaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 243, MaxDegree = 313.999, Coefficient = 0.45, RootDepth = 15, HydricBalanceDepth = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V4") select stage).FirstOrDefault();
                var lPSSoyaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 314, MaxDegree = 348.999, Coefficient = 0.50, RootDepth = 20, HydricBalanceDepth = 30, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V5") select stage).FirstOrDefault();
                var lPSSoyaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 349, MaxDegree = 397.999, Coefficient = 0.52, RootDepth = 20, HydricBalanceDepth = 30, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V6") select stage).FirstOrDefault();
                var lPSSoyaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 398, MaxDegree = 445.999, Coefficient = 0.54, RootDepth = 25, HydricBalanceDepth = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V7") select stage).FirstOrDefault();
                var lPSSoyaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 446, MaxDegree = 471.999, Coefficient = 0.57, RootDepth = 25, HydricBalanceDepth = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V8") select stage).FirstOrDefault();
                var lPSSoyaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 472, MaxDegree = 515.999, Coefficient = 0.59, RootDepth = 30, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V9") select stage).FirstOrDefault();
                var lPSSoyaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 516, MaxDegree = 565.999, Coefficient = 0.61, RootDepth = 32, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V10") select stage).FirstOrDefault();
                var lPSSoyaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 566, MaxDegree = 653.999, Coefficient = 0.63, RootDepth = 35, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 654, MaxDegree = 741.999, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R1") select stage).FirstOrDefault();
                var lPSSoyaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 742, MaxDegree = 843.999, Coefficient = 0.72, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R2") select stage).FirstOrDefault();
                var lPSSoyaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 844, MaxDegree = 911.999, Coefficient = 0.75, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R3") select stage).FirstOrDefault();
                var lPSSoyaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 912, MaxDegree = 979.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R4") select stage).FirstOrDefault();
                var lPSSoyaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 980, MaxDegree = 1098.999, Coefficient = 0.83, RootDepth = 40, HydricBalanceDepth = 45, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R5") select stage).FirstOrDefault();
                var lPSSoyaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1099, MaxDegree = 1217.999, Coefficient = 0.88, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R6") select stage).FirstOrDefault();
                var lPSSoyaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1218, MaxDegree = 1608.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R7") select stage).FirstOrDefault();
                var lPSSoyaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1609, MaxDegree = 1999.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R8") select stage).FirstOrDefault();
                var lPSSoyaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2000, MaxDegree = 4000, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, };

                #endregion

                #region Add to Context - Soya
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSSoyaV0);
                context.PhenologicalStages.Add(lPSSoyaVe);
                context.PhenologicalStages.Add(lPSSoyaV1);
                context.PhenologicalStages.Add(lPSSoyaV2);
                context.PhenologicalStages.Add(lPSSoyaV3);
                context.PhenologicalStages.Add(lPSSoyaV4);
                context.PhenologicalStages.Add(lPSSoyaV5);
                context.PhenologicalStages.Add(lPSSoyaV6);
                context.PhenologicalStages.Add(lPSSoyaV7);
                context.PhenologicalStages.Add(lPSSoyaV8);
                context.PhenologicalStages.Add(lPSSoyaV9);
                context.PhenologicalStages.Add(lPSSoyaV10);
                context.PhenologicalStages.Add(lPSSoyaV11);
                context.PhenologicalStages.Add(lPSSoyaR1);
                context.PhenologicalStages.Add(lPSSoyaR2);
                context.PhenologicalStages.Add(lPSSoyaR3);
                context.PhenologicalStages.Add(lPSSoyaR4);
                context.PhenologicalStages.Add(lPSSoyaR5);
                context.PhenologicalStages.Add(lPSSoyaR6);
                context.PhenologicalStages.Add(lPSSoyaR7);
                context.PhenologicalStages.Add(lPSSoyaR8);
                context.SaveChanges();
                #endregion
            };
        }

        #endregion

        public static void InsertHorizons()
        {
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
            };
            #endregion

            #region Horizons Demo1 - La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                #region Pivot 11
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
                };
                #endregion

                #region Pivot 12
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
                };
                #endregion

                #region Pivot 13
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
                };
                #endregion

                #region Pivot 15
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
                };
                #endregion

                using (var context = new IrrigationAdvisorContext())
                {
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
                #region Pivot 21
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
                };
                #endregion

                #region Pivot 22
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
                };
                #endregion

                #region Pivot 23
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
                };
                #endregion

                #region Pivot 24
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
                };

                #endregion

                #region Pivot 25
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
                };
                #endregion

                using (var context = new IrrigationAdvisorContext())
                {
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
                #region Pivot 31
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
                };
                #endregion

                #region Pivot 32
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
                };
                #endregion

                #region Pivot 33
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
                };
                #endregion

                #region Pivot 34
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
                };
                #endregion

                #region Pivot 35
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
                };
                #endregion

                using (var context = new IrrigationAdvisorContext())
                {
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
            {
                #region Pivot 1
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
                };
                #endregion

                #region Pivot 2
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
                };
                #endregion

                #region Pivot 3
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
                };
                #endregion

                #region Pivot 4
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
                };
                #endregion

                #region Pivot 5
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
                };
                #endregion

                using (var context = new IrrigationAdvisorContext())
                {
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
            {
                #region Pivot 1
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
                };
                #endregion
                #region Pivot 2
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
                };
                #endregion
                #region Pivot 3
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
                };
                #endregion
                #region Pivot 4
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
                };
                #endregion
                #region Pivot 5
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
                };
                #endregion
                #region Pivot 6
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
                };
                #endregion
                #region Pivot 7
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
                };
                #endregion

                using (var context = new IrrigationAdvisorContext())
                {
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
            {
                #region Pivot 1
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
                };
                #endregion
                #region Pivot 2
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
                };
                #endregion
                #region Pivot 3
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
                };
                #endregion
                #region Pivot 4
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
                };
                #endregion

                using (var context = new IrrigationAdvisorContext())
                {
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                #region Pivot 1
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
                };
                #endregion
                #region Pivot 2
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
                };
                #endregion
                #region Pivot 3
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
                };
                #endregion
                #region Pivot 4
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
                };
                #endregion
                #region Pivot 5
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
                };
                #endregion
                #region Pivot 6
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
                };
                #endregion
                #region Pivot 7
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
                };
                #endregion
                #region Pivot 8
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
                };
                #endregion
                #region Pivot 9
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
                };
                #endregion
                #region Pivot 10a
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
                };
                #endregion
                #region Pivot 10b
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
                };
                #endregion
                #region Pivot 11
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
                };
                #endregion
                #region Pivot 12
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
                };
                #endregion
                #region Pivot 13
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
                };
                #endregion
                #region Pivot 14
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
                };
                #endregion
                #region Pivot 15
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
                };
                #endregion

                using (var context = new IrrigationAdvisorContext())
                {
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                #region Pivot 5
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
                };

                #endregion

                #region Pivot 6
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
                };

                #endregion

                #region Pivot 7
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
                };

                #endregion

                #region Pivot 8
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
                };
                #endregion

                using (var context = new IrrigationAdvisorContext())
                {
                    #region Horizons Del Lago - San Pedro
                    context.Horizons.Add(lDelLagoSanPedroPivot_5_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_5_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_6_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_6_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_7_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_7_2);
                    context.Horizons.Add(lDelLagoSanPedroPivot_8_1);
                    context.Horizons.Add(lDelLagoSanPedroPivot_8_2);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion

            #region Horizons Del Lago - El Mirador
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {

                #region Pivot 1
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
                };
                #endregion

                #region Pivot 2
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
                };
                #endregion

                #region Pivot 3
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
                };
                #endregion

                #region Pivot 4
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
                };
                #endregion

                #region Pivot 5
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
                };
                #endregion

                #region Pivot 6
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
                };
                #endregion

                #region Pivot 7
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
                };
                #endregion

                #region Pivot 8
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
                };
                #endregion

                #region Pivot 9
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
                };
                #endregion

                #region Pivot 10
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
                };
                #endregion

                #region Pivot 11
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
                };
                #endregion

                #region Pivot 12
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
                };
                #endregion

                #region Pivot 13
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
                };
                #endregion

                #region Pivot 14
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
                };
                #endregion

                #region Pivot 15
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
                };
                #endregion

                #region Pivot Chaja 1
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
                };
                #endregion

                #region Pivot Chaja 2
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
                };
                #endregion

                using (var context = new IrrigationAdvisorContext())
                {
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
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion

            #region Horizons GMO - La Palma
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
            {

                #region Pivot 1
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
                };
                #endregion

                #region Pivot 2
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
                };
                #endregion

                #region Pivot 3
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
                };

                #endregion

                #region Pivot 4
                var lGMOLaPalmaPivot_4_1 = new Horizon
                {
                    Name = Utils.NamePivotGMOLaPalma4 + " 1",
                    Order = 1,
                    HorizonLayer = "A",
                    HorizonLayerDepth = 25,
                    Sand = 42,
                    Limo = 33,
                    Clay = 25,
                    OrganicMatter = 2.5,
                    NitrogenAnalysis = 0,
                    BulkDensitySoil = 1.15,
                };
                var lGMOLaPalmaPivot_4_2 = new Horizon
                {
                    Name = Utils.NamePivotGMOLaPalma4 + " 2",
                    Order = 2,
                    HorizonLayer = "B1",
                    HorizonLayerDepth = 20,
                    Sand = 35,
                    Limo = 35,
                    Clay = 30,
                    OrganicMatter = 2.0,
                    NitrogenAnalysis = 0,
                    BulkDensitySoil = 1.25,
                };
                var lGMOLaPalmaPivot_4_3 = new Horizon
                {
                    Name = Utils.NamePivotGMOLaPalma4 + " 3",
                    Order = 3,
                    HorizonLayer = "B2",
                    HorizonLayerDepth = 30,
                    Sand = 29,
                    Limo = 37,
                    Clay = 34,
                    OrganicMatter = 1.3,
                    NitrogenAnalysis = 0,
                    BulkDensitySoil = 1.35,
                };
                #endregion

                #region Pivot 5
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
                };
                #endregion

                using (var context = new IrrigationAdvisorContext())
                {
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
                    context.Horizons.Add(lGMOLaPalmaPivot_5_1);
                    context.Horizons.Add(lGMOLaPalmaPivot_5_2);
                    context.Horizons.Add(lGMOLaPalmaPivot_5_3);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion

            #region Horizons GMO - El Tacuru
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
            {

                #region Pivot 1a
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
                };

                #endregion
                #region Pivot 1b
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
                };

                #endregion
                #region Pivot 2a
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
                };

                #endregion
                #region Pivot 2b
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
                };

                #endregion
                #region Pivot 3a
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
                };

                #endregion
                #region Pivot 3b
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
                };

                #endregion
                #region Pivot 4
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
                };

                #endregion
                #region Pivot 5
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
                };

                #endregion
                #region Pivot 6
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
                };

                #endregion
                #region Pivot 7
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
                };

                #endregion
                #region Pivot 8
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
                };

                #endregion
                #region Pivot 9
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
                };

                #endregion
                #region Pivot 10
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
                };

                #endregion

                using (var context = new IrrigationAdvisorContext())
                {
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
            {

                #region Pivot 1
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
                };
                #endregion

                #region Pivot 2
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
                };
                #endregion

                #region Pivot 3
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
                };
                #endregion

                #region Pivot 4
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
                };
                #endregion

                using (var context = new IrrigationAdvisorContext())
                {
                    #region Horizons La Rinconada
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
            {

                #region Pivot 1
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
                };
                #endregion

                #region Pivot 2
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
                };
                #endregion

                #region Pivot 3.1
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
                };

                #endregion

                #region Pivot 13.1
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
                };
                #endregion

                using (var context = new IrrigationAdvisorContext())
                {
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
            Position lPosition = null;
            Horizon lHorizon1 = null;
            Horizon lHorizon2 = null;
            Horizon lHorizon3 = null;
            Horizon lHorizon4 = null;

            #region Base
            var lBase = new Soil
            {
                Name = Utils.NameBase,
                Description = "",
                PositionId = 0,
                TestDate = Utils.MIN_DATETIME,
                DepthLimit = 0,
            };
            #endregion

            #region Demo1 Soils - La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {

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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
            {
                using (var context = new IrrigationAdvisorContext())
                {

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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
            {
                using (var context = new IrrigationAdvisorContext())
                {

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
                        Description = "Suelo del Pivot 2 en El Paraiso. Unidad Bequlo con incidencia de Villa Soriano.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 55,
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
                        Description = "Suelo del Pivot 3 en El Paraiso. Unidad Bequlo con incidencia de Villa Soriano.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 55,
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
                        Description = "Suelo del Pivot 4 en El Paraiso. Unidad Bequlo con incidencia de Villa Soriano.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 55,
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {

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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {

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
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoSanPedroPivot8.HorizonList.Add(lHorizon1);
                    lDelLagoSanPedroPivot8.HorizonList.Add(lHorizon2);
                    #endregion

                    //context.Soils.Add(lBase);
                    context.Soils.Add(lDelLagoSanPedroPivot5);
                    context.Soils.Add(lDelLagoSanPedroPivot6);
                    context.Soils.Add(lDelLagoSanPedroPivot7);
                    context.Soils.Add(lDelLagoSanPedroPivot8);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Del Lago - El Mirador Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                using (var context = new IrrigationAdvisorContext())
                {

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
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivotChaja2.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivotChaja2.HorizonList.Add(lHorizon2);
                    lDelLagoElMiradorPivotChaja2.HorizonList.Add(lHorizon3);
                    lDelLagoElMiradorPivotChaja2.HorizonList.Add(lHorizon4);
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
                    context.SaveChanges();
                }
            }
            #endregion

            #region GMO - La Palma Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {

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
                        DepthLimit = 45,
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
                        DepthLimit = 45,
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
                        DepthLimit = 45,
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
                    var lGMOLaPalmaPivot4 = new Soil
                    {
                        Name = Utils.NamePivotGMOLaPalma4,
                        Description = "Suelo del Pivot 4 en La Palma. "
                         + "Brunosol.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2016, 09, 28),
                        DepthLimit = 45,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOLaPalmaPivot4.HorizonList.Add(lHorizon1);
                    lGMOLaPalmaPivot4.HorizonList.Add(lHorizon2);
                    lGMOLaPalmaPivot4.HorizonList.Add(lHorizon3);
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
                        DepthLimit = 45,
                        HorizonList = new List<Horizon>(),
                    };
                    lGMOLaPalmaPivot5.HorizonList.Add(lHorizon1);
                    lGMOLaPalmaPivot5.HorizonList.Add(lHorizon2);
                    lGMOLaPalmaPivot5.HorizonList.Add(lHorizon3);
                    #endregion

                    context.Soils.Add(lGMOLaPalmaPivot1);
                    context.Soils.Add(lGMOLaPalmaPivot2);
                    context.Soils.Add(lGMOLaPalmaPivot3);
                    context.Soils.Add(lGMOLaPalmaPivot4);
                    context.Soils.Add(lGMOLaPalmaPivot5);
                    context.SaveChanges();
                }
            }
            #endregion

            #region GMO - El Tacuru Soils
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
            {
                using (var context = new IrrigationAdvisorContext())
                {

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
                        DepthLimit = 40,
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
                        DepthLimit = 40,
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
                        DepthLimit = 40,
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
                        DepthLimit = 40,
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
                        DepthLimit = 40,
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
                        DepthLimit = 40,
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
                        DepthLimit = 40,
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
                        DepthLimit = 40,
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
                        DepthLimit = 40,
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
                        DepthLimit = 40,
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
                        DepthLimit = 40,
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
                        DepthLimit = 40,
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
                        DepthLimit = 40,
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
            {
                using (var context = new IrrigationAdvisorContext())
                {

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
                                 where hor.Name == Utils.NamePivotTresMarias4+ " 2"
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
            {
                using (var context = new IrrigationAdvisorContext())
                {

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

        }

        public static void InsertCropCoefficients()
        {
            #region Base
            var lBase = new CropCoefficient()
            {
                Name = Utils.NameBase,
                SpecieId = 0,
                KCList = new List<KC>(),
            };
            #endregion

            Specie lSpecie = null;

            #region Crop Coefficient Corn South Short
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieCornSouthShort)
                           select specie).FirstOrDefault();
                var lCropCoefficientCornSouthShort = new CropCoefficient
                {
                    Name = Utils.NameSpecieCornSouthShort,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientCornSouthShort = InitialTables.CreateUpdateCropCoefficient_CornSouthShort(lCropCoefficientCornSouthShort, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientCornSouthShort);
                context.SaveChanges();
            }
            #endregion

            #region Crop Coefficient Soya South Short
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieSoyaSouthShort)
                           select specie).FirstOrDefault();
                var lCropCoefficientSoyaSouthShort = new CropCoefficient
                {
                    Name = Utils.NameSpecieSoyaSouthShort,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientSoyaSouthShort = InitialTables.CreateUpdateCropCoefficient_SoyaSouthShort(lCropCoefficientSoyaSouthShort, 1, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientSoyaSouthShort);
                context.SaveChanges();
            }
            #endregion

            #region Crop Coefficient Soya South Medium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieSoyaSouthMedium)
                           select specie).FirstOrDefault();
                var lCropCoefficientSoyaSouthMedium = new CropCoefficient
                {
                    Name = Utils.NameSpecieSoyaSouthMedium,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientSoyaSouthMedium = InitialTables.CreateUpdateCropCoefficient_SoyaSouthMedium(lCropCoefficientSoyaSouthMedium, 1, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientSoyaSouthMedium);
                context.SaveChanges();
            }
            #endregion

            #region Crop Coefficient Corn North Short
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieCornNorthShort)
                           select specie).FirstOrDefault();
                var lCropCoefficientCornNorthShort = new CropCoefficient
                {
                    Name = Utils.NameSpecieCornNorthShort,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientCornNorthShort = InitialTables.CreateUpdateCropCoefficient_CornNorthShort(lCropCoefficientCornNorthShort, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientCornNorthShort);
                context.SaveChanges();
            }
            #endregion

            #region Crop Coefficient Soya North Short
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieSoyaNorthShort)
                           select specie).FirstOrDefault();
                var lCropCoefficientSoyaNorthShort = new CropCoefficient
                {
                    Name = Utils.NameSpecieSoyaNorthShort,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientSoyaNorthShort = InitialTables.CreateUpdateCropCoefficient_SoyaNorthShort(lCropCoefficientSoyaNorthShort, 1, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientSoyaNorthShort);
                context.SaveChanges();
            }
            #endregion

        }

#endif
        #endregion

    }
}