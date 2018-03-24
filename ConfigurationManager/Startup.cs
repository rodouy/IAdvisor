using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using ConfigurationManager.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ConfigurationManager.DataAccess;
using IrrigationAdvisor.CommonUtils;

[assembly: OwinStartup(typeof(ConfigurationManager.Startup))]

namespace ConfigurationManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }


        // In this method we will create default User roles and Admin user for login  
        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            IrrigationAdvisorEntities irrigationAdvisorEntities = new IrrigationAdvisorEntities();
            

            var roles = irrigationAdvisorEntities.Roles.ToList();
            var users = irrigationAdvisorEntities.Users.ToList();

            foreach (var role in roles)
            {
                // In Startup iam creating first Admin Role and creating a default Admin User   
                if (!roleManager.RoleExists(role.Name))
                {
                    // first we create Admin rool  
                    var identityRole = new IdentityRole();
                    identityRole.Name = role.Name;
                    roleManager.Create(identityRole);                
                }
            }

            //foreach (var user in users)
            //{
            //    if (!UserManager.Users.Where(u => u.UserName == user.Name).Any())
            //    {
            //        //Here we create a Admin super user who will maintain the website                 

            //        var applicationUser = new ApplicationUser();
            //        applicationUser.UserName = user.Name;
            //        applicationUser.Email = user.Email;

            //        // string userPWD = "A@Z200711";

            //        var chkUser = UserManager.Create(applicationUser);

            //        //Add default User to Role Admin  
            //        if (chkUser.Succeeded)
            //        {
            //            string roleName = irrigationAdvisorEntities.Roles.Single(n => n.RoleId == user.RoleId).Name;

            //            var result1 = UserManager.AddToRole(applicationUser.Id, roleName);
            //        }
            //    }
            //}

            string userName = "Admin1234";
            string password = "123456";
            string roleName;
            if (!UserManager.Users.Where(u => u.UserName == userName).Any())
            {
                var toTestUser = new ApplicationUser();
                toTestUser.UserName = userName;
                toTestUser.Email = "mail@mail.com";
                var okUser = UserManager.Create(toTestUser, password);

                if (okUser.Succeeded)
                {
                    roleName = irrigationAdvisorEntities.Roles.Single(n => n.RoleId == 1).Name;
                    UserManager.AddToRole(toTestUser.Id, roleName);
                }
            }
        }
    }
}
