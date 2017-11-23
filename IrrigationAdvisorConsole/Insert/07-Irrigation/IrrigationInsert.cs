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
                        Show = true,
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
                        Show = true,
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
                        Show = true,
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
                        Show = true,
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
                        Show = false,
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
                        Show = true,
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
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
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
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmDelLagoSanPedro
                             select f).FirstOrDefault();

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
                        Show = false,
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
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 60,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 30,
                        Show = false,
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
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 110,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 55,
                        Show = false,
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
                        IrrigationEfficiency = 0.85,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 32,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        Radius = 16,
                        Show = false,
                        FarmId = lFarm.FarmId,
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
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
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
                        Show = true,
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
                        Show = true,
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
                        Show = true,
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
                        Show = true,
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
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
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
                        Show = true,
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmLaRinconada
                             select f).FirstOrDefault();

                    #region Pivot 1
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
                    #region Pivot 2
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
                        Show = true,
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
                        Show = true,
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
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
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
                        Show = true,
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
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    context.Pivots.Add(lElRinconPivot1a);
                    context.Pivots.Add(lElRinconPivot1b);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Pivots El Desafio
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
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
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LosNaranjales)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lFarm = (from f in context.Farms
                             where f.Name == Utils.NameFarmLosNaranjales
                             select f).FirstOrDefault();

                    #region Pivot 1a
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLosNaranjales
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLosNaranjales1a
                                 select pos).FirstOrDefault();

                    var lLosNaranjalesPivot1a = new Pivot
                    {
                        Name = Utils.NamePivotLosNaranjales1a,
                        ShortName = "Pivot 1a",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.70,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 25,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 12,
                        Radius = 12,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 1b
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLosNaranjales
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLosNaranjales1b
                                 select pos).FirstOrDefault();

                    var lLosNaranjalesPivot1b = new Pivot
                    {
                        Name = Utils.NamePivotLosNaranjales1b,
                        ShortName = "Pivot 1b",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.70,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 25,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 12,
                        Radius = 12,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2a
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLosNaranjales
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLosNaranjales2a
                                 select pos).FirstOrDefault();

                    var lLosNaranjalesPivot2a = new Pivot
                    {
                        Name = Utils.NamePivotLosNaranjales2a,
                        ShortName = "Pivot 2a",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.70,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 25,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 12,
                        Radius = 12,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion
                    #region Pivot 2b
                    lBomb = (from b in context.Bombs
                             where b.Name == Utils.NameBombLosNaranjales
                             select b).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionPivotLosNaranjales2b
                                 select pos).FirstOrDefault();

                    var lLosNaranjalesPivot2b = new Pivot
                    {
                        Name = Utils.NamePivotLosNaranjales2b,
                        ShortName = "Pivot 2b",
                        IrrigationType = Utils.IrrigationUnitType.Pivot,
                        IrrigationEfficiency = 0.70,
                        IrrigationList = new List<Pair<DateTime, double>>(),
                        Surface = 25,
                        BombId = lBomb.BombId,
                        PositionId = lPosition.PositionId,
                        PredeterminatedIrrigationQuantity = 12,
                        Radius = 12,
                        Show = true,
                        FarmId = lFarm.FarmId,
                    };
                    #endregion

                    context.Pivots.Add(lLosNaranjalesPivot1a);
                    context.Pivots.Add(lLosNaranjalesPivot1b);
                    context.Pivots.Add(lLosNaranjalesPivot2a);
                    context.Pivots.Add(lLosNaranjalesPivot2b);
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmDCAElParaiso();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmDCALaPerdiz();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmDelLagoSanPedro();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmGMOLaPalma();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmGMOElTacuru();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmTresMarias();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmLaRinconada();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElRincon)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmElRincon();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElDesafio)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmElDesafio();
            }
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LosNaranjales)
            {
                LocalizationInsert.UpdateSoilsBombsIrrigationUnitsUsersFarmLosNaranjales();
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
                context.Crops.Add(lCropAlfalfaSouthShort);
                context.Crops.Add(lCropAlfalfaSouthMedium);
                context.Crops.Add(lCropAlfalfaNorthShort);
                context.Crops.Add(lCropAlfalfaNorthMedium);
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

                context.CropInformationByDates.Add(lCornSouthShort);
                context.CropInformationByDates.Add(lCornSouthMedium);
                context.CropInformationByDates.Add(lSoyaSouthShort);
                context.CropInformationByDates.Add(lSoyaSouthMedium);
                context.CropInformationByDates.Add(lAlfalfaSouthShort);
                context.CropInformationByDates.Add(lAlfalfaSouthMedium);
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

                context.CropInformationByDates.Add(lCornNorthShort);
                context.CropInformationByDates.Add(lCornNorthMedium);
                context.CropInformationByDates.Add(lSoyaNorthShort);
                context.CropInformationByDates.Add(lSoyaNorthMedium);
                context.CropInformationByDates.Add(lAlfalfaNorthShort);
                context.CropInformationByDates.Add(lAlfalfaNorthMedium);
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
