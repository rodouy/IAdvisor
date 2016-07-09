using IrrigationAdvisor.Models.Irrigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Irrigation
{
    public class BombViewModel
    {

        #region Consts
        #endregion

        #region Fields

        #endregion

        #region Properties

        public long BombId { get; set; }

        public String Name { get; set; }

        public String SerialNumber { get; set; }

        public DateTime ServiceDate { get; set; }

        public DateTime PurchaseDate { get; set; }

        public long PositionId { get; set; }

        #endregion

        #region Construction

        public BombViewModel(Bomb pBomb)
        {
            this.BombId = pBomb.BombId;
            this.Name = pBomb.Name;
            this.SerialNumber = pBomb.SerialNumber;
            this.ServiceDate = pBomb.ServiceDate;
            this.PurchaseDate = pBomb.PurchaseDate;
            this.PositionId = pBomb.PositionId;
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