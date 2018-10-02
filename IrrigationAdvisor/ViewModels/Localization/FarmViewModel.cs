using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.ViewModels.Irrigation;
using IrrigationAdvisor.ViewModels.Security;
using IrrigationAdvisor.ViewModels.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using IrrigationAdvisor.Models.Weather;

namespace IrrigationAdvisor.ViewModels.Localization
{
    public class FarmViewModel
    {

        #region Consts
        #endregion

        #region Fields

        #endregion

        #region Properties

        public long FarmId { get; set; }

        [Display(Name = "Nombre")]
         public String Name { get; set; }
        
        [Display(Name = "Empresa")]
        public String Company { get; set; }

        [Display(Name = "Dirección")]
        public String Address { get; set; }

        [Display(Name = "Teléfono")]
        public String Phone { get; set; }

        public long PositionId { get; set; }

        [Display(Name = "Hectareas")]
        public int Has { get; set; }

        [Display(Name = "Estación")]
        public long WeatherStationId { get; set; }

        [Display(Name = "Estacíon")]
        public List<System.Web.Mvc.SelectListItem> WeatherStations { get; set; }

        public List<BombViewModel> BombViewModelList { get; set; }

        public List<IrrigationUnitViewModel> IrrigationUnitViewModelList { get; set; }

        public List<UserViewModel> UserViewModelList { get; set; }

        public List<System.Web.Mvc.SelectListItem> Cities{ get; set; }

        public City City { get; set; }

        public WeatherStation WeatherStation { get; set; }

        [Display(Name = "Ciudad")]
        public long CityId { get; set; }

        [Display(Name = "Mostrar balance hídrico")]
        public bool IrrigationUnitReportShowAvailableWater { get; set; }

        [Display(Name = "Mostrar ETC")]
        public bool IrrigationUnitReportShowEvapotranspiration { get; set; }

        [Display(Name = "Mostrar temperatura")]
        public bool  IrrigationUnitReportShowTemperature { get; set; }

        public List<System.Web.Mvc.SelectListItem> Countries { get; set; }
        


        #endregion

        #region Construction
        
        public FarmViewModel(Farm pFarm)
        {
            this.FarmId = pFarm.FarmId;
            this.Name = pFarm.Name;
            this.Company = pFarm.Company;
            this.Address = pFarm.Address;
            this.Phone = pFarm.Phone;
            this.PositionId = pFarm.PositionId;
            this.Has = pFarm.Has;
            this.WeatherStationId = pFarm.WeatherStationId;
            this.CityId = pFarm.CityId;
            this.BombViewModelList = this.GetBombListBy(pFarm.BombList);
            this.IrrigationUnitViewModelList = this.GetIrrigationUnitListBy(pFarm.IrrigationUnitList);
            this.UserViewModelList = this.GetUserListBy(pFarm.UserFarmList);
            this.IrrigationUnitReportShowAvailableWater = pFarm.IrrigationUnitReportShowAvailableWater;
            this.IrrigationUnitReportShowEvapotranspiration = pFarm.IrrigationUnitReportShowEvapotranspiration;
            this.IrrigationUnitReportShowTemperature = pFarm.IrrigationUnitReportShowTemperature;
            this.City = pFarm.City;
            this.WeatherStation = pFarm.WeatherStation;

        }

        #endregion

        #region Private Helpers

        #endregion

        #region Public Methods

        /// <summary>
        /// Get BombViewModel list by Bomb list
        /// </summary>
        /// <param name="pBombList"></param>
        /// <returns></returns>
        public List<BombViewModel> GetBombListBy (List<Bomb> pBombList)
        {
            List<BombViewModel> lReturn = new List<BombViewModel>();

            if(pBombList != null && pBombList.Count() > 0)
            {
                foreach (Bomb item in pBombList)
                {
                    BombViewModel lBomb = new BombViewModel(item);
                    lReturn.Add(lBomb);
                }
            }

            return lReturn;
        }

        /// <summary>
        /// Get IrrigationUnitViewModel list by IrrigationUnit list
        /// Only if Show is true
        /// </summary>
        /// <param name="pIrrigationUnitList"></param>
        /// <returns></returns>
        public List<IrrigationUnitViewModel> GetIrrigationUnitListBy(List<IrrigationUnit> pIrrigationUnitList)
        {
            List<IrrigationUnitViewModel> lReturn = new List<IrrigationUnitViewModel>();

            if(pIrrigationUnitList !=null && pIrrigationUnitList.Count() > 0)
            {
                foreach (IrrigationUnit item in pIrrigationUnitList)
                {
                    if(item.Show)
                    {
                        IrrigationUnitViewModel lIrrigationUnit = new IrrigationUnitViewModel(item);
                        lReturn.Add(lIrrigationUnit);
                    }
                }
            }

            return lReturn;
        }

        /// <summary>
        /// Set IrrigationUnitViewModel list by IrrigationUnit list
        /// </summary>
        /// <param name="pIrrigationUnitList"></param>
        /// <returns></returns>
        public List<IrrigationUnitViewModel> SetIrrigationUnitListBy(List<IrrigationUnit> pIrrigationUnitList)
        {
            List<IrrigationUnitViewModel> lReturn = new List<IrrigationUnitViewModel>();

            if (pIrrigationUnitList != null && pIrrigationUnitList.Count() > 0)
            {
                foreach (IrrigationUnit item in pIrrigationUnitList)
                {
                    IrrigationUnitViewModel lIrrigationUnit = new IrrigationUnitViewModel(item);
                    lReturn.Add(lIrrigationUnit);
                }
            }
            this.IrrigationUnitViewModelList = lReturn;
            return lReturn;
        }

        /// <summary>
        /// Get UserViewModelList list by User list
        /// </summary>
        /// <param name="pUserList"></param>
        /// <returns></returns>
        public List<UserViewModel> GetUserListBy(List<UserFarm> pUserFarmList)
        {
            List<UserViewModel> lReturn = new List<UserViewModel>();

            if(pUserFarmList != null && pUserFarmList.Count() > 0)
            {
                foreach (UserFarm item in pUserFarmList)
                {
                    UserViewModel lUser = new UserViewModel(item.User);
                    lReturn.Add(lUser);
                }
            }

            return lReturn;
        }

        #endregion

        #region Overrides
        #endregion

    }
}