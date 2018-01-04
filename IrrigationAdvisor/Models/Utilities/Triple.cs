using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Utilities
{
    /// <summary>
    /// Create: 2018-01-01
    /// Author: rodouy
    /// Description: 
    ///     Class for triple elements that support generics
    ///     
    /// References:
    ///     list of classes this class use
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: OK
    ///     UnitTest
    /// 
    /// Example of use:
    /// Triple<String, int, Double> lTriple = new Triple<String, int, Double>("test", 2, 5.1);
    /// Console.WriteLine(lTriple.First);   
    /// Console.WriteLine(lTriple.Second);
    /// Console.WriteLine(lTriple.Third);
    /// 
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - first T
    ///     - second U
    ///     - third V
    /// 
    /// Methods:
    ///     - Triple()      -- constructor
    ///     - Triple(pFirst, pSecond, pThird)  -- consturctor with parameters
    ///     
    /// 
    /// </summary>
    public class Triple<T, U, V>
    {
        #region Consts
        #endregion

        #region Fields
        private T first;
        private U second;
        private V third;
        #endregion

        #region Properties
        public T First
        {
            get { return first; }
            set { first = value; }
        }

        public U Second
        {
            get { return second; }
            set { second = value; }
        }

        public V Third
        {
            get { return third; }
            set { third = value; }
        }
        #endregion

        #region Construction
        public Triple()
        { }

        public Triple(T pFirst, U pSecond, V pThird)
        {
            this.First = pFirst;
            this.Second = pSecond;
            this.Third = pThird;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        #endregion

        #region Overrides
        public override bool Equals(object obj)
        {
            bool lReturn = false;
            if (obj == null)
                return false;
            if (obj == this)
                return true;
            Triple<T, U, V> other = obj as Triple<T, U, V>;
            if (other == null)
                return false;
            lReturn = (((first == null) && (other.first == null))
                        || ((first != null) && first.Equals(other.first)))
                       &&
                       (((second == null) && (other.second == null))
                        || ((second != null) && second.Equals(other.second)))
                       &&
                       (((third == null) && (other.third == null))
                        || ((third != null) && third.Equals(other.third)));

            return lReturn;
        }

        public override int GetHashCode()
        {
            int lHashCode = 0;
            if (first != null)
                lHashCode += first.GetHashCode();
            if (second != null)
                lHashCode += second.GetHashCode();
            if (third != null)
                lHashCode += third.GetHashCode();
            return lHashCode;
        }
        #endregion
    }
}