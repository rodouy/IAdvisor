﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Security;
using NLog;

namespace IrrigationAdvisor.DBContext.Security
{
    public class UserConfiguration :
        EntityTypeConfiguration<User>
    {

        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        private const string ERROR_USER_EXISTS = "User not found";

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public UserConfiguration()
        {
            ToTable("User");
            HasKey(s => s.UserId);
            Property(s => s.UserId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);
            Property(s => s.Surname)
                .IsRequired()
                .HasMaxLength(50);
            Property(s => s.UserName)
                .IsRequired()
                .HasMaxLength(50);
            Property(s => s.Password)
                .IsRequired();
            Property(s => s.Phone)
                .IsRequired();
            Property(s => s.RoleId)
                .IsRequired();


        }

        public string GetPasswordFor(string userName)
        {

            string result = null;
            if (db.Users.Where(u => u.UserName == userName).Count() > 0)
            {

                result = db.Users.Where(u => u.UserName == userName).FirstOrDefault().Password;

            }


            return result;
        }


        public User GetUserByName(String pName)
        {
            User lReturn;
            try
            {
                bool exists = db.Users.Where(u => u.UserName == pName).Any();

                if (pName != null && exists)
                {
                    lReturn = db.Users.Where(u => u.UserName == pName).Single();
                }
                else
                {
                    lReturn = null;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in User.GetUserByName " + "\n" + ex.Message + "\n" + ex.StackTrace);
                
                throw ex;
            }

            return lReturn;
        }

        public User GetUserByEmail(string email)
        {

            return db.Users.Where(u => u.Email == email).FirstOrDefault();
        }

        
    }
}