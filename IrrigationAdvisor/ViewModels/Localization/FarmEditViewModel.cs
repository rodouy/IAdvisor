using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using IrrigationAdvisor.ViewModels.Localization;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.ViewModels.Irrigation;
using IrrigationAdvisor.Models.Irrigation;

namespace IrrigationAdvisor.ViewModels.Wizard
{
    public class FarmEditViewModel 
    {
        [Required]
        public long FarmId { get; set; }
       [Required]
        public String Name { get; set; }

        [Required]
        public String Company { get; set; }

        public String Address { get; set; }

        [Required]
        public String Phone { get; set; }

        [Required]
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "Ingrese latitud válida")]
        public double Latitude { get; set; }

        [Required]
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "Ingrese longitud válida")]
        public double Longitude { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Ingrese cantidad de hectareas válidas")]
        public int Has { get; set; }

        [Required]
        public long CityId { get; set; }

        [Required]
        public long WeatherStationId { get; set; }

        public List<System.Web.Mvc.SelectListItem> City { get; set; }

        
        public List<System.Web.Mvc.SelectListItem> WeatherStation { get; set; }

        [Required]
        public long PositionId { get; set; }

        public List<BombViewModel> BombViewModelList { get; set; }




        public FarmEditViewModel(Farm pFarm)
        {
            this.WeatherStation = new List<System.Web.Mvc.SelectListItem>();
            this.City = new List<System.Web.Mvc.SelectListItem>();
            this.FarmId = pFarm.FarmId;
            this.Name = pFarm.Name;
            this.Company = pFarm.Company;
            this.Address = pFarm.Address;
            this.Phone = pFarm.Phone;
            this.PositionId = pFarm.PositionId;
            this.Has = pFarm.Has;
            this.WeatherStationId = pFarm.WeatherStationId;

            this.BombViewModelList = this.GetBombListBy(pFarm.BombList);
            //this.IrrigationUnitViewModelList = this.GetIrrigationUnitListBy(pFarm.IrrigationUnitList);
            //this.UserViewModelList = this.GetUserListBy(pFarm.UserFarmList);

        }

        /// <summary>
        /// Get BombViewModel list by Bomb list
        /// </summary>
        /// <param name="pBombList"></param>
        /// <returns></returns>
        public List<BombViewModel> GetBombListBy(List<Bomb> pBombList)
        {
            List<BombViewModel> lReturn = new List<BombViewModel>();

            if (pBombList != null && pBombList.Count() > 0)
            {
                foreach (Bomb item in pBombList)
                {
                    BombViewModel lBomb = new BombViewModel(item);
                    lReturn.Add(lBomb);
                }
            }

            return lReturn;
        }
      



    }

}