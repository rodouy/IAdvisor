using IrrigationAdvisor.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 

namespace IrrigationAdvisor.Models.GridHome
{

    public class GridPivotHome
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// Fields of Class:
        ///      
        ///
        /// </summary>
        private string irrigationUnitName;
        private string phenologyName;
        private string cropName;
        private List<GridPivotDetailHome> listGridPivotDetailHome;

        #endregion

        #region Properties

        public virtual string IrrigationUnitName
        {
            get { return irrigationUnitName; }
            set
            {
                irrigationUnitName = value;
            }
        }

        public string PhenologyName
        {
            get { return phenologyName; }
            set
            {
                phenologyName = value;
            }
        }

        public string CropName
        {
            get { return cropName; }
            set
            {
                cropName = value;
            }
        }

        public virtual List<GridPivotDetailHome> ListGridPivotDetailHome
        {
            get { return listGridPivotDetailHome; }
            set
            {
                listGridPivotDetailHome = value;
            }
        }

        #endregion


        public GridPivotHome(String pIrrigationUnitName, String pPhenologyName, String pCropName, 
                            List<GridPivotDetailHome> plistGridPivotDetailHome)
        {
            this.IrrigationUnitName = pIrrigationUnitName;
            this.PhenologyName = pPhenologyName;
            this.CropName = pCropName;
            this.ListGridPivotDetailHome = plistGridPivotDetailHome;
        }


    }
}