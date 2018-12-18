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
    public static class AgricultureInsert
    {

        #region Agriculture
#if true

        public static void InsertSpecieCycles()
        {
            #region Base
            Region lRegion = null;
            using (var context = new IrrigationAdvisorContext())
            {           
                var lBase = new SpecieCycle
                {
                    Name = Utils.NameBase,
                    Duration = 0,
                    Region = null,
                };
                #endregion

                #region Sur
                lRegion = (from pos in context.Regions
                           where pos.Name == Utils.NameRegionSouth
                           select pos).FirstOrDefault();
                var lSurCorto = new SpecieCycle
                {
                    Name = Utils.NameSpecieCycleSouthShort,
                    Duration = 145,
                    RegionId = lRegion.RegionId,
                };

                var lSurMedio = new SpecieCycle
                {
                    Name = Utils.NameSpecieCycleSouthMedium,
                    Duration = 160,
                    RegionId = lRegion.RegionId,
                };

                var lSurLargo = new SpecieCycle
                {
                    Name = Utils.NameSpecieCycleSouthLong,
                    Duration = 180,
                    RegionId = lRegion.RegionId,
                };

                #endregion

                #region Norte
                lRegion = (from pos in context.Regions
                           where pos.Name == Utils.NameRegionNorth
                           select pos).FirstOrDefault();
                var lNorthShort = new SpecieCycle
                {
                    Name = Utils.NameSpecieCycleNorthShort,
                    Duration = 160,
                    RegionId = lRegion.RegionId,
                };

                var lNorthMedium = new SpecieCycle
                {
                    Name = Utils.NameSpecieCycleNorthMedium,
                    Duration = 180,
                    RegionId = lRegion.RegionId,
                };

                var lNorthLong = new SpecieCycle
                {
                    Name = Utils.NameSpecieCycleNorthLong,
                    Duration = 200,
                    RegionId = lRegion.RegionId,
                };
                #endregion


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

        public static void InsertSpecies_2016()
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
                    BaseTemperature = DataEntry2016.BaseTemperature_CornSouth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_CornSouth_2016,
                    SpecieType = Utils.SpecieType.Grains,
                };

                context.Species.Add(lCornSouthShort);
                context.SaveChanges();
            }
            #endregion
            #region CornSouthMedium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthMedium);

                var lCornSouthMedium = new Specie
                {
                    Name = Utils.NameSpecieCornSouthMedium,
                    ShortName = "Maíz",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2016.BaseTemperature_CornSouth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_CornSouth_2016,
                    SpecieType = Utils.SpecieType.Grains,
                };

                context.Species.Add(lCornSouthMedium);
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
                    BaseTemperature = DataEntry2016.BaseTemperature_SoyaSouth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_SoyaSouth_2016,
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
                    BaseTemperature = DataEntry2016.BaseTemperature_SoyaSouth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_SoyaSouth_2016,
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
                    BaseTemperature = DataEntry2016.BaseTemperature_SorghumForageSouth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_SorghumForageSouth_2016,
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
                    BaseTemperature = DataEntry2016.BaseTemperature_SorghumGrainSouth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_SorghumGrainSouth_2016,
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
                    BaseTemperature = DataEntry2016.BaseTemperature_AlfalfaSouth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_AlfalfaSouth_2016,
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
                    BaseTemperature = DataEntry2016.BaseTemperature_RedCloverForageSouth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_RedCloverForageSouth_2016,
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
                    BaseTemperature = DataEntry2016.BaseTemperature_RedCloverSeedSouth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_RedCloverSeedSouth_2016,
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
                    BaseTemperature = DataEntry2016.BaseTemperature_FescueForageSouth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_FescueForageSouth_2016,
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
                    BaseTemperature = DataEntry2016.BaseTemperature_FescueSeedSouth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_FescueSeedSouth_2016,
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
                    BaseTemperature = DataEntry2016.BaseTemperature_CornNorth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_CornNorth_2016,
                    SpecieType = Utils.SpecieType.Grains,
                };
                context.Species.Add(lCornNorthShort);
                context.SaveChanges();
            }
            #endregion
            #region Corn North Medium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthMedium);
                var lCornNorthMedium = new Specie
                {
                    Name = Utils.NameSpecieCornNorthMedium,
                    ShortName = "Maíz",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2016.BaseTemperature_CornNorth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_CornNorth_2016,
                    SpecieType = Utils.SpecieType.Grains,
                };
                context.Species.Add(lCornNorthMedium);
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
                    BaseTemperature = DataEntry2016.BaseTemperature_SoyaNorth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_SoyaNorth_2016,
                    SpecieType = Utils.SpecieType.Grains,
                };
                context.Species.Add(lSoyaNorthShort);
                context.SaveChanges();
            }
            #endregion
            #region Soya North Medium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthMedium);

                var lSoyaNorthMedium = new Specie
                {
                    Name = Utils.NameSpecieSoyaNorthMedium,
                    ShortName = "Soja",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2016.BaseTemperature_SoyaNorth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_SoyaNorth_2016,
                    SpecieType = Utils.SpecieType.Grains,
                };
                context.Species.Add(lSoyaNorthMedium);
                context.SaveChanges();
            }
            #endregion

            #region AlfalfaNorthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthShort);

                var lAlfalfaNorthShort = new Specie
                {
                    Name = Utils.NameSpecieAlfalfaNorthShort,
                    ShortName = "Alfalfa",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2016.BaseTemperature_AlfalfaNorth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_AlfalfaNorth_2016,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lAlfalfaNorthShort);
                context.SaveChanges();
            }
            #endregion

            #region FescueForageNorthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthShort);

                var lFescueForageNorthShort = new Specie
                {
                    Name = Utils.NameSpecieFescueForageNorthShort,
                    ShortName = "Festuca Forraje",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2016.BaseTemperature_FescueForageNorth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_FescueForageNorth_2016,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lFescueForageNorthShort);
                context.SaveChanges();
            }
            #endregion
            #region FescueSeedNorthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthShort);

                var lFescueSeedNorthShort = new Specie
                {
                    Name = Utils.NameSpecieFescueSeedNorthShort,
                    ShortName = "Festuca Semilla",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2016.BaseTemperature_FescueSeedNorth_2016,
                    StressTemperature = DataEntry2016.StressTemperature_FescueSeedNorth_2016,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lFescueSeedNorthShort);
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

        public static void InsertSpecies_2017()
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
                    BaseTemperature = DataEntry2017.BaseTemperature_CornSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_CornSouth_2017,
                    SpecieType = Utils.SpecieType.Grains,
                };

                context.Species.Add(lCornSouthShort);
                context.SaveChanges();
            }
            #endregion
            #region CornSouthMedium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthMedium);

                var lCornSouthMedium = new Specie
                {
                    Name = Utils.NameSpecieCornSouthMedium,
                    ShortName = "Maíz",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_CornSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_CornSouth_2017,
                    SpecieType = Utils.SpecieType.Grains,
                };

                context.Species.Add(lCornSouthMedium);
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
                    BaseTemperature = DataEntry2017.BaseTemperature_SoyaSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_SoyaSouth_2017,
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
                    BaseTemperature = DataEntry2017.BaseTemperature_SoyaSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_SoyaSouth_2017,
                    SpecieType = Utils.SpecieType.Grains,
                };

                context.Species.Add(lSoyaSouthMedium);
                context.SaveChanges();
            }
            #endregion

            #region OatSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                var lOatSouthShort = new Specie
                {
                    Name = Utils.NameSpecieOatSouthShort,
                    ShortName = "Avena",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_OatSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_OatSouth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lOatSouthShort);
                context.SaveChanges();
            }
            #endregion
            #region OatSouthMedium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthMedium);

                var lOatSouthMedium = new Specie
                {
                    Name = Utils.NameSpecieOatSouthMedium,
                    ShortName = "Avena",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_OatSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_OatSouth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lOatSouthMedium);
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
                    BaseTemperature = DataEntry2017.BaseTemperature_SorghumForageSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_SorghumForageSouth_2017,
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
                    BaseTemperature = DataEntry2017.BaseTemperature_SorghumGrainSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_SorghumGrainSouth_2017,
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
                    BaseTemperature = DataEntry2017.BaseTemperature_AlfalfaSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_AlfalfaSouth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lAlfalfaSouthShort);
                context.SaveChanges();
            }
            #endregion
            #region AlfalfaSouthMedium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthMedium);

                var lAlfalfaSouthMedium = new Specie
                {
                    Name = Utils.NameSpecieAlfalfaSouthMedium,
                    ShortName = "Alfalfa",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_AlfalfaSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_AlfalfaSouth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lAlfalfaSouthMedium);
                context.SaveChanges();
            }
            #endregion

            #region SudanGrassSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                var lSudanGrassSouthShort = new Specie
                {
                    Name = Utils.NameSpecieSudanGrassSouthShort,
                    ShortName = "SudanGrass",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_SudanGrassSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_SudanGrassSouth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lSudanGrassSouthShort);
                context.SaveChanges();
            }
            #endregion
            #region SudanGrassSouthMedium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthMedium);

                var lSudanGrassSouthMedium = new Specie
                {
                    Name = Utils.NameSpecieSudanGrassSouthMedium,
                    ShortName = "SudanGrass",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_SudanGrassSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_SudanGrassSouth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lSudanGrassSouthMedium);
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
                    BaseTemperature = DataEntry2017.BaseTemperature_RedCloverForageSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_RedCloverForageSouth_2017,
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
                    BaseTemperature = DataEntry2017.BaseTemperature_RedCloverSeedSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_RedCloverSeedSouth_2017,
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
                    BaseTemperature = DataEntry2017.BaseTemperature_FescueForageSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_FescueForageSouth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lFescueForageSouthShort);
                context.SaveChanges();
            }
            #endregion
            #region FescueForageSouthMedium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthMedium);

                var lFescueForageSouthMedium = new Specie
                {
                    Name = Utils.NameSpecieFescueForageSouthMedium,
                    ShortName = "Festuca Forraje",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_FescueForageSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_FescueForageSouth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lFescueForageSouthMedium);
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
                    BaseTemperature = DataEntry2017.BaseTemperature_FescueSeedSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_FescueSeedSouth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lFescueSeedSouthShort);
                context.SaveChanges();
            }
            #endregion
            #region FescueSeedSouthMedium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthMedium);

                var lFescueSeedSouthMedium = new Specie
                {
                    Name = Utils.NameSpecieFescueSeedSouthMedium,
                    ShortName = "Festuca Semilla",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_FescueSeedSouth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_FescueSeedSouth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lFescueSeedSouthMedium);
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
                    BaseTemperature = DataEntry2017.BaseTemperature_CornNorth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_CornNorth_2017,
                    SpecieType = Utils.SpecieType.Grains,
                };
                context.Species.Add(lCornNorthShort);
                context.SaveChanges();
            }
            #endregion
            #region Corn North Medium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthMedium);
                var lCornNorthMedium = new Specie
                {
                    Name = Utils.NameSpecieCornNorthMedium,
                    ShortName = "Maíz",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_CornNorth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_CornNorth_2017,
                    SpecieType = Utils.SpecieType.Grains,
                };
                context.Species.Add(lCornNorthMedium);
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
                    BaseTemperature = DataEntry2017.BaseTemperature_SoyaNorth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_SoyaNorth_2017,
                    SpecieType = Utils.SpecieType.Grains,
                };
                context.Species.Add(lSoyaNorthShort);
                context.SaveChanges();
            }
            #endregion
            #region Soya North Medium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthMedium);

                var lSoyaNorthMedium = new Specie
                {
                    Name = Utils.NameSpecieSoyaNorthMedium,
                    ShortName = "Soja",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_SoyaNorth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_SoyaNorth_2017,
                    SpecieType = Utils.SpecieType.Grains,
                };
                context.Species.Add(lSoyaNorthMedium);
                context.SaveChanges();
            }
            #endregion

            #region OatNorthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthShort);

                var lOatNorthShort = new Specie
                {
                    Name = Utils.NameSpecieOatNorthShort,
                    ShortName = "Avena",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_OatNorth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_OatNorth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lOatNorthShort);
                context.SaveChanges();
            }
            #endregion
            #region OatNorthMedium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthMedium);

                var lOatNorthMedium = new Specie
                {
                    Name = Utils.NameSpecieOatNorthMedium,
                    ShortName = "Avena",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_OatNorth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_OatNorth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lOatNorthMedium);
                context.SaveChanges();
            }
            #endregion

            #region AlfalfaNorthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthShort);

                var lAlfalfaNorthShort = new Specie
                {
                    Name = Utils.NameSpecieAlfalfaNorthShort,
                    ShortName = "Alfalfa",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_AlfalfaNorth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_AlfalfaNorth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lAlfalfaNorthShort);
                context.SaveChanges();
            }
            #endregion
            #region AlfalfaNorthMedium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthMedium);

                var lAlfalfaNorthMedium = new Specie
                {
                    Name = Utils.NameSpecieAlfalfaNorthMedium,
                    ShortName = "Alfalfa",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_AlfalfaNorth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_AlfalfaNorth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lAlfalfaNorthMedium);
                context.SaveChanges();
            }
            #endregion

            #region SudanGrassNorthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthShort);

                var lSudanGrassNorthShort = new Specie
                {
                    Name = Utils.NameSpecieSudanGrassNorthShort,
                    ShortName = "SudanGrass",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_SudanGrassNorth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_SudanGrassNorth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lSudanGrassNorthShort);
                context.SaveChanges();
            }
            #endregion
            #region SudanGrassNorthMedium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthMedium);

                var lSudanGrassNorthMedium = new Specie
                {
                    Name = Utils.NameSpecieSudanGrassNorthMedium,
                    ShortName = "SudanGrass",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_SudanGrassNorth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_SudanGrassNorth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lSudanGrassNorthMedium);
                context.SaveChanges();
            }
            #endregion

            #region FescueForageNorthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthShort);

                var lFescueForageNorthShort = new Specie
                {
                    Name = Utils.NameSpecieFescueForageNorthShort,
                    ShortName = "Festuca Forraje",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_FescueForageNorth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_FescueForageNorth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lFescueForageNorthShort);
                context.SaveChanges();
            }
            #endregion
            #region FescueForageNorthMedium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthMedium);

                var lFescueForageNorthMedium = new Specie
                {
                    Name = Utils.NameSpecieFescueForageNorthMedium,
                    ShortName = "Festuca Forraje",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_FescueForageNorth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_FescueForageNorth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lFescueForageNorthMedium);
                context.SaveChanges();
            }
            #endregion
            #region FescueSeedNorthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthShort);

                var lFescueSeedNorthShort = new Specie
                {
                    Name = Utils.NameSpecieFescueSeedNorthShort,
                    ShortName = "Festuca Semilla",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_FescueSeedNorth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_FescueSeedNorth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lFescueSeedNorthShort);
                context.SaveChanges();
            }
            #endregion
            #region FescueSeedNorthMedium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthMedium);

                var lFescueSeedNorthMedium = new Specie
                {
                    Name = Utils.NameSpecieFescueSeedNorthMedium,
                    ShortName = "Festuca Semilla",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2017.BaseTemperature_FescueSeedNorth_2017,
                    StressTemperature = DataEntry2017.StressTemperature_FescueSeedNorth_2017,
                    SpecieType = Utils.SpecieType.Pastures,
                };

                context.Species.Add(lFescueSeedNorthMedium);
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

        public static void InsertSpecies_2018()
        {
            SpecieCycle lSpecieCycle = null;
            Region lRegion = null;
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
            using (var context = new IrrigationAdvisorContext())
            {
                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();

                #region CornSouthShort

                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                var lCornSouthShort = new Specie
                {
                    Name = Utils.NameSpecieCornSouthShort,
                    ShortName = "Maíz",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2018.BaseTemperature_CornSouth_2018,
                    StressTemperature = DataEntry2018.StressTemperature_CornSouth_2018,
                    SpecieType = Utils.SpecieType.Grains,
                    RegionId = lRegion.RegionId,
                };

                context.Species.Add(lCornSouthShort);
                context.SaveChanges();
            
                #endregion
                #region CornSouthMedium

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthMedium);

                    var lCornSouthMedium = new Specie
                    {
                        Name = Utils.NameSpecieCornSouthMedium,
                        ShortName = "Maíz",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_CornSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_CornSouth_2018,
                        SpecieType = Utils.SpecieType.Grains,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lCornSouthMedium);
                    context.SaveChanges();
                
                #endregion

                #region SoyaSouthShort

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                    var lSoyaSouthShort = new Specie
                    {
                        Name = Utils.NameSpecieSoyaSouthShort,
                        ShortName = "Soja",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_SoyaSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_SoyaSouth_2018,
                        SpecieType = Utils.SpecieType.Grains,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lSoyaSouthShort);
                    context.SaveChanges();
              
                #endregion
                #region SoyaSouthMedium

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthMedium);

                    var lSoyaSouthMedium = new Specie
                    {
                        Name = Utils.NameSpecieSoyaSouthMedium,
                        ShortName = "Soja",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_SoyaSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_SoyaSouth_2018,
                        SpecieType = Utils.SpecieType.Grains,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lSoyaSouthMedium);
                    context.SaveChanges();
               
                #endregion

                #region OatSouthShort

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                    var lOatSouthShort = new Specie
                    {
                        Name = Utils.NameSpecieOatSouthShort,
                        ShortName = "Avena",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_OatSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_OatSouth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lOatSouthShort);
                    context.SaveChanges();
                
                #endregion
                #region OatSouthMedium

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthMedium);

                    var lOatSouthMedium = new Specie
                    {
                        Name = Utils.NameSpecieOatSouthMedium,
                        ShortName = "Avena",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_OatSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_OatSouth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lOatSouthMedium);
                    context.SaveChanges();
                
                #endregion

                #region SorghumForageSouthShort

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                    var lSorghumForageSouthShort = new Specie
                    {
                        Name = Utils.NameSpecieSorghumForageSouthShort,
                        ShortName = "Sorgo Forrajero",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_SorghumForageSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_SorghumForageSouth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lSorghumForageSouthShort);
                    context.SaveChanges();
                
                #endregion
                #region SorghumGrainSouthShort

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                    var lSorghumGrainSouthShort = new Specie
                    {
                        Name = Utils.NameSpecieSorghumGrainSouthShort,
                        ShortName = "Sorgo Granifero",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_SorghumGrainSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_SorghumGrainSouth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lSorghumGrainSouthShort);
                    context.SaveChanges();
                
                #endregion

                #region AlfalfaSouthShort

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                    var lAlfalfaSouthShort = new Specie
                    {
                        Name = Utils.NameSpecieAlfalfaSouthShort,
                        ShortName = "Alfalfa",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_AlfalfaSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_AlfalfaSouth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lAlfalfaSouthShort);
                    context.SaveChanges();
                
                #endregion
                #region AlfalfaSouthMedium

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthMedium);

                    var lAlfalfaSouthMedium = new Specie
                    {
                        Name = Utils.NameSpecieAlfalfaSouthMedium,
                        ShortName = "Alfalfa",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_AlfalfaSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_AlfalfaSouth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lAlfalfaSouthMedium);
                    context.SaveChanges();
                
                #endregion

                #region SudanGrassSouthShort

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                    var lSudanGrassSouthShort = new Specie
                    {
                        Name = Utils.NameSpecieSudanGrassSouthShort,
                        ShortName = "SudanGrass",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_SudanGrassSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_SudanGrassSouth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lSudanGrassSouthShort);
                    context.SaveChanges();
                
                #endregion
                #region SudanGrassSouthMedium

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthMedium);

                    var lSudanGrassSouthMedium = new Specie
                    {
                        Name = Utils.NameSpecieSudanGrassSouthMedium,
                        ShortName = "SudanGrass",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_SudanGrassSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_SudanGrassSouth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lSudanGrassSouthMedium);
                    context.SaveChanges();
               
                #endregion

                #region RedCloverForageSouthShort

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                    var lRedCloverForageSouthShort = new Specie
                    {
                        Name = Utils.NameSpecieRedCloverForageSouthShort,
                        ShortName = "Trebol Rojo Forraje",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_RedCloverForageSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_RedCloverForageSouth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lRedCloverForageSouthShort);
                    context.SaveChanges();
                
                #endregion
                #region RedCloverSeedSouthShort

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                    var lRedCloverSeedSouthShort = new Specie
                    {
                        Name = Utils.NameSpecieRedCloverSeedSouthShort,
                        ShortName = "Trebol Rojo Semilla",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_RedCloverSeedSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_RedCloverSeedSouth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lRedCloverSeedSouthShort);
                    context.SaveChanges();
                
                #endregion

                #region FescueForageSouthShort

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                    var lFescueForageSouthShort = new Specie
                    {
                        Name = Utils.NameSpecieFescueForageSouthShort,
                        ShortName = "Festuca Forraje",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_FescueForageSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_FescueForageSouth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lFescueForageSouthShort);
                    context.SaveChanges();
                
                #endregion
                #region FescueForageSouthMedium

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthMedium);

                    var lFescueForageSouthMedium = new Specie
                    {
                        Name = Utils.NameSpecieFescueForageSouthMedium,
                        ShortName = "Festuca Forraje",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_FescueForageSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_FescueForageSouth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lFescueForageSouthMedium);
                    context.SaveChanges();
                
                #endregion
                #region FescueSeedSouthShort
                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthShort);

                    var lFescueSeedSouthShort = new Specie
                    {
                        Name = Utils.NameSpecieFescueSeedSouthShort,
                        ShortName = "Festuca Semilla",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_FescueSeedSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_FescueSeedSouth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lFescueSeedSouthShort);
                    context.SaveChanges();
                
                #endregion
                #region FescueSeedSouthMedium

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleSouthMedium);

                    var lFescueSeedSouthMedium = new Specie
                    {
                        Name = Utils.NameSpecieFescueSeedSouthMedium,
                        ShortName = "Festuca Semilla",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_FescueSeedSouth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_FescueSeedSouth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lFescueSeedSouthMedium);
                    context.SaveChanges();
                
                #endregion
            }
            #endregion

            #region North
            using (var context = new IrrigationAdvisorContext())
            {               
                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                             select reg).FirstOrDefault();

                #region Corn North Short

                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        sc => sc.Name == Utils.NameSpecieCycleNorthShort);
                var lCornNorthShort = new Specie
                {
                    Name = Utils.NameSpecieCornNorthShort,
                    ShortName = "Maíz",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry2018.BaseTemperature_CornNorth_2018,
                    StressTemperature = DataEntry2018.StressTemperature_CornNorth_2018,
                    SpecieType = Utils.SpecieType.Grains,
                    RegionId = lRegion.RegionId,
                };
                context.Species.Add(lCornNorthShort);
                context.SaveChanges();
            
                #endregion
                #region Corn North Medium

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleNorthMedium);
                    var lCornNorthMedium = new Specie
                    {
                        Name = Utils.NameSpecieCornNorthMedium,
                        ShortName = "Maíz",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_CornNorth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_CornNorth_2018,
                        SpecieType = Utils.SpecieType.Grains,
                        RegionId = lRegion.RegionId,
                    };
                    context.Species.Add(lCornNorthMedium);
                    context.SaveChanges();

               
                #endregion

                #region Soya North Short

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleNorthShort);

                    var lSoyaNorthShort = new Specie
                    {
                        Name = Utils.NameSpecieSoyaNorthShort,
                        ShortName = "Soja",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_SoyaNorth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_SoyaNorth_2018,
                        SpecieType = Utils.SpecieType.Grains,
                        RegionId = lRegion.RegionId,
                    };
                    context.Species.Add(lSoyaNorthShort);
                    context.SaveChanges();
               
                #endregion
                #region Soya North Medium

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleNorthMedium);

                    var lSoyaNorthMedium = new Specie
                    {
                        Name = Utils.NameSpecieSoyaNorthMedium,
                        ShortName = "Soja",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_SoyaNorth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_SoyaNorth_2018,
                        SpecieType = Utils.SpecieType.Grains,
                        RegionId = lRegion.RegionId,
                    };
                    context.Species.Add(lSoyaNorthMedium);
                    context.SaveChanges();
                
                #endregion

                #region OatNorthShort

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleNorthShort);

                    var lOatNorthShort = new Specie
                    {
                        Name = Utils.NameSpecieOatNorthShort,
                        ShortName = "Avena",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_OatNorth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_OatNorth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lOatNorthShort);
                    context.SaveChanges();
                
                #endregion
                #region OatNorthMedium

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleNorthMedium);

                    var lOatNorthMedium = new Specie
                    {
                        Name = Utils.NameSpecieOatNorthMedium,
                        ShortName = "Avena",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_OatNorth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_OatNorth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lOatNorthMedium);
                    context.SaveChanges();
                
                #endregion

                #region AlfalfaNorthShort

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleNorthShort);

                    var lAlfalfaNorthShort = new Specie
                    {
                        Name = Utils.NameSpecieAlfalfaNorthShort,
                        ShortName = "Alfalfa",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_AlfalfaNorth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_AlfalfaNorth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lAlfalfaNorthShort);
                    context.SaveChanges();
               
                #endregion
                #region AlfalfaNorthMedium

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleNorthMedium);

                    var lAlfalfaNorthMedium = new Specie
                    {
                        Name = Utils.NameSpecieAlfalfaNorthMedium,
                        ShortName = "Alfalfa",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_AlfalfaNorth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_AlfalfaNorth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lAlfalfaNorthMedium);
                    context.SaveChanges();
                
                #endregion

                #region SudanGrassNorthShort

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleNorthShort);

                    var lSudanGrassNorthShort = new Specie
                    {
                        Name = Utils.NameSpecieSudanGrassNorthShort,
                        ShortName = "SudanGrass",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_SudanGrassNorth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_SudanGrassNorth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lSudanGrassNorthShort);
                    context.SaveChanges();
                
                #endregion
                #region SudanGrassNorthMedium

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleNorthMedium);

                    var lSudanGrassNorthMedium = new Specie
                    {
                        Name = Utils.NameSpecieSudanGrassNorthMedium,
                        ShortName = "SudanGrass",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_SudanGrassNorth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_SudanGrassNorth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lSudanGrassNorthMedium);
                    context.SaveChanges();
                #endregion

                #region FescueForageNorthShort

                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleNorthShort);

                    var lFescueForageNorthShort = new Specie
                    {
                        Name = Utils.NameSpecieFescueForageNorthShort,
                        ShortName = "Festuca Forraje",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_FescueForageNorth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_FescueForageNorth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lFescueForageNorthShort);
                    context.SaveChanges();
                
                #endregion
                #region FescueForageNorthMedium
                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleNorthMedium);

                    var lFescueForageNorthMedium = new Specie
                    {
                        Name = Utils.NameSpecieFescueForageNorthMedium,
                        ShortName = "Festuca Forraje",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_FescueForageNorth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_FescueForageNorth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lFescueForageNorthMedium);
                    context.SaveChanges();
                #endregion
                #region FescueSeedNorthShort
                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleNorthShort);

                    var lFescueSeedNorthShort = new Specie
                    {
                        Name = Utils.NameSpecieFescueSeedNorthShort,
                        ShortName = "Festuca Semilla",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_FescueSeedNorth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_FescueSeedNorth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lFescueSeedNorthShort);
                    context.SaveChanges();
                
                #endregion
                #region FescueSeedNorthMedium
                    lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                            sc => sc.Name == Utils.NameSpecieCycleNorthMedium);

                    var lFescueSeedNorthMedium = new Specie
                    {
                        Name = Utils.NameSpecieFescueSeedNorthMedium,
                        ShortName = "Festuca Semilla",
                        SpecieCycleId = lSpecieCycle.SpecieCycleId,
                        BaseTemperature = DataEntry2018.BaseTemperature_FescueSeedNorth_2018,
                        StressTemperature = DataEntry2018.StressTemperature_FescueSeedNorth_2018,
                        SpecieType = Utils.SpecieType.Pastures,
                        RegionId = lRegion.RegionId,
                    };

                    context.Species.Add(lFescueSeedNorthMedium);
                    context.SaveChanges();
                
                #endregion
            
            #endregion

            //using (var context = new IrrigationAdvisorContext())
            //{
            //    //context.Species.Add(lBase);
            //    context.SaveChanges();
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
            var lStageMv16 = new Stage { Name = Utils.NameStagesCorn + " V16", ShortName = "V16", Description = "16 nudos", Order = 18, };
            var lStageMv17 = new Stage { Name = Utils.NameStagesCorn + " V17", ShortName = "V17", Description = "17 nudos", Order = 19, };
            var lStageMvt = new Stage { Name = Utils.NameStagesCorn + " VT", ShortName = "VT", Description = "Floracion", Order = 20, };
            var lStageMr1 = new Stage { Name = Utils.NameStagesCorn + " R1", ShortName = "R1", Description = "Estambres 50%", Order = 21, };
            var lStageMr2 = new Stage { Name = Utils.NameStagesCorn + " R2", ShortName = "R2", Description = "Granos hinchados", Order = 22, };
            var lStageMr3 = new Stage { Name = Utils.NameStagesCorn + " R3", ShortName = "R3", Description = "Estado lechoso", Order = 23, };
            var lStageMr4 = new Stage { Name = Utils.NameStagesCorn + " R4", ShortName = "R4", Description = "Estado pastoso", Order = 24, };
            var lStageMr5 = new Stage { Name = Utils.NameStagesCorn + " R5", ShortName = "R5", Description = "Estado de diente", Order = 25, };
            var lStageMr6 = new Stage { Name = Utils.NameStagesCorn + " R6", ShortName = "R6", Description = "Madurez fisiologica", Order = 26, };
            var lStageMr7 = new Stage { Name = Utils.NameStagesCorn + " R7", ShortName = "R7", Description = "Madurez fisiologica", Order = 27, };
            var lStageMr8 = new Stage { Name = Utils.NameStagesCorn + " R8", ShortName = "R8", Description = "Madurez fisiologica", Order = 28, };
            var lStageMr9 = new Stage { Name = Utils.NameStagesCorn + " R9", ShortName = "R9", Description = "Madurez fisiologica", Order = 29, };
            var lStageMr10 = new Stage { Name = Utils.NameStagesCorn + " R10", ShortName = "R10", Description = "Madurez fisiologica", Order = 30, };


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
                context.Stages.Add(lStageMv16);
                context.Stages.Add(lStageMv17);
                context.Stages.Add(lStageMvt);
                context.Stages.Add(lStageMr1);
                context.Stages.Add(lStageMr2);
                context.Stages.Add(lStageMr3);
                context.Stages.Add(lStageMr4);
                context.Stages.Add(lStageMr5);
                context.Stages.Add(lStageMr6);
                context.Stages.Add(lStageMr7);
                context.Stages.Add(lStageMr8);
                context.Stages.Add(lStageMr9);
                context.Stages.Add(lStageMr10);

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
            var lStageSv11 = new Stage { Name = Utils.NameStagesSoya + " V11", ShortName = "V11", Description = "11 nudos", Order = 13, };
            var lStageSv12 = new Stage { Name = Utils.NameStagesSoya + " V12", ShortName = "V12", Description = "12 nudos", Order = 14, };
            var lStageSv13 = new Stage { Name = Utils.NameStagesSoya + " V13", ShortName = "V13", Description = "13 nudos", Order = 15, };
            var lStageSv14 = new Stage { Name = Utils.NameStagesSoya + " V14", ShortName = "V14", Description = "14 nudos", Order = 16, };
            var lStageSr1 = new Stage { Name = Utils.NameStagesSoya + " R1", ShortName = "R1", Description = "Inicio Floracion", Order = 17, };
            var lStageSr2 = new Stage { Name = Utils.NameStagesSoya + " R2", ShortName = "R2", Description = "Floracion Completa", Order = 18, };
            var lStageSr3 = new Stage { Name = Utils.NameStagesSoya + " R3", ShortName = "R3", Description = "Inicio Vainas", Order = 19, };
            var lStageSr4 = new Stage { Name = Utils.NameStagesSoya + " R4", ShortName = "R4", Description = "Vainas Completas", Order = 20, };
            var lStageSr5 = new Stage { Name = Utils.NameStagesSoya + " R5", ShortName = "R5", Description = "Formacion de semillas", Order = 21, };
            var lStageSr6 = new Stage { Name = Utils.NameStagesSoya + " R6", ShortName = "R6", Description = "Semillas Completas", Order = 22, };
            var lStageSr7 = new Stage { Name = Utils.NameStagesSoya + " R7", ShortName = "R7", Description = "Inicio Maduracion", Order = 23, };
            var lStageSr8 = new Stage { Name = Utils.NameStagesSoya + " R8", ShortName = "R8", Description = "Maduracion Completa", Order = 24, };
            var lStageSr9 = new Stage { Name = Utils.NameStagesSoya + " R9", ShortName = "R9", Description = "Maduracion Completa", Order = 25, };
            var lStageSr10 = new Stage { Name = Utils.NameStagesSoya + " R10", ShortName = "R10", Description = "Maduracion Completa", Order = 26, };


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
                context.Stages.Add(lStageSv12);
                context.Stages.Add(lStageSv13);
                context.Stages.Add(lStageSv14);
                context.Stages.Add(lStageSr1);
                context.Stages.Add(lStageSr2);
                context.Stages.Add(lStageSr3);
                context.Stages.Add(lStageSr4);
                context.Stages.Add(lStageSr5);
                context.Stages.Add(lStageSr6);
                context.Stages.Add(lStageSr7);
                context.Stages.Add(lStageSr8);
                context.Stages.Add(lStageSr9);
                context.Stages.Add(lStageSr10);
                context.SaveChanges();
            };
        }

        public static void InsertStagesOat()
        {
            var lBase = new Stage
            {
                Name = Utils.NameBase,
                Description = "",
            };

            var lStageSv0 = new Stage { Name = Utils.NameStagesOat + " V0", Description = "Siembra", Order = 1, };
            var lStageSve = new Stage { Name = Utils.NameStagesOat + " VE", Description = "Emergencia", Order = 2, };
            var lStageSv1 = new Stage { Name = Utils.NameStagesOat + " V1", Description = "1 nudo", Order = 3, };
            var lStageSv2 = new Stage { Name = Utils.NameStagesOat + " V2", Description = "2 nudos", Order = 4, };
            var lStageSv3 = new Stage { Name = Utils.NameStagesOat + " V3", Description = "3 nudos", Order = 5, };
            var lStageSv4 = new Stage { Name = Utils.NameStagesOat + " V4", Description = "4 nudos", Order = 6, };
            var lStageSv5 = new Stage { Name = Utils.NameStagesOat + " V5", Description = "5 nudos", Order = 7, };
            var lStageSv6 = new Stage { Name = Utils.NameStagesOat + " V6", Description = "6 nudos", Order = 8, };
            var lStageSv7 = new Stage { Name = Utils.NameStagesOat + " V7", Description = "7 nudos", Order = 9, };
            var lStageSv8 = new Stage { Name = Utils.NameStagesOat + " V8", Description = "8 nudos", Order = 10, };
            var lStageSv9 = new Stage { Name = Utils.NameStagesOat + " V9", Description = "9 nudos", Order = 11, };
            var lStageSv10 = new Stage { Name = Utils.NameStagesOat + " V10", Description = "10 nudos", Order = 12, };
            var lStageSv11 = new Stage { Name = Utils.NameStagesOat + " V11", Description = "11 nudo", Order = 13, };
            var lStageSv12 = new Stage { Name = Utils.NameStagesOat + " V12", Description = "12 nudo", Order = 14, };
            var lStageSv13 = new Stage { Name = Utils.NameStagesOat + " V13", Description = "13 nudo", Order = 15, };
            var lStageSv14 = new Stage { Name = Utils.NameStagesOat + " V14", Description = "14 nudo", Order = 16, };
            var lStageSv15 = new Stage { Name = Utils.NameStagesOat + " V15", Description = "15 nudo", Order = 17, };
            var lStageSv16 = new Stage { Name = Utils.NameStagesOat + " V16", Description = "16 nudo", Order = 18, };
            var lStageSv17 = new Stage { Name = Utils.NameStagesOat + " V17", Description = "17 nudo", Order = 19, };
            var lStageMvt = new Stage { Name = Utils.NameStagesOat + " VT", ShortName = "VT", Description = "Floracion", Order = 20, };
            var lStageSr1 = new Stage { Name = Utils.NameStagesOat + " R1", ShortName = "R1", Description = "Inicio Floracion", Order = 21, };
            var lStageSr2 = new Stage { Name = Utils.NameStagesOat + " R2", ShortName = "R2", Description = "Floracion Completa", Order = 22, };
            var lStageSr3 = new Stage { Name = Utils.NameStagesOat + " R3", ShortName = "R3", Description = "Inicio Vainas", Order = 23, };
            var lStageSr4 = new Stage { Name = Utils.NameStagesOat + " R4", ShortName = "R4", Description = "Vainas Completas", Order = 24, };
            var lStageSr5 = new Stage { Name = Utils.NameStagesOat + " R5", ShortName = "R5", Description = "Formacion de semillas", Order = 25, };
            var lStageSr6 = new Stage { Name = Utils.NameStagesOat + " R6", ShortName = "R6", Description = "Semillas Completas", Order = 26, };
            var lStageSr7 = new Stage { Name = Utils.NameStagesOat + " R7", ShortName = "R7", Description = "Inicio Maduracion", Order = 27, };
            var lStageSr8 = new Stage { Name = Utils.NameStagesOat + " R8", ShortName = "R8", Description = "Maduracion Completa", Order = 28, };


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
                context.Stages.Add(lStageSv12);
                context.Stages.Add(lStageSv13);
                context.Stages.Add(lStageSv14);
                context.Stages.Add(lStageSv15);
                context.Stages.Add(lStageSv16);
                context.Stages.Add(lStageSv17);
                context.Stages.Add(lStageMvt);
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

            var lStageSv0 = new Stage { Name = Utils.NameStagesAlfalfa + " V0", ShortName = "V0", Description = "Siembra", Order = 1, };
            var lStageSve = new Stage { Name = Utils.NameStagesAlfalfa + " VE", ShortName = "VE", Description = "Emergencia", Order = 2, };
            var lStageSv1 = new Stage { Name = Utils.NameStagesAlfalfa + " V1", ShortName = "V1", Description = "1 nudo", Order = 3, };
            var lStageSv2 = new Stage { Name = Utils.NameStagesAlfalfa + " V2", ShortName = "V2", Description = "2 nudos", Order = 4, };
            var lStageSv3 = new Stage { Name = Utils.NameStagesAlfalfa + " V3", ShortName = "V3", Description = "3 nudos", Order = 5, };
            var lStageSv4 = new Stage { Name = Utils.NameStagesAlfalfa + " V4", ShortName = "V4", Description = "4 nudos", Order = 6, };
            var lStageSv5 = new Stage { Name = Utils.NameStagesAlfalfa + " V5", ShortName = "V5", Description = "5 nudos", Order = 7, };
            var lStageSv6 = new Stage { Name = Utils.NameStagesAlfalfa + " V6", ShortName = "V6", Description = "6 nudos", Order = 8, };
            var lStageSv7 = new Stage { Name = Utils.NameStagesAlfalfa + " V7", ShortName = "V7", Description = "7 nudos", Order = 9, };
            var lStageSv8 = new Stage { Name = Utils.NameStagesAlfalfa + " V8", ShortName = "V8", Description = "8 nudos", Order = 10, };
            var lStageSv9 = new Stage { Name = Utils.NameStagesAlfalfa + " V9", ShortName = "V9", Description = "9 nudos", Order = 11, };
            var lStageSv10 = new Stage { Name = Utils.NameStagesAlfalfa + " V10", ShortName = "V10", Description = "10 nudos", Order = 12, };
            var lStageSv11 = new Stage { Name = Utils.NameStagesAlfalfa + " V11", ShortName = "V11", Description = "11 nudo", Order = 13, };
            var lStageSv12 = new Stage { Name = Utils.NameStagesAlfalfa + " V12", ShortName = "V12", Description = "12 nudo", Order = 14, };
            var lStageSv13 = new Stage { Name = Utils.NameStagesAlfalfa + " V13", ShortName = "V13", Description = "13 nudo", Order = 15, };
            var lStageSv14 = new Stage { Name = Utils.NameStagesAlfalfa + " V14", ShortName = "V14", Description = "14 nudo", Order = 16, };
            var lStageSv15 = new Stage { Name = Utils.NameStagesAlfalfa + " V15", ShortName = "V15", Description = "15 nudo", Order = 17, };
            var lStageSv16 = new Stage { Name = Utils.NameStagesAlfalfa + " V16", ShortName = "V16", Description = "16 nudo", Order = 18, };
            var lStageSv17 = new Stage { Name = Utils.NameStagesAlfalfa + " V17", ShortName = "V17", Description = "17 nudo", Order = 19, };
            var lStageMvt = new Stage { Name = Utils.NameStagesAlfalfa + " VT", ShortName = "VT", Description = "Floracion", Order = 20, };
            var lStageSr1 = new Stage { Name = Utils.NameStagesAlfalfa + " R1", ShortName = "R1", Description = "Inicio Floracion", Order = 21, };
            var lStageSr2 = new Stage { Name = Utils.NameStagesAlfalfa + " R2", ShortName = "R2", Description = "Floracion Completa", Order = 22, };
            var lStageSr3 = new Stage { Name = Utils.NameStagesAlfalfa + " R3", ShortName = "R3", Description = "Inicio Vainas", Order = 23, };
            var lStageSr4 = new Stage { Name = Utils.NameStagesAlfalfa + " R4", ShortName = "R4", Description = "Vainas Completas", Order = 24, };
            var lStageSr5 = new Stage { Name = Utils.NameStagesAlfalfa + " R5", ShortName = "R5", Description = "Formacion de semillas", Order = 25, };
            var lStageSr6 = new Stage { Name = Utils.NameStagesAlfalfa + " R6", ShortName = "R6", Description = "Semillas Completas", Order = 26, };
            var lStageSr7 = new Stage { Name = Utils.NameStagesAlfalfa + " R7", ShortName = "R7", Description = "Inicio Maduracion", Order = 27, };
            var lStageSr8 = new Stage { Name = Utils.NameStagesAlfalfa + " R8", ShortName = "R8", Description = "Maduracion Completa", Order = 28, };


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
                context.Stages.Add(lStageSv12);
                context.Stages.Add(lStageSv13);
                context.Stages.Add(lStageSv14);
                context.Stages.Add(lStageSv15);
                context.Stages.Add(lStageSv16);
                context.Stages.Add(lStageSv17);
                context.Stages.Add(lStageMvt);
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

        public static void InsertStagesSudanGrass()
        {
            var lBase = new Stage
            {
                Name = Utils.NameBase,
                Description = "",
            };

            var lStageSv0 = new Stage { Name = Utils.NameStagesSudanGrass + " V0", Description = "Siembra", Order = 1, };
            var lStageSve = new Stage { Name = Utils.NameStagesSudanGrass + " VE", Description = "Emergencia", Order = 2, };
            var lStageSv1 = new Stage { Name = Utils.NameStagesSudanGrass + " V1", Description = "1 nudo", Order = 3, };
            var lStageSv2 = new Stage { Name = Utils.NameStagesSudanGrass + " V2", Description = "2 nudos", Order = 4, };
            var lStageSv3 = new Stage { Name = Utils.NameStagesSudanGrass + " V3", Description = "3 nudos", Order = 5, };
            var lStageSv4 = new Stage { Name = Utils.NameStagesSudanGrass + " V4", Description = "4 nudos", Order = 6, };
            var lStageSv5 = new Stage { Name = Utils.NameStagesSudanGrass + " V5", Description = "5 nudos", Order = 7, };
            var lStageSv6 = new Stage { Name = Utils.NameStagesSudanGrass + " V6", Description = "6 nudos", Order = 8, };
            var lStageSv7 = new Stage { Name = Utils.NameStagesSudanGrass + " V7", Description = "7 nudos", Order = 9, };
            var lStageSv8 = new Stage { Name = Utils.NameStagesSudanGrass + " V8", Description = "8 nudos", Order = 10, };
            var lStageSv9 = new Stage { Name = Utils.NameStagesSudanGrass + " V9", Description = "9 nudos", Order = 11, };
            var lStageSv10 = new Stage { Name = Utils.NameStagesSudanGrass + " V10", Description = "10 nudos", Order = 12, };
            var lStageSv11 = new Stage { Name = Utils.NameStagesSudanGrass + " V11", Description = "11 nudo", Order = 13, };
            var lStageSv12 = new Stage { Name = Utils.NameStagesSudanGrass + " V12", Description = "12 nudo", Order = 14, };
            var lStageSv13 = new Stage { Name = Utils.NameStagesSudanGrass + " V13", Description = "13 nudo", Order = 15, };
            var lStageSv14 = new Stage { Name = Utils.NameStagesSudanGrass + " V14", Description = "14 nudo", Order = 16, };
            var lStageSv15 = new Stage { Name = Utils.NameStagesSudanGrass + " V15", Description = "15 nudo", Order = 17, };
            var lStageSv16 = new Stage { Name = Utils.NameStagesSudanGrass + " V16", Description = "16 nudo", Order = 18, };
            var lStageSv17 = new Stage { Name = Utils.NameStagesSudanGrass + " V17", Description = "17 nudo", Order = 19, };
            var lStageMvt = new Stage { Name = Utils.NameStagesSudanGrass + " VT", ShortName = "VT", Description = "Floracion", Order = 20, };
            var lStageSr1 = new Stage { Name = Utils.NameStagesSudanGrass + " R1", ShortName = "R1", Description = "Inicio Floracion", Order = 21, };
            var lStageSr2 = new Stage { Name = Utils.NameStagesSudanGrass + " R2", ShortName = "R2", Description = "Floracion Completa", Order = 22, };
            var lStageSr3 = new Stage { Name = Utils.NameStagesSudanGrass + " R3", ShortName = "R3", Description = "Inicio Vainas", Order = 23, };
            var lStageSr4 = new Stage { Name = Utils.NameStagesSudanGrass + " R4", ShortName = "R4", Description = "Vainas Completas", Order = 24, };
            var lStageSr5 = new Stage { Name = Utils.NameStagesSudanGrass + " R5", ShortName = "R5", Description = "Formacion de semillas", Order = 25, };
            var lStageSr6 = new Stage { Name = Utils.NameStagesSudanGrass + " R6", ShortName = "R6", Description = "Semillas Completas", Order = 26, };
            var lStageSr7 = new Stage { Name = Utils.NameStagesSudanGrass + " R7", ShortName = "R7", Description = "Inicio Maduracion", Order = 27, };
            var lStageSr8 = new Stage { Name = Utils.NameStagesSudanGrass + " R8", ShortName = "R8", Description = "Maduracion Completa", Order = 28, };


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
                context.Stages.Add(lStageSv12);
                context.Stages.Add(lStageSv13);
                context.Stages.Add(lStageSv14);
                context.Stages.Add(lStageSv15);
                context.Stages.Add(lStageSv16);
                context.Stages.Add(lStageSv17);
                context.Stages.Add(lStageMvt);
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
            var lStageSv12 = new Stage { Name = Utils.NameStagesFescueForage + " V12", ShortName = "V12", Description = "12 nudo", Order = 14, };
            var lStageSv13 = new Stage { Name = Utils.NameStagesFescueForage + " V13", ShortName = "V13", Description = "13 nudo", Order = 15, };
            var lStageSv14 = new Stage { Name = Utils.NameStagesFescueForage + " V14", ShortName = "V14", Description = "14 nudo", Order = 16, };
            var lStageSv15 = new Stage { Name = Utils.NameStagesFescueForage + " V15", ShortName = "V15", Description = "15 nudo", Order = 17, };
            var lStageSv16 = new Stage { Name = Utils.NameStagesFescueForage + " V16", ShortName = "V16", Description = "16 nudo", Order = 18, };
            var lStageSv17 = new Stage { Name = Utils.NameStagesFescueForage + " V17", ShortName = "V17", Description = "17 nudo", Order = 19, };
            var lStageSr1 = new Stage { Name = Utils.NameStagesFescueForage + " R1", ShortName = "R1", Description = "Inicio Floracion", Order = 20, };
            var lStageSr2 = new Stage { Name = Utils.NameStagesFescueForage + " R2", ShortName = "R2", Description = "Floracion Completa", Order = 21, };
            var lStageSr3 = new Stage { Name = Utils.NameStagesFescueForage + " R3", ShortName = "R3", Description = "Inicio Vainas", Order = 22, };
            var lStageSr4 = new Stage { Name = Utils.NameStagesFescueForage + " R4", ShortName = "R4", Description = "Vainas Completas", Order = 23, };
            var lStageSr5 = new Stage { Name = Utils.NameStagesFescueForage + " R5", ShortName = "R5", Description = "Formacion de semillas", Order = 24, };
            var lStageSr6 = new Stage { Name = Utils.NameStagesFescueForage + " R6", ShortName = "R6", Description = "Semillas Completas", Order = 25, };
            var lStageSr7 = new Stage { Name = Utils.NameStagesFescueForage + " R7", ShortName = "R7", Description = "Inicio Maduracion", Order = 26, };
            var lStageSr8 = new Stage { Name = Utils.NameStagesFescueForage + " R8", ShortName = "R8", Description = "Maduracion Completa", Order = 27, };


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
                context.Stages.Add(lStageSv12);
                context.Stages.Add(lStageSv13);
                context.Stages.Add(lStageSv14);
                context.Stages.Add(lStageSv15);
                context.Stages.Add(lStageSv16);
                context.Stages.Add(lStageSv17);
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
            var lStageSv12 = new Stage { Name = Utils.NameStagesFescueSeed + " V12", ShortName = "V12", Description = "12 nudo", Order = 14, };
            var lStageSv13 = new Stage { Name = Utils.NameStagesFescueSeed + " V13", ShortName = "V13", Description = "13 nudo", Order = 15, };
            var lStageSv14 = new Stage { Name = Utils.NameStagesFescueSeed + " V14", ShortName = "V14", Description = "14 nudo", Order = 16, };
            var lStageSv15 = new Stage { Name = Utils.NameStagesFescueSeed + " V15", ShortName = "V15", Description = "15 nudo", Order = 17, };
            var lStageSv16 = new Stage { Name = Utils.NameStagesFescueSeed + " V16", ShortName = "V16", Description = "16 nudo", Order = 18, };
            var lStageSv17 = new Stage { Name = Utils.NameStagesFescueSeed + " V17", ShortName = "V17", Description = "17 nudo", Order = 19, };
            var lStageSr1 = new Stage { Name = Utils.NameStagesFescueSeed + " R1", ShortName = "R1", Description = "Inicio Floracion", Order = 20, };
            var lStageSr2 = new Stage { Name = Utils.NameStagesFescueSeed + " R2", ShortName = "R2", Description = "Floracion Completa", Order = 21, };
            var lStageSr3 = new Stage { Name = Utils.NameStagesFescueSeed + " R3", ShortName = "R3", Description = "Inicio Vainas", Order = 22, };
            var lStageSr4 = new Stage { Name = Utils.NameStagesFescueSeed + " R4", ShortName = "R4", Description = "Vainas Completas", Order = 23, };
            var lStageSr5 = new Stage { Name = Utils.NameStagesFescueSeed + " R5", ShortName = "R5", Description = "Formacion de semillas", Order = 24, };
            var lStageSr6 = new Stage { Name = Utils.NameStagesFescueSeed + " R6", ShortName = "R6", Description = "Semillas Completas", Order = 25, };
            var lStageSr7 = new Stage { Name = Utils.NameStagesFescueSeed + " R7", ShortName = "R7", Description = "Inicio Maduracion", Order = 26, };
            var lStageSr8 = new Stage { Name = Utils.NameStagesFescueSeed + " R8", ShortName = "R8", Description = "Maduracion Completa", Order = 27, };


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
                context.Stages.Add(lStageSv12);
                context.Stages.Add(lStageSv13);
                context.Stages.Add(lStageSv14);
                context.Stages.Add(lStageSv15);
                context.Stages.Add(lStageSv16);
                context.Stages.Add(lStageSv17);
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

        #region Basic 
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

                #region Corn South Short
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieCornSouthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V0") select stage).FirstOrDefault();
                var lPSCornV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VE") select stage).FirstOrDefault();
                var lPSCornVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 114.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval =55};

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V1") select stage).FirstOrDefault();
                var lPSCornV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 20};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V2") select stage).FirstOrDefault();
                var lPSCornV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 179.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V3") select stage).FirstOrDefault();
                var lPSCornV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 180, MaxDegree = 229.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval =50};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V4") select stage).FirstOrDefault();
                var lPSCornV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 230, MaxDegree = 289.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval =60};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V5") select stage).FirstOrDefault();
                var lPSCornV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 349.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval =60};

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V6") select stage).FirstOrDefault();
                var lPSCornV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 350, MaxDegree = 404.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V7") select stage).FirstOrDefault();
                var lPSCornV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 405, MaxDegree = 459.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval =55};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V8") select stage).FirstOrDefault();
                var lPSCornV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 519.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval =60};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V9") select stage).FirstOrDefault();
                var lPSCornV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 520, MaxDegree = 589.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval =70};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V10") select stage).FirstOrDefault();
                var lPSCornV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 590, MaxDegree = 649.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval =60};

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V11") select stage).FirstOrDefault();
                var lPSCornV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 650, MaxDegree = 689.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval =40};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V12") select stage).FirstOrDefault();
                var lPSCornV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 690, MaxDegree = 714.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval =25};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V13") select stage).FirstOrDefault();
                var lPSCornV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 715, MaxDegree = 749.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval =35};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V14") select stage).FirstOrDefault();
                var lPSCornV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 750, MaxDegree = 774.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval =25};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V15") select stage).FirstOrDefault();
                var lPSCornV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 775, MaxDegree = 889.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval =115};

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V15Bis") select stage).FirstOrDefault();
                var lPSCornV15Bis = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V15Tres") select stage).FirstOrDefault();
                var lPSCornV15Tres = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VT") select stage).FirstOrDefault();
                var lPSCornVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 890, MaxDegree = 1049.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160};

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R1") select stage).FirstOrDefault();
                var lPSCornR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1050, MaxDegree = 1199.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval =150};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R2") select stage).FirstOrDefault();
                var lPSCornR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval =150};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R3") select stage).FirstOrDefault();
                var lPSCornR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval =150};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R4") select stage).FirstOrDefault();
                var lPSCornR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 1599.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval =100};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R5") select stage).FirstOrDefault();
                var lPSCornR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1600, MaxDegree = 1899.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval =300};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R6") select stage).FirstOrDefault();
                var lPSCornR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1900, MaxDegree = 3500, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval =1600};

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
                context.PhenologicalStages.Add(lPSCornV15Bis);
                context.PhenologicalStages.Add(lPSCornV15Tres);
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
        public static void InsertPhenologicalStagesCornSouthMedium()
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

                #region Corn South Medium
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieCornSouthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V0") select stage).FirstOrDefault();
                var lPSCornV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VE") select stage).FirstOrDefault();
                var lPSCornVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 114.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V1") select stage).FirstOrDefault();
                var lPSCornV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 20, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V2") select stage).FirstOrDefault();
                var lPSCornV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 179.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V3") select stage).FirstOrDefault();
                var lPSCornV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 180, MaxDegree = 229.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V4") select stage).FirstOrDefault();
                var lPSCornV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 230, MaxDegree = 289.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V5") select stage).FirstOrDefault();
                var lPSCornV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 349.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V6") select stage).FirstOrDefault();
                var lPSCornV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 350, MaxDegree = 404.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V7") select stage).FirstOrDefault();
                var lPSCornV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 405, MaxDegree = 459.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V8") select stage).FirstOrDefault();
                var lPSCornV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 519.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V9") select stage).FirstOrDefault();
                var lPSCornV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 520, MaxDegree = 589.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 70, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V10") select stage).FirstOrDefault();
                var lPSCornV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 590, MaxDegree = 649.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V11") select stage).FirstOrDefault();
                var lPSCornV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 650, MaxDegree = 689.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V12") select stage).FirstOrDefault();
                var lPSCornV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 690, MaxDegree = 714.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V13") select stage).FirstOrDefault();
                var lPSCornV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 715, MaxDegree = 749.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V14") select stage).FirstOrDefault();
                var lPSCornV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 750, MaxDegree = 774.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V15") select stage).FirstOrDefault();
                var lPSCornV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V16") select stage).FirstOrDefault();
                var lPSCornV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25, };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VT") select stage).FirstOrDefault();
                var lPSCornVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 775, MaxDegree = 889.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 115 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R1") select stage).FirstOrDefault();
                var lPSCornR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 890, MaxDegree = 1049.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R2") select stage).FirstOrDefault();
                var lPSCornR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1050, MaxDegree = 1199.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R3") select stage).FirstOrDefault();
                var lPSCornR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R4") select stage).FirstOrDefault();
                var lPSCornR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R5") select stage).FirstOrDefault();
                var lPSCornR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 1599.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R6") select stage).FirstOrDefault();
                var lPSCornR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1600, MaxDegree = 1899.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 300 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R7") select stage).FirstOrDefault();
                var lPSCornR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1900, MaxDegree = 2500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1600 };

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
                context.PhenologicalStages.Add(lPSCornV16);
                context.PhenologicalStages.Add(lPSCornVt);
                context.PhenologicalStages.Add(lPSCornR1);
                context.PhenologicalStages.Add(lPSCornR2);
                context.PhenologicalStages.Add(lPSCornR3);
                context.PhenologicalStages.Add(lPSCornR4);
                context.PhenologicalStages.Add(lPSCornR5);
                context.PhenologicalStages.Add(lPSCornR6);
                context.PhenologicalStages.Add(lPSCornR7);
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
                var lPSSoyaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 114.999, Coefficient = 0.30, RootDepth = 7, HydricBalanceDepth = 17, PhenologicalStageIsUsed = true, DegreesDaysInterval = 115, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " VE") select stage).FirstOrDefault();
                var lPSSoyaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 141.999, Coefficient = 0.37, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 27, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V1") select stage).FirstOrDefault();
                var lPSSoyaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 142, MaxDegree = 191.999, Coefficient = 0.40, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V2") select stage).FirstOrDefault();
                var lPSSoyaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 192, MaxDegree = 242.999, Coefficient = 0.43, RootDepth = 12, HydricBalanceDepth = 22, PhenologicalStageIsUsed = true, DegreesDaysInterval = 51 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V3") select stage).FirstOrDefault();
                var lPSSoyaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 243, MaxDegree = 313.999, Coefficient = 0.45, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 71 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V4") select stage).FirstOrDefault();
                var lPSSoyaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 314, MaxDegree = 348.999, Coefficient = 0.50, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V5") select stage).FirstOrDefault();
                var lPSSoyaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 349, MaxDegree = 397.999, Coefficient = 0.52, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 49 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V6") select stage).FirstOrDefault();
                var lPSSoyaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 398, MaxDegree = 445.999, Coefficient = 0.54, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 48 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V7") select stage).FirstOrDefault();
                var lPSSoyaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 446, MaxDegree = 471.999, Coefficient = 0.57, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 26 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V8") select stage).FirstOrDefault();
                var lPSSoyaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 472, MaxDegree = 515.999, Coefficient = 0.59, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 44 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V9") select stage).FirstOrDefault();
                var lPSSoyaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 516, MaxDegree = 565.999, Coefficient = 0.61, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V10") select stage).FirstOrDefault();
                var lPSSoyaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 566, MaxDegree = 653.999, Coefficient = 0.63, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 88 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 654, MaxDegree = 741.999, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 88 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 88 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 88 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R1") select stage).FirstOrDefault();
                var lPSSoyaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 742, MaxDegree = 843.999, Coefficient = 0.72, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 102 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R2") select stage).FirstOrDefault();
                var lPSSoyaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 844, MaxDegree = 911.999, Coefficient = 0.75, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 68 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R3") select stage).FirstOrDefault();
                var lPSSoyaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 912, MaxDegree = 979.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 68 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R4") select stage).FirstOrDefault();
                var lPSSoyaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 980, MaxDegree = 1098.999, Coefficient = 0.83, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 118 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R5") select stage).FirstOrDefault();
                var lPSSoyaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1099, MaxDegree = 1217.999, Coefficient = 0.88, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 119 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R6") select stage).FirstOrDefault();
                var lPSSoyaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1218, MaxDegree = 1608.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 391 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R7") select stage).FirstOrDefault();
                var lPSSoyaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1609, MaxDegree = 1999.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 391 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R8") select stage).FirstOrDefault();
                var lPSSoyaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2000, MaxDegree = 4000, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 2000 };

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
                context.PhenologicalStages.Add(lPSSoyaV12);
                context.PhenologicalStages.Add(lPSSoyaV13);
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
                var lPSSoyaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 114.999, Coefficient = 0.30, RootDepth = 7, HydricBalanceDepth = 17, PhenologicalStageIsUsed = true, DegreesDaysInterval = 115, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " VE") select stage).FirstOrDefault();
                var lPSSoyaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 141.999, Coefficient = 0.37, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 27, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V1") select stage).FirstOrDefault();
                var lPSSoyaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 142, MaxDegree = 191.999, Coefficient = 0.40, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 49, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V2") select stage).FirstOrDefault();
                var lPSSoyaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 192, MaxDegree = 242.999, Coefficient = 0.43, RootDepth = 12, HydricBalanceDepth = 22, PhenologicalStageIsUsed = true, DegreesDaysInterval = 51, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V3") select stage).FirstOrDefault();
                var lPSSoyaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 243, MaxDegree = 313.999, Coefficient = 0.45, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 71, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V4") select stage).FirstOrDefault();
                var lPSSoyaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 314, MaxDegree = 348.999, Coefficient = 0.50, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V5") select stage).FirstOrDefault();
                var lPSSoyaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 349, MaxDegree = 397.999, Coefficient = 0.52, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 49, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V6") select stage).FirstOrDefault();
                var lPSSoyaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 398, MaxDegree = 445.999, Coefficient = 0.54, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 48, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V7") select stage).FirstOrDefault();
                var lPSSoyaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 446, MaxDegree = 471.999, Coefficient = 0.57, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 26, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V8") select stage).FirstOrDefault();
                var lPSSoyaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 472, MaxDegree = 515.999, Coefficient = 0.59, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 44, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V9") select stage).FirstOrDefault();
                var lPSSoyaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 516, MaxDegree = 565.999, Coefficient = 0.61, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V10") select stage).FirstOrDefault();
                var lPSSoyaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 566, MaxDegree = 653.999, Coefficient = 0.63, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 88, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 654, MaxDegree = 741.999, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 88, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V12") select stage).FirstOrDefault();
                var lPSSoyaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 80, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V13") select stage).FirstOrDefault();
                var lPSSoyaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 80, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R1") select stage).FirstOrDefault();
                var lPSSoyaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 742, MaxDegree = 843.999, Coefficient = 0.72, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 102, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R2") select stage).FirstOrDefault();
                var lPSSoyaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 844, MaxDegree = 911.999, Coefficient = 0.75, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 68, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R3") select stage).FirstOrDefault();
                var lPSSoyaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 912, MaxDegree = 979.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 68, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R4") select stage).FirstOrDefault();
                var lPSSoyaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 980, MaxDegree = 1098.999, Coefficient = 0.83, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 119, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R5") select stage).FirstOrDefault();
                var lPSSoyaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1099, MaxDegree = 1217.999, Coefficient = 0.88, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 119, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R6") select stage).FirstOrDefault();
                var lPSSoyaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1218, MaxDegree = 1608.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 391, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R7") select stage).FirstOrDefault();
                var lPSSoyaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1609, MaxDegree = 1999.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 391, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R8") select stage).FirstOrDefault();
                var lPSSoyaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2000, MaxDegree = 4000, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 2000, };

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
                context.PhenologicalStages.Add(lPSSoyaV12);
                context.PhenologicalStages.Add(lPSSoyaV13);
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

                #region Corn North Short
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieCornNorthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V0") select stage).FirstOrDefault();
                var lPSCornV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VE") select stage).FirstOrDefault();
                var lPSCornVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 114.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V1") select stage).FirstOrDefault();
                var lPSCornV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 20, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V2") select stage).FirstOrDefault();
                var lPSCornV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 179.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V3") select stage).FirstOrDefault();
                var lPSCornV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 180, MaxDegree = 229.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V4") select stage).FirstOrDefault();
                var lPSCornV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 230, MaxDegree = 289.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V5") select stage).FirstOrDefault();
                var lPSCornV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 349.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V6") select stage).FirstOrDefault();
                var lPSCornV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 350, MaxDegree = 404.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V7") select stage).FirstOrDefault();
                var lPSCornV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 405, MaxDegree = 459.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V8") select stage).FirstOrDefault();
                var lPSCornV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 519.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V9") select stage).FirstOrDefault();
                var lPSCornV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 520, MaxDegree = 589.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 70, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V10") select stage).FirstOrDefault();
                var lPSCornV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 590, MaxDegree = 649.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V11") select stage).FirstOrDefault();
                var lPSCornV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 650, MaxDegree = 689.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V12") select stage).FirstOrDefault();
                var lPSCornV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 690, MaxDegree = 714.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V13") select stage).FirstOrDefault();
                var lPSCornV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 715, MaxDegree = 749.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V14") select stage).FirstOrDefault();
                var lPSCornV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 750, MaxDegree = 774.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V15") select stage).FirstOrDefault();
                var lPSCornV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 775, MaxDegree = 889.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 115, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V16") select stage).FirstOrDefault();
                var lPSCornV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V17") select stage).FirstOrDefault();
                var lPSCornV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25, };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VT") select stage).FirstOrDefault();
                var lPSCornVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 890, MaxDegree = 1049.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R1") select stage).FirstOrDefault();
                var lPSCornR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1050, MaxDegree = 1199.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R2") select stage).FirstOrDefault();
                var lPSCornR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R3") select stage).FirstOrDefault();
                var lPSCornR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R4") select stage).FirstOrDefault();
                var lPSCornR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 1599.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R5") select stage).FirstOrDefault();
                var lPSCornR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1600, MaxDegree = 1899.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 300, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R6") select stage).FirstOrDefault();
                var lPSCornR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1900, MaxDegree = 2499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 600, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R7") select stage).FirstOrDefault();
                var lPSCornR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 4000, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1500, };

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
                context.PhenologicalStages.Add(lPSCornV16);
                context.PhenologicalStages.Add(lPSCornV17);
                context.PhenologicalStages.Add(lPSCornVt);
                context.PhenologicalStages.Add(lPSCornR1);
                context.PhenologicalStages.Add(lPSCornR2);
                context.PhenologicalStages.Add(lPSCornR3);
                context.PhenologicalStages.Add(lPSCornR4);
                context.PhenologicalStages.Add(lPSCornR5);
                context.PhenologicalStages.Add(lPSCornR6);
                context.PhenologicalStages.Add(lPSCornR7);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesCornNorthMedium()
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

                #region Corn North Medium
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieCornNorthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V0") select stage).FirstOrDefault();
                var lPSCornV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VE") select stage).FirstOrDefault();
                var lPSCornVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 114.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V1") select stage).FirstOrDefault();
                var lPSCornV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 20, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V2") select stage).FirstOrDefault();
                var lPSCornV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 179.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V3") select stage).FirstOrDefault();
                var lPSCornV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 180, MaxDegree = 229.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V4") select stage).FirstOrDefault();
                var lPSCornV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 230, MaxDegree = 289.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V5") select stage).FirstOrDefault();
                var lPSCornV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 349.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V6") select stage).FirstOrDefault();
                var lPSCornV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 350, MaxDegree = 404.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V7") select stage).FirstOrDefault();
                var lPSCornV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 405, MaxDegree = 459.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V8") select stage).FirstOrDefault();
                var lPSCornV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 519.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V9") select stage).FirstOrDefault();
                var lPSCornV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 520, MaxDegree = 589.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 70, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V10") select stage).FirstOrDefault();
                var lPSCornV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 590, MaxDegree = 649.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V11") select stage).FirstOrDefault();
                var lPSCornV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 650, MaxDegree = 689.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V12") select stage).FirstOrDefault();
                var lPSCornV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 690, MaxDegree = 714.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V13") select stage).FirstOrDefault();
                var lPSCornV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 715, MaxDegree = 749.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V14") select stage).FirstOrDefault();
                var lPSCornV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 750, MaxDegree = 774.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V15") select stage).FirstOrDefault();
                var lPSCornV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 775, MaxDegree = 889.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 15, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V16") select stage).FirstOrDefault();
                var lPSCornV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V17") select stage).FirstOrDefault();
                var lPSCornV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25, };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VT") select stage).FirstOrDefault();
                var lPSCornVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 890, MaxDegree = 1049.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R1") select stage).FirstOrDefault();
                var lPSCornR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1050, MaxDegree = 1199.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R2") select stage).FirstOrDefault();
                var lPSCornR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R3") select stage).FirstOrDefault();
                var lPSCornR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 159, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R4") select stage).FirstOrDefault();
                var lPSCornR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 1599.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R5") select stage).FirstOrDefault();
                var lPSCornR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1600, MaxDegree = 1899.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 300, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R6") select stage).FirstOrDefault();
                var lPSCornR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1900, MaxDegree = 2500, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 600, };

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
                context.PhenologicalStages.Add(lPSCornV16);
                context.PhenologicalStages.Add(lPSCornV17);
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
                var lPSSoyaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 114.999, Coefficient = 0.30, RootDepth = 7, HydricBalanceDepth = 17, PhenologicalStageIsUsed = true, DegreesDaysInterval = 115, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " VE") select stage).FirstOrDefault();
                var lPSSoyaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 141.999, Coefficient = 0.37, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 27, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V1") select stage).FirstOrDefault();
                var lPSSoyaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 142, MaxDegree = 191.999, Coefficient = 0.40, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V2") select stage).FirstOrDefault();
                var lPSSoyaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 192, MaxDegree = 242.999, Coefficient = 0.43, RootDepth = 12, HydricBalanceDepth = 22, PhenologicalStageIsUsed = true, DegreesDaysInterval = 51, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V3") select stage).FirstOrDefault();
                var lPSSoyaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 243, MaxDegree = 313.999, Coefficient = 0.45, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 71, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V4") select stage).FirstOrDefault();
                var lPSSoyaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 314, MaxDegree = 348.999, Coefficient = 0.50, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V5") select stage).FirstOrDefault();
                var lPSSoyaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 349, MaxDegree = 397.999, Coefficient = 0.52, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 49, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V6") select stage).FirstOrDefault();
                var lPSSoyaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 398, MaxDegree = 445.999, Coefficient = 0.54, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 48, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V7") select stage).FirstOrDefault();
                var lPSSoyaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 446, MaxDegree = 471.999, Coefficient = 0.57, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 26, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V8") select stage).FirstOrDefault();
                var lPSSoyaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 472, MaxDegree = 515.999, Coefficient = 0.59, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 44, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V9") select stage).FirstOrDefault();
                var lPSSoyaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 516, MaxDegree = 565.999, Coefficient = 0.61, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V10") select stage).FirstOrDefault();
                var lPSSoyaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 566, MaxDegree = 653.999, Coefficient = 0.63, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 88, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 654, MaxDegree = 741.999, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 88, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V12") select stage).FirstOrDefault();
                var lPSSoyaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 80, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V13") select stage).FirstOrDefault();
                var lPSSoyaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 80, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R1") select stage).FirstOrDefault();
                var lPSSoyaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 742, MaxDegree = 843.999, Coefficient = 0.72, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 102, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R2") select stage).FirstOrDefault();
                var lPSSoyaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 844, MaxDegree = 911.999, Coefficient = 0.75, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 68, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R3") select stage).FirstOrDefault();
                var lPSSoyaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 912, MaxDegree = 979.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 68, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R4") select stage).FirstOrDefault();
                var lPSSoyaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 980, MaxDegree = 1098.999, Coefficient = 0.83, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 119, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R5") select stage).FirstOrDefault();
                var lPSSoyaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1099, MaxDegree = 1217.999, Coefficient = 0.88, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 119, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R6") select stage).FirstOrDefault();
                var lPSSoyaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1218, MaxDegree = 1608.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 391, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R7") select stage).FirstOrDefault();
                var lPSSoyaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1609, MaxDegree = 1999.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 391, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R8") select stage).FirstOrDefault();
                var lPSSoyaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2000, MaxDegree = 4000, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 2000, };

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
                context.PhenologicalStages.Add(lPSSoyaV12);
                context.PhenologicalStages.Add(lPSSoyaV13);
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

        public static void InsertPhenologicalStagesSoyaNorthMedium()
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

                #region Soya North Medium
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieSoyaNorthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V0") select stage).FirstOrDefault();
                var lPSSoyaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 114.999, Coefficient = 0.30, RootDepth = 7, HydricBalanceDepth = 17, PhenologicalStageIsUsed = true, DegreesDaysInterval = 115, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " VE") select stage).FirstOrDefault();
                var lPSSoyaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 141.999, Coefficient = 0.37, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval =  27, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V1") select stage).FirstOrDefault();
                var lPSSoyaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 142, MaxDegree = 191.999, Coefficient = 0.40, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V2") select stage).FirstOrDefault();
                var lPSSoyaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 192, MaxDegree = 242.999, Coefficient = 0.43, RootDepth = 12, HydricBalanceDepth = 22, PhenologicalStageIsUsed = true, DegreesDaysInterval = 51, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V3") select stage).FirstOrDefault();
                var lPSSoyaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 243, MaxDegree = 313.999, Coefficient = 0.45, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 71, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V4") select stage).FirstOrDefault();
                var lPSSoyaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 314, MaxDegree = 348.999, Coefficient = 0.50, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V5") select stage).FirstOrDefault();
                var lPSSoyaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 349, MaxDegree = 397.999, Coefficient = 0.52, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 49, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V6") select stage).FirstOrDefault();
                var lPSSoyaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 398, MaxDegree = 445.999, Coefficient = 0.54, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 48, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V7") select stage).FirstOrDefault();
                var lPSSoyaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 446, MaxDegree = 471.999, Coefficient = 0.57, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 26, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V8") select stage).FirstOrDefault();
                var lPSSoyaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 472, MaxDegree = 515.999, Coefficient = 0.59, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 44, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V9") select stage).FirstOrDefault();
                var lPSSoyaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 516, MaxDegree = 565.999, Coefficient = 0.61, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V10") select stage).FirstOrDefault();
                var lPSSoyaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 566, MaxDegree = 653.999, Coefficient = 0.63, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 88, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 654, MaxDegree = 741.999, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 88,};

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V12") select stage).FirstOrDefault();
                var lPSSoyaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 80, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V13") select stage).FirstOrDefault();
                var lPSSoyaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 80, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R1") select stage).FirstOrDefault();
                var lPSSoyaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 742, MaxDegree = 843.999, Coefficient = 0.72, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 102, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R2") select stage).FirstOrDefault();
                var lPSSoyaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 844, MaxDegree = 911.999, Coefficient = 0.75, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 68, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R3") select stage).FirstOrDefault();
                var lPSSoyaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 912, MaxDegree = 979.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 68, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R4") select stage).FirstOrDefault();
                var lPSSoyaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 980, MaxDegree = 1098.999, Coefficient = 0.83, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 119, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R5") select stage).FirstOrDefault();
                var lPSSoyaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1099, MaxDegree = 1217.999, Coefficient = 0.88, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 119,};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R6") select stage).FirstOrDefault();
                var lPSSoyaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1218, MaxDegree = 1608.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 391, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R7") select stage).FirstOrDefault();
                var lPSSoyaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1609, MaxDegree = 1999.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 391, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R8") select stage).FirstOrDefault();
                var lPSSoyaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2000, MaxDegree = 4000, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 2000, };

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
                context.PhenologicalStages.Add(lPSSoyaV12);
                context.PhenologicalStages.Add(lPSSoyaV13);
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
        #region 2017
        public static void InsertPhenologicalStagesCornSouthShort_2017()
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
                var lPSCornV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VE") select stage).FirstOrDefault();
                var lPSCornVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V1") select stage).FirstOrDefault();
                var lPSCornV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V2") select stage).FirstOrDefault();
                var lPSCornV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V3") select stage).FirstOrDefault();
                var lPSCornV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V4") select stage).FirstOrDefault();
                var lPSCornV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V5") select stage).FirstOrDefault();
                var lPSCornV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40};

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V6") select stage).FirstOrDefault();
                var lPSCornV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V7") select stage).FirstOrDefault();
                var lPSCornV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V8") select stage).FirstOrDefault();
                var lPSCornV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V9") select stage).FirstOrDefault();
                var lPSCornV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V10") select stage).FirstOrDefault();
                var lPSCornV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35};

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V11") select stage).FirstOrDefault();
                var lPSCornV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V12") select stage).FirstOrDefault();
                var lPSCornV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V13") select stage).FirstOrDefault();
                var lPSCornV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V14") select stage).FirstOrDefault();
                var lPSCornV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25};

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V15") select stage).FirstOrDefault();
                var lPSCornV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V16") select stage).FirstOrDefault();
                var lPSCornV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V17") select stage).FirstOrDefault();
                var lPSCornV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VT") select stage).FirstOrDefault();
                var lPSCornVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R1") select stage).FirstOrDefault();
                var lPSCornR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R2") select stage).FirstOrDefault();
                var lPSCornR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R3") select stage).FirstOrDefault();
                var lPSCornR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R4") select stage).FirstOrDefault();
                var lPSCornR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R5") select stage).FirstOrDefault();
                var lPSCornR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150};
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R6") select stage).FirstOrDefault();
                var lPSCornR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R7") select stage).FirstOrDefault();
                var lPSCornR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R8") select stage).FirstOrDefault();
                var lPSCornR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

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
                context.PhenologicalStages.Add(lPSCornV16);
                context.PhenologicalStages.Add(lPSCornV17);
                context.PhenologicalStages.Add(lPSCornVt);
                context.PhenologicalStages.Add(lPSCornR1);
                context.PhenologicalStages.Add(lPSCornR2);
                context.PhenologicalStages.Add(lPSCornR3);
                context.PhenologicalStages.Add(lPSCornR4);
                context.PhenologicalStages.Add(lPSCornR5);
                context.PhenologicalStages.Add(lPSCornR6);
                context.PhenologicalStages.Add(lPSCornR7);
                context.PhenologicalStages.Add(lPSCornR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesSoyaSouthShort_2017()
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
                var lPSSoyaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 114.999, Coefficient = 0.30, RootDepth = 7, HydricBalanceDepth = 17, PhenologicalStageIsUsed = true, DegreesDaysInterval = 115, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " VE") select stage).FirstOrDefault();
                var lPSSoyaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 141.999, Coefficient = 0.37, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 27, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V1") select stage).FirstOrDefault();
                var lPSSoyaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 142, MaxDegree = 191.999, Coefficient = 0.40, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V2") select stage).FirstOrDefault();
                var lPSSoyaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 192, MaxDegree = 242.999, Coefficient = 0.43, RootDepth = 12, HydricBalanceDepth = 22, PhenologicalStageIsUsed = true, DegreesDaysInterval = 51, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V3") select stage).FirstOrDefault();
                var lPSSoyaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 243, MaxDegree = 313.999, Coefficient = 0.45, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 71, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V4") select stage).FirstOrDefault();
                var lPSSoyaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 314, MaxDegree = 348.999, Coefficient = 0.50, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V5") select stage).FirstOrDefault();
                var lPSSoyaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 349, MaxDegree = 397.999, Coefficient = 0.52, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 49, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V6") select stage).FirstOrDefault();
                var lPSSoyaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 398, MaxDegree = 445.999, Coefficient = 0.54, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 48, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V7") select stage).FirstOrDefault();
                var lPSSoyaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 446, MaxDegree = 471.999, Coefficient = 0.57, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 26, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V8") select stage).FirstOrDefault();
                var lPSSoyaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 472, MaxDegree = 515.999, Coefficient = 0.59, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 44, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V9") select stage).FirstOrDefault();
                var lPSSoyaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 516, MaxDegree = 615.999, Coefficient = 0.61, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V10") select stage).FirstOrDefault();
                var lPSSoyaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 616, MaxDegree = 741.999, Coefficient = 0.63, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 126, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 742, MaxDegree = 843.999, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 102, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V12") select stage).FirstOrDefault();
                var lPSSoyaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 100, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V13") select stage).FirstOrDefault();
                var lPSSoyaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 100, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R1") select stage).FirstOrDefault();
                var lPSSoyaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 844, MaxDegree = 911.999, Coefficient = 0.72, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 68, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R2") select stage).FirstOrDefault();
                var lPSSoyaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 912, MaxDegree = 979.999, Coefficient = 0.75, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 68, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R3") select stage).FirstOrDefault();
                var lPSSoyaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 980, MaxDegree = 1058.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 79, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R4") select stage).FirstOrDefault();
                var lPSSoyaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1059, MaxDegree = 1149.999, Coefficient = 0.83, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 91, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R5") select stage).FirstOrDefault();
                var lPSSoyaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1150, MaxDegree = 1267.999, Coefficient = 0.88, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 118, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R6") select stage).FirstOrDefault();
                var lPSSoyaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1268, MaxDegree = 1608.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 341, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R7") select stage).FirstOrDefault();
                var lPSSoyaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1609, MaxDegree = 1999.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 391, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R8") select stage).FirstOrDefault();
                var lPSSoyaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2000, MaxDegree = 4000, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 2000, };

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
                context.PhenologicalStages.Add(lPSSoyaV12);
                context.PhenologicalStages.Add(lPSSoyaV13);
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

        public static void InsertPhenologicalStagesCornNorthShort_2017()
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

                #region Corn North Short
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieCornNorthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V0") select stage).FirstOrDefault();
                var lPSCornV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VE") select stage).FirstOrDefault();
                var lPSCornVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V1") select stage).FirstOrDefault();
                var lPSCornV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V2") select stage).FirstOrDefault();
                var lPSCornV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V3") select stage).FirstOrDefault();
                var lPSCornV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V4") select stage).FirstOrDefault();
                var lPSCornV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V5") select stage).FirstOrDefault();
                var lPSCornV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V6") select stage).FirstOrDefault();
                var lPSCornV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V7") select stage).FirstOrDefault();
                var lPSCornV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V8") select stage).FirstOrDefault();
                var lPSCornV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V9") select stage).FirstOrDefault();
                var lPSCornV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V10") select stage).FirstOrDefault();
                var lPSCornV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V11") select stage).FirstOrDefault();
                var lPSCornV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V12") select stage).FirstOrDefault();
                var lPSCornV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V13") select stage).FirstOrDefault();
                var lPSCornV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V14") select stage).FirstOrDefault();
                var lPSCornV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V15") select stage).FirstOrDefault();
                var lPSCornV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VT") select stage).FirstOrDefault();
                var lPSCornVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R1") select stage).FirstOrDefault();
                var lPSCornR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R2") select stage).FirstOrDefault();
                var lPSCornR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R3") select stage).FirstOrDefault();
                var lPSCornR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R4") select stage).FirstOrDefault();
                var lPSCornR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R5") select stage).FirstOrDefault();
                var lPSCornR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R6") select stage).FirstOrDefault();
                var lPSCornR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R7") select stage).FirstOrDefault();
                var lPSCornR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R8") select stage).FirstOrDefault();
                var lPSCornR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000, };

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
                context.PhenologicalStages.Add(lPSCornR7);
                context.PhenologicalStages.Add(lPSCornR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesSoyaNorthShort_2017()
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
                var lPSSoyaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 114.999, Coefficient = 0.30, RootDepth = 7, HydricBalanceDepth = 17, PhenologicalStageIsUsed = true, DegreesDaysInterval = 115, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " VE") select stage).FirstOrDefault();
                var lPSSoyaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 141.999, Coefficient = 0.37, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 27, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V1") select stage).FirstOrDefault();
                var lPSSoyaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 142, MaxDegree = 191.999, Coefficient = 0.40, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V2") select stage).FirstOrDefault();
                var lPSSoyaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 192, MaxDegree = 242.999, Coefficient = 0.43, RootDepth = 12, HydricBalanceDepth = 22, PhenologicalStageIsUsed = true, DegreesDaysInterval = 51, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V3") select stage).FirstOrDefault();
                var lPSSoyaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 243, MaxDegree = 313.999, Coefficient = 0.45, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 71, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V4") select stage).FirstOrDefault();
                var lPSSoyaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 314, MaxDegree = 348.999, Coefficient = 0.50, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V5") select stage).FirstOrDefault();
                var lPSSoyaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 349, MaxDegree = 397.999, Coefficient = 0.52, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 49, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V6") select stage).FirstOrDefault();
                var lPSSoyaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 398, MaxDegree = 445.999, Coefficient = 0.54, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 48, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V7") select stage).FirstOrDefault();
                var lPSSoyaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 446, MaxDegree = 471.999, Coefficient = 0.57, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 26, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V8") select stage).FirstOrDefault();
                var lPSSoyaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 472, MaxDegree = 515.999, Coefficient = 0.59, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 44, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V9") select stage).FirstOrDefault();
                var lPSSoyaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 516, MaxDegree = 615.999, Coefficient = 0.61, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V10") select stage).FirstOrDefault();
                var lPSSoyaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 616, MaxDegree = 741.999, Coefficient = 0.63, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 126, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 742, MaxDegree = 843.999, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 102, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V12") select stage).FirstOrDefault();
                var lPSSoyaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 100, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V13") select stage).FirstOrDefault();
                var lPSSoyaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 100, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R1") select stage).FirstOrDefault();
                var lPSSoyaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 844, MaxDegree = 911.999, Coefficient = 0.72, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 68, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R2") select stage).FirstOrDefault();
                var lPSSoyaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 912, MaxDegree = 979.999, Coefficient = 0.75, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 68, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R3") select stage).FirstOrDefault();
                var lPSSoyaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 980, MaxDegree = 1058.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 79, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R4") select stage).FirstOrDefault();
                var lPSSoyaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1059, MaxDegree = 1149.999, Coefficient = 0.83, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 91, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R5") select stage).FirstOrDefault();
                var lPSSoyaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1150, MaxDegree = 1267.999, Coefficient = 0.88, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 118, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R6") select stage).FirstOrDefault();
                var lPSSoyaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1268, MaxDegree = 1608.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 341, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R7") select stage).FirstOrDefault();
                var lPSSoyaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1609, MaxDegree = 1999.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 391, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R8") select stage).FirstOrDefault();
                var lPSSoyaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2000, MaxDegree = 4000, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 2000, };

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
                context.PhenologicalStages.Add(lPSSoyaV12);
                context.PhenologicalStages.Add(lPSSoyaV13);
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

        public static void InsertPhenologicalStagesOatSouthShort_2017()
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

                #region Oat
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieOatSouthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V0") select stage).FirstOrDefault();
                var lPSOatV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " VE") select stage).FirstOrDefault();
                var lPSOatVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V1") select stage).FirstOrDefault();
                var lPSOatV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V2") select stage).FirstOrDefault();
                var lPSOatV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V3") select stage).FirstOrDefault();
                var lPSOatV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V4") select stage).FirstOrDefault();
                var lPSOatV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V5") select stage).FirstOrDefault();
                var lPSOatV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V6") select stage).FirstOrDefault();
                var lPSOatV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V7") select stage).FirstOrDefault();
                var lPSOatV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V8") select stage).FirstOrDefault();
                var lPSOatV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V9") select stage).FirstOrDefault();
                var lPSOatV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V10") select stage).FirstOrDefault();
                var lPSOatV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V11") select stage).FirstOrDefault();
                var lPSOatV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V12") select stage).FirstOrDefault();
                var lPSOatV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V13") select stage).FirstOrDefault();
                var lPSOatV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V14") select stage).FirstOrDefault();
                var lPSOatV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 729.99, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V15") select stage).FirstOrDefault();
                var lPSOatV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 730, MaxDegree = 879.99, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V16") select stage).FirstOrDefault();
                var lPSOatV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 880, MaxDegree = 1029.99, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V17") select stage).FirstOrDefault();
                var lPSOatV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1030, MaxDegree = 1179.99, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " VT") select stage).FirstOrDefault();
                var lPSOatVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1180, MaxDegree = 1279.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R1") select stage).FirstOrDefault();
                var lPSOatR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1280, MaxDegree = 1399.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R2") select stage).FirstOrDefault();
                var lPSOatR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1400, MaxDegree = 1529.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R3") select stage).FirstOrDefault();
                var lPSOatR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1530, MaxDegree = 1639.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R4") select stage).FirstOrDefault();
                var lPSOatR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1640, MaxDegree = 1799.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R5") select stage).FirstOrDefault();
                var lPSOatR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1800, MaxDegree = 1949.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R6") select stage).FirstOrDefault();
                var lPSOatR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1950, MaxDegree = 2099.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R7") select stage).FirstOrDefault();
                var lPSOatR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2100, MaxDegree = 3199.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R8") select stage).FirstOrDefault();
                var lPSOatR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3100, MaxDegree = 4100, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - Oat
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSOatV0);
                context.PhenologicalStages.Add(lPSOatVe);
                context.PhenologicalStages.Add(lPSOatV1);
                context.PhenologicalStages.Add(lPSOatV2);
                context.PhenologicalStages.Add(lPSOatV3);
                context.PhenologicalStages.Add(lPSOatV4);
                context.PhenologicalStages.Add(lPSOatV5);
                context.PhenologicalStages.Add(lPSOatV6);
                context.PhenologicalStages.Add(lPSOatV7);
                context.PhenologicalStages.Add(lPSOatV8);
                context.PhenologicalStages.Add(lPSOatV9);
                context.PhenologicalStages.Add(lPSOatV10);
                context.PhenologicalStages.Add(lPSOatV11);
                context.PhenologicalStages.Add(lPSOatV12);
                context.PhenologicalStages.Add(lPSOatV13);
                context.PhenologicalStages.Add(lPSOatV14);
                context.PhenologicalStages.Add(lPSOatV15);
                context.PhenologicalStages.Add(lPSOatV16);
                context.PhenologicalStages.Add(lPSOatV17);
                context.PhenologicalStages.Add(lPSOatVt);
                context.PhenologicalStages.Add(lPSOatR1);
                context.PhenologicalStages.Add(lPSOatR2);
                context.PhenologicalStages.Add(lPSOatR3);
                context.PhenologicalStages.Add(lPSOatR4);
                context.PhenologicalStages.Add(lPSOatR5);
                context.PhenologicalStages.Add(lPSOatR6);
                context.PhenologicalStages.Add(lPSOatR7);
                context.PhenologicalStages.Add(lPSOatR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesOatSouthMedium_2017()
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

                #region Oat
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieOatSouthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V0") select stage).FirstOrDefault();
                var lPSOatV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " VE") select stage).FirstOrDefault();
                var lPSOatVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V1") select stage).FirstOrDefault();
                var lPSOatV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V2") select stage).FirstOrDefault();
                var lPSOatV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V3") select stage).FirstOrDefault();
                var lPSOatV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V4") select stage).FirstOrDefault();
                var lPSOatV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V5") select stage).FirstOrDefault();
                var lPSOatV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V6") select stage).FirstOrDefault();
                var lPSOatV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V7") select stage).FirstOrDefault();
                var lPSOatV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V8") select stage).FirstOrDefault();
                var lPSOatV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V9") select stage).FirstOrDefault();
                var lPSOatV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V10") select stage).FirstOrDefault();
                var lPSOatV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V11") select stage).FirstOrDefault();
                var lPSOatV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V12") select stage).FirstOrDefault();
                var lPSOatV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V13") select stage).FirstOrDefault();
                var lPSOatV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V14") select stage).FirstOrDefault();
                var lPSOatV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V15") select stage).FirstOrDefault();
                var lPSOatV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V16") select stage).FirstOrDefault();
                var lPSOatV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V17") select stage).FirstOrDefault();
                var lPSOatV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " VT") select stage).FirstOrDefault();
                var lPSOatVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R1") select stage).FirstOrDefault();
                var lPSOatR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R2") select stage).FirstOrDefault();
                var lPSOatR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R3") select stage).FirstOrDefault();
                var lPSOatR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R4") select stage).FirstOrDefault();
                var lPSOatR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R5") select stage).FirstOrDefault();
                var lPSOatR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R6") select stage).FirstOrDefault();
                var lPSOatR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R7") select stage).FirstOrDefault();
                var lPSOatR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R8") select stage).FirstOrDefault();
                var lPSOatR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - Oat
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSOatV0);
                context.PhenologicalStages.Add(lPSOatVe);
                context.PhenologicalStages.Add(lPSOatV1);
                context.PhenologicalStages.Add(lPSOatV2);
                context.PhenologicalStages.Add(lPSOatV3);
                context.PhenologicalStages.Add(lPSOatV4);
                context.PhenologicalStages.Add(lPSOatV5);
                context.PhenologicalStages.Add(lPSOatV6);
                context.PhenologicalStages.Add(lPSOatV7);
                context.PhenologicalStages.Add(lPSOatV8);
                context.PhenologicalStages.Add(lPSOatV9);
                context.PhenologicalStages.Add(lPSOatV10);
                context.PhenologicalStages.Add(lPSOatV11);
                context.PhenologicalStages.Add(lPSOatV12);
                context.PhenologicalStages.Add(lPSOatV13);
                context.PhenologicalStages.Add(lPSOatV14);
                context.PhenologicalStages.Add(lPSOatV15);
                context.PhenologicalStages.Add(lPSOatV16);
                context.PhenologicalStages.Add(lPSOatV17);
                context.PhenologicalStages.Add(lPSOatVt);
                context.PhenologicalStages.Add(lPSOatR1);
                context.PhenologicalStages.Add(lPSOatR2);
                context.PhenologicalStages.Add(lPSOatR3);
                context.PhenologicalStages.Add(lPSOatR4);
                context.PhenologicalStages.Add(lPSOatR5);
                context.PhenologicalStages.Add(lPSOatR6);
                context.PhenologicalStages.Add(lPSOatR7);
                context.PhenologicalStages.Add(lPSOatR8);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesOatNorthShort_2017()
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

                #region Oat
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieOatNorthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V0") select stage).FirstOrDefault();
                var lPSOatV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " VE") select stage).FirstOrDefault();
                var lPSOatVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V1") select stage).FirstOrDefault();
                var lPSOatV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V2") select stage).FirstOrDefault();
                var lPSOatV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V3") select stage).FirstOrDefault();
                var lPSOatV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V4") select stage).FirstOrDefault();
                var lPSOatV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V5") select stage).FirstOrDefault();
                var lPSOatV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V6") select stage).FirstOrDefault();
                var lPSOatV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V7") select stage).FirstOrDefault();
                var lPSOatV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V8") select stage).FirstOrDefault();
                var lPSOatV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V9") select stage).FirstOrDefault();
                var lPSOatV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V10") select stage).FirstOrDefault();
                var lPSOatV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V11") select stage).FirstOrDefault();
                var lPSOatV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V12") select stage).FirstOrDefault();
                var lPSOatV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V13") select stage).FirstOrDefault();
                var lPSOatV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V14") select stage).FirstOrDefault();
                var lPSOatV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V15") select stage).FirstOrDefault();
                var lPSOatV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V16") select stage).FirstOrDefault();
                var lPSOatV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V17") select stage).FirstOrDefault();
                var lPSOatV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " VT") select stage).FirstOrDefault();
                var lPSOatVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R1") select stage).FirstOrDefault();
                var lPSOatR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R2") select stage).FirstOrDefault();
                var lPSOatR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R3") select stage).FirstOrDefault();
                var lPSOatR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R4") select stage).FirstOrDefault();
                var lPSOatR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R5") select stage).FirstOrDefault();
                var lPSOatR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R6") select stage).FirstOrDefault();
                var lPSOatR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R7") select stage).FirstOrDefault();
                var lPSOatR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R8") select stage).FirstOrDefault();
                var lPSOatR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - Oat
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSOatV0);
                context.PhenologicalStages.Add(lPSOatVe);
                context.PhenologicalStages.Add(lPSOatV1);
                context.PhenologicalStages.Add(lPSOatV2);
                context.PhenologicalStages.Add(lPSOatV3);
                context.PhenologicalStages.Add(lPSOatV4);
                context.PhenologicalStages.Add(lPSOatV5);
                context.PhenologicalStages.Add(lPSOatV6);
                context.PhenologicalStages.Add(lPSOatV7);
                context.PhenologicalStages.Add(lPSOatV8);
                context.PhenologicalStages.Add(lPSOatV9);
                context.PhenologicalStages.Add(lPSOatV10);
                context.PhenologicalStages.Add(lPSOatV11);
                context.PhenologicalStages.Add(lPSOatV12);
                context.PhenologicalStages.Add(lPSOatV13);
                context.PhenologicalStages.Add(lPSOatV14);
                context.PhenologicalStages.Add(lPSOatV15);
                context.PhenologicalStages.Add(lPSOatV16);
                context.PhenologicalStages.Add(lPSOatV17);
                context.PhenologicalStages.Add(lPSOatVt);
                context.PhenologicalStages.Add(lPSOatR1);
                context.PhenologicalStages.Add(lPSOatR2);
                context.PhenologicalStages.Add(lPSOatR3);
                context.PhenologicalStages.Add(lPSOatR4);
                context.PhenologicalStages.Add(lPSOatR5);
                context.PhenologicalStages.Add(lPSOatR6);
                context.PhenologicalStages.Add(lPSOatR7);
                context.PhenologicalStages.Add(lPSOatR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesOatNorthMedium_2017()
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

                #region Oat
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieOatNorthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V0") select stage).FirstOrDefault();
                var lPSOatV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " VE") select stage).FirstOrDefault();
                var lPSOatVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V1") select stage).FirstOrDefault();
                var lPSOatV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V2") select stage).FirstOrDefault();
                var lPSOatV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V3") select stage).FirstOrDefault();
                var lPSOatV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V4") select stage).FirstOrDefault();
                var lPSOatV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V5") select stage).FirstOrDefault();
                var lPSOatV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V6") select stage).FirstOrDefault();
                var lPSOatV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V7") select stage).FirstOrDefault();
                var lPSOatV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V8") select stage).FirstOrDefault();
                var lPSOatV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V9") select stage).FirstOrDefault();
                var lPSOatV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V10") select stage).FirstOrDefault();
                var lPSOatV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V11") select stage).FirstOrDefault();
                var lPSOatV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V12") select stage).FirstOrDefault();
                var lPSOatV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V13") select stage).FirstOrDefault();
                var lPSOatV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V14") select stage).FirstOrDefault();
                var lPSOatV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V15") select stage).FirstOrDefault();
                var lPSOatV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V16") select stage).FirstOrDefault();
                var lPSOatV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V17") select stage).FirstOrDefault();
                var lPSOatV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " VT") select stage).FirstOrDefault();
                var lPSOatVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R1") select stage).FirstOrDefault();
                var lPSOatR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R2") select stage).FirstOrDefault();
                var lPSOatR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R3") select stage).FirstOrDefault();
                var lPSOatR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R4") select stage).FirstOrDefault();
                var lPSOatR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R5") select stage).FirstOrDefault();
                var lPSOatR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R6") select stage).FirstOrDefault();
                var lPSOatR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R7") select stage).FirstOrDefault();
                var lPSOatR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R8") select stage).FirstOrDefault();
                var lPSOatR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - Oat
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSOatV0);
                context.PhenologicalStages.Add(lPSOatVe);
                context.PhenologicalStages.Add(lPSOatV1);
                context.PhenologicalStages.Add(lPSOatV2);
                context.PhenologicalStages.Add(lPSOatV3);
                context.PhenologicalStages.Add(lPSOatV4);
                context.PhenologicalStages.Add(lPSOatV5);
                context.PhenologicalStages.Add(lPSOatV6);
                context.PhenologicalStages.Add(lPSOatV7);
                context.PhenologicalStages.Add(lPSOatV8);
                context.PhenologicalStages.Add(lPSOatV9);
                context.PhenologicalStages.Add(lPSOatV10);
                context.PhenologicalStages.Add(lPSOatV11);
                context.PhenologicalStages.Add(lPSOatV12);
                context.PhenologicalStages.Add(lPSOatV13);
                context.PhenologicalStages.Add(lPSOatV14);
                context.PhenologicalStages.Add(lPSOatV15);
                context.PhenologicalStages.Add(lPSOatV16);
                context.PhenologicalStages.Add(lPSOatV17);
                context.PhenologicalStages.Add(lPSOatVt);
                context.PhenologicalStages.Add(lPSOatR1);
                context.PhenologicalStages.Add(lPSOatR2);
                context.PhenologicalStages.Add(lPSOatR3);
                context.PhenologicalStages.Add(lPSOatR4);
                context.PhenologicalStages.Add(lPSOatR5);
                context.PhenologicalStages.Add(lPSOatR6);
                context.PhenologicalStages.Add(lPSOatR7);
                context.PhenologicalStages.Add(lPSOatR8);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesAlfalfaSouthShort_2017()
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

                #region Alfalfa
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieAlfalfaSouthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V0") select stage).FirstOrDefault();
                var lPSAlfalfaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 159.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " VE") select stage).FirstOrDefault();
                var lPSAlfalfaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 160, MaxDegree = 309.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V1") select stage).FirstOrDefault();
                var lPSAlfalfaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 310, MaxDegree = 434.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V2") select stage).FirstOrDefault();
                var lPSAlfalfaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 435, MaxDegree = 569.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V3") select stage).FirstOrDefault();
                var lPSAlfalfaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 570, MaxDegree = 709.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V4") select stage).FirstOrDefault();
                var lPSAlfalfaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 710, MaxDegree = 849.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V5") select stage).FirstOrDefault();
                var lPSAlfalfaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 850, MaxDegree = 989.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V6") select stage).FirstOrDefault();
                var lPSAlfalfaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 990, MaxDegree = 1134.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V7") select stage).FirstOrDefault();
                var lPSAlfalfaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1135, MaxDegree = 1279.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V8") select stage).FirstOrDefault();
                var lPSAlfalfaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1280, MaxDegree = 1419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V9") select stage).FirstOrDefault();
                var lPSAlfalfaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1420, MaxDegree = 1559.999, Coefficient = 0.70, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V10") select stage).FirstOrDefault();
                var lPSAlfalfaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1560, MaxDegree = 1694.999, Coefficient = 0.70, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V11") select stage).FirstOrDefault();
                var lPSAlfalfaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1695, MaxDegree = 1829.999, Coefficient = 0.70, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V12") select stage).FirstOrDefault();
                var lPSAlfalfaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1830, MaxDegree = 1954.999, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V13") select stage).FirstOrDefault();
                var lPSAlfalfaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1955, MaxDegree = 2079.999, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V14") select stage).FirstOrDefault();
                var lPSAlfalfaV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2080, MaxDegree = 2229.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V15") select stage).FirstOrDefault();
                var lPSAlfalfaV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2230, MaxDegree = 2379.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V16") select stage).FirstOrDefault();
                var lPSAlfalfaV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2380, MaxDegree = 2529.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V17") select stage).FirstOrDefault();
                var lPSAlfalfaV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2530, MaxDegree = 2679.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R1") select stage).FirstOrDefault();
                var lPSAlfalfaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2680, MaxDegree = 2799.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R2") select stage).FirstOrDefault();
                var lPSAlfalfaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2800, MaxDegree = 2929.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R3") select stage).FirstOrDefault();
                var lPSAlfalfaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2930, MaxDegree = 3039.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R4") select stage).FirstOrDefault();
                var lPSAlfalfaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3140, MaxDegree = 3299.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R5") select stage).FirstOrDefault();
                var lPSAlfalfaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3300, MaxDegree = 3449.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R6") select stage).FirstOrDefault();
                var lPSAlfalfaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3450, MaxDegree = 4599.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R7") select stage).FirstOrDefault();
                var lPSAlfalfaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 4600, MaxDegree = 5599.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R8") select stage).FirstOrDefault();
                var lPSAlfalfaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 5600, MaxDegree = 6600, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - Alfalfa
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSAlfalfaV0);
                context.PhenologicalStages.Add(lPSAlfalfaVe);
                context.PhenologicalStages.Add(lPSAlfalfaV1);
                context.PhenologicalStages.Add(lPSAlfalfaV2);
                context.PhenologicalStages.Add(lPSAlfalfaV3);
                context.PhenologicalStages.Add(lPSAlfalfaV4);
                context.PhenologicalStages.Add(lPSAlfalfaV5);
                context.PhenologicalStages.Add(lPSAlfalfaV6);
                context.PhenologicalStages.Add(lPSAlfalfaV7);
                context.PhenologicalStages.Add(lPSAlfalfaV8);
                context.PhenologicalStages.Add(lPSAlfalfaV9);
                context.PhenologicalStages.Add(lPSAlfalfaV10);
                context.PhenologicalStages.Add(lPSAlfalfaV11);
                context.PhenologicalStages.Add(lPSAlfalfaV12);
                context.PhenologicalStages.Add(lPSAlfalfaV13);
                context.PhenologicalStages.Add(lPSAlfalfaV14);
                context.PhenologicalStages.Add(lPSAlfalfaV15);
                context.PhenologicalStages.Add(lPSAlfalfaV16);
                context.PhenologicalStages.Add(lPSAlfalfaV17);
                context.PhenologicalStages.Add(lPSAlfalfaR1);
                context.PhenologicalStages.Add(lPSAlfalfaR2);
                context.PhenologicalStages.Add(lPSAlfalfaR3);
                context.PhenologicalStages.Add(lPSAlfalfaR4);
                context.PhenologicalStages.Add(lPSAlfalfaR5);
                context.PhenologicalStages.Add(lPSAlfalfaR6);
                context.PhenologicalStages.Add(lPSAlfalfaR7);
                context.PhenologicalStages.Add(lPSAlfalfaR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesAlfalfaSouthMedium_2017()
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

                #region Alfalfa
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieAlfalfaSouthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V0") select stage).FirstOrDefault();
                var lPSAlfalfaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " VE") select stage).FirstOrDefault();
                var lPSAlfalfaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V1") select stage).FirstOrDefault();
                var lPSAlfalfaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V2") select stage).FirstOrDefault();
                var lPSAlfalfaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V3") select stage).FirstOrDefault();
                var lPSAlfalfaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V4") select stage).FirstOrDefault();
                var lPSAlfalfaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V5") select stage).FirstOrDefault();
                var lPSAlfalfaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V6") select stage).FirstOrDefault();
                var lPSAlfalfaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V7") select stage).FirstOrDefault();
                var lPSAlfalfaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V8") select stage).FirstOrDefault();
                var lPSAlfalfaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V9") select stage).FirstOrDefault();
                var lPSAlfalfaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V10") select stage).FirstOrDefault();
                var lPSAlfalfaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V11") select stage).FirstOrDefault();
                var lPSAlfalfaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V12") select stage).FirstOrDefault();
                var lPSAlfalfaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V13") select stage).FirstOrDefault();
                var lPSAlfalfaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V14") select stage).FirstOrDefault();
                var lPSAlfalfaV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V15") select stage).FirstOrDefault();
                var lPSAlfalfaV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V16") select stage).FirstOrDefault();
                var lPSAlfalfaV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V17") select stage).FirstOrDefault();
                var lPSAlfalfaV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " VT") select stage).FirstOrDefault();
                var lPSAlfalfaVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R1") select stage).FirstOrDefault();
                var lPSAlfalfaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R2") select stage).FirstOrDefault();
                var lPSAlfalfaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R3") select stage).FirstOrDefault();
                var lPSAlfalfaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R4") select stage).FirstOrDefault();
                var lPSAlfalfaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R5") select stage).FirstOrDefault();
                var lPSAlfalfaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R6") select stage).FirstOrDefault();
                var lPSAlfalfaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R7") select stage).FirstOrDefault();
                var lPSAlfalfaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R8") select stage).FirstOrDefault();
                var lPSAlfalfaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - Alfalfa
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSAlfalfaV0);
                context.PhenologicalStages.Add(lPSAlfalfaVe);
                context.PhenologicalStages.Add(lPSAlfalfaV1);
                context.PhenologicalStages.Add(lPSAlfalfaV2);
                context.PhenologicalStages.Add(lPSAlfalfaV3);
                context.PhenologicalStages.Add(lPSAlfalfaV4);
                context.PhenologicalStages.Add(lPSAlfalfaV5);
                context.PhenologicalStages.Add(lPSAlfalfaV6);
                context.PhenologicalStages.Add(lPSAlfalfaV7);
                context.PhenologicalStages.Add(lPSAlfalfaV8);
                context.PhenologicalStages.Add(lPSAlfalfaV9);
                context.PhenologicalStages.Add(lPSAlfalfaV10);
                context.PhenologicalStages.Add(lPSAlfalfaV11);
                context.PhenologicalStages.Add(lPSAlfalfaV12);
                context.PhenologicalStages.Add(lPSAlfalfaV13);
                context.PhenologicalStages.Add(lPSAlfalfaV14);
                context.PhenologicalStages.Add(lPSAlfalfaV15);
                context.PhenologicalStages.Add(lPSAlfalfaV16);
                context.PhenologicalStages.Add(lPSAlfalfaV17);
                context.PhenologicalStages.Add(lPSAlfalfaVt);
                context.PhenologicalStages.Add(lPSAlfalfaR1);
                context.PhenologicalStages.Add(lPSAlfalfaR2);
                context.PhenologicalStages.Add(lPSAlfalfaR3);
                context.PhenologicalStages.Add(lPSAlfalfaR4);
                context.PhenologicalStages.Add(lPSAlfalfaR5);
                context.PhenologicalStages.Add(lPSAlfalfaR6);
                context.PhenologicalStages.Add(lPSAlfalfaR7);
                context.PhenologicalStages.Add(lPSAlfalfaR8);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesAlfalfaNorthShort_2017()
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

                #region Alfalfa
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieAlfalfaNorthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V0") select stage).FirstOrDefault();
                var lPSAlfalfaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " VE") select stage).FirstOrDefault();
                var lPSAlfalfaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V1") select stage).FirstOrDefault();
                var lPSAlfalfaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V2") select stage).FirstOrDefault();
                var lPSAlfalfaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V3") select stage).FirstOrDefault();
                var lPSAlfalfaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V4") select stage).FirstOrDefault();
                var lPSAlfalfaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V5") select stage).FirstOrDefault();
                var lPSAlfalfaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V6") select stage).FirstOrDefault();
                var lPSAlfalfaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V7") select stage).FirstOrDefault();
                var lPSAlfalfaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V8") select stage).FirstOrDefault();
                var lPSAlfalfaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V9") select stage).FirstOrDefault();
                var lPSAlfalfaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V10") select stage).FirstOrDefault();
                var lPSAlfalfaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V11") select stage).FirstOrDefault();
                var lPSAlfalfaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V12") select stage).FirstOrDefault();
                var lPSAlfalfaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V13") select stage).FirstOrDefault();
                var lPSAlfalfaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V14") select stage).FirstOrDefault();
                var lPSAlfalfaV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V15") select stage).FirstOrDefault();
                var lPSAlfalfaV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V16") select stage).FirstOrDefault();
                var lPSAlfalfaV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V17") select stage).FirstOrDefault();
                var lPSAlfalfaV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " VT") select stage).FirstOrDefault();
                var lPSAlfalfaVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R1") select stage).FirstOrDefault();
                var lPSAlfalfaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R2") select stage).FirstOrDefault();
                var lPSAlfalfaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R3") select stage).FirstOrDefault();
                var lPSAlfalfaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R4") select stage).FirstOrDefault();
                var lPSAlfalfaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R5") select stage).FirstOrDefault();
                var lPSAlfalfaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R6") select stage).FirstOrDefault();
                var lPSAlfalfaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R7") select stage).FirstOrDefault();
                var lPSAlfalfaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R8") select stage).FirstOrDefault();
                var lPSAlfalfaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - Alfalfa
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSAlfalfaV0);
                context.PhenologicalStages.Add(lPSAlfalfaVe);
                context.PhenologicalStages.Add(lPSAlfalfaV1);
                context.PhenologicalStages.Add(lPSAlfalfaV2);
                context.PhenologicalStages.Add(lPSAlfalfaV3);
                context.PhenologicalStages.Add(lPSAlfalfaV4);
                context.PhenologicalStages.Add(lPSAlfalfaV5);
                context.PhenologicalStages.Add(lPSAlfalfaV6);
                context.PhenologicalStages.Add(lPSAlfalfaV7);
                context.PhenologicalStages.Add(lPSAlfalfaV8);
                context.PhenologicalStages.Add(lPSAlfalfaV9);
                context.PhenologicalStages.Add(lPSAlfalfaV10);
                context.PhenologicalStages.Add(lPSAlfalfaV11);
                context.PhenologicalStages.Add(lPSAlfalfaV12);
                context.PhenologicalStages.Add(lPSAlfalfaV13);
                context.PhenologicalStages.Add(lPSAlfalfaV14);
                context.PhenologicalStages.Add(lPSAlfalfaV15);
                context.PhenologicalStages.Add(lPSAlfalfaV16);
                context.PhenologicalStages.Add(lPSAlfalfaV17);
                context.PhenologicalStages.Add(lPSAlfalfaVt);
                context.PhenologicalStages.Add(lPSAlfalfaR1);
                context.PhenologicalStages.Add(lPSAlfalfaR2);
                context.PhenologicalStages.Add(lPSAlfalfaR3);
                context.PhenologicalStages.Add(lPSAlfalfaR4);
                context.PhenologicalStages.Add(lPSAlfalfaR5);
                context.PhenologicalStages.Add(lPSAlfalfaR6);
                context.PhenologicalStages.Add(lPSAlfalfaR7);
                context.PhenologicalStages.Add(lPSAlfalfaR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesAlfalfaNorthMedium_2017()
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

                #region Alfalfa
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieAlfalfaNorthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V0") select stage).FirstOrDefault();
                var lPSAlfalfaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " VE") select stage).FirstOrDefault();
                var lPSAlfalfaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V1") select stage).FirstOrDefault();
                var lPSAlfalfaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V2") select stage).FirstOrDefault();
                var lPSAlfalfaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V3") select stage).FirstOrDefault();
                var lPSAlfalfaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V4") select stage).FirstOrDefault();
                var lPSAlfalfaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V5") select stage).FirstOrDefault();
                var lPSAlfalfaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V6") select stage).FirstOrDefault();
                var lPSAlfalfaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V7") select stage).FirstOrDefault();
                var lPSAlfalfaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V8") select stage).FirstOrDefault();
                var lPSAlfalfaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V9") select stage).FirstOrDefault();
                var lPSAlfalfaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V10") select stage).FirstOrDefault();
                var lPSAlfalfaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V11") select stage).FirstOrDefault();
                var lPSAlfalfaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V12") select stage).FirstOrDefault();
                var lPSAlfalfaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V13") select stage).FirstOrDefault();
                var lPSAlfalfaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V14") select stage).FirstOrDefault();
                var lPSAlfalfaV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V15") select stage).FirstOrDefault();
                var lPSAlfalfaV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V16") select stage).FirstOrDefault();
                var lPSAlfalfaV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V17") select stage).FirstOrDefault();
                var lPSAlfalfaV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " VT") select stage).FirstOrDefault();
                var lPSAlfalfaVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R1") select stage).FirstOrDefault();
                var lPSAlfalfaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R2") select stage).FirstOrDefault();
                var lPSAlfalfaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R3") select stage).FirstOrDefault();
                var lPSAlfalfaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R4") select stage).FirstOrDefault();
                var lPSAlfalfaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R5") select stage).FirstOrDefault();
                var lPSAlfalfaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R6") select stage).FirstOrDefault();
                var lPSAlfalfaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R7") select stage).FirstOrDefault();
                var lPSAlfalfaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R8") select stage).FirstOrDefault();
                var lPSAlfalfaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - Alfalfa
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSAlfalfaV0);
                context.PhenologicalStages.Add(lPSAlfalfaVe);
                context.PhenologicalStages.Add(lPSAlfalfaV1);
                context.PhenologicalStages.Add(lPSAlfalfaV2);
                context.PhenologicalStages.Add(lPSAlfalfaV3);
                context.PhenologicalStages.Add(lPSAlfalfaV4);
                context.PhenologicalStages.Add(lPSAlfalfaV5);
                context.PhenologicalStages.Add(lPSAlfalfaV6);
                context.PhenologicalStages.Add(lPSAlfalfaV7);
                context.PhenologicalStages.Add(lPSAlfalfaV8);
                context.PhenologicalStages.Add(lPSAlfalfaV9);
                context.PhenologicalStages.Add(lPSAlfalfaV10);
                context.PhenologicalStages.Add(lPSAlfalfaV11);
                context.PhenologicalStages.Add(lPSAlfalfaV12);
                context.PhenologicalStages.Add(lPSAlfalfaV13);
                context.PhenologicalStages.Add(lPSAlfalfaV14);
                context.PhenologicalStages.Add(lPSAlfalfaV15);
                context.PhenologicalStages.Add(lPSAlfalfaV16);
                context.PhenologicalStages.Add(lPSAlfalfaV17);
                context.PhenologicalStages.Add(lPSAlfalfaVt);
                context.PhenologicalStages.Add(lPSAlfalfaR1);
                context.PhenologicalStages.Add(lPSAlfalfaR2);
                context.PhenologicalStages.Add(lPSAlfalfaR3);
                context.PhenologicalStages.Add(lPSAlfalfaR4);
                context.PhenologicalStages.Add(lPSAlfalfaR5);
                context.PhenologicalStages.Add(lPSAlfalfaR6);
                context.PhenologicalStages.Add(lPSAlfalfaR7);
                context.PhenologicalStages.Add(lPSAlfalfaR8);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesSudanGrassSouthShort_2017()
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

                #region SudanGrass
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieSudanGrassSouthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V0") select stage).FirstOrDefault();
                var lPSSudanGrassV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " VE") select stage).FirstOrDefault();
                var lPSSudanGrassVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V1") select stage).FirstOrDefault();
                var lPSSudanGrassV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V2") select stage).FirstOrDefault();
                var lPSSudanGrassV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V3") select stage).FirstOrDefault();
                var lPSSudanGrassV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V4") select stage).FirstOrDefault();
                var lPSSudanGrassV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V5") select stage).FirstOrDefault();
                var lPSSudanGrassV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V6") select stage).FirstOrDefault();
                var lPSSudanGrassV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V7") select stage).FirstOrDefault();
                var lPSSudanGrassV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V8") select stage).FirstOrDefault();
                var lPSSudanGrassV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V9") select stage).FirstOrDefault();
                var lPSSudanGrassV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V10") select stage).FirstOrDefault();
                var lPSSudanGrassV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V11") select stage).FirstOrDefault();
                var lPSSudanGrassV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V12") select stage).FirstOrDefault();
                var lPSSudanGrassV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V13") select stage).FirstOrDefault();
                var lPSSudanGrassV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V14") select stage).FirstOrDefault();
                var lPSSudanGrassV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V15") select stage).FirstOrDefault();
                var lPSSudanGrassV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V16") select stage).FirstOrDefault();
                var lPSSudanGrassV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V17") select stage).FirstOrDefault();
                var lPSSudanGrassV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " VT") select stage).FirstOrDefault();
                var lPSSudanGrassVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R1") select stage).FirstOrDefault();
                var lPSSudanGrassR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R2") select stage).FirstOrDefault();
                var lPSSudanGrassR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R3") select stage).FirstOrDefault();
                var lPSSudanGrassR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R4") select stage).FirstOrDefault();
                var lPSSudanGrassR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R5") select stage).FirstOrDefault();
                var lPSSudanGrassR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R6") select stage).FirstOrDefault();
                var lPSSudanGrassR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R7") select stage).FirstOrDefault();
                var lPSSudanGrassR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R8") select stage).FirstOrDefault();
                var lPSSudanGrassR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - SudanGrass
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSSudanGrassV0);
                context.PhenologicalStages.Add(lPSSudanGrassVe);
                context.PhenologicalStages.Add(lPSSudanGrassV1);
                context.PhenologicalStages.Add(lPSSudanGrassV2);
                context.PhenologicalStages.Add(lPSSudanGrassV3);
                context.PhenologicalStages.Add(lPSSudanGrassV4);
                context.PhenologicalStages.Add(lPSSudanGrassV5);
                context.PhenologicalStages.Add(lPSSudanGrassV6);
                context.PhenologicalStages.Add(lPSSudanGrassV7);
                context.PhenologicalStages.Add(lPSSudanGrassV8);
                context.PhenologicalStages.Add(lPSSudanGrassV9);
                context.PhenologicalStages.Add(lPSSudanGrassV10);
                context.PhenologicalStages.Add(lPSSudanGrassV11);
                context.PhenologicalStages.Add(lPSSudanGrassV12);
                context.PhenologicalStages.Add(lPSSudanGrassV13);
                context.PhenologicalStages.Add(lPSSudanGrassV14);
                context.PhenologicalStages.Add(lPSSudanGrassV15);
                context.PhenologicalStages.Add(lPSSudanGrassV16);
                context.PhenologicalStages.Add(lPSSudanGrassV17);
                context.PhenologicalStages.Add(lPSSudanGrassVt);
                context.PhenologicalStages.Add(lPSSudanGrassR1);
                context.PhenologicalStages.Add(lPSSudanGrassR2);
                context.PhenologicalStages.Add(lPSSudanGrassR3);
                context.PhenologicalStages.Add(lPSSudanGrassR4);
                context.PhenologicalStages.Add(lPSSudanGrassR5);
                context.PhenologicalStages.Add(lPSSudanGrassR6);
                context.PhenologicalStages.Add(lPSSudanGrassR7);
                context.PhenologicalStages.Add(lPSSudanGrassR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesSudanGrassSouthMedium_2017()
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

                #region SudanGrass
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieSudanGrassSouthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V0") select stage).FirstOrDefault();
                var lPSSudanGrassV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " VE") select stage).FirstOrDefault();
                var lPSSudanGrassVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V1") select stage).FirstOrDefault();
                var lPSSudanGrassV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V2") select stage).FirstOrDefault();
                var lPSSudanGrassV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V3") select stage).FirstOrDefault();
                var lPSSudanGrassV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V4") select stage).FirstOrDefault();
                var lPSSudanGrassV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V5") select stage).FirstOrDefault();
                var lPSSudanGrassV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V6") select stage).FirstOrDefault();
                var lPSSudanGrassV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V7") select stage).FirstOrDefault();
                var lPSSudanGrassV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V8") select stage).FirstOrDefault();
                var lPSSudanGrassV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V9") select stage).FirstOrDefault();
                var lPSSudanGrassV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V10") select stage).FirstOrDefault();
                var lPSSudanGrassV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V11") select stage).FirstOrDefault();
                var lPSSudanGrassV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V12") select stage).FirstOrDefault();
                var lPSSudanGrassV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V13") select stage).FirstOrDefault();
                var lPSSudanGrassV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V14") select stage).FirstOrDefault();
                var lPSSudanGrassV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V15") select stage).FirstOrDefault();
                var lPSSudanGrassV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V16") select stage).FirstOrDefault();
                var lPSSudanGrassV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V17") select stage).FirstOrDefault();
                var lPSSudanGrassV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " VT") select stage).FirstOrDefault();
                var lPSSudanGrassVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R1") select stage).FirstOrDefault();
                var lPSSudanGrassR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R2") select stage).FirstOrDefault();
                var lPSSudanGrassR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R3") select stage).FirstOrDefault();
                var lPSSudanGrassR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R4") select stage).FirstOrDefault();
                var lPSSudanGrassR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R5") select stage).FirstOrDefault();
                var lPSSudanGrassR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R6") select stage).FirstOrDefault();
                var lPSSudanGrassR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R7") select stage).FirstOrDefault();
                var lPSSudanGrassR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R8") select stage).FirstOrDefault();
                var lPSSudanGrassR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - SudanGrass
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSSudanGrassV0);
                context.PhenologicalStages.Add(lPSSudanGrassVe);
                context.PhenologicalStages.Add(lPSSudanGrassV1);
                context.PhenologicalStages.Add(lPSSudanGrassV2);
                context.PhenologicalStages.Add(lPSSudanGrassV3);
                context.PhenologicalStages.Add(lPSSudanGrassV4);
                context.PhenologicalStages.Add(lPSSudanGrassV5);
                context.PhenologicalStages.Add(lPSSudanGrassV6);
                context.PhenologicalStages.Add(lPSSudanGrassV7);
                context.PhenologicalStages.Add(lPSSudanGrassV8);
                context.PhenologicalStages.Add(lPSSudanGrassV9);
                context.PhenologicalStages.Add(lPSSudanGrassV10);
                context.PhenologicalStages.Add(lPSSudanGrassV11);
                context.PhenologicalStages.Add(lPSSudanGrassV12);
                context.PhenologicalStages.Add(lPSSudanGrassV13);
                context.PhenologicalStages.Add(lPSSudanGrassV14);
                context.PhenologicalStages.Add(lPSSudanGrassV15);
                context.PhenologicalStages.Add(lPSSudanGrassV16);
                context.PhenologicalStages.Add(lPSSudanGrassV17);
                context.PhenologicalStages.Add(lPSSudanGrassVt);
                context.PhenologicalStages.Add(lPSSudanGrassR1);
                context.PhenologicalStages.Add(lPSSudanGrassR2);
                context.PhenologicalStages.Add(lPSSudanGrassR3);
                context.PhenologicalStages.Add(lPSSudanGrassR4);
                context.PhenologicalStages.Add(lPSSudanGrassR5);
                context.PhenologicalStages.Add(lPSSudanGrassR6);
                context.PhenologicalStages.Add(lPSSudanGrassR7);
                context.PhenologicalStages.Add(lPSSudanGrassR8);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesSudanGrassNorthShort_2017()
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

                #region SudanGrass
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieSudanGrassNorthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V0") select stage).FirstOrDefault();
                var lPSSudanGrassV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " VE") select stage).FirstOrDefault();
                var lPSSudanGrassVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V1") select stage).FirstOrDefault();
                var lPSSudanGrassV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V2") select stage).FirstOrDefault();
                var lPSSudanGrassV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V3") select stage).FirstOrDefault();
                var lPSSudanGrassV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V4") select stage).FirstOrDefault();
                var lPSSudanGrassV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V5") select stage).FirstOrDefault();
                var lPSSudanGrassV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V6") select stage).FirstOrDefault();
                var lPSSudanGrassV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V7") select stage).FirstOrDefault();
                var lPSSudanGrassV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V8") select stage).FirstOrDefault();
                var lPSSudanGrassV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V9") select stage).FirstOrDefault();
                var lPSSudanGrassV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V10") select stage).FirstOrDefault();
                var lPSSudanGrassV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V11") select stage).FirstOrDefault();
                var lPSSudanGrassV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V12") select stage).FirstOrDefault();
                var lPSSudanGrassV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V13") select stage).FirstOrDefault();
                var lPSSudanGrassV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V14") select stage).FirstOrDefault();
                var lPSSudanGrassV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V15") select stage).FirstOrDefault();
                var lPSSudanGrassV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V16") select stage).FirstOrDefault();
                var lPSSudanGrassV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V17") select stage).FirstOrDefault();
                var lPSSudanGrassV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " VT") select stage).FirstOrDefault();
                var lPSSudanGrassVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R1") select stage).FirstOrDefault();
                var lPSSudanGrassR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R2") select stage).FirstOrDefault();
                var lPSSudanGrassR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R3") select stage).FirstOrDefault();
                var lPSSudanGrassR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R4") select stage).FirstOrDefault();
                var lPSSudanGrassR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R5") select stage).FirstOrDefault();
                var lPSSudanGrassR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R6") select stage).FirstOrDefault();
                var lPSSudanGrassR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R7") select stage).FirstOrDefault();
                var lPSSudanGrassR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R8") select stage).FirstOrDefault();
                var lPSSudanGrassR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - SudanGrass
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSSudanGrassV0);
                context.PhenologicalStages.Add(lPSSudanGrassVe);
                context.PhenologicalStages.Add(lPSSudanGrassV1);
                context.PhenologicalStages.Add(lPSSudanGrassV2);
                context.PhenologicalStages.Add(lPSSudanGrassV3);
                context.PhenologicalStages.Add(lPSSudanGrassV4);
                context.PhenologicalStages.Add(lPSSudanGrassV5);
                context.PhenologicalStages.Add(lPSSudanGrassV6);
                context.PhenologicalStages.Add(lPSSudanGrassV7);
                context.PhenologicalStages.Add(lPSSudanGrassV8);
                context.PhenologicalStages.Add(lPSSudanGrassV9);
                context.PhenologicalStages.Add(lPSSudanGrassV10);
                context.PhenologicalStages.Add(lPSSudanGrassV11);
                context.PhenologicalStages.Add(lPSSudanGrassV12);
                context.PhenologicalStages.Add(lPSSudanGrassV13);
                context.PhenologicalStages.Add(lPSSudanGrassV14);
                context.PhenologicalStages.Add(lPSSudanGrassV15);
                context.PhenologicalStages.Add(lPSSudanGrassV16);
                context.PhenologicalStages.Add(lPSSudanGrassV17);
                context.PhenologicalStages.Add(lPSSudanGrassVt);
                context.PhenologicalStages.Add(lPSSudanGrassR1);
                context.PhenologicalStages.Add(lPSSudanGrassR2);
                context.PhenologicalStages.Add(lPSSudanGrassR3);
                context.PhenologicalStages.Add(lPSSudanGrassR4);
                context.PhenologicalStages.Add(lPSSudanGrassR5);
                context.PhenologicalStages.Add(lPSSudanGrassR6);
                context.PhenologicalStages.Add(lPSSudanGrassR7);
                context.PhenologicalStages.Add(lPSSudanGrassR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesSudanGrassNorthMedium_2017()
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

                #region SudanGrass
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieSudanGrassNorthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V0") select stage).FirstOrDefault();
                var lPSSudanGrassV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " VE") select stage).FirstOrDefault();
                var lPSSudanGrassVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V1") select stage).FirstOrDefault();
                var lPSSudanGrassV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V2") select stage).FirstOrDefault();
                var lPSSudanGrassV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V3") select stage).FirstOrDefault();
                var lPSSudanGrassV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V4") select stage).FirstOrDefault();
                var lPSSudanGrassV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V5") select stage).FirstOrDefault();
                var lPSSudanGrassV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V6") select stage).FirstOrDefault();
                var lPSSudanGrassV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V7") select stage).FirstOrDefault();
                var lPSSudanGrassV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V8") select stage).FirstOrDefault();
                var lPSSudanGrassV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V9") select stage).FirstOrDefault();
                var lPSSudanGrassV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V10") select stage).FirstOrDefault();
                var lPSSudanGrassV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V11") select stage).FirstOrDefault();
                var lPSSudanGrassV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V12") select stage).FirstOrDefault();
                var lPSSudanGrassV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V13") select stage).FirstOrDefault();
                var lPSSudanGrassV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V14") select stage).FirstOrDefault();
                var lPSSudanGrassV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V15") select stage).FirstOrDefault();
                var lPSSudanGrassV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V16") select stage).FirstOrDefault();
                var lPSSudanGrassV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V17") select stage).FirstOrDefault();
                var lPSSudanGrassV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " VT") select stage).FirstOrDefault();
                var lPSSudanGrassVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R1") select stage).FirstOrDefault();
                var lPSSudanGrassR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R2") select stage).FirstOrDefault();
                var lPSSudanGrassR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R3") select stage).FirstOrDefault();
                var lPSSudanGrassR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R4") select stage).FirstOrDefault();
                var lPSSudanGrassR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R5") select stage).FirstOrDefault();
                var lPSSudanGrassR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R6") select stage).FirstOrDefault();
                var lPSSudanGrassR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R7") select stage).FirstOrDefault();
                var lPSSudanGrassR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R8") select stage).FirstOrDefault();
                var lPSSudanGrassR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - SudanGrass
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSSudanGrassV0);
                context.PhenologicalStages.Add(lPSSudanGrassVe);
                context.PhenologicalStages.Add(lPSSudanGrassV1);
                context.PhenologicalStages.Add(lPSSudanGrassV2);
                context.PhenologicalStages.Add(lPSSudanGrassV3);
                context.PhenologicalStages.Add(lPSSudanGrassV4);
                context.PhenologicalStages.Add(lPSSudanGrassV5);
                context.PhenologicalStages.Add(lPSSudanGrassV6);
                context.PhenologicalStages.Add(lPSSudanGrassV7);
                context.PhenologicalStages.Add(lPSSudanGrassV8);
                context.PhenologicalStages.Add(lPSSudanGrassV9);
                context.PhenologicalStages.Add(lPSSudanGrassV10);
                context.PhenologicalStages.Add(lPSSudanGrassV11);
                context.PhenologicalStages.Add(lPSSudanGrassV12);
                context.PhenologicalStages.Add(lPSSudanGrassV13);
                context.PhenologicalStages.Add(lPSSudanGrassV14);
                context.PhenologicalStages.Add(lPSSudanGrassV15);
                context.PhenologicalStages.Add(lPSSudanGrassV16);
                context.PhenologicalStages.Add(lPSSudanGrassV17);
                context.PhenologicalStages.Add(lPSSudanGrassVt);
                context.PhenologicalStages.Add(lPSSudanGrassR1);
                context.PhenologicalStages.Add(lPSSudanGrassR2);
                context.PhenologicalStages.Add(lPSSudanGrassR3);
                context.PhenologicalStages.Add(lPSSudanGrassR4);
                context.PhenologicalStages.Add(lPSSudanGrassR5);
                context.PhenologicalStages.Add(lPSSudanGrassR6);
                context.PhenologicalStages.Add(lPSSudanGrassR7);
                context.PhenologicalStages.Add(lPSSudanGrassR8);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesFescueForageSouthShort_2017()
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

                #region FescueForage
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieFescueForageSouthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V0") select stage).FirstOrDefault();
                var lPSFescueForageV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 159.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " VE") select stage).FirstOrDefault();
                var lPSFescueForageVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 160, MaxDegree = 309.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V1") select stage).FirstOrDefault();
                var lPSFescueForageV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 310, MaxDegree = 434.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V2") select stage).FirstOrDefault();
                var lPSFescueForageV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 435, MaxDegree = 569.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V3") select stage).FirstOrDefault();
                var lPSFescueForageV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 570, MaxDegree = 709.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V4") select stage).FirstOrDefault();
                var lPSFescueForageV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 710, MaxDegree = 849.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V5") select stage).FirstOrDefault();
                var lPSFescueForageV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 850, MaxDegree = 989.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V6") select stage).FirstOrDefault();
                var lPSFescueForageV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 990, MaxDegree = 1134.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V7") select stage).FirstOrDefault();
                var lPSFescueForageV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1135, MaxDegree = 1279.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V8") select stage).FirstOrDefault();
                var lPSFescueForageV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1280, MaxDegree = 1419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V9") select stage).FirstOrDefault();
                var lPSFescueForageV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1420, MaxDegree = 1559.999, Coefficient = 0.70, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V10") select stage).FirstOrDefault();
                var lPSFescueForageV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1560, MaxDegree = 1694.999, Coefficient = 0.70, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V11") select stage).FirstOrDefault();
                var lPSFescueForageV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1695, MaxDegree = 1829.999, Coefficient = 0.70, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V12") select stage).FirstOrDefault();
                var lPSFescueForageV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1830, MaxDegree = 1954.999, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V13") select stage).FirstOrDefault();
                var lPSFescueForageV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1955, MaxDegree = 2079.999, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V14") select stage).FirstOrDefault();
                var lPSFescueForageV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2080, MaxDegree = 2229.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V15") select stage).FirstOrDefault();
                var lPSFescueForageV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2230, MaxDegree = 2379.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V16") select stage).FirstOrDefault();
                var lPSFescueForageV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2380, MaxDegree = 2529.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V17") select stage).FirstOrDefault();
                var lPSFescueForageV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2530, MaxDegree = 2679.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R1") select stage).FirstOrDefault();
                var lPSFescueForageR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2680, MaxDegree = 2799.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R2") select stage).FirstOrDefault();
                var lPSFescueForageR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2800, MaxDegree = 2929.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R3") select stage).FirstOrDefault();
                var lPSFescueForageR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2930, MaxDegree = 3039.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R4") select stage).FirstOrDefault();
                var lPSFescueForageR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3140, MaxDegree = 3299.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R5") select stage).FirstOrDefault();
                var lPSFescueForageR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3300, MaxDegree = 3449.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R6") select stage).FirstOrDefault();
                var lPSFescueForageR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3450, MaxDegree = 4599.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R7") select stage).FirstOrDefault();
                var lPSFescueForageR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 4600, MaxDegree = 5599.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R8") select stage).FirstOrDefault();
                var lPSFescueForageR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 5600, MaxDegree = 6600, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - FescueForage
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSFescueForageV0);
                context.PhenologicalStages.Add(lPSFescueForageVe);
                context.PhenologicalStages.Add(lPSFescueForageV1);
                context.PhenologicalStages.Add(lPSFescueForageV2);
                context.PhenologicalStages.Add(lPSFescueForageV3);
                context.PhenologicalStages.Add(lPSFescueForageV4);
                context.PhenologicalStages.Add(lPSFescueForageV5);
                context.PhenologicalStages.Add(lPSFescueForageV6);
                context.PhenologicalStages.Add(lPSFescueForageV7);
                context.PhenologicalStages.Add(lPSFescueForageV8);
                context.PhenologicalStages.Add(lPSFescueForageV9);
                context.PhenologicalStages.Add(lPSFescueForageV10);
                context.PhenologicalStages.Add(lPSFescueForageV11);
                context.PhenologicalStages.Add(lPSFescueForageV12);
                context.PhenologicalStages.Add(lPSFescueForageV13);
                context.PhenologicalStages.Add(lPSFescueForageV14);
                context.PhenologicalStages.Add(lPSFescueForageV15);
                context.PhenologicalStages.Add(lPSFescueForageV16);
                context.PhenologicalStages.Add(lPSFescueForageV17);
                context.PhenologicalStages.Add(lPSFescueForageR1);
                context.PhenologicalStages.Add(lPSFescueForageR2);
                context.PhenologicalStages.Add(lPSFescueForageR3);
                context.PhenologicalStages.Add(lPSFescueForageR4);
                context.PhenologicalStages.Add(lPSFescueForageR5);
                context.PhenologicalStages.Add(lPSFescueForageR6);
                context.PhenologicalStages.Add(lPSFescueForageR7);
                context.PhenologicalStages.Add(lPSFescueForageR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesFescueForageSouthMedium_2017()
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

                #region FescueForage
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieFescueForageSouthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V0") select stage).FirstOrDefault();
                var lPSFescueForageV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " VE") select stage).FirstOrDefault();
                var lPSFescueForageVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V1") select stage).FirstOrDefault();
                var lPSFescueForageV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V2") select stage).FirstOrDefault();
                var lPSFescueForageV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V3") select stage).FirstOrDefault();
                var lPSFescueForageV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V4") select stage).FirstOrDefault();
                var lPSFescueForageV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V5") select stage).FirstOrDefault();
                var lPSFescueForageV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V6") select stage).FirstOrDefault();
                var lPSFescueForageV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V7") select stage).FirstOrDefault();
                var lPSFescueForageV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V8") select stage).FirstOrDefault();
                var lPSFescueForageV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V9") select stage).FirstOrDefault();
                var lPSFescueForageV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V10") select stage).FirstOrDefault();
                var lPSFescueForageV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V11") select stage).FirstOrDefault();
                var lPSFescueForageV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R1") select stage).FirstOrDefault();
                var lPSFescueForageR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R2") select stage).FirstOrDefault();
                var lPSFescueForageR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R3") select stage).FirstOrDefault();
                var lPSFescueForageR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R4") select stage).FirstOrDefault();
                var lPSFescueForageR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R5") select stage).FirstOrDefault();
                var lPSFescueForageR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R6") select stage).FirstOrDefault();
                var lPSFescueForageR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R7") select stage).FirstOrDefault();
                var lPSFescueForageR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R8") select stage).FirstOrDefault();
                var lPSFescueForageR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - FescueForage
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSFescueForageV0);
                context.PhenologicalStages.Add(lPSFescueForageVe);
                context.PhenologicalStages.Add(lPSFescueForageV1);
                context.PhenologicalStages.Add(lPSFescueForageV2);
                context.PhenologicalStages.Add(lPSFescueForageV3);
                context.PhenologicalStages.Add(lPSFescueForageV4);
                context.PhenologicalStages.Add(lPSFescueForageV5);
                context.PhenologicalStages.Add(lPSFescueForageV6);
                context.PhenologicalStages.Add(lPSFescueForageV7);
                context.PhenologicalStages.Add(lPSFescueForageV8);
                context.PhenologicalStages.Add(lPSFescueForageV9);
                context.PhenologicalStages.Add(lPSFescueForageV10);
                context.PhenologicalStages.Add(lPSFescueForageV11);
                context.PhenologicalStages.Add(lPSFescueForageR1);
                context.PhenologicalStages.Add(lPSFescueForageR2);
                context.PhenologicalStages.Add(lPSFescueForageR3);
                context.PhenologicalStages.Add(lPSFescueForageR4);
                context.PhenologicalStages.Add(lPSFescueForageR5);
                context.PhenologicalStages.Add(lPSFescueForageR6);
                context.PhenologicalStages.Add(lPSFescueForageR7);
                context.PhenologicalStages.Add(lPSFescueForageR8);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesFescueForageNorthShort_2017()
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

                #region FescueForage
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieFescueForageNorthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V0") select stage).FirstOrDefault();
                var lPSFescueForageV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 159.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " VE") select stage).FirstOrDefault();
                var lPSFescueForageVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 160, MaxDegree = 309.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V1") select stage).FirstOrDefault();
                var lPSFescueForageV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 310, MaxDegree = 434.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V2") select stage).FirstOrDefault();
                var lPSFescueForageV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 435, MaxDegree = 569.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V3") select stage).FirstOrDefault();
                var lPSFescueForageV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 570, MaxDegree = 709.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V4") select stage).FirstOrDefault();
                var lPSFescueForageV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 710, MaxDegree = 849.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V5") select stage).FirstOrDefault();
                var lPSFescueForageV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 850, MaxDegree = 989.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V6") select stage).FirstOrDefault();
                var lPSFescueForageV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 990, MaxDegree = 1134.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V7") select stage).FirstOrDefault();
                var lPSFescueForageV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1135, MaxDegree = 1279.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V8") select stage).FirstOrDefault();
                var lPSFescueForageV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1280, MaxDegree = 1419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V9") select stage).FirstOrDefault();
                var lPSFescueForageV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1420, MaxDegree = 1559.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V10") select stage).FirstOrDefault();
                var lPSFescueForageV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1560, MaxDegree = 1694.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V11") select stage).FirstOrDefault();
                var lPSFescueForageV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1695, MaxDegree = 1729.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R1") select stage).FirstOrDefault();
                var lPSFescueForageR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1780, MaxDegree = 1999.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R2") select stage).FirstOrDefault();
                var lPSFescueForageR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1900, MaxDegree = 2029.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R3") select stage).FirstOrDefault();
                var lPSFescueForageR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2030, MaxDegree = 2139.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R4") select stage).FirstOrDefault();
                var lPSFescueForageR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2140, MaxDegree = 2299.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R5") select stage).FirstOrDefault();
                var lPSFescueForageR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2300, MaxDegree = 2449.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R6") select stage).FirstOrDefault();
                var lPSFescueForageR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2450, MaxDegree = 2599.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R7") select stage).FirstOrDefault();
                var lPSFescueForageR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2600, MaxDegree = 3599.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R8") select stage).FirstOrDefault();
                var lPSFescueForageR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3600, MaxDegree = 4600, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - FescueForage
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSFescueForageV0);
                context.PhenologicalStages.Add(lPSFescueForageVe);
                context.PhenologicalStages.Add(lPSFescueForageV1);
                context.PhenologicalStages.Add(lPSFescueForageV2);
                context.PhenologicalStages.Add(lPSFescueForageV3);
                context.PhenologicalStages.Add(lPSFescueForageV4);
                context.PhenologicalStages.Add(lPSFescueForageV5);
                context.PhenologicalStages.Add(lPSFescueForageV6);
                context.PhenologicalStages.Add(lPSFescueForageV7);
                context.PhenologicalStages.Add(lPSFescueForageV8);
                context.PhenologicalStages.Add(lPSFescueForageV9);
                context.PhenologicalStages.Add(lPSFescueForageV10);
                context.PhenologicalStages.Add(lPSFescueForageV11);
                context.PhenologicalStages.Add(lPSFescueForageR1);
                context.PhenologicalStages.Add(lPSFescueForageR2);
                context.PhenologicalStages.Add(lPSFescueForageR3);
                context.PhenologicalStages.Add(lPSFescueForageR4);
                context.PhenologicalStages.Add(lPSFescueForageR5);
                context.PhenologicalStages.Add(lPSFescueForageR6);
                context.PhenologicalStages.Add(lPSFescueForageR7);
                context.PhenologicalStages.Add(lPSFescueForageR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesFescueForageNorthMedium_2017()
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

                #region FescueForage
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieFescueForageNorthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V0") select stage).FirstOrDefault();
                var lPSFescueForageV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " VE") select stage).FirstOrDefault();
                var lPSFescueForageVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V1") select stage).FirstOrDefault();
                var lPSFescueForageV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V2") select stage).FirstOrDefault();
                var lPSFescueForageV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V3") select stage).FirstOrDefault();
                var lPSFescueForageV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V4") select stage).FirstOrDefault();
                var lPSFescueForageV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V5") select stage).FirstOrDefault();
                var lPSFescueForageV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V6") select stage).FirstOrDefault();
                var lPSFescueForageV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V7") select stage).FirstOrDefault();
                var lPSFescueForageV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V8") select stage).FirstOrDefault();
                var lPSFescueForageV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V9") select stage).FirstOrDefault();
                var lPSFescueForageV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V10") select stage).FirstOrDefault();
                var lPSFescueForageV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V11") select stage).FirstOrDefault();
                var lPSFescueForageV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R1") select stage).FirstOrDefault();
                var lPSFescueForageR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R2") select stage).FirstOrDefault();
                var lPSFescueForageR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R3") select stage).FirstOrDefault();
                var lPSFescueForageR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R4") select stage).FirstOrDefault();
                var lPSFescueForageR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R5") select stage).FirstOrDefault();
                var lPSFescueForageR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R6") select stage).FirstOrDefault();
                var lPSFescueForageR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R7") select stage).FirstOrDefault();
                var lPSFescueForageR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R8") select stage).FirstOrDefault();
                var lPSFescueForageR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - FescueForage
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSFescueForageV0);
                context.PhenologicalStages.Add(lPSFescueForageVe);
                context.PhenologicalStages.Add(lPSFescueForageV1);
                context.PhenologicalStages.Add(lPSFescueForageV2);
                context.PhenologicalStages.Add(lPSFescueForageV3);
                context.PhenologicalStages.Add(lPSFescueForageV4);
                context.PhenologicalStages.Add(lPSFescueForageV5);
                context.PhenologicalStages.Add(lPSFescueForageV6);
                context.PhenologicalStages.Add(lPSFescueForageV7);
                context.PhenologicalStages.Add(lPSFescueForageV8);
                context.PhenologicalStages.Add(lPSFescueForageV9);
                context.PhenologicalStages.Add(lPSFescueForageV10);
                context.PhenologicalStages.Add(lPSFescueForageV11);
                context.PhenologicalStages.Add(lPSFescueForageR1);
                context.PhenologicalStages.Add(lPSFescueForageR2);
                context.PhenologicalStages.Add(lPSFescueForageR3);
                context.PhenologicalStages.Add(lPSFescueForageR4);
                context.PhenologicalStages.Add(lPSFescueForageR5);
                context.PhenologicalStages.Add(lPSFescueForageR6);
                context.PhenologicalStages.Add(lPSFescueForageR7);
                context.PhenologicalStages.Add(lPSFescueForageR8);
                context.SaveChanges();
                #endregion
            };
        }

        #endregion
        #region 2018
        //AX 7918
        public static void InsertPhenologicalStagesCornSouthShort_2018()
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

                #region Corn South Short
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieCornSouthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V0") select stage).FirstOrDefault();
                var lPSCornV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VE") select stage).FirstOrDefault();
                var lPSCornVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 114.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V1") select stage).FirstOrDefault();
                var lPSCornV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 20 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V2") select stage).FirstOrDefault();
                var lPSCornV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 179.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V3") select stage).FirstOrDefault();
                var lPSCornV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 180, MaxDegree = 229.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V4") select stage).FirstOrDefault();
                var lPSCornV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 230, MaxDegree = 289.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V5") select stage).FirstOrDefault();
                var lPSCornV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 349.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V6") select stage).FirstOrDefault();
                var lPSCornV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 350, MaxDegree = 404.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V7") select stage).FirstOrDefault();
                var lPSCornV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 405, MaxDegree = 459.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V8") select stage).FirstOrDefault();
                var lPSCornV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 519.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V9") select stage).FirstOrDefault();
                var lPSCornV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 520, MaxDegree = 589.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 70 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V10") select stage).FirstOrDefault();
                var lPSCornV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 590, MaxDegree = 649.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V11") select stage).FirstOrDefault();
                var lPSCornV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 650, MaxDegree = 689.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V12") select stage).FirstOrDefault();
                var lPSCornV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 690, MaxDegree = 714.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V13") select stage).FirstOrDefault();
                var lPSCornV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 715, MaxDegree = 749.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V14") select stage).FirstOrDefault();
                var lPSCornV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 750, MaxDegree = 784.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V15") select stage).FirstOrDefault();
                var lPSCornV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 785, MaxDegree = 914.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V16") select stage).FirstOrDefault();
                var lPSCornV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 50 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V17") select stage).FirstOrDefault();
                var lPSCornV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VT") select stage).FirstOrDefault();
                var lPSCornVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 915, MaxDegree = 1059.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R1") select stage).FirstOrDefault();
                var lPSCornR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1060, MaxDegree = 1119.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R2") select stage).FirstOrDefault();
                var lPSCornR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1220, MaxDegree = 1359.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R3") select stage).FirstOrDefault();
                var lPSCornR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1360, MaxDegree = 1499.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R4") select stage).FirstOrDefault();
                var lPSCornR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 1599.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R5") select stage).FirstOrDefault();
                var lPSCornR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1600, MaxDegree = 1899.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 300 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R6") select stage).FirstOrDefault();
                var lPSCornR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1900, MaxDegree = 2499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 600 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R7") select stage).FirstOrDefault();
                var lPSCornR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3999.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1500 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R8") select stage).FirstOrDefault();
                var lPSCornR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 4000, MaxDegree = 6500, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 2500 };

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
                context.PhenologicalStages.Add(lPSCornV16);
                context.PhenologicalStages.Add(lPSCornV17);
                context.PhenologicalStages.Add(lPSCornVt);
                context.PhenologicalStages.Add(lPSCornR1);
                context.PhenologicalStages.Add(lPSCornR2);
                context.PhenologicalStages.Add(lPSCornR3);
                context.PhenologicalStages.Add(lPSCornR4);
                context.PhenologicalStages.Add(lPSCornR5);
                context.PhenologicalStages.Add(lPSCornR6);
                context.PhenologicalStages.Add(lPSCornR7);
                context.PhenologicalStages.Add(lPSCornR8);
                context.SaveChanges();
                #endregion
            };
        }
        //AX 7822
        public static void InsertPhenologicalStagesCornSouthMedium_2018()
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

                #region Corn Medium Short
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieCornSouthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V0") select stage).FirstOrDefault();
                var lPSCornV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VE") select stage).FirstOrDefault();
                var lPSCornVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 114.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V1") select stage).FirstOrDefault();
                var lPSCornV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 20 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V2") select stage).FirstOrDefault();
                var lPSCornV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 179.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V3") select stage).FirstOrDefault();
                var lPSCornV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 180, MaxDegree = 229.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V4") select stage).FirstOrDefault();
                var lPSCornV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 230, MaxDegree = 289.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V5") select stage).FirstOrDefault();
                var lPSCornV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 349.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V6") select stage).FirstOrDefault();
                var lPSCornV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 350, MaxDegree = 404.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V7") select stage).FirstOrDefault();
                var lPSCornV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 405, MaxDegree = 459.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V8") select stage).FirstOrDefault();
                var lPSCornV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 519.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V9") select stage).FirstOrDefault();
                var lPSCornV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 520, MaxDegree = 589.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 70 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V10") select stage).FirstOrDefault();
                var lPSCornV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 590, MaxDegree = 649.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V11") select stage).FirstOrDefault();
                var lPSCornV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 650, MaxDegree = 689.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V12") select stage).FirstOrDefault();
                var lPSCornV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 690, MaxDegree = 714.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V13") select stage).FirstOrDefault();
                var lPSCornV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 715, MaxDegree = 749.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V14") select stage).FirstOrDefault();
                var lPSCornV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 750, MaxDegree = 774.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V15") select stage).FirstOrDefault();
                var lPSCornV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 775, MaxDegree = 884.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V16") select stage).FirstOrDefault();
                var lPSCornV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V17") select stage).FirstOrDefault();
                var lPSCornV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VT") select stage).FirstOrDefault();
                var lPSCornVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 885, MaxDegree = 1049.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 165 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R1") select stage).FirstOrDefault();
                var lPSCornR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1050, MaxDegree = 1199.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R2") select stage).FirstOrDefault();
                var lPSCornR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R3") select stage).FirstOrDefault();
                var lPSCornR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R4") select stage).FirstOrDefault();
                var lPSCornR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 1599.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R5") select stage).FirstOrDefault();
                var lPSCornR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1600, MaxDegree = 1899.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 300 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R6") select stage).FirstOrDefault();
                var lPSCornR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1900, MaxDegree = 2499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 600 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R7") select stage).FirstOrDefault();
                var lPSCornR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3999.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1500 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R8") select stage).FirstOrDefault();
                var lPSCornR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 4000, MaxDegree = 6500, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 2500 };

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
                context.PhenologicalStages.Add(lPSCornV16);
                context.PhenologicalStages.Add(lPSCornV17);
                context.PhenologicalStages.Add(lPSCornVt);
                context.PhenologicalStages.Add(lPSCornR1);
                context.PhenologicalStages.Add(lPSCornR2);
                context.PhenologicalStages.Add(lPSCornR3);
                context.PhenologicalStages.Add(lPSCornR4);
                context.PhenologicalStages.Add(lPSCornR5);
                context.PhenologicalStages.Add(lPSCornR6);
                context.PhenologicalStages.Add(lPSCornR7);
                context.PhenologicalStages.Add(lPSCornR8);
                context.SaveChanges();
                #endregion
            };
        }

        //AX 7918
        public static void InsertPhenologicalStagesCornNorthShort_2018()
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

                #region Corn North Short
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieCornNorthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V0") select stage).FirstOrDefault();
                var lPSCornV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VE") select stage).FirstOrDefault();
                var lPSCornVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 114.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V1") select stage).FirstOrDefault();
                var lPSCornV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 20 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V2") select stage).FirstOrDefault();
                var lPSCornV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 179.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V3") select stage).FirstOrDefault();
                var lPSCornV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 180, MaxDegree = 229.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V4") select stage).FirstOrDefault();
                var lPSCornV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 230, MaxDegree = 289.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V5") select stage).FirstOrDefault();
                var lPSCornV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 349.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V6") select stage).FirstOrDefault();
                var lPSCornV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 350, MaxDegree = 404.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V7") select stage).FirstOrDefault();
                var lPSCornV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 405, MaxDegree = 459.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V8") select stage).FirstOrDefault();
                var lPSCornV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 519.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V9") select stage).FirstOrDefault();
                var lPSCornV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 520, MaxDegree = 589.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 70 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V10") select stage).FirstOrDefault();
                var lPSCornV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 590, MaxDegree = 649.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V11") select stage).FirstOrDefault();
                var lPSCornV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 650, MaxDegree = 689.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V12") select stage).FirstOrDefault();
                var lPSCornV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 690, MaxDegree = 714.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V13") select stage).FirstOrDefault();
                var lPSCornV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 715, MaxDegree = 749.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V14") select stage).FirstOrDefault();
                var lPSCornV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 750, MaxDegree = 784.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V15") select stage).FirstOrDefault();
                var lPSCornV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 785, MaxDegree = 914.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V16") select stage).FirstOrDefault();
                var lPSCornV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 50 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V17") select stage).FirstOrDefault();
                var lPSCornV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VT") select stage).FirstOrDefault();
                var lPSCornVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 915, MaxDegree = 1059.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R1") select stage).FirstOrDefault();
                var lPSCornR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1060, MaxDegree = 1119.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R2") select stage).FirstOrDefault();
                var lPSCornR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1220, MaxDegree = 1359.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R3") select stage).FirstOrDefault();
                var lPSCornR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1360, MaxDegree = 1499.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R4") select stage).FirstOrDefault();
                var lPSCornR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 1599.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R5") select stage).FirstOrDefault();
                var lPSCornR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1600, MaxDegree = 1899.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 300 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R6") select stage).FirstOrDefault();
                var lPSCornR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1900, MaxDegree = 2499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 600 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R7") select stage).FirstOrDefault();
                var lPSCornR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3999.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1500 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R8") select stage).FirstOrDefault();
                var lPSCornR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 4000, MaxDegree = 6500, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 2500 };

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
                context.PhenologicalStages.Add(lPSCornV16);
                context.PhenologicalStages.Add(lPSCornV17);
                context.PhenologicalStages.Add(lPSCornVt);
                context.PhenologicalStages.Add(lPSCornR1);
                context.PhenologicalStages.Add(lPSCornR2);
                context.PhenologicalStages.Add(lPSCornR3);
                context.PhenologicalStages.Add(lPSCornR4);
                context.PhenologicalStages.Add(lPSCornR5);
                context.PhenologicalStages.Add(lPSCornR6);
                context.PhenologicalStages.Add(lPSCornR7);
                context.PhenologicalStages.Add(lPSCornR8);
                context.SaveChanges();
                #endregion
            };
        }
        //AX 7822
        public static void InsertPhenologicalStagesCornNorthMedium_2018()
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

                #region Corn North Medium
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieCornNorthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V0") select stage).FirstOrDefault();
                var lPSCornV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VE") select stage).FirstOrDefault();
                var lPSCornVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 114.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V1") select stage).FirstOrDefault();
                var lPSCornV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 20 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V2") select stage).FirstOrDefault();
                var lPSCornV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 179.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V3") select stage).FirstOrDefault();
                var lPSCornV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 180, MaxDegree = 229.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V4") select stage).FirstOrDefault();
                var lPSCornV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 230, MaxDegree = 289.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V5") select stage).FirstOrDefault();
                var lPSCornV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 349.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V6") select stage).FirstOrDefault();
                var lPSCornV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 350, MaxDegree = 404.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V7") select stage).FirstOrDefault();
                var lPSCornV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 405, MaxDegree = 459.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 55 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V8") select stage).FirstOrDefault();
                var lPSCornV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 519.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V9") select stage).FirstOrDefault();
                var lPSCornV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 520, MaxDegree = 589.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 70 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V10") select stage).FirstOrDefault();
                var lPSCornV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 590, MaxDegree = 649.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V11") select stage).FirstOrDefault();
                var lPSCornV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 650, MaxDegree = 689.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V12") select stage).FirstOrDefault();
                var lPSCornV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 690, MaxDegree = 714.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V13") select stage).FirstOrDefault();
                var lPSCornV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 715, MaxDegree = 749.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V14") select stage).FirstOrDefault();
                var lPSCornV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 750, MaxDegree = 774.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V15") select stage).FirstOrDefault();
                var lPSCornV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 775, MaxDegree = 884.999, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V16") select stage).FirstOrDefault();
                var lPSCornV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V17") select stage).FirstOrDefault();
                var lPSCornV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.10, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VT") select stage).FirstOrDefault();
                var lPSCornVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 885, MaxDegree = 1049.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 165 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R1") select stage).FirstOrDefault();
                var lPSCornR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1050, MaxDegree = 1199.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R2") select stage).FirstOrDefault();
                var lPSCornR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R3") select stage).FirstOrDefault();
                var lPSCornR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R4") select stage).FirstOrDefault();
                var lPSCornR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 1599.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R5") select stage).FirstOrDefault();
                var lPSCornR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1600, MaxDegree = 1899.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 300 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R6") select stage).FirstOrDefault();
                var lPSCornR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1900, MaxDegree = 2499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 600 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R7") select stage).FirstOrDefault();
                var lPSCornR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3999.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1500 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R8") select stage).FirstOrDefault();
                var lPSCornR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 4000, MaxDegree = 6500, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 2500 };

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
                context.PhenologicalStages.Add(lPSCornV16);
                context.PhenologicalStages.Add(lPSCornV17);
                context.PhenologicalStages.Add(lPSCornVt);
                context.PhenologicalStages.Add(lPSCornR1);
                context.PhenologicalStages.Add(lPSCornR2);
                context.PhenologicalStages.Add(lPSCornR3);
                context.PhenologicalStages.Add(lPSCornR4);
                context.PhenologicalStages.Add(lPSCornR5);
                context.PhenologicalStages.Add(lPSCornR6);
                context.PhenologicalStages.Add(lPSCornR7);
                context.PhenologicalStages.Add(lPSCornR8);
                context.SaveChanges();
                #endregion
            };
        }


        public static void InsertPhenologicalStagesSoyaSouthShort_2018()
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
                var lPSSoyaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 114.999, Coefficient = 0.30, RootDepth = 7, HydricBalanceDepth = 17, PhenologicalStageIsUsed = true, DegreesDaysInterval = 115, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " VE") select stage).FirstOrDefault();
                var lPSSoyaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 141.999, Coefficient = 0.37, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 27, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V1") select stage).FirstOrDefault();
                var lPSSoyaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 142, MaxDegree = 191.999, Coefficient = 0.40, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V2") select stage).FirstOrDefault();
                var lPSSoyaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 192, MaxDegree = 242.999, Coefficient = 0.43, RootDepth = 12, HydricBalanceDepth = 22, PhenologicalStageIsUsed = true, DegreesDaysInterval = 51, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V3") select stage).FirstOrDefault();
                var lPSSoyaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 243, MaxDegree = 313.999, Coefficient = 0.45, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 71, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V4") select stage).FirstOrDefault();
                var lPSSoyaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 314, MaxDegree = 348.999, Coefficient = 0.50, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V5") select stage).FirstOrDefault();
                var lPSSoyaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 349, MaxDegree = 397.999, Coefficient = 0.52, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 49, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V6") select stage).FirstOrDefault();
                var lPSSoyaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 398, MaxDegree = 445.999, Coefficient = 0.54, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 48, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V7") select stage).FirstOrDefault();
                var lPSSoyaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 446, MaxDegree = 471.999, Coefficient = 0.57, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 26, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V8") select stage).FirstOrDefault();
                var lPSSoyaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 472, MaxDegree = 515.999, Coefficient = 0.59, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 44, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V9") select stage).FirstOrDefault();
                var lPSSoyaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 516, MaxDegree = 569.999, Coefficient = 0.61, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 54, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V10") select stage).FirstOrDefault();
                var lPSSoyaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 570, MaxDegree = 654.999, Coefficient = 0.63, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 85, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 655, MaxDegree = 734.999, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 80, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V12") select stage).FirstOrDefault();
                var lPSSoyaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 100, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V13") select stage).FirstOrDefault();
                var lPSSoyaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 100, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V14") select stage).FirstOrDefault();
                var lPSSoyaV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 100, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R1") select stage).FirstOrDefault();
                var lPSSoyaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 735, MaxDegree = 849.999, Coefficient = 0.72, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 115, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R2") select stage).FirstOrDefault();
                var lPSSoyaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 850, MaxDegree = 917.999, Coefficient = 0.75, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 68, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R3") select stage).FirstOrDefault();
                var lPSSoyaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 918, MaxDegree = 1047.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R4") select stage).FirstOrDefault();
                var lPSSoyaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1048, MaxDegree = 1139.999, Coefficient = 0.83, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 92, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R5") select stage).FirstOrDefault();
                var lPSSoyaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1140, MaxDegree = 1319.999, Coefficient = 0.88, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 180, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R6") select stage).FirstOrDefault();
                var lPSSoyaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1320, MaxDegree = 1759.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 440, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R7") select stage).FirstOrDefault();
                var lPSSoyaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1760, MaxDegree = 2199.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 440, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R8") select stage).FirstOrDefault();
                var lPSSoyaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2200, MaxDegree = 2699.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 500, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R9") select stage).FirstOrDefault();
                var lPSSoyaR9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2700, MaxDegree = 3199.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 500, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R10") select stage).FirstOrDefault();
                var lPSSoyaR10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3200, MaxDegree = 4000, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000, };

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
                context.PhenologicalStages.Add(lPSSoyaV12);
                context.PhenologicalStages.Add(lPSSoyaV13);
                context.PhenologicalStages.Add(lPSSoyaV14);
                context.PhenologicalStages.Add(lPSSoyaR1);
                context.PhenologicalStages.Add(lPSSoyaR2);
                context.PhenologicalStages.Add(lPSSoyaR3);
                context.PhenologicalStages.Add(lPSSoyaR4);
                context.PhenologicalStages.Add(lPSSoyaR5);
                context.PhenologicalStages.Add(lPSSoyaR6);
                context.PhenologicalStages.Add(lPSSoyaR7);
                context.PhenologicalStages.Add(lPSSoyaR8);
                context.PhenologicalStages.Add(lPSSoyaR9);
                context.PhenologicalStages.Add(lPSSoyaR10);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesSoyaSouthMedium_2018()
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

                #region Soya South Medium
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieSoyaSouthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V0") select stage).FirstOrDefault();
                var lPSSoyaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 114.999, Coefficient = 0.30, RootDepth = 7, HydricBalanceDepth = 17, PhenologicalStageIsUsed = true, DegreesDaysInterval = 115, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " VE") select stage).FirstOrDefault();
                var lPSSoyaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 141.999, Coefficient = 0.37, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 27, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V1") select stage).FirstOrDefault();
                var lPSSoyaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 142, MaxDegree = 191.999, Coefficient = 0.40, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V2") select stage).FirstOrDefault();
                var lPSSoyaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 192, MaxDegree = 242.999, Coefficient = 0.43, RootDepth = 12, HydricBalanceDepth = 22, PhenologicalStageIsUsed = true, DegreesDaysInterval = 51, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V3") select stage).FirstOrDefault();
                var lPSSoyaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 243, MaxDegree = 313.999, Coefficient = 0.45, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 71, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V4") select stage).FirstOrDefault();
                var lPSSoyaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 314, MaxDegree = 348.999, Coefficient = 0.50, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V5") select stage).FirstOrDefault();
                var lPSSoyaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 349, MaxDegree = 397.999, Coefficient = 0.52, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 49, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V6") select stage).FirstOrDefault();
                var lPSSoyaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 398, MaxDegree = 445.999, Coefficient = 0.54, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 48, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V7") select stage).FirstOrDefault();
                var lPSSoyaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 446, MaxDegree = 471.999, Coefficient = 0.57, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 26, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V8") select stage).FirstOrDefault();
                var lPSSoyaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 472, MaxDegree = 515.999, Coefficient = 0.59, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 44, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V9") select stage).FirstOrDefault();
                var lPSSoyaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 516, MaxDegree = 569.999, Coefficient = 0.61, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 90, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V10") select stage).FirstOrDefault();
                var lPSSoyaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 606, MaxDegree = 654.999, Coefficient = 0.63, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 144, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 750, MaxDegree = 929.999, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 180, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V12") select stage).FirstOrDefault();
                var lPSSoyaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 100, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V13") select stage).FirstOrDefault();
                var lPSSoyaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 100, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V14") select stage).FirstOrDefault();
                var lPSSoyaV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 100, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R1") select stage).FirstOrDefault();
                var lPSSoyaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1059.999, Coefficient = 0.72, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R2") select stage).FirstOrDefault();
                var lPSSoyaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1060, MaxDegree = 1169.999, Coefficient = 0.75, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R3") select stage).FirstOrDefault();
                var lPSSoyaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1170, MaxDegree = 1339.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 170, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R4") select stage).FirstOrDefault();
                var lPSSoyaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1340, MaxDegree = 1459.999, Coefficient = 0.83, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R5") select stage).FirstOrDefault();
                var lPSSoyaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1460, MaxDegree = 1589.999, Coefficient = 0.88, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R6") select stage).FirstOrDefault();
                var lPSSoyaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1590, MaxDegree = 1839.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 250, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R7") select stage).FirstOrDefault();
                var lPSSoyaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1840, MaxDegree = 2374.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 535, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R8") select stage).FirstOrDefault();
                var lPSSoyaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2375, MaxDegree = 3374.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R9") select stage).FirstOrDefault();
                var lPSSoyaR9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3375, MaxDegree = 4374.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R10") select stage).FirstOrDefault();
                var lPSSoyaR10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 4375, MaxDegree = 5000, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 625, };

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
                context.PhenologicalStages.Add(lPSSoyaV12);
                context.PhenologicalStages.Add(lPSSoyaV13);
                context.PhenologicalStages.Add(lPSSoyaV14);
                context.PhenologicalStages.Add(lPSSoyaR1);
                context.PhenologicalStages.Add(lPSSoyaR2);
                context.PhenologicalStages.Add(lPSSoyaR3);
                context.PhenologicalStages.Add(lPSSoyaR4);
                context.PhenologicalStages.Add(lPSSoyaR5);
                context.PhenologicalStages.Add(lPSSoyaR6);
                context.PhenologicalStages.Add(lPSSoyaR7);
                context.PhenologicalStages.Add(lPSSoyaR8);
                context.PhenologicalStages.Add(lPSSoyaR9);
                context.PhenologicalStages.Add(lPSSoyaR10);
                context.SaveChanges();
                #endregion
            };
        }


        public static void InsertPhenologicalStagesSoyaNorthShort_2018()
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

                #region Soya North Short
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieSoyaNorthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V0") select stage).FirstOrDefault();
                var lPSSoyaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 114.999, Coefficient = 0.30, RootDepth = 7, HydricBalanceDepth = 17, PhenologicalStageIsUsed = true, DegreesDaysInterval = 115, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " VE") select stage).FirstOrDefault();
                var lPSSoyaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 141.999, Coefficient = 0.37, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 27, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V1") select stage).FirstOrDefault();
                var lPSSoyaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 142, MaxDegree = 191.999, Coefficient = 0.40, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V2") select stage).FirstOrDefault();
                var lPSSoyaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 192, MaxDegree = 242.999, Coefficient = 0.43, RootDepth = 12, HydricBalanceDepth = 22, PhenologicalStageIsUsed = true, DegreesDaysInterval = 51, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V3") select stage).FirstOrDefault();
                var lPSSoyaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 243, MaxDegree = 313.999, Coefficient = 0.45, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 71, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V4") select stage).FirstOrDefault();
                var lPSSoyaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 314, MaxDegree = 348.999, Coefficient = 0.50, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V5") select stage).FirstOrDefault();
                var lPSSoyaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 349, MaxDegree = 397.999, Coefficient = 0.52, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 49, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V6") select stage).FirstOrDefault();
                var lPSSoyaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 398, MaxDegree = 445.999, Coefficient = 0.54, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 48, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V7") select stage).FirstOrDefault();
                var lPSSoyaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 446, MaxDegree = 471.999, Coefficient = 0.57, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 26, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V8") select stage).FirstOrDefault();
                var lPSSoyaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 472, MaxDegree = 515.999, Coefficient = 0.59, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 44, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V9") select stage).FirstOrDefault();
                var lPSSoyaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 516, MaxDegree = 559.999, Coefficient = 0.61, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 44, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V10") select stage).FirstOrDefault();
                var lPSSoyaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 560, MaxDegree = 634.999, Coefficient = 0.63, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 75, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 80, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V12") select stage).FirstOrDefault();
                var lPSSoyaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 100, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V13") select stage).FirstOrDefault();
                var lPSSoyaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 100, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V14") select stage).FirstOrDefault();
                var lPSSoyaV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 100, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R1") select stage).FirstOrDefault();
                var lPSSoyaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 635, MaxDegree = 844.999, Coefficient = 0.72, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 210, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R2") select stage).FirstOrDefault();
                var lPSSoyaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 845, MaxDegree = 964.999, Coefficient = 0.75, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R3") select stage).FirstOrDefault();
                var lPSSoyaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 965, MaxDegree = 1124.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R4") select stage).FirstOrDefault();
                var lPSSoyaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1125, MaxDegree = 1284.999, Coefficient = 0.83, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R5") select stage).FirstOrDefault();
                var lPSSoyaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1285, MaxDegree = 1399.999, Coefficient = 0.88, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 115, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R6") select stage).FirstOrDefault();
                var lPSSoyaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1400, MaxDegree = 1699.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 300, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R7") select stage).FirstOrDefault();
                var lPSSoyaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1700, MaxDegree = 2149.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 450, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R8") select stage).FirstOrDefault();
                var lPSSoyaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2150, MaxDegree = 2649.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 500, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R9") select stage).FirstOrDefault();
                var lPSSoyaR9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2650, MaxDegree = 3149.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 500, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R10") select stage).FirstOrDefault();
                var lPSSoyaR10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3150, MaxDegree = 4000, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 850, };

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
                context.PhenologicalStages.Add(lPSSoyaV12);
                context.PhenologicalStages.Add(lPSSoyaV13);
                context.PhenologicalStages.Add(lPSSoyaV14);
                context.PhenologicalStages.Add(lPSSoyaR1);
                context.PhenologicalStages.Add(lPSSoyaR2);
                context.PhenologicalStages.Add(lPSSoyaR3);
                context.PhenologicalStages.Add(lPSSoyaR4);
                context.PhenologicalStages.Add(lPSSoyaR5);
                context.PhenologicalStages.Add(lPSSoyaR6);
                context.PhenologicalStages.Add(lPSSoyaR7);
                context.PhenologicalStages.Add(lPSSoyaR8);
                context.PhenologicalStages.Add(lPSSoyaR9);
                context.PhenologicalStages.Add(lPSSoyaR10);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesSoyaNorthMedium_2018()
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

                #region Soya North Medium
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieSoyaNorthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V0") select stage).FirstOrDefault();
                var lPSSoyaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 114.999, Coefficient = 0.30, RootDepth = 7, HydricBalanceDepth = 17, PhenologicalStageIsUsed = true, DegreesDaysInterval = 115, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " VE") select stage).FirstOrDefault();
                var lPSSoyaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 141.999, Coefficient = 0.37, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 27, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V1") select stage).FirstOrDefault();
                var lPSSoyaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 142, MaxDegree = 191.999, Coefficient = 0.40, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V2") select stage).FirstOrDefault();
                var lPSSoyaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 192, MaxDegree = 242.999, Coefficient = 0.43, RootDepth = 12, HydricBalanceDepth = 22, PhenologicalStageIsUsed = true, DegreesDaysInterval = 51, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V3") select stage).FirstOrDefault();
                var lPSSoyaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 243, MaxDegree = 313.999, Coefficient = 0.45, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 71, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V4") select stage).FirstOrDefault();
                var lPSSoyaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 314, MaxDegree = 348.999, Coefficient = 0.50, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V5") select stage).FirstOrDefault();
                var lPSSoyaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 349, MaxDegree = 397.999, Coefficient = 0.52, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 49, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V6") select stage).FirstOrDefault();
                var lPSSoyaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 398, MaxDegree = 445.999, Coefficient = 0.54, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 48, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V7") select stage).FirstOrDefault();
                var lPSSoyaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 446, MaxDegree = 471.999, Coefficient = 0.57, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 26, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V8") select stage).FirstOrDefault();
                var lPSSoyaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 472, MaxDegree = 515.999, Coefficient = 0.59, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 44, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V9") select stage).FirstOrDefault();
                var lPSSoyaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 516, MaxDegree = 565.999, Coefficient = 0.61, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V10") select stage).FirstOrDefault();
                var lPSSoyaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 566, MaxDegree = 655.999, Coefficient = 0.63, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 90, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 656, MaxDegree = 775.999, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V12") select stage).FirstOrDefault();
                var lPSSoyaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 100, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V13") select stage).FirstOrDefault();
                var lPSSoyaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 100, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V14") select stage).FirstOrDefault();
                var lPSSoyaV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 0.68, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = false, DegreesDaysInterval = 100, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R1") select stage).FirstOrDefault();
                var lPSSoyaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 776, MaxDegree = 839.999, Coefficient = 0.72, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 64, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R2") select stage).FirstOrDefault();
                var lPSSoyaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 840, MaxDegree = 949.999, Coefficient = 0.75, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R3") select stage).FirstOrDefault();
                var lPSSoyaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 950, MaxDegree = 1069.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R4") select stage).FirstOrDefault();
                var lPSSoyaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1070, MaxDegree = 1189.999, Coefficient = 0.83, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R5") select stage).FirstOrDefault();
                var lPSSoyaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1190, MaxDegree = 1369.999, Coefficient = 0.88, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 180, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R6") select stage).FirstOrDefault();
                var lPSSoyaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1370, MaxDegree = 1719.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 350, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R7") select stage).FirstOrDefault();
                var lPSSoyaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1720, MaxDegree = 2244.999, Coefficient = 1.15, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 525, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R8") select stage).FirstOrDefault();
                var lPSSoyaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2245, MaxDegree = 2744.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 500, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R9") select stage).FirstOrDefault();
                var lPSSoyaR9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2745, MaxDegree = 3244.999, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 500, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R10") select stage).FirstOrDefault();
                var lPSSoyaR10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3245, MaxDegree = 4000, Coefficient = 0.78, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 850, };

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
                context.PhenologicalStages.Add(lPSSoyaV12);
                context.PhenologicalStages.Add(lPSSoyaV13);
                context.PhenologicalStages.Add(lPSSoyaV14);
                context.PhenologicalStages.Add(lPSSoyaR1);
                context.PhenologicalStages.Add(lPSSoyaR2);
                context.PhenologicalStages.Add(lPSSoyaR3);
                context.PhenologicalStages.Add(lPSSoyaR4);
                context.PhenologicalStages.Add(lPSSoyaR5);
                context.PhenologicalStages.Add(lPSSoyaR6);
                context.PhenologicalStages.Add(lPSSoyaR7);
                context.PhenologicalStages.Add(lPSSoyaR8);
                context.PhenologicalStages.Add(lPSSoyaR9);
                context.PhenologicalStages.Add(lPSSoyaR10);
                context.SaveChanges();
                #endregion
            };
        }


        public static void InsertPhenologicalStagesOatSouthShort_2018()
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

                #region Oat
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieOatSouthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V0") select stage).FirstOrDefault();
                var lPSOatV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " VE") select stage).FirstOrDefault();
                var lPSOatVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V1") select stage).FirstOrDefault();
                var lPSOatV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V2") select stage).FirstOrDefault();
                var lPSOatV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V3") select stage).FirstOrDefault();
                var lPSOatV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V4") select stage).FirstOrDefault();
                var lPSOatV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V5") select stage).FirstOrDefault();
                var lPSOatV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V6") select stage).FirstOrDefault();
                var lPSOatV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V7") select stage).FirstOrDefault();
                var lPSOatV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V8") select stage).FirstOrDefault();
                var lPSOatV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V9") select stage).FirstOrDefault();
                var lPSOatV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V10") select stage).FirstOrDefault();
                var lPSOatV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V11") select stage).FirstOrDefault();
                var lPSOatV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V12") select stage).FirstOrDefault();
                var lPSOatV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V13") select stage).FirstOrDefault();
                var lPSOatV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V14") select stage).FirstOrDefault();
                var lPSOatV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 729.99, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V15") select stage).FirstOrDefault();
                var lPSOatV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 730, MaxDegree = 879.99, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V16") select stage).FirstOrDefault();
                var lPSOatV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 880, MaxDegree = 1029.99, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V17") select stage).FirstOrDefault();
                var lPSOatV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1030, MaxDegree = 1179.99, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " VT") select stage).FirstOrDefault();
                var lPSOatVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1180, MaxDegree = 1279.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R1") select stage).FirstOrDefault();
                var lPSOatR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1280, MaxDegree = 1399.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R2") select stage).FirstOrDefault();
                var lPSOatR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1400, MaxDegree = 1529.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R3") select stage).FirstOrDefault();
                var lPSOatR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1530, MaxDegree = 1639.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R4") select stage).FirstOrDefault();
                var lPSOatR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1640, MaxDegree = 1799.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R5") select stage).FirstOrDefault();
                var lPSOatR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1800, MaxDegree = 1949.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R6") select stage).FirstOrDefault();
                var lPSOatR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1950, MaxDegree = 2099.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R7") select stage).FirstOrDefault();
                var lPSOatR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2100, MaxDegree = 3199.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R8") select stage).FirstOrDefault();
                var lPSOatR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3100, MaxDegree = 4100, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - Oat
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSOatV0);
                context.PhenologicalStages.Add(lPSOatVe);
                context.PhenologicalStages.Add(lPSOatV1);
                context.PhenologicalStages.Add(lPSOatV2);
                context.PhenologicalStages.Add(lPSOatV3);
                context.PhenologicalStages.Add(lPSOatV4);
                context.PhenologicalStages.Add(lPSOatV5);
                context.PhenologicalStages.Add(lPSOatV6);
                context.PhenologicalStages.Add(lPSOatV7);
                context.PhenologicalStages.Add(lPSOatV8);
                context.PhenologicalStages.Add(lPSOatV9);
                context.PhenologicalStages.Add(lPSOatV10);
                context.PhenologicalStages.Add(lPSOatV11);
                context.PhenologicalStages.Add(lPSOatV12);
                context.PhenologicalStages.Add(lPSOatV13);
                context.PhenologicalStages.Add(lPSOatV14);
                context.PhenologicalStages.Add(lPSOatV15);
                context.PhenologicalStages.Add(lPSOatV16);
                context.PhenologicalStages.Add(lPSOatV17);
                context.PhenologicalStages.Add(lPSOatVt);
                context.PhenologicalStages.Add(lPSOatR1);
                context.PhenologicalStages.Add(lPSOatR2);
                context.PhenologicalStages.Add(lPSOatR3);
                context.PhenologicalStages.Add(lPSOatR4);
                context.PhenologicalStages.Add(lPSOatR5);
                context.PhenologicalStages.Add(lPSOatR6);
                context.PhenologicalStages.Add(lPSOatR7);
                context.PhenologicalStages.Add(lPSOatR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesOatSouthMedium_2018()
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

                #region Oat
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieOatSouthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V0") select stage).FirstOrDefault();
                var lPSOatV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " VE") select stage).FirstOrDefault();
                var lPSOatVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V1") select stage).FirstOrDefault();
                var lPSOatV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V2") select stage).FirstOrDefault();
                var lPSOatV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V3") select stage).FirstOrDefault();
                var lPSOatV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V4") select stage).FirstOrDefault();
                var lPSOatV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V5") select stage).FirstOrDefault();
                var lPSOatV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V6") select stage).FirstOrDefault();
                var lPSOatV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V7") select stage).FirstOrDefault();
                var lPSOatV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V8") select stage).FirstOrDefault();
                var lPSOatV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V9") select stage).FirstOrDefault();
                var lPSOatV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V10") select stage).FirstOrDefault();
                var lPSOatV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V11") select stage).FirstOrDefault();
                var lPSOatV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V12") select stage).FirstOrDefault();
                var lPSOatV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V13") select stage).FirstOrDefault();
                var lPSOatV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V14") select stage).FirstOrDefault();
                var lPSOatV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V15") select stage).FirstOrDefault();
                var lPSOatV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V16") select stage).FirstOrDefault();
                var lPSOatV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V17") select stage).FirstOrDefault();
                var lPSOatV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " VT") select stage).FirstOrDefault();
                var lPSOatVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R1") select stage).FirstOrDefault();
                var lPSOatR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R2") select stage).FirstOrDefault();
                var lPSOatR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R3") select stage).FirstOrDefault();
                var lPSOatR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R4") select stage).FirstOrDefault();
                var lPSOatR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R5") select stage).FirstOrDefault();
                var lPSOatR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R6") select stage).FirstOrDefault();
                var lPSOatR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R7") select stage).FirstOrDefault();
                var lPSOatR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R8") select stage).FirstOrDefault();
                var lPSOatR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - Oat
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSOatV0);
                context.PhenologicalStages.Add(lPSOatVe);
                context.PhenologicalStages.Add(lPSOatV1);
                context.PhenologicalStages.Add(lPSOatV2);
                context.PhenologicalStages.Add(lPSOatV3);
                context.PhenologicalStages.Add(lPSOatV4);
                context.PhenologicalStages.Add(lPSOatV5);
                context.PhenologicalStages.Add(lPSOatV6);
                context.PhenologicalStages.Add(lPSOatV7);
                context.PhenologicalStages.Add(lPSOatV8);
                context.PhenologicalStages.Add(lPSOatV9);
                context.PhenologicalStages.Add(lPSOatV10);
                context.PhenologicalStages.Add(lPSOatV11);
                context.PhenologicalStages.Add(lPSOatV12);
                context.PhenologicalStages.Add(lPSOatV13);
                context.PhenologicalStages.Add(lPSOatV14);
                context.PhenologicalStages.Add(lPSOatV15);
                context.PhenologicalStages.Add(lPSOatV16);
                context.PhenologicalStages.Add(lPSOatV17);
                context.PhenologicalStages.Add(lPSOatVt);
                context.PhenologicalStages.Add(lPSOatR1);
                context.PhenologicalStages.Add(lPSOatR2);
                context.PhenologicalStages.Add(lPSOatR3);
                context.PhenologicalStages.Add(lPSOatR4);
                context.PhenologicalStages.Add(lPSOatR5);
                context.PhenologicalStages.Add(lPSOatR6);
                context.PhenologicalStages.Add(lPSOatR7);
                context.PhenologicalStages.Add(lPSOatR8);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesOatNorthShort_2018()
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

                #region Oat
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieOatNorthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V0") select stage).FirstOrDefault();
                var lPSOatV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " VE") select stage).FirstOrDefault();
                var lPSOatVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V1") select stage).FirstOrDefault();
                var lPSOatV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V2") select stage).FirstOrDefault();
                var lPSOatV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V3") select stage).FirstOrDefault();
                var lPSOatV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V4") select stage).FirstOrDefault();
                var lPSOatV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V5") select stage).FirstOrDefault();
                var lPSOatV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V6") select stage).FirstOrDefault();
                var lPSOatV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V7") select stage).FirstOrDefault();
                var lPSOatV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V8") select stage).FirstOrDefault();
                var lPSOatV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V9") select stage).FirstOrDefault();
                var lPSOatV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V10") select stage).FirstOrDefault();
                var lPSOatV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V11") select stage).FirstOrDefault();
                var lPSOatV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V12") select stage).FirstOrDefault();
                var lPSOatV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V13") select stage).FirstOrDefault();
                var lPSOatV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V14") select stage).FirstOrDefault();
                var lPSOatV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V15") select stage).FirstOrDefault();
                var lPSOatV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V16") select stage).FirstOrDefault();
                var lPSOatV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V17") select stage).FirstOrDefault();
                var lPSOatV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " VT") select stage).FirstOrDefault();
                var lPSOatVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R1") select stage).FirstOrDefault();
                var lPSOatR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R2") select stage).FirstOrDefault();
                var lPSOatR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R3") select stage).FirstOrDefault();
                var lPSOatR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R4") select stage).FirstOrDefault();
                var lPSOatR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R5") select stage).FirstOrDefault();
                var lPSOatR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R6") select stage).FirstOrDefault();
                var lPSOatR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R7") select stage).FirstOrDefault();
                var lPSOatR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R8") select stage).FirstOrDefault();
                var lPSOatR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - Oat
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSOatV0);
                context.PhenologicalStages.Add(lPSOatVe);
                context.PhenologicalStages.Add(lPSOatV1);
                context.PhenologicalStages.Add(lPSOatV2);
                context.PhenologicalStages.Add(lPSOatV3);
                context.PhenologicalStages.Add(lPSOatV4);
                context.PhenologicalStages.Add(lPSOatV5);
                context.PhenologicalStages.Add(lPSOatV6);
                context.PhenologicalStages.Add(lPSOatV7);
                context.PhenologicalStages.Add(lPSOatV8);
                context.PhenologicalStages.Add(lPSOatV9);
                context.PhenologicalStages.Add(lPSOatV10);
                context.PhenologicalStages.Add(lPSOatV11);
                context.PhenologicalStages.Add(lPSOatV12);
                context.PhenologicalStages.Add(lPSOatV13);
                context.PhenologicalStages.Add(lPSOatV14);
                context.PhenologicalStages.Add(lPSOatV15);
                context.PhenologicalStages.Add(lPSOatV16);
                context.PhenologicalStages.Add(lPSOatV17);
                context.PhenologicalStages.Add(lPSOatVt);
                context.PhenologicalStages.Add(lPSOatR1);
                context.PhenologicalStages.Add(lPSOatR2);
                context.PhenologicalStages.Add(lPSOatR3);
                context.PhenologicalStages.Add(lPSOatR4);
                context.PhenologicalStages.Add(lPSOatR5);
                context.PhenologicalStages.Add(lPSOatR6);
                context.PhenologicalStages.Add(lPSOatR7);
                context.PhenologicalStages.Add(lPSOatR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesOatNorthMedium_2018()
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

                #region Oat
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieOatNorthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V0") select stage).FirstOrDefault();
                var lPSOatV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " VE") select stage).FirstOrDefault();
                var lPSOatVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V1") select stage).FirstOrDefault();
                var lPSOatV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V2") select stage).FirstOrDefault();
                var lPSOatV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V3") select stage).FirstOrDefault();
                var lPSOatV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V4") select stage).FirstOrDefault();
                var lPSOatV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V5") select stage).FirstOrDefault();
                var lPSOatV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V6") select stage).FirstOrDefault();
                var lPSOatV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V7") select stage).FirstOrDefault();
                var lPSOatV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V8") select stage).FirstOrDefault();
                var lPSOatV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V9") select stage).FirstOrDefault();
                var lPSOatV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V10") select stage).FirstOrDefault();
                var lPSOatV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V11") select stage).FirstOrDefault();
                var lPSOatV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V12") select stage).FirstOrDefault();
                var lPSOatV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V13") select stage).FirstOrDefault();
                var lPSOatV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V14") select stage).FirstOrDefault();
                var lPSOatV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V15") select stage).FirstOrDefault();
                var lPSOatV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V16") select stage).FirstOrDefault();
                var lPSOatV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " V17") select stage).FirstOrDefault();
                var lPSOatV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " VT") select stage).FirstOrDefault();
                var lPSOatVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R1") select stage).FirstOrDefault();
                var lPSOatR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R2") select stage).FirstOrDefault();
                var lPSOatR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R3") select stage).FirstOrDefault();
                var lPSOatR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R4") select stage).FirstOrDefault();
                var lPSOatR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R5") select stage).FirstOrDefault();
                var lPSOatR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R6") select stage).FirstOrDefault();
                var lPSOatR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R7") select stage).FirstOrDefault();
                var lPSOatR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesOat + " R8") select stage).FirstOrDefault();
                var lPSOatR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - Oat
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSOatV0);
                context.PhenologicalStages.Add(lPSOatVe);
                context.PhenologicalStages.Add(lPSOatV1);
                context.PhenologicalStages.Add(lPSOatV2);
                context.PhenologicalStages.Add(lPSOatV3);
                context.PhenologicalStages.Add(lPSOatV4);
                context.PhenologicalStages.Add(lPSOatV5);
                context.PhenologicalStages.Add(lPSOatV6);
                context.PhenologicalStages.Add(lPSOatV7);
                context.PhenologicalStages.Add(lPSOatV8);
                context.PhenologicalStages.Add(lPSOatV9);
                context.PhenologicalStages.Add(lPSOatV10);
                context.PhenologicalStages.Add(lPSOatV11);
                context.PhenologicalStages.Add(lPSOatV12);
                context.PhenologicalStages.Add(lPSOatV13);
                context.PhenologicalStages.Add(lPSOatV14);
                context.PhenologicalStages.Add(lPSOatV15);
                context.PhenologicalStages.Add(lPSOatV16);
                context.PhenologicalStages.Add(lPSOatV17);
                context.PhenologicalStages.Add(lPSOatVt);
                context.PhenologicalStages.Add(lPSOatR1);
                context.PhenologicalStages.Add(lPSOatR2);
                context.PhenologicalStages.Add(lPSOatR3);
                context.PhenologicalStages.Add(lPSOatR4);
                context.PhenologicalStages.Add(lPSOatR5);
                context.PhenologicalStages.Add(lPSOatR6);
                context.PhenologicalStages.Add(lPSOatR7);
                context.PhenologicalStages.Add(lPSOatR8);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesAlfalfaSouthShort_2018()
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

                #region Alfalfa
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieAlfalfaSouthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V0") select stage).FirstOrDefault();
                var lPSAlfalfaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 159.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " VE") select stage).FirstOrDefault();
                var lPSAlfalfaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 160, MaxDegree = 309.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V1") select stage).FirstOrDefault();
                var lPSAlfalfaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 310, MaxDegree = 434.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V2") select stage).FirstOrDefault();
                var lPSAlfalfaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 435, MaxDegree = 569.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V3") select stage).FirstOrDefault();
                var lPSAlfalfaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 570, MaxDegree = 709.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V4") select stage).FirstOrDefault();
                var lPSAlfalfaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 710, MaxDegree = 849.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V5") select stage).FirstOrDefault();
                var lPSAlfalfaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 850, MaxDegree = 989.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V6") select stage).FirstOrDefault();
                var lPSAlfalfaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 990, MaxDegree = 1134.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V7") select stage).FirstOrDefault();
                var lPSAlfalfaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1135, MaxDegree = 1279.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V8") select stage).FirstOrDefault();
                var lPSAlfalfaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1280, MaxDegree = 1419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V9") select stage).FirstOrDefault();
                var lPSAlfalfaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1420, MaxDegree = 1559.999, Coefficient = 0.70, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V10") select stage).FirstOrDefault();
                var lPSAlfalfaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1560, MaxDegree = 1694.999, Coefficient = 0.70, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V11") select stage).FirstOrDefault();
                var lPSAlfalfaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1695, MaxDegree = 1829.999, Coefficient = 0.70, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V12") select stage).FirstOrDefault();
                var lPSAlfalfaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1830, MaxDegree = 1954.999, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V13") select stage).FirstOrDefault();
                var lPSAlfalfaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1955, MaxDegree = 2079.999, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V14") select stage).FirstOrDefault();
                var lPSAlfalfaV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2080, MaxDegree = 2229.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V15") select stage).FirstOrDefault();
                var lPSAlfalfaV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2230, MaxDegree = 2379.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V16") select stage).FirstOrDefault();
                var lPSAlfalfaV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2380, MaxDegree = 2529.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V17") select stage).FirstOrDefault();
                var lPSAlfalfaV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2530, MaxDegree = 2679.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R1") select stage).FirstOrDefault();
                var lPSAlfalfaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2680, MaxDegree = 2799.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R2") select stage).FirstOrDefault();
                var lPSAlfalfaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2800, MaxDegree = 2929.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R3") select stage).FirstOrDefault();
                var lPSAlfalfaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2930, MaxDegree = 3039.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R4") select stage).FirstOrDefault();
                var lPSAlfalfaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3140, MaxDegree = 3299.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R5") select stage).FirstOrDefault();
                var lPSAlfalfaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3300, MaxDegree = 3449.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R6") select stage).FirstOrDefault();
                var lPSAlfalfaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3450, MaxDegree = 4599.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R7") select stage).FirstOrDefault();
                var lPSAlfalfaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 4600, MaxDegree = 5599.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R8") select stage).FirstOrDefault();
                var lPSAlfalfaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 5600, MaxDegree = 6600, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - Alfalfa
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSAlfalfaV0);
                context.PhenologicalStages.Add(lPSAlfalfaVe);
                context.PhenologicalStages.Add(lPSAlfalfaV1);
                context.PhenologicalStages.Add(lPSAlfalfaV2);
                context.PhenologicalStages.Add(lPSAlfalfaV3);
                context.PhenologicalStages.Add(lPSAlfalfaV4);
                context.PhenologicalStages.Add(lPSAlfalfaV5);
                context.PhenologicalStages.Add(lPSAlfalfaV6);
                context.PhenologicalStages.Add(lPSAlfalfaV7);
                context.PhenologicalStages.Add(lPSAlfalfaV8);
                context.PhenologicalStages.Add(lPSAlfalfaV9);
                context.PhenologicalStages.Add(lPSAlfalfaV10);
                context.PhenologicalStages.Add(lPSAlfalfaV11);
                context.PhenologicalStages.Add(lPSAlfalfaV12);
                context.PhenologicalStages.Add(lPSAlfalfaV13);
                context.PhenologicalStages.Add(lPSAlfalfaV14);
                context.PhenologicalStages.Add(lPSAlfalfaV15);
                context.PhenologicalStages.Add(lPSAlfalfaV16);
                context.PhenologicalStages.Add(lPSAlfalfaV17);
                context.PhenologicalStages.Add(lPSAlfalfaR1);
                context.PhenologicalStages.Add(lPSAlfalfaR2);
                context.PhenologicalStages.Add(lPSAlfalfaR3);
                context.PhenologicalStages.Add(lPSAlfalfaR4);
                context.PhenologicalStages.Add(lPSAlfalfaR5);
                context.PhenologicalStages.Add(lPSAlfalfaR6);
                context.PhenologicalStages.Add(lPSAlfalfaR7);
                context.PhenologicalStages.Add(lPSAlfalfaR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesAlfalfaSouthMedium_2018()
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

                #region Alfalfa
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieAlfalfaSouthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V0") select stage).FirstOrDefault();
                var lPSAlfalfaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " VE") select stage).FirstOrDefault();
                var lPSAlfalfaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V1") select stage).FirstOrDefault();
                var lPSAlfalfaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V2") select stage).FirstOrDefault();
                var lPSAlfalfaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V3") select stage).FirstOrDefault();
                var lPSAlfalfaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V4") select stage).FirstOrDefault();
                var lPSAlfalfaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V5") select stage).FirstOrDefault();
                var lPSAlfalfaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V6") select stage).FirstOrDefault();
                var lPSAlfalfaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V7") select stage).FirstOrDefault();
                var lPSAlfalfaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V8") select stage).FirstOrDefault();
                var lPSAlfalfaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V9") select stage).FirstOrDefault();
                var lPSAlfalfaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V10") select stage).FirstOrDefault();
                var lPSAlfalfaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V11") select stage).FirstOrDefault();
                var lPSAlfalfaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V12") select stage).FirstOrDefault();
                var lPSAlfalfaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V13") select stage).FirstOrDefault();
                var lPSAlfalfaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V14") select stage).FirstOrDefault();
                var lPSAlfalfaV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V15") select stage).FirstOrDefault();
                var lPSAlfalfaV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V16") select stage).FirstOrDefault();
                var lPSAlfalfaV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V17") select stage).FirstOrDefault();
                var lPSAlfalfaV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " VT") select stage).FirstOrDefault();
                var lPSAlfalfaVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R1") select stage).FirstOrDefault();
                var lPSAlfalfaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R2") select stage).FirstOrDefault();
                var lPSAlfalfaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R3") select stage).FirstOrDefault();
                var lPSAlfalfaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R4") select stage).FirstOrDefault();
                var lPSAlfalfaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R5") select stage).FirstOrDefault();
                var lPSAlfalfaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R6") select stage).FirstOrDefault();
                var lPSAlfalfaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R7") select stage).FirstOrDefault();
                var lPSAlfalfaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R8") select stage).FirstOrDefault();
                var lPSAlfalfaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - Alfalfa
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSAlfalfaV0);
                context.PhenologicalStages.Add(lPSAlfalfaVe);
                context.PhenologicalStages.Add(lPSAlfalfaV1);
                context.PhenologicalStages.Add(lPSAlfalfaV2);
                context.PhenologicalStages.Add(lPSAlfalfaV3);
                context.PhenologicalStages.Add(lPSAlfalfaV4);
                context.PhenologicalStages.Add(lPSAlfalfaV5);
                context.PhenologicalStages.Add(lPSAlfalfaV6);
                context.PhenologicalStages.Add(lPSAlfalfaV7);
                context.PhenologicalStages.Add(lPSAlfalfaV8);
                context.PhenologicalStages.Add(lPSAlfalfaV9);
                context.PhenologicalStages.Add(lPSAlfalfaV10);
                context.PhenologicalStages.Add(lPSAlfalfaV11);
                context.PhenologicalStages.Add(lPSAlfalfaV12);
                context.PhenologicalStages.Add(lPSAlfalfaV13);
                context.PhenologicalStages.Add(lPSAlfalfaV14);
                context.PhenologicalStages.Add(lPSAlfalfaV15);
                context.PhenologicalStages.Add(lPSAlfalfaV16);
                context.PhenologicalStages.Add(lPSAlfalfaV17);
                context.PhenologicalStages.Add(lPSAlfalfaVt);
                context.PhenologicalStages.Add(lPSAlfalfaR1);
                context.PhenologicalStages.Add(lPSAlfalfaR2);
                context.PhenologicalStages.Add(lPSAlfalfaR3);
                context.PhenologicalStages.Add(lPSAlfalfaR4);
                context.PhenologicalStages.Add(lPSAlfalfaR5);
                context.PhenologicalStages.Add(lPSAlfalfaR6);
                context.PhenologicalStages.Add(lPSAlfalfaR7);
                context.PhenologicalStages.Add(lPSAlfalfaR8);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesAlfalfaNorthShort_2018()
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

                #region Alfalfa
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieAlfalfaNorthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V0") select stage).FirstOrDefault();
                var lPSAlfalfaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " VE") select stage).FirstOrDefault();
                var lPSAlfalfaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V1") select stage).FirstOrDefault();
                var lPSAlfalfaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V2") select stage).FirstOrDefault();
                var lPSAlfalfaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V3") select stage).FirstOrDefault();
                var lPSAlfalfaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V4") select stage).FirstOrDefault();
                var lPSAlfalfaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V5") select stage).FirstOrDefault();
                var lPSAlfalfaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V6") select stage).FirstOrDefault();
                var lPSAlfalfaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V7") select stage).FirstOrDefault();
                var lPSAlfalfaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V8") select stage).FirstOrDefault();
                var lPSAlfalfaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V9") select stage).FirstOrDefault();
                var lPSAlfalfaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V10") select stage).FirstOrDefault();
                var lPSAlfalfaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V11") select stage).FirstOrDefault();
                var lPSAlfalfaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V12") select stage).FirstOrDefault();
                var lPSAlfalfaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V13") select stage).FirstOrDefault();
                var lPSAlfalfaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V14") select stage).FirstOrDefault();
                var lPSAlfalfaV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V15") select stage).FirstOrDefault();
                var lPSAlfalfaV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V16") select stage).FirstOrDefault();
                var lPSAlfalfaV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V17") select stage).FirstOrDefault();
                var lPSAlfalfaV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " VT") select stage).FirstOrDefault();
                var lPSAlfalfaVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R1") select stage).FirstOrDefault();
                var lPSAlfalfaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R2") select stage).FirstOrDefault();
                var lPSAlfalfaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R3") select stage).FirstOrDefault();
                var lPSAlfalfaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R4") select stage).FirstOrDefault();
                var lPSAlfalfaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R5") select stage).FirstOrDefault();
                var lPSAlfalfaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R6") select stage).FirstOrDefault();
                var lPSAlfalfaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R7") select stage).FirstOrDefault();
                var lPSAlfalfaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R8") select stage).FirstOrDefault();
                var lPSAlfalfaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - Alfalfa
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSAlfalfaV0);
                context.PhenologicalStages.Add(lPSAlfalfaVe);
                context.PhenologicalStages.Add(lPSAlfalfaV1);
                context.PhenologicalStages.Add(lPSAlfalfaV2);
                context.PhenologicalStages.Add(lPSAlfalfaV3);
                context.PhenologicalStages.Add(lPSAlfalfaV4);
                context.PhenologicalStages.Add(lPSAlfalfaV5);
                context.PhenologicalStages.Add(lPSAlfalfaV6);
                context.PhenologicalStages.Add(lPSAlfalfaV7);
                context.PhenologicalStages.Add(lPSAlfalfaV8);
                context.PhenologicalStages.Add(lPSAlfalfaV9);
                context.PhenologicalStages.Add(lPSAlfalfaV10);
                context.PhenologicalStages.Add(lPSAlfalfaV11);
                context.PhenologicalStages.Add(lPSAlfalfaV12);
                context.PhenologicalStages.Add(lPSAlfalfaV13);
                context.PhenologicalStages.Add(lPSAlfalfaV14);
                context.PhenologicalStages.Add(lPSAlfalfaV15);
                context.PhenologicalStages.Add(lPSAlfalfaV16);
                context.PhenologicalStages.Add(lPSAlfalfaV17);
                context.PhenologicalStages.Add(lPSAlfalfaVt);
                context.PhenologicalStages.Add(lPSAlfalfaR1);
                context.PhenologicalStages.Add(lPSAlfalfaR2);
                context.PhenologicalStages.Add(lPSAlfalfaR3);
                context.PhenologicalStages.Add(lPSAlfalfaR4);
                context.PhenologicalStages.Add(lPSAlfalfaR5);
                context.PhenologicalStages.Add(lPSAlfalfaR6);
                context.PhenologicalStages.Add(lPSAlfalfaR7);
                context.PhenologicalStages.Add(lPSAlfalfaR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesAlfalfaNorthMedium_2018()
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

                #region Alfalfa
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieAlfalfaNorthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V0") select stage).FirstOrDefault();
                var lPSAlfalfaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " VE") select stage).FirstOrDefault();
                var lPSAlfalfaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V1") select stage).FirstOrDefault();
                var lPSAlfalfaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V2") select stage).FirstOrDefault();
                var lPSAlfalfaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V3") select stage).FirstOrDefault();
                var lPSAlfalfaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V4") select stage).FirstOrDefault();
                var lPSAlfalfaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V5") select stage).FirstOrDefault();
                var lPSAlfalfaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V6") select stage).FirstOrDefault();
                var lPSAlfalfaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V7") select stage).FirstOrDefault();
                var lPSAlfalfaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V8") select stage).FirstOrDefault();
                var lPSAlfalfaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V9") select stage).FirstOrDefault();
                var lPSAlfalfaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V10") select stage).FirstOrDefault();
                var lPSAlfalfaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V11") select stage).FirstOrDefault();
                var lPSAlfalfaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V12") select stage).FirstOrDefault();
                var lPSAlfalfaV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V13") select stage).FirstOrDefault();
                var lPSAlfalfaV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V14") select stage).FirstOrDefault();
                var lPSAlfalfaV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V15") select stage).FirstOrDefault();
                var lPSAlfalfaV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V16") select stage).FirstOrDefault();
                var lPSAlfalfaV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " V17") select stage).FirstOrDefault();
                var lPSAlfalfaV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " VT") select stage).FirstOrDefault();
                var lPSAlfalfaVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R1") select stage).FirstOrDefault();
                var lPSAlfalfaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R2") select stage).FirstOrDefault();
                var lPSAlfalfaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R3") select stage).FirstOrDefault();
                var lPSAlfalfaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R4") select stage).FirstOrDefault();
                var lPSAlfalfaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R5") select stage).FirstOrDefault();
                var lPSAlfalfaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R6") select stage).FirstOrDefault();
                var lPSAlfalfaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R7") select stage).FirstOrDefault();
                var lPSAlfalfaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesAlfalfa + " R8") select stage).FirstOrDefault();
                var lPSAlfalfaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - Alfalfa
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSAlfalfaV0);
                context.PhenologicalStages.Add(lPSAlfalfaVe);
                context.PhenologicalStages.Add(lPSAlfalfaV1);
                context.PhenologicalStages.Add(lPSAlfalfaV2);
                context.PhenologicalStages.Add(lPSAlfalfaV3);
                context.PhenologicalStages.Add(lPSAlfalfaV4);
                context.PhenologicalStages.Add(lPSAlfalfaV5);
                context.PhenologicalStages.Add(lPSAlfalfaV6);
                context.PhenologicalStages.Add(lPSAlfalfaV7);
                context.PhenologicalStages.Add(lPSAlfalfaV8);
                context.PhenologicalStages.Add(lPSAlfalfaV9);
                context.PhenologicalStages.Add(lPSAlfalfaV10);
                context.PhenologicalStages.Add(lPSAlfalfaV11);
                context.PhenologicalStages.Add(lPSAlfalfaV12);
                context.PhenologicalStages.Add(lPSAlfalfaV13);
                context.PhenologicalStages.Add(lPSAlfalfaV14);
                context.PhenologicalStages.Add(lPSAlfalfaV15);
                context.PhenologicalStages.Add(lPSAlfalfaV16);
                context.PhenologicalStages.Add(lPSAlfalfaV17);
                context.PhenologicalStages.Add(lPSAlfalfaVt);
                context.PhenologicalStages.Add(lPSAlfalfaR1);
                context.PhenologicalStages.Add(lPSAlfalfaR2);
                context.PhenologicalStages.Add(lPSAlfalfaR3);
                context.PhenologicalStages.Add(lPSAlfalfaR4);
                context.PhenologicalStages.Add(lPSAlfalfaR5);
                context.PhenologicalStages.Add(lPSAlfalfaR6);
                context.PhenologicalStages.Add(lPSAlfalfaR7);
                context.PhenologicalStages.Add(lPSAlfalfaR8);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesSudanGrassSouthShort_2018()
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

                #region SudanGrass
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieSudanGrassSouthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V0") select stage).FirstOrDefault();
                var lPSSudanGrassV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 159.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " VE") select stage).FirstOrDefault();
                var lPSSudanGrassVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 160, MaxDegree = 309.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V1") select stage).FirstOrDefault();
                var lPSSudanGrassV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 310, MaxDegree = 434.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V2") select stage).FirstOrDefault();
                var lPSSudanGrassV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 435, MaxDegree = 569.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V3") select stage).FirstOrDefault();
                var lPSSudanGrassV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 570, MaxDegree = 709.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V4") select stage).FirstOrDefault();
                var lPSSudanGrassV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 710, MaxDegree = 849.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V5") select stage).FirstOrDefault();
                var lPSSudanGrassV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 850, MaxDegree = 989.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V6") select stage).FirstOrDefault();
                var lPSSudanGrassV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 990, MaxDegree = 1134.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V7") select stage).FirstOrDefault();
                var lPSSudanGrassV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1135, MaxDegree = 1279.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V8") select stage).FirstOrDefault();
                var lPSSudanGrassV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1280, MaxDegree = 1419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V9") select stage).FirstOrDefault();
                var lPSSudanGrassV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1420, MaxDegree = 1559.999, Coefficient = 0.70, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V10") select stage).FirstOrDefault();
                var lPSSudanGrassV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1560, MaxDegree = 1694.999, Coefficient = 0.70, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V11") select stage).FirstOrDefault();
                var lPSSudanGrassV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1695, MaxDegree = 1829.999, Coefficient = 0.70, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V12") select stage).FirstOrDefault();
                var lPSSudanGrassV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1830, MaxDegree = 1954.999, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V13") select stage).FirstOrDefault();
                var lPSSudanGrassV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1955, MaxDegree = 2079.999, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V14") select stage).FirstOrDefault();
                var lPSSudanGrassV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2080, MaxDegree = 2229.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V15") select stage).FirstOrDefault();
                var lPSSudanGrassV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2230, MaxDegree = 2379.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V16") select stage).FirstOrDefault();
                var lPSSudanGrassV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2380, MaxDegree = 2529.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V17") select stage).FirstOrDefault();
                var lPSSudanGrassV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2530, MaxDegree = 2679.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R1") select stage).FirstOrDefault();
                var lPSSudanGrassR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2680, MaxDegree = 2799.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R2") select stage).FirstOrDefault();
                var lPSSudanGrassR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2800, MaxDegree = 2929.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R3") select stage).FirstOrDefault();
                var lPSSudanGrassR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2930, MaxDegree = 3039.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R4") select stage).FirstOrDefault();
                var lPSSudanGrassR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3140, MaxDegree = 3299.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R5") select stage).FirstOrDefault();
                var lPSSudanGrassR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3300, MaxDegree = 3449.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R6") select stage).FirstOrDefault();
                var lPSSudanGrassR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3450, MaxDegree = 4599.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R7") select stage).FirstOrDefault();
                var lPSSudanGrassR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 4600, MaxDegree = 5599.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R8") select stage).FirstOrDefault();
                var lPSSudanGrassR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 5600, MaxDegree = 6600, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - SudanGrass
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSSudanGrassV0);
                context.PhenologicalStages.Add(lPSSudanGrassVe);
                context.PhenologicalStages.Add(lPSSudanGrassV1);
                context.PhenologicalStages.Add(lPSSudanGrassV2);
                context.PhenologicalStages.Add(lPSSudanGrassV3);
                context.PhenologicalStages.Add(lPSSudanGrassV4);
                context.PhenologicalStages.Add(lPSSudanGrassV5);
                context.PhenologicalStages.Add(lPSSudanGrassV6);
                context.PhenologicalStages.Add(lPSSudanGrassV7);
                context.PhenologicalStages.Add(lPSSudanGrassV8);
                context.PhenologicalStages.Add(lPSSudanGrassV9);
                context.PhenologicalStages.Add(lPSSudanGrassV10);
                context.PhenologicalStages.Add(lPSSudanGrassV11);
                context.PhenologicalStages.Add(lPSSudanGrassV12);
                context.PhenologicalStages.Add(lPSSudanGrassV13);
                context.PhenologicalStages.Add(lPSSudanGrassV14);
                context.PhenologicalStages.Add(lPSSudanGrassV15);
                context.PhenologicalStages.Add(lPSSudanGrassV16);
                context.PhenologicalStages.Add(lPSSudanGrassV17);
                context.PhenologicalStages.Add(lPSSudanGrassR1);
                context.PhenologicalStages.Add(lPSSudanGrassR2);
                context.PhenologicalStages.Add(lPSSudanGrassR3);
                context.PhenologicalStages.Add(lPSSudanGrassR4);
                context.PhenologicalStages.Add(lPSSudanGrassR5);
                context.PhenologicalStages.Add(lPSSudanGrassR6);
                context.PhenologicalStages.Add(lPSSudanGrassR7);
                context.PhenologicalStages.Add(lPSSudanGrassR8);
                context.SaveChanges();
                #endregion

            };
        }
        public static void InsertPhenologicalStagesSudanGrassSouthMedium_2018()
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

                #region SudanGrass
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieSudanGrassSouthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V0") select stage).FirstOrDefault();
                var lPSSudanGrassV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " VE") select stage).FirstOrDefault();
                var lPSSudanGrassVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V1") select stage).FirstOrDefault();
                var lPSSudanGrassV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V2") select stage).FirstOrDefault();
                var lPSSudanGrassV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V3") select stage).FirstOrDefault();
                var lPSSudanGrassV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V4") select stage).FirstOrDefault();
                var lPSSudanGrassV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V5") select stage).FirstOrDefault();
                var lPSSudanGrassV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V6") select stage).FirstOrDefault();
                var lPSSudanGrassV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V7") select stage).FirstOrDefault();
                var lPSSudanGrassV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V8") select stage).FirstOrDefault();
                var lPSSudanGrassV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V9") select stage).FirstOrDefault();
                var lPSSudanGrassV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V10") select stage).FirstOrDefault();
                var lPSSudanGrassV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V11") select stage).FirstOrDefault();
                var lPSSudanGrassV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V12") select stage).FirstOrDefault();
                var lPSSudanGrassV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V13") select stage).FirstOrDefault();
                var lPSSudanGrassV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V14") select stage).FirstOrDefault();
                var lPSSudanGrassV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V15") select stage).FirstOrDefault();
                var lPSSudanGrassV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V16") select stage).FirstOrDefault();
                var lPSSudanGrassV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V17") select stage).FirstOrDefault();
                var lPSSudanGrassV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " VT") select stage).FirstOrDefault();
                var lPSSudanGrassVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R1") select stage).FirstOrDefault();
                var lPSSudanGrassR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R2") select stage).FirstOrDefault();
                var lPSSudanGrassR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R3") select stage).FirstOrDefault();
                var lPSSudanGrassR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R4") select stage).FirstOrDefault();
                var lPSSudanGrassR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R5") select stage).FirstOrDefault();
                var lPSSudanGrassR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R6") select stage).FirstOrDefault();
                var lPSSudanGrassR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R7") select stage).FirstOrDefault();
                var lPSSudanGrassR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R8") select stage).FirstOrDefault();
                var lPSSudanGrassR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - SudanGrass
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSSudanGrassV0);
                context.PhenologicalStages.Add(lPSSudanGrassVe);
                context.PhenologicalStages.Add(lPSSudanGrassV1);
                context.PhenologicalStages.Add(lPSSudanGrassV2);
                context.PhenologicalStages.Add(lPSSudanGrassV3);
                context.PhenologicalStages.Add(lPSSudanGrassV4);
                context.PhenologicalStages.Add(lPSSudanGrassV5);
                context.PhenologicalStages.Add(lPSSudanGrassV6);
                context.PhenologicalStages.Add(lPSSudanGrassV7);
                context.PhenologicalStages.Add(lPSSudanGrassV8);
                context.PhenologicalStages.Add(lPSSudanGrassV9);
                context.PhenologicalStages.Add(lPSSudanGrassV10);
                context.PhenologicalStages.Add(lPSSudanGrassV11);
                context.PhenologicalStages.Add(lPSSudanGrassV12);
                context.PhenologicalStages.Add(lPSSudanGrassV13);
                context.PhenologicalStages.Add(lPSSudanGrassV14);
                context.PhenologicalStages.Add(lPSSudanGrassV15);
                context.PhenologicalStages.Add(lPSSudanGrassV16);
                context.PhenologicalStages.Add(lPSSudanGrassV17);
                context.PhenologicalStages.Add(lPSSudanGrassVt);
                context.PhenologicalStages.Add(lPSSudanGrassR1);
                context.PhenologicalStages.Add(lPSSudanGrassR2);
                context.PhenologicalStages.Add(lPSSudanGrassR3);
                context.PhenologicalStages.Add(lPSSudanGrassR4);
                context.PhenologicalStages.Add(lPSSudanGrassR5);
                context.PhenologicalStages.Add(lPSSudanGrassR6);
                context.PhenologicalStages.Add(lPSSudanGrassR7);
                context.PhenologicalStages.Add(lPSSudanGrassR8);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesSudanGrassNorthShort_2018()
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

                #region SudanGrass
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieSudanGrassNorthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V0") select stage).FirstOrDefault();
                var lPSSudanGrassV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " VE") select stage).FirstOrDefault();
                var lPSSudanGrassVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V1") select stage).FirstOrDefault();
                var lPSSudanGrassV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V2") select stage).FirstOrDefault();
                var lPSSudanGrassV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V3") select stage).FirstOrDefault();
                var lPSSudanGrassV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V4") select stage).FirstOrDefault();
                var lPSSudanGrassV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V5") select stage).FirstOrDefault();
                var lPSSudanGrassV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V6") select stage).FirstOrDefault();
                var lPSSudanGrassV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V7") select stage).FirstOrDefault();
                var lPSSudanGrassV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V8") select stage).FirstOrDefault();
                var lPSSudanGrassV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V9") select stage).FirstOrDefault();
                var lPSSudanGrassV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V10") select stage).FirstOrDefault();
                var lPSSudanGrassV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V11") select stage).FirstOrDefault();
                var lPSSudanGrassV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V12") select stage).FirstOrDefault();
                var lPSSudanGrassV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V13") select stage).FirstOrDefault();
                var lPSSudanGrassV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V14") select stage).FirstOrDefault();
                var lPSSudanGrassV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V15") select stage).FirstOrDefault();
                var lPSSudanGrassV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V16") select stage).FirstOrDefault();
                var lPSSudanGrassV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V17") select stage).FirstOrDefault();
                var lPSSudanGrassV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " VT") select stage).FirstOrDefault();
                var lPSSudanGrassVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R1") select stage).FirstOrDefault();
                var lPSSudanGrassR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R2") select stage).FirstOrDefault();
                var lPSSudanGrassR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R3") select stage).FirstOrDefault();
                var lPSSudanGrassR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R4") select stage).FirstOrDefault();
                var lPSSudanGrassR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R5") select stage).FirstOrDefault();
                var lPSSudanGrassR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R6") select stage).FirstOrDefault();
                var lPSSudanGrassR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R7") select stage).FirstOrDefault();
                var lPSSudanGrassR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R8") select stage).FirstOrDefault();
                var lPSSudanGrassR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - SudanGrass
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSSudanGrassV0);
                context.PhenologicalStages.Add(lPSSudanGrassVe);
                context.PhenologicalStages.Add(lPSSudanGrassV1);
                context.PhenologicalStages.Add(lPSSudanGrassV2);
                context.PhenologicalStages.Add(lPSSudanGrassV3);
                context.PhenologicalStages.Add(lPSSudanGrassV4);
                context.PhenologicalStages.Add(lPSSudanGrassV5);
                context.PhenologicalStages.Add(lPSSudanGrassV6);
                context.PhenologicalStages.Add(lPSSudanGrassV7);
                context.PhenologicalStages.Add(lPSSudanGrassV8);
                context.PhenologicalStages.Add(lPSSudanGrassV9);
                context.PhenologicalStages.Add(lPSSudanGrassV10);
                context.PhenologicalStages.Add(lPSSudanGrassV11);
                context.PhenologicalStages.Add(lPSSudanGrassV12);
                context.PhenologicalStages.Add(lPSSudanGrassV13);
                context.PhenologicalStages.Add(lPSSudanGrassV14);
                context.PhenologicalStages.Add(lPSSudanGrassV15);
                context.PhenologicalStages.Add(lPSSudanGrassV16);
                context.PhenologicalStages.Add(lPSSudanGrassV17);
                context.PhenologicalStages.Add(lPSSudanGrassVt);
                context.PhenologicalStages.Add(lPSSudanGrassR1);
                context.PhenologicalStages.Add(lPSSudanGrassR2);
                context.PhenologicalStages.Add(lPSSudanGrassR3);
                context.PhenologicalStages.Add(lPSSudanGrassR4);
                context.PhenologicalStages.Add(lPSSudanGrassR5);
                context.PhenologicalStages.Add(lPSSudanGrassR6);
                context.PhenologicalStages.Add(lPSSudanGrassR7);
                context.PhenologicalStages.Add(lPSSudanGrassR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesSudanGrassNorthMedium_2018()
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

                #region SudanGrass
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieSudanGrassNorthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V0") select stage).FirstOrDefault();
                var lPSSudanGrassV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " VE") select stage).FirstOrDefault();
                var lPSSudanGrassVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V1") select stage).FirstOrDefault();
                var lPSSudanGrassV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V2") select stage).FirstOrDefault();
                var lPSSudanGrassV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V3") select stage).FirstOrDefault();
                var lPSSudanGrassV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V4") select stage).FirstOrDefault();
                var lPSSudanGrassV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V5") select stage).FirstOrDefault();
                var lPSSudanGrassV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V6") select stage).FirstOrDefault();
                var lPSSudanGrassV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V7") select stage).FirstOrDefault();
                var lPSSudanGrassV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V8") select stage).FirstOrDefault();
                var lPSSudanGrassV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V9") select stage).FirstOrDefault();
                var lPSSudanGrassV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V10") select stage).FirstOrDefault();
                var lPSSudanGrassV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V11") select stage).FirstOrDefault();
                var lPSSudanGrassV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V12") select stage).FirstOrDefault();
                var lPSSudanGrassV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 530, MaxDegree = 554.999, Coefficient = 1.00, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V13") select stage).FirstOrDefault();
                var lPSSudanGrassV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 555, MaxDegree = 579.999, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V14") select stage).FirstOrDefault();
                var lPSSudanGrassV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V15") select stage).FirstOrDefault();
                var lPSSudanGrassV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V16") select stage).FirstOrDefault();
                var lPSSudanGrassV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " V17") select stage).FirstOrDefault();
                var lPSSudanGrassV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 0, Coefficient = 1.05, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = false, DegreesDaysInterval = 25 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " VT") select stage).FirstOrDefault();
                var lPSSudanGrassVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 580, MaxDegree = 679.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 100 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R1") select stage).FirstOrDefault();
                var lPSSudanGrassR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R2") select stage).FirstOrDefault();
                var lPSSudanGrassR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R3") select stage).FirstOrDefault();
                var lPSSudanGrassR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R4") select stage).FirstOrDefault();
                var lPSSudanGrassR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R5") select stage).FirstOrDefault();
                var lPSSudanGrassR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R6") select stage).FirstOrDefault();
                var lPSSudanGrassR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R7") select stage).FirstOrDefault();
                var lPSSudanGrassR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSudanGrass + " R8") select stage).FirstOrDefault();
                var lPSSudanGrassR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - SudanGrass
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSSudanGrassV0);
                context.PhenologicalStages.Add(lPSSudanGrassVe);
                context.PhenologicalStages.Add(lPSSudanGrassV1);
                context.PhenologicalStages.Add(lPSSudanGrassV2);
                context.PhenologicalStages.Add(lPSSudanGrassV3);
                context.PhenologicalStages.Add(lPSSudanGrassV4);
                context.PhenologicalStages.Add(lPSSudanGrassV5);
                context.PhenologicalStages.Add(lPSSudanGrassV6);
                context.PhenologicalStages.Add(lPSSudanGrassV7);
                context.PhenologicalStages.Add(lPSSudanGrassV8);
                context.PhenologicalStages.Add(lPSSudanGrassV9);
                context.PhenologicalStages.Add(lPSSudanGrassV10);
                context.PhenologicalStages.Add(lPSSudanGrassV11);
                context.PhenologicalStages.Add(lPSSudanGrassV12);
                context.PhenologicalStages.Add(lPSSudanGrassV13);
                context.PhenologicalStages.Add(lPSSudanGrassV14);
                context.PhenologicalStages.Add(lPSSudanGrassV15);
                context.PhenologicalStages.Add(lPSSudanGrassV16);
                context.PhenologicalStages.Add(lPSSudanGrassV17);
                context.PhenologicalStages.Add(lPSSudanGrassVt);
                context.PhenologicalStages.Add(lPSSudanGrassR1);
                context.PhenologicalStages.Add(lPSSudanGrassR2);
                context.PhenologicalStages.Add(lPSSudanGrassR3);
                context.PhenologicalStages.Add(lPSSudanGrassR4);
                context.PhenologicalStages.Add(lPSSudanGrassR5);
                context.PhenologicalStages.Add(lPSSudanGrassR6);
                context.PhenologicalStages.Add(lPSSudanGrassR7);
                context.PhenologicalStages.Add(lPSSudanGrassR8);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesFescueForageSouthShort_2018()
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

                #region FescueForage
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieFescueForageSouthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V0") select stage).FirstOrDefault();
                var lPSFescueForageV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 159.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " VE") select stage).FirstOrDefault();
                var lPSFescueForageVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 160, MaxDegree = 309.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V1") select stage).FirstOrDefault();
                var lPSFescueForageV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 310, MaxDegree = 434.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V2") select stage).FirstOrDefault();
                var lPSFescueForageV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 435, MaxDegree = 569.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V3") select stage).FirstOrDefault();
                var lPSFescueForageV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 570, MaxDegree = 709.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V4") select stage).FirstOrDefault();
                var lPSFescueForageV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 710, MaxDegree = 849.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V5") select stage).FirstOrDefault();
                var lPSFescueForageV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 850, MaxDegree = 989.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V6") select stage).FirstOrDefault();
                var lPSFescueForageV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 990, MaxDegree = 1134.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V7") select stage).FirstOrDefault();
                var lPSFescueForageV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1135, MaxDegree = 1279.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V8") select stage).FirstOrDefault();
                var lPSFescueForageV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1280, MaxDegree = 1419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V9") select stage).FirstOrDefault();
                var lPSFescueForageV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1420, MaxDegree = 1559.999, Coefficient = 0.70, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V10") select stage).FirstOrDefault();
                var lPSFescueForageV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1560, MaxDegree = 1694.999, Coefficient = 0.70, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V11") select stage).FirstOrDefault();
                var lPSFescueForageV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1695, MaxDegree = 1829.999, Coefficient = 0.70, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V12") select stage).FirstOrDefault();
                var lPSFescueForageV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1830, MaxDegree = 1954.999, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V13") select stage).FirstOrDefault();
                var lPSFescueForageV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1955, MaxDegree = 2079.999, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V14") select stage).FirstOrDefault();
                var lPSFescueForageV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2080, MaxDegree = 2229.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V15") select stage).FirstOrDefault();
                var lPSFescueForageV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2230, MaxDegree = 2379.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V16") select stage).FirstOrDefault();
                var lPSFescueForageV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2380, MaxDegree = 2529.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V17") select stage).FirstOrDefault();
                var lPSFescueForageV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2530, MaxDegree = 2679.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R1") select stage).FirstOrDefault();
                var lPSFescueForageR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2680, MaxDegree = 2799.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R2") select stage).FirstOrDefault();
                var lPSFescueForageR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2800, MaxDegree = 2929.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R3") select stage).FirstOrDefault();
                var lPSFescueForageR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2930, MaxDegree = 3039.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R4") select stage).FirstOrDefault();
                var lPSFescueForageR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3140, MaxDegree = 3299.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R5") select stage).FirstOrDefault();
                var lPSFescueForageR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3300, MaxDegree = 3449.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R6") select stage).FirstOrDefault();
                var lPSFescueForageR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3450, MaxDegree = 4599.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R7") select stage).FirstOrDefault();
                var lPSFescueForageR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 4600, MaxDegree = 5599.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R8") select stage).FirstOrDefault();
                var lPSFescueForageR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 5600, MaxDegree = 6600, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - FescueForage
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSFescueForageV0);
                context.PhenologicalStages.Add(lPSFescueForageVe);
                context.PhenologicalStages.Add(lPSFescueForageV1);
                context.PhenologicalStages.Add(lPSFescueForageV2);
                context.PhenologicalStages.Add(lPSFescueForageV3);
                context.PhenologicalStages.Add(lPSFescueForageV4);
                context.PhenologicalStages.Add(lPSFescueForageV5);
                context.PhenologicalStages.Add(lPSFescueForageV6);
                context.PhenologicalStages.Add(lPSFescueForageV7);
                context.PhenologicalStages.Add(lPSFescueForageV8);
                context.PhenologicalStages.Add(lPSFescueForageV9);
                context.PhenologicalStages.Add(lPSFescueForageV10);
                context.PhenologicalStages.Add(lPSFescueForageV11);
                context.PhenologicalStages.Add(lPSFescueForageV12);
                context.PhenologicalStages.Add(lPSFescueForageV13);
                context.PhenologicalStages.Add(lPSFescueForageV14);
                context.PhenologicalStages.Add(lPSFescueForageV15);
                context.PhenologicalStages.Add(lPSFescueForageV16);
                context.PhenologicalStages.Add(lPSFescueForageV17);
                context.PhenologicalStages.Add(lPSFescueForageR1);
                context.PhenologicalStages.Add(lPSFescueForageR2);
                context.PhenologicalStages.Add(lPSFescueForageR3);
                context.PhenologicalStages.Add(lPSFescueForageR4);
                context.PhenologicalStages.Add(lPSFescueForageR5);
                context.PhenologicalStages.Add(lPSFescueForageR6);
                context.PhenologicalStages.Add(lPSFescueForageR7);
                context.PhenologicalStages.Add(lPSFescueForageR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesFescueForageSouthMedium_2018()
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

                #region FescueForage
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieFescueForageSouthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V0") select stage).FirstOrDefault();
                var lPSFescueForageV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 159.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " VE") select stage).FirstOrDefault();
                var lPSFescueForageVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 160, MaxDegree = 309.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V1") select stage).FirstOrDefault();
                var lPSFescueForageV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 310, MaxDegree = 434.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V2") select stage).FirstOrDefault();
                var lPSFescueForageV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 435, MaxDegree = 569.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V3") select stage).FirstOrDefault();
                var lPSFescueForageV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 570, MaxDegree = 709.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V4") select stage).FirstOrDefault();
                var lPSFescueForageV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 710, MaxDegree = 849.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V5") select stage).FirstOrDefault();
                var lPSFescueForageV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 850, MaxDegree = 989.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V6") select stage).FirstOrDefault();
                var lPSFescueForageV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 990, MaxDegree = 1134.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V7") select stage).FirstOrDefault();
                var lPSFescueForageV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1135, MaxDegree = 1279.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V8") select stage).FirstOrDefault();
                var lPSFescueForageV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1280, MaxDegree = 1419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V9") select stage).FirstOrDefault();
                var lPSFescueForageV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1420, MaxDegree = 1559.999, Coefficient = 0.70, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V10") select stage).FirstOrDefault();
                var lPSFescueForageV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1560, MaxDegree = 1694.999, Coefficient = 0.70, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V11") select stage).FirstOrDefault();
                var lPSFescueForageV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1695, MaxDegree = 1829.999, Coefficient = 0.70, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V12") select stage).FirstOrDefault();
                var lPSFescueForageV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1830, MaxDegree = 1954.999, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V13") select stage).FirstOrDefault();
                var lPSFescueForageV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1955, MaxDegree = 2079.999, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V14") select stage).FirstOrDefault();
                var lPSFescueForageV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2080, MaxDegree = 2229.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V15") select stage).FirstOrDefault();
                var lPSFescueForageV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2230, MaxDegree = 2379.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V16") select stage).FirstOrDefault();
                var lPSFescueForageV16 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2380, MaxDegree = 2529.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V17") select stage).FirstOrDefault();
                var lPSFescueForageV17 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2530, MaxDegree = 2679.99, Coefficient = 0.70, RootDepth = 40, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };


                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R1") select stage).FirstOrDefault();
                var lPSFescueForageR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2680, MaxDegree = 2799.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R2") select stage).FirstOrDefault();
                var lPSFescueForageR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2800, MaxDegree = 2929.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R3") select stage).FirstOrDefault();
                var lPSFescueForageR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2930, MaxDegree = 3039.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R4") select stage).FirstOrDefault();
                var lPSFescueForageR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3140, MaxDegree = 3299.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R5") select stage).FirstOrDefault();
                var lPSFescueForageR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3300, MaxDegree = 3449.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R6") select stage).FirstOrDefault();
                var lPSFescueForageR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3450, MaxDegree = 4599.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R7") select stage).FirstOrDefault();
                var lPSFescueForageR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 4600, MaxDegree = 5599.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R8") select stage).FirstOrDefault();
                var lPSFescueForageR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 5600, MaxDegree = 6600, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - FescueForage
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSFescueForageV0);
                context.PhenologicalStages.Add(lPSFescueForageVe);
                context.PhenologicalStages.Add(lPSFescueForageV1);
                context.PhenologicalStages.Add(lPSFescueForageV2);
                context.PhenologicalStages.Add(lPSFescueForageV3);
                context.PhenologicalStages.Add(lPSFescueForageV4);
                context.PhenologicalStages.Add(lPSFescueForageV5);
                context.PhenologicalStages.Add(lPSFescueForageV6);
                context.PhenologicalStages.Add(lPSFescueForageV7);
                context.PhenologicalStages.Add(lPSFescueForageV8);
                context.PhenologicalStages.Add(lPSFescueForageV9);
                context.PhenologicalStages.Add(lPSFescueForageV10);
                context.PhenologicalStages.Add(lPSFescueForageV11);
                context.PhenologicalStages.Add(lPSFescueForageR1);
                context.PhenologicalStages.Add(lPSFescueForageR2);
                context.PhenologicalStages.Add(lPSFescueForageR3);
                context.PhenologicalStages.Add(lPSFescueForageR4);
                context.PhenologicalStages.Add(lPSFescueForageR5);
                context.PhenologicalStages.Add(lPSFescueForageR6);
                context.PhenologicalStages.Add(lPSFescueForageR7);
                context.PhenologicalStages.Add(lPSFescueForageR8);
                context.SaveChanges();
                #endregion
            };
        }

        public static void InsertPhenologicalStagesFescueForageNorthShort_2018()
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

                #region FescueForage
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieFescueForageNorthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V0") select stage).FirstOrDefault();
                var lPSFescueForageV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 159.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " VE") select stage).FirstOrDefault();
                var lPSFescueForageVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 160, MaxDegree = 309.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V1") select stage).FirstOrDefault();
                var lPSFescueForageV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 310, MaxDegree = 434.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 125 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V2") select stage).FirstOrDefault();
                var lPSFescueForageV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 435, MaxDegree = 569.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V3") select stage).FirstOrDefault();
                var lPSFescueForageV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 570, MaxDegree = 709.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V4") select stage).FirstOrDefault();
                var lPSFescueForageV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 710, MaxDegree = 849.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V5") select stage).FirstOrDefault();
                var lPSFescueForageV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 850, MaxDegree = 989.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V6") select stage).FirstOrDefault();
                var lPSFescueForageV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 990, MaxDegree = 1134.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V7") select stage).FirstOrDefault();
                var lPSFescueForageV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1135, MaxDegree = 1279.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 145 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V8") select stage).FirstOrDefault();
                var lPSFescueForageV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1280, MaxDegree = 1419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V9") select stage).FirstOrDefault();
                var lPSFescueForageV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1420, MaxDegree = 1559.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 140 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V10") select stage).FirstOrDefault();
                var lPSFescueForageV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1560, MaxDegree = 1694.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V11") select stage).FirstOrDefault();
                var lPSFescueForageV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1695, MaxDegree = 1729.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 135 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R1") select stage).FirstOrDefault();
                var lPSFescueForageR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1780, MaxDegree = 1999.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R2") select stage).FirstOrDefault();
                var lPSFescueForageR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1900, MaxDegree = 2029.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R3") select stage).FirstOrDefault();
                var lPSFescueForageR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2030, MaxDegree = 2139.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R4") select stage).FirstOrDefault();
                var lPSFescueForageR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2140, MaxDegree = 2299.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R5") select stage).FirstOrDefault();
                var lPSFescueForageR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2300, MaxDegree = 2449.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R6") select stage).FirstOrDefault();
                var lPSFescueForageR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2450, MaxDegree = 2599.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R7") select stage).FirstOrDefault();
                var lPSFescueForageR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2600, MaxDegree = 3599.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R8") select stage).FirstOrDefault();
                var lPSFescueForageR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 3600, MaxDegree = 4600, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - FescueForage
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSFescueForageV0);
                context.PhenologicalStages.Add(lPSFescueForageVe);
                context.PhenologicalStages.Add(lPSFescueForageV1);
                context.PhenologicalStages.Add(lPSFescueForageV2);
                context.PhenologicalStages.Add(lPSFescueForageV3);
                context.PhenologicalStages.Add(lPSFescueForageV4);
                context.PhenologicalStages.Add(lPSFescueForageV5);
                context.PhenologicalStages.Add(lPSFescueForageV6);
                context.PhenologicalStages.Add(lPSFescueForageV7);
                context.PhenologicalStages.Add(lPSFescueForageV8);
                context.PhenologicalStages.Add(lPSFescueForageV9);
                context.PhenologicalStages.Add(lPSFescueForageV10);
                context.PhenologicalStages.Add(lPSFescueForageV11);
                context.PhenologicalStages.Add(lPSFescueForageR1);
                context.PhenologicalStages.Add(lPSFescueForageR2);
                context.PhenologicalStages.Add(lPSFescueForageR3);
                context.PhenologicalStages.Add(lPSFescueForageR4);
                context.PhenologicalStages.Add(lPSFescueForageR5);
                context.PhenologicalStages.Add(lPSFescueForageR6);
                context.PhenologicalStages.Add(lPSFescueForageR7);
                context.PhenologicalStages.Add(lPSFescueForageR8);
                context.SaveChanges();
                #endregion
            };
        }
        public static void InsertPhenologicalStagesFescueForageNorthMedium_2018()
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

                #region FescueForage
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieFescueForageNorthMedium) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V0") select stage).FirstOrDefault();
                var lPSFescueForageV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 60 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " VE") select stage).FirstOrDefault();
                var lPSFescueForageVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 109.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 50 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V1") select stage).FirstOrDefault();
                var lPSFescueForageV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 110, MaxDegree = 134.999, Coefficient = 0.35, RootDepth = 5, HydricBalanceDepth = 15, PhenologicalStageIsUsed = true, DegreesDaysInterval = 25 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V2") select stage).FirstOrDefault();
                var lPSFescueForageV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 135, MaxDegree = 169.999, Coefficient = 0.35, RootDepth = 10, HydricBalanceDepth = 20, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V3") select stage).FirstOrDefault();
                var lPSFescueForageV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 170, MaxDegree = 209.999, Coefficient = 0.38, RootDepth = 15, HydricBalanceDepth = 25, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V4") select stage).FirstOrDefault();
                var lPSFescueForageV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 210, MaxDegree = 249.999, Coefficient = 0.40, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V5") select stage).FirstOrDefault();
                var lPSFescueForageV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 250, MaxDegree = 289.999, Coefficient = 0.45, RootDepth = 20, HydricBalanceDepth = 30, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V6") select stage).FirstOrDefault();
                var lPSFescueForageV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 290, MaxDegree = 334.999, Coefficient = 0.50, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V7") select stage).FirstOrDefault();
                var lPSFescueForageV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 335, MaxDegree = 379.999, Coefficient = 0.60, RootDepth = 25, HydricBalanceDepth = 35, PhenologicalStageIsUsed = true, DegreesDaysInterval = 45 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V8") select stage).FirstOrDefault();
                var lPSFescueForageV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 380, MaxDegree = 419.999, Coefficient = 0.70, RootDepth = 30, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V9") select stage).FirstOrDefault();
                var lPSFescueForageV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 420, MaxDegree = 459.999, Coefficient = 0.80, RootDepth = 32, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 40 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V10") select stage).FirstOrDefault();
                var lPSFescueForageV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 460, MaxDegree = 494.999, Coefficient = 0.90, RootDepth = 35, HydricBalanceDepth = 40, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " V11") select stage).FirstOrDefault();
                var lPSFescueForageV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 495, MaxDegree = 529.999, Coefficient = 0.95, RootDepth = 37, HydricBalanceDepth = 42, PhenologicalStageIsUsed = true, DegreesDaysInterval = 35 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R1") select stage).FirstOrDefault();
                var lPSFescueForageR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 680, MaxDegree = 799.999, Coefficient = 1.15, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 120 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R2") select stage).FirstOrDefault();
                var lPSFescueForageR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 800, MaxDegree = 929.999, Coefficient = 1.05, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 130 };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R3") select stage).FirstOrDefault();
                var lPSFescueForageR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 930, MaxDegree = 1039.999, Coefficient = 0.90, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 110 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R4") select stage).FirstOrDefault();
                var lPSFescueForageR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1040, MaxDegree = 1199.999, Coefficient = 0.80, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 160 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R5") select stage).FirstOrDefault();
                var lPSFescueForageR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1200, MaxDegree = 1349.999, Coefficient = 0.70, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R6") select stage).FirstOrDefault();
                var lPSFescueForageR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1350, MaxDegree = 1499.999, Coefficient = 0.65, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 150 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R7") select stage).FirstOrDefault();
                var lPSFescueForageR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1500, MaxDegree = 2499.999, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesFescueForage + " R8") select stage).FirstOrDefault();
                var lPSFescueForageR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2500, MaxDegree = 3500, Coefficient = 0.60, RootDepth = 45, HydricBalanceDepth = 45, PhenologicalStageIsUsed = true, DegreesDaysInterval = 1000 };

                #endregion

                #region Add to Context - FescueForage
                //context.PhenologicalStages.Add(lBase);
                context.PhenologicalStages.Add(lPSFescueForageV0);
                context.PhenologicalStages.Add(lPSFescueForageVe);
                context.PhenologicalStages.Add(lPSFescueForageV1);
                context.PhenologicalStages.Add(lPSFescueForageV2);
                context.PhenologicalStages.Add(lPSFescueForageV3);
                context.PhenologicalStages.Add(lPSFescueForageV4);
                context.PhenologicalStages.Add(lPSFescueForageV5);
                context.PhenologicalStages.Add(lPSFescueForageV6);
                context.PhenologicalStages.Add(lPSFescueForageV7);
                context.PhenologicalStages.Add(lPSFescueForageV8);
                context.PhenologicalStages.Add(lPSFescueForageV9);
                context.PhenologicalStages.Add(lPSFescueForageV10);
                context.PhenologicalStages.Add(lPSFescueForageV11);
                context.PhenologicalStages.Add(lPSFescueForageR1);
                context.PhenologicalStages.Add(lPSFescueForageR2);
                context.PhenologicalStages.Add(lPSFescueForageR3);
                context.PhenologicalStages.Add(lPSFescueForageR4);
                context.PhenologicalStages.Add(lPSFescueForageR5);
                context.PhenologicalStages.Add(lPSFescueForageR6);
                context.PhenologicalStages.Add(lPSFescueForageR7);
                context.PhenologicalStages.Add(lPSFescueForageR8);
                context.SaveChanges();
                #endregion
            };
        }

        #endregion

        #endregion

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
            #region Crop Coefficient Corn South Medium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieCornSouthMedium)
                           select specie).FirstOrDefault();
                var lCropCoefficientCornSouthMedium = new CropCoefficient
                {
                    Name = Utils.NameSpecieCornSouthMedium,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientCornSouthMedium = InitialTables.CreateUpdateCropCoefficient_CornSouthMedium(lCropCoefficientCornSouthMedium, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientCornSouthMedium);
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
            #region Crop Coefficient Corn North Medium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieCornNorthMedium)
                           select specie).FirstOrDefault();
                var lCropCoefficientCornNorthMedium = new CropCoefficient
                {
                    Name = Utils.NameSpecieCornNorthMedium,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientCornNorthMedium = InitialTables.CreateUpdateCropCoefficient_CornNorthMedium(lCropCoefficientCornNorthMedium, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientCornNorthMedium);
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
            #region Crop Coefficient Soya North Medium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieSoyaNorthMedium)
                           select specie).FirstOrDefault();
                var lCropCoefficientSoyaNorthMedium = new CropCoefficient
                {
                    Name = Utils.NameSpecieSoyaNorthMedium,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientSoyaNorthMedium = InitialTables.CreateUpdateCropCoefficient_SoyaNorthMedium(lCropCoefficientSoyaNorthMedium, 1, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientSoyaNorthMedium);
                context.SaveChanges();
            }
            #endregion


            #region Crop Coefficient Oat South Short
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieOatSouthShort)
                           select specie).FirstOrDefault();
                var lCropCoefficientOatSouthShort = new CropCoefficient
                {
                    Name = Utils.NameSpecieOatSouthShort,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientOatSouthShort = InitialTables.CreateUpdateCropCoefficient_OatSouthShort(lCropCoefficientOatSouthShort, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientOatSouthShort);
                context.SaveChanges();
            }
            #endregion
            #region Crop Coefficient Oat South Medium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieOatSouthMedium)
                           select specie).FirstOrDefault();
                var lCropCoefficientOatSouthMedium = new CropCoefficient
                {
                    Name = Utils.NameSpecieOatSouthMedium,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientOatSouthMedium = InitialTables.CreateUpdateCropCoefficient_OatSouthMedium(lCropCoefficientOatSouthMedium, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientOatSouthMedium);
                context.SaveChanges();
            }
            #endregion
            #region Crop Coefficient Oat North Short
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieOatNorthShort)
                           select specie).FirstOrDefault();
                var lCropCoefficientOatNorthShort = new CropCoefficient
                {
                    Name = Utils.NameSpecieOatNorthShort,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientOatNorthShort = InitialTables.CreateUpdateCropCoefficient_OatNorthShort(lCropCoefficientOatNorthShort, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientOatNorthShort);
                context.SaveChanges();
            }
            #endregion
            #region Crop Coefficient Oat North Medium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieOatNorthMedium)
                           select specie).FirstOrDefault();
                var lCropCoefficientOatNorthMedium = new CropCoefficient
                {
                    Name = Utils.NameSpecieOatNorthMedium,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientOatNorthMedium = InitialTables.CreateUpdateCropCoefficient_OatNorthMedium(lCropCoefficientOatNorthMedium, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientOatNorthMedium);
                context.SaveChanges();
            }
            #endregion

            #region Crop Coefficient Alfalfa South Short
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieAlfalfaSouthShort)
                           select specie).FirstOrDefault();
                var lCropCoefficientAlfalfaSouthShort = new CropCoefficient
                {
                    Name = Utils.NameSpecieAlfalfaSouthShort,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientAlfalfaSouthShort = InitialTables.CreateUpdateCropCoefficient_AlfalfaSouthShort(lCropCoefficientAlfalfaSouthShort, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientAlfalfaSouthShort);
                context.SaveChanges();
            }
            #endregion
            #region Crop Coefficient Alfalfa South Medium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieAlfalfaSouthMedium)
                           select specie).FirstOrDefault();
                var lCropCoefficientAlfalfaSouthMedium = new CropCoefficient
                {
                    Name = Utils.NameSpecieAlfalfaSouthMedium,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientAlfalfaSouthMedium = InitialTables.CreateUpdateCropCoefficient_AlfalfaSouthMedium(lCropCoefficientAlfalfaSouthMedium, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientAlfalfaSouthMedium);
                context.SaveChanges();
            }
            #endregion
            #region Crop Coefficient Alfalfa North Short
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieAlfalfaNorthShort)
                           select specie).FirstOrDefault();
                var lCropCoefficientAlfalfaNorthShort = new CropCoefficient
                {
                    Name = Utils.NameSpecieAlfalfaNorthShort,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientAlfalfaNorthShort = InitialTables.CreateUpdateCropCoefficient_AlfalfaNorthShort(lCropCoefficientAlfalfaNorthShort, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientAlfalfaNorthShort);
                context.SaveChanges();
            }
            #endregion
            #region Crop Coefficient Alfalfa North Medium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieAlfalfaNorthMedium)
                           select specie).FirstOrDefault();
                var lCropCoefficientAlfalfaNorthMedium = new CropCoefficient
                {
                    Name = Utils.NameSpecieAlfalfaNorthMedium,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientAlfalfaNorthMedium = InitialTables.CreateUpdateCropCoefficient_AlfalfaNorthMedium(lCropCoefficientAlfalfaNorthMedium, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientAlfalfaNorthMedium);
                context.SaveChanges();
            }
            #endregion

            #region Crop Coefficient SudanGrass South Short
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieSudanGrassSouthShort)
                           select specie).FirstOrDefault();
                var lCropCoefficientSudanGrassSouthShort = new CropCoefficient
                {
                    Name = Utils.NameSpecieSudanGrassSouthShort,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientSudanGrassSouthShort = InitialTables.CreateUpdateCropCoefficient_SudanGrassSouthShort(lCropCoefficientSudanGrassSouthShort, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientSudanGrassSouthShort);
                context.SaveChanges();
            }
            #endregion
            #region Crop Coefficient SudanGrass South Medium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieSudanGrassSouthMedium)
                           select specie).FirstOrDefault();
                var lCropCoefficientSudanGrassSouthMedium = new CropCoefficient
                {
                    Name = Utils.NameSpecieSudanGrassSouthMedium,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientSudanGrassSouthMedium = InitialTables.CreateUpdateCropCoefficient_SudanGrassSouthMedium(lCropCoefficientSudanGrassSouthMedium, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientSudanGrassSouthMedium);
                context.SaveChanges();
            }
            #endregion
            #region Crop Coefficient SudanGrass North Short
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieSudanGrassNorthShort)
                           select specie).FirstOrDefault();
                var lCropCoefficientSudanGrassNorthShort = new CropCoefficient
                {
                    Name = Utils.NameSpecieSudanGrassNorthShort,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientSudanGrassNorthShort = InitialTables.CreateUpdateCropCoefficient_SudanGrassNorthShort(lCropCoefficientSudanGrassNorthShort, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientSudanGrassNorthShort);
                context.SaveChanges();
            }
            #endregion
            #region Crop Coefficient SudanGrass North Medium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieSudanGrassNorthMedium)
                           select specie).FirstOrDefault();
                var lCropCoefficientSudanGrassNorthMedium = new CropCoefficient
                {
                    Name = Utils.NameSpecieSudanGrassNorthMedium,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientSudanGrassNorthMedium = InitialTables.CreateUpdateCropCoefficient_SudanGrassNorthMedium(lCropCoefficientSudanGrassNorthMedium, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientSudanGrassNorthMedium);
                context.SaveChanges();
            }
            #endregion

            #region Crop Coefficient FescueForage South Short
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieFescueForageSouthShort)
                           select specie).FirstOrDefault();
                var lCropCoefficientFescueForageSouthShort = new CropCoefficient
                {
                    Name = Utils.NameSpecieFescueForageSouthShort,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientFescueForageSouthShort = InitialTables.CreateUpdateCropCoefficient_FescueForageSouthShort(lCropCoefficientFescueForageSouthShort, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientFescueForageSouthShort);
                context.SaveChanges();
            }
            #endregion
            #region Crop Coefficient FescueForage South Medium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieFescueForageSouthMedium)
                           select specie).FirstOrDefault();
                var lCropCoefficientFescueForageSouthMedium = new CropCoefficient
                {
                    Name = Utils.NameSpecieFescueForageSouthMedium,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientFescueForageSouthMedium = InitialTables.CreateUpdateCropCoefficient_FescueForageSouthMedium(lCropCoefficientFescueForageSouthMedium, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientFescueForageSouthMedium);
                context.SaveChanges();
            }
            #endregion
            #region Crop Coefficient FescueForage North Short
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieFescueForageNorthShort)
                           select specie).FirstOrDefault();
                var lCropCoefficientFescueForageNorthShort = new CropCoefficient
                {
                    Name = Utils.NameSpecieFescueForageNorthShort,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientFescueForageNorthShort = InitialTables.CreateUpdateCropCoefficient_FescueForageNorthShort(lCropCoefficientFescueForageNorthShort, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientFescueForageNorthShort);
                context.SaveChanges();
            }
            #endregion
            #region Crop Coefficient FescueForage North Medium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecie = (from specie in context.Species
                           where specie.Name.Contains(Utils.NameSpecieFescueForageNorthMedium)
                           select specie).FirstOrDefault();
                var lCropCoefficientFescueForageNorthMedium = new CropCoefficient
                {
                    Name = Utils.NameSpecieFescueForageNorthMedium,
                    SpecieId = lSpecie.SpecieId,
                    KCList = new List<KC>(),
                };
                lCropCoefficientFescueForageNorthMedium = InitialTables.CreateUpdateCropCoefficient_FescueForageNorthMedium(lCropCoefficientFescueForageNorthMedium, 0, lSpecie);
                context.CropCoefficients.Add(lCropCoefficientFescueForageNorthMedium);
                context.SaveChanges();
            }
            #endregion

        }

#endif
        #endregion

    }
}
