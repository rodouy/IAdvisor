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

        public String Name { get; set; }

        public String Company { get; set; }

        public String Address { get; set; }

        public String Phone { get; set; }

        public long PositionId { get; set; }
        
        public int Has { get; set;}

        public long WeatherStationId { get; set; }

        public WeatherStationViewModel WeatherStationViewModel { get; set; }

        public List<BombViewModel> BombViewModelList { get; set; }

        public List<IrrigationUnitViewModel> IrrigationUnitViewModelList { get; set; }

        public List<UserViewModel> UserViewModelList { get; set; }

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

            this.BombViewModelList = this.GetBombListBy(pFarm.BombList);
            this.IrrigationUnitViewModelList = this.GetIrrigationUnitListBy(pFarm.IrrigationUnitList);
            this.UserViewModelList = this.GetUserListBy(pFarm.UserFarmList);

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