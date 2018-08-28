using IrrigationAdvisor.Models.Irrigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Irrigation
{
    public class PivotViewModel: IrrigationUnitViewModel
    {

        #region Consts
        #endregion

        #region Fields
        #endregion

        #region Properties
        public new long IrrigationUnitId {get; set;}
        public Double Radius {get; set;}
        #endregion

        #region Construction
        public PivotViewModel() { }
        public PivotViewModel(Pivot pPivot)
        {
            this.IrrigationUnitId = pPivot.IrrigationUnitId;
            this.Radius = pPivot.Radius;
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