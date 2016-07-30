﻿using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.Models.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Utilities;


namespace IrrigationAdvisor.Models.Localization
{
    /// <summary>
    /// Create: 2015-01-15
    /// Author: rodouy 
    /// Description: 
    ///     Farm Class represent the land of the user with all his elements
    ///     
    /// References:
    ///     list of classes this class use
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: UnitTest Farm
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - farmId long - PK (Primary Key)
    ///     - name String
    ///     - address String
    ///     - phone String
    ///     - location Location
    ///     - has int
    ///     - soilList List<Soil>
    ///     - lBombList List<Bomb>
    ///     - weatherStation WeatherStation
    ///     - irrigationUnitList List<IrrigationUnit>
    ///     - userList List<User>
    /// 
    /// Methods:
    ///     - Farm()      -- constructor
    ///     - Farm(name, address, phone, location, user)  -- consturctor with parameters
    ///     
    /// </summary>
    public class Farm
    {

        #region Consts
        #endregion

        #region Fields

        private long farmId;
        private String name;
        private String company;
        private String address;
        private String phone;
        private long positionId;
        private int has;
        private long weatherStationId;
        private List<Soil> soilList;
        private List<Bomb> bombList;
        private List<IrrigationUnit> irrigationUnitList;
        private long cityId;
        private List<User> userList;

        #endregion

        #region Properties

        public long FarmId
        {
            get { return farmId; }
            set { farmId = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Company
        {
            get { return company; }
            set { company = value; }
        }
        
        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public long PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }

        public int Has
        {
            get { return has; }
            set { has = value; }
        }

        public long WeatherStationId
        {
            get { return weatherStationId; }
            set { weatherStationId = value; }
        }

        public virtual WeatherStation WeatherStation
        {
            get;
            set;
        }
        
        public List<Soil> SoilList
        {
            get { return soilList; }
            set { soilList = value; }
        }

        public List<Bomb> BombList
        {
            get { return bombList; }
            set { bombList = value; }
        }
        
        public List<IrrigationUnit> IrrigationUnitList
        {
            get { return irrigationUnitList; }
            set { irrigationUnitList = value; }
        }

        public long CityId
        {
            get { return cityId; }
            set { cityId = value; }
        }

        public virtual City City
        {
            get;
            set;
        }

        public List<User> UserList
        {
            get { return userList; }
            set { userList = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor of Farm
        /// </summary>
        public Farm()
        {
            this.FarmId = 0;
            this.Name = "NoName";
            this.Address = "";
            this.Phone = "";
            this.PositionId = 0;
            this.Has = 0;
            this.WeatherStationId = 0;
            this.SoilList = new List<Soil>();
            this.BombList = new List<Bomb>();
            this.IrrigationUnitList = new List<IrrigationUnit>();
            this.CityId = 0;
            this.UserList = new List<User>();
        }

        /// <summary>
        /// Constructor of Farm with parameters
        /// </summary>
        /// <param name="pFarmId"></param>
        /// <param name="pName"></param>
        /// <param name="pCompany"></param>
        /// <param name="pAddress"></param>
        /// <param name="pPhone"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pHas"></param>
        /// <param name="pWeatherStationId"></param>
        /// <param name="pSoilList"></param>
        /// <param name="pBombList"></param>
        /// <param name="pIrrigationUnitList"></param>
        /// <param name="pCityId"></param>
        /// <param name="pUserList"></param>
        public Farm(long pFarmId, String pName, String pCompany,
                    String pAddress,String pPhone, long pPositionId, 
                    int pHas, long pWeatherStationId,
                    List<Soil> pSoilList, List<Bomb> pBombList,
                    List<IrrigationUnit> pIrrigationUnitList, 
                    long pCityId, List<User> pUserList)
        {
            this.FarmId = pFarmId;
            this.Name = pName;
            this.Company = pCompany;
            this.Address = pAddress;
            this.Phone = pPhone;
            this.PositionId = pPositionId;
            this.Has = pHas;
            this.WeatherStationId = pWeatherStationId;
            this.SoilList = pSoilList;
            this.BombList = pBombList;
            this.IrrigationUnitList = pIrrigationUnitList;
            this.CityId = pCityId;
            this.UserList = pUserList;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        
        #region Bomb

        /// <summary>
        /// Return if the Bomb exists in Farm Bomb List,
        /// else null
        /// </summary>
        /// <param name="pBomb"></param>
        /// <returns></returns>
        public Bomb ExistBomb(Bomb pBomb)
        {
            Bomb lReturn = null;
            if (pBomb != null)
            {
                foreach (Bomb item in this.BombList)
                {
                    if (item.Equals(pBomb))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a Bomb to Farm Bomb List,
        /// If exists return null
        /// </summary>
        /// <param name="pBomb"></param>
        public Bomb AddBomb(Bomb pBomb)
        {
            Bomb lRetrurn = null;
            if(ExistBomb(pBomb) == null)
            {
                BombList.Add(pBomb);
                lRetrurn = pBomb;
            }
            return lRetrurn;
        }

        #endregion

        #region Soil

        /// <summary>
        /// Return if the Soil exists in Farm Soil List,
        /// else null
        /// </summary>
        /// <param name="pSoil"></param>
        /// <returns></returns>
        public Soil ExistSoil(Soil pSoil)
        {
            Soil lReturn = null;
            foreach (Soil item in this.SoilList)
            {
                if(item.Equals(pSoil))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a Soil to Farm Soil List,
        /// If exists return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDescription"></param>
        /// <param name="pLocation"></param>
        /// <param name="pTestDate"></param>
        /// <param name="pDepthLimit"></param>
        /// <returns></returns>
        public Soil AddSoil(String pName, String pDescription, long pPositionId, 
                            DateTime pTestDate, double pDepthLimit)
        {
            Soil lReturn = null;
            long lIdSoil = this.SoilList.Count();
            Soil lSoil = new Soil(lIdSoil, pName, pDescription, pPositionId, pTestDate, pDepthLimit);
            if(ExistSoil(lSoil) == null)
            {
                this.SoilList.Add(lSoil);
                lReturn = lSoil;
            }
            return lReturn;
        }

        /// <summary>
        /// Update the Soil from Farm Soil List,
        /// If do not exists return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDescription"></param>
        /// <param name="pLocation"></param>
        /// <param name="pTestDate"></param>
        /// <param name="pDepthLimit"></param>
        /// <returns></returns>
        public Soil UpdateSoil(String pName, String pDescription, long pPositionId,
                            DateTime pTestDate, double pDepthLimit)
        {
            Soil lReturn = null;
            Soil lSoil = new Soil(0, pName, pDescription, pPositionId, pTestDate, pDepthLimit);
            lReturn = ExistSoil(lSoil);
            if(lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Description = pDescription;
                lReturn.PositionId = pPositionId;
                lReturn.TestDate = pTestDate;
                lReturn.DepthLimit = pDepthLimit;
            }
            return lReturn;
        }

        #endregion

        #region IrrigationUnit

        /// <summary>
        /// Return if the IrrigationUnit exists in Farm IrrigationUnit List,
        /// else null
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <returns></returns>
        public IrrigationUnit ExistIrrigationUnit(IrrigationUnit pIrrigationUnit)
        {
            IrrigationUnit lReturn = null;
            foreach (IrrigationUnit item in this.IrrigationUnitList)
            {
                if(item.Equals(pIrrigationUnit))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a IrrigationUnit to Farm IrrigationUnit List,
        /// If exists return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pShortName"></param>
        /// <param name="pIrrigationType"></param>
        /// <param name="pIrrigationEfficiency"></param>
        /// <param name="pIrrigationList"></param>
        /// <param name="pSurface"></param>
        /// <param name="pBombId"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pPredeterminatedIrrigationQuantity"></param>
        /// <returns></returns>
        public IrrigationUnit AddIrrigationUnit(String pName, String pShortName, Utils.IrrigationUnitType pIrrigationType, 
                                    double pIrrigationEfficiency, List<Pair<DateTime, double>> pIrrigationList,
                                    double pSurface, long pBombId, long pPositionId, Double pPredeterminatedIrrigationQuantity)
        {
            IrrigationUnit lReturn = null;
            long lIdIrrigationUnit = this.IrrigationUnitList.Count();
            IrrigationUnit lIrrigationUnit = new IrrigationUnit(lIdIrrigationUnit, pName,
                                            pShortName, pIrrigationType, pIrrigationEfficiency,
                                            pIrrigationList, pSurface, pBombId, pPositionId,
                                            pPredeterminatedIrrigationQuantity);
            if(ExistIrrigationUnit(lIrrigationUnit) == null)
            {
                this.IrrigationUnitList.Add(lIrrigationUnit);
                lReturn = lIrrigationUnit;
            }
            return lReturn;
        }

        /// <summary>
        /// Update the IrrigationUnit from Farm IrrigationUnit List,
        /// If do not exists return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pShortName"></param>
        /// <param name="pIrrigationType"></param>
        /// <param name="pIrrigationEfficiency"></param>
        /// <param name="pIrrigationList"></param>
        /// <param name="pSurface"></param>
        /// <param name="pBombId"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pPredeterminatedIrrigationQuantity"></param>
        /// <returns></returns>
        public IrrigationUnit UpdateIrrigationUnit(String pName, String pShortName, Utils.IrrigationUnitType pIrrigationType,
                                    double pIrrigationEfficiency, List<Pair<DateTime, double>> pIrrigationList,
                                    double pSurface, long pBombId, long pPositionId, Double pPredeterminatedIrrigationQuantity)
        {
            IrrigationUnit lReturn = null;
            IrrigationUnit lIrrigationUnit = new IrrigationUnit(0, pName, pShortName,
                                            pIrrigationType, pIrrigationEfficiency,
                                            pIrrigationList, pSurface, pBombId, pPositionId, 
                                            pPredeterminatedIrrigationQuantity);
            lReturn = ExistIrrigationUnit(lIrrigationUnit);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.ShortName = pShortName;
                lReturn.IrrigationType = pIrrigationType;
                lReturn.IrrigationEfficiency = pIrrigationEfficiency;
                lReturn.IrrigationList = pIrrigationList;
                lReturn.Surface = pSurface;
                lReturn.BombId = pBombId;
                lReturn.PositionId = pPositionId;
                lReturn.PredeterminatedIrrigationQuantity = pPredeterminatedIrrigationQuantity;
            }
            return lReturn;
        }

        #endregion

        #region User

        /// <summary>
        /// Return if the User exists in Farm User List,
        /// else null
        /// </summary>
        /// <param name="pUser"></param>
        /// <returns></returns>
        public User ExistUser(User pUser)
        {
            User lReturn = null;
            foreach (User item in this.UserList)
            {
                if (item.Equals(pUser))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a User to Farm Administrator List,
        /// If exists return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSurname"></param>
        /// <param name="pPhone"></param>
        /// <param name="pAddress"></param>
        /// <param name="pEmail"></param>
        /// <param name="pRoleId"></param>
        /// <param name="pUserName"></param>
        /// <param name="pPassword"></param>
        /// <returns></returns>
        public User AddUser(String pName, String pSurname, String pPhone, String pAddress, 
                            String pEmail, long pRoleId, String pUserName, String pPassword)
        {
            User lReturn = null;
            long lUserId = this.UserList.Count();
            User lUser = new User(lUserId, pName, pSurname, pPhone, pAddress, 
                                pEmail, pRoleId, pUserName, pPassword);
            if (ExistUser(lUser) == null)
            {
                this.UserList.Add(lUser);
                lReturn = lUser;
            }
            return lReturn;
        }

        /// <summary>
        /// Update the User from Farm Administrator List,
        /// If do not exists return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSurname"></param>
        /// <param name="pPhone"></param>
        /// <param name="pAddress"></param>
        /// <param name="pEmail"></param>
        /// <param name="pRoleId"></param>
        /// <param name="pUserName"></param>
        /// <param name="pPassword"></param>
        /// <returns></returns>
        public User UpdateUser(String pName, String pSurname, String pPhone, String pAddress,
                            String pEmail, long pRoleId, String pUserName, String pPassword)
        {
            User lReturn = null;
            User lUser = new User(0, pName, pSurname, pPhone, pAddress,
                                pEmail, pRoleId, pUserName, pPassword);
            lReturn = ExistUser(lUser);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Surname = pSurname;
                lReturn.Phone = pPhone;
                lReturn.Address = pAddress;
                lReturn.Email = pEmail;
                lReturn.RoleId = pRoleId;
                lReturn.UserName = pUserName;
                lReturn.Password = pPassword;
            }
            return lReturn;
        }

        #endregion

        #endregion

        #region Overrides

        /// <summary>
        /// Overrides equals, Name, PositionId And UserId
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            Farm lFarm = obj as Farm;
            return this.Name.Equals(lFarm.Name)
                && this.PositionId.Equals(lFarm.PositionId)
                && this.WeatherStationId.Equals(lFarm.WeatherStationId);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        
        #endregion

    }
}