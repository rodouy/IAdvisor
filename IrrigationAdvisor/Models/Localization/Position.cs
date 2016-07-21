using IrrigationAdvisor.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Localization
{
    /// <summary>
    /// Create: 2014-10-22
    /// Author: rodouy
    /// Description: 
    ///     Class that describes the position (latitude, longitude)
    /// Update: 2014-12-17
    /// Author: rodouy
    /// Description:
    ///     Serilizable class
    ///     
    /// References:
    ///     none
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: Dependencies, getDistance(Position pOrigin, Position pDestiny), UnitTest
    ///     
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - latitude double
    ///     - longitude double
    /// 
    /// Methods:
    ///     - Position()      -- constructor
    ///     - Position(pLatitude double, pLongitude double)  -- consturctor with parameters
    ///     - setPosition(Position)     -- method to set the name field
    ///     - getDistance(pOrigin Position, pDestiny Position) double
    /// 
    /// </summary>
    
    public partial class Position
    {
        #region Consts
        #endregion

        #region Fields
        
        /// <summary>
        /// Fields of Class:
        ///     - latitude double
        ///     - longitude double
        /// </summary>
        private long positionId;
        private String name;
        private Double latitude;
        private Double longitude;
        //First = latitude; Second = longitude
        private Pair<Double, Double> thePosition;

        #endregion

        #region Properties
        /// <summary>
        /// Properties of Class:
        ///     - Latitude double read only
        ///     - Longitude double read only
        /// 
        /// </summary>


        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        
        
        public long PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }

        public virtual double Latitude
        {
            get { return latitude; }
            set 
            {
                latitude = value;
                if(this.ThePosition == null)
                {
                    this.thePosition = new Pair<Double, Double>(0, 0);
                }
                this.thePosition.First = latitude;
            }
        }

        public virtual double Longitude
        {
            get { return longitude; }
            set 
            {
                longitude = value;
                if (this.ThePosition == null)
                {
                    this.thePosition = new Pair<Double, Double>(0, 0);
                }
                this.thePosition.Second = longitude;
            }
        }

        public Pair<double, double> ThePosition
        {
            get { return thePosition; }
        }

        #endregion

        #region Construction
        /// <summary>
        /// Constructors of Position
        /// </summary>
        public Position()
        {
            this.PositionId = 0;
            this.Name = "noname";
            this.Latitude = 0;
            this.Longitude = 0;
            this.thePosition = new Pair<Double, Double>(this.latitude, this.longitude);
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pPositionId"></param>
        /// <param name="pName"></param>
        /// <param name="pLatitude"></param>
        /// <param name="pLongitude"></param>
        public Position(long pPositionId, String pName, Double pLatitude, Double pLongitude)
        {
            this.PositionId = pPositionId;
            this.Name = pName;
            this.latitude = pLatitude;
            this.longitude = pLongitude;
            this.thePosition = new Pair<double, double> (this.latitude, this.longitude);
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        /// <summary>
        /// Return the distance from two different Positions
        /// TODO: implementation getDistance(origin, destiny)
        /// </summary>
        /// <param name="pOrigin"></param>
        /// <param name="pDestiny"></param>
        /// <returns></returns>
        public Double GetDistanceInKm(Position pOrigin, Position pDestiny)
        {
            Double lReturn = 0;
            Double lDistance = 0;

            if (pOrigin.Equals(pDestiny))
            {
                lDistance = 0;
            }
            else
            {
                lDistance = Utils.DistanceFromLatitudeLongitudeInKm
                                    (pOrigin.Latitude, pOrigin.Longitude,
                                    pDestiny.Latitude, pDestiny.Longitude,
                                    false);
            }

            lReturn = lDistance;
            return lReturn;
        }

        /// <summary>
        /// Return the new Position adding the latitude and longitude to the Origin.
        /// </summary>
        /// <param name="pOrigin"></param>
        /// <param name="pLatitude"></param>
        /// <param name="pLongitude"></param>
        /// <returns></returns>
        public Position GetPositionMoveFromOrigin(Position pOrigin, String pNewName, 
                                                    double pLatitude, double pLongitude)
        {
            Position lPosition = null;
            String lNewName = pNewName;
            double lNewLatitude = pOrigin.Latitude + pLatitude;
            double lNewLongitude = pOrigin.Longitude + pLongitude;
            
            lPosition = new Position(0, lNewName, lNewLatitude, lNewLongitude);
            return lPosition;
        }

        /// <summary>
        /// Get New Latitude by Current Latitude & KM to West
        /// </summary>
        /// <param name="pLatitude"></param>
        /// <param name="pKMWest"></param>
        /// <returns></returns>
        public double GetLatitude(double pLatitude, double pKMWest)
        {
            double lLatitude = pLatitude;

            return lLatitude;
        }

        /// <summary>
        /// Get New Longitude by Current Longitude & KM to South
        /// </summary>
        /// <param name="pLongitude"></param>
        /// <param name="pKMSouth"></param>
        /// <returns></returns>
        public double GetLongitude(double pLongitude, double pKMSouth)
        {
            double lLongitude = pLongitude;

            return lLongitude;
        }

        /// <summary>
        /// Get New Position by Current Position & KM to West & KM to South
        /// </summary>
        /// <param name="pOrigin"></param>
        /// <param name="pKMWest"></param>
        /// <param name="pKMSouht"></param>
        /// <returns></returns>
        public Position GetNewPositionByKM(Position pOrigin, double pKMWest, double pKMSouth)
        {
            Position lPosition = null;

            return lPosition;
        }

        #endregion

        #region Overrides
        /// <summary>
        /// Override equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            Position lPosition = obj as Position;
            return this.latitude.Equals(lPosition.latitude)
                && this.longitude.Equals(lPosition.longitude);
        }

        public override int GetHashCode()
        {
            return this.latitude.GetHashCode() ^ this.longitude.GetHashCode() ;
        }
        #endregion
    }
}