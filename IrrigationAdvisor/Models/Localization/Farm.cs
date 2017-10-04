using IrrigationAdvisor.Models.Agriculture;
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
        private List<UserFarm> userFarmList;

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

        public List<UserFarm> UserFarmList
        {
            get { return userFarmList; }
            set { userFarmList = value; }
        }

        public virtual Position Position
        {
            get;
            set;
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
            this.UserFarmList = new List<UserFarm>();
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
                    long pCityId, List<UserFarm> pUserFarmList)
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
            this.UserFarmList = pUserFarmList;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        
        #region Bomb

        /// <summary>
        /// New ID for BombList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewBombListId()
        {
            long lReturn = 1;
            if (this.BombList != null && this.BombList.Count > 0)
            {
                lReturn += this.BombList.Max(bo => bo.BombId);
            }
            return lReturn;
        }

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
        /// New ID for SoilList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewSoilListId()
        {
            long lReturn = 1;
            if (this.SoilList != null && this.SoilList.Count > 0)
            {
                lReturn += this.SoilList.Max(so => so.SoilId);
            }
            return lReturn;
        }

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
        public Soil AddSoil(String pName, String pShortName, String pDescription, long pPositionId,
                            DateTime pTestDate, double pDepthLimit, long pFarmId)
        {
            Soil lReturn = null;
            long lIdSoil = this.GetNewSoilListId();
            Soil lSoil = new Soil(lIdSoil, pName,pShortName, pDescription, pPositionId, pTestDate, pDepthLimit, pFarmId);
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
        /// <param name="pShortName"></param>
        /// <param name="pDescription"></param>
        /// <param name="pLocation"></param>
        /// <param name="pTestDate"></param>
        /// <param name="pDepthLimit"></param>
        /// <param name="pFarmId"></param>
        /// <returns></returns>
        public Soil UpdateSoil(String pName, String pShortName, String pDescription, long pPositionId,
                            DateTime pTestDate, double pDepthLimit, long pFarmId)
        {
            Soil lReturn = null;
            Soil lSoil = new Soil(this.GetNewSoilListId(), pName, pShortName, pDescription, pPositionId, pTestDate, pDepthLimit, pFarmId);
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
        /// New ID for IrrigationUnitList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewIrrigationUnitListId()
        {
            long lReturn = 1;
            if (this.IrrigationUnitList != null && this.IrrigationUnitList.Count > 0)
            {
                lReturn += this.IrrigationUnitList.Max(iu => iu.IrrigationUnitId);
            }
            return lReturn;
        }

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
            long lIdIrrigationUnit = this.GetNewIrrigationUnitListId();
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
            IrrigationUnit lIrrigationUnit = new IrrigationUnit(this.GetNewIrrigationUnitListId(), pName, pShortName,
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
        /// New ID for UserFarmList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewUserFarmListId()
        {
            long lReturn = 1;
            if (this.UserFarmList != null && this.UserFarmList.Count > 0)
            {
                lReturn += this.UserFarmList.Max(uf => uf.UserFarmId);
            }
            return lReturn;
        }

        /// <summary>
        /// Return if the User exists in UserFarm List,
        /// else null
        /// </summary>
        /// <param name="pUser"></param>
        /// <returns></returns>
        public User ExistUser(User pUser)
        {
            User lReturn = null;
            foreach (UserFarm item in this.UserFarmList)
            {
                if (item.User.Equals(pUser))
                {
                    lReturn = item.User;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Return if the UserId exists in UserFarm List,
        /// else null
        /// </summary>
        /// <param name="pUser"></param>
        /// <returns></returns>
        public long ExistUser(long pUserId)
        {
            long lReturn = 0;
            foreach (UserFarm item in this.UserFarmList)
            {
                if (item.UserId.Equals(pUserId))
                {
                    lReturn = item.UserId;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a UserFarm to User Farm List creating new User,
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
        public UserFarm AddUser(long pUserId, String pName, String pSurname, String pPhone, String pAddress,
                            String pEmail, long pRoleId, String pUserName, String pPassword)
        {
            UserFarm lReturn = null;
            long lUserFarmId = this.GetNewUserFarmListId();
            User lUser = new User(pUserId, pName, pSurname, pPhone, 
                                    pAddress, pEmail, pRoleId, 
                                    pUserName, pPassword);
            String lUserFarmName = lUser.Name + this.Name;
            UserFarm lUserFarm = new UserFarm(lUserFarmId, lUser, this,
                                lUserFarmName, DateTime.Now);
            if (ExistUserFarm(lUserFarm) == null)
            {
                this.UserFarmList.Add(lUserFarm);
                lReturn = lUserFarm;
            }
            return lReturn;
        }

        /// <summary>
        /// Return if the UserId exists in UserFarm List,
        /// else null
        /// </summary>
        /// <param name="pUser"></param>
        /// <returns></returns>
        public UserFarm ExistUserFarm(UserFarm pUserFarm)
        {
            UserFarm lReturn = null;
            foreach (UserFarm item in this.UserFarmList)
            {
                if (item.Equals(pUserFarm))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a UserFarm to User Farm List,
        /// If exists return null
        /// </summary>
        /// <param name="pUser"></param>
        /// <param name="pFarm"></param>
        /// <param name="pName"></param>
        /// <param name="pStartDate"></param>
        /// <returns></returns>
        public UserFarm AddUserFarm(User pUser, Farm pFarm,
                        String pName, DateTime pStartDate)
        {
            UserFarm lReturn = null;
            long lUserFarmId = this.GetNewUserFarmListId();
            String lUserFarmName = pUser.Name + pFarm.Name;
            UserFarm lUserFarm = new UserFarm(lUserFarmId, pUser, pFarm,
                                lUserFarmName, DateTime.Now);
            if (ExistUserFarm(lUserFarm) == null)
            {
                this.UserFarmList.Add(lUserFarm);
                lReturn = lUserFarm;
            }
            return lReturn;
        }

        /// <summary>
        /// Update the UserFarm from User Farm List,
        /// If do not exists return null
        /// </summary>
        /// <param name="pUser"></param>
        /// <param name="pFarm"></param>
        /// <param name="pName"></param>
        /// <param name="pStartDate"></param>
        /// <returns></returns>
        public UserFarm UpdateUserFarm(User pUser, Farm pFarm,
                        String pName, DateTime pStartDate)
        {
            UserFarm lReturn = null;
            UserFarm lUserFarm = new UserFarm(this.GetNewUserFarmListId(), pUser, pFarm, pName, pStartDate);
            lReturn = ExistUserFarm(lUserFarm);
            if (lReturn != null)
            {
                lReturn.UserId = pUser.UserId;
                lReturn.FarmId = pFarm.FarmId;
                lReturn.Name = pName;
                lReturn.StartDate = pStartDate;
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