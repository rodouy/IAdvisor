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
        private String irrigationUnitName;
        private String cropName;
        private String sowingDate;
        private String phenologyName;
        private List<GridPivotDetailHome> listGridPivotDetailHome;

        #endregion

        #region Properties

        public String IrrigationUnitName
        {
            get { return irrigationUnitName; }
            set
            {
                irrigationUnitName = value;
            }
        }

        public String CropName
        {
            get { return cropName; }
            set
            {
                cropName = value;
            }
        }

        public String SowingDate
        {
            get { return sowingDate; }
            set
            {
                sowingDate = value;
            }
        }

        public String PhenologyName
        {
            get { return phenologyName; }
            set
            {
                phenologyName = value;
            }
        }

        public List<GridPivotDetailHome> ListGridPivotDetailHome
        {
            get { return listGridPivotDetailHome; }
            set
            {
                listGridPivotDetailHome = value;
            }
        }

        #endregion


        public GridPivotHome(String pIrrigationUnitName, String pCropName, String pSowingDate, String pPhenologyName, 
                            List<GridPivotDetailHome> plistGridPivotDetailHome)
        {
            this.IrrigationUnitName = pIrrigationUnitName;
            this.CropName = pCropName;
            this.SowingDate = pSowingDate;
            this.PhenologyName = pPhenologyName;
            this.ListGridPivotDetailHome = plistGridPivotDetailHome;
        }


    }
}