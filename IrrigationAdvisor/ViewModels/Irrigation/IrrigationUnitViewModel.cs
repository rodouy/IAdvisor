using IrrigationAdvisor.DBContext.Irrigation;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Irrigation
{
    public class IrrigationUnitViewModel
    {

        #region Consts
        #endregion

        #region Fields

        #endregion

        #region Properties

        public long IrrigationUnitId { get; set; }

        public String Name { get; set; }

        public Utils.IrrigationUnitType IrrigationType { get; set; }

        public Double IrrigationEfficiency { get; set; }

        public List<Pair<DateTime, double>> IrrigationList { get; set; }

        public Double Surface { get; set; }

        public long BombId { get; set; }

        public BombViewModel Bomb { get; set; }

        public long PositionId { get; set; }

        public Double PredeterminatedIrrigationQuantity { get; set; }


        #endregion

        #region Construction

        public IrrigationUnitViewModel(IrrigationUnit pIrrigationUnit)
        {
            this.IrrigationUnitId = pIrrigationUnit.IrrigationUnitId;
            this.Name = pIrrigationUnit.Name;
            this.IrrigationType = pIrrigationUnit.IrrigationType;
            this.IrrigationEfficiency = pIrrigationUnit.IrrigationEfficiency;
            this.IrrigationList = pIrrigationUnit.IrrigationList;
            this.Surface = pIrrigationUnit.Surface;
            this.BombId = pIrrigationUnit.BombId;
            this.Bomb = new BombViewModel(pIrrigationUnit.Bomb);
            this.PositionId = pIrrigationUnit.PositionId;
            this.PredeterminatedIrrigationQuantity = pIrrigationUnit.PredeterminatedIrrigationQuantity;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        #endregion

        #region Overrides
        #endregion

    }
}