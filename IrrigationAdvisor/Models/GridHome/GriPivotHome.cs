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
        private long cropIrrigationWeatherId;
        private String irrigationUnitName;
        private String cropName;
        private String sowingDate;
        private String phenologyName;
        private String hydricBalance;
        private String cropCoefficient;
        private bool isAdministrator;
        private List<GridPivotDetailHome> listGridPivotDetailHome;
        private List<double> listEtc;

        #endregion

        #region Properties
        public long CropIrrigationWeatherId
        {
            get { return cropIrrigationWeatherId; }
            set
            {
                cropIrrigationWeatherId = value;
            }
        }
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

        public String HydricBalance
        {
            get { return hydricBalance; }
            set
            {
                hydricBalance = value;
            }
        }

        public String CropCoefficient
        {
            get { return cropCoefficient; }
            set
            {
                cropCoefficient = value;
            }
        }

        public bool IsAdministrator
        {
            get { return isAdministrator; }
            set
            {
                isAdministrator = value;
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

        public List<double> ListEtc
        {
            get { return listEtc; }
            set
            {
                listEtc = value;
            }
        }

        #endregion


        public GridPivotHome(String pIrrigationUnitName, 
                            String pCropName, 
                            String pSowingDate, 
                            String pPhenologyName, 
                            String pHydricBalance, 
                            String pCropCoefficient,
                            bool pIsAdministratror,
                            List<double> pEtcs,
                            List<GridPivotDetailHome> plistGridPivotDetailHome,
                            long pCropIrrigationWeatherId)
        {
            this.IrrigationUnitName = pIrrigationUnitName;
            this.CropName = pCropName;
            this.SowingDate = pSowingDate;
            this.PhenologyName = pPhenologyName;
            this.hydricBalance = pHydricBalance;
            this.CropCoefficient = pCropCoefficient;
            this.IsAdministrator = pIsAdministratror;
            this.ListEtc = pEtcs;
            this.ListGridPivotDetailHome = plistGridPivotDetailHome;
            this.CropIrrigationWeatherId = pCropIrrigationWeatherId;
        }


    }
}