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
                RoleId = 2,
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

            var lCristian = new User()
            {
                Name = "Cristian",
                Surname = "Gonzalez",
                Phone = "099 127 950",
                Address = "1958 Cuareim, Montevideo",
                Email = "riegopgw@googlegroups.com",
                UserName = Utils.NameUserCristian,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "Cr15t14n"),
                RoleId = 1,
            };

            var lCPalo = new User()
            {
                Name = "Cristian Diego",
                Surname = "Palo",
                Phone = "099 234 500",
                Address = "1958 Cuareim, Montevideo",
                Email = "riegopgw@googlegroups.com",
                UserName = Utils.NameUserCPalo,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "Cr15t14n"),
                RoleId = 1,
            };

            var lMCarle = new User()
            {
                Name = "Monica",
                Surname = "Carle",
                Phone = "098 291 349",
                Address = "1958 Cuareim, Montevideo",
                Email = "riegopgw@googlegroups.com",
                UserName = Utils.NameUserMCarle,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "M0n1c4"),
                RoleId = 1,
            };

            var lROlivera = new User()
            {
                Name = "Rodolfo",
                Surname = "Olivera",
                Phone = "099 618 260",
                Address = "1958 Cuareim, Montevideo",
                Email = "riegopgw@googlegroups.com",
                UserName = Utils.NameUserROlivera,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "R0d01f0"),
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
            var lDCAJavier = new User()
            {
                Name = "Javier",
                Surname = "Lauber",
                Phone = "+598 99 530 023",
                Address = "Mercedes Ruta 14",
                Email = "javierlauber@hotmail.com",
                UserName = Utils.NameUserDCA3,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "ADC2017"),
                RoleId = 3,
            };
            var lDCASantiago = new User()
            {
                Name = "Santiago",
                Surname = "Chilibroste",
                Phone = "+598 92 384 296",
                Address = "Mercedes Ruta 14",
                Email = "schilibroste@delcarmen.com.uy",
                UserName = Utils.NameUserDCA4,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "ADC2017"),
                RoleId = 3,
            };
            var lDCAAlejandro = new User()
            {
                Name = "Alejandro",
                Surname = "Gareta",
                Phone = "+598 91 727 569",
                Address = "Mercedes Ruta 14",
                Email = "",
                UserName = Utils.NameUserDCA5,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "ADC2017"),
                RoleId = 3,
            };
            var lDCARaul = new User()
            {
                Name = "Raul",
                Surname = "Pastorino",
                Phone = "+598 98 306 440",
                Address = "Mercedes Ruta 14",
                Email = "",
                UserName = Utils.NameUserDCA6,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "ADC2017"),
                RoleId = 3,
            };
            #endregion

            #region Estancias del Lago - Del Lago - EDL
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
            var lDelLagoSebastian = new User()
            {
                Name = "Sebastian",
                Surname = "Riera",
                Phone = "+598 99 355 924",
                Address = "Ruta 4 Km 20, Durazno, Uruguay CP 97.000",
                Email = "sriera@estanciasdellago.com ",
                UserName = Utils.NameUserDelLago3,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "EDL2017"),
                RoleId = 3,
            };
            var lDelLagoJoseV = new User()
            {
                Name = "José",
                Surname = "Volf",
                Phone = "+598 98 349 739",
                Address = "Ruta 4 Km 20, Durazno, Uruguay CP 97.000",
                Email = "jose.volf@estanciasdellago.com ",
                UserName = Utils.NameUserDelLago4,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "EDL2017"),
                RoleId = 3,
            };
            var lDelLagoLuis = new User()
            {
                Name = "Luis",
                Surname = "Lanusse",
                Phone = "+54 11 6469 5425",
                Address = "Ruta 4 Km 20, Durazno, Uruguay CP 97.000",
                Email = "llanusse@samconsult.com ",
                UserName = Utils.NameUserDelLago5,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "EDL2017"),
                RoleId = 3,
            };
            var lDelLagoJRRodriguez = new User()
            {
                Name = "Juan Ramon",
                Surname = "Rodriguez",
                Phone = "+598 99 580 604",
                Address = "Ruta 4 Km 20, Durazno, Uruguay CP 97.000",
                Email = "juan.rodriguez@estanciasdellago.com ",
                UserName = Utils.NameUserDelLago6,
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
            var lGMOGuillermo = new User()
            {
                Name = "Guillermo",
                Surname = "O Brien",
                Phone = "+598 99 636 441",
                Address = "Ruta 4 km 640",
                Email = "guillermoobrien@adinet.com.uy",
                UserName = Utils.NameUserGMO4,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "GMO2018"),
                RoleId = 3,
            };
            var lGMOEsteban = new User()
            {
                Name = "Esteban",
                Surname = "Molina",
                Phone = "+598 92 747 921",
                Address = "Ruta 4 km 640",
                Email = "emolinapenna@gmail.com",
                UserName = Utils.NameUserGMO5,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "GMO2018"),
                RoleId = 3,
            };
            var lGMOLuis = new User()
            {
                Name = "Luis",
                Surname = "Ramirez",
                Phone = "+598 92 747 922",
                Address = "Ruta 25 km 20",
                Email = "l.ramirez@vera.com.uy",
                UserName = Utils.NameUserGMO6,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "GMO2018"),
                RoleId = 3,
            };
            var lGMOSebastian = new User()
            {
                Name = "Sebastian",
                Surname = "O Brien",
                Phone = "+598 99 684 102",
                Address = "Ruta 4 km 640",
                Email = "sobrien@timbertec.com.uy",
                UserName = Utils.NameUserGMO7,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "GMO2018"),
                RoleId = 3,
            };
            var lGMOGuzman = new User()
            {
                Name = "Guzman",
                Surname = "Hernandez",
                Phone = "+598 92 167 576",
                Address = "Ruta 4 km 640",
                Email = "guzmanhernandezbordenave@gmail.com",
                UserName = Utils.NameUserGMO8,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "GMO2018"),
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

            #region Albanell - Tres Marias
            var lTresMariasCarlosE = new User()
            {
                Name = "Carlos",
                Surname = "Etchegaray",
                Phone = "+598 99 603 349",
                Address = "Misiones 1481 P2",
                Email = "cetchega@gmail.com",
                UserName = Utils.NameUserTM1,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "TM2017"),
                RoleId = 3,
            };
            #endregion

            #region Nilve - El Rincon
            var lElRinconEBonino = new User()
            {
                Name = "Eduardo",
                Surname = "Bonino",
                Phone = "+598 99 204 293",
                Address = "Ruta 1, km 77",
                Email = "eb6164@vera.com.uy",
                UserName = Utils.NameUserER1,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "ER2018"),
                RoleId = 3,
            };
            #endregion

            #region El Desafio
            var lElDesafioMAlgorta = new User()
            {
                Name = "Marcos",
                Surname = "Algorta",
                Phone = "+598 98 927 885",
                Address = "Ruta 1, km 58",
                Email = "algortamarcos@gmail.com",
                UserName = Utils.NameUserED1,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "ED2018"),
                RoleId = 3,
            };
            #endregion

            #region OLAM - Los Naranjales
            var lLosNaranjalesIGoicoechea = new User()
            {
                Name = "Ignacio",
                Surname = "Goicoechea",
                Phone = "+598 98 200 064",
                Address = "Ruta 56, km 32",
                Email = "ignacio.goicoechea@olamnet.com",
                UserName = Utils.NameUserLN1,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "LN2018"),
                RoleId = 3,
            };
            var lLosNaranjalesPIglesias = new User()
            {
                Name = "Pablo",
                Surname = "Iglesias",
                Phone = "+598 913 933 094",
                Address = "Ruta 56, km 32",
                Email = "pablo.iglesias@olamnet.com",
                UserName = Utils.NameUserLN2,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "LN2018"),
                RoleId = 3,
            };
            var lLosNaranjalesJDemelo = new User()
            {
                Name = "Juan",
                Surname = "de Melo",
                Phone = "+598 98 200 066",
                Address = "Ruta 56, km 32",
                Email = "juan.demelo@olamnet.com",
                UserName = Utils.NameUserLN3,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "LN2018"),
                RoleId = 3,
            };
            var lLosNaranjalesSScarlato = new User()
            {
                Name = "Santiago",
                Surname = "Scarlato",
                Phone = "+598 99 140 736",
                Address = "Ruta 56, km 32",
                Email = "sscarlato@gmail.com",
                UserName = Utils.NameUserLN4,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "LN2018"),
                RoleId = 3,
            };
            

            #endregion

            #region Santa Emilia
            var lSantaEmiliaDSilveyra = new User()
            {
                Name = "David",
                Surname = "Silveyra",
                Phone = "+598 98 319 949",
                Address = "Ruta 2, km 141",
                Email = "thedavis015@hotmail.com",
                UserName = Utils.NameUserSE1,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "SE2018"),
                RoleId = 3,
            };
            var lSantaEmiliaSMontero = new User()
            {
                Name = "Salvador",
                Surname = "Montero",
                Phone = "+598 99 550 676",
                Address = "Ruta 2, km 141",
                Email = "monterosalvador@hotmail.com",
                UserName = Utils.NameUserSE2,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "SE2018"),
                RoleId = 3,
            };
            #endregion

            #region Gran Molino
            var lGranMolinoPJimenez = new User()
            {
                Name = "Pablo",
                Surname = "Jimenez",
                Phone = "+598 99 146 616",
                Address = "Ruta 1, km 45",
                Email = "pjimenezdearechaga@gmail.com",
                UserName = Utils.NameUserGM1,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "GM2018"),
                RoleId = 3,
            };

            #endregion

            #region La Portuguesa
            var lLaPortuguesaPDamiani = new User()
            {
                Name = "Patricia",
                Surname = "Damiani",
                Phone = "+598 99 999 999",
                Address = "Saucedo, Salto",
                Email = "damianipatricia@gmail.com",
                UserName = Utils.NameUserGM1,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "GM2018"),
                RoleId = 3,
            };

            #endregion

            #region Cassarino - La Perdiz
            var lCassarinoLaPerdizFRovira = new User()
            {
                Name = "Fernando",
                Surname = "Rovira",
                Phone = "+598 99 246 587",
                Address = "Ruta 105, km 60. Soriano",
                Email = "fernando.roviracuervo@gmail.com",
                UserName = Utils.NameUserCLP1,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "LP2019"),
                RoleId = 3,
            };

            #endregion

            #region Santo Domingo
            var lSantoDomingoDOrdoqui = new User()
            {
                Name = "Daniel",
                Surname = "Ordoqui",
                Phone = "+598 99 353 896",
                Address = "Ruta 21, Conchillas",
                Email = "danordoqui@gmail.com",
                UserName = Utils.NameUserSD1,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "SD2018"),
                RoleId = 3,
            };

            #endregion

            #region Cecchini
            var lCecchiniWalter = new User()
            {
                Name = "Walter",
                Surname = "Cecchini",
                Phone = "+598 91 097 912",
                Address = "Ruta 21, km 4",
                Email = "walter_cecchini@hotmail.com",
                UserName = Utils.NameUserCE1,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "WC2018"),
                RoleId = 3,
            };
            var lCecchiniJulio = new User()
            {
                Name = "Julio",
                Surname = "Cecchini",
                Phone = "+598 91 097 912",
                Address = "Ruta 21, km 4",
                Email = "julioe_1987@hotmail.com",
                UserName = Utils.NameUserCE2,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "WC2018"),
                RoleId = 3,
            };

            #endregion

            #region El Alba
            var lElAlbaDUrani = new User()
            {
                Name = "Daniel",
                Surname = "Urani",
                Phone = "+598 99 568 176",
                Address = "Ruta 55, Campana",
                Email = "estanciaelalba@gmail.com",
                UserName = Utils.NameUserEA1,
                Password = CryptoUtils.GetMd5Hash(MD5.Create(), "EA2018"),
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
                context.Users.Add(lCristian);
                context.Users.Add(lCPalo);
                context.Users.Add(lMCarle);
                context.Users.Add(lROlivera);
                context.Users.Add(lAdmin);
                context.Users.Add(lDCAJuan);
                context.Users.Add(lDCAFabian);
                context.Users.Add(lDCAJavier);
                context.Users.Add(lDCASantiago);
                context.Users.Add(lDCAAlejandro);
                context.Users.Add(lDCARaul);
                context.Users.Add(lDelLagoGuzman);
                context.Users.Add(lDelLagoJose);
                context.Users.Add(lDelLagoSebastian);
                context.Users.Add(lDelLagoJoseV);
                context.Users.Add(lDelLagoLuis);
                context.Users.Add(lDelLagoJRRodriguez);
                context.Users.Add(lGMOPablo);
                context.Users.Add(lGMODiego);
                context.Users.Add(lGMOMauricio);
                context.Users.Add(lGMOGuillermo);
                context.Users.Add(lGMOEsteban);
                context.Users.Add(lGMOLuis);
                context.Users.Add(lGMOSebastian);
                context.Users.Add(lGMOGuzman);
                context.Users.Add(lTresMariasCarlosE);
                context.Users.Add(lLaRinconadaJuanB);
                context.Users.Add(lLarinconadaJuanP);
                context.Users.Add(lElRinconEBonino);
                context.Users.Add(lElDesafioMAlgorta);
                context.Users.Add(lLosNaranjalesIGoicoechea);
                context.Users.Add(lLosNaranjalesPIglesias);
                context.Users.Add(lLosNaranjalesJDemelo);
                context.Users.Add(lLosNaranjalesSScarlato);
                context.Users.Add(lSantaEmiliaDSilveyra);
                context.Users.Add(lSantaEmiliaSMontero);
                context.Users.Add(lGranMolinoPJimenez);
                context.Users.Add(lLaPortuguesaPDamiani);
                context.Users.Add(lCassarinoLaPerdizFRovira);
                context.Users.Add(lSantoDomingoDOrdoqui);
                context.Users.Add(lCecchiniWalter);
                context.Users.Add(lCecchiniJulio);
                context.Users.Add(lElAlbaDUrani);
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
                    lUserNames = new String[] { Utils.NameUserSeba,  Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTestAdm };

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
                    lUserNames = new String[] { Utils.NameUserSeba, Utils.NameUserGonza, 
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTestAdm};

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
                    lUserNames = new String[] { Utils.NameUserSeba, Utils.NameUserGonza, 
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTestAdm };

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
                    lUserNames = new String[] { Utils.NameUserSantaLucia, 
                                                Utils.NameUserSeba, Utils.NameUserGonza, 
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm};

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
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
                {
                    lUserNames = new String[] { Utils.NameUserDCA1, Utils.NameUserDCA3,
                                                Utils.NameUserDCA4, Utils.NameUserDCA6,
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

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
                #region Del Carmen ACISA S.A. - La Perdiz - DCA
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
                {
                    lUserNames = new String[] { Utils.NameUserDCA1, Utils.NameUserDCA3, 
                                                Utils.NameUserDCA4, Utils.NameUserDCA5, 
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

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
                #region Del Carmen ACISA S.A. - San Jose - DCA
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
                {
                    lUserNames = new String[] { Utils.NameUserDCA1, Utils.NameUserDCA3,
                                                Utils.NameUserDCA4, 
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

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

                #region DelLago - San Pedro - Estancias del Lago S.R.L.
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
                {
                    lUserNames = new String[] { Utils.NameUserDelLago1, Utils.NameUserDelLago2, 
                                                Utils.NameUserDelLago3, Utils.NameUserDelLago4,  
                                                Utils.NameUserDelLago5,
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

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
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
                {
                    lUserNames = new String[] { Utils.NameUserDelLago1, Utils.NameUserDelLago2,
                                                Utils.NameUserDelLago3, Utils.NameUserDelLago4,  
                                                Utils.NameUserDelLago5,  Utils.NameUserDelLago6,  
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

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
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
                {
                    lUserNames = new String[] { Utils.NameUserGMO1, Utils.NameUserGMO2, Utils.NameUserGMO3,
                                                Utils.NameUserGMO4, Utils.NameUserGMO5, Utils.NameUserGMO6,
                                                Utils.NameUserGMO7, Utils.NameUserGMO8, 
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

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
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
                {
                    lUserNames = new String[] { Utils.NameUserGMO1, Utils.NameUserGMO2, Utils.NameUserGMO3,
                                                Utils.NameUserGMO4, Utils.NameUserGMO5, Utils.NameUserGMO6,
                                                Utils.NameUserGMO7, Utils.NameUserGMO8,
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

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

                #region Albanell - Tres Marias
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
                {
                    lUserNames = new String[] { Utils.NameUserTM1, 
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmTresMarias
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
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
                {
                    lUserNames = new String[] { Utils.NameUserLR1, Utils.NameUserLR2, 
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

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

                #region Nilve S.A. - El Rincon - ER
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElRincon)
                {
                    lUserNames = new String[] { Utils.NameUserER1, 
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmElRincon
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

                #region El Desafio - ED
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElDesafio)
                {
                    lUserNames = new String[] { Utils.NameUserED1, 
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmElDesafio
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

                #region OLAM - Los Naranjales - LN
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LosNaranjales)
                {
                    lUserNames = new String[] { Utils.NameUserLN1, Utils.NameUserLN2,
                                                Utils.NameUserLN3, Utils.NameUserLN4, 
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmLosNaranjales
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

                #region Sierra Madera S.A - Santa Emilia - SE
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaEmilia)
                {
                    lUserNames = new String[] { Utils.NameUserSE1, Utils.NameUserSE2,
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmSantaEmilia
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

                #region Gran Molino SRL - Gran Molino - GM
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GranMolino)
                {
                    lUserNames = new String[] { Utils.NameUserGM1,
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGranMolino
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

                #region La Portuguesa - LP
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPortuguesa)
                {
                    lUserNames = new String[] { Utils.NameUserLP1, 
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmLaPortuguesa
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
                #region Cassarino La Perdiz - CLP
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.CassarinoLaPerdiz)
                {
                    lUserNames = new String[] { Utils.NameUserCLP1, 
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmCassarinoLaPerdiz
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
                #region Santo Domingo - SD
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantoDomingo)
                {
                    lUserNames = new String[] { Utils.NameUserSD1, 
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmSantoDomingo
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

                #region Cecchini - CE
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Cecchini)
                {
                    lUserNames = new String[] { Utils.NameUserCE1, Utils.NameUserCE2,
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmCecchini
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
                #region El Alba - EA
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElAlba)
                {
                    lUserNames = new String[] { Utils.NameUserEA1, 
                                                Utils.NameUserSeba, Utils.NameUserGonza,
                                                Utils.NameUserAdmin, Utils.NameUserCristian,
                                                Utils.NameUserCPalo, Utils.NameUserMCarle,
                                                Utils.NameUserROlivera, Utils.NameUserDemo,
                                                Utils.NameUserTesting, Utils.NameUserTestAdm };

                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmElAlba
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
