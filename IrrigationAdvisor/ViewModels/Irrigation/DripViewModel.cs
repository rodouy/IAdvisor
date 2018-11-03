using IrrigationAdvisor.Models.Irrigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Irrigation
{
    public class DripViewModel: IrrigationUnitViewModel
    {

        #region Consts
        #endregion

        #region Fields
        #endregion

        #region Properties
        public new long IrrigationUnitId {get; set;}
        public Double Width { get; set; }
        public Double Length { get; set; }
        #endregion

        #region Construction
        public DripViewModel() { }
        public DripViewModel(Drip pDrip)
        {
            this.IrrigationUnitId = pDrip.IrrigationUnitId;
            this.Width = pDrip.Width;
            this.Length = pDrip.Length;
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