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

using IrrigationAdvisor.DBContext;

using System.Data.Entity;
using System.Security.Cryptography;
using IrrigationAdvisor.ComplementedUtils;

namespace IrrigationAdvisorConsole
{
    public class Program
    {
        public static Utils.IrrigationAdvisorProcessFarm ProcessFarm = Utils.IrrigationAdvisorProcessFarm.Demo;
        
        public static Utils.IrrigationAdvisorOutputFiles PrintFarm = Utils.IrrigationAdvisorOutputFiles.NONE;
        
        static void Main(string[] args)
        {
            try
            {
                //IASystem IASystem = new IrrigationAdvisorConsole.IASystem();

                #if false
                Database.SetInitializer < IrrigationAdvisorContext>
                    (new DropCreateDatabaseIfModelChanges<IrrigationAdvisorContext>());
                #endif

                #if false
                Database.SetInitializer < IrrigationAdvisorContext>
                    (new CreateDatabaseIfNotExists<IrrigationAdvisorContext>());
                #endif
                /*
                 * Changing from DropCreateDatabaseIfModelChanges to DropCreateDatabaseAlways works, 
                 * the latter configuration causes the database to be recreated no matter what, 
                 * bypassing any sort of database versioning that might be causing an error.
                 */
                #if true
                Database.SetInitializer<IrrigationAdvisorContext>
                    (new DropCreateDatabaseAlways<IrrigationAdvisorContext>());
                #endif

                #region Lenguage
                InsertLanguages();
                #endregion

                #region Security
                InsertRoles();
                InsertUsers();
                #endregion

                #region Localization
                #if true

                InsertPositions();
                InsertRegions();
                InsertCapitals();
                InsertCountry();
                InsertCities();
                InsertWeatherStations();
                InsertFarms();
                InsertUserFarms();
                #endif
                #endregion

                #region Agriculture
                #if true
                InsertSpecieCycles();
                InsertSpecies();
                UpdateCountryRegionWithSpeciesSpeciesCycles();
                InsertStagesCorn();
                InsertStagesSoya();
                InsertEffectiveRainsSouth();
                InsertEffectiveRainsNorth();
                UpdateRegionSetEffectiveRainList();

                InsertPhenologicalStagesCornSouthShort();
                InsertPhenologicalStagesSoyaSouthShort();
                InsertHorizons();
                InsertSoils();
                InsertCropCoefficients();
                #endif
                #endregion

                #region Irrigation
                #if true

                InsertBombs();
                InsertIrrigationUnits();
                UpdateSoilsBombsIrrigationUnitsUsersByFarm();
                InsertCrops();
                InsertCropsInformationByDate();

                #endif
                #endregion

                #region Weather
                #if true
                
                InsertTemperatureData();
                AddTemperatureDataToRegion();
                WetherStationsAddInformationOfWeather();
                
                #endif
                #endregion

                #region Management
                #if true
                 
                InsertCropIrrigationWeather();
                UpdateInformationOfRain();
                UpdateInformationOfIrrigation();
                AddPhenologicalStageAdjustements();
                AddInformationToIrrigationUnits();
                LayoutDailyRecords();
                #endif
                #endregion

                //Next to do
                #if false

                CalculateIrrigation();

                #endif
            }
                
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                Console.WriteLine("DB Update Exception ");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Initialization Failed...");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }

        /////////////////////////////////******************************/////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////
        #region Steps for a New Client

        /* 1.- Position
         *   Cities
         *   Farm
         *   Pivots
         *   WeatherStation
         * Position
         *   Cities
         *   Farm
         *   Pivots
         *   WeatherStation
         */

        /* 2.- Names
         * Client
         * Region
         * Cities
         * Farm
         * Bomb
         * Pivots
         * WeatherStation
         * Horizons
         * Soils
         * Crops
         * Soils, Bombs, IrrigationUnits, Farm
         * CropIrrigationWeather
         * 
        */

        /* 3.- Client Data
         * Utils.NameUserCLIENT
         * InsertUsers()
        */
            
        /* 4.- Region Data
         * InsertRegions()
         * 
        */
            
        /* 5.- Farm
         * InsertFarms()
        */
            
        /* 6.- Bomb
         * InsertBombs()
        */

        /* 7.- Pivots
         * InsertIrrigationUnits()
        */

        /* 8.- WeatherStations
         * InsertWeatherStations()
         */

        /* 9.- Horizons
         * InsertHorizons()
         */

        /* 10.- Soils
         * InsertSoils()
         */

        /* 11.- Crops
         * InsertCrops()
         */

        /* 12.- Update Farm Lists: Soils, Bombs, IrrigationUnits
         * UpdateSoilsBombsIrrigationUnitsFarmXXX()
         */

        /* 13.- CropIrrigationWeather
         * InsertCropIrrigationWeather()
         */

        #endregion
        /////////////////////////////////******************************/////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////
       

        #region Language

        private static void InsertLanguages()
        {
            var lBase = new Language
            {
                Name = Utils.NameBase,
            }; 
            
            var lSpanish = new Language
            {
                Name = Utils.NameLanguageSpanish,
            };

            var lEnglish = new Language
            {
                Name = Utils.NameLanguageEnglish,
            };

            using (var context = new IrrigationAdvisorContext())
            {
                //context.Languages.Add(lBase);
                context.Languages.Add(lSpanish);
                context.Languages.Add(lEnglish);
                context.SaveChanges();
            }
        }
        
        #endregion

        #region Security

        private static void InsertRoles()
        {

            var lRoleAdministrator = new Role()
            {
                RoleId = 1,
                Name = "Administrador",
                SiteId = 1,
                MenuId = 1,
            };

            var lRoleIntermediate = new Role()
            {
                RoleId = 2,
                Name = "Intermedio",
                SiteId = 1,
                MenuId = 1,
            };

            var lRoleStandard = new Role()
            {
                RoleId = 3,
                Name = "Estándar",
                SiteId = 1,
                MenuId = 1,
            };


            using (var context = new IrrigationAdvisorContext())
            {
                context.Roles.Add(lRoleAdministrator);
                context.Roles.Add(lRoleIntermediate);
                context.Roles.Add(lRoleStandard);
                context.SaveChanges();
            }

        }

        private static void InsertUsers()
        {
            

            #region Base
            var lBase = new User()
            {
                Name = Utils.NameBase,
                Surname = "",
                Phone = "",
                Address = "",
                Email = "",
                UserName = "",
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "P4ssw0rd"),
            };
            #endregion

            #region Demo
            var lDemo = new User()
            {
                Name = Utils.NameUserDemo,
                Surname = "PGW Water",
                Phone = "098 938 269",
                Address = "1958 Cuareim, Montevideo",
                Email = "riegopgw@googlegroups.com",
                UserName = Utils.NameUserDemo,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "lluvia"),
                RoleId = 3,
            };
            #endregion

            #region Admin Users
            var lSCasanova = new User()
            {
                Name = "Sebastian",
                Surname = "Casanova",
                Phone = "098 938 269",
                Address = "1958 Cuareim, Montevideo",
                Email = "scasanova@pgwwater.com.uy",
                UserName = Utils.NameUserSeba,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "SCasanova"),
                RoleId = 1,
            };

            var lAdmin = new User()
            {
                Name = Utils.NameUserAdmin,
                Surname = "PGW Water",
                Phone = "099 618 260",
                Address = "1958 Cuareim, Montevideo",
                Email = "riegopgw@googlegroups.com",
                UserName = Utils.NameUserAdmin,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "Irrigation4dvis0r"),
                RoleId = 3,
            };
            #endregion

            #region Del Carmen ACISA S.A. - La Perdiz - DCA
            var lLaPerdiz = new User()
            {
                Name = "Juan",
                Surname = "Platero",
                Phone = "+598 98 938 269",
                Address = "Mercedes",
                Email = "jplatero@delcarmen.com.uy",
                UserName = Utils.NameUserDelCarmen,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "Laperdiz"),
                RoleId = 3,
            };
            #endregion

            #region Estancias del lago - Del Lago - EDL
            var lDelLago = new User()
            {
                Name = "Guzmán",
                Surname = "Irrazabal",
                Phone = "+598 91 359 000",
                Address = "Miguel Cabrera Km 5, Durazno, Uruguay CP 97.000",
                Email = "guzman.irazabal@estanciasdellago.com ",
                UserName = Utils.NameUserDelLago,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "Dellago"),
                RoleId = 3,
            };
            #endregion

            #region Estancia Menafra - LaPalma - GMO
            var lLaPalma = new User()
            {
                Name = "Pablo",
                Surname = "Tarigo",
                Phone = "+598 9",
                Address = "",
                Email = "pablo.tarigo@LaPalma.com.uy",
                UserName = Utils.NameUserLaPalma,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "gmo"),
                RoleId = 3,
            };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {
                //context.Users.Add(lBase);
                context.Users.Add(lDemo);
                context.Users.Add(lSCasanova);
                context.Users.Add(lAdmin);
                context.Users.Add(lLaPerdiz);
                context.Users.Add(lDelLago);
                context.Users.Add(lLaPalma);
                context.SaveChanges();
            }
 
        }

        private static void InsertUserFarms()
        {
            Farm lFarm = null;
            List<User> lUserList = null;
            String[] lUserNames = null;
            
            using (var context = new IrrigationAdvisorContext())
            {

                #region Base
                var lBase = new UserFarm()
                {
                    UserId = 0,
                    FarmId = 0,
                    Name = "No Name",
                    StartDate = Utils.MIN_DATETIME,
                };
                #endregion

                #region Demo1
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {
                    lUserNames = new String[] { Utils.NameUserDemo, Utils.NameUserSeba, Utils.NameUserAdmin };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo1
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User item in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = item.UserId,
                            FarmId = lFarm.FarmId,
                            Name = item.Name + lFarm.Name,
                            StartDate = DateTime.Now,
                        };

                        context.UserFarms.Add(lUserFarm);
                        context.SaveChanges();
                    }
                }
                #endregion

                #region Demo2
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {
                    lUserNames = new String[] { Utils.NameUserDemo, Utils.NameUserSeba, Utils.NameUserAdmin };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo2
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User item in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = item.UserId,
                            FarmId = lFarm.FarmId,
                            Name = item.Name + lFarm.Name,
                            StartDate = DateTime.Now,
                        };

                        context.UserFarms.Add(lUserFarm);
                        context.SaveChanges();
                    }
                }
                #endregion

                #region Demo3
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {
                    lUserNames = new String[] { Utils.NameUserDemo, Utils.NameUserSeba, Utils.NameUserAdmin };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo3
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User item in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = item.UserId,
                            FarmId = lFarm.FarmId,
                            Name = item.Name + lFarm.Name,
                            StartDate = DateTime.Now,
                        };

                        context.UserFarms.Add(lUserFarm);
                        context.SaveChanges();
                    }
                }
                #endregion

                #region Santa Lucia
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
                {
                    lUserNames = new String[] { Utils.NameUserSantaLucia, Utils.NameUserSeba, Utils.NameUserAdmin };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmSantaLucia
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User item in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = item.UserId,
                            FarmId = lFarm.FarmId,
                            Name = item.Name + lFarm.Name,
                            StartDate = DateTime.Now,
                        };

                        context.UserFarms.Add(lUserFarm);
                        context.SaveChanges();
                    }
                }
                #endregion

                #region Del Carmen ACISA S.A. - La Perdiz - DCA
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPerdiz)
                {
                    lUserNames = new String[] { Utils.NameUserDelCarmen, Utils.NameUserSeba, Utils.NameUserAdmin };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmLaPerdiz
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User item in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = item.UserId,
                            FarmId = lFarm.FarmId,
                            Name = item.Name + lFarm.Name,
                            StartDate = DateTime.Now,
                        };

                        context.UserFarms.Add(lUserFarm);
                        context.SaveChanges();
                    }
                }
                #endregion

                #region DelLago - San Pedro - Estancias del Lago S.R.L.
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
                {
                    lUserNames = new String[] { Utils.NameUserDelLago, Utils.NameUserSeba, Utils.NameUserAdmin };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoSanPedro
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User item in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = item.UserId,
                            FarmId = lFarm.FarmId,
                            Name = item.Name + lFarm.Name,
                            StartDate = DateTime.Now,
                        };

                        context.UserFarms.Add(lUserFarm);
                        context.SaveChanges();
                    }
                }
                #endregion

                #region DelLago - El Mirador - Estancias del Lago S.R.L.
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
                {
                    lUserNames = new String[] { Utils.NameUserDelLago, Utils.NameUserSeba, Utils.NameUserAdmin };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User item in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = item.UserId,
                            FarmId = lFarm.FarmId,
                            Name = item.Name + lFarm.Name,
                            StartDate = DateTime.Now,
                        };

                        context.UserFarms.Add(lUserFarm);
                        context.SaveChanges();
                    }
                }
                #endregion

                #region Estancia Menafra - LaPalma - GMO
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPalma)
                {
                    lUserNames = new String[] { Utils.NameUserLaPalma, Utils.NameUserSeba, Utils.NameUserAdmin };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmLaPalma
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User item in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = item.UserId,
                            FarmId = lFarm.FarmId,
                            Name = item.Name + lFarm.Name,
                            StartDate = DateTime.Now,
                        };

                        context.UserFarms.Add(lUserFarm);
                        context.SaveChanges();
                    }
                }
                #endregion

                context.SaveChanges();
            }

        }
        
        #endregion

        #region Localization
        #if true

        private static void InsertPositions()
        {
            
            #region Base
            var lBase = new Position()
            {
                Name = Utils.NameBase,
                Latitude = 0,
                Longitude = 0
            };
            #endregion

            #region Countries
            var lUruguay = new Position()
            {
                Name = Utils.NamePositionUruguay,
                Latitude = -32.523,
                Longitude = -55.766
            };
            #endregion

            #region Regions

            var lRegionSur = new Position()
            {
                Name = Utils.NamePositionRegionSouth,
                Latitude = -33.874333,
                Longitude = -56.009694
            };

            var lRegionNorte = new Position()
            {
                Name = Utils.NamePositionRegionNorth,
                Latitude = -31.381117,
                Longitude = -56.539784
            };

            #endregion

            #region Cities
            var lMontevideo = new Position()
            {
                Name = Utils.NamePositionCityMontevideo,
                Latitude = -34.9019718,
                Longitude = -56.1640629,
            };

            var lMinas = new Position()
            {
                Name = Utils.NamePositionCityMinas,
                Latitude = -34.366747,
                Longitude = -55.233317,
            };

            var lMercedes = new Position()
            {
                Name = Utils.NamePositionCityMercedes,
                Latitude = -33.255833,
                Longitude = -58.019167,
            };

            var lPalmar = new Position() 
            {
                Name = Utils.NamePositionCityPalmar,
                Latitude = -33.062500,
                Longitude = -57.460833,
            };

            var lDurazno = new Position()
            {
                Name = Utils.NamePositionCityDurazno,
                Latitude = -33.413056,
                Longitude = -56.500556,
            };

            var lYoung = new Position()
            {
                Name = Utils.NamePositionCityYoung,
                Latitude = -32.683333,
                Longitude = -57.633333,
            };
            
            #endregion

            #region Farms

            var lDemo1 = new Position()
            {
                Name = Utils.NamePositionFarmDemo1,
                Latitude = -33.023674,
                Longitude = -57.514196,
            };

            var lDemo2 = new Position()
            {
                Name = Utils.NamePositionFarmDemo2,
                Latitude = -34.232518,
                Longitude = -55.541477,
            };

            var lDemo3 = new Position()
            {
                Name = Utils.NamePositionFarmDemo3,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };

            var lSantaLucia = new Position()
            {
                Name = Utils.NamePositionFarmSantaLucia,
                Latitude = -34.232518,
                Longitude = -55.541477,
            };

            var lLaPerdiz = new Position()
            {
                Name = Utils.NamePositionFarmLaPerdiz,
                Latitude = -33.023674,
                Longitude = -57.514196,
            };

            var lDelLagoSanPedro = new Position()
            {
                Name = Utils.NamePositionFarmDelLagoSanPedro,
                Latitude = -33.343049,
                Longitude = -56.567679,
            };

            var lDelLagoElMirador = new Position()
            {
                Name = Utils.NamePositionFarmDelLagoElMirador,
                Latitude = -33.343049,
                Longitude = -56.567679,
            };

            var lLaPalma = new Position()
            {
                Name = Utils.NamePositionFarmLaPalma,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };

            #endregion

            #region WeatherStations
            var lLasBrujasWS = new Position()
            {
                Name = Utils.NamePositionWeatherStationLasBrujas,
                Latitude = -34.670641,
                Longitude = -56.340871
            };
            
            var lSantaLuciaWS = new Position()
            {
                Name = Utils.NamePositionWeatherStationSantaLucia,
                Latitude = -34.232518,
                Longitude = -55.541477
            };

            var lLaEstanzuelaWS = new Position()
            {
                Name = Utils.NamePositionWeatherStationLaEstanzuela,
                Latitude = -34.3384179,
                Longitude = -57.6920361,
            };

            var lSaltoGrandeWS = new Position()
            {
                Name = Utils.NamePositionWeatherStationSaltoGrande,
                Latitude = -34.3384179,
                Longitude = -57.6920361,
            };

            var lTacuaremboWS = new Position()
            {
                Name = Utils.NamePositionWeatherStationTacuarembo,
                Latitude = -34.3384179,
                Longitude = -57.6920361,
            };

            #endregion

            #region Pivots Demo1 - La Perdiz
            var lDemoPivot11 = new Position()
            {
                Name = Utils.NamePositionPivotDemo11,
                Latitude = -33.035406,
                Longitude = -57.551740,
            };
            var lDemoPivot12 = new Position()
            {
                Name = Utils.NamePositionPivotDemo12,
                Latitude = -33.024191,
                Longitude = -57.543566,
            };
            var lDemoPivot13 = new Position()
            {
                Name = Utils.NamePositionPivotDemo13,
                Latitude = -33.020039,
                Longitude = -57.530693
            };
            var lDemoPivot15 = new Position()
            {
                Name = Utils.NamePositionPivotDemo15,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            #endregion

            #region Pivots Demo2 - Santa Lucia
            var lDemoPivot21 = new Position()
            {
                Name = Utils.NamePositionPivotDemo21,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            var lDemoPivot22 = new Position()
            {
                Name = Utils.NamePositionPivotDemo22,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            var lDemoPivot23 = new Position()
            {
                Name = Utils.NamePositionPivotDemo23,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            var lDemoPivot24 = new Position()
            {
                Name = Utils.NamePositionPivotDemo24,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            var lDemoPivot25 = new Position()
            {
                Name = Utils.NamePositionPivotDemo25,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            #endregion

            #region Pivots Demo3 - La Palma
            var lDemoPivot31 = new Position()
            {
                Name = Utils.NamePositionPivotDemo31,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lDemoPivot32A = new Position()
            {
                Name = Utils.NamePositionPivotDemo32A,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lDemoPivot33 = new Position()
            {
                Name = Utils.NamePositionPivotDemo33,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lDemoPivot34 = new Position()
            {
                Name = Utils.NamePositionPivotDemo34,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lDemoPivot35 = new Position()
            {
                Name = Utils.NamePositionPivotDemo35,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            #endregion

            #region Pivots Santa Lucia
            var lSantaLuciaPivot1 = new Position()
            {
                Name = Utils.NamePositionPivotSantaLucia1,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            var lSantaLuciaPivot2 = new Position()
            {
                Name = Utils.NamePositionPivotSantaLucia2,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            var lSantaLuciaPivot3 = new Position()
            {
                Name = Utils.NamePositionPivotSantaLucia3,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            var lSantaLuciaPivot4 = new Position()
            {
                Name = Utils.NamePositionPivotSantaLucia4,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            var lSantaLuciaPivot5 = new Position()
            {
                Name = Utils.NamePositionPivotSantaLucia5,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            #endregion

            #region Pivots La Perdiz
            var lLaPerdizPivot1 = new Position()
            {
                Name = Utils.NamePositionPivotLaPerdiz1,
                Latitude = -33.035406,
                Longitude = -57.551740,
            };
            var lLaPerdizPivot2 = new Position()
            {
                Name = Utils.NamePositionPivotLaPerdiz2,
                Latitude = -33.024191,
                Longitude = -57.543566,
            };
            var lLaPerdizPivot3 = new Position()
            {
                Name = Utils.NamePositionPivotLaPerdiz3,
                Latitude = -33.020039,
                Longitude = -57.530693
            };
            var lLaPerdizPivot5 = new Position()
            {
                Name = Utils.NamePositionPivotLaPerdiz5,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            var lLaPerdizPivot14 = new Position()
            {
                Name = Utils.NamePositionPivotLaPerdiz14,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            #endregion

            #region Pivots Del Lago
            var lDelLagoSanPedroPivot5 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoSanPedro5,
                Latitude = -33.035406,
                Longitude = -57.551740,
            };

            var lDelLagoSanPedroPivot6 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoSanPedro6,
                Latitude = -33.024191,
                Longitude = -57.543566,
            };
            var lDelLagoSanPedroPivot7 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoSanPedro7,
                Latitude = -33.020039,
                Longitude = -57.530693
            };
            var lDelLagoSanPedroPivot8 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoSanPedro8,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            var lDelLagoElMiradorPivot6 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador6,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivot7 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador7,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivot8 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador8,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivot9 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador9,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            #endregion

            #region Pivots LaPalma
            var lLaPalmaPivot1 = new Position()
            {
                Name = Utils.NamePositionPivotLaPalma1,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lLaPalmaPivot2A = new Position()
            {
                Name = Utils.NamePositionPivotLaPalma2A,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lLaPalmaPivot3 = new Position()
            {
                Name = Utils.NamePositionPivotLaPalma3,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lLaPalmaPivot4 = new Position()
            {
                Name = Utils.NamePositionPivotLaPalma4,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lLaPalmaPivot5 = new Position()
            {
                Name = Utils.NamePositionPivotLaPalma5,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {
                //context.Positions.Add(lBase);
                context.Positions.Add(lUruguay); 
                context.Positions.Add(lRegionSur); 
                context.Positions.Add(lRegionNorte); 
                //Cities
                context.Positions.Add(lMontevideo); 
                context.Positions.Add(lMinas);
                context.Positions.Add(lMercedes);
                context.Positions.Add(lPalmar);
                context.Positions.Add(lDurazno);
                context.Positions.Add(lYoung);
                //Farms
                context.Positions.Add(lDemo1);
                context.Positions.Add(lDemo2);
                context.Positions.Add(lDemo3);
                context.Positions.Add(lSantaLucia);
                context.Positions.Add(lLaPerdiz);
                context.Positions.Add(lDelLagoSanPedro);
                context.Positions.Add(lDelLagoElMirador);
                context.Positions.Add(lLaPalma);
                //Weather Stations
                context.Positions.Add(lLasBrujasWS); 
                context.Positions.Add(lSantaLuciaWS);
                context.Positions.Add(lLaEstanzuelaWS);
                context.Positions.Add(lSaltoGrandeWS);
                context.Positions.Add(lTacuaremboWS);
                //Pivots
                context.Positions.Add(lDemoPivot11);
                context.Positions.Add(lDemoPivot12);
                context.Positions.Add(lDemoPivot13);
                context.Positions.Add(lDemoPivot15);
                context.Positions.Add(lDemoPivot21);
                context.Positions.Add(lDemoPivot22);
                context.Positions.Add(lDemoPivot23);
                context.Positions.Add(lDemoPivot24);
                context.Positions.Add(lDemoPivot25);
                context.Positions.Add(lDemoPivot31);
                context.Positions.Add(lDemoPivot32A);
                context.Positions.Add(lDemoPivot33);
                context.Positions.Add(lDemoPivot34);
                context.Positions.Add(lDemoPivot35);
                context.Positions.Add(lSantaLuciaPivot1);
                context.Positions.Add(lSantaLuciaPivot2);
                context.Positions.Add(lSantaLuciaPivot3);
                context.Positions.Add(lSantaLuciaPivot4);
                context.Positions.Add(lSantaLuciaPivot5);
                context.Positions.Add(lLaPerdizPivot1);
                context.Positions.Add(lLaPerdizPivot2);
                context.Positions.Add(lLaPerdizPivot3);
                context.Positions.Add(lLaPerdizPivot5);
                context.Positions.Add(lLaPerdizPivot14);
                context.Positions.Add(lDelLagoSanPedroPivot5);
                context.Positions.Add(lDelLagoSanPedroPivot6);
                context.Positions.Add(lDelLagoSanPedroPivot7);
                context.Positions.Add(lDelLagoSanPedroPivot8);
                context.Positions.Add(lDelLagoElMiradorPivot6);
                context.Positions.Add(lDelLagoElMiradorPivot7);
                context.Positions.Add(lDelLagoElMiradorPivot8);
                context.Positions.Add(lDelLagoElMiradorPivot9);
                context.Positions.Add(lLaPalmaPivot1);
                context.Positions.Add(lLaPalmaPivot2A);
                context.Positions.Add(lLaPalmaPivot3);
                context.Positions.Add(lLaPalmaPivot4);
                context.Positions.Add(lLaPalmaPivot5);
                context.SaveChanges();
            }
        }
        
        private static void InsertRegions()
        {
            Position lPosition = null;
            using (var context = new IrrigationAdvisorContext())
            {
                #region Base
                var lBase = new Region
                {
                    Name = Utils.NameBase,
                    PositionId = 0,
                    Position = new Position(),
                    EffectiveRainList = null,
                    SpecieList = null,
                    SpecieCycleList = null,
                    TemperatureDataList = null,
                };
                #endregion

                #region Sur
                lPosition = (from pos in context.Positions
                               where pos.Name == Utils.NamePositionRegionSouth
                               select pos).FirstOrDefault();
                var lSur = new Region 
                {
                    Name = Utils.NameRegionSouth,
                    PositionId = lPosition.PositionId,
                    EffectiveRainList = null,
                    SpecieList = null,
                    SpecieCycleList = null,
                    TemperatureDataList = null,
                };
                #endregion
                
                #region Norte
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionRegionNorth
                             select pos).FirstOrDefault();
                var lNorte = new Region
                {
                    Name = Utils.NameRegionNorth,
                    PositionId = lPosition.PositionId,
                    EffectiveRainList = null,
                    SpecieList = null,
                    SpecieCycleList = null,
                    TemperatureDataList = null,
                };
                #endregion

                //context.Regions.Add(lBase);
                context.Regions.Add(lSur);
                context.Regions.Add(lNorte);
                context.SaveChanges();
            }
        }

        private static void InsertCapitals()
        {
            using(var context = new IrrigationAdvisorContext())
            {
                Position lPosition = null;
                
                #region Base
                var lBase = new City
                {
                    Name = Utils.NameBase,
                    PositionId = 0,
                    CountryId = 0,
                };
                #endregion

                #region Montevideo
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionCityMontevideo
                             select pos).FirstOrDefault();
                var lMontevideo = new City
                {
                    Name = Utils.NameCityMontevideo,
                    PositionId = lPosition.PositionId,
                    CountryId = 1,
                };

                //lMontevideo.Country.LanguageId = 1;
                #endregion

                //context.Cities.Add(lBase);
                context.Cities.Add(lMontevideo);
                context.SaveChanges();
            }
        }

        private static void InsertCountry()
        {
            Position lPosition = null;
            City lCity = null;
            Language lLanguage = null;

            using (var context = new IrrigationAdvisorContext())
            {
                #region Base
                var lBase = new Country
                {
                    Name = Utils.NameBase,
                    CapitalId = 0,
                    LanguageId = 0,
                    CityList = null,
                    RegionList = null,
                };
                #endregion

                #region Uruguay
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionUruguay
                             select pos).FirstOrDefault();

                lLanguage = (from language in context.Languages
                             where language.Name == Utils.NameLanguageSpanish
                             select language).FirstOrDefault();

                lCity = (from city in context.Cities
                         where city.Name == Utils.NameCityMontevideo
                         select city).FirstOrDefault();


                var lUruguay = new Country
                {
                    Name = Utils.NameCountryUruguay,
                    LanguageId = lLanguage.LanguageId,
                    CapitalId = lCity.CityId,
                    RegionList = null,
                    CityList = new List<City>(),
                };
                lUruguay.AddCity(lCity);
                #endregion

                //context.Countries.Add(lBase);
                context.Countries.Add(lUruguay);
                context.SaveChanges();
            }
        }

        private static void InsertCities()
        {
            using (var context = new IrrigationAdvisorContext())
            {
                Position lPosition = null;
                Country lCountry = null;

                #region Base
                var lBase = new City
                {
                    Name = Utils.NameBase,
                    PositionId = 0,
                    CountryId = 0,
                };
                #endregion

                #region Minas
                lCountry = (from country in context.Countries
                            where country.Name == Utils.NameCountryUruguay
                            select country).FirstOrDefault();
                

                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionCityMinas
                             select pos).FirstOrDefault();
                var lMinas = new City
                {
                    Name = Utils.NameCityMinas,
                    PositionId = lPosition.PositionId,
                    CountryId = lCountry.CountryId,
                };
                #endregion

                #region Mercedes
                lCountry = (from country in context.Countries
                            where country.Name == Utils.NameCountryUruguay
                            select country).FirstOrDefault();


                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionCityMercedes
                             select pos).FirstOrDefault();
                var lMercedes = new City
                {
                    Name = Utils.NameCityMercedes,
                    PositionId = lPosition.PositionId,
                    CountryId = lCountry.CountryId,
                };
                #endregion

                #region Palmar
                lCountry = (from country in context.Countries
                            where country.Name == Utils.NameCountryUruguay
                            select country).FirstOrDefault();
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionCityPalmar
                             select pos).FirstOrDefault();
                var lPalmar = new City
                {
                    Name = Utils.NameCityPalmar,
                    PositionId = lPosition.PositionId,
                    CountryId = lCountry.CountryId,
                };
                #endregion

                #region Durazno
                lCountry = (from country in context.Countries
                            where country.Name == Utils.NameCountryUruguay
                            select country).FirstOrDefault();
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionCityDurazno
                             select pos).FirstOrDefault();
                var lDurazno = new City
                {
                    Name = Utils.NameCityDurazno,
                    PositionId = lPosition.PositionId,
                    CountryId = lCountry.CountryId,
                };
                #endregion

                #region Young
                lCountry = (from country in context.Countries
                            where country.Name == Utils.NameCountryUruguay
                            select country).FirstOrDefault();
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionCityYoung
                             select pos).FirstOrDefault();
                var lYoung = new City
                {
                    Name = Utils.NameCityYoung,
                    PositionId = lPosition.PositionId,
                    CountryId = lCountry.CountryId,
                };
                #endregion


                //context.Cities.Add(lBase);
                context.Cities.Add(lMinas);
                context.Cities.Add(lMercedes);
                context.Cities.Add(lPalmar);
                context.Cities.Add(lDurazno);
                context.Cities.Add(lYoung);
                context.SaveChanges();
            }
        }

        #endif
        #endregion

        #region Weather.WeatherStation
        #if true

        private static void InsertWeatherStations()
        {
            Position lPosition = null;
            using (var context = new IrrigationAdvisorContext())
            {
                #region Base
                var lBase = new WeatherStation
                {
                    Name = Utils.NameBase,
                    Model = "",
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService =Utils.MAX_DATETIME,
                    UpdateTime = Utils.MAX_DATETIME,
                    WirelessTransmission = 0,
                    PositionId = 0,
                    GiveET = false,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.NoData,
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
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService = Utils.MAX_DATETIME,
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
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
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService = Utils.MAX_DATETIME,
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
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
                    DateOfInstallation = new DateTime(2015, 10, 01),
                    DateOfService = new DateTime(2015, 10, 01).AddMonths(6),
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
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
                    DateOfInstallation = new DateTime(2015, 10, 01),
                    DateOfService = new DateTime(2015, 10, 01).AddMonths(6),
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                };
                #endregion

                #region SantaLucia
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionWeatherStationSantaLucia
                             select pos).FirstOrDefault();
                var lSantaLuciaWS = new WeatherStation
                {
                    Name = Utils.NameWeatherStationSantaLucia,
                    Model = "",
                    DateOfInstallation = new DateTime(2015, 10, 01),
                    DateOfService = new DateTime(2015, 10, 01).AddMonths(6),
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                };
                #endregion

                //context.WeatherStations.Add(lBase);
                context.WeatherStations.Add(lLasBrujasWS);
                context.WeatherStations.Add(lSantaLuciaWS);
                context.WeatherStations.Add(lLaEstanzuelaWS);
                context.WeatherStations.Add(lSaltoGrandeWS);
                context.WeatherStations.Add(lTacuaremboWS);
                context.SaveChanges();
            };
        }

        private static void InsertTemperatureData()
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
                DataEntry.DataTemperatures_South_2014(context, lRegion);
                DataEntry.DataTemperatures_South_2015(context, lRegion);
                DataEntry.DataTemperatures_South_2016(context, lRegion);

                #endregion

                #region North
                lRegion = (from region in context.Regions
                           where region.Name == Utils.NameRegionNorth
                           select region).FirstOrDefault();
                DataEntry.DataTemperatures_North_2014(context, lRegion);
                DataEntry.DataTemperatures_North_2015(context, lRegion);
                DataEntry.DataTemperatures_North_2016(context, lRegion);

                #endregion

                //context.TemperatureDatas.Add(lBase);
                context.SaveChanges();
            }
        }

        private static void AddTemperatureDataToRegion()
        {
            Region lRegion= null;
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

        private static void WetherStationsAddInformationOfWeather()
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

            #region LasBrujas 2015
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntry.WeatherDataLasBrujas_2015(context);
                context.SaveChanges();
            }
            #endregion

            #region LasBrujas 2016
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntry.WeatherDataLasBrujas_2016(context);
                context.SaveChanges();
            }
            #endregion

            #region LaEstuanzuela 2015
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntry.WeatherDataLaEstanzuela_2015(context);
                context.SaveChanges();
            }
            #endregion

            #region LaEstuanzuela 2016
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntry.WeatherDataLaEstanzuela_2016(context);
                context.SaveChanges();
            }
            #endregion

            #region SaltoGrande 2015
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntry.WeatherDataSaltoGrande_2015(context);
                context.SaveChanges();
            }
            #endregion

            #region SaltoGrande 2016
            using (var context = new IrrigationAdvisorContext())
            {
                DataEntry.WeatherDataSaltoGrande_2016(context);
                context.SaveChanges();
            }
            #endregion

        }

        #endif
        #endregion

        #region Localization.Farm
        #if true

        private static void InsertFarms()
        {
            Position lPosition = null;
            WeatherStation lWeatherStation = null;
            City lCity = null;
            
            #region Base
            var lBase = new Farm
            {
                Name = Utils.NameBase,
                Company = "",
                Address = "",
                Phone = "",
                PositionId = 0,
                Has = 0,
                WeatherStationId = 0,
                WeatherStation = null,
                SoilList = null,
                BombList = null,
                IrrigationUnitList = null,
                CityId = 0,
                UserFarmList = null,
            };
            #endregion

            #region Demo1 - LaPerdiz - Del Carmen ACISA SA
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == Utils.NameWeatherStationLasBrujas
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDemo1
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityMercedes
                             select city).FirstOrDefault();
                    
                    var lDemo = new Farm
                    {
                        Name = Utils.NameFarmDemo1,
                        Company = "Del Carmen ACISA SA - Demo",
                        Address = "",
                        Phone = "",
                        PositionId = lPosition.PositionId,
                        Has = 411,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lDemo);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Demo2 - SantaLucia - Campo de Sol SA
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == Utils.NameWeatherStationLasBrujas
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDemo2
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityMinas
                             select city).FirstOrDefault();

                    var lDemo = new Farm
                    {
                        Name = Utils.NameFarmDemo2,
                        Company = "Campo de Sol SA - Demo",
                        Address = "",
                        Phone = "",
                        PositionId = lPosition.PositionId,
                        Has = 470,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lDemo);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Demo3 - LaPalma - GMO - Menafra
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == Utils.NameWeatherStationLasBrujas
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDemo3
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityYoung
                             select city).FirstOrDefault();

                    var lDemo = new Farm
                    {
                        Name = Utils.NameFarmDemo3,
                        Company = "GMO - Demo",
                        Address = "Menafra",
                        Phone = "094 688 833",
                        PositionId = lPosition.PositionId,
                        Has = 140,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lDemo);
                    context.SaveChanges();
                }
            }
            #endregion

            #region SantaLucia - Campo de Sol SA
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == Utils.NameWeatherStationLasBrujas
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmSantaLucia
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityMinas
                             select city).FirstOrDefault();

                    var lSantaLucia = new Farm
                    {
                        Name = Utils.NameFarmSantaLucia,
                        Company = "Campo de Sol SA",
                        Address = "",
                        Phone = "",
                        PositionId = lPosition.PositionId,
                        Has = 470,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lSantaLucia);
                    context.SaveChanges();
                }
            }
            #endregion

            #region LaPerdiz - Del Carmen ACISA SA
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == Utils.NameWeatherStationLasBrujas
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmLaPerdiz
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityMercedes
                             select city).FirstOrDefault();

                    var lLaPerdiz = new Farm
                    {
                        Name = Utils.NameFarmLaPerdiz,
                        Company = "Del Carmen ACISA SA",
                        Address = "",
                        Phone = "",
                        PositionId = lPosition.PositionId,
                        Has = 411,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lLaPerdiz);
                    context.SaveChanges();
                }
            }
            #endregion

            #region DelLago - San Pedro - Estancias del Lago S.R.L.
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == Utils.NameWeatherStationLasBrujas
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDelLagoSanPedro
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityDurazno
                             select city).FirstOrDefault();

                    var lDelLagoSanPedro = new Farm
                    {
                        Name = Utils.NameFarmDelLagoSanPedro,
                        Company = "Estancias del Lago S.R.L.",
                        Address = "Miguel Cabrera Km 5. Durazno, Uruguay.",
                        Phone = "+598 91 359 000",
                        PositionId = lPosition.PositionId,
                        Has = 560,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lDelLagoSanPedro);
                    context.SaveChanges();
                }
            }
            #endregion

            #region DelLago - El Mirador - Estancias del Lago S.R.L.
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == Utils.NameWeatherStationLasBrujas
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDelLagoElMirador
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityDurazno
                             select city).FirstOrDefault();

                    var lDelLagoElMirador = new Farm
                    {
                        Name = Utils.NameFarmDelLagoElMirador,
                        Company = "Estancias del Lago S.R.L.",
                        Address = "Miguel Cabrera Km 5. Durazno, Uruguay.",
                        Phone = "+598 91 359 000",
                        PositionId = lPosition.PositionId,
                        Has = 560,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lDelLagoElMirador);
                    context.SaveChanges();
                }
            }
            #endregion

            #region LaPalma - GMO - Menafra
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == Utils.NameWeatherStationLasBrujas
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmLaPalma
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityYoung
                             select city).FirstOrDefault();

                    var lLaPalma = new Farm
                    {
                        Name = Utils.NameFarmLaPalma,
                        Company = "GMO",
                        Address = "Menafra",
                        Phone = "094 688 833",
                        PositionId = lPosition.PositionId,
                        Has = 140,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lLaPalma);
                    context.SaveChanges();
                }
            }
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {
                //context.Farms.Add(lBase);
                context.SaveChanges();
            }
        }

        private static void UpdateSoilsBombsIrrigationUnitsUsersFarmDemo1()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = {Utils.NameUserDemo, Utils.NameUserSeba, Utils.NameUserAdmin};
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmDemo1
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmDemo1)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmDemo1)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmDemo1)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                         select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                             select userFarm).ToList();
                
                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmDemo1));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmDemo1));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmDemo1));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if(lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units, and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        private static void UpdateSoilsBombsIrrigationUnitsUsersFarmDemo2()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = { Utils.NameUserDemo, Utils.NameUserSeba, Utils.NameUserAdmin };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmDemo2
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmDemo2)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmDemo2)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmDemo2)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmDemo2));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmDemo2));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmDemo2));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units, and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        private static void UpdateSoilsBombsIrrigationUnitsUsersFarmDemo3()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = { Utils.NameUserDemo, Utils.NameUserSeba, Utils.NameUserAdmin };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmDemo3
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmDemo3)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmDemo3)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmDemo3)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmDemo3));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmDemo3));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmDemo3));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units, and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        private static void UpdateSoilsBombsIrrigationUnitsUsersFarmSantaLucia()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = { Utils.NameUserSantaLucia, Utils.NameUserSeba, Utils.NameUserAdmin };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmSantaLucia
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmSantaLucia)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmSantaLucia)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmSantaLucia)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmSantaLucia));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmSantaLucia));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmSantaLucia));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, and Irrigation Units
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        private static void UpdateSoilsBombsIrrigationUnitsUsersFarmLaPerdiz()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null; 
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = { Utils.NameUserDelCarmen, Utils.NameUserSeba, Utils.NameUserAdmin };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmLaPerdiz
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmLaPerdiz)
                             select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmLaPerdiz)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmLaPerdiz)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmLaPerdiz));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmLaPerdiz));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmLaPerdiz));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        private static void UpdateSoilsBombsIrrigationUnitsUsersFarmDelLagoSanPedro()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = { Utils.NameUserDelLago, Utils.NameUserSeba, Utils.NameUserAdmin };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmDelLagoSanPedro
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmDelLagoSanPedro)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmDelLagoSanPedro)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmDelLagoSanPedro)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmDelLagoSanPedro));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmDelLagoSanPedro));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmDelLagoSanPedro));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units, and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        private static void UpdateSoilsBombsIrrigationUnitsUsersFarmDelLagoElMirador()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = { Utils.NameUserDelLago, Utils.NameUserSeba, Utils.NameUserAdmin };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmDelLagoElMirador
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmDelLagoElMirador)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmDelLagoElMirador)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmDelLagoElMirador)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;
                
                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmDelLagoElMirador));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmDelLagoElMirador));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmDelLagoElMirador));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units, and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        private static void UpdateSoilsBombsIrrigationUnitsUsersFarmLaPalma()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = { Utils.NameUserLaPalma, Utils.NameUserSeba, Utils.NameUserAdmin };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmLaPalma
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmLaPalma)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmLaPalma)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmLaPalma)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmLaPalma));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmLaPalma));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmLaPalma));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units, and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        #endif
        #endregion

        #region Agriculture
        #if true

        private static void InsertSpecieCycles()
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
            var lNorteCorto = new SpecieCycle
            {
                Name = Utils.NameSpecieCycleNorthShort,
                Duration = 160,
            };

            var lNorteMedio = new SpecieCycle
            {
                Name = Utils.NameSpecieCycleNorthMedium,
                Duration = 180,
            };

            var lNorteLargo = new SpecieCycle
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
                context.SpecieCycles.Add(lNorteCorto);
                context.SpecieCycles.Add(lNorteMedio);
                context.SpecieCycles.Add(lNorteLargo);
                context.SaveChanges();
            }
        }

        private static void InsertSpecies()
        {
            SpecieCycle lSpecieCycle = null;

            #region Base
            var lBase = new Specie
            {
                Name = Utils.NameBase,
                SpecieCycleId = 0,
                BaseTemperature = 0,
                StressTemperature = 0
            };
            #endregion
            
            #region South
            #region CornSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        region => region.Name == Utils.NameSpecieCycleSouthShort);
                
                var lCornSouthShort = new Specie
                {
                    Name = Utils.NameSpecieCornSouthShort,
                    ShortName = "Maíz",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_CornSouth_2015,
                    StressTemperature = DataEntry.StressTemperature_CornSouth_2015,
                };

                context.Species.Add(lCornSouthShort);
                context.SaveChanges();
            }
            #endregion

            #region SoyaSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        region => region.Name == Utils.NameSpecieCycleSouthShort);

                var lSoyaSouthShort = new Specie
                {
                    Name = Utils.NameSpecieSoyaSouthShort,
                    ShortName = "Soja",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_SoyaSouth_2015,
                    StressTemperature = DataEntry.StressTemperature_SoyaSouth_2015,
                };

                context.Species.Add(lSoyaSouthShort);
                context.SaveChanges();
            }
            #endregion

            #region SoyaSouthMedium
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        region => region.Name == Utils.NameSpecieCycleSouthMedium);

                var lSoyaSouthMedium = new Specie
                {
                    Name = Utils.NameSpecieSoyaSouthMedium,
                    ShortName = "Soja",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_SoyaSouth_2015,
                    StressTemperature = DataEntry.StressTemperature_SoyaSouth_2015,
                };

                context.Species.Add(lSoyaSouthMedium);
                context.SaveChanges();
            }
            #endregion

            #region ForageSorghumSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        region => region.Name == Utils.NameSpecieCycleSouthShort);

                var lForageSorghumSouthShort = new Specie
                {
                    Name = Utils.NameSpecieForageSorghumSouthShort,
                    ShortName = "Sorgo Forrajero",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_ForageSorghumSouth_2015,
                    StressTemperature = DataEntry.StressTemperature_ForageSorghumSouth_2015,
                };

                context.Species.Add(lForageSorghumSouthShort);
                context.SaveChanges();
            }
            #endregion

            #region GrainSorghumSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        region => region.Name == Utils.NameSpecieCycleSouthShort);

                var lGrainSorghumSouthShort = new Specie
                {
                    Name = Utils.NameSpecieGrainSorghumSouthShort,
                    ShortName = "Sorgo Granifero",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_GrainSorghumSouth_2015,
                    StressTemperature = DataEntry.StressTemperature_GrainSorghumSouth_2015,
                };

                context.Species.Add(lGrainSorghumSouthShort);
                context.SaveChanges();
            }
            #endregion

            #region AlfalfaSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        region => region.Name == Utils.NameSpecieCycleSouthShort);

                var lAlfalfaSouthShort = new Specie
                {
                    Name = Utils.NameSpecieAlfalfaSouthShort,
                    ShortName = "Alfalfa",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_AlfalfaSouth_2015,
                    StressTemperature = DataEntry.StressTemperature_AlfalfaSouth_2015,
                };

                context.Species.Add(lAlfalfaSouthShort);
                context.SaveChanges();
            }
            #endregion

            #region RedCloverSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        region => region.Name == Utils.NameSpecieCycleSouthShort);

                var lRedCloverSouthShort = new Specie
                {
                    Name = Utils.NameSpecieRedCloverSouthShort,
                    ShortName = "Trebol Rojo",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_RedCloverSouth_2015,
                    StressTemperature = DataEntry.StressTemperature_RedCloverSouth_2015,
                };

                context.Species.Add(lRedCloverSouthShort);
                context.SaveChanges();
            }
            #endregion

            #region FescueSouthShort
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        region => region.Name == Utils.NameSpecieCycleSouthShort);

                var lFescueSouthShort = new Specie
                {
                    Name = Utils.NameSpecieFescueSouthShort,
                    ShortName = "Festuca",
                    SpecieCycleId = lSpecieCycle.SpecieCycleId,
                    BaseTemperature = DataEntry.BaseTemperature_FescueSouth_2015,
                    StressTemperature = DataEntry.StressTemperature_FescueSouth_2015,
                };

                context.Species.Add(lFescueSouthShort);
                context.SaveChanges();
            }
            #endregion

            #endregion

            #region North
            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        region => region.Name == Utils.NameSpecieCycleNorthShort);
            }

            var lCornNorthShort = new Specie
            {
                Name = Utils.NameSpecieCornNorthShort,
                ShortName = "Maíz",
                SpecieCycleId = lSpecieCycle.SpecieCycleId,
                BaseTemperature = 10,
                StressTemperature = 40
            };

            using (var context = new IrrigationAdvisorContext())
            {
                lSpecieCycle = context.SpecieCycles.SingleOrDefault(
                                        region => region.Name == Utils.NameSpecieCycleNorthShort);
            }

            var lSoyaNorthShort = new Specie
            {
                Name = Utils.NameSpecieSoyaNorthShort,
                ShortName = "Soja",
                SpecieCycleId = lSpecieCycle.SpecieCycleId,
                BaseTemperature = 8,
                StressTemperature = 40
            };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {
                //context.Species.Add(lBase);
                context.Species.Add(lCornNorthShort);
                context.Species.Add(lSoyaNorthShort);
                context.SaveChanges();
            };
        }

        private static void UpdateCountryRegionWithSpeciesSpeciesCycles()
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

        private static void InsertStagesCorn()
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
            
            
            using(var context = new IrrigationAdvisorContext())
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

        private static void InsertStagesSoya()
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

        private static void InsertStagesForageSorghum()
        {
            var lStageV0 = new Stage { Name = Utils.NameStagesForageSorghum + " V0", ShortName = "V0", Description = "Emergencia ", Order = 1, };
            var lStageV3 = new Stage { Name = Utils.NameStagesForageSorghum + " V3", ShortName = "V3", Description = "3 hojas ", Order = 2, };
            var lStageV5 = new Stage { Name = Utils.NameStagesForageSorghum + " V5", ShortName = "V5", Description = "5 hojas ", Order = 3, };
            var lStageV8 = new Stage { Name = Utils.NameStagesForageSorghum + " V8", ShortName = "V8", Description = "8 hojas ", Order = 4, };
            var lStageHF = new Stage { Name = Utils.NameStagesForageSorghum + " HF", ShortName = "HF", Description = "Hoja Final ", Order = 5, };
            var lStageEM = new Stage { Name = Utils.NameStagesForageSorghum + " EM", ShortName = "EM", Description = "Embuche ", Order = 6, };
            var lStageFF = new Stage { Name = Utils.NameStagesForageSorghum + " FF", ShortName = "FF", Description = "Floracion ", Order = 7, };
            var lStageGL = new Stage { Name = Utils.NameStagesForageSorghum + " GL", ShortName = "GL", Description = "Grano Lechoso ", Order = 8, };
            var lStageGP = new Stage { Name = Utils.NameStagesForageSorghum + " GP", ShortName = "GP", Description = "Grano pastoso ", Order = 9, };
            var lStageMF = new Stage { Name = Utils.NameStagesForageSorghum + " MF", ShortName = "MF", Description = "Madurez Fisiologica ", Order = 10, };
    
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

        private static void InsertStagesGrainSorghum()
        {
            var lStageV0 = new Stage { Name = Utils.NameStagesForageSorghum + " V0", ShortName = "V0", Description = "Emergencia ", Order = 1, };
            var lStageV3 = new Stage { Name = Utils.NameStagesForageSorghum + " V3", ShortName = "V3", Description = "3 hojas ", Order = 2, };
            var lStageV5 = new Stage { Name = Utils.NameStagesForageSorghum + " V5", ShortName = "V5", Description = "5 hojas ", Order = 3, };
            var lStageV8 = new Stage { Name = Utils.NameStagesForageSorghum + " V8", ShortName = "V8", Description = "8 hojas ", Order = 4, };
            var lStageHF = new Stage { Name = Utils.NameStagesForageSorghum + " HF", ShortName = "HF", Description = "Hoja Final ", Order = 5, };
            var lStageEM = new Stage { Name = Utils.NameStagesForageSorghum + " EM", ShortName = "EM", Description = "Embuche ", Order = 6, };
            var lStageFF = new Stage { Name = Utils.NameStagesForageSorghum + " FF", ShortName = "FF", Description = "Floracion ", Order = 7, };
            var lStageGL = new Stage { Name = Utils.NameStagesForageSorghum + " GL", ShortName = "GL", Description = "Grano Lechoso ", Order = 8, };
            var lStageGP = new Stage { Name = Utils.NameStagesForageSorghum + " GP", ShortName = "GP", Description = "Grano pastoso ", Order = 9, };
            var lStageMF = new Stage { Name = Utils.NameStagesForageSorghum + " MF", ShortName = "MF", Description = "Madurez Fisiologica ", Order = 10, };

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

        private static void InsertStagesAlfalfa()
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

        private static void InsertStagesRedClover()
        {
            var lBase = new Stage
            {
                Name = Utils.NameBase,
                Description = "",
            };

            var lStageSv0 = new Stage { Name = Utils.NameStagesRedClover + " V0", Description = "Siembra", Order = 1, };
            var lStageSve = new Stage { Name = Utils.NameStagesRedClover + " VE", Description = "Emergencia", Order = 2, };
            var lStageSv1 = new Stage { Name = Utils.NameStagesRedClover + " V1", Description = "1 nudo", Order = 3, };
            var lStageSv2 = new Stage { Name = Utils.NameStagesRedClover + " V2", Description = "2 nudos", Order = 4, };
            var lStageSv3 = new Stage { Name = Utils.NameStagesRedClover + " V3", Description = "3 nudos", Order = 5, };
            var lStageSv4 = new Stage { Name = Utils.NameStagesRedClover + " V4", Description = "4 nudos", Order = 6, };
            var lStageSv5 = new Stage { Name = Utils.NameStagesRedClover + " V5", Description = "5 nudos", Order = 7, };
            var lStageSv6 = new Stage { Name = Utils.NameStagesRedClover + " V6", Description = "6 nudos", Order = 8, };
            var lStageSv7 = new Stage { Name = Utils.NameStagesRedClover + " V7", Description = "7 nudos", Order = 9, };
            var lStageSv8 = new Stage { Name = Utils.NameStagesRedClover + " V8", Description = "8 nudos", Order = 10, };
            var lStageSv9 = new Stage { Name = Utils.NameStagesRedClover + " V9", Description = "9 nudos", Order = 11, };
            var lStageSv10 = new Stage { Name = Utils.NameStagesRedClover + " V10", Description = "10 nudos", Order = 12, };
            var lStageSv11 = new Stage { Name = Utils.NameStagesRedClover + " V11", Description = "11 nudo", Order = 13, };
            var lStageSr1 = new Stage { Name = Utils.NameStagesRedClover + " R1", ShortName = "R1", Description = "Inicio Floracion", Order = 14, };
            var lStageSr2 = new Stage { Name = Utils.NameStagesRedClover + " R2", ShortName = "R2", Description = "Floracion Completa", Order = 15, };
            var lStageSr3 = new Stage { Name = Utils.NameStagesRedClover + " R3", ShortName = "R3", Description = "Inicio Vainas", Order = 16, };
            var lStageSr4 = new Stage { Name = Utils.NameStagesRedClover + " R4", ShortName = "R4", Description = "Vainas Completas", Order = 17, };
            var lStageSr5 = new Stage { Name = Utils.NameStagesRedClover + " R5", ShortName = "R5", Description = "Formacion de semillas", Order = 18, };
            var lStageSr6 = new Stage { Name = Utils.NameStagesRedClover + " R6", ShortName = "R6", Description = "Semillas Completas", Order = 19, };
            var lStageSr7 = new Stage { Name = Utils.NameStagesRedClover + " R7", ShortName = "R7", Description = "Inicio Maduracion", Order = 20, };
            var lStageSr8 = new Stage { Name = Utils.NameStagesRedClover + " R8", ShortName = "R8", Description = "Maduracion Completa", Order = 21, };


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

        private static void InsertStagesFescue()
        {
            var lBase = new Stage
            {
                Name = Utils.NameBase,
                Description = "",
            };

            var lStageSv0 = new Stage { Name = Utils.NameStagesFescue + " V0", ShortName = "V0", Description = "Siembra", Order = 1, };
            var lStageSve = new Stage { Name = Utils.NameStagesFescue + " VE", ShortName = "VE", Description = "Emergencia", Order = 2, };
            var lStageSv1 = new Stage { Name = Utils.NameStagesFescue + " V1", ShortName = "V1", Description = "1 nudo", Order = 3, };
            var lStageSv2 = new Stage { Name = Utils.NameStagesFescue + " V2", ShortName = "V2", Description = "2 nudos", Order = 4, };
            var lStageSv3 = new Stage { Name = Utils.NameStagesFescue + " V3", ShortName = "V3", Description = "3 nudos", Order = 5, };
            var lStageSv4 = new Stage { Name = Utils.NameStagesFescue + " V4", ShortName = "V4", Description = "4 nudos", Order = 6, };
            var lStageSv5 = new Stage { Name = Utils.NameStagesFescue + " V5", ShortName = "V5", Description = "5 nudos", Order = 7, };
            var lStageSv6 = new Stage { Name = Utils.NameStagesFescue + " V6", ShortName = "V6", Description = "6 nudos", Order = 8, };
            var lStageSv7 = new Stage { Name = Utils.NameStagesFescue + " V7", ShortName = "V7", Description = "7 nudos", Order = 9, };
            var lStageSv8 = new Stage { Name = Utils.NameStagesFescue + " V8", ShortName = "V8", Description = "8 nudos", Order = 10, };
            var lStageSv9 = new Stage { Name = Utils.NameStagesFescue + " V9", ShortName = "V9", Description = "9 nudos", Order = 11, };
            var lStageSv10 = new Stage { Name = Utils.NameStagesFescue + " V10", ShortName = "V10", Description = "10 nudos", Order = 12, };
            var lStageSv11 = new Stage { Name = Utils.NameStagesFescue + " V11", ShortName = "V11", Description = "11 nudo", Order = 13, };
            var lStageSr1 = new Stage { Name = Utils.NameStagesFescue + " R1", ShortName = "R1", Description = "Inicio Floracion", Order = 14, };
            var lStageSr2 = new Stage { Name = Utils.NameStagesFescue + " R2", ShortName = "R2", Description = "Floracion Completa", Order = 15, };
            var lStageSr3 = new Stage { Name = Utils.NameStagesFescue + " R3", ShortName = "R3", Description = "Inicio Vainas", Order = 16, };
            var lStageSr4 = new Stage { Name = Utils.NameStagesFescue + " R4", ShortName = "R4", Description = "Vainas Completas", Order = 17, };
            var lStageSr5 = new Stage { Name = Utils.NameStagesFescue + " R5", ShortName = "R5", Description = "Formacion de semillas", Order = 18, };
            var lStageSr6 = new Stage { Name = Utils.NameStagesFescue + " R6", ShortName = "R6", Description = "Semillas Completas", Order = 19, };
            var lStageSr7 = new Stage { Name = Utils.NameStagesFescue + " R7", ShortName = "R7", Description = "Inicio Maduracion", Order = 20, };
            var lStageSr8 = new Stage { Name = Utils.NameStagesFescue + " R8", ShortName = "R8", Description = "Maduracion Completa", Order = 21, };


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

        private static void InsertPhenologicalStagesCornSouthShort()
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
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieCornSouthShort) select specie).FirstOrDefault();
                
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V0") select stage).FirstOrDefault();
                var lPSCornV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 59.999, RootDepth = 5, HydricBalanceDepth = 15, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VE") select stage).FirstOrDefault();
                var lPSCornVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 60, MaxDegree = 113.999, RootDepth = 5, HydricBalanceDepth = 15, };
                
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V1") select stage).FirstOrDefault();
                var lPSCornV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 114, MaxDegree = 133.999, RootDepth = 5, HydricBalanceDepth = 15, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V2") select stage).FirstOrDefault();
                var lPSCornV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 134, MaxDegree = 178.999, RootDepth = 10, HydricBalanceDepth = 20, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V3") select stage).FirstOrDefault();
                var lPSCornV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 179, MaxDegree = 228.999, RootDepth = 15, HydricBalanceDepth = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V4") select stage).FirstOrDefault();
                var lPSCornV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 229, MaxDegree = 288.999, RootDepth = 20, HydricBalanceDepth = 30, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V5") select stage).FirstOrDefault();
                var lPSCornV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 289, MaxDegree = 348.999, RootDepth = 20, HydricBalanceDepth = 30, };
                
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V6") select stage).FirstOrDefault();
                var lPSCornV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 349, MaxDegree = 403.999, RootDepth = 25, HydricBalanceDepth = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V7") select stage).FirstOrDefault();
                var lPSCornV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 404, MaxDegree = 458.999, RootDepth = 25, HydricBalanceDepth = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V8") select stage).FirstOrDefault();
                var lPSCornV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 459, MaxDegree = 518.999, RootDepth = 30, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V9") select stage).FirstOrDefault();
                var lPSCornV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 519, MaxDegree = 588.999, RootDepth = 32, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V10") select stage).FirstOrDefault();
                var lPSCornV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 589, MaxDegree = 648.999, RootDepth = 35, HydricBalanceDepth = 40, };
                
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V11") select stage).FirstOrDefault();
                var lPSCornV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 649, MaxDegree = 688.999, RootDepth = 37, HydricBalanceDepth = 42, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V12") select stage).FirstOrDefault();
                var lPSCornV12 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 689, MaxDegree = 713.999, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V13") select stage).FirstOrDefault();
                var lPSCornV13 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 714, MaxDegree = 748.999, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V14") select stage).FirstOrDefault();
                var lPSCornV14 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 749, MaxDegree = 773.999, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " V15") select stage).FirstOrDefault();
                var lPSCornV15 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 774, MaxDegree = 888.999, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " VT") select stage).FirstOrDefault();
                var lPSCornVt = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 889, MaxDegree = 1048.999, RootDepth = 45, HydricBalanceDepth = 45, };
                
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R1") select stage).FirstOrDefault();
                var lPSCornR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1049, MaxDegree = 1198.999, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R2") select stage).FirstOrDefault();
                var lPSCornR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1199, MaxDegree = 1348.999, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R3") select stage).FirstOrDefault();
                var lPSCornR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1349, MaxDegree = 1498.999, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R4") select stage).FirstOrDefault();
                var lPSCornR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1499, MaxDegree = 1598.999, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R5") select stage).FirstOrDefault();
                var lPSCornR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1599, MaxDegree = 1898.999, RootDepth = 45, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesCorn + " R6") select stage).FirstOrDefault();
                var lPSCornR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1899, MaxDegree = 2500, RootDepth = 45, HydricBalanceDepth = 45, };
                
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

        private static void InsertPhenologicalStagesSoyaSouthShort()
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

                #region Soya South Short
                Specie lSpecie = null;
                Stage lStage = null;
                lSpecie = (from specie in context.Species where specie.Name.Contains(Utils.NameSpecieSoyaSouthShort) select specie).FirstOrDefault();

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V0") select stage).FirstOrDefault();
                var lPSSoyaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 114.999, RootDepth = 7, HydricBalanceDepth = 17, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " VE") select stage).FirstOrDefault();
                var lPSSoyaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 140.999, RootDepth = 10, HydricBalanceDepth = 20, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V1") select stage).FirstOrDefault();
                var lPSSoyaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 141, MaxDegree = 190.999, RootDepth = 10, HydricBalanceDepth = 20, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V2") select stage).FirstOrDefault();
                var lPSSoyaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 191, MaxDegree = 241.999, RootDepth = 12, HydricBalanceDepth = 22, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V3") select stage).FirstOrDefault();
                var lPSSoyaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 242, MaxDegree = 312.999, RootDepth = 15, HydricBalanceDepth = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V4") select stage).FirstOrDefault();
                var lPSSoyaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 313, MaxDegree = 347.999, RootDepth = 20, HydricBalanceDepth = 30, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V5") select stage).FirstOrDefault();
                var lPSSoyaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 348, MaxDegree = 396.999, RootDepth = 20, HydricBalanceDepth = 30, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V6") select stage).FirstOrDefault();
                var lPSSoyaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 397, MaxDegree = 444.999, RootDepth = 25, HydricBalanceDepth = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V7") select stage).FirstOrDefault();
                var lPSSoyaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 445, MaxDegree = 470.999, RootDepth = 25, HydricBalanceDepth = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V8") select stage).FirstOrDefault();
                var lPSSoyaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 471, MaxDegree = 514.999, RootDepth = 30, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V9") select stage).FirstOrDefault();
                var lPSSoyaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 515, MaxDegree = 564.999, RootDepth = 32, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V10") select stage).FirstOrDefault();
                var lPSSoyaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 565, MaxDegree = 652.999, RootDepth = 35, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 653, MaxDegree = 740.999, RootDepth = 35, HydricBalanceDepth = 40, };
                
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R1") select stage).FirstOrDefault();
                var lPSSoyaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 741, MaxDegree = 842.999, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R2") select stage).FirstOrDefault();
                var lPSSoyaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 843, MaxDegree = 910.999, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R3") select stage).FirstOrDefault();
                var lPSSoyaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 911, MaxDegree = 978.999, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R4") select stage).FirstOrDefault();
                var lPSSoyaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 979, MaxDegree = 1097.999, RootDepth = 40, HydricBalanceDepth = 45, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R5") select stage).FirstOrDefault();
                var lPSSoyaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1098, MaxDegree = 1216.999, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R6") select stage).FirstOrDefault();
                var lPSSoyaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1217, MaxDegree = 1607.999, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R7") select stage).FirstOrDefault();
                var lPSSoyaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1608, MaxDegree = 1999.999, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R8") select stage).FirstOrDefault();
                var lPSSoyaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2000, MaxDegree = 4000, RootDepth = 40, HydricBalanceDepth = 45, };

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

        private static void InsertPhenologicalStagesSoyaSouthMedium()
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
                var lPSSoyaV0 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 0, MaxDegree = 114.999, RootDepth = 7, HydricBalanceDepth = 17, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " VE") select stage).FirstOrDefault();
                var lPSSoyaVe = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 115, MaxDegree = 140.999, RootDepth = 10, HydricBalanceDepth = 20, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V1") select stage).FirstOrDefault();
                var lPSSoyaV1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 141, MaxDegree = 190.999, RootDepth = 10, HydricBalanceDepth = 20, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V2") select stage).FirstOrDefault();
                var lPSSoyaV2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 191, MaxDegree = 241.999, RootDepth = 12, HydricBalanceDepth = 22, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V3") select stage).FirstOrDefault();
                var lPSSoyaV3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 242, MaxDegree = 312.999, RootDepth = 15, HydricBalanceDepth = 25, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V4") select stage).FirstOrDefault();
                var lPSSoyaV4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 313, MaxDegree = 347.999, RootDepth = 20, HydricBalanceDepth = 30, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V5") select stage).FirstOrDefault();
                var lPSSoyaV5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 348, MaxDegree = 396.999, RootDepth = 20, HydricBalanceDepth = 30, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V6") select stage).FirstOrDefault();
                var lPSSoyaV6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 397, MaxDegree = 444.999, RootDepth = 25, HydricBalanceDepth = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V7") select stage).FirstOrDefault();
                var lPSSoyaV7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 445, MaxDegree = 470.999, RootDepth = 25, HydricBalanceDepth = 35, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V8") select stage).FirstOrDefault();
                var lPSSoyaV8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 471, MaxDegree = 514.999, RootDepth = 30, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V9") select stage).FirstOrDefault();
                var lPSSoyaV9 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 515, MaxDegree = 564.999, RootDepth = 32, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V10") select stage).FirstOrDefault();
                var lPSSoyaV10 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 565, MaxDegree = 652.999, RootDepth = 35, HydricBalanceDepth = 40, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " V11") select stage).FirstOrDefault();
                var lPSSoyaV11 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 653, MaxDegree = 740.999, RootDepth = 35, HydricBalanceDepth = 40, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R1") select stage).FirstOrDefault();
                var lPSSoyaR1 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 741, MaxDegree = 842.999, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R2") select stage).FirstOrDefault();
                var lPSSoyaR2 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 843, MaxDegree = 910.999, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R3") select stage).FirstOrDefault();
                var lPSSoyaR3 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 911, MaxDegree = 978.999, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R4") select stage).FirstOrDefault();
                var lPSSoyaR4 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 979, MaxDegree = 1097.999, RootDepth = 40, HydricBalanceDepth = 45, };

                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R5") select stage).FirstOrDefault();
                var lPSSoyaR5 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1098, MaxDegree = 1216.999, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R6") select stage).FirstOrDefault();
                var lPSSoyaR6 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1217, MaxDegree = 1607.999, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R7") select stage).FirstOrDefault();
                var lPSSoyaR7 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 1608, MaxDegree = 1999.999, RootDepth = 40, HydricBalanceDepth = 45, };
                lStage = (from stage in context.Stages where stage.Name.Contains(Utils.NameStagesSoya + " R8") select stage).FirstOrDefault();
                var lPSSoyaR8 = new PhenologicalStage { SpecieId = lSpecie.SpecieId, StageId = lStage.StageId, MinDegree = 2000, MaxDegree = 4000, RootDepth = 40, HydricBalanceDepth = 45, };

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

        private static void InsertHorizons()
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
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
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
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
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
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
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
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
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

            #region Horizons La Perdiz
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPerdiz)
            {
                #region Pivot 1
                var lLaPerdizPivot_1_1 = new Horizon
                {
                    Name = Utils.NamePivotLaPerdiz1 + " 1",
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
                var lLaPerdizPivot_1_2 = new Horizon
                {
                    Name = Utils.NamePivotLaPerdiz1 + " 2",
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
                var lLaPerdizPivot_1_3 = new Horizon
                {
                    Name = Utils.NamePivotLaPerdiz1 + " 3",
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

                #region Pivot 2
                var lLaPerdizPivot_2_1 = new Horizon
                {
                    Name = Utils.NamePivotLaPerdiz2 + " 1",
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
                var lLaPerdizPivot_2_2 = new Horizon
                {
                    Name = Utils.NamePivotLaPerdiz2 + " 2",
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
                var lLaPerdizPivot_2_3 = new Horizon
                {
                    Name = Utils.NamePivotLaPerdiz2 + " 3",
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
                var lLaPerdizPivot_3_1 = new Horizon
                {
                    Name = Utils.NamePivotLaPerdiz3 + " 1",
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
                var lLaPerdizPivot_3_2 = new Horizon
                {
                    Name = Utils.NamePivotLaPerdiz3 + " 2",
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
                var lLaPerdizPivot_3_3 = new Horizon
                {
                    Name = Utils.NamePivotLaPerdiz3 + " 3",
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

                #region Pivot 5
                var lLaPerdizPivot_5_1 = new Horizon
                {
                    Name = Utils.NamePivotLaPerdiz5 + " 1",
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
                var lLaPerdizPivot_5_2 = new Horizon
                {
                    Name = Utils.NamePivotLaPerdiz5 + " 2",
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
                var lLaPerdizPivot_5_3 = new Horizon
                {
                    Name = Utils.NamePivotLaPerdiz5 + " 3",
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

                #region Pivot 14
                var lLaPerdizPivot_14_1 = new Horizon
                {
                    Name = Utils.NamePivotLaPerdiz14 + " 1",
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
                var lLaPerdizPivot_14_2 = new Horizon
                {
                    Name = Utils.NamePivotLaPerdiz14 + " 2",
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
                var lLaPerdizPivot_14_3 = new Horizon
                {
                    Name = Utils.NamePivotLaPerdiz14 + " 3",
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
                    #region Horizons La Perdiz
                    context.Horizons.Add(lLaPerdizPivot_1_1);
                    context.Horizons.Add(lLaPerdizPivot_1_2);
                    context.Horizons.Add(lLaPerdizPivot_1_3);
                    context.Horizons.Add(lLaPerdizPivot_2_1);
                    context.Horizons.Add(lLaPerdizPivot_2_2);
                    context.Horizons.Add(lLaPerdizPivot_2_3);
                    context.Horizons.Add(lLaPerdizPivot_3_1);
                    context.Horizons.Add(lLaPerdizPivot_3_2);
                    context.Horizons.Add(lLaPerdizPivot_3_3);
                    context.Horizons.Add(lLaPerdizPivot_5_1);
                    context.Horizons.Add(lLaPerdizPivot_5_2);
                    context.Horizons.Add(lLaPerdizPivot_5_3);
                    context.Horizons.Add(lLaPerdizPivot_14_1);
                    context.Horizons.Add(lLaPerdizPivot_14_2);
                    context.Horizons.Add(lLaPerdizPivot_14_3);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion

            #region Horizons Del Lago - San Pedro
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
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
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                #region Pivot 6
                var lDelLagoElMiradorPivot_6_1 = new Horizon
                {
                    Name = Utils.NamePivotDelLagoElMirador6 + " 1",
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
                var lDelLagoElMiradorPivot_6_2 = new Horizon
                {
                    Name = Utils.NamePivotDelLagoElMirador6 + " 2",
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
                var lDelLagoElMiradorPivot_7_1 = new Horizon
                {
                    Name = Utils.NamePivotDelLagoElMirador7 + " 1",
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
                var lDelLagoElMiradorPivot_7_2 = new Horizon
                {
                    Name = Utils.NamePivotDelLagoElMirador7 + " 2",
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
                var lDelLagoElMiradorPivot_8_1 = new Horizon
                {
                    Name = Utils.NamePivotDelLagoElMirador8 + " 1",
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
                var lDelLagoElMiradorPivot_8_2 = new Horizon
                {
                    Name = Utils.NamePivotDelLagoElMirador8 + " 2",
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

                #region Pivot 9
                var lDelLagoElMiradorPivot_9_1 = new Horizon
                {
                    Name = Utils.NamePivotDelLagoElMirador9 + " 1",
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
                var lDelLagoElMiradorPivot_9_2 = new Horizon
                {
                    Name = Utils.NamePivotDelLagoElMirador9 + " 2",
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
                    #region Horizons Del Lago - El Mirador
                    context.Horizons.Add(lDelLagoElMiradorPivot_6_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_6_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_7_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_7_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_8_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_8_2);
                    context.Horizons.Add(lDelLagoElMiradorPivot_9_1);
                    context.Horizons.Add(lDelLagoElMiradorPivot_9_2);
                    #endregion
                    context.SaveChanges();
                }
            }
            #endregion

            #region Horizons LaPalma
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPalma)
            {
                #region Pivot 1
                var lLaPalmaPivot_1_1 = new Horizon
                {
                    Name = Utils.NamePivotLaPalma1 + " 1",
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
                var lLaPalmaPivot_1_2 = new Horizon
                {
                    Name = Utils.NamePivotLaPalma1 + " 2",
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

                #region Pivot 2
                var lLaPalmaPivot_2_1 = new Horizon
                {
                    Name = Utils.NamePivotLaPalma2A + " 1",
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
                var lLaPalmaPivot_2_2 = new Horizon
                {
                    Name = Utils.NamePivotLaPalma2A + " 2",
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

                #region Pivot 3
                var lLaPalmaPivot_3_1 = new Horizon
                {
                    Name = Utils.NamePivotLaPalma3 + " 1",
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
                var lLaPalmaPivot_3_2 = new Horizon
                {
                    Name = Utils.NamePivotLaPalma3 + " 2",
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

                #region Pivot 4
                var lLaPalmaPivot_4_1 = new Horizon
                {
                    Name = Utils.NamePivotLaPalma4 + " 1",
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
                var lLaPalmaPivot_4_2 = new Horizon
                {
                    Name = Utils.NamePivotLaPalma4 + " 2",
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

                #region Pivot 5
                var lLaPalmaPivot_5_1 = new Horizon
                {
                    Name = Utils.NamePivotLaPalma5 + " 1",
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
                var lLaPalmaPivot_5_2 = new Horizon
                {
                    Name = Utils.NamePivotLaPalma5 + " 2",
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
                    #region Horizons La Palma
                    context.Horizons.Add(lLaPalmaPivot_1_1);
                    context.Horizons.Add(lLaPalmaPivot_1_2);
                    context.Horizons.Add(lLaPalmaPivot_2_1);
                    context.Horizons.Add(lLaPalmaPivot_2_2);
                    context.Horizons.Add(lLaPalmaPivot_3_1);
                    context.Horizons.Add(lLaPalmaPivot_3_2);
                    context.Horizons.Add(lLaPalmaPivot_4_1);
                    context.Horizons.Add(lLaPalmaPivot_4_2);
                    context.Horizons.Add(lLaPalmaPivot_5_1);
                    context.Horizons.Add(lLaPalmaPivot_5_2);
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

        private static void InsertSoils()
        {
            Position lPosition = null;
            Horizon lHorizon1 = null;
            Horizon lHorizon2 = null;
            Horizon lHorizon3 = null;

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
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
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
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
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
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
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
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
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

            #region La Perdiz Soils
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPerdiz1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPerdiz1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPerdiz1 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPerdiz1 + " 3"
                                 select hor).FirstOrDefault();
                    var lLaPerdizPivot1 = new Soil
                    {
                        Name = Utils.NamePivotLaPerdiz1,
                        Description = "Suelo del Pivot 1 en La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        HorizonList = new List<Horizon>(),
                    };
                    lLaPerdizPivot1.HorizonList.Add(lHorizon1);
                    lLaPerdizPivot1.HorizonList.Add(lHorizon2);
                    lLaPerdizPivot1.HorizonList.Add(lHorizon3);
                    #endregion

                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPerdiz2
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPerdiz2 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPerdiz2 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPerdiz2 + " 3"
                                 select hor).FirstOrDefault();
                    var lLaPerdizPivot2 = new Soil
                    {
                        Name = Utils.NamePivotLaPerdiz2,
                        Description = "Suelo del Pivot 2 en La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        HorizonList = new List<Horizon>(),
                    };
                    lLaPerdizPivot2.HorizonList.Add(lHorizon1);
                    lLaPerdizPivot2.HorizonList.Add(lHorizon2);
                    lLaPerdizPivot2.HorizonList.Add(lHorizon3);
                    #endregion

                    #region Pivot 3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPerdiz3
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPerdiz3 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPerdiz3 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPerdiz3 + " 3"
                                 select hor).FirstOrDefault();
                    var lLaPerdizPivot3 = new Soil
                    {
                        Name = Utils.NamePivotLaPerdiz3,
                        Description = "Suelo del Pivot 3 en La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 7),
                        DepthLimit = 50,
                        HorizonList = new List<Horizon>(),
                    };
                    lLaPerdizPivot3.HorizonList.Add(lHorizon1);
                    lLaPerdizPivot3.HorizonList.Add(lHorizon2);
                    lLaPerdizPivot3.HorizonList.Add(lHorizon3);
                    #endregion

                    #region Pivot 5
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPerdiz5
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPerdiz5 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPerdiz5 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPerdiz5 + " 3"
                                 select hor).FirstOrDefault();
                    var lLaPerdizPivot5 = new Soil
                    {
                        Name = Utils.NamePivotLaPerdiz5,
                        Description = "Suelo del Pivot 5 en La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 8),
                        DepthLimit = 50,
                        HorizonList = new List<Horizon>(),
                    };
                    lLaPerdizPivot5.HorizonList.Add(lHorizon1);
                    lLaPerdizPivot5.HorizonList.Add(lHorizon2);
                    lLaPerdizPivot5.HorizonList.Add(lHorizon3);
                    #endregion

                    #region Pivot 14
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPerdiz14
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPerdiz14 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPerdiz14 + " 2"
                                 select hor).FirstOrDefault();
                    lHorizon3 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPerdiz14 + " 3"
                                 select hor).FirstOrDefault();
                    var lLaPerdizPivot14 = new Soil
                    {
                        Name = Utils.NamePivotLaPerdiz14,
                        Description = "Suelo del Pivot 14 en La Perdiz. Unidad Bequelo.",
                        PositionId = lPosition.PositionId,
                        TestDate = Utils.MIN_DATETIME,
                        DepthLimit = 50,
                        HorizonList = new List<Horizon>(),
                    };
                    lLaPerdizPivot14.HorizonList.Add(lHorizon1);
                    lLaPerdizPivot14.HorizonList.Add(lHorizon2);
                    lLaPerdizPivot14.HorizonList.Add(lHorizon3);
                    #endregion

                    context.Soils.Add(lLaPerdizPivot1);
                    context.Soils.Add(lLaPerdizPivot2);
                    context.Soils.Add(lLaPerdizPivot3);
                    context.Soils.Add(lLaPerdizPivot5);
                    context.Soils.Add(lLaPerdizPivot14);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Del Lago - San Pedro Soils
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
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
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    #region Pivot 6
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador6
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador6 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador6 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot6 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador6,
                        Description = "Suelo del Pivot 6 en Del Lago - El Mirador.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot6.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot6.HorizonList.Add(lHorizon2);
                    #endregion

                    #region Pivot 7
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador7
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador7 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador7 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot7 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador7,
                        Description = "Suelo del Pivot 7 en Del Lago - El Mirador.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 6),
                        DepthLimit = 50,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot7.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot7.HorizonList.Add(lHorizon2);
                    #endregion

                    #region Pivot 8
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador8
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador8 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador8 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot8 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador8,
                        Description = "Suelo del Pivot 8 en Del Lago - El Mirador.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 11, 7),
                        DepthLimit = 50,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot8.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot8.HorizonList.Add(lHorizon2);
                    #endregion

                    #region Pivot 9
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador9
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador9 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotDelLagoElMirador9 + " 2"
                                 select hor).FirstOrDefault();
                    var lDelLagoElMiradorPivot9 = new Soil
                    {
                        Name = Utils.NamePivotDelLagoElMirador9,
                        Description = "Suelo del Pivot 9 en Del Lago - El Mirador.",
                        PositionId = lPosition.PositionId,
                        TestDate = Utils.MIN_DATETIME,
                        DepthLimit = 50,
                        HorizonList = new List<Horizon>(),
                    };
                    lDelLagoElMiradorPivot9.HorizonList.Add(lHorizon1);
                    lDelLagoElMiradorPivot9.HorizonList.Add(lHorizon2);
                    #endregion

                    context.Soils.Add(lDelLagoElMiradorPivot6);
                    context.Soils.Add(lDelLagoElMiradorPivot7);
                    context.Soils.Add(lDelLagoElMiradorPivot8);
                    context.Soils.Add(lDelLagoElMiradorPivot9);
                    context.SaveChanges();
                }
            }
            #endregion

            #region La Palma Soils
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPalma1
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPalma1 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPalma1 + " 2"
                                 select hor).FirstOrDefault();
                    var lLaPalmaPivot1 = new Soil
                    {
                        Name = Utils.NamePivotLaPalma1,
                        Description = "Suelo del Pivot 1 en La Palma. "
                         + "Suelos moderadamente bien drenados, indice coneat 131.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 12, 29),
                        DepthLimit = 50,
                        HorizonList = new List<Horizon>(),
                    };
                    lLaPalmaPivot1.HorizonList.Add(lHorizon1);
                    lLaPalmaPivot1.HorizonList.Add(lHorizon2);
                    #endregion

                    #region Pivot 2A
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPalma2A
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPalma2A + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPalma2A + " 2"
                                 select hor).FirstOrDefault();
                    var lLaPalmaPivot2A = new Soil
                    {
                        Name = Utils.NamePivotLaPalma2A,
                        Description = "Suelo del Pivot 2 en La Palma. "
                         + "Suelos moderadamente bien drenados, indice coneat 131.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 12, 29),
                        DepthLimit = 50,
                        HorizonList = new List<Horizon>(),
                    };
                    lLaPalmaPivot2A.HorizonList.Add(lHorizon1);
                    lLaPalmaPivot2A.HorizonList.Add(lHorizon2);
                    #endregion

                    #region Pivot 3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPalma3
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPalma3 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPalma3 + " 2"
                                 select hor).FirstOrDefault();
                    var lLaPalmaPivot3 = new Soil
                    {
                        Name = Utils.NamePivotLaPalma3,
                        Description = "Suelo del Pivot 3 en La Palma. "
                         + "Suelos moderadamente bien drenados, indice coneat 131.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 12, 29),
                        DepthLimit = 50,
                        HorizonList = new List<Horizon>(),
                    };
                    lLaPalmaPivot3.HorizonList.Add(lHorizon1);
                    lLaPalmaPivot3.HorizonList.Add(lHorizon2);
                    #endregion

                    #region Pivot 4
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPalma4
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPalma4 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPalma4 + " 2"
                                 select hor).FirstOrDefault();
                    var lLaPalmaPivot4 = new Soil
                    {
                        Name = Utils.NamePivotLaPalma4,
                        Description = "Suelo del Pivot 14 en La Palma. "
                         + "Suelos moderadamente bien drenados, indice coneat 131.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 12, 29),
                        DepthLimit = 50,
                        HorizonList = new List<Horizon>(),
                    };
                    lLaPalmaPivot4.HorizonList.Add(lHorizon1);
                    lLaPalmaPivot4.HorizonList.Add(lHorizon2);
                    #endregion

                    #region Pivot 5
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPalma5
                                 select pos).FirstOrDefault();
                    lHorizon1 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPalma5 + " 1"
                                 select hor).FirstOrDefault();
                    lHorizon2 = (from hor in context.Horizons
                                 where hor.Name == Utils.NamePivotLaPalma5 + " 2"
                                 select hor).FirstOrDefault();
                    var lLaPalmaPivot5 = new Soil
                    {
                        Name = Utils.NamePivotLaPalma5,
                        Description = "Suelo del Pivot 5 en La Palma. "
                         + "Suelos moderadamente bien drenados, indice coneat 131.",
                        PositionId = lPosition.PositionId,
                        TestDate = new DateTime(2015, 12, 29),
                        DepthLimit = 50,
                        HorizonList = new List<Horizon>(),
                    };
                    lLaPalmaPivot5.HorizonList.Add(lHorizon1);
                    lLaPalmaPivot5.HorizonList.Add(lHorizon2);
                    #endregion

                    context.Soils.Add(lLaPalmaPivot1);
                    context.Soils.Add(lLaPalmaPivot2A);
                    context.Soils.Add(lLaPalmaPivot3);
                    context.Soils.Add(lLaPalmaPivot4);
                    context.Soils.Add(lLaPalmaPivot5);
                    context.SaveChanges();
                }
            }
            #endregion

            
        }

        private static void InsertCropCoefficients()
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

        }

        #endif
        #endregion

        #region Irrigation
        #if true

        private static void InsertBombs()
        {
            Position lPosition = null;

            #region Base
            var lBase = new Bomb
            {
                Name = Utils.NameBase,
                SerialNumber = "0",
                PurchaseDate = Utils.MAX_DATETIME,
                ServiceDate = Utils.MAX_DATETIME,
                PositionId = 0,
            };
            #endregion

            #region Bomb Demo - La Perdiz
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDemo1
                                 select pos).FirstOrDefault();

                    var lBombDemo = new Bomb
                    {
                        Name = Utils.NameBombDemo1,
                        SerialNumber = "98134759807",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                    };
                    context.Bombs.Add(lBombDemo);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Bomb Demo - Santa Lucia
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDemo2
                                 select pos).FirstOrDefault();

                    var lBombDemo = new Bomb
                    {
                        Name = Utils.NameBombDemo2,
                        SerialNumber = "98134759807",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                    };
                    context.Bombs.Add(lBombDemo);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Bomb Demo - La Palma
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDemo3
                                 select pos).FirstOrDefault();

                    var lBombDemo = new Bomb
                    {
                        Name = Utils.NameBombDemo3,
                        SerialNumber = "98134759807",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                    };
                    context.Bombs.Add(lBombDemo);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Bomb Santa Lucia
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmSantaLucia
                                 select pos).FirstOrDefault();

                    var lBombSantaLucia = new Bomb
                    {
                        Name = Utils.NameBombSantaLucia,
                        SerialNumber = "1234",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                    };

                    context.Bombs.Add(lBombSantaLucia);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Bomb La Perdiz
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmLaPerdiz
                                 select pos).FirstOrDefault();

                    var lBombLaPerdiz = new Bomb
                    {
                        Name = Utils.NameBombLaPerdiz,
                        SerialNumber = "98134759807",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                    };
                    context.Bombs.Add(lBombLaPerdiz);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Bomb Del Lago - San Pedro
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDelLagoSanPedro
                                 select pos).FirstOrDefault();

                    var lBombDelLagoSanPedro = new Bomb
                    {
                        Name = Utils.NameBombDelLagoSanPedro,
                        SerialNumber = "",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                    };
                    context.Bombs.Add(lBombDelLagoSanPedro);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Bomb Del Lago - El Mirador
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDelLagoElMirador
                                 select pos).FirstOrDefault();

                    var lBombDelLagoElMirador = new Bomb
                    {
                        Name = Utils.NameBombDelLagoElMirador,
                        SerialNumber = "",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                    };
                    context.Bombs.Add(lBombDelLagoElMirador);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Bomb LaPalma
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmLaPalma
                                 select pos).FirstOrDefault();


                    var lBombLaPalma = new Bomb
                    {
                        Name = Utils.NameBombLaPalma,
                        SerialNumber = "",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                    };
                    context.Bombs.Add(lBombLaPalma);
                    context.SaveChanges();
                }
            }
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {
                //context.Bombs.Add(lBase);
                context.SaveChanges();
            }

        }

        private static void InsertIrrigationUnits()
        {
            Bomb lBomb = null;
            Position lPosition = null;

            #region Base
            var lBase = new Pivot
            {
                Name = Utils.NameBase,
                IrrigationType = Utils.IrrigationUnitType.Pivot,
                IrrigationEfficiency = Utils.PivotEfficiencyByDefault,
                IrrigationList = null,
                Surface = Utils.PivotSurfaceByDefault,
                //CropList = null,
                BombId = 0,
                PositionId = 0,
            };
            #endregion

            #region Pivots Demo1 - La Perdiz
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    #region Pivot 11
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDemo1
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo11
                                 select pos).FirstOrDefault();

                    var lDemo1Pivot11 = new Pivot
                    {
                        Name = Utils.NamePivotDemo11,
                        ShortName = "Pivot 1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 12
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDemo1
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo12
                                 select pos).FirstOrDefault();

                    var lDemo1Pivot12 = new Pivot
                    {
                        Name = Utils.NamePivotDemo12,
                        ShortName = "Pivot 2",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 137,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 13
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDemo1
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo13
                                 select pos).FirstOrDefault();

                    var lDemo1Pivot13 = new Pivot
                    {
                        Name = Utils.NamePivotDemo13,
                        ShortName = "Pivot 3",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 120,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 15
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDemo1
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo15
                                 select pos).FirstOrDefault();

                    var lDemo1Pivot15 = new Pivot
                    {
                        Name = Utils.NamePivotDemo15,
                        ShortName = "Pivot 5",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 154,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    context.Pivots.Add(lDemo1Pivot11);
                    context.Pivots.Add(lDemo1Pivot12);
                    context.Pivots.Add(lDemo1Pivot13);
                    context.Pivots.Add(lDemo1Pivot15);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Pivots Demo2 - Santa Lucia
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    #region Pivot 21
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDemo2
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo21
                                 select pos).FirstOrDefault();

                    var lDemo2Pivot21 = new Pivot
                    {
                        Name = Utils.NamePivotDemo21,
                        ShortName = "Pivot 1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 22
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDemo2
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo22
                                 select pos).FirstOrDefault();

                    var lDemo2Pivot22 = new Pivot
                    {
                        Name = Utils.NamePivotDemo22,
                        ShortName = "Pivot 2",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 137,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 23
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDemo2
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo23
                                 select pos).FirstOrDefault();

                    var lDemo2Pivot23 = new Pivot
                    {
                        Name = Utils.NamePivotDemo23,
                        ShortName = "Pivot 3",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 120,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 24
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDemo2
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo24
                                 select pos).FirstOrDefault();

                    var lDemo2Pivot24 = new Pivot
                    {
                        Name = Utils.NamePivotDemo24,
                        ShortName = "Pivot 4",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 120,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 25
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDemo2
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo25
                                 select pos).FirstOrDefault();

                    var lDemo2Pivot25 = new Pivot
                    {
                        Name = Utils.NamePivotDemo25,
                        ShortName = "Pivot 5",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 154,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    context.Pivots.Add(lDemo2Pivot21);
                    context.Pivots.Add(lDemo2Pivot22);
                    context.Pivots.Add(lDemo2Pivot23);
                    context.Pivots.Add(lDemo2Pivot24);
                    context.Pivots.Add(lDemo2Pivot25);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Pivots Demo3 - La Palmas
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    #region Pivot 31
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDemo3
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo31
                                 select pos).FirstOrDefault();

                    var lDemo3Pivot31 = new Pivot
                    {
                        Name = Utils.NamePivotDemo31,
                        ShortName = "Pivot 1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 32A
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDemo3
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo32A
                                 select pos).FirstOrDefault();

                    var lDemo3Pivot32A = new Pivot
                    {
                        Name = Utils.NamePivotDemo32A,
                        ShortName = "Pivot 2A",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 137,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 33
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDemo3
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo33
                                 select pos).FirstOrDefault();

                    var lDemo3Pivot33 = new Pivot
                    {
                        Name = Utils.NamePivotDemo33,
                        ShortName = "Pivot 3",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 120,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 34
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDemo3
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo34
                                 select pos).FirstOrDefault();

                    var lDemo3Pivot34 = new Pivot
                    {
                        Name = Utils.NamePivotDemo34,
                        ShortName = "Pivot 4",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 120,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 35
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDemo3
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDemo35
                                 select pos).FirstOrDefault();

                    var lDemo3Pivot35 = new Pivot
                    {
                        Name = Utils.NamePivotDemo35,
                        ShortName = "Pivot 5",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 154,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    context.Pivots.Add(lDemo3Pivot31);
                    context.Pivots.Add(lDemo3Pivot32A);
                    context.Pivots.Add(lDemo3Pivot33);
                    context.Pivots.Add(lDemo3Pivot34);
                    context.Pivots.Add(lDemo3Pivot35);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Pivots Santa Lucia
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombSantaLucia
                             select b).FirstOrDefault();

                    #region Pivot 1
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaLucia1
                                 select pos).FirstOrDefault();

                    var lSantaLuciaPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotSantaLucia1,
                        ShortName = "Pivot 1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 300,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 2
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaLucia2
                                 select pos).FirstOrDefault();

                    var lSantaLuciaPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotSantaLucia2,
                        ShortName = "Pivot 2",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 300,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 3
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaLucia3
                                 select pos).FirstOrDefault();

                    var lSantaLuciaPivot3 = new Pivot
                    {
                        Name = Utils.NamePivotSantaLucia3,
                        ShortName = "Pivot 3",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 300,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 4
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaLucia4
                                 select pos).FirstOrDefault();

                    var lSantaLuciaPivot4 = new Pivot
                    {
                        Name = Utils.NamePivotSantaLucia4,
                        ShortName = "Pivot 4",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 300,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 5
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaLucia5
                                 select pos).FirstOrDefault();

                    var lSantaLuciaPivot5 = new Pivot
                    {
                        Name = Utils.NamePivotSantaLucia5,
                        ShortName = "Pivot 5",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 300,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    //context.Pivots.Add(lBase);
                    context.Pivots.Add(lSantaLuciaPivot1);
                    context.Pivots.Add(lSantaLuciaPivot2);
                    context.Pivots.Add(lSantaLuciaPivot3);
                    context.Pivots.Add(lSantaLuciaPivot4);
                    context.Pivots.Add(lSantaLuciaPivot5);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Pivots La Perdiz
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    #region Pivot 1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPerdiz1
                                 select pos).FirstOrDefault();

                    var lLaPerdizPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotLaPerdiz1,
                        ShortName = "Pivot 1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 2
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPerdiz2
                                 select pos).FirstOrDefault();

                    var lLaPerdizPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotLaPerdiz2,
                        ShortName = "Pivot 2",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 137,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 3
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPerdiz3
                                 select pos).FirstOrDefault();

                    var lLaPerdizPivot3 = new Pivot
                    {
                        Name = Utils.NamePivotLaPerdiz3,
                        ShortName = "Pivot 3",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 120,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 5
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPerdiz5
                                 select pos).FirstOrDefault();

                    var lLaPerdizPivot5 = new Pivot
                    {
                        Name = Utils.NamePivotLaPerdiz5,
                        ShortName = "Pivot 5",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 154,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 14
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPerdiz14
                                 select pos).FirstOrDefault();

                    var lLaPerdizPivot14 = new Pivot
                    {
                        Name = Utils.NamePivotLaPerdiz14,
                        ShortName = "Pivot 4",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 73.8,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    //context.Pivots.Add(lLaPerdizPivot1);
                    context.Pivots.Add(lLaPerdizPivot2);
                    context.Pivots.Add(lLaPerdizPivot3);
                    context.Pivots.Add(lLaPerdizPivot5);
                    //context.Pivots.Add(lLaPerdizPivot14);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Pivots Del Lago - San Pedro
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    #region Pivot 5
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro5
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot5 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro5,
                        ShortName = "Pivot 5",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 118,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 59,
                    };
                    #endregion

                    #region Pivot 6
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro6
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot6 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro6,
                        ShortName = "Pivot 6",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 60,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 30,
                    };
                    #endregion

                    #region Pivot 7
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro7
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot7 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro7,
                        ShortName = "Pivot 7",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 110,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 55,
                    };
                    #endregion

                    #region Pivot 8
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro8
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot8 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro8,
                        ShortName = "Pivot 8",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 32,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 16,
                    };
                    #endregion

                    context.Pivots.Add(lDelLagoSanPedroPivot5);
                    context.Pivots.Add(lDelLagoSanPedroPivot6);
                    context.Pivots.Add(lDelLagoSanPedroPivot7);
                    context.Pivots.Add(lDelLagoSanPedroPivot8);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Pivots Del Lago - El Mirador
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    #region Pivot 6
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador6
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot6 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador6,
                        ShortName = "Pivot 6",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 60,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 30,
                    };
                    #endregion

                    #region Pivot 7
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador7
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot7 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador7,
                        ShortName = "Pivot 7",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 60,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 30,
                    };
                    #endregion

                    #region Pivot 8
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador8
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot8 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador8,
                        ShortName = "Pivot 8",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 60,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 30,
                    };
                    #endregion

                    #region Pivot 9
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador9
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot9 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador9,
                        ShortName = "Pivot 9",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 60,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 30,
                    };
                    #endregion

                    context.Pivots.Add(lDelLagoElMiradorPivot6);
                    context.Pivots.Add(lDelLagoElMiradorPivot7);
                    context.Pivots.Add(lDelLagoElMiradorPivot8);
                    context.Pivots.Add(lDelLagoElMiradorPivot9);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Pivots LaPalma
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    #region Pivot 1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaPalma
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPalma1
                                 select pos).FirstOrDefault();

                    var lLaPalmaPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotLaPalma1,
                        ShortName = "Pivot 1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 120,
                    };
                    #endregion

                    #region Pivot 2A
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaPalma
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPalma2A
                                 select pos).FirstOrDefault();

                    var lLaPalmaPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotLaPalma2A,
                        ShortName = "Pivot 2A",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 60,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 30,
                    };
                    #endregion

                    #region Pivot 3
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaPalma
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPalma3
                                 select pos).FirstOrDefault();

                    var lLaPalmaPivot3 = new Pivot
                    {
                        Name = Utils.NamePivotLaPalma3,
                        ShortName = "Pivot 3",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 54,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 27,
                    };
                    #endregion

                    #region Pivot 4
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaPalma
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPalma4
                                 select pos).FirstOrDefault();

                    var lLaPalmaPivot4 = new Pivot
                    {
                        Name = Utils.NamePivotLaPalma4,
                        ShortName = "Pivot 4",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 25.5,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 12.7,
                    };
                    #endregion

                    #region Pivot 5
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaPalma
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPalma5
                                 select pos).FirstOrDefault();

                    var lLaPalmaPivot5 = new Pivot
                    {
                        Name = Utils.NamePivotLaPalma5,
                        ShortName = "Pivot 5",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 50,
                    };
                    #endregion

                    context.Pivots.Add(lLaPalmaPivot1);
                    context.Pivots.Add(lLaPalmaPivot2);
                    context.Pivots.Add(lLaPalmaPivot3);
                    context.Pivots.Add(lLaPalmaPivot4);
                    context.Pivots.Add(lLaPalmaPivot5);
                    context.SaveChanges();
                }
            }
            #endregion

        }

        private static void UpdateSoilsBombsIrrigationUnitsUsersByFarm()
        {
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                UpdateSoilsBombsIrrigationUnitsUsersFarmDemo1();
                UpdateSoilsBombsIrrigationUnitsUsersFarmDemo2();
                UpdateSoilsBombsIrrigationUnitsUsersFarmDemo3();
            }
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
            {
                UpdateSoilsBombsIrrigationUnitsUsersFarmSantaLucia();
            }
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPerdiz)
            {
                UpdateSoilsBombsIrrigationUnitsUsersFarmLaPerdiz();
            }
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago)
            {
                UpdateSoilsBombsIrrigationUnitsUsersFarmDelLagoSanPedro();
                UpdateSoilsBombsIrrigationUnitsUsersFarmDelLagoElMirador();
            }
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                UpdateSoilsBombsIrrigationUnitsUsersFarmDelLagoSanPedro();
            }
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                UpdateSoilsBombsIrrigationUnitsUsersFarmDelLagoElMirador();
            }
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPalma)
            {
                UpdateSoilsBombsIrrigationUnitsUsersFarmLaPalma();
            }

        }

        private static void InsertCrops()
        {
            Region lRegion = null;
            Specie lSpecie = null;
            CropCoefficient lCropCoefficient = null;

            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;

            Stage lStopIrrigationStage = null;

            #region Base
            var lBase = new Crop
            {
                Name = Utils.NameBase,
                RegionId = 0,
                SpecieId = 0,
                Density = 0,
                MaxEvapotranspirationToIrrigate = 0,
                MinEvapotranspirationToIrrigate = 0,
                CropCoefficient = null,
                StageList = null,
                PhenologicalStageList = null,
                StopIrrigationStageId = 0,
                CropCoefficientId = 0,
            };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {

                #region Maiz Sur 

                lRegion = (from reg in context.Regions
                             where reg.Name == Utils.NameRegionSouth
                             select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                             where sp.Name == Utils.NameSpecieCornSouthShort
                             select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieCornSouthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                             where st.Name.Contains(Utils.NameStagesCorn)
                             select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                           where ps.SpecieId == lSpecie.SpecieId
                           select ps).ToList<PhenologicalStage>();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesCorn)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE)
                                        select st).FirstOrDefault();

                var lCropMaizSur = new Crop
                {
                    Name = Utils.NameSpecieCornSouthShort,
                    ShortName = "Maíz",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    Density = Utils.CropDensity_Corn,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Corn,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Corn,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList  = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion

                #region Soja Sur

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieSoyaSouthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieSoyaSouthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesSoya)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesCorn)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE)
                                        select st).FirstOrDefault();

                var lCropSojaSur = new Crop
                {
                    Name = Utils.NameSpecieSoyaSouthShort,
                    ShortName = "Soja",
                    RegionId = lRegion.RegionId,
                    SpecieId = lSpecie.SpecieId,
                    Density = Utils.CropDensity_Corn,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Corn,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Corn,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    StageList  = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                };

                #endregion

                //context.Crops.Add(lBase);
                context.Crops.Add(lCropMaizSur);
                context.Crops.Add(lCropSojaSur);
                context.SaveChanges();
            }

        }

        private static void InsertCropsInformationByDate()
        {
            Crop lCrop = null;
            Region lRegion = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Stage lStage = null;

            #region Base
            var lBase = new CropInformationByDate
            {
                SowingDate = Utils.MIN_DATETIME,
                DaysAfterSowing = 0,
                SpecieId = 0,
                CropCoefficientId = 0,
                RegionId = 0,
                PhenologicalStageList = null,
                CurrentDate = DateTime.Now,
                AccumulatedGrowingDegreeDays = 0,
                StageId = 0,
                CropCoefficientValue = 0,
                RootDepth = 0,
            };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {

                #region South

                lRegion = (from region in context.Regions
                        where region.Name == Utils.NameRegionSouth
                        select region).FirstOrDefault();

                #region Corn South
                lCrop = (from crop in context.Crops
                           where crop.Name == Utils.NameSpecieCornSouthShort
                           select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lCornSouth = new CropInformationByDate
                {
                    Name = Utils.NameSpecieCornSouthShort,
                    SowingDate = Utils.MIN_DATETIME,
                    DaysAfterSowing = 0,
                    SpecieId = lCrop.SpecieId,
                    CropCoefficientId = lCrop.CropCoefficientId,
                    RegionId = lRegion.RegionId,
                    PhenologicalStageList = lPhenologicalStages,
                    CurrentDate = DateTime.Now,
                    AccumulatedGrowingDegreeDays = 0,
                    StageId = lStage.StageId,
                    CropCoefficientValue = 0,
                    RootDepth = 0,
                };
                #endregion

                #region Soya South
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieSoyaSouthShort
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lSoyaSouth = new CropInformationByDate
                {
                    Name = Utils.NameSpecieSoyaSouthShort,
                    SowingDate = Utils.MIN_DATETIME,
                    DaysAfterSowing = 0,
                    SpecieId = lCrop.SpecieId,
                    CropCoefficientId = lCrop.CropCoefficientId,
                    RegionId = lRegion.RegionId,
                    PhenologicalStageList = lPhenologicalStages,
                    CurrentDate = DateTime.Now,
                    AccumulatedGrowingDegreeDays = 0,
                    StageId = lStage.StageId,
                    CropCoefficientValue = 0,
                    RootDepth = 0,
                };
                #endregion

                context.CropInformationByDates.Add(lCornSouth);
                context.CropInformationByDates.Add(lSoyaSouth);
                context.SaveChanges();

                #endregion

                #region North
                lRegion = (from region in context.Regions
                           where region.Name == Utils.NameRegionNorth
                           select region).FirstOrDefault();

                #endregion

                //context.CropInformationByDates.Add(lBase);
                context.SaveChanges();
            }
        }

        #endif
        #endregion

        #region Water
        #if true

        private static void InsertEffectiveRainsSouth()
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
                
                context.SaveChanges();
            };
        }

        private static void InsertEffectiveRainsNorth()
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

                context.SaveChanges();
            };
        }

        private static void UpdateRegionSetEffectiveRainList()
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

        /// <summary>
        /// Add Rain Data to Pivots in Farms
        /// </summary>
        private static void UpdateInformationOfRain()
        {
            
            #region South

            using (var context = new IrrigationAdvisorContext())
            {

                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {
                    DataEntry.AddRainDataDemoPivot1_2015(context);
                    DataEntry.AddRainDataDemoPivot2_2015(context);
                    DataEntry.AddRainDataDemoPivot3_2015(context);
                    DataEntry.AddRainDataDemoPivot5_2015(context);
                    context.SaveChanges();
                }

                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPerdiz)
                {
                    DataEntry.AddRainDataLaPerdizPivot2_2015(context);
                    DataEntry.AddRainDataLaPerdizPivot3_2015(context);
                    DataEntry.AddRainDataLaPerdizPivot5_2015(context);
                    context.SaveChanges();
                }

                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
                {
                    DataEntry.AddRainDataDelLagoSanPedroPivot5_2015(context);
                    DataEntry.AddRainDataDelLagoSanPedroPivot6_2015(context);
                    DataEntry.AddRainDataDelLagoSanPedroPivot7_2015(context);
                    DataEntry.AddRainDataDelLagoSanPedroPivot8_2015(context);
                    context.SaveChanges();
                }

                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
                {
                    DataEntry.AddRainDataDelLagoElMiradorPivot6_2015(context);
                    DataEntry.AddRainDataDelLagoElMiradorPivot7_2015(context);
                    DataEntry.AddRainDataDelLagoElMiradorPivot8_2015(context);
                    DataEntry.AddRainDataDelLagoElMiradorPivot9_2015(context);
                    context.SaveChanges();
                }

                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPalma)
                {
                    DataEntry.AddRainDataLaPalmaPivot2A_2015(context);
                    DataEntry.AddRainDataLaPalmaPivot3_2015(context);
                    DataEntry.AddRainDataLaPalmaPivot4_2015(context);
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
        private static void UpdateInformationOfIrrigation()
        {

            #region South

            #region Demo - La Perdiz
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
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

            #region La Perdiz
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPerdiz) 
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntry.AddIrrigationDataLaPerdizPivot2_2015(context);
                    DataEntry.AddIrrigationDataLaPerdizPivot3_2015(context);
                    DataEntry.AddIrrigationDataLaPerdizPivot5_2015(context);
                    context.SaveChanges();
                
                }
            }
            #endregion

            #region Del Lago - El Mirador
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    
                    context.SaveChanges();

                }
            }
            #endregion

            #region Del Lago - San Pedro
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    context.SaveChanges();

                }
            }
            #endregion 

            #region La Palma
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPalma)
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

        #endif
        #endregion

        #region Management
        #if true

        /// <summary>
        /// Insert CropIrrigationWeather:
        ///     - Use: Farm, WeatherStations, EffectiveRainList, Crop, CropCoefficient, 
        ///         KCList, CropInformationByDate, IrrigationUnit, Soil, HorizonList,
        ///         SowingDate, HarvestDate, CropDate, PredeterminatedIrrigationQuantity,
        ///         WeatherDataList.
        ///     - Set the initial Phenological Stage for the Crop
        ///     - Set Calculus Method for Phenological Adjustment
        ///     - Get Initial Hydric Balance
        ///     - Create the initial registry
        /// </summary>
        private static void InsertCropIrrigationWeather()
        {
            #region Local Variables
            Farm lFarm = null;
            Crop lCrop = null;
            Specie lSpecie = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            IrrigationUnit lIrrigationUnit = null;
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
            DateTime lCropDate;
            Double lPredeterminatedIrrigationQuantity;
            #endregion

            #region Base
            var lBase = new CropIrrigationWeather
            {
                CropId = 0,
                SoilId = 0,

                SowingDate = DateTime.Now.AddMonths(-1),
                HarvestDate = DateTime.Now.AddMonths(4),
                CropDate = DateTime.Now,

                PhenologicalStageId = 0,
                HydricBalance = 0,
                SoilHydricVolume = 0,
                TotalEvapotranspirationCropFromLastWaterInput = 0,

                CalculusMethodForPhenologicalAdjustment = Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing,
                CropInformationByDate = lCropInformationByDate,
                DaysAfterSowing = 1,
                DaysAfterSowingModified = 1,
                GrowingDegreeDaysAccumulated = 0,
                GrowingDegreeDaysModified = 0,

                IrrigationUnitId = 0,
                PredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity,
                
                PositionId = 0,

                RainList = null,
                IrrigationList = null,
                EvapotranspirationCropList = null,

                LastWaterInputDate = Utils.MIN_DATETIME,
                LastBigWaterInputDate = Utils.MIN_DATETIME,
                LastPartialWaterInputDate = Utils.MIN_DATETIME,
                LastPartialWaterInput = 0,

                MainWeatherStationId = 0,
                AlternativeWeatherStationId = 0,
                UsingMainWeatherStation = true,

                //DailyRecordList = null,

                TotalEvapotranspirationCrop = 0,
                TotalEffectiveRain = 0,
                TotalRealRain = 0,
                TotalIrrigation = 0,
                TotalIrrigationInHydricBalance = 0,
                TotalExtraIrrigation = 0,
                TotalExtraIrrigationInHydricBalance = 0,

            };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {

                #region Demo1 - La Perdiz
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {

                    #region Demo1 - La Perdiz Pivot 11 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo1
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo11
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo11
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo11)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_Demo1Pivot11_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_Demo1Pivot11_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_Demo1Pivot11_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDemo1Pivot11_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo1Pivot11,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDemo1Pivot11_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo1Pivot11_2015.HydricBalance = lCIWDemo1Pivot11_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo1Pivot11_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDemo1Pivot11_2015);
                    context.SaveChanges();

                    #region Print
                    //Save Titles for print
                    foreach (var item in lCIWDemo1Pivot11_2015.Titles)
                    {
                        var lTitlesDemo1Pivot11_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo1Pivot11_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo1Pivot11_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo1Pivot11_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo1Pivot11_2015 = (from title in context.Titles
                                                         where title.Name == "DDS"
                                                            && title.Daily == false
                                                            && title.CropIrrigationWeatherId == lCIWDemo1Pivot11_2015.CropIrrigationWeatherId
                                                         select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo1Pivot11_2015 = lCIWDemo1Pivot11_2015.Titles.Count();
                    long lTitleIdDemo1Pivot11_2015 = lFirstTitleIdDemo1Pivot11_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo1Pivot11_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo1Pivot11_2015;
                        lTitleIdDemo1Pivot11_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo1Pivot11_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo1Pivot11_2015 - lFirstTitleIdDemo1Pivot11_2015) % (lTotalTitlesDemo1Pivot11_2015) == 0)
                        {
                            lTitleIdDemo1Pivot11_2015 = lFirstTitleIdDemo1Pivot11_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #endregion

                    #region Demo1 - La Perdiz Pivot 12 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo1
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo12
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo12
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo12)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_Demo1Pivot12_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_Demo1Pivot12_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_Demo1Pivot12_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDemo1Pivot12_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo1Pivot12,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDemo1Pivot12_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo1Pivot12_2015.HydricBalance = lCIWDemo1Pivot12_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo1Pivot12_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDemo1Pivot12_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo1Pivot12_2015.Titles)
                    {
                        var lTitlesDemo1Pivot12_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo1Pivot12_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo1Pivot12_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo1Pivot12_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo1Pivot12_2015 = (from title in context.Titles
                                                             where title.Name == "DDS"
                                                                && title.Daily == false
                                                                && title.CropIrrigationWeatherId == lCIWDemo1Pivot12_2015.CropIrrigationWeatherId
                                                             select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo1Pivot12_2015 = lCIWDemo1Pivot12_2015.Titles.Count();
                    long lTitleIdDemo1Pivot12_2015 = lFirstTitleIdDemo1Pivot12_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo1Pivot12_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo1Pivot12_2015;
                        lTitleIdDemo1Pivot12_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo1Pivot12_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo1Pivot12_2015 - lFirstTitleIdDemo1Pivot12_2015) % (lTotalTitlesDemo1Pivot12_2015) == 0)
                        {
                            lTitleIdDemo1Pivot12_2015 = lFirstTitleIdDemo1Pivot12_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Demo1 - La Perdiz Pivot 3 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo1
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo13
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo13
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo13)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_Demo1Pivot13_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_Demo1Pivot13_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_Demo1Pivot13_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDemo1Pivot13_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo1Pivot13,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDemo1Pivot13_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo1Pivot13_2015.HydricBalance = lCIWDemo1Pivot13_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo1Pivot13_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDemo1Pivot13_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo1Pivot13_2015.Titles)
                    {
                        var lTitlesDemo1Pivot13_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo1Pivot13_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo1Pivot13_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo1Pivot13_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo1Pivot13_2015 = (from title in context.Titles
                                                             where title.Name == "DDS"
                                                                && title.Daily == false
                                                                && title.CropIrrigationWeatherId == lCIWDemo1Pivot13_2015.CropIrrigationWeatherId
                                                             select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo1Pivot13_2015 = lCIWDemo1Pivot13_2015.Titles.Count();
                    long lTitleIdDemo1Pivot13_2015 = lFirstTitleIdDemo1Pivot13_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo1Pivot13_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo1Pivot13_2015;
                        lTitleIdDemo1Pivot13_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo1Pivot13_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo1Pivot13_2015 - lFirstTitleIdDemo1Pivot13_2015) % (lTotalTitlesDemo1Pivot13_2015) == 0)
                        {
                            lTitleIdDemo1Pivot13_2015 = lFirstTitleIdDemo1Pivot13_2015;
                        }
                    }

                    context.SaveChanges();
                    #endregion

                    #region Demo1 - La Perdiz Pivot 5 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo1
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo15
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo15
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo15)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_Demo1Pivot15_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_Demo1Pivot15_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_Demo1Pivot15_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDemo1Pivot15_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo1Pivot15,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDemo1Pivot15_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo1Pivot15_2015.HydricBalance = lCIWDemo1Pivot15_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo1Pivot15_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDemo1Pivot15_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo1Pivot15_2015.Titles)
                    {
                        var lTitlesDemo1Pivot15_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo1Pivot15_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo1Pivot15_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo1Pivot15_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo1Pivot15_2015 = (from title in context.Titles
                                                             where title.Name == "DDS"
                                                                && title.Daily == false
                                                                && title.CropIrrigationWeatherId == lCIWDemo1Pivot15_2015.CropIrrigationWeatherId
                                                             select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo1Pivot15_2015 = lCIWDemo1Pivot15_2015.Titles.Count();
                    long lTitleIdDemo1Pivot15_2015 = lFirstTitleIdDemo1Pivot15_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo1Pivot15_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo1Pivot15_2015;
                        lTitleIdDemo1Pivot15_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo1Pivot15_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo1Pivot15_2015 - lFirstTitleIdDemo1Pivot15_2015) % (lTotalTitlesDemo1Pivot15_2015) == 0)
                        {
                            lTitleIdDemo1Pivot15_2015 = lFirstTitleIdDemo1Pivot15_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                }
                #endregion

                #region Demo2 - Santa Lucia
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {

                    #region Demo2 - Santa Lucia Pivot 21 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo2
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo21
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo21
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo21)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_Demo2Pivot21_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_Demo2Pivot21_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_Demo2Pivot21_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDemo2Pivot21_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo2Pivot21,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDemo2Pivot21_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo2Pivot21_2015.HydricBalance = lCIWDemo2Pivot21_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo2Pivot21_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDemo2Pivot21_2015);
                    context.SaveChanges();

                    #region Print
                    //Save Titles for print
                    foreach (var item in lCIWDemo2Pivot21_2015.Titles)
                    {
                        var lTitlesDemo2Pivot21_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo2Pivot21_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo2Pivot21_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo2Pivot21_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo2Pivot21_2015 = (from title in context.Titles
                                                         where title.Name == "DDS"
                                                            && title.Daily == false
                                                            && title.CropIrrigationWeatherId == lCIWDemo2Pivot21_2015.CropIrrigationWeatherId
                                                         select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo2Pivot21_2015 = lCIWDemo2Pivot21_2015.Titles.Count();
                    long lTitleIdDemo2Pivot21_2015 = lFirstTitleIdDemo2Pivot21_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo2Pivot21_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo2Pivot21_2015;
                        lTitleIdDemo2Pivot21_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo2Pivot21_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo2Pivot21_2015 - lFirstTitleIdDemo2Pivot21_2015) % (lTotalTitlesDemo2Pivot21_2015) == 0)
                        {
                            lTitleIdDemo2Pivot21_2015 = lFirstTitleIdDemo2Pivot21_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #endregion

                    #region Demo2 - La Perdiz Pivot 22 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo2
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo22
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo22
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo22)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_Demo2Pivot22_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_Demo2Pivot22_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_Demo2Pivot22_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDemo2Pivot22_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo2Pivot22,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDemo2Pivot22_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo2Pivot22_2015.HydricBalance = lCIWDemo2Pivot22_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo2Pivot22_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDemo2Pivot22_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo2Pivot22_2015.Titles)
                    {
                        var lTitlesDemo2Pivot22_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo2Pivot22_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo2Pivot22_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo2Pivot22_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo2Pivot22_2015 = (from title in context.Titles
                                                         where title.Name == "DDS"
                                                            && title.Daily == false
                                                            && title.CropIrrigationWeatherId == lCIWDemo2Pivot22_2015.CropIrrigationWeatherId
                                                         select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo2Pivot22_2015 = lCIWDemo2Pivot22_2015.Titles.Count();
                    long lTitleIdDemo2Pivot22_2015 = lFirstTitleIdDemo2Pivot22_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo2Pivot22_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo2Pivot22_2015;
                        lTitleIdDemo2Pivot22_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo2Pivot22_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo2Pivot22_2015 - lFirstTitleIdDemo2Pivot22_2015) % (lTotalTitlesDemo2Pivot22_2015) == 0)
                        {
                            lTitleIdDemo2Pivot22_2015 = lFirstTitleIdDemo2Pivot22_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Demo2 - La Perdiz Pivot 23 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo2
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo23
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo23
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo23)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_Demo2Pivot23_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_Demo2Pivot23_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_Demo2Pivot23_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDemo2Pivot23_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo2Pivot23,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDemo2Pivot23_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo2Pivot23_2015.HydricBalance = lCIWDemo2Pivot23_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo2Pivot23_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDemo2Pivot23_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo2Pivot23_2015.Titles)
                    {
                        var lTitlesDemo2Pivot23_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo2Pivot23_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo2Pivot23_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo2Pivot23_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo2Pivot23_2015 = (from title in context.Titles
                                                         where title.Name == "DDS"
                                                            && title.Daily == false
                                                            && title.CropIrrigationWeatherId == lCIWDemo2Pivot23_2015.CropIrrigationWeatherId
                                                         select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo2Pivot23_2015 = lCIWDemo2Pivot23_2015.Titles.Count();
                    long lTitleIdDemo2Pivot23_2015 = lFirstTitleIdDemo2Pivot23_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo2Pivot23_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo2Pivot23_2015;
                        lTitleIdDemo2Pivot23_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo2Pivot23_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo2Pivot23_2015 - lFirstTitleIdDemo2Pivot23_2015) % (lTotalTitlesDemo2Pivot23_2015) == 0)
                        {
                            lTitleIdDemo2Pivot23_2015 = lFirstTitleIdDemo2Pivot23_2015;
                        }
                    }

                    context.SaveChanges();
                    #endregion

                    #region Demo2 - La Perdiz Pivot 24 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo2
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo24
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo24
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo24)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_Demo2Pivot24_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_Demo2Pivot24_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_Demo2Pivot24_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDemo2Pivot24_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo2Pivot24,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDemo2Pivot24_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo2Pivot24_2015.HydricBalance = lCIWDemo2Pivot24_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo2Pivot24_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDemo2Pivot24_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo2Pivot24_2015.Titles)
                    {
                        var lTitlesDemo2Pivot24_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo2Pivot24_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo2Pivot24_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo2Pivot24_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo2Pivot24_2015 = (from title in context.Titles
                                                           where title.Name == "DDS"
                                                              && title.Daily == false
                                                              && title.CropIrrigationWeatherId == lCIWDemo2Pivot24_2015.CropIrrigationWeatherId
                                                           select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo2Pivot24_2015 = lCIWDemo2Pivot24_2015.Titles.Count();
                    long lTitleIdDemo2Pivot24_2015 = lFirstTitleIdDemo2Pivot24_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo2Pivot24_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo2Pivot24_2015;
                        lTitleIdDemo2Pivot24_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo2Pivot24_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo2Pivot24_2015 - lFirstTitleIdDemo2Pivot24_2015) % (lTotalTitlesDemo2Pivot24_2015) == 0)
                        {
                            lTitleIdDemo2Pivot24_2015 = lFirstTitleIdDemo2Pivot24_2015;
                        }
                    }

                    context.SaveChanges();
                    #endregion

                    #region Demo2 - La Perdiz Pivot 25 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo2
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo25
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo25
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo25)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_Demo2Pivot25_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_Demo2Pivot25_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_Demo2Pivot25_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDemo2Pivot25_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo2Pivot25,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDemo2Pivot25_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo2Pivot25_2015.HydricBalance = lCIWDemo2Pivot25_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo2Pivot25_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDemo2Pivot25_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo2Pivot25_2015.Titles)
                    {
                        var lTitlesDemo2Pivot25_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo2Pivot25_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo2Pivot25_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo2Pivot25_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo2Pivot25_2015 = (from title in context.Titles
                                                         where title.Name == "DDS"
                                                            && title.Daily == false
                                                            && title.CropIrrigationWeatherId == lCIWDemo2Pivot25_2015.CropIrrigationWeatherId
                                                         select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo2Pivot25_2015 = lCIWDemo2Pivot25_2015.Titles.Count();
                    long lTitleIdDemo2Pivot25_2015 = lFirstTitleIdDemo2Pivot25_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo2Pivot25_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo2Pivot25_2015;
                        lTitleIdDemo2Pivot25_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo2Pivot25_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo2Pivot25_2015 - lFirstTitleIdDemo2Pivot25_2015) % (lTotalTitlesDemo2Pivot25_2015) == 0)
                        {
                            lTitleIdDemo2Pivot25_2015 = lFirstTitleIdDemo2Pivot25_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                }
                #endregion

                #region Demo3 - Las Palmas
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {

                    #region Demo3 - La Palma Pivot 31 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo3
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo31
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo31
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo31)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_Demo3Pivot31_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_Demo3Pivot31_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_Demo3Pivot31_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDemo3Pivot31_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo3Pivot31,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDemo3Pivot31_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo3Pivot31_2015.HydricBalance = lCIWDemo3Pivot31_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo3Pivot31_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDemo3Pivot31_2015);
                    context.SaveChanges();

                    #region Print
                    //Save Titles for print
                    foreach (var item in lCIWDemo3Pivot31_2015.Titles)
                    {
                        var lTitlesDemo3Pivot31_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo3Pivot31_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo3Pivot31_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo3Pivot31_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo3Pivot31_2015 = (from title in context.Titles
                                                         where title.Name == "DDS"
                                                            && title.Daily == false
                                                            && title.CropIrrigationWeatherId == lCIWDemo3Pivot31_2015.CropIrrigationWeatherId
                                                         select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo3Pivot31_2015 = lCIWDemo3Pivot31_2015.Titles.Count();
                    long lTitleIdDemo3Pivot31_2015 = lFirstTitleIdDemo3Pivot31_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo3Pivot31_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo3Pivot31_2015;
                        lTitleIdDemo3Pivot31_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo3Pivot31_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo3Pivot31_2015 - lFirstTitleIdDemo3Pivot31_2015) % (lTotalTitlesDemo3Pivot31_2015) == 0)
                        {
                            lTitleIdDemo3Pivot31_2015 = lFirstTitleIdDemo3Pivot31_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #endregion

                    #region Demo3 - La Palma Pivot 32A 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo3
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo32A
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo32A
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo32A)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_Demo3Pivot32A_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_Demo3Pivot32A_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_Demo3Pivot32A_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDemo3Pivot32A_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo3Pivot32A,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDemo3Pivot32A_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo3Pivot32A_2015.HydricBalance = lCIWDemo3Pivot32A_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo3Pivot32A_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDemo3Pivot32A_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo3Pivot32A_2015.Titles)
                    {
                        var lTitlesDemo3Pivot32A_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo3Pivot32A_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo3Pivot32A_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo3Pivot32A_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo3Pivot32A_2015 = (from title in context.Titles
                                                         where title.Name == "DDS"
                                                            && title.Daily == false
                                                            && title.CropIrrigationWeatherId == lCIWDemo3Pivot32A_2015.CropIrrigationWeatherId
                                                         select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo3Pivot32A_2015 = lCIWDemo3Pivot32A_2015.Titles.Count();
                    long lTitleIdDemo3Pivot32A_2015 = lFirstTitleIdDemo3Pivot32A_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo3Pivot32A_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo3Pivot32A_2015;
                        lTitleIdDemo3Pivot32A_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo3Pivot32A_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo3Pivot32A_2015 - lFirstTitleIdDemo3Pivot32A_2015) % (lTotalTitlesDemo3Pivot32A_2015) == 0)
                        {
                            lTitleIdDemo3Pivot32A_2015 = lFirstTitleIdDemo3Pivot32A_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Demo3 - La Palma Pivot 33 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo3
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo33
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo33
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo33)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_Demo3Pivot33_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_Demo3Pivot33_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_Demo3Pivot33_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDemo3Pivot33_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo3Pivot33,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDemo3Pivot33_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo3Pivot33_2015.HydricBalance = lCIWDemo3Pivot33_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo3Pivot33_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDemo3Pivot33_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo3Pivot33_2015.Titles)
                    {
                        var lTitlesDemo3Pivot33_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo3Pivot33_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo3Pivot33_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo3Pivot33_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo3Pivot33_2015 = (from title in context.Titles
                                                         where title.Name == "DDS"
                                                            && title.Daily == false
                                                            && title.CropIrrigationWeatherId == lCIWDemo3Pivot33_2015.CropIrrigationWeatherId
                                                         select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo3Pivot33_2015 = lCIWDemo3Pivot33_2015.Titles.Count();
                    long lTitleIdDemo3Pivot33_2015 = lFirstTitleIdDemo3Pivot33_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo3Pivot33_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo3Pivot33_2015;
                        lTitleIdDemo3Pivot33_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo3Pivot33_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo3Pivot33_2015 - lFirstTitleIdDemo3Pivot33_2015) % (lTotalTitlesDemo3Pivot33_2015) == 0)
                        {
                            lTitleIdDemo3Pivot33_2015 = lFirstTitleIdDemo3Pivot33_2015;
                        }
                    }

                    context.SaveChanges();
                    #endregion

                    #region Demo3 - La Palma Pivot 34 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo3
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo34
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo34
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo34)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_Demo3Pivot34_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_Demo3Pivot34_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_Demo3Pivot34_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDemo3Pivot34_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo3Pivot34,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDemo3Pivot34_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo3Pivot34_2015.HydricBalance = lCIWDemo3Pivot34_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo3Pivot34_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDemo3Pivot34_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo3Pivot34_2015.Titles)
                    {
                        var lTitlesDemo3Pivot34_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo3Pivot34_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo3Pivot34_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo3Pivot34_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo3Pivot34_2015 = (from title in context.Titles
                                                           where title.Name == "DDS"
                                                              && title.Daily == false
                                                              && title.CropIrrigationWeatherId == lCIWDemo3Pivot34_2015.CropIrrigationWeatherId
                                                           select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo3Pivot34_2015 = lCIWDemo3Pivot34_2015.Titles.Count();
                    long lTitleIdDemo3Pivot34_2015 = lFirstTitleIdDemo3Pivot34_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo3Pivot34_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo3Pivot34_2015;
                        lTitleIdDemo3Pivot34_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo3Pivot34_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo3Pivot34_2015 - lFirstTitleIdDemo3Pivot34_2015) % (lTotalTitlesDemo3Pivot34_2015) == 0)
                        {
                            lTitleIdDemo3Pivot34_2015 = lFirstTitleIdDemo3Pivot34_2015;
                        }
                    }

                    context.SaveChanges();
                    #endregion

                    #region Demo3 - La Palma Pivot 35 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo3
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo35
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo35
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo35)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_Demo3Pivot35_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_Demo3Pivot35_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_Demo3Pivot35_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDemo3Pivot35_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo3Pivot35,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDemo3Pivot35_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo3Pivot35_2015.HydricBalance = lCIWDemo3Pivot35_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo3Pivot35_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDemo3Pivot35_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo3Pivot35_2015.Titles)
                    {
                        var lTitlesDemo3Pivot35_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo3Pivot35_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo3Pivot35_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo3Pivot35_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo3Pivot35_2015 = (from title in context.Titles
                                                         where title.Name == "DDS"
                                                            && title.Daily == false
                                                            && title.CropIrrigationWeatherId == lCIWDemo3Pivot35_2015.CropIrrigationWeatherId
                                                         select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo3Pivot35_2015 = lCIWDemo3Pivot35_2015.Titles.Count();
                    long lTitleIdDemo3Pivot35_2015 = lFirstTitleIdDemo3Pivot35_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo3Pivot35_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo3Pivot35_2015;
                        lTitleIdDemo3Pivot35_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo3Pivot35_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo3Pivot35_2015 - lFirstTitleIdDemo3Pivot35_2015) % (lTotalTitlesDemo3Pivot35_2015) == 0)
                        {
                            lTitleIdDemo3Pivot35_2015 = lFirstTitleIdDemo3Pivot35_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                }
                #endregion

                #region Santa Lucia

                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
                { 
                    #region Santa Lucia Pivot 1 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmSantaLucia
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                       where ws.Name == Utils.NameWeatherStationLasBrujas
                                       select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationSantaLucia
                                           select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                            where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                            select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                             where iu.Name == Utils.NamePivotSantaLucia1
                             select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilSantaLucia1
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotSantaLucia1)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_SantaLuciaPivot1_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_SantaLuciaPivot1_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_SantaLuciaPivot1_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where  (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWSantaLuciaPivot1_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherSantaLuciaPivot1,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        //Get Effective Rain List from Region
                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,
                    
                    };
                    context.SaveChanges();

                    lCIWSantaLuciaPivot1_2015.Soil.HorizonList = lHorizonList;

                    //Set Calculus Method for Phenological Adjustment
                    lCIWSantaLuciaPivot1_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWSantaLuciaPivot1_2015.HydricBalance = lCIWSantaLuciaPivot1_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWSantaLuciaPivot1_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWSantaLuciaPivot1_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWSantaLuciaPivot1_2015.Titles)
                    {
                        var lTitlesSantaLuciaPivot1_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWSantaLuciaPivot1_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWSantaLuciaPivot1_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesSantaLuciaPivot1_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdSantaLuciaPivot1_2015 = (from title in context.Titles
                                                               where title.Name == "DDS"
                                                                  && title.Daily == false
                                                                  && title.CropIrrigationWeatherId == lCIWSantaLuciaPivot1_2015.CropIrrigationWeatherId
                                                               select title.TitleId).FirstOrDefault();
                    long lTotalTitlesSantaLuciaPivot1_2015 = lCIWSantaLuciaPivot1_2015.Titles.Count();
                    long lTitleIdSantaLuciaPivot1_2015 = lFirstTitleIdSantaLuciaPivot1_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWSantaLuciaPivot1_2015.Messages)
                    {
                        item.TitleId = lTitleIdSantaLuciaPivot1_2015;
                        lTitleIdSantaLuciaPivot1_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWSantaLuciaPivot1_2015.CropIrrigationWeatherId;
                        if (lTotalTitlesSantaLuciaPivot1_2015 == lTitleIdSantaLuciaPivot1_2015 - lFirstTitleIdSantaLuciaPivot1_2015)
                        {
                            lTitleIdSantaLuciaPivot1_2015 = lFirstTitleIdSantaLuciaPivot1_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Santa Lucia Pivot 2 2015

                    #endregion

                    #region Santa Lucia Pivot 3 2015

                    #endregion
                
                    #region Santa Lucia Pivot 4 2015

                    #endregion

                    #region Santa Lucia Pivot 5 2015

                    #endregion
                }
                #endregion

                #region La Perdiz
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPerdiz)
                {
                    #region La Perdiz Pivot 2 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmLaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotLaPerdiz2
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilLaPerdiz2
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotLaPerdiz2)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_LaPerdizPivot2_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_LaPerdizPivot2_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_LaPerdizPivot2_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWLaPerdizPivot2_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherLaPerdizPivot2,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWLaPerdizPivot2_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWLaPerdizPivot2_2015.HydricBalance = lCIWLaPerdizPivot2_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWLaPerdizPivot2_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWLaPerdizPivot2_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWLaPerdizPivot2_2015.Titles)
                    {
                        var lTitlesLaPerdizPivot2_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWLaPerdizPivot2_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWLaPerdizPivot2_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesLaPerdizPivot2_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdLaPerdizPivot2_2015 = (from title in context.Titles
                                                             where title.Name == "DDS"
                                                                && title.Daily == false
                                                                && title.CropIrrigationWeatherId == lCIWLaPerdizPivot2_2015.CropIrrigationWeatherId
                                                             select title.TitleId).FirstOrDefault();
                    long lTotalTitlesLaPerdizPivot2_2015 = lCIWLaPerdizPivot2_2015.Titles.Count();
                    long lTitleIdLaPerdizPivot2_2015 = lFirstTitleIdLaPerdizPivot2_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWLaPerdizPivot2_2015.Messages)
                    {
                        item.TitleId = lTitleIdLaPerdizPivot2_2015;
                        lTitleIdLaPerdizPivot2_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWLaPerdizPivot2_2015.CropIrrigationWeatherId;
                        if ((lTitleIdLaPerdizPivot2_2015 - lFirstTitleIdLaPerdizPivot2_2015) % (lTotalTitlesLaPerdizPivot2_2015) == 0)
                        {
                            lTitleIdLaPerdizPivot2_2015 = lFirstTitleIdLaPerdizPivot2_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region La Perdiz Pivot 3 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmLaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotLaPerdiz3
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilLaPerdiz3
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotLaPerdiz3)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_LaPerdizPivot3_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_LaPerdizPivot3_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_LaPerdizPivot3_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWLaPerdizPivot3_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherLaPerdizPivot3,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWLaPerdizPivot3_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWLaPerdizPivot3_2015.HydricBalance = lCIWLaPerdizPivot3_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWLaPerdizPivot3_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWLaPerdizPivot3_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWLaPerdizPivot3_2015.Titles)
                    {
                        var lTitlesLaPerdizPivot3_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWLaPerdizPivot3_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWLaPerdizPivot3_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesLaPerdizPivot3_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdLaPerdizPivot3_2015 = (from title in context.Titles
                                                             where title.Name == "DDS"
                                                                && title.Daily == false
                                                                && title.CropIrrigationWeatherId == lCIWLaPerdizPivot3_2015.CropIrrigationWeatherId
                                                             select title.TitleId).FirstOrDefault();
                    long lTotalTitlesLaPerdizPivot3_2015 = lCIWLaPerdizPivot3_2015.Titles.Count();
                    long lTitleIdLaPerdizPivot3_2015 = lFirstTitleIdLaPerdizPivot3_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWLaPerdizPivot3_2015.Messages)
                    {
                        item.TitleId = lTitleIdLaPerdizPivot3_2015;
                        lTitleIdLaPerdizPivot3_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWLaPerdizPivot3_2015.CropIrrigationWeatherId;
                        if ((lTitleIdLaPerdizPivot3_2015 - lFirstTitleIdLaPerdizPivot3_2015) % (lTotalTitlesLaPerdizPivot3_2015) == 0)
                        {
                            lTitleIdLaPerdizPivot3_2015 = lFirstTitleIdLaPerdizPivot3_2015;
                        }
                    }

                    context.SaveChanges();
                    #endregion

                    #region La Perdiz Pivot 5 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmLaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotLaPerdiz5
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilLaPerdiz5
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotLaPerdiz5)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_LaPerdizPivot5_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_LaPerdizPivot5_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_LaPerdizPivot5_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWLaPerdizPivot5_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherLaPerdizPivot5,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWLaPerdizPivot5_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWLaPerdizPivot5_2015.HydricBalance = lCIWLaPerdizPivot5_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWLaPerdizPivot5_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWLaPerdizPivot5_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWLaPerdizPivot5_2015.Titles)
                    {
                        var lTitlesLaPerdizPivot5_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWLaPerdizPivot5_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWLaPerdizPivot5_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesLaPerdizPivot5_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdLaPerdizPivot5_2015 = (from title in context.Titles
                                                             where title.Name == "DDS"
                                                                && title.Daily == false
                                                                && title.CropIrrigationWeatherId == lCIWLaPerdizPivot5_2015.CropIrrigationWeatherId
                                                             select title.TitleId).FirstOrDefault();
                    long lTotalTitlesLaPerdizPivot5_2015 = lCIWLaPerdizPivot5_2015.Titles.Count();
                    long lTitleIdLaPerdizPivot5_2015 = lFirstTitleIdLaPerdizPivot5_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWLaPerdizPivot5_2015.Messages)
                    {
                        item.TitleId = lTitleIdLaPerdizPivot5_2015;
                        lTitleIdLaPerdizPivot5_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWLaPerdizPivot5_2015.CropIrrigationWeatherId;
                        if ((lTitleIdLaPerdizPivot5_2015 - lFirstTitleIdLaPerdizPivot5_2015) % (lTotalTitlesLaPerdizPivot5_2015) == 0)
                        {
                            lTitleIdLaPerdizPivot5_2015 = lFirstTitleIdLaPerdizPivot5_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                }                
                #endregion

                #region Del Lago - San Pedro
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
                {
                    #region Del Lago - San Pedro Pivot 5 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoSanPedro
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoSanPedro5
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoSanPedro5
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro5)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoSanPedroPivot5_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot5_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot5_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDelLagoSanPedroPivot5_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoSanPedroPivot5,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoSanPedroPivot5_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoSanPedroPivot5_2015.HydricBalance = lCIWDelLagoSanPedroPivot5_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoSanPedroPivot5_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoSanPedroPivot5_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDelLagoSanPedroPivot5_2015.Titles)
                    {
                        var lTitlesDelLagoSanPedroPivot5_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot5_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoSanPedroPivot5_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoSanPedroPivot5_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoSanPedroPivot5_2015 = (from title in context.Titles
                                                                    where title.Name == "DDS"
                                                                       && title.Daily == false
                                                                       && title.CropIrrigationWeatherId == lCIWDelLagoSanPedroPivot5_2015.CropIrrigationWeatherId
                                                                    select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoSanPedroPivot5_2015 = lCIWDelLagoSanPedroPivot5_2015.Titles.Count();
                    long lTitleIdDelLagoSanPedroPivot5_2015 = lFirstTitleIdDelLagoSanPedroPivot5_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDelLagoSanPedroPivot5_2015.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoSanPedroPivot5_2015;
                        lTitleIdDelLagoSanPedroPivot5_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot5_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoSanPedroPivot5_2015 - lFirstTitleIdDelLagoSanPedroPivot5_2015) % (lTotalTitlesDelLagoSanPedroPivot5_2015) == 0)
                        {
                            lTitleIdDelLagoSanPedroPivot5_2015 = lFirstTitleIdDelLagoSanPedroPivot5_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Del Lago - San Pedro Pivot 6 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoSanPedro
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoSanPedro6
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoSanPedro6
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro6)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoSanPedroPivot6_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot6_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot6_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDelLagoSanPedroPivot6_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoSanPedroPivot6,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoSanPedroPivot6_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoSanPedroPivot6_2015.HydricBalance = lCIWDelLagoSanPedroPivot6_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoSanPedroPivot6_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoSanPedroPivot6_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDelLagoSanPedroPivot6_2015.Titles)
                    {
                        var lTitlesDelLagoSanPedroPivot6_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot6_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoSanPedroPivot6_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoSanPedroPivot6_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoSanPedroPivot6_2015 = (from title in context.Titles
                                                                    where title.Name == "DDS"
                                                                       && title.Daily == false
                                                                       && title.CropIrrigationWeatherId == lCIWDelLagoSanPedroPivot6_2015.CropIrrigationWeatherId
                                                                    select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoSanPedroPivot6_2015 = lCIWDelLagoSanPedroPivot6_2015.Titles.Count();
                    long lTitleIdDelLagoSanPedroPivot6_2015 = lFirstTitleIdDelLagoSanPedroPivot6_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDelLagoSanPedroPivot6_2015.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoSanPedroPivot6_2015;
                        lTitleIdDelLagoSanPedroPivot6_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot6_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoSanPedroPivot6_2015 - lFirstTitleIdDelLagoSanPedroPivot6_2015) % (lTotalTitlesDelLagoSanPedroPivot6_2015) == 0)
                        {
                            lTitleIdDelLagoSanPedroPivot6_2015 = lFirstTitleIdDelLagoSanPedroPivot6_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Del Lago - San Pedro Pivot 7 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoSanPedro
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoSanPedro7
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoSanPedro7
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro7)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoSanPedroPivot7_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot7_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot7_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDelLagoSanPedroPivot7_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoSanPedroPivot7,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoSanPedroPivot7_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoSanPedroPivot7_2015.HydricBalance = lCIWDelLagoSanPedroPivot7_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoSanPedroPivot7_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoSanPedroPivot7_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDelLagoSanPedroPivot7_2015.Titles)
                    {
                        var lTitlesDelLagoSanPedroPivot7_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot7_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoSanPedroPivot7_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoSanPedroPivot7_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoSanPedroPivot7_2015 = (from title in context.Titles
                                                                    where title.Name == "DDS"
                                                                       && title.Daily == false
                                                                       && title.CropIrrigationWeatherId == lCIWDelLagoSanPedroPivot7_2015.CropIrrigationWeatherId
                                                                    select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoSanPedroPivot7_2015 = lCIWDelLagoSanPedroPivot7_2015.Titles.Count();
                    long lTitleIdDelLagoSanPedroPivot7_2015 = lFirstTitleIdDelLagoSanPedroPivot7_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDelLagoSanPedroPivot7_2015.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoSanPedroPivot7_2015;
                        lTitleIdDelLagoSanPedroPivot7_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot7_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoSanPedroPivot7_2015 - lFirstTitleIdDelLagoSanPedroPivot7_2015) % (lTotalTitlesDelLagoSanPedroPivot7_2015) == 0)
                        {
                            lTitleIdDelLagoSanPedroPivot7_2015 = lFirstTitleIdDelLagoSanPedroPivot7_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Del Lago - San Pedro Pivot 8 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoSanPedro
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoSanPedro8
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoSanPedro8
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro8)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoSanPedroPivot8_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot8_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot8_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDelLagoSanPedroPivot8_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoSanPedroPivot8,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoSanPedroPivot8_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoSanPedroPivot8_2015.HydricBalance = lCIWDelLagoSanPedroPivot8_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoSanPedroPivot8_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoSanPedroPivot8_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDelLagoSanPedroPivot8_2015.Titles)
                    {
                        var lTitlesDelLagoSanPedroPivot8_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot8_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoSanPedroPivot8_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoSanPedroPivot8_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoSanPedroPivot8_2015 = (from title in context.Titles
                                                                    where title.Name == "DDS"
                                                                       && title.Daily == false
                                                                       && title.CropIrrigationWeatherId == lCIWDelLagoSanPedroPivot8_2015.CropIrrigationWeatherId
                                                                    select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoSanPedroPivot8_2015 = lCIWDelLagoSanPedroPivot8_2015.Titles.Count();
                    long lTitleIdDelLagoSanPedroPivot8_2015 = lFirstTitleIdDelLagoSanPedroPivot8_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDelLagoSanPedroPivot8_2015.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoSanPedroPivot8_2015;
                        lTitleIdDelLagoSanPedroPivot8_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot8_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoSanPedroPivot8_2015 - lFirstTitleIdDelLagoSanPedroPivot8_2015) % (lTotalTitlesDelLagoSanPedroPivot8_2015) == 0)
                        {
                            lTitleIdDelLagoSanPedroPivot8_2015 = lFirstTitleIdDelLagoSanPedroPivot8_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                }
                #endregion

                #region Del Lago - El Mirador
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago 
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
                {
                    #region Del Lago - El Mirador Pivot 6 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador6
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador6
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador6)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot6_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot6_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot6_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDelLagoElMiradorPivot6_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot6,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot6_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot6_2015.HydricBalance = lCIWDelLagoElMiradorPivot6_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot6_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot6_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot6_2015.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot6_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot6_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot6_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot6_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot6_2015 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot6_2015.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot6_2015 = lCIWDelLagoElMiradorPivot6_2015.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot6_2015 = lFirstTitleIdDelLagoElMiradorPivot6_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot6_2015.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot6_2015;
                        lTitleIdDelLagoElMiradorPivot6_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot6_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot6_2015 - lFirstTitleIdDelLagoElMiradorPivot6_2015) % (lTotalTitlesDelLagoElMiradorPivot6_2015) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot6_2015 = lFirstTitleIdDelLagoElMiradorPivot6_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Del Lago - El Mirador Pivot 7 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador7
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador7
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador7)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot7_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot7_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot7_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDelLagoElMiradorPivot7_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot7,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot7_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot7_2015.HydricBalance = lCIWDelLagoElMiradorPivot7_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot7_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot7_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot7_2015.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot7_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot7_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot7_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot7_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot7_2015 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot7_2015.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot7_2015 = lCIWDelLagoElMiradorPivot7_2015.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot7_2015 = lFirstTitleIdDelLagoElMiradorPivot7_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot7_2015.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot7_2015;
                        lTitleIdDelLagoElMiradorPivot7_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot7_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot7_2015 - lFirstTitleIdDelLagoElMiradorPivot7_2015) % (lTotalTitlesDelLagoElMiradorPivot7_2015) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot7_2015 = lFirstTitleIdDelLagoElMiradorPivot7_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Del Lago - El Mirador Pivot 8 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador8
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador8
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador8)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot8_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot8_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot8_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDelLagoElMiradorPivot8_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot8,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot8_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot8_2015.HydricBalance = lCIWDelLagoElMiradorPivot8_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot8_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot8_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot8_2015.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot8_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot8_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot8_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot8_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot8_2015 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot8_2015.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot8_2015 = lCIWDelLagoElMiradorPivot8_2015.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot8_2015 = lFirstTitleIdDelLagoElMiradorPivot8_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot8_2015.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot8_2015;
                        lTitleIdDelLagoElMiradorPivot8_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot8_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot8_2015 - lFirstTitleIdDelLagoElMiradorPivot8_2015) % (lTotalTitlesDelLagoElMiradorPivot8_2015) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot8_2015 = lFirstTitleIdDelLagoElMiradorPivot8_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Del Lago - El Mirador Pivot 9 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador9
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador9
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador9)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot9_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot9_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot9_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWDelLagoElMiradorPivot9_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot9,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot9_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot9_2015.HydricBalance = lCIWDelLagoElMiradorPivot9_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot9_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot9_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot9_2015.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot9_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot9_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot9_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot9_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot9_2015 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot9_2015.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot9_2015 = lCIWDelLagoElMiradorPivot9_2015.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot9_2015 = lFirstTitleIdDelLagoElMiradorPivot9_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot9_2015.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot9_2015;
                        lTitleIdDelLagoElMiradorPivot9_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot9_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot9_2015 - lFirstTitleIdDelLagoElMiradorPivot9_2015) % (lTotalTitlesDelLagoElMiradorPivot9_2015) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot9_2015 = lFirstTitleIdDelLagoElMiradorPivot9_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                }
                #endregion

                #region La Palma
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPalma)
                {
                    #region La Palma Pivot 2A 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmLaPalma
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth) //TODO: Verify Region of La Palma
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort   //TODO: Verify Specie of La Palma
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotLaPalma2A
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilLaPalma2A
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotLaPalma2A)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_LaPalmaPivot2A_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_LaPalmaPivot2A_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_LaPalmaPivot2A_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWLaPalmaPivot2A_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherLaPalmaPivot2A,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWLaPalmaPivot2A_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWLaPalmaPivot2A_2015.HydricBalance = lCIWLaPalmaPivot2A_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWLaPalmaPivot2A_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWLaPalmaPivot2A_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWLaPalmaPivot2A_2015.Titles)
                    {
                        var lTitlesLaPalmaPivot2A_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWLaPalmaPivot2A_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWLaPalmaPivot2A_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesLaPalmaPivot2A_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdLaPalmaPivot2A_2015 = (from title in context.Titles
                                                             where title.Name == "DDS"
                                                                && title.Daily == false
                                                                && title.CropIrrigationWeatherId == lCIWLaPalmaPivot2A_2015.CropIrrigationWeatherId
                                                             select title.TitleId).FirstOrDefault();
                    long lTotalTitlesLaPalmaPivot2A_2015 = lCIWLaPalmaPivot2A_2015.Titles.Count();
                    long lTitleIdLaPalmaPivot2A_2015 = lFirstTitleIdLaPalmaPivot2A_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWLaPalmaPivot2A_2015.Messages)
                    {
                        item.TitleId = lTitleIdLaPalmaPivot2A_2015;
                        lTitleIdLaPalmaPivot2A_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWLaPalmaPivot2A_2015.CropIrrigationWeatherId;
                        if ((lTitleIdLaPalmaPivot2A_2015 - lFirstTitleIdLaPalmaPivot2A_2015) % (lTotalTitlesLaPalmaPivot2A_2015) == 0)
                        {
                            lTitleIdLaPalmaPivot2A_2015 = lFirstTitleIdLaPalmaPivot2A_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region La Palma Pivot 3 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmLaPalma
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth) //TODO: Verify Region of La Palma
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort   //TODO: Verify Specie of La Palma
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotLaPalma3
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilLaPalma3
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotLaPalma3)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_LaPalmaPivot3_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_LaPalmaPivot3_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_LaPalmaPivot3_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWLaPalmaPivot3_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherLaPalmaPivot3,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWLaPalmaPivot3_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWLaPalmaPivot3_2015.HydricBalance = lCIWLaPalmaPivot3_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWLaPalmaPivot3_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWLaPalmaPivot3_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWLaPalmaPivot3_2015.Titles)
                    {
                        var lTitlesLaPalmaPivot3_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWLaPalmaPivot3_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWLaPalmaPivot3_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesLaPalmaPivot3_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdLaPalmaPivot3_2015 = (from title in context.Titles
                                                            where title.Name == "DDS"
                                                               && title.Daily == false
                                                               && title.CropIrrigationWeatherId == lCIWLaPalmaPivot3_2015.CropIrrigationWeatherId
                                                            select title.TitleId).FirstOrDefault();
                    long lTotalTitlesLaPalmaPivot3_2015 = lCIWLaPalmaPivot3_2015.Titles.Count();
                    long lTitleIdLaPalmaPivot3_2015 = lFirstTitleIdLaPalmaPivot3_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWLaPalmaPivot3_2015.Messages)
                    {
                        item.TitleId = lTitleIdLaPalmaPivot3_2015;
                        lTitleIdLaPalmaPivot3_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWLaPalmaPivot3_2015.CropIrrigationWeatherId;
                        if ((lTitleIdLaPalmaPivot3_2015 - lFirstTitleIdLaPalmaPivot3_2015) % (lTotalTitlesLaPalmaPivot3_2015) == 0)
                        {
                            lTitleIdLaPalmaPivot3_2015 = lFirstTitleIdLaPalmaPivot3_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region La Palma Pivot 4 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmLaPalma
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth) //TODO: Verify Region of La Palma, region north
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort   //TODO: Verify Specie of La Palma, region north
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotLaPalma4
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilLaPalma4
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotLaPalma4)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_LaPalmaPivot4_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_LaPalmaPivot4_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_LaPalmaPivot4_2015;
                    }
                    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                            join weatherstation in context.WeatherStations
                                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    var lCIWLaPalmaPivot4_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherLaPalmaPivot4,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWLaPalmaPivot4_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWLaPalmaPivot4_2015.HydricBalance = lCIWLaPalmaPivot4_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWLaPalmaPivot4_2015.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWLaPalmaPivot4_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWLaPalmaPivot4_2015.Titles)
                    {
                        var lTitlesLaPalmaPivot4_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWLaPalmaPivot4_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWLaPalmaPivot4_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesLaPalmaPivot4_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdLaPalmaPivot4_2015 = (from title in context.Titles
                                                            where title.Name == "DDS"
                                                               && title.Daily == false
                                                               && title.CropIrrigationWeatherId == lCIWLaPalmaPivot4_2015.CropIrrigationWeatherId
                                                            select title.TitleId).FirstOrDefault();
                    long lTotalTitlesLaPalmaPivot4_2015 = lCIWLaPalmaPivot4_2015.Titles.Count();
                    long lTitleIdLaPalmaPivot4_2015 = lFirstTitleIdLaPalmaPivot4_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWLaPalmaPivot4_2015.Messages)
                    {
                        item.TitleId = lTitleIdLaPalmaPivot4_2015;
                        lTitleIdLaPalmaPivot4_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWLaPalmaPivot4_2015.CropIrrigationWeatherId;
                        if ((lTitleIdLaPalmaPivot4_2015 - lFirstTitleIdLaPalmaPivot4_2015) % (lTotalTitlesLaPalmaPivot4_2015) == 0)
                        {
                            lTitleIdLaPalmaPivot4_2015 = lFirstTitleIdLaPalmaPivot4_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                }
                #endregion

                #region New Farm

                #region Farm Pivot # 2015

                #endregion

                #endregion

            }
        }

        /// <summary>
        /// Add PhenologicalStage Adjustments:
        ///     - DataEntry Add PhenologicalStage Adjustements Farm Pivot Year
        /// </summary>
        private static void AddPhenologicalStageAdjustements()
        {
            #region South

            #region Demo - La Perdiz
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntry.AddPhenologicalStageAdjustementsDemoPivot1_2015(context);
                    DataEntry.AddPhenologicalStageAdjustementsDemoPivot2_2015(context);
                    DataEntry.AddPhenologicalStageAdjustementsDemoPivot3_2015(context);
                    DataEntry.AddPhenologicalStageAdjustementsDemoPivot5_2015(context);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Santa Lucia
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    
                    context.SaveChanges();
                }
            }
            #endregion

            #region La Perdiz
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //DataEntry.AddPhenologicalStageAdjustementsLaPerdizPivot2_2015(context);
                    //DataEntry.AddPhenologicalStageAdjustementsLaPerdizPivot3_2015(context);
                    //DataEntry.AddPhenologicalStageAdjustementsLaPerdizPivot5_2015(context);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Del Lago - San Pedro
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    
                    context.SaveChanges();
                }
            }
            #endregion

            #region Del Lago - El Mirador
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    
                    context.SaveChanges();
                }
            }
            #endregion

            #region La Palma
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPalma)
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

        /// <summary>
        /// Add Information to Irrigation Units:
        ///     - DataEntry Add Information To Irrigation Units Farm Pivot Year
        /// </summary>
        private static void AddInformationToIrrigationUnits()
        {
            #region South

            #region Demo - La Perdiz
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntry.AddInformationToIrrigationUnitsDemo1Pivot11_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsDemo1Pivot12_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsDemo1Pivot13_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsDemo1Pivot15_2015(context);
                    context.SaveChanges();
                    DataEntry.AddInformationToIrrigationUnitsDemo2Pivot21_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsDemo2Pivot22_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsDemo2Pivot23_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsDemo2Pivot24_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsDemo2Pivot25_2015(context);
                    context.SaveChanges();
                    //DataEntry.AddInformationToIrrigationUnitsDemo3Pivot31_2015(context);
                    //DataEntry.AddInformationToIrrigationUnitsDemo3Pivot32A_2015(context);
                    //DataEntry.AddInformationToIrrigationUnitsDemo3Pivot33_2015(context);
                    //DataEntry.AddInformationToIrrigationUnitsDemo3Pivot34_2015(context);
                    //DataEntry.AddInformationToIrrigationUnitsDemo3Pivot35_2015(context);
                    //context.SaveChanges();
                }
            }
            #endregion

            #region La Perdiz
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntry.AddInformationToIrrigationUnitsLaPerdizPivot2_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsLaPerdizPivot3_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsLaPerdizPivot5_2015(context);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Del Lago - San Pedro
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntry.AddInformationToIrrigationUnitsDelLagoSanPedroPivot5_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoSanPedroPivot6_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoSanPedroPivot7_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoSanPedroPivot8_2015(context);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Del Lago - El Mirador
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot6_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot7_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot8_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot9_2015(context);
                    context.SaveChanges();
                }
            }
            #endregion

            #region La Palma
            if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntry.AddInformationToIrrigationUnitsLaPalmaPivot2A_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsLaPalmaPivot3_2015(context);
                    DataEntry.AddInformationToIrrigationUnitsLaPalmaPivot4_2015(context);
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

        #endif
        #endregion

        #region Print

        /// <summary>
        /// Layout of Daily Records
        /// </summary>
        private static void LayoutDailyRecords()
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
                if (PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
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
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
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
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
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
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
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
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
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
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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
                if (PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || PrintFarm == Utils.IrrigationAdvisorOutputFiles.SantaLucia)
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
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
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
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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
                #endregion

                #region LaPerdiz
                if (PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || PrintFarm == Utils.IrrigationAdvisorOutputFiles.LaPerdiz)
                {

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
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
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
                                       where iu.Name == Utils.NamePivotLaPerdiz2
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilLaPerdiz2
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotLaPerdiz2)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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
                                       where iu.Name == Utils.NamePivotLaPerdiz3
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilLaPerdiz3
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotLaPerdiz3)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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
                                       where iu.Name == Utils.NamePivotLaPerdiz5
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilLaPerdiz5
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotLaPerdiz5)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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

                #region Del Lago - San Pedro
                if (PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoSanPedro)
                {
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
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
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
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
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
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
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
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
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
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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

                #region Del Lago - El Mirador
                if (PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
                {
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
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
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
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
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
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
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
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
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
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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
                
                #region La Palma
                if (PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || PrintFarm == Utils.IrrigationAdvisorOutputFiles.LaPalma)
                {

                    #region La Palma Pivot 2A 2015
                    lFile = "IrrigationSystem_LaPalma_Pivot_2A_Maiz_2015";

                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                             .ToList<EffectiveRain>();

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmLaPalma
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
                                       where iu.Name == Utils.NamePivotLaPalma2A
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilLaPalma2A
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotLaPalma2A)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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
                             where farm.Name == Utils.NameFarmLaPalma
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
                                       where iu.Name == Utils.NamePivotLaPalma3
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilLaPalma3
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotLaPalma3)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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
                             where farm.Name == Utils.NameFarmLaPalma
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
                                       where iu.Name == Utils.NamePivotLaPalma4
                                       select iu).FirstOrDefault();
                    lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                              where ciw.CropId == lCrop.CropId
                                                  && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                                  && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
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
                                            where (weatherdata.Date >= lSowingDate ||
                                                    weatherdata.Date <= lHarvestDate) &&
                                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                            select weatherdata).ToList<WeatherData>();
                    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                                   join weatherstation in context.WeatherStations
                                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                                   where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                        weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilLaPalma4
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotLaPalma4)
                                    select horizon)
                                    .ToList<Horizon>();

                    #region TextLog
                    lCropIrrigationWeather.TextLog = lCropIrrigationWeather.OutPut;
                    lCropIrrigationWeather.TextLog += Environment.NewLine + Environment.NewLine + printDailyRecordList(lCropIrrigationWeather);

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

                }
                #endregion

                #endregion

                #region North
                #endregion
            }
        }

        /// <summary>
        /// Print Daily Record List
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <returns></returns>
        private static String printDailyRecordList(CropIrrigationWeather pCropIrrigationWeather)
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

        /// <summary>
        /// Print Weather Data List
        /// </summary>
        /// <param name="pWeatherStation"></param>
        /// <returns></returns>
        private static String printWeatherDataList(WeatherStation pWeatherStation)
        {
            String lReturn = Environment.NewLine + "WEATHER DATA" + Environment.NewLine;
            foreach (WeatherData lWeatherData in pWeatherStation.WeatherDataList)
            {
                lReturn += lWeatherData.ToString() + Environment.NewLine;
            }
            return lReturn;
        }

        #endregion

    }

    public class IASystem 
    {
        
        public IrrigationSystem IrrigationAdvSystem { get; set; }
        
        public IASystem()
        {
            IrrigationAdvSystem = IrrigationSystem.Instance;
        }

    }
}
