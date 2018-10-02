using IrrigationAdvisor.DBContext.Irrigation;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Localization;
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

        public bool Show { get; set; }

        public Position Position { get; set; }

        public Double PredeterminatedIrrigationQuantity { get; set; }

        public long FarmId { get; set; }

        public Farm Farm { get; set; }
        public List<System.Web.Mvc.SelectListItem> Farms { get; set; }


        public String ShortName { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public List<System.Web.Mvc.SelectListItem> IrrigationTypes { get; set; }

        #endregion

        #region Construction
        public IrrigationUnitViewModel()
        {
        }
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
            this.Position = pIrrigationUnit.Position;
            this.PredeterminatedIrrigationQuantity = pIrrigationUnit.PredeterminatedIrrigationQuantity;
            this.FarmId = pIrrigationUnit.FarmId;
            this.Farm = pIrrigationUnit.Farm;
            this.ShortName = pIrrigationUnit.ShortName;
            this.Latitude = pIrrigationUnit.Position.Latitude;
            this.Longitude = pIrrigationUnit.Position.Longitude;
            this.Show = pIrrigationUnit.Show;


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