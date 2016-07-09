using IrrigationAdvisor.Models.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Security
{
    public class UserViewModel
    {

        #region Consts
        #endregion

        #region Fields
        #endregion

        #region Properties

        public long UserId { get; set; }

        public String Name { get; set; }

        public String Surname { get; set; }

        public String Phone { get; set; }

        public String Address { get; set; }

        public String Email { get; set; }

        public String UserName { get; set; }

        public String Password { get; set; }

        #endregion

        #region Construction

        public UserViewModel(User pUser)
        {
            this.UserId = pUser.UserId;
            this.Name = pUser.Name;
            this.Surname = pUser.Surname;
            this.Phone = pUser.Phone;
            this.Address = pUser.Address;
            this.Email = pUser.Email;
            this.UserName = pUser.UserName;
            this.Password = pUser.Password;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        #endregion

        #region Overrides
        #endregion

    }
}