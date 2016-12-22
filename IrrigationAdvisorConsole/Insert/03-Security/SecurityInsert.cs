using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.ComplementedUtils;

using IrrigationAdvisor.DBContext;

namespace IrrigationAdvisorConsole.Insert._03_Security
{
    public static class SecurityInsert
    {

        #region Security

        public static void InsertRoles()
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

            var lRoleTesting = new Role()
            {
                RoleId = 4,
                Name = "Testing",
                SiteId = 1,
                MenuId = 1,
            };

            using (var context = new IrrigationAdvisorContext())
            {
                context.Roles.Add(lRoleAdministrator);
                context.Roles.Add(lRoleIntermediate);
                context.Roles.Add(lRoleStandard);
                context.Roles.Add(lRoleTesting);
                context.SaveChanges();
            }

        }

        public static void InsertUsers()
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

            #region Demo-Testing
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
            var lTesting = new User()
            {
                Name = Utils.NameUserTesting,
                Surname = "PGW Water Testing",
                Phone = "098 938 269",
                Address = "1958 Cuareim, Montevideo",
                Email = "riegopgw@googlegroups.com",
                UserName = Utils.NameUserTesting,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "riego"),
                RoleId = 1,
            };
            var lTestAdmin = new User()
            {
                Name = Utils.NameUserTestAdm,
                Surname = "PGW Water TestAdm",
                Phone = "098 938 269",
                Address = "1958 Cuareim, Montevideo",
                Email = "riegopgw@googlegroups.com",
                UserName = Utils.NameUserTestAdm,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "riego"),
                RoleId = 1,
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

            var lGMoreno = new User()
            {
                Name = "Gonzalo",
                Surname = "Moreno",
                Phone = "098 645 016",
                Address = "1958 Cuareim, Montevideo",
                Email = "gmoreno@pgwwater.com.uy",
                UserName = Utils.NameUserGonza,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "GMoreno"),
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
                RoleId = 1,
            };
            #endregion

            #region Del Carmen ACISA S.A. - El Paraiso - San Jose - La Perdiz - DCA
            var lDCAJuan = new User()
            {
                Name = "Juan",
                Surname = "Platero",
                Phone = "+598 98 938 269",
                Address = "Mercedes",
                Email = "jplatero@delcarmen.com.uy",
                UserName = Utils.NameUserDCA1,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "ADC2017"),
                RoleId = 3,
            };
            var lDCAFabian = new User()
            {
                Name = "Fabian",
                Surname = "Artigue",
                Phone = "+598 99 830 058",
                Address = "Mercedes Ruta 14",
                Email = "fartigue@delcarmen.com.uy",
                UserName = Utils.NameUserDCA2,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "ADC2017"),
                RoleId = 3,
            };
            #endregion

            #region Estancias del lago - Del Lago - EDL
            var lDelLagoGuzman = new User()
            {
                Name = "Guzmán",
                Surname = "Irrazabal",
                Phone = "+598 91 359 000",
                Address = "Miguel Cabrera Km 5, Durazno, Uruguay CP 97.000",
                Email = "guzman.irazabal@estanciasdellago.com ",
                UserName = Utils.NameUserDelLago1,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "EDL2017"),
                RoleId = 3,
            };
            var lDelLagoJose = new User()
            {
                Name = "José",
                Surname = "Hemala",
                Phone = "+598 92 124 119",
                Address = "Ruta 4 Km 20, Durazno, Uruguay CP 97.000",
                Email = "jose.hemala@estanciasdellago.com ",
                UserName = Utils.NameUserDelLago2,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "EDL2017"),
                RoleId = 3,
            };
            #endregion

            #region Estancia Menafra - LaPalma ElTacuru - GMO
            var lGMOPablo = new User()
            {
                Name = "Pablo",
                Surname = "Tarigo",
                Phone = "+598 9",
                Address = "",
                Email = "pablo.tarigo@LaPalma.com.uy",
                UserName = Utils.NameUserGMO1,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "GMO2017"),
                RoleId = 3,
            };
            var lGMODiego = new User()
            {
                Name = "Diego",
                Surname = "Anselmi",
                Phone = "+598 94 688 833",
                Address = "Batlle 596, Trinidad",
                Email = "danselmi@tropagrande.com",
                UserName = Utils.NameUserGMO2,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "GMO2017"),
                RoleId = 3,
            };
            var lGMOMauricio = new User()
            {
                Name = "Mauricio",
                Surname = "Rios",
                Phone = "+598 94 688 849",
                Address = "Batlle 596, Trinidad",
                Email = "mrios@tropagrande.com",
                UserName = Utils.NameUserGMO3,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "GMO2017"),
                RoleId = 3,
            };
            #endregion

            #region Maria Elena SRL - La Rinconada - LR
            var lLaRinconadaJuanB = new User()
            {
                Name = "Juan",
                Surname = "Baroffio",
                Phone = "+598 99 492 897",
                Address = "Ruta 3 km 287.3",
                Email = "juanbaroffio@ingleby.com.uy",
                UserName = Utils.NameUserLR1,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "LR2017"),
                RoleId = 3,
            };
            var lLarinconadaJuanP = new User()
            {
                Name = "Juan",
                Surname = "Pastorini",
                Phone = "+598 91 035 584",
                Address = "Ruta 3 km 287.3",
                Email = "juanpastorini@ingleby.com.uy",
                UserName = Utils.NameUserLR2,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "LR2017"),
                RoleId = 3,
            };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {
                //context.Users.Add(lBase);
                context.Users.Add(lDemo);
                context.Users.Add(lTesting);
                context.Users.Add(lTestAdmin);
                context.Users.Add(lSCasanova);
                context.Users.Add(lGMoreno);
                context.Users.Add(lAdmin);
                context.Users.Add(lDCAJuan);
                context.Users.Add(lDCAFabian);
                context.Users.Add(lDelLagoGuzman);
                context.Users.Add(lDelLagoJose);
                context.Users.Add(lGMOPablo);
                context.Users.Add(lGMODiego);
                context.Users.Add(lGMOMauricio);
                context.Users.Add(lLaRinconadaJuanB);
                context.Users.Add(lLarinconadaJuanP);
                context.SaveChanges();
            }

        }

        public static void InsertUserFarms()
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
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {
                    lUserNames = new String[] { Utils.NameUserDemo, Utils.NameUserSeba,  Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserTestAdm };

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
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {
                    lUserNames = new String[] { Utils.NameUserDemo, Utils.NameUserSeba, Utils.NameUserGonza, 
                                                Utils.NameUserAdmin, Utils.NameUserTestAdm };

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
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {
                    lUserNames = new String[] { Utils.NameUserDemo, Utils.NameUserSeba, Utils.NameUserGonza, 
                                                Utils.NameUserAdmin, Utils.NameUserTestAdm };

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
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
                {
                    lUserNames = new String[] { Utils.NameUserSantaLucia, Utils.NameUserSeba, Utils.NameUserGonza, 
                                                Utils.NameUserAdmin, Utils.NameUserTesting, Utils.NameUserTestAdm};

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmSantaLucia
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User lUser in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = lUser.UserId,
                            FarmId = lFarm.FarmId,
                            Name = lUser.Name + lFarm.Name,
                            StartDate = DateTime.Now,
                        };

                        context.UserFarms.Add(lUserFarm);
                        context.SaveChanges();
                    }
                }
                #endregion

                #region Del Carmen ACISA S.A. - El Paraiso - DCA
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
                {
                    lUserNames = new String[] { Utils.NameUserDCA1, Utils.NameUserDCA2, Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCAElParaiso
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User lUser in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = lUser.UserId,
                            FarmId = lFarm.FarmId,
                            Name = lUser.Name + lFarm.Name,
                            StartDate = DateTime.Now,
                        };

                        context.UserFarms.Add(lUserFarm);
                        context.SaveChanges();
                    }
                }
                #endregion

                #region Del Carmen ACISA S.A. - San Jose - DCA
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
                {
                    lUserNames = new String[] { Utils.NameUserDCA1, Utils.NameUserDCA2, 
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCASanJose
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User lUser in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = lUser.UserId,
                            FarmId = lFarm.FarmId,
                            Name = lUser.Name + lFarm.Name,
                            StartDate = DateTime.Now,
                        };

                        context.UserFarms.Add(lUserFarm);
                        context.SaveChanges();
                    }
                }
                #endregion

                #region Del Carmen ACISA S.A. - La Perdiz - DCA
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
                {
                    lUserNames = new String[] { Utils.NameUserDCA1, Utils.NameUserDCA2, 
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCALaPerdiz
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User lUser in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = lUser.UserId,
                            FarmId = lFarm.FarmId,
                            Name = lUser.Name + lFarm.Name,
                            StartDate = DateTime.Now,
                        };

                        context.UserFarms.Add(lUserFarm);
                        context.SaveChanges();
                    }
                }
                #endregion

                #region DelLago - San Pedro - Estancias del Lago S.R.L.
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
                {
                    lUserNames = new String[] { Utils.NameUserDelLago1, Utils.NameUserDelLago2, 
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoSanPedro
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User lUser in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = lUser.UserId,
                            FarmId = lFarm.FarmId,
                            Name = lUser.Name + lFarm.Name,
                            StartDate = DateTime.Now,
                        };

                        context.UserFarms.Add(lUserFarm);
                        context.SaveChanges();
                    }
                }
                #endregion

                #region DelLago - El Mirador - Estancias del Lago S.R.L.
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
                {
                    lUserNames = new String[] { Utils.NameUserDelLago1, Utils.NameUserDelLago2,
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User lUser in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = lUser.UserId,
                            FarmId = lFarm.FarmId,
                            Name = lUser.Name + lFarm.Name,
                            StartDate = DateTime.Now,
                        };

                        context.UserFarms.Add(lUserFarm);
                        context.SaveChanges();
                    }
                }
                #endregion

                #region Estancia Menafra - GMO - LaPalma
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
                {
                    lUserNames = new String[] { Utils.NameUserGMO1, Utils.NameUserGMO2, Utils.NameUserGMO3,
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOLaPalma
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User lUser in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = lUser.UserId,
                            FarmId = lFarm.FarmId,
                            Name = lUser.Name + lFarm.Name,
                            StartDate = DateTime.Now,
                        };

                        context.UserFarms.Add(lUserFarm);
                        context.SaveChanges();
                    }
                }
                #endregion

                #region Estancia Menafra - GMO - ElTacuru
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
                {
                    lUserNames = new String[] { Utils.NameUserGMO1, Utils.NameUserGMO2, Utils.NameUserGMO3,
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOElTacuru
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User lUser in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = lUser.UserId,
                            FarmId = lFarm.FarmId,
                            Name = lUser.Name + lFarm.Name,
                            StartDate = DateTime.Now,
                        };

                        context.UserFarms.Add(lUserFarm);
                        context.SaveChanges();
                    }
                }
                #endregion

                #region Maria Elena SRL - La Rinconada - LR
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
                {
                    lUserNames = new String[] { Utils.NameUserLR1, Utils.NameUserLR2, 
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmLaRinconada
                             select farm).FirstOrDefault();
                    lUserList = (from user in context.Users
                                 where lUserNames.Contains(user.UserName)
                                 select user).ToList();
                    foreach (User lUser in lUserList)
                    {
                        var lUserFarm = new UserFarm()
                        {
                            UserId = lUser.UserId,
                            FarmId = lFarm.FarmId,
                            Name = lUser.Name + lFarm.Name,
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

    }
}
