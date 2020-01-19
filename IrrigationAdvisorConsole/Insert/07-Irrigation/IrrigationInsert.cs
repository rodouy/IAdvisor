using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Utilities;

using IrrigationAdvisor.DBContext;

using IrrigationAdvisorConsole.Data;
using IrrigationAdvisorConsole.Insert._04_Localization;

namespace IrrigationAdvisorConsole.Insert._07_Irrigation
{
    public static class IrrigationInsert
    {

        #region Irrigation
#if true

        public static void InsertBombs()
        {
            Position lPosition = null;
            Farm lFarm = null;

            #region Base
            var lBase = new Bomb
            {
                Name = Utils.NameBase,
                ShortName = Utils.NameBase,
                SerialNumber = "0",
                PurchaseDate = Utils.MAX_DATETIME,
                ServiceDate = Utils.MAX_DATETIME,
                PositionId = 0,
                FarmId = 0,
            };
            #endregion

            #region Bomb Demo - La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDemo1
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmDemo1
                             select far).FirstOrDefault();

                    var lBombDemo = new Bomb
                    {
                        Name = Utils.NameBombDemo1,
                        ShortName = Utils.NameBombDemo1,
                        SerialNumber = "98134759807",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombDemo);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb Demo - Santa Lucia
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDemo2
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmDemo2
                             select far).FirstOrDefault();
                    
                    var lBombDemo = new Bomb
                    {
                        Name = Utils.NameBombDemo2,
                        ShortName = Utils.NameBombDemo2,
                        SerialNumber = "98134759807",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombDemo);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb Demo - La Palma
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDemo3
                                 select pos).FirstOrDefault();
                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmDemo3
                             select far).FirstOrDefault();


                    var lBombDemo = new Bomb
                    {
                        Name = Utils.NameBombDemo3,
                        ShortName = Utils.NameBombDemo3,
                        SerialNumber = "98134759807",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombDemo);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Bomb Santa Lucia
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All 
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmSantaLucia
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmSantaLucia
                             select far).FirstOrDefault();
                    
                    var lBombSantaLucia = new Bomb
                    {
                        Name = Utils.NameBombSantaLucia,
                        ShortName = Utils.NameBombSantaLucia,
                        SerialNumber = "1234",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };

                    context.Bombs.Add(lBombSantaLucia);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb El Paraiso
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
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDCAElParaiso
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmDCAElParaiso
                             select far).FirstOrDefault();

                    var lBombDCAElParaiso = new Bomb
                    {
                        Name = Utils.NameBombDCAElParaiso,
                        ShortName = Utils.NameBombDCAElParaiso,
                        SerialNumber = "98134759807",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombDCAElParaiso);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb San Jose
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
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDCASanJose
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmDCASanJose
                             select far).FirstOrDefault();

                    var lBombDCASanJose = new Bomb
                    {
                        Name = Utils.NameBombDCASanJose,
                        ShortName = Utils.NameBombDCASanJose,
                        SerialNumber = "98134759807",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombDCASanJose);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb La Perdiz
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
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDCALaPerdiz
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmDCALaPerdiz
                             select far).FirstOrDefault();

                    var lBombDCALaPerdiz = new Bomb
                    {
                        Name = Utils.NameBombDCALaPerdiz,
                        ShortName = Utils.NameBombDCALaPerdiz,
                        SerialNumber = "98134759807",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombDCALaPerdiz);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb Del Lago - San Pedro
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
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDelLagoSanPedro
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmDelLagoSanPedro
                             select far).FirstOrDefault();

                    var lBombDelLagoSanPedro = new Bomb
                    {
                        Name = Utils.NameBombDelLagoSanPedro,
                        ShortName = Utils.NameBombDelLagoSanPedro,
                        SerialNumber = "",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombDelLagoSanPedro);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb Del Lago - El Mirador
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
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDelLagoElMirador
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmDelLagoElMirador
                             select far).FirstOrDefault();

                    var lBombDelLagoElMirador = new Bomb
                    {
                        Name = Utils.NameBombDelLagoElMirador,
                        ShortName = Utils.NameBombDelLagoElMirador,
                        SerialNumber = "",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombDelLagoElMirador);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb GMO - LaPalma
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
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmGMOLaPalma
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmGMOLaPalma
                             select far).FirstOrDefault(); 

                    var lBombGMOLaPalma = new Bomb
                    {
                        Name = Utils.NameBombGMOLaPalma,
                        ShortName = Utils.NameBombGMOLaPalma,
                        SerialNumber = "",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombGMOLaPalma);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb GMO - ElTacuru
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
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmGMOElTacuru
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmGMOElTacuru
                             select far).FirstOrDefault();

                    var lBombGMOElTacuru = new Bomb
                    {
                        Name = Utils.NameBombGMOElTacuru,
                        ShortName = Utils.NameBombGMOElTacuru,
                        SerialNumber = "",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombGMOElTacuru);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb Tres Marias
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmTresMarias
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmTresMarias
                             select far).FirstOrDefault();
                    
                    var lBombTresMarias = new Bomb
                    {
                        Name = Utils.NameBombTresMarias,
                        ShortName = Utils.NameBombTresMarias,
                        SerialNumber = "111111111",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombTresMarias);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb La Rinconada
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmLaRinconada
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NameFarmLaRinconada
                             select far).FirstOrDefault();
                    
                    var lBombLaRinconada = new Bomb
                    {
                        Name = Utils.NameBombLaRinconada,
                        ShortName = Utils.NameBombLaRinconada,
                        SerialNumber = "111111111",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombLaRinconada);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb El Rincon
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElRincon)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmElRincon
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NamePositionFarmElRincon
                             select far).FirstOrDefault(); 
                    
                    var lBombElRincon = new Bomb
                    {
                        Name = Utils.NameBombElRincon,
                        ShortName = Utils.NameBombElRincon,
                        SerialNumber = "111111111",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombElRincon);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb El Desafio
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElDesafio)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmElDesafio
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NamePositionFarmElDesafio
                             select far).FirstOrDefault(); 

                    var lBombElDesafio = new Bomb
                    {
                        Name = Utils.NameBombElDesafio,
                        ShortName = Utils.NameBombElDesafio,
                        SerialNumber = "111111111",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombElDesafio);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb Los Naranjales
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LosNaranjales)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmLosNaranjales
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NamePositionFarmLosNaranjales
                             select far).FirstOrDefault(); 

                    var lBombLosNaranjales = new Bomb
                    {
                        Name = Utils.NameBombLosNaranjales,
                        ShortName = Utils.NameBombLosNaranjales,
                        SerialNumber = "111111111",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombLosNaranjales);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb Santa Emilia
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaEmilia)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmSantaEmilia
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NamePositionFarmSantaEmilia
                             select far).FirstOrDefault();

                    var lBombSantaEmilia = new Bomb
                    {
                        Name = Utils.NameBombSantaEmilia,
                        ShortName = Utils.NameBombSantaEmilia,
                        SerialNumber = "111111111",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombSantaEmilia);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb Gran Molino
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GranMolino)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmGranMolino
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NamePositionFarmGranMolino
                             select far).FirstOrDefault();

                    var lBombGranMolino = new Bomb
                    {
                        Name = Utils.NameBombGranMolino,
                        ShortName = Utils.NameBombGranMolino,
                        SerialNumber = "111111111",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombGranMolino);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb La Portuguesa
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPortuguesa)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmLaPortuguesa
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NamePositionFarmLaPortuguesa
                             select far).FirstOrDefault();

                    var lBombLaPortuguesa = new Bomb
                    {
                        Name = Utils.NameBombLaPortuguesa,
                        ShortName = Utils.NameBombLaPortuguesa,
                        SerialNumber = "111111111",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombLaPortuguesa);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb Cassarino - La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.CassarinoLaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmCassarinoLaPerdiz
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NamePositionFarmCassarinoLaPerdiz
                             select far).FirstOrDefault();

                    var lBombCassarinoLaPerdiz = new Bomb
                    {
                        Name = Utils.NameBombCassarinoLaPerdiz,
                        ShortName = Utils.NameBombCassarinoLaPerdiz,
                        SerialNumber = "111111111",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombCassarinoLaPerdiz);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb Santo Domingo
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantoDomingo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmSantoDomingo
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NamePositionFarmSantoDomingo
                             select far).FirstOrDefault();

                    var lBombSantoDomingo = new Bomb
                    {
                        Name = Utils.NameBombSantoDomingo,
                        ShortName = Utils.NameBombSantoDomingo,
                        SerialNumber = "111111111",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombSantoDomingo);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb Cecchini
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Cecchini)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmCecchini
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NamePositionFarmCecchini
                             select far).FirstOrDefault();

                    var lBombCecchini = new Bomb
                    {
                        Name = Utils.NameBombCecchini,
                        ShortName = Utils.NameBombCecchini,
                        SerialNumber = "111111111",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombCecchini);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb El Alba
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElAlba)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmElAlba
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NamePositionFarmElAlba
                             select far).FirstOrDefault();

                    var lBombElAlba = new Bomb
                    {
                        Name = Utils.NameBombElAlba,
                        ShortName = Utils.NameBombElAlba,
                        SerialNumber = "111111111",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombElAlba);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Bomb La Zenaida
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaZenaida)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmLaZenaida
                                 select pos).FirstOrDefault();

                    lFarm = (from far in context.Farms
                             where far.Name == Utils.NamePositionFarmLaZenaida
                             select far).FirstOrDefault();

                    var lBombLaZenaida = new Bomb
                    {
                        Name = Utils.NameBombLaZenaida,
                        ShortName = Utils.NameBombLaZenaida,
                        SerialNumber = "111111111",
                        PurchaseDate = Utils.MIN_DATETIME,
                        ServiceDate = Utils.MIN_DATETIME,
                        PositionId = lPosition.PositionId,
                        FarmId = lFarm.FarmId,
                    };
                    context.Bombs.Add(lBombLaZenaida);
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

        public static void InsertIrrigationUnits()
        {
            Bomb lBomb = null;
            Position lPosition = null;
            Farm lFarm = null;

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
                Show = false,
                FarmId = 0,
            };
            #endregion

            #region Pivots Demo1 - La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmDemo1
                             select f).FirstOrDefault();

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
                        Show = true,
                        FarmId = lFarm.FarmId
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
                        Show = true,
                        FarmId = lFarm.FarmId
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
                        Show = true,
                        FarmId = lFarm.FarmId
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
                        Show = true,
                        FarmId = lFarm.FarmId
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
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmDemo2
                             select f).FirstOrDefault();

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
                        Show = true,
                        FarmId = lFarm.FarmId
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
                        Show = true,
                        FarmId = lFarm.FarmId
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
                        Show = true,
                        FarmId = lFarm.FarmId
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
                        Show = true,
                        FarmId = lFarm.FarmId
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
                        Show = true,
                        FarmId = lFarm.FarmId
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
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmDemo3
                             select f).FirstOrDefault();

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
                        Show = true,
                        FarmId = lFarm.FarmId
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
                        Show = true,
                        FarmId = lFarm.FarmId
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
                        Show = true,
                        FarmId = lFarm.FarmId
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
                        Show = true,
                        FarmId = lFarm.FarmId
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
                        Show = true,
                        FarmId = lFarm.FarmId
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
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //|| Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmSantaLucia
                             select f).FirstOrDefault();

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
                        Show = false,
                        FarmId = lFarm.FarmId
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
                        Show = false,
                        FarmId = lFarm.FarmId
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
                        Show = false,
                        FarmId = lFarm.FarmId
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
                        Show = false,
                        FarmId = lFarm.FarmId
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
                        Show = false,
                        FarmId = lFarm.FarmId
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
            #region Pivots DCA El Paraiso
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

                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmDCAElParaiso
                             select f).FirstOrDefault();
                    #region Pivot 1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCAElParaiso
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCAElParaiso1
                                 select pos).FirstOrDefault();

                    var lDCAElParaisoPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotDCAElParaiso1,
                        ShortName = "Pivot 1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 69,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 35,
                        Show = false,
                        FarmId = lFarm.FarmId
                    };
                    #endregion
                    #region Pivot 2
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCAElParaiso
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCAElParaiso2
                                 select pos).FirstOrDefault();

                    var lDCAElParaisoPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotDCAElParaiso2,
                        ShortName = "Pivot 2",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 69,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 35,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 3
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCAElParaiso
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCAElParaiso3
                                 select pos).FirstOrDefault();

                    var lDCAElParaisoPivot3 = new Pivot
                    {
                        Name = Utils.NamePivotDCAElParaiso3,
                        ShortName = "Pivot 3",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 69,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 35,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 4
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCAElParaiso
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCAElParaiso4
                                 select pos).FirstOrDefault();

                    var lDCAElParaisoPivot4 = new Pivot
                    {
                        Name = Utils.NamePivotDCAElParaiso4,
                        ShortName = "Pivot 4",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 69,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 35,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 5
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCAElParaiso
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCAElParaiso5
                                 select pos).FirstOrDefault();

                    var lDCAElParaisoPivot5 = new Pivot
                    {
                        Name = Utils.NamePivotDCAElParaiso5,
                        ShortName = "Pivot 5",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 69,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 35,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 6
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCAElParaiso
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCAElParaiso6
                                 select pos).FirstOrDefault();

                    var lDCAElParaisoPivot6 = new Pivot
                    {
                        Name = Utils.NamePivotDCAElParaiso6,
                        ShortName = "Pivot 6",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 50,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 7
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCAElParaiso
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCAElParaiso7
                                 select pos).FirstOrDefault();

                    var lDCAElParaisoPivot7 = new Pivot
                    {
                        Name = Utils.NamePivotDCAElParaiso7,
                        ShortName = "Pivot 7",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 91,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 45,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017)
                    {
                        lDCAElParaisoPivot1.Show = true;
                        lDCAElParaisoPivot2.Show = true;
                        lDCAElParaisoPivot3.Show = false;
                        lDCAElParaisoPivot4.Show = false;
                        lDCAElParaisoPivot5.Show = false;
                        lDCAElParaisoPivot6.Show = false;
                        lDCAElParaisoPivot7.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lDCAElParaisoPivot1.Show = false;
                        lDCAElParaisoPivot2.Show = false;
                        lDCAElParaisoPivot3.Show = false;
                        lDCAElParaisoPivot4.Show = false;
                        lDCAElParaisoPivot5.Show = false;
                        lDCAElParaisoPivot6.Show = false;
                        lDCAElParaisoPivot7.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lDCAElParaisoPivot1.Show = false;
                        lDCAElParaisoPivot2.Show = true;
                        lDCAElParaisoPivot3.Show = true;
                        lDCAElParaisoPivot4.Show = true;
                        lDCAElParaisoPivot5.Show = false;
                        lDCAElParaisoPivot6.Show = false;
                        lDCAElParaisoPivot7.Show = false;
                    }
                    else 
                    {
                        lDCAElParaisoPivot1.Show = false;
                        lDCAElParaisoPivot2.Show = true;
                        lDCAElParaisoPivot3.Show = true;
                        lDCAElParaisoPivot4.Show = true;
                        lDCAElParaisoPivot5.Show = false;
                        lDCAElParaisoPivot6.Show = false;
                        lDCAElParaisoPivot7.Show = false;
                    }
                    #endregion

                    context.Pivots.Add(lDCAElParaisoPivot1);
                    context.Pivots.Add(lDCAElParaisoPivot2);
                    context.Pivots.Add(lDCAElParaisoPivot3);
                    context.Pivots.Add(lDCAElParaisoPivot4);
                    context.Pivots.Add(lDCAElParaisoPivot5);
                    context.Pivots.Add(lDCAElParaisoPivot6);
                    context.Pivots.Add(lDCAElParaisoPivot7);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots DCA La Perdiz
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
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmDCALaPerdiz
                             select f).FirstOrDefault();

                    #region Pivot 1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCALaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz1
                                 select pos).FirstOrDefault();

                    var lDCALaPerdizPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotDCALaPerdiz1,
                        ShortName = "Pivot 1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 141,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 70,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCALaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz2
                                 select pos).FirstOrDefault();

                    var lDCALaPerdizPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotDCALaPerdiz2,
                        ShortName = "Pivot 2",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 137,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 68,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 3
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCALaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz3
                                 select pos).FirstOrDefault();

                    var lDCALaPerdizPivot3 = new Pivot
                    {
                        Name = Utils.NamePivotDCALaPerdiz3,
                        ShortName = "Pivot 3",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 120,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 60,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 4
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCALaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz4
                                 select pos).FirstOrDefault();

                    var lDCALaPerdizPivot4 = new Pivot
                    {
                        Name = Utils.NamePivotDCALaPerdiz4,
                        ShortName = "Pivot 4",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 154,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 77,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 5
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCALaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz5
                                 select pos).FirstOrDefault();

                    var lDCALaPerdizPivot5 = new Pivot
                    {
                        Name = Utils.NamePivotDCALaPerdiz5,
                        ShortName = "Pivot 5",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 154,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 77,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 6
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCALaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz6
                                 select pos).FirstOrDefault();

                    var lDCALaPerdizPivot6 = new Pivot
                    {
                        Name = Utils.NamePivotDCALaPerdiz6,
                        ShortName = "Pivot 6",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 128.3,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 64,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 7
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCALaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz7
                                 select pos).FirstOrDefault();

                    var lDCALaPerdizPivot7 = new Pivot
                    {
                        Name = Utils.NamePivotDCALaPerdiz7,
                        ShortName = "Pivot 7",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 90.3,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 45,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 8
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCALaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz8
                                 select pos).FirstOrDefault();

                    var lDCALaPerdizPivot8 = new Pivot
                    {
                        Name = Utils.NamePivotDCALaPerdiz8,
                        ShortName = "Pivot 8",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 50,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 9
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCALaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz9
                                 select pos).FirstOrDefault();

                    var lDCALaPerdizPivot9 = new Pivot
                    {
                        Name = Utils.NamePivotDCALaPerdiz9,
                        ShortName = "Pivot 9",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 50,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 10a
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCALaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz10a
                                 select pos).FirstOrDefault();

                    var lDCALaPerdizPivot10a = new Pivot
                    {
                        Name = Utils.NamePivotDCALaPerdiz10a,
                        ShortName = "Pivot 10a",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 82.4,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 41,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 10b
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCALaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz10b
                                 select pos).FirstOrDefault();

                    var lDCALaPerdizPivot10b = new Pivot
                    {
                        Name = Utils.NamePivotDCALaPerdiz10b,
                        ShortName = "Pivot 10b",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 82.4,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 41,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 11
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCALaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz11
                                 select pos).FirstOrDefault();

                    var lDCALaPerdizPivot11 = new Pivot
                    {
                        Name = Utils.NamePivotDCALaPerdiz11,
                        ShortName = "Pivot 11",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 129,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 65,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 12
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCALaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz12
                                 select pos).FirstOrDefault();

                    var lDCALaPerdizPivot12 = new Pivot
                    {
                        Name = Utils.NamePivotDCALaPerdiz12,
                        ShortName = "Pivot 12",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 50,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 13
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCALaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz13
                                 select pos).FirstOrDefault();

                    var lDCALaPerdizPivot13 = new Pivot
                    {
                        Name = Utils.NamePivotDCALaPerdiz13,
                        ShortName = "Pivot 13",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 50,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 14
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCALaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz14
                                 select pos).FirstOrDefault();

                    var lDCALaPerdizPivot14 = new Pivot
                    {
                        Name = Utils.NamePivotDCALaPerdiz14,
                        ShortName = "Pivot 14",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 73.8,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 37,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 15
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCALaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCALaPerdiz15
                                 select pos).FirstOrDefault();

                    var lDCALaPerdizPivot15 = new Pivot
                    {
                        Name = Utils.NamePivotDCALaPerdiz15,
                        ShortName = "Pivot 15",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100.6,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 50,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017)
                    {
                        lDCALaPerdizPivot1.Show = false;
                        lDCALaPerdizPivot2.Show = true;
                        lDCALaPerdizPivot3.Show = true;
                        lDCALaPerdizPivot4.Show = false;
                        lDCALaPerdizPivot5.Show = true;
                        lDCALaPerdizPivot6.Show = false;
                        lDCALaPerdizPivot7.Show = true;
                        lDCALaPerdizPivot8.Show = false;
                        lDCALaPerdizPivot9.Show = false;
                        lDCALaPerdizPivot10a.Show = false;
                        lDCALaPerdizPivot10b.Show = false;
                        lDCALaPerdizPivot11.Show = false;
                        lDCALaPerdizPivot12.Show = false;
                        lDCALaPerdizPivot13.Show = false;
                        lDCALaPerdizPivot14.Show = true;
                        lDCALaPerdizPivot15.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lDCALaPerdizPivot1.Show = false;
                        lDCALaPerdizPivot2.Show = true;
                        lDCALaPerdizPivot3.Show = true;
                        lDCALaPerdizPivot4.Show = false;
                        lDCALaPerdizPivot5.Show = true;
                        lDCALaPerdizPivot6.Show = false;
                        lDCALaPerdizPivot7.Show = true;
                        lDCALaPerdizPivot8.Show = false;
                        lDCALaPerdizPivot9.Show = false;
                        lDCALaPerdizPivot10a.Show = false;
                        lDCALaPerdizPivot10b.Show = false;
                        lDCALaPerdizPivot11.Show = false;
                        lDCALaPerdizPivot12.Show = false;
                        lDCALaPerdizPivot13.Show = false;
                        lDCALaPerdizPivot14.Show = true;
                        lDCALaPerdizPivot15.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lDCALaPerdizPivot1.Show = true;
                        lDCALaPerdizPivot2.Show = false;
                        lDCALaPerdizPivot3.Show = false;
                        lDCALaPerdizPivot4.Show = false;
                        lDCALaPerdizPivot5.Show = false;
                        lDCALaPerdizPivot6.Show = true;
                        lDCALaPerdizPivot7.Show = true;
                        lDCALaPerdizPivot8.Show = false;
                        lDCALaPerdizPivot9.Show = false;
                        lDCALaPerdizPivot10a.Show = true;
                        lDCALaPerdizPivot10b.Show = false;
                        lDCALaPerdizPivot11.Show = false;
                        lDCALaPerdizPivot12.Show = false;
                        lDCALaPerdizPivot13.Show = false;
                        lDCALaPerdizPivot14.Show = true;
                        lDCALaPerdizPivot15.Show = true;
                    }
                    else 
                    {
                        lDCALaPerdizPivot1.Show = true;
                        lDCALaPerdizPivot2.Show = false;
                        lDCALaPerdizPivot3.Show = false;
                        lDCALaPerdizPivot4.Show = false;
                        lDCALaPerdizPivot5.Show = false;
                        lDCALaPerdizPivot6.Show = true;
                        lDCALaPerdizPivot7.Show = true;
                        lDCALaPerdizPivot8.Show = false;
                        lDCALaPerdizPivot9.Show = false;
                        lDCALaPerdizPivot10a.Show = true;
                        lDCALaPerdizPivot10b.Show = false;
                        lDCALaPerdizPivot11.Show = false;
                        lDCALaPerdizPivot12.Show = false;
                        lDCALaPerdizPivot13.Show = false;
                        lDCALaPerdizPivot14.Show = true;
                        lDCALaPerdizPivot15.Show = true;
                    }
                    #endregion

                    context.Pivots.Add(lDCALaPerdizPivot1);
                    context.Pivots.Add(lDCALaPerdizPivot2);
                    context.Pivots.Add(lDCALaPerdizPivot3);
                    context.Pivots.Add(lDCALaPerdizPivot4);
                    context.Pivots.Add(lDCALaPerdizPivot5);
                    context.Pivots.Add(lDCALaPerdizPivot6);
                    context.Pivots.Add(lDCALaPerdizPivot7);
                    context.Pivots.Add(lDCALaPerdizPivot8);
                    context.Pivots.Add(lDCALaPerdizPivot9);
                    context.Pivots.Add(lDCALaPerdizPivot10a);
                    context.Pivots.Add(lDCALaPerdizPivot10b);
                    context.Pivots.Add(lDCALaPerdizPivot11);
                    context.Pivots.Add(lDCALaPerdizPivot12);
                    context.Pivots.Add(lDCALaPerdizPivot13);
                    context.Pivots.Add(lDCALaPerdizPivot14);
                    context.Pivots.Add(lDCALaPerdizPivot15);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots DCA San Jose
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmDCASanJose
                             select f).FirstOrDefault();

                    #region Pivot 1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCASanJose
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCASanJose1
                                 select pos).FirstOrDefault();

                    var lDCASanJosePivot1 = new Pivot
                    {
                        Name = Utils.NamePivotDCASanJose1,
                        ShortName = "Pivot 01",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 64.4,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 32,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCASanJose
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCASanJose2
                                 select pos).FirstOrDefault();

                    var lDCASanJosePivot2 = new Pivot
                    {
                        Name = Utils.NamePivotDCASanJose2,
                        ShortName = "Pivot 02",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 64.4,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 32,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 3
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCASanJose
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCASanJose3
                                 select pos).FirstOrDefault();

                    var lDCASanJosePivot3 = new Pivot
                    {
                        Name = Utils.NamePivotDCASanJose3,
                        ShortName = "Pivot 03",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 64.4,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 32,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 4
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDCASanJose
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDCASanJose4
                                 select pos).FirstOrDefault();

                    var lDCASanJosePivot4 = new Pivot
                    {
                        Name = Utils.NamePivotDCASanJose4,
                        ShortName = "Pivot 04",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 137,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 68,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017)
                    {
                        lDCASanJosePivot1.Show = false;
                        lDCASanJosePivot2.Show = true;
                        lDCASanJosePivot3.Show = true;
                        lDCASanJosePivot4.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lDCASanJosePivot1.Show = true;
                        lDCASanJosePivot2.Show = false;
                        lDCASanJosePivot3.Show = false;
                        lDCASanJosePivot4.Show = true;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lDCASanJosePivot1.Show = false;
                        lDCASanJosePivot2.Show = true;
                        lDCASanJosePivot3.Show = true;
                        lDCASanJosePivot4.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020)
                    {
                        lDCASanJosePivot1.Show = true;
                        lDCASanJosePivot2.Show = true;
                        lDCASanJosePivot3.Show = true;
                        lDCASanJosePivot4.Show = true;
                    }
                    else
                    {
                        lDCASanJosePivot1.Show = true;
                        lDCASanJosePivot2.Show = true;
                        lDCASanJosePivot3.Show = true;
                        lDCASanJosePivot4.Show = true;
                    }
                    #endregion

                    context.Pivots.Add(lDCASanJosePivot1);
                    context.Pivots.Add(lDCASanJosePivot2);
                    context.Pivots.Add(lDCASanJosePivot3);
                    context.Pivots.Add(lDCASanJosePivot4);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots Del Lago - San Pedro
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
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmDelLagoSanPedro
                             select f).FirstOrDefault();

                    #region Pivot 1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro1
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro1,
                        ShortName = "Pivot 1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 118,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 59,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro2
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro2,
                        ShortName = "Pivot 2",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 118,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 59,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 3
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro3
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot3 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro3,
                        ShortName = "Pivot 3",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 118,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 59,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 4
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro4
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot4 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro4,
                        ShortName = "Pivot 4",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 118,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 59,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
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
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 118,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 59,
                        Show = true,
                        FarmId = lFarm.FarmId,
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
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 60,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
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
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 110,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 55,
                        Show = true,
                        FarmId = lFarm.FarmId,
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
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 32,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 16,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 9
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro9
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot9 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro9,
                        ShortName = "Pivot 9",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 118,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 59,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 10
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro10
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot10 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro10,
                        ShortName = "Pivot 10",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 118,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 59,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 11
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro11
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot11 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro11,
                        ShortName = "Pivot 11",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 118,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 59,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 12
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro12
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot12 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro12,
                        ShortName = "Pivot 12",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 118,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 59,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 13
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro13
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot13 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro13,
                        ShortName = "Pivot 13",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 118,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 59,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 14
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro14
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot14 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro14,
                        ShortName = "Pivot 14",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 118,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 59,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 15
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro15
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot15 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro15,
                        ShortName = "Pivot 15",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 118,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 59,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 16
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro16
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot16 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro16,
                        ShortName = "Pivot 16",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 118,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 59,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 17
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoSanPedro
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoSanPedro17
                                 select pos).FirstOrDefault();

                    var lDelLagoSanPedroPivot17 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoSanPedro17,
                        ShortName = "Pivot 17",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 118,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 59,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017)
                    {
                        lDelLagoSanPedroPivot1.Show = false;
                        lDelLagoSanPedroPivot2.Show = false;
                        lDelLagoSanPedroPivot3.Show = false;
                        lDelLagoSanPedroPivot4.Show = false;
                        lDelLagoSanPedroPivot5.Show = false;
                        lDelLagoSanPedroPivot6.Show = false;
                        lDelLagoSanPedroPivot7.Show = false;
                        lDelLagoSanPedroPivot8.Show = false;
                        lDelLagoSanPedroPivot9.Show = false;
                        lDelLagoSanPedroPivot10.Show = false;
                        lDelLagoSanPedroPivot11.Show = false;
                        lDelLagoSanPedroPivot12.Show = false;
                        lDelLagoSanPedroPivot13.Show = false;
                        lDelLagoSanPedroPivot14.Show = false;
                        lDelLagoSanPedroPivot15.Show = false;
                        lDelLagoSanPedroPivot16.Show = false;
                        lDelLagoSanPedroPivot17.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lDelLagoSanPedroPivot1.Show = false;
                        lDelLagoSanPedroPivot2.Show = false;
                        lDelLagoSanPedroPivot3.Show = false;
                        lDelLagoSanPedroPivot4.Show = false;
                        lDelLagoSanPedroPivot5.Show = true;
                        lDelLagoSanPedroPivot6.Show = true;
                        lDelLagoSanPedroPivot7.Show = true;
                        lDelLagoSanPedroPivot8.Show = true;
                        lDelLagoSanPedroPivot9.Show = false;
                        lDelLagoSanPedroPivot10.Show = false;
                        lDelLagoSanPedroPivot11.Show = false;
                        lDelLagoSanPedroPivot12.Show = false;
                        lDelLagoSanPedroPivot13.Show = false;
                        lDelLagoSanPedroPivot14.Show = false;
                        lDelLagoSanPedroPivot15.Show = false;
                        lDelLagoSanPedroPivot16.Show = false;
                        lDelLagoSanPedroPivot17.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lDelLagoSanPedroPivot1.Show = false;
                        lDelLagoSanPedroPivot2.Show = false;
                        lDelLagoSanPedroPivot3.Show = false;
                        lDelLagoSanPedroPivot4.Show = false;
                        lDelLagoSanPedroPivot5.Show = false;
                        lDelLagoSanPedroPivot6.Show = false;
                        lDelLagoSanPedroPivot7.Show = false;
                        lDelLagoSanPedroPivot8.Show = false;
                        lDelLagoSanPedroPivot9.Show = false;
                        lDelLagoSanPedroPivot10.Show = false;
                        lDelLagoSanPedroPivot11.Show = false;
                        lDelLagoSanPedroPivot12.Show = false;
                        lDelLagoSanPedroPivot13.Show = false;
                        lDelLagoSanPedroPivot14.Show = false;
                        lDelLagoSanPedroPivot15.Show = false;
                        lDelLagoSanPedroPivot16.Show = false;
                        lDelLagoSanPedroPivot17.Show = false;
                    }
                    else 
                    {
                        lDelLagoSanPedroPivot1.Show = false;
                        lDelLagoSanPedroPivot2.Show = false;
                        lDelLagoSanPedroPivot3.Show = false;
                        lDelLagoSanPedroPivot4.Show = false;
                        lDelLagoSanPedroPivot5.Show = false;
                        lDelLagoSanPedroPivot6.Show = false;
                        lDelLagoSanPedroPivot7.Show = false;
                        lDelLagoSanPedroPivot8.Show = false;
                        lDelLagoSanPedroPivot9.Show = false;
                        lDelLagoSanPedroPivot10.Show = false;
                        lDelLagoSanPedroPivot11.Show = false;
                        lDelLagoSanPedroPivot12.Show = false;
                        lDelLagoSanPedroPivot13.Show = false;
                        lDelLagoSanPedroPivot14.Show = false;
                        lDelLagoSanPedroPivot15.Show = false;
                        lDelLagoSanPedroPivot16.Show = false;
                        lDelLagoSanPedroPivot17.Show = false;
                    }
                    #endregion

                    context.Pivots.Add(lDelLagoSanPedroPivot1);
                    context.Pivots.Add(lDelLagoSanPedroPivot2);
                    context.Pivots.Add(lDelLagoSanPedroPivot3);
                    context.Pivots.Add(lDelLagoSanPedroPivot4);
                    context.Pivots.Add(lDelLagoSanPedroPivot5);
                    context.Pivots.Add(lDelLagoSanPedroPivot6);
                    context.Pivots.Add(lDelLagoSanPedroPivot7);
                    context.Pivots.Add(lDelLagoSanPedroPivot8);
                    context.Pivots.Add(lDelLagoSanPedroPivot9);
                    context.Pivots.Add(lDelLagoSanPedroPivot10);
                    context.Pivots.Add(lDelLagoSanPedroPivot11);
                    context.Pivots.Add(lDelLagoSanPedroPivot12);
                    context.Pivots.Add(lDelLagoSanPedroPivot13);
                    context.Pivots.Add(lDelLagoSanPedroPivot14);
                    context.Pivots.Add(lDelLagoSanPedroPivot15);
                    context.Pivots.Add(lDelLagoSanPedroPivot16);
                    context.Pivots.Add(lDelLagoSanPedroPivot17);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots Del Lago - El Mirador
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
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmDelLagoElMirador
                             select f).FirstOrDefault();

                    #region Pivot 01
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador1
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador1,
                        ShortName = "Pivot 01",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 38.36,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 02
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador2
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador2,
                        ShortName = "Pivot 02",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 54.31,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 03
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador3
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot3 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador3,
                        ShortName = "Pivot 03",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 47.69,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 04
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador4
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot4 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador4,
                        ShortName = "Pivot 04",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 62.07,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 05
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador5
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot5 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador5,
                        ShortName = "Pivot 05",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 63.62,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 06
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador6
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot6 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador6,
                        ShortName = "Pivot 06",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 57.28,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 07
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador7
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot7 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador7,
                        ShortName = "Pivot 07",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 55.82,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 08
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador8
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot8 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador8,
                        ShortName = "Pivot 08",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 67.9,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 09
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador9
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot9 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador9,
                        ShortName = "Pivot 09",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 57.28,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 10
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador10
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot10 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador10,
                        ShortName = "Pivot 10",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 83.75,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 11
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador11
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot11 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador11,
                        ShortName = "Pivot 11",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 96.41,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 12
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador12
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot12 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador12,
                        ShortName = "Pivot 12",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 50.48,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 13
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador13
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot13 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador13,
                        ShortName = "Pivot 13",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 79.24,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 14
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador14
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot14 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador14,
                        ShortName = "Pivot 14",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 40.15,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 15
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador15
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot15 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador15,
                        ShortName = "Pivot 15",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 101.58,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot Chaja 01
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMiradorChaja1
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivotChaja1 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMiradorChaja1,
                        ShortName = "Chaja 01",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 79.35,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot Chaja 02
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMiradorChaja2
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivotChaja2 = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMiradorChaja2,
                        ShortName = "Chaja 02",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 94.44,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot 01b
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador1b
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot1b = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador1b,
                        ShortName = "Pivot 01",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 38.36,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 02b
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador2b
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot2b = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador2b,
                        ShortName = "Pivot 02",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 54.31,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 03b
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador3b
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot3b = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador3b,
                        ShortName = "Pivot 03",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 47.69,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 04b
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombDelLagoElMirador
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotDelLagoElMirador4b
                                 select pos).FirstOrDefault();

                    var lDelLagoElMiradorPivot4b = new Pivot
                    {
                        Name = Utils.NamePivotDelLagoElMirador4b,
                        ShortName = "Pivot 04",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 62.07,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 30,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017)
                    {
                        lDelLagoElMiradorPivot1.Show = true;
                        lDelLagoElMiradorPivot2.Show = true;
                        lDelLagoElMiradorPivot3.Show = true;
                        lDelLagoElMiradorPivot4.Show = true;
                        lDelLagoElMiradorPivot5.Show = true;
                        lDelLagoElMiradorPivot6.Show = true;
                        lDelLagoElMiradorPivot7.Show = true;
                        lDelLagoElMiradorPivot8.Show = true;
                        lDelLagoElMiradorPivot9.Show = true;
                        lDelLagoElMiradorPivot10.Show = true;
                        lDelLagoElMiradorPivot11.Show = true;
                        lDelLagoElMiradorPivot12.Show = true;
                        lDelLagoElMiradorPivot13.Show = true;
                        lDelLagoElMiradorPivot14.Show = true;
                        lDelLagoElMiradorPivot15.Show = true;
                        lDelLagoElMiradorPivotChaja1.Show = true;
                        lDelLagoElMiradorPivotChaja2.Show = true;
                        lDelLagoElMiradorPivot1b.Show = true;
                        lDelLagoElMiradorPivot2b.Show = true;
                        lDelLagoElMiradorPivot3b.Show = true;
                        lDelLagoElMiradorPivot4b.Show = true;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lDelLagoElMiradorPivot1.Show = true;
                        lDelLagoElMiradorPivot2.Show = true;
                        lDelLagoElMiradorPivot3.Show = true;
                        lDelLagoElMiradorPivot4.Show = true;
                        lDelLagoElMiradorPivot5.Show = true;
                        lDelLagoElMiradorPivot6.Show = true;
                        lDelLagoElMiradorPivot7.Show = false;
                        lDelLagoElMiradorPivot8.Show = true;
                        lDelLagoElMiradorPivot9.Show = true;
                        lDelLagoElMiradorPivot10.Show = true;
                        lDelLagoElMiradorPivot11.Show = true;
                        lDelLagoElMiradorPivot12.Show = true;
                        lDelLagoElMiradorPivot13.Show = true;
                        lDelLagoElMiradorPivot14.Show = true;
                        lDelLagoElMiradorPivot15.Show = true;
                        lDelLagoElMiradorPivotChaja1.Show = true;
                        lDelLagoElMiradorPivotChaja2.Show = true;
                        lDelLagoElMiradorPivot1b.Show = false;
                        lDelLagoElMiradorPivot2b.Show = false;
                        lDelLagoElMiradorPivot3b.Show = false;
                        lDelLagoElMiradorPivot4b.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lDelLagoElMiradorPivot1.Show = false;
                        lDelLagoElMiradorPivot2.Show = false;
                        lDelLagoElMiradorPivot3.Show = false;
                        lDelLagoElMiradorPivot4.Show = false;
                        lDelLagoElMiradorPivot5.Show = false;
                        lDelLagoElMiradorPivot6.Show = false;
                        lDelLagoElMiradorPivot7.Show = false;
                        lDelLagoElMiradorPivot8.Show = false;
                        lDelLagoElMiradorPivot9.Show = false;
                        lDelLagoElMiradorPivot10.Show = false;
                        lDelLagoElMiradorPivot11.Show = false;
                        lDelLagoElMiradorPivot12.Show = false;
                        lDelLagoElMiradorPivot13.Show = false;
                        lDelLagoElMiradorPivot14.Show = false;
                        lDelLagoElMiradorPivot15.Show = false;
                        lDelLagoElMiradorPivotChaja1.Show = false;
                        lDelLagoElMiradorPivotChaja2.Show = false;
                        lDelLagoElMiradorPivot1b.Show = false;
                        lDelLagoElMiradorPivot2b.Show = false;
                        lDelLagoElMiradorPivot3b.Show = false;
                        lDelLagoElMiradorPivot4b.Show = false;
                    }
                    else 
                    {
                        lDelLagoElMiradorPivot1.Show = false;
                        lDelLagoElMiradorPivot2.Show = false;
                        lDelLagoElMiradorPivot3.Show = false;
                        lDelLagoElMiradorPivot4.Show = false;
                        lDelLagoElMiradorPivot5.Show = false;
                        lDelLagoElMiradorPivot6.Show = false;
                        lDelLagoElMiradorPivot7.Show = false;
                        lDelLagoElMiradorPivot8.Show = false;
                        lDelLagoElMiradorPivot9.Show = false;
                        lDelLagoElMiradorPivot10.Show = false;
                        lDelLagoElMiradorPivot11.Show = false;
                        lDelLagoElMiradorPivot12.Show = false;
                        lDelLagoElMiradorPivot13.Show = false;
                        lDelLagoElMiradorPivot14.Show = false;
                        lDelLagoElMiradorPivot15.Show = false;
                        lDelLagoElMiradorPivotChaja1.Show = false;
                        lDelLagoElMiradorPivotChaja2.Show = false;
                        lDelLagoElMiradorPivot1b.Show = false;
                        lDelLagoElMiradorPivot2b.Show = false;
                        lDelLagoElMiradorPivot3b.Show = false;
                        lDelLagoElMiradorPivot4b.Show = false;
                    }
                    #endregion

                    context.Pivots.Add(lDelLagoElMiradorPivot1);
                    context.Pivots.Add(lDelLagoElMiradorPivot2);
                    context.Pivots.Add(lDelLagoElMiradorPivot3);
                    context.Pivots.Add(lDelLagoElMiradorPivot4);
                    context.Pivots.Add(lDelLagoElMiradorPivot5);
                    context.Pivots.Add(lDelLagoElMiradorPivot6);
                    context.Pivots.Add(lDelLagoElMiradorPivot7);
                    context.Pivots.Add(lDelLagoElMiradorPivot8);
                    context.Pivots.Add(lDelLagoElMiradorPivot9);
                    context.Pivots.Add(lDelLagoElMiradorPivot10);
                    context.Pivots.Add(lDelLagoElMiradorPivot11);
                    context.Pivots.Add(lDelLagoElMiradorPivot12);
                    context.Pivots.Add(lDelLagoElMiradorPivot13);
                    context.Pivots.Add(lDelLagoElMiradorPivot14);
                    context.Pivots.Add(lDelLagoElMiradorPivot15);
                    context.Pivots.Add(lDelLagoElMiradorPivotChaja1);
                    context.Pivots.Add(lDelLagoElMiradorPivotChaja2);

                    context.Pivots.Add(lDelLagoElMiradorPivot1b);
                    context.Pivots.Add(lDelLagoElMiradorPivot2b);
                    context.Pivots.Add(lDelLagoElMiradorPivot3b);
                    context.Pivots.Add(lDelLagoElMiradorPivot4b);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots GMO - LaPalma
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
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmGMOLaPalma
                             select f).FirstOrDefault();

                    #region Pivot 1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOLaPalma
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma1
                                 select pos).FirstOrDefault();

                    var lGMOLaPalmaPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotGMOLaPalma1,
                        ShortName = "Pivot 01",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 50,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 25,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOLaPalma
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma2
                                 select pos).FirstOrDefault();

                    var lGMOLaPalmaPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotGMOLaPalma2,
                        ShortName = "Pivot 02",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 56,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 28,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 3
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOLaPalma
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma3
                                 select pos).FirstOrDefault();

                    var lGMOLaPalmaPivot3 = new Pivot
                    {
                        Name = Utils.NamePivotGMOLaPalma3,
                        ShortName = "Pivot 03",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 54,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 27,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 4
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOLaPalma
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma4
                                 select pos).FirstOrDefault();

                    var lGMOLaPalmaPivot4 = new Pivot
                    {
                        Name = Utils.NamePivotGMOLaPalma4,
                        ShortName = "Pivot 04",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 24,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 12,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 5
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOLaPalma
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma5
                                 select pos).FirstOrDefault();

                    var lGMOLaPalmaPivot5 = new Pivot
                    {
                        Name = Utils.NamePivotGMOLaPalma5,
                        ShortName = "Pivot 05",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 50,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 1.1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOLaPalma
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma1_1
                                 select pos).FirstOrDefault();

                    var lGMOLaPalmaPivot1_1 = new Pivot
                    {
                        Name = Utils.NamePivotGMOLaPalma1_1,
                        ShortName = "Pivot 1.1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 46,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 23,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2.1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOLaPalma
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma2_1
                                 select pos).FirstOrDefault();

                    var lGMOLaPalmaPivot2_1 = new Pivot
                    {
                        Name = Utils.NamePivotGMOLaPalma2_1,
                        ShortName = "Pivot 2.1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 59,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 29,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 3.1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOLaPalma
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma3_1
                                 select pos).FirstOrDefault();

                    var lGMOLaPalmaPivot3_1 = new Pivot
                    {
                        Name = Utils.NamePivotGMOLaPalma3_1,
                        ShortName = "Pivot 3.1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 55,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 27,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 4.1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOLaPalma
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOLaPalma4_1
                                 select pos).FirstOrDefault();

                    var lGMOLaPalmaPivot4_1 = new Pivot
                    {
                        Name = Utils.NamePivotGMOLaPalma4_1,
                        ShortName = "Pivot 4.1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 28,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 14,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017)
                    {
                        lGMOLaPalmaPivot1.Show = false;
                        lGMOLaPalmaPivot2.Show = false;
                        lGMOLaPalmaPivot3.Show = false;
                        lGMOLaPalmaPivot4.Show = false;
                        lGMOLaPalmaPivot5.Show = false;
                        lGMOLaPalmaPivot1_1.Show = false;
                        lGMOLaPalmaPivot2_1.Show = false;
                        lGMOLaPalmaPivot3_1.Show = false;
                        lGMOLaPalmaPivot4_1.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lGMOLaPalmaPivot1.Show = true;
                        lGMOLaPalmaPivot2.Show = true;
                        lGMOLaPalmaPivot3.Show = true;
                        lGMOLaPalmaPivot4.Show = true;
                        lGMOLaPalmaPivot5.Show = false;
                        lGMOLaPalmaPivot1_1.Show = true;
                        lGMOLaPalmaPivot2_1.Show = true;
                        lGMOLaPalmaPivot3_1.Show = true;
                        lGMOLaPalmaPivot4_1.Show = true;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lGMOLaPalmaPivot1.Show = false;
                        lGMOLaPalmaPivot2.Show = false;
                        lGMOLaPalmaPivot3.Show = false;
                        lGMOLaPalmaPivot4.Show = false;
                        lGMOLaPalmaPivot5.Show = false;
                        lGMOLaPalmaPivot1_1.Show = false;
                        lGMOLaPalmaPivot2_1.Show = false;
                        lGMOLaPalmaPivot3_1.Show = false;
                        lGMOLaPalmaPivot4_1.Show = false;
                    }
                    else 
                    {
                        lGMOLaPalmaPivot1.Show = false;
                        lGMOLaPalmaPivot2.Show = false;
                        lGMOLaPalmaPivot3.Show = false;
                        lGMOLaPalmaPivot4.Show = false;
                        lGMOLaPalmaPivot5.Show = false;
                        lGMOLaPalmaPivot1_1.Show = false;
                        lGMOLaPalmaPivot2_1.Show = false;
                        lGMOLaPalmaPivot3_1.Show = false;
                        lGMOLaPalmaPivot4_1.Show = false;
                    }
                    #endregion

                    context.Pivots.Add(lGMOLaPalmaPivot1);
                    context.Pivots.Add(lGMOLaPalmaPivot2);
                    context.Pivots.Add(lGMOLaPalmaPivot3);
                    context.Pivots.Add(lGMOLaPalmaPivot4);
                    context.Pivots.Add(lGMOLaPalmaPivot5);
                    context.Pivots.Add(lGMOLaPalmaPivot1_1);
                    context.Pivots.Add(lGMOLaPalmaPivot2_1);
                    context.Pivots.Add(lGMOLaPalmaPivot3_1);
                    context.Pivots.Add(lGMOLaPalmaPivot4_1);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots GMO - ElTacuru
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
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmGMOElTacuru
                             select f).FirstOrDefault();

                    #region Pivot 1a
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOElTacuru
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru1a
                                 select pos).FirstOrDefault();

                    var lGMOElTacuruPivot1a = new Pivot
                    {
                        Name = Utils.NamePivotGMOElTacuru1a,
                        ShortName = "Pivot 1a",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 55,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 27,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 1b
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOElTacuru
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru1b
                                 select pos).FirstOrDefault();

                    var lGMOElTacuruPivot1b = new Pivot
                    {
                        Name = Utils.NamePivotGMOElTacuru1b,
                        ShortName = "Pivot 1b",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 55,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 27,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2a
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOElTacuru
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru2a
                                 select pos).FirstOrDefault();

                    var lGMOElTacuruPivot2a = new Pivot
                    {
                        Name = Utils.NamePivotGMOElTacuru2a,
                        ShortName = "Pivot 2a",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 60.4,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2b
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOElTacuru
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru2b
                                 select pos).FirstOrDefault();

                    var lGMOElTacuruPivot2b = new Pivot
                    {
                        Name = Utils.NamePivotGMOElTacuru2b,
                        ShortName = "Pivot 2b",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 80,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 40,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 3a
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOElTacuru
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru3a
                                 select pos).FirstOrDefault();

                    var lGMOElTacuruPivot3a = new Pivot
                    {
                        Name = Utils.NamePivotGMOElTacuru3a,
                        ShortName = "Pivot 3a",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 60.4,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 30,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 3b
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOElTacuru
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru3b
                                 select pos).FirstOrDefault();

                    var lGMOElTacuruPivot3b = new Pivot
                    {
                        Name = Utils.NamePivotGMOElTacuru3b,
                        ShortName = "Pivot 3b",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 59,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 29,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 4
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOElTacuru
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru4
                                 select pos).FirstOrDefault();

                    var lGMOElTacuruPivot4 = new Pivot
                    {
                        Name = Utils.NamePivotGMOElTacuru4,
                        ShortName = "Pivot 04",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 71,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 12,
                        Radius = 36,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 5
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOElTacuru
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru5
                                 select pos).FirstOrDefault();

                    var lGMOElTacuruPivot5 = new Pivot
                    {
                        Name = Utils.NamePivotGMOElTacuru5,
                        ShortName = "Pivot 05",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 50,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 25,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 6
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOElTacuru
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru6
                                 select pos).FirstOrDefault();

                    var lGMOElTacuruPivot6 = new Pivot
                    {
                        Name = Utils.NamePivotGMOElTacuru6,
                        ShortName = "Pivot 06",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 60,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 30,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 7
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOElTacuru
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru7
                                 select pos).FirstOrDefault();

                    var lGMOElTacuruPivot7 = new Pivot
                    {
                        Name = Utils.NamePivotGMOElTacuru7,
                        ShortName = "Pivot 07",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 50,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 8
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOElTacuru
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru8
                                 select pos).FirstOrDefault();

                    var lGMOElTacuruPivot8 = new Pivot
                    {
                        Name = Utils.NamePivotGMOElTacuru8,
                        ShortName = "Pivot 08",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 85.6,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 43,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 9
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOElTacuru
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru9
                                 select pos).FirstOrDefault();

                    var lGMOElTacuruPivot9 = new Pivot
                    {
                        Name = Utils.NamePivotGMOElTacuru9,
                        ShortName = "Pivot 09",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 83,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 42,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 10
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGMOElTacuru
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGMOElTacuru10
                                 select pos).FirstOrDefault();

                    var lGMOElTacuruPivot10 = new Pivot
                    {
                        Name = Utils.NamePivotGMOElTacuru10,
                        ShortName = "Pivot 10",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 55,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 27,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017)
                    {
                        lGMOElTacuruPivot1a.Show = false;
                        lGMOElTacuruPivot1b.Show = true;
                        lGMOElTacuruPivot2a.Show = false;
                        lGMOElTacuruPivot2b.Show = true;
                        lGMOElTacuruPivot3a.Show = false;
                        lGMOElTacuruPivot3b.Show = true;
                        lGMOElTacuruPivot4.Show = false;
                        lGMOElTacuruPivot5.Show = true;
                        lGMOElTacuruPivot6.Show = false;
                        lGMOElTacuruPivot7.Show = false;
                        lGMOElTacuruPivot8.Show = true;
                        lGMOElTacuruPivot9.Show = true;
                        lGMOElTacuruPivot10.Show = true;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lGMOElTacuruPivot1a.Show = true;
                        lGMOElTacuruPivot1b.Show = true;
                        lGMOElTacuruPivot2a.Show = true;
                        lGMOElTacuruPivot2b.Show = true;
                        lGMOElTacuruPivot3a.Show = true;
                        lGMOElTacuruPivot3b.Show = true;
                        lGMOElTacuruPivot4.Show = true;
                        lGMOElTacuruPivot5.Show = true;
                        lGMOElTacuruPivot6.Show = false;
                        lGMOElTacuruPivot7.Show = false;
                        lGMOElTacuruPivot8.Show = true;
                        lGMOElTacuruPivot9.Show = true;
                        lGMOElTacuruPivot10.Show = true;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lGMOElTacuruPivot1a.Show = false;
                        lGMOElTacuruPivot1b.Show = false;
                        lGMOElTacuruPivot2a.Show = false;
                        lGMOElTacuruPivot2b.Show = false;
                        lGMOElTacuruPivot3a.Show = false;
                        lGMOElTacuruPivot3b.Show = false;
                        lGMOElTacuruPivot4.Show = false;
                        lGMOElTacuruPivot5.Show = false;
                        lGMOElTacuruPivot6.Show = false;
                        lGMOElTacuruPivot7.Show = false;
                        lGMOElTacuruPivot8.Show = false;
                        lGMOElTacuruPivot9.Show = false;
                        lGMOElTacuruPivot10.Show = false;
                    }
                    else 
                    {
                        lGMOElTacuruPivot1a.Show = false;
                        lGMOElTacuruPivot1b.Show = false;
                        lGMOElTacuruPivot2a.Show = false;
                        lGMOElTacuruPivot2b.Show = false;
                        lGMOElTacuruPivot3a.Show = false;
                        lGMOElTacuruPivot3b.Show = false;
                        lGMOElTacuruPivot4.Show = false;
                        lGMOElTacuruPivot5.Show = false;
                        lGMOElTacuruPivot6.Show = false;
                        lGMOElTacuruPivot7.Show = false;
                        lGMOElTacuruPivot8.Show = false;
                        lGMOElTacuruPivot9.Show = false;
                        lGMOElTacuruPivot10.Show = false;
                    }
                    #endregion

                    context.Pivots.Add(lGMOElTacuruPivot1a);
                    context.Pivots.Add(lGMOElTacuruPivot1b);
                    context.Pivots.Add(lGMOElTacuruPivot2a);
                    context.Pivots.Add(lGMOElTacuruPivot2b);
                    context.Pivots.Add(lGMOElTacuruPivot3a);
                    context.Pivots.Add(lGMOElTacuruPivot3b);
                    context.Pivots.Add(lGMOElTacuruPivot4);
                    context.Pivots.Add(lGMOElTacuruPivot5);
                    context.Pivots.Add(lGMOElTacuruPivot6);
                    context.Pivots.Add(lGMOElTacuruPivot7);
                    context.Pivots.Add(lGMOElTacuruPivot8);
                    context.Pivots.Add(lGMOElTacuruPivot9);
                    context.Pivots.Add(lGMOElTacuruPivot10);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots Tres Marias
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmTresMarias
                             select f).FirstOrDefault();

                    #region Pivot 1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombTresMarias
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotTresMarias1
                                 select pos).FirstOrDefault();

                    var lTresMariasPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotTresMarias1,
                        ShortName = "Pivot 01",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 82,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 41,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombTresMarias
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotTresMarias2
                                 select pos).FirstOrDefault();

                    var lTresMariasPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotTresMarias2,
                        ShortName = "Pivot 02",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 52,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 26,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 3
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombTresMarias
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotTresMarias3
                                 select pos).FirstOrDefault();

                    var lTresMariasPivot3 = new Pivot
                    {
                        Name = Utils.NamePivotTresMarias3,
                        ShortName = "Pivot 03",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 58,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 29,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 4
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombTresMarias
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotTresMarias4
                                 select pos).FirstOrDefault();

                    var lTresMariasPivot4 = new Pivot
                    {
                        Name = Utils.NamePivotTresMarias4,
                        ShortName = "Pivot 04",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 48,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 24,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017)
                    {
                        lTresMariasPivot1.Show = true;
                        lTresMariasPivot2.Show = true;
                        lTresMariasPivot3.Show = true;
                        lTresMariasPivot4.Show = true;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lTresMariasPivot1.Show = false;
                        lTresMariasPivot2.Show = false;
                        lTresMariasPivot3.Show = false;
                        lTresMariasPivot4.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lTresMariasPivot1.Show = false;
                        lTresMariasPivot2.Show = false;
                        lTresMariasPivot3.Show = false;
                        lTresMariasPivot4.Show = false;
                    }
                    else 
                    {
                        lTresMariasPivot1.Show = false;
                        lTresMariasPivot2.Show = false;
                        lTresMariasPivot3.Show = false;
                        lTresMariasPivot4.Show = false;
                    }
                    #endregion

                    context.Pivots.Add(lTresMariasPivot1);
                    context.Pivots.Add(lTresMariasPivot2);
                    context.Pivots.Add(lTresMariasPivot3);
                    context.Pivots.Add(lTresMariasPivot4);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots La Rinconada
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmLaRinconada
                             select f).FirstOrDefault();

                    #region Pivot 01
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaRinconada
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaRinconada1
                                 select pos).FirstOrDefault();

                    var lLaRinconadaPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotLaRinconada1,
                        ShortName = "Pivot 01",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 50,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 25,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 02
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaRinconada
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaRinconada2
                                 select pos).FirstOrDefault();

                    var lLaRinconadaPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotLaRinconada2,
                        ShortName = "Pivot 02",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 52,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 26,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 3.1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaRinconada
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaRinconada3_1
                                 select pos).FirstOrDefault();

                    var lLaRinconadaPivot3_1 = new Pivot
                    {
                        Name = Utils.NamePivotLaRinconada3_1,
                        ShortName = "Pivot 3.1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 58,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 29,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 13.1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaRinconada
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaRinconada13_1
                                 select pos).FirstOrDefault();

                    var lLaRinconadaPivot13_1 = new Pivot
                    {
                        Name = Utils.NamePivotLaRinconada13_1,
                        ShortName = "Pivot 13.1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 48,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 24,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017)
                    {
                        lLaRinconadaPivot1.Show = true;
                        lLaRinconadaPivot2.Show = true;
                        lLaRinconadaPivot3_1.Show = true;
                        lLaRinconadaPivot13_1.Show = true;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lLaRinconadaPivot1.Show = false;
                        lLaRinconadaPivot2.Show = false;
                        lLaRinconadaPivot3_1.Show = false;
                        lLaRinconadaPivot13_1.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lLaRinconadaPivot1.Show = false;
                        lLaRinconadaPivot2.Show = false;
                        lLaRinconadaPivot3_1.Show = false;
                        lLaRinconadaPivot13_1.Show = false;
                    }
                    else 
                    {
                        lLaRinconadaPivot1.Show = false;
                        lLaRinconadaPivot2.Show = false;
                        lLaRinconadaPivot3_1.Show = false;
                        lLaRinconadaPivot13_1.Show = false;
                    }
                    #endregion

                    context.Pivots.Add(lLaRinconadaPivot1);
                    context.Pivots.Add(lLaRinconadaPivot2);
                    context.Pivots.Add(lLaRinconadaPivot3_1);
                    context.Pivots.Add(lLaRinconadaPivot13_1);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots El Rincon
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElRincon)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmElRincon
                             select f).FirstOrDefault();

                    #region Pivot 1a
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombElRincon
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElRincon1a
                                 select pos).FirstOrDefault();

                    var lElRinconPivot1a = new Pivot
                    {
                        Name = Utils.NamePivotElRincon1a,
                        ShortName = "Pivot 1a",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 47,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 23,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 1b
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombElRincon
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElRincon1b
                                 select pos).FirstOrDefault();

                    var lElRinconPivot1b = new Pivot
                    {
                        Name = Utils.NamePivotElRincon1b,
                        ShortName = "Pivot 1b",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 46,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 23,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2a
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombElRincon
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElRincon2a
                                 select pos).FirstOrDefault();

                    var lElRinconPivot2a = new Pivot
                    {
                        Name = Utils.NamePivotElRincon2a,
                        ShortName = "Pivot 2a",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 47,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 23,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2b
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombElRincon
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElRincon2b
                                 select pos).FirstOrDefault();

                    var lElRinconPivot2b = new Pivot
                    {
                        Name = Utils.NamePivotElRincon2b,
                        ShortName = "Pivot 2b",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 50,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 25,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lElRinconPivot1a.Show = true;
                        lElRinconPivot1b.Show = true;
                        lElRinconPivot2a.Show = false;
                        lElRinconPivot2b.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lElRinconPivot1a.Show = false;
                        lElRinconPivot1b.Show = false;
                        lElRinconPivot2a.Show = false;
                        lElRinconPivot2b.Show = true;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020)
                    {
                        lElRinconPivot1a.Show = false;
                        lElRinconPivot1b.Show = true;
                        lElRinconPivot2a.Show = false;
                        lElRinconPivot2b.Show = false;
                    }
                    else
                    {
                        lElRinconPivot1a.Show = false;
                        lElRinconPivot1b.Show = true;
                        lElRinconPivot2a.Show = false;
                        lElRinconPivot2b.Show = false;
                    }
                    #endregion

                    context.Pivots.Add(lElRinconPivot1a);
                    context.Pivots.Add(lElRinconPivot1b);
                    context.Pivots.Add(lElRinconPivot2a);
                    context.Pivots.Add(lElRinconPivot2b);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots El Desafio
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElDesafio)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmElDesafio
                             select f).FirstOrDefault();

                    #region Pivot 1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombElDesafio
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElDesafio1
                                 select pos).FirstOrDefault();

                    var lElDesafioPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotElDesafio1,
                        ShortName = "Pivot 1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 20,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 10,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombElDesafio
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElDesafio2
                                 select pos).FirstOrDefault();

                    var lElDesafioPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotElDesafio2,
                        ShortName = "Pivot 2",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 20,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 10,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lElDesafioPivot1.Show = true;
                        lElDesafioPivot2.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lElDesafioPivot1.Show = false;
                        lElDesafioPivot2.Show = false;
                    }
                    else 
                    {
                        lElDesafioPivot1.Show = false;
                        lElDesafioPivot2.Show = false;
                    }
                    #endregion

                    context.Pivots.Add(lElDesafioPivot1);
                    context.Pivots.Add(lElDesafioPivot2);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots Los Naranjales
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LosNaranjales)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmLosNaranjales
                             select f).FirstOrDefault();

                    #region Pivot 6aT3
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLosNaranjales
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLosNaranjales6aT3
                                 select pos).FirstOrDefault();

                    var lLosNaranjalesPivot6aT3 = new Pivot
                    {
                        Name = Utils.NamePivotLosNaranjales6aT3,
                        ShortName = "Pivot 6aT3",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.70,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 35,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 8,
                        Radius = 17,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 6bT3
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLosNaranjales
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLosNaranjales6bT3
                                 select pos).FirstOrDefault();

                    var lLosNaranjalesPivot6bT3 = new Pivot
                    {
                        Name = Utils.NamePivotLosNaranjales6bT3,
                        ShortName = "Pivot 6bT3",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.70,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 35,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 8,
                        Radius = 17,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 5aT5
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLosNaranjales
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLosNaranjales5aT5
                                 select pos).FirstOrDefault();

                    var lLosNaranjalesPivot5aT5 = new Pivot
                    {
                        Name = Utils.NamePivotLosNaranjales5aT5,
                        ShortName = "Pivot 5aT5",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.70,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 35,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 8,
                        Radius = 17,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 5bT5
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLosNaranjales
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLosNaranjales5bT5
                                 select pos).FirstOrDefault();

                    var lLosNaranjalesPivot5bT5 = new Pivot
                    {
                        Name = Utils.NamePivotLosNaranjales5bT5,
                        ShortName = "Pivot 5bT5",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.70,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 35,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 8,
                        Radius = 17,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lLosNaranjalesPivot6aT3.Show = true;
                        lLosNaranjalesPivot6bT3.Show = true;
                        lLosNaranjalesPivot5aT5.Show = true;
                        lLosNaranjalesPivot5bT5.Show = true;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lLosNaranjalesPivot6aT3.Show = false;
                        lLosNaranjalesPivot6bT3.Show = false;
                        lLosNaranjalesPivot5aT5.Show = false;
                        lLosNaranjalesPivot5bT5.Show = false;
                    }
                    else 
                    {
                        lLosNaranjalesPivot6aT3.Show = false;
                        lLosNaranjalesPivot6bT3.Show = false;
                        lLosNaranjalesPivot5aT5.Show = false;
                        lLosNaranjalesPivot5bT5.Show = false;
                    }
                    #endregion

                    context.Pivots.Add(lLosNaranjalesPivot6aT3);
                    context.Pivots.Add(lLosNaranjalesPivot6bT3);
                    context.Pivots.Add(lLosNaranjalesPivot5aT5);
                    context.Pivots.Add(lLosNaranjalesPivot5bT5);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots Santa Emilia
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaEmilia)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmSantaEmilia
                             select f).FirstOrDefault();

                    #region Pivot 1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombSantaEmilia
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaEmilia1
                                 select pos).FirstOrDefault();

                    var lSantaEmiliaPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotSantaEmilia1,
                        ShortName = "Pivot 1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.75,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 20,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 10,
                        Radius = 10,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombSantaEmilia
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaEmilia2
                                 select pos).FirstOrDefault();

                    var lSantaEmiliaPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotSantaEmilia2,
                        ShortName = "Pivot 2",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.75,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 75,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 15,
                        Radius = 32,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 3
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombSantaEmilia
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaEmilia3
                                 select pos).FirstOrDefault();

                    var lSantaEmiliaPivot3 = new Pivot
                    {
                        Name = Utils.NamePivotSantaEmilia3,
                        ShortName = "Pivot 3",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.75,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 20,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 12,
                        Radius = 10,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 4
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombSantaEmilia
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaEmilia4
                                 select pos).FirstOrDefault();

                    var lSantaEmiliaPivot4 = new Pivot
                    {
                        Name = Utils.NamePivotSantaEmilia4,
                        ShortName = "Pivot 4",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.75,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 75,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 12,
                        Radius = 37,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 5
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombSantaEmilia
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaEmilia5
                                 select pos).FirstOrDefault();

                    var lSantaEmiliaPivot5 = new Pivot
                    {
                        Name = Utils.NamePivotSantaEmilia5,
                        ShortName = "Pivot 5",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.75,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 75,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 15,
                        Radius = 37,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 6
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombSantaEmilia
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaEmilia6
                                 select pos).FirstOrDefault();

                    var lSantaEmiliaPivot6 = new Pivot
                    {
                        Name = Utils.NamePivotSantaEmilia6,
                        ShortName = "Pivot 6",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.75,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 75,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 15,
                        Radius = 37,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 7
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombSantaEmilia
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaEmilia7
                                 select pos).FirstOrDefault();

                    var lSantaEmiliaPivot7 = new Pivot
                    {
                        Name = Utils.NamePivotSantaEmilia7,
                        ShortName = "Pivot 7",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.75,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 75,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 15,
                        Radius = 37,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot ZP
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombSantaEmilia
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantaEmiliaZP
                                 select pos).FirstOrDefault();

                    var lSantaEmiliaPivotZP = new Pivot
                    {
                        Name = Utils.NamePivotSantaEmiliaZP,
                        ShortName = "Pivot ZP",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 70,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 35,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lSantaEmiliaPivot1.Show = false;
                        lSantaEmiliaPivot2.Show = true;
                        lSantaEmiliaPivot3.Show = false;
                        lSantaEmiliaPivot4.Show = false;
                        lSantaEmiliaPivot5.Show = true;
                        lSantaEmiliaPivot6.Show = false;
                        lSantaEmiliaPivot7.Show = true;
                        lSantaEmiliaPivotZP.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lSantaEmiliaPivot1.Show = false;
                        lSantaEmiliaPivot2.Show = false;
                        lSantaEmiliaPivot3.Show = false;
                        lSantaEmiliaPivot4.Show = false;
                        lSantaEmiliaPivot5.Show = false;
                        lSantaEmiliaPivot6.Show = false;
                        lSantaEmiliaPivot7.Show = false;
                        lSantaEmiliaPivotZP.Show = true;
                    }
                    else 
                    {
                        lSantaEmiliaPivot1.Show = false;
                        lSantaEmiliaPivot2.Show = false;
                        lSantaEmiliaPivot3.Show = false;
                        lSantaEmiliaPivot4.Show = false;
                        lSantaEmiliaPivot5.Show = false;
                        lSantaEmiliaPivot6.Show = false;
                        lSantaEmiliaPivot7.Show = false;
                        lSantaEmiliaPivotZP.Show = true;
                    }
                    #endregion


                    context.Pivots.Add(lSantaEmiliaPivot1);
                    context.Pivots.Add(lSantaEmiliaPivot2);
                    context.Pivots.Add(lSantaEmiliaPivot3);
                    context.Pivots.Add(lSantaEmiliaPivot4);
                    context.Pivots.Add(lSantaEmiliaPivot5);
                    context.Pivots.Add(lSantaEmiliaPivot6);
                    context.Pivots.Add(lSantaEmiliaPivot7);
                    context.Pivots.Add(lSantaEmiliaPivotZP);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots Gran Molino
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GranMolino)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmGranMolino
                             select f).FirstOrDefault();

                    #region Pivot 1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGranMolino
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGranMolino1
                                 select pos).FirstOrDefault();

                    var lGranMolinoPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotGranMolino1,
                        ShortName = "Pivot 1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 25,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 12,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGranMolino
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGranMolino2
                                 select pos).FirstOrDefault();

                    var lGranMolinoPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotGranMolino2,
                        ShortName = "Pivot 2",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 23,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 11,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 3
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGranMolino
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGranMolino3
                                 select pos).FirstOrDefault();

                    var lGranMolinoPivot3 = new Pivot
                    {
                        Name = Utils.NamePivotGranMolino3,
                        ShortName = "Pivot 3",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 30,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 12,
                        Radius = 15,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 4
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGranMolino
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGranMolino4
                                 select pos).FirstOrDefault();

                    var lGranMolinoPivot4 = new Pivot
                    {
                        Name = Utils.NamePivotGranMolino4,
                        ShortName = "Pivot 4",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 30,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 15,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 5
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGranMolino
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGranMolino5
                                 select pos).FirstOrDefault();

                    var lGranMolinoPivot5 = new Pivot
                    {
                        Name = Utils.NamePivotGranMolino5,
                        ShortName = "Pivot 5",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 6,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 3,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2b
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGranMolino
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGranMolino2b
                                 select pos).FirstOrDefault();

                    var lGranMolinoPivot2b = new Pivot
                    {
                        Name = Utils.NamePivotGranMolino2b,
                        ShortName = "Pivot 2b",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 23,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 11,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 5b
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombGranMolino
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotGranMolino5b
                                 select pos).FirstOrDefault();

                    var lGranMolinoPivot5b = new Pivot
                    {
                        Name = Utils.NamePivotGranMolino5b,
                        ShortName = "Pivot 5b",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 6,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 3,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lGranMolinoPivot1.Show = true;
                        lGranMolinoPivot2.Show = true;
                        lGranMolinoPivot3.Show = true;
                        lGranMolinoPivot4.Show = true;
                        lGranMolinoPivot5.Show = true;
                        lGranMolinoPivot2b.Show = true;
                        lGranMolinoPivot5b.Show = true;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lGranMolinoPivot1.Show = false;
                        lGranMolinoPivot2.Show = false;
                        lGranMolinoPivot3.Show = false;
                        lGranMolinoPivot4.Show = false;
                        lGranMolinoPivot5.Show = false;
                        lGranMolinoPivot2b.Show = false;
                        lGranMolinoPivot5b.Show = false;
                    }
                    else 
                    {
                        lGranMolinoPivot1.Show = false;
                        lGranMolinoPivot2.Show = false;
                        lGranMolinoPivot3.Show = false;
                        lGranMolinoPivot4.Show = false;
                        lGranMolinoPivot5.Show = false;
                        lGranMolinoPivot2b.Show = false;
                        lGranMolinoPivot5b.Show = false;
                    }
                    #endregion

                    context.Pivots.Add(lGranMolinoPivot1);
                    context.Pivots.Add(lGranMolinoPivot2);
                    context.Pivots.Add(lGranMolinoPivot3);
                    context.Pivots.Add(lGranMolinoPivot4);
                    context.Pivots.Add(lGranMolinoPivot5);
                    context.Pivots.Add(lGranMolinoPivot2b);
                    context.Pivots.Add(lGranMolinoPivot5b);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots La Portuguesa
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPortuguesa)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmLaPortuguesa
                             select f).FirstOrDefault();

                    #region Pivot 1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaPortuguesa
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPortuguesa1
                                 select pos).FirstOrDefault();

                    var lLaPortuguesaPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotLaPortuguesa1,
                        ShortName = "Pivot 1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 50,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaPortuguesa
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaPortuguesa2
                                 select pos).FirstOrDefault();

                    var lLaPortuguesaPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotLaPortuguesa2,
                        ShortName = "Pivot 2",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.80,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 50,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lLaPortuguesaPivot1.Show = false;
                        lLaPortuguesaPivot2.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lLaPortuguesaPivot1.Show = true;
                        lLaPortuguesaPivot2.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020)
                    {
                        lLaPortuguesaPivot1.Show = true;
                        lLaPortuguesaPivot2.Show = false;
                    }
                    else
                    {
                        lLaPortuguesaPivot1.Show = true;
                        lLaPortuguesaPivot2.Show = false;

                    }
                    #endregion

                    context.Pivots.Add(lLaPortuguesaPivot1);
                    context.Pivots.Add(lLaPortuguesaPivot2);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots Cassarino - La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.CassarinoLaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmCassarinoLaPerdiz
                             select f).FirstOrDefault();

                    #region Pivot 1.1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombCassarinoLaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotCassarinoLaPerdiz11
                                 select pos).FirstOrDefault();

                    var lCassarinoLaPerdizPivot11 = new Pivot
                    {
                        Name = Utils.NamePivotCassarinoLaPerdiz11,
                        ShortName = "Pivot 1.1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 46,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 23,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 1.2
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombCassarinoLaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotCassarinoLaPerdiz12
                                 select pos).FirstOrDefault();

                    var lCassarinoLaPerdizPivot12 = new Pivot
                    {
                        Name = Utils.NamePivotCassarinoLaPerdiz12,
                        ShortName = "Pivot 1.2",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 46,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 23,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 1.3
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombCassarinoLaPerdiz
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotCassarinoLaPerdiz13
                                 select pos).FirstOrDefault();

                    var lCassarinoLaPerdizPivot13 = new Pivot
                    {
                        Name = Utils.NamePivotCassarinoLaPerdiz13,
                        ShortName = "Pivot 1.3",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 46,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 23,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lCassarinoLaPerdizPivot11.Show = false;
                        lCassarinoLaPerdizPivot12.Show = false;
                        lCassarinoLaPerdizPivot13.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lCassarinoLaPerdizPivot11.Show = true;
                        lCassarinoLaPerdizPivot12.Show = true;
                        lCassarinoLaPerdizPivot13.Show = true;
                    }
                    else
                    {
                        lCassarinoLaPerdizPivot11.Show = true;
                        lCassarinoLaPerdizPivot12.Show = true;
                        lCassarinoLaPerdizPivot13.Show = true;
                    }
                    #endregion

                    context.Pivots.Add(lCassarinoLaPerdizPivot11);
                    context.Pivots.Add(lCassarinoLaPerdizPivot12);
                    context.Pivots.Add(lCassarinoLaPerdizPivot13);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots Santo Domingo
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantoDomingo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmSantoDomingo
                             select f).FirstOrDefault();

                    #region Pivot 1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombSantoDomingo
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantoDomingo1
                                 select pos).FirstOrDefault();

                    var lSantoDomingoPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotSantoDomingo1,
                        ShortName = "Pivot 1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 175,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 88,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombSantoDomingo
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotSantoDomingo2
                                 select pos).FirstOrDefault();

                    var lSantoDomingoPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotSantoDomingo2,
                        ShortName = "Pivot 2",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 100,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 50,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lSantoDomingoPivot1.Show = false;
                        lSantoDomingoPivot2.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lSantoDomingoPivot1.Show = true;
                        lSantoDomingoPivot2.Show = false;
                    }
                    else
                    {
                        lSantoDomingoPivot1.Show = true;
                        lSantoDomingoPivot2.Show = false;
                    }
                    #endregion

                    context.Pivots.Add(lSantoDomingoPivot1);
                    context.Pivots.Add(lSantoDomingoPivot2);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots Cecchini
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Cecchini)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmCecchini
                             select f).FirstOrDefault();

                    #region Pivot 1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombCecchini
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotCecchini1
                                 select pos).FirstOrDefault();

                    var lCecchiniPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotCecchini1,
                        ShortName = "Pivot 1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 90,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 45,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombCecchini
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotCecchini2
                                 select pos).FirstOrDefault();

                    var lCecchiniPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotCecchini2,
                        ShortName = "Pivot 2 Canon",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 30,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 15,
                        Show = false,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lCecchiniPivot1.Show = false;
                        lCecchiniPivot2.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lCecchiniPivot1.Show = true;
                        lCecchiniPivot2.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020)
                    {
                        lCecchiniPivot1.Show = true;
                        lCecchiniPivot2.Show = true;
                    }
                    else
                    {
                        lCecchiniPivot1.Show = true;
                        lCecchiniPivot2.Show = true;
                    }
                    #endregion

                    context.Pivots.Add(lCecchiniPivot1);
                    context.Pivots.Add(lCecchiniPivot2);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots El Alba
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElAlba)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmElAlba
                             select f).FirstOrDefault();

                    #region Pivot 32
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombElAlba
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElAlba32
                                 select pos).FirstOrDefault();

                    var lElAlbaPivot32 = new Pivot
                    {
                        Name = Utils.NamePivotElAlba32,
                        ShortName = "Pivot 32",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 65,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 12,
                        Radius = 32,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 33
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombElAlba
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElAlba33
                                 select pos).FirstOrDefault();

                    var lElAlbaPivot33 = new Pivot
                    {
                        Name = Utils.NamePivotElAlba33,
                        ShortName = "Pivot 33",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 75,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 37,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 36
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombElAlba
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElAlba36
                                 select pos).FirstOrDefault();

                    var lElAlbaPivot36 = new Pivot
                    {
                        Name = Utils.NamePivotElAlba36,
                        ShortName = "Pivot 36",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 75,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 37,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 38
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombElAlba
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElAlba38
                                 select pos).FirstOrDefault();

                    var lElAlbaPivot38 = new Pivot
                    {
                        Name = Utils.NamePivotElAlba38,
                        ShortName = "Pivot 38",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 70,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 12,
                        Radius = 35,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 40
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombElAlba
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotElAlba40
                                 select pos).FirstOrDefault();

                    var lElAlbaPivot40 = new Pivot
                    {
                        Name = Utils.NamePivotElAlba40,
                        ShortName = "Pivot 40",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 70,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 35,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                    {
                        lElAlbaPivot32.Show = false;
                        lElAlbaPivot33.Show = false;
                        lElAlbaPivot36.Show = false;
                        lElAlbaPivot32.Show = false;
                        lElAlbaPivot33.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lElAlbaPivot32.Show = true;
                        lElAlbaPivot33.Show = true;
                        lElAlbaPivot36.Show = false;
                        lElAlbaPivot38.Show = false;
                        lElAlbaPivot40.Show = false;
                    }
                    else if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020)
                    {
                        lElAlbaPivot32.Show = false;
                        lElAlbaPivot33.Show = false;
                        lElAlbaPivot36.Show = true;
                        lElAlbaPivot38.Show = true;
                        lElAlbaPivot40.Show = true;
                    }
                    else
                    {
                        lElAlbaPivot32.Show = false;
                        lElAlbaPivot33.Show = false;
                        lElAlbaPivot36.Show = true;
                        lElAlbaPivot38.Show = true;
                        lElAlbaPivot40.Show = true;
                    }
                    #endregion

                    context.Pivots.Add(lElAlbaPivot32);
                    context.Pivots.Add(lElAlbaPivot33);
                    context.Pivots.Add(lElAlbaPivot36);
                    context.Pivots.Add(lElAlbaPivot38);
                    context.Pivots.Add(lElAlbaPivot40);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots La Zenaida
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaZenaida)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmLaZenaida
                             select f).FirstOrDefault();

                    #region Pivot 1
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaZenaida
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaZenaida1
                                 select pos).FirstOrDefault();

                    var lLaZenaidaPivot1 = new Pivot
                    {
                        Name = Utils.NamePivotLaZenaida1,
                        ShortName = "Pivot 1",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 15,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 8,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaZenaida
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaZenaida2
                                 select pos).FirstOrDefault();

                    var lLaZenaidaPivot2 = new Pivot
                    {
                        Name = Utils.NamePivotLaZenaida2,
                        ShortName = "Pivot 2",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 15,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 8,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 3
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaZenaida
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaZenaida3
                                 select pos).FirstOrDefault();

                    var lLaZenaidaPivot3 = new Pivot
                    {
                        Name = Utils.NamePivotLaZenaida3,
                        ShortName = "Pivot 3",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 15,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 8,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 4
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaZenaida
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaZenaida4
                                 select pos).FirstOrDefault();

                    var lLaZenaidaPivot4 = new Pivot
                    {
                        Name = Utils.NamePivotLaZenaida4,
                        ShortName = "Pivot 4",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 15,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 8,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 5
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaZenaida
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaZenaida5
                                 select pos).FirstOrDefault();

                    var lLaZenaidaPivot5 = new Pivot
                    {
                        Name = Utils.NamePivotLaZenaida5,
                        ShortName = "Pivot 5",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 15,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 8,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot 1a
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaZenaida
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaZenaida1a
                                 select pos).FirstOrDefault();

                    var lLaZenaidaPivot1a = new Pivot
                    {
                        Name = Utils.NamePivotLaZenaida1a,
                        ShortName = "Pivot 1a",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 15,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 8,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 4a
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaZenaida
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaZenaida4a
                                 select pos).FirstOrDefault();

                    var lLaZenaidaPivot4a = new Pivot
                    {
                        Name = Utils.NamePivotLaZenaida4a,
                        ShortName = "Pivot 4a",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 15,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 8,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 5a
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLaZenaida
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLaZenaida5a
                                 select pos).FirstOrDefault();

                    var lLaZenaidaPivot5a = new Pivot
                    {
                        Name = Utils.NamePivotLaZenaida5a,
                        ShortName = "Pivot 5a",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.90,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 15,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 14,
                        Radius = 8,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    #region Pivot - Shows by Season
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                    {
                        lLaZenaidaPivot1.Show = true;
                        lLaZenaidaPivot2.Show = true;
                        lLaZenaidaPivot3.Show = true;
                        lLaZenaidaPivot4.Show = true;
                        lLaZenaidaPivot5.Show = true;
                        lLaZenaidaPivot1a.Show = true;
                        lLaZenaidaPivot4a.Show = true;
                        lLaZenaidaPivot5a.Show = true;
                    }
                    if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                          || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020)
                    {
                        lLaZenaidaPivot1.Show = true;
                        lLaZenaidaPivot2.Show = true;
                        lLaZenaidaPivot3.Show = true;
                        lLaZenaidaPivot4.Show = true;
                        lLaZenaidaPivot5.Show = true;
                        lLaZenaidaPivot1a.Show = false;
                        lLaZenaidaPivot4a.Show = false;
                        lLaZenaidaPivot5a.Show = false;
                    }
                    else
                    {
                        lLaZenaidaPivot1.Show = true;
                        lLaZenaidaPivot2.Show = true;
                        lLaZenaidaPivot3.Show = true;
                        lLaZenaidaPivot4.Show = true;
                        lLaZenaidaPivot5.Show = true;
                        lLaZenaidaPivot1a.Show = true;
                        lLaZenaidaPivot4a.Show = true;
                        lLaZenaidaPivot5a.Show = true;
                    }
                    #endregion

                    context.Pivots.Add(lLaZenaidaPivot1);
                    context.Pivots.Add(lLaZenaidaPivot2);
                    context.Pivots.Add(lLaZenaidaPivot3);
                    context.Pivots.Add(lLaZenaidaPivot4);
                    context.Pivots.Add(lLaZenaidaPivot5);
                    context.Pivots.Add(lLaZenaidaPivot1a);
                    context.Pivots.Add(lLaZenaidaPivot4a);
                    context.Pivots.Add(lLaZenaidaPivot5a);
                    context.SaveChanges();
                }
            }
            #endregion

        }

        public static void UpdateSoilsBombsIrrigationUnitsUsersByFarm()
        {
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmDemo1();
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmDemo2();
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmDemo3();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmSantaLucia();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmDCAElParaiso();
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmDCASanJose();
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmDCALaPerdiz();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmDCAElParaiso();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmDCALaPerdiz();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmDCASanJose();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmDelLagoSanPedro();
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmDelLagoElMirador();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmDelLagoSanPedro();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmDelLagoElMirador();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmGMOLaPalma();
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmGMOElTacuru();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production 
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmGMOLaPalma();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production 
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmGMOElTacuru();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmTresMarias();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmLaRinconada();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElRincon)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmElRincon();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElDesafio)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmElDesafio();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LosNaranjales)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmLosNaranjales();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaEmilia)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmSantaEmilia();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GranMolino)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmGranMolino();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaPortuguesa)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmLaPortuguesa();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.CassarinoLaPerdiz)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmCassarinoLaPerdiz();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantoDomingo)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmSantoDomingo();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Cecchini)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmCecchini();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElAlba)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmElAlba();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2019_2020
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaZenaida)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmLaZenaida();
            }
        }

        public static void InsertCrops()
        {
            Region lRegion = null;
            Specie lSpecie = null;
            CropCoefficient lCropCoefficient = null;

            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;

            Stage lMinStageToConsiderETinHBCalculation = null;
            Stage lStopIrrigationStage = null;

            #region Base
            var lBase = new Crop
            {
                Name = Utils.NameBase,
                RegionId = 0,
                SpecieId = 0,
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

                #region Corn South Short

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
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesCorn)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_CORN)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesCorn)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_CORN)
                                        select st).FirstOrDefault();

                var lCropCornSouthShort = new Crop
                {
                    Name = Utils.NameSpecieCornSouthShort,
                    ShortName = "Maíz",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Corn,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Corn,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Corn South Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieCornSouthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieCornSouthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesCorn)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesCorn)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_CORN)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesCorn)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_CORN)
                                        select st).FirstOrDefault();

                var lCropCornSouthMedium = new Crop
                {
                    Name = Utils.NameSpecieCornSouthMedium,
                    ShortName = "Maíz",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Corn,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Corn,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion

                #region Soya South Short

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
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesSoya)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_SOYA)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesSoya)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_SOYA)
                                        select st).FirstOrDefault();

                var lCropSoyaSouthShort = new Crop
                {
                    Name = Utils.NameSpecieSoyaSouthShort,
                    ShortName = "Soja",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Soya,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Soya,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Soya South Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieSoyaSouthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieSoyaSouthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesSoya)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesSoya)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_SOYA)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesSoya)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_SOYA)
                                        select st).FirstOrDefault();

                var lCropSoyaSouthMedium = new Crop
                {
                    Name = Utils.NameSpecieSoyaSouthMedium,
                    ShortName = "Soja",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Soya,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Soya,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion

                #region Corn North Short

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieCornNorthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieCornNorthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesCorn)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesCorn)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_CORN)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesCorn)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_CORN)
                                        select st).FirstOrDefault();

                var lCropCornNorthShort = new Crop
                {
                    Name = Utils.NameSpecieCornNorthShort,
                    ShortName = "Maíz",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Corn,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Corn,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Corn North Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieCornNorthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieCornNorthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesCorn)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesCorn)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_CORN)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesCorn)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_CORN)
                                        select st).FirstOrDefault();

                var lCropCornNorthMedium = new Crop
                {
                    Name = Utils.NameSpecieCornNorthMedium,
                    ShortName = "Maíz",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Corn,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Corn,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion

                #region Soya North Short

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieSoyaNorthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieSoyaNorthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesSoya)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesSoya)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_SOYA)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesSoya)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_SOYA)
                                        select st).FirstOrDefault();

                var lCropSoyaNorthShort = new Crop
                {
                    Name = Utils.NameSpecieSoyaNorthShort,
                    ShortName = "Soja",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Soya,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Soya,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Soya North Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieSoyaNorthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieSoyaNorthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesSoya)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesSoya)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_SOYA)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesSoya)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_SOYA)
                                        select st).FirstOrDefault();

                var lCropSoyaNorthMedium = new Crop
                {
                    Name = Utils.NameSpecieSoyaNorthMedium,
                    ShortName = "Soja",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Soya,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Soya,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion

                #region Oat South Short

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieOatSouthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieOatSouthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesOat)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesOat)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_OAT)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesOat)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_OAT)
                                        select st).FirstOrDefault();

                var lCropOatSouthShort = new Crop
                {
                    Name = Utils.NameSpecieOatSouthShort,
                    ShortName = "Avena",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Oat,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Oat,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Oat South Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieOatSouthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieOatSouthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesOat)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesOat)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_OAT)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesOat)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_OAT)
                                        select st).FirstOrDefault();

                var lCropOatSouthMedium = new Crop
                {
                    Name = Utils.NameSpecieOatSouthMedium,
                    ShortName = "Avena",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Oat,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Oat,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Oat North Short

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieOatNorthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieOatNorthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesOat)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesOat)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_OAT)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesOat)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_OAT)
                                        select st).FirstOrDefault();

                var lCropOatNorthShort = new Crop
                {
                    Name = Utils.NameSpecieOatNorthShort,
                    ShortName = "Avena",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Oat,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Oat,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Oat North Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieOatNorthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieOatNorthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesOat)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesOat)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_OAT)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesOat)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_OAT)
                                        select st).FirstOrDefault();

                var lCropOatNorthMedium = new Crop
                {
                    Name = Utils.NameSpecieOatNorthMedium,
                    ShortName = "Avena",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Oat,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Oat,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion

                #region Pasture South Short

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpeciePastureSouthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpeciePastureSouthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesPasture)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesPasture)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_PASTURE)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesPasture)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_PASTURE)
                                        select st).FirstOrDefault();

                var lCropPastureSouthShort = new Crop
                {
                    Name = Utils.NameSpeciePastureSouthShort,
                    ShortName = "Pastura",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Pasture,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Pasture,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Pasture South Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpeciePastureSouthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpeciePastureSouthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesPasture)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesPasture)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_PASTURE)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesPasture)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_PASTURE)
                                        select st).FirstOrDefault();

                var lCropPastureSouthMedium = new Crop
                {
                    Name = Utils.NameSpeciePastureSouthMedium,
                    ShortName = "Pastura",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Pasture,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Pasture,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Pasture North Short

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpeciePastureNorthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpeciePastureNorthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesPasture)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesPasture)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_PASTURE)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesPasture)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_PASTURE)
                                        select st).FirstOrDefault();

                var lCropPastureNorthShort = new Crop
                {
                    Name = Utils.NameSpeciePastureNorthShort,
                    ShortName = "Pastura",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Pasture,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Pasture,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Pasture North Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpeciePastureNorthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpeciePastureNorthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesPasture)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesPasture)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_PASTURE)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesPasture)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_PASTURE)
                                        select st).FirstOrDefault();

                var lCropPastureNorthMedium = new Crop
                {
                    Name = Utils.NameSpeciePastureNorthMedium,
                    ShortName = "Pastura",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Pasture,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Pasture,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion

                #region Paspalum South Short

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpeciePaspalumSouthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpeciePaspalumSouthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesPaspalum)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesPaspalum)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_PASTURE)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesPaspalum)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_PASTURE)
                                        select st).FirstOrDefault();

                var lCropPaspalumSouthShort = new Crop
                {
                    Name = Utils.NameSpeciePaspalumSouthShort,
                    ShortName = "Pastura",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Paspalum,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Paspalum,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Paspalum South Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpeciePaspalumSouthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpeciePaspalumSouthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesPaspalum)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesPaspalum)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_PASTURE)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesPaspalum)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_PASTURE)
                                        select st).FirstOrDefault();

                var lCropPaspalumSouthMedium = new Crop
                {
                    Name = Utils.NameSpeciePaspalumSouthMedium,
                    ShortName = "Pastura",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Paspalum,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Paspalum,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Paspalum North Short

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpeciePaspalumNorthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpeciePaspalumNorthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesPaspalum)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesPaspalum)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_PASTURE)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesPaspalum)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_PASTURE)
                                        select st).FirstOrDefault();

                var lCropPaspalumNorthShort = new Crop
                {
                    Name = Utils.NameSpeciePaspalumNorthShort,
                    ShortName = "Pastura",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Paspalum,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Paspalum,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Paspalum North Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpeciePaspalumNorthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpeciePaspalumNorthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesPaspalum)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesPaspalum)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_PASTURE)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesPaspalum)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_PASTURE)
                                        select st).FirstOrDefault();

                var lCropPaspalumNorthMedium = new Crop
                {
                    Name = Utils.NameSpeciePaspalumNorthMedium,
                    ShortName = "Pastura",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Paspalum,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Paspalum,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion

                #region Prairie South Short

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpeciePrairieSouthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpeciePrairieSouthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesPrairie)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesPrairie)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_PASTURE)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesPrairie)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_PASTURE)
                                        select st).FirstOrDefault();

                var lCropPrairieSouthShort = new Crop
                {
                    Name = Utils.NameSpeciePrairieSouthShort,
                    ShortName = "Pastura",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Prairie,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Prairie,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Prairie South Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpeciePrairieSouthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpeciePrairieSouthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesPrairie)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesPrairie)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_PASTURE)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesPrairie)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_PASTURE)
                                        select st).FirstOrDefault();

                var lCropPrairieSouthMedium = new Crop
                {
                    Name = Utils.NameSpeciePrairieSouthMedium,
                    ShortName = "Pastura",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Prairie,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Prairie,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Prairie North Short

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpeciePrairieNorthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpeciePrairieNorthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesPrairie)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesPrairie)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_PASTURE)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesPrairie)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_PASTURE)
                                        select st).FirstOrDefault();

                var lCropPrairieNorthShort = new Crop
                {
                    Name = Utils.NameSpeciePrairieNorthShort,
                    ShortName = "Pastura",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Prairie,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Prairie,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Prairie North Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpeciePrairieNorthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpeciePrairieNorthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesPrairie)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesPrairie)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_PASTURE)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesPrairie)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_PASTURE)
                                        select st).FirstOrDefault();

                var lCropPrairieNorthMedium = new Crop
                {
                    Name = Utils.NameSpeciePrairieNorthMedium,
                    ShortName = "Pastura",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Prairie,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Prairie,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion

                #region Alfalfa South Short

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieAlfalfaSouthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieAlfalfaSouthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesAlfalfa)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesAlfalfa)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_ALFALFA)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesAlfalfa)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_ALFALFA)
                                        select st).FirstOrDefault();

                var lCropAlfalfaSouthShort = new Crop
                {
                    Name = Utils.NameSpecieAlfalfaSouthShort,
                    ShortName = "Alfalfa",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Alfalfa,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Alfalfa,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Alfalfa South Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieAlfalfaSouthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieAlfalfaSouthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesAlfalfa)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesAlfalfa)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_ALFALFA)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesAlfalfa)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_ALFALFA)
                                        select st).FirstOrDefault();

                var lCropAlfalfaSouthMedium = new Crop
                {
                    Name = Utils.NameSpecieAlfalfaSouthMedium,
                    ShortName = "Alfalfa",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Alfalfa,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Alfalfa,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Alfalfa North Short

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieAlfalfaNorthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieAlfalfaNorthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesAlfalfa)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesAlfalfa)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_ALFALFA)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesAlfalfa)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_ALFALFA)
                                        select st).FirstOrDefault();

                var lCropAlfalfaNorthShort = new Crop
                {
                    Name = Utils.NameSpecieAlfalfaNorthShort,
                    ShortName = "Alfalfa",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Alfalfa,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Alfalfa,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region Alfalfa North Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieAlfalfaNorthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieAlfalfaNorthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesAlfalfa)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesAlfalfa)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_ALFALFA)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesAlfalfa)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_ALFALFA)
                                        select st).FirstOrDefault();

                var lCropAlfalfaNorthMedium = new Crop
                {
                    Name = Utils.NameSpecieAlfalfaNorthMedium,
                    ShortName = "Alfalfa",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_Alfalfa,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_Alfalfa,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion

                #region SudanGrass South Short

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieSudanGrassSouthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieSudanGrassSouthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesSudanGrass)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesSudanGrass)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_SUDANGRASS)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesSudanGrass)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_SUDANGRASS)
                                        select st).FirstOrDefault();

                var lCropSudanGrassSouthShort = new Crop
                {
                    Name = Utils.NameSpecieSudanGrassSouthShort,
                    ShortName = "SudanGrass",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_SudanGrass,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_SudanGrass,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region SudanGrass South Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieSudanGrassSouthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieSudanGrassSouthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesSudanGrass)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesSudanGrass)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_SUDANGRASS)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesSudanGrass)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_SUDANGRASS)
                                        select st).FirstOrDefault();

                var lCropSudanGrassSouthMedium = new Crop
                {
                    Name = Utils.NameSpecieSudanGrassSouthMedium,
                    ShortName = "SudanGrass",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_SudanGrass,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_SudanGrass,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region SudanGrass North Short

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieSudanGrassNorthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieSudanGrassNorthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesSudanGrass)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesSudanGrass)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_SUDANGRASS)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesSudanGrass)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_SUDANGRASS)
                                        select st).FirstOrDefault();

                var lCropSudanGrassNorthShort = new Crop
                {
                    Name = Utils.NameSpecieSudanGrassNorthShort,
                    ShortName = "SudanGrass",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_SudanGrass,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_SudanGrass,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region SudanGrass North Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieSudanGrassNorthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieSudanGrassNorthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesSudanGrass)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesSudanGrass)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_SUDANGRASS)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesSudanGrass)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_SUDANGRASS)
                                        select st).FirstOrDefault();

                var lCropSudanGrassNorthMedium = new Crop
                {
                    Name = Utils.NameSpecieSudanGrassNorthMedium,
                    ShortName = "SudanGrass",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_SudanGrass,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_SudanGrass,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion

                #region FescueForage South Short

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieFescueForageSouthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieFescueForageSouthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesFescueForage)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesFescueForage)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_FESCUEFORAGE)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesFescueForage)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_FESCUEFORAGE)
                                        select st).FirstOrDefault();

                var lCropFescueForageSouthShort = new Crop
                {
                    Name = Utils.NameSpecieFescueForageSouthShort,
                    ShortName = "Festuca Forage",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_FescueForage,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_FescueForage,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region FescueForage South Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionSouth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieFescueForageSouthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieFescueForageSouthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesFescueForage)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesFescueForage)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_FESCUEFORAGE)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesFescueForage)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_FESCUEFORAGE)
                                        select st).FirstOrDefault();

                var lCropFescueForageSouthMedium = new Crop
                {
                    Name = Utils.NameSpecieFescueForageSouthMedium,
                    ShortName = "Festuca Forage",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_FescueForage,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_FescueForage,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region FescueForage North Short

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieFescueForageNorthShort
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieFescueForageNorthShort
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesFescueForage)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesFescueForage)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_FESCUEFORAGE)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesFescueForage)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_FESCUEFORAGE)
                                        select st).FirstOrDefault();

                var lCropFescueForageNorthShort = new Crop
                {
                    Name = Utils.NameSpecieFescueForageNorthShort,
                    ShortName = "Festuca Forage",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_FescueForage,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_FescueForage,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion
                #region FescueForage North Medium

                lRegion = (from reg in context.Regions
                           where reg.Name == Utils.NameRegionNorth
                           select reg).FirstOrDefault();
                lSpecie = (from sp in context.Species
                           where sp.Name == Utils.NameSpecieFescueForageNorthMedium
                           select sp).FirstOrDefault();
                lCropCoefficient = (from cc in context.CropCoefficients
                                    where cc.Name == Utils.NameSpecieFescueForageNorthMedium
                                    select cc).FirstOrDefault();
                lStages = (from st in context.Stages
                           where st.Name.Contains(Utils.NameStagesFescueForage)
                           select st).ToList<Stage>();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lSpecie.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lMinStageToConsiderETinHBCalculation = (from st in context.Stages
                                                        where st.Name.Contains(Utils.NameStagesFescueForage)
                                                           && st.Name.Contains(InitialTables.STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_FESCUEFORAGE)
                                                        select st).FirstOrDefault();
                lStopIrrigationStage = (from st in context.Stages
                                        where st.Name.Contains(Utils.NameStagesFescueForage)
                                           && st.Name.Contains(InitialTables.STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_FESCUEFORAGE)
                                        select st).FirstOrDefault();

                var lCropFescueForageNorthMedium = new Crop
                {
                    Name = Utils.NameSpecieFescueForageNorthMedium,
                    ShortName = "Festuca Forage",
                    RegionId = lRegion.RegionId,
                    Region = lRegion,
                    SpecieId = lSpecie.SpecieId,
                    Specie = lSpecie,
                    MinStageToConsiderETinHBCalculationId = lMinStageToConsiderETinHBCalculation.StageId,
                    MinStageToConsiderETinHBCalculation = lMinStageToConsiderETinHBCalculation,
                    MaxEvapotranspirationToIrrigate = Utils.MaxEvapotranspirationToIrrigate_FescueForage,
                    MinEvapotranspirationToIrrigate = Utils.MinEvapotranspirationToIrrigate_FescueForage,
                    CropCoefficientId = lCropCoefficient.CropCoefficientId,
                    CropCoefficient = lCropCoefficient,
                    StageList = lStages,
                    PhenologicalStageList = lPhenologicalStages,
                    StopIrrigationStageId = lStopIrrigationStage.StageId,
                    StopIrrigationStage = lStopIrrigationStage,
                };

                #endregion

                //context.Crops.Add(lBase);
                context.Crops.Add(lCropCornSouthShort);
                context.Crops.Add(lCropCornSouthMedium);
                context.Crops.Add(lCropSoyaSouthShort);
                context.Crops.Add(lCropSoyaSouthMedium);
                context.Crops.Add(lCropCornNorthShort);
                context.Crops.Add(lCropCornNorthMedium);
                context.Crops.Add(lCropSoyaNorthShort);
                context.Crops.Add(lCropSoyaNorthMedium);

                //TODO POC pastures
                context.Crops.Add(lCropOatSouthShort);
                context.Crops.Add(lCropOatSouthMedium);
                context.Crops.Add(lCropOatNorthShort);
                context.Crops.Add(lCropOatNorthMedium);
                context.Crops.Add(lCropPastureSouthShort);
                context.Crops.Add(lCropPastureSouthMedium);
                context.Crops.Add(lCropPastureNorthShort);
                context.Crops.Add(lCropPastureNorthMedium);
                context.Crops.Add(lCropPaspalumSouthShort);
                context.Crops.Add(lCropPaspalumSouthMedium);
                context.Crops.Add(lCropPaspalumNorthShort);
                context.Crops.Add(lCropPaspalumNorthMedium);
                context.Crops.Add(lCropPrairieSouthShort);
                context.Crops.Add(lCropPrairieSouthMedium);
                context.Crops.Add(lCropPrairieNorthShort);
                context.Crops.Add(lCropPrairieNorthMedium);
                context.Crops.Add(lCropAlfalfaSouthShort);
                context.Crops.Add(lCropAlfalfaSouthMedium);
                context.Crops.Add(lCropAlfalfaNorthShort);
                context.Crops.Add(lCropAlfalfaNorthMedium);
                context.Crops.Add(lCropSudanGrassSouthShort);
                context.Crops.Add(lCropSudanGrassSouthMedium);
                context.Crops.Add(lCropSudanGrassNorthShort);
                context.Crops.Add(lCropSudanGrassNorthMedium);
                context.Crops.Add(lCropFescueForageSouthShort);
                context.Crops.Add(lCropFescueForageSouthMedium);
                context.Crops.Add(lCropFescueForageNorthShort);
                context.Crops.Add(lCropFescueForageNorthMedium);
                //End TODO
                context.SaveChanges();
            }

        }

        public static void InsertCropsInformationByDate()
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

                #region Corn South Short
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieCornSouthShort
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lCornSouthShort = new CropInformationByDate
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
                #region Corn South Medium
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieCornSouthMedium
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lCornSouthMedium = new CropInformationByDate
                {
                    Name = Utils.NameSpecieCornSouthMedium,
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
                #region Soya South Short
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieSoyaSouthShort
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lSoyaSouthShort = new CropInformationByDate
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
                #region Soya South Medium
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieSoyaSouthMedium
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lSoyaSouthMedium = new CropInformationByDate
                {
                    Name = Utils.NameSpecieSoyaSouthMedium,
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

                #region Oat South Short
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieOatSouthShort
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lOatSouthShort = new CropInformationByDate
                {
                    Name = Utils.NameSpecieOatSouthShort,
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
                #region Oat South Medium
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieOatSouthMedium
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lOatSouthMedium = new CropInformationByDate
                {
                    Name = Utils.NameSpecieOatSouthMedium,
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
                #region Pasture South Short
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpeciePastureSouthShort
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lPastureSouthShort = new CropInformationByDate
                {
                    Name = Utils.NameSpeciePastureSouthShort,
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
                #region Pasture South Medium
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpeciePastureSouthMedium
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lPastureSouthMedium = new CropInformationByDate
                {
                    Name = Utils.NameSpeciePastureSouthMedium,
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
                #region Alfalfa South Short
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieAlfalfaSouthShort
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lAlfalfaSouthShort = new CropInformationByDate
                {
                    Name = Utils.NameSpecieAlfalfaSouthShort,
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
                #region Alfalfa South Medium
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieAlfalfaSouthMedium
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lAlfalfaSouthMedium = new CropInformationByDate
                {
                    Name = Utils.NameSpecieAlfalfaSouthMedium,
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
                #region SudanGrass South Short
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieSudanGrassSouthShort
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lSudanGrassSouthShort = new CropInformationByDate
                {
                    Name = Utils.NameSpecieSudanGrassSouthShort,
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
                #region SudanGrass South Medium
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieSudanGrassSouthMedium
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lSudanGrassSouthMedium = new CropInformationByDate
                {
                    Name = Utils.NameSpecieSudanGrassSouthMedium,
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
                #region FescueForage South Short
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieFescueForageSouthShort
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lFescueForageSouthShort = new CropInformationByDate
                {
                    Name = Utils.NameSpecieFescueForageSouthShort,
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
                #region FescueForage South Medium
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieFescueForageSouthMedium
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lFescueForageSouthMedium = new CropInformationByDate
                {
                    Name = Utils.NameSpecieFescueForageSouthMedium,
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

                context.CropInformationByDates.Add(lCornSouthShort);
                context.CropInformationByDates.Add(lCornSouthMedium);
                context.CropInformationByDates.Add(lSoyaSouthShort);
                context.CropInformationByDates.Add(lSoyaSouthMedium);
                context.CropInformationByDates.Add(lOatSouthShort);
                context.CropInformationByDates.Add(lOatSouthMedium);
                context.CropInformationByDates.Add(lPastureSouthShort);
                context.CropInformationByDates.Add(lPastureSouthMedium);
                context.CropInformationByDates.Add(lAlfalfaSouthShort);
                context.CropInformationByDates.Add(lAlfalfaSouthMedium);
                context.CropInformationByDates.Add(lSudanGrassSouthShort);
                context.CropInformationByDates.Add(lSudanGrassSouthMedium);
                context.CropInformationByDates.Add(lFescueForageSouthShort);
                context.CropInformationByDates.Add(lFescueForageSouthMedium);
                context.SaveChanges();

                #endregion

                #region North
                lRegion = (from region in context.Regions
                           where region.Name == Utils.NameRegionNorth
                           select region).FirstOrDefault();

                #region Corn North Short
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieCornNorthShort
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lCornNorthShort = new CropInformationByDate
                {
                    Name = Utils.NameSpecieCornNorthShort,
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
                #region Corn North Medium
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieCornNorthMedium
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lCornNorthMedium = new CropInformationByDate
                {
                    Name = Utils.NameSpecieCornNorthMedium,
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
                #region Soya North Short
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieSoyaNorthShort
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lSoyaNorthShort = new CropInformationByDate
                {
                    Name = Utils.NameSpecieSoyaNorthShort,
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
                #region Soya North Medium
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieSoyaNorthMedium
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lSoyaNorthMedium = new CropInformationByDate
                {
                    Name = Utils.NameSpecieSoyaNorthMedium,
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

                #region Oat North Short
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieOatNorthShort
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lOatNorthShort = new CropInformationByDate
                {
                    Name = Utils.NameSpecieOatNorthShort,
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
                #region Oat North Medium
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieOatNorthMedium
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lOatNorthMedium = new CropInformationByDate
                {
                    Name = Utils.NameSpecieOatNorthMedium,
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
                #region Pasture North Short
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpeciePastureNorthShort
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lPastureNorthShort = new CropInformationByDate
                {
                    Name = Utils.NameSpeciePastureNorthShort,
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
                #region Pasture North Medium
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpeciePastureNorthMedium
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lPastureNorthMedium = new CropInformationByDate
                {
                    Name = Utils.NameSpeciePastureNorthMedium,
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
                #region Alfalfa North Short
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieAlfalfaNorthShort
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lAlfalfaNorthShort = new CropInformationByDate
                {
                    Name = Utils.NameSpecieAlfalfaNorthShort,
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
                #region Alfalfa North Medium
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieAlfalfaNorthMedium
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lAlfalfaNorthMedium = new CropInformationByDate
                {
                    Name = Utils.NameSpecieAlfalfaNorthMedium,
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
                #region SudanGrass North Short
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieSudanGrassNorthShort
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lSudanGrassNorthShort = new CropInformationByDate
                {
                    Name = Utils.NameSpecieSudanGrassNorthShort,
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
                #region SudanGrass North Medium
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieSudanGrassNorthMedium
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lSudanGrassNorthMedium = new CropInformationByDate
                {
                    Name = Utils.NameSpecieSudanGrassNorthMedium,
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
                #region FescueForage North Short
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieFescueForageNorthShort
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lFescueForageNorthShort = new CropInformationByDate
                {
                    Name = Utils.NameSpecieFescueForageNorthShort,
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
                #region FescueForage North Medium
                lCrop = (from crop in context.Crops
                         where crop.Name == Utils.NameSpecieFescueForageNorthMedium
                         select crop).FirstOrDefault();
                lPhenologicalStages = (from ps in context.PhenologicalStages
                                       where ps.SpecieId == lCrop.SpecieId
                                       select ps).ToList<PhenologicalStage>();
                lStage = lPhenologicalStages.FirstOrDefault().Stage;

                var lFescueForageNorthMedium = new CropInformationByDate
                {
                    Name = Utils.NameSpecieFescueForageNorthMedium,
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

                context.CropInformationByDates.Add(lCornNorthShort);
                context.CropInformationByDates.Add(lCornNorthMedium);
                context.CropInformationByDates.Add(lSoyaNorthShort);
                context.CropInformationByDates.Add(lSoyaNorthMedium);

                context.CropInformationByDates.Add(lOatNorthShort);
                context.CropInformationByDates.Add(lOatNorthMedium);
                context.CropInformationByDates.Add(lPastureNorthShort);
                context.CropInformationByDates.Add(lPastureNorthMedium);
                context.CropInformationByDates.Add(lAlfalfaNorthShort);
                context.CropInformationByDates.Add(lAlfalfaNorthMedium);
                context.CropInformationByDates.Add(lSudanGrassNorthShort);
                context.CropInformationByDates.Add(lSudanGrassNorthMedium);
                context.CropInformationByDates.Add(lFescueForageNorthShort);
                context.CropInformationByDates.Add(lFescueForageNorthMedium);
                context.SaveChanges();

                #endregion

                //context.CropInformationByDates.Add(lBase);
                context.SaveChanges();
            }
        }

#endif
        #endregion

    }
}
