using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.Security;
using System.Security.Cryptography;
using IrrigationAdvisor.ComplementedUtils;
using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.ViewModels.Security;
using AutoMapper;
using IrrigationAdvisor.DBContext.Security;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.Models.Localization;

namespace IrrigationAdvisor.Controllers.Security
{
    public class UsersController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        private const string USERNAME_EXISTS_ERROR = "El nombre de usuario ya existe";


        // GET: Users
        public ActionResult Index()
        {
            //TO-DO: Not use access directly to database. Access via controllers.
            return View("~/Views/Security/Users/Index.cshtml", db.Users.ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Security/Users/Details.cshtml", user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            CreateUserViewModel userVM = new CreateUserViewModel();

            userVM.Roles = this.LoadRoles();

            return View("~/Views/Security/Users/Create.cshtml", userVM);
        }

        // GET: Users/Wizard
        public ActionResult Wizard()
        {
            CreateUserViewModel userVM = new CreateUserViewModel();

            userVM.Roles = this.LoadRoles();
            userVM.Farms = this.LoadFarms();
            return View("~/Views/Security/Users/Wizard.cshtml", userVM);
        }

        // POST: Users/Wizard;
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Wizard([Bind(Include = "UserId,Name,Surname,Phone,Address,Email,UserName,Password,ConfirmPassword,RoleId,FarmsHidden")] CreateUserViewModel user)
        {

            if (ModelState.IsValid)
            {

                MD5 md5Hash = MD5.Create();


                //  private string[] s = user.FarmsHidden

                var userMapped = new User
                {
                    Address = user.Address,
                    Email = user.Email,
                    Name = user.Name,
                    Password = user.Password,
                    Phone = user.Phone,
                    RoleId = user.RoleId,
                    Surname = user.Surname,
                    UserName = user.UserName

                };
                userMapped.Password = CryptoUtils.GetMd5Hash(md5Hash, user.Password);
                db.Users.Add(userMapped);



                //working with farms 
                string[] farmsId = user.FarmsHidden.Split('|');
                foreach (string fId in farmsId)
                {
                    UserFarm lUserFarm = new UserFarm();
                    Farm lfarm = new Farm();
                    long id = long.Parse(fId);
                    lfarm = (from farm in db.Farms
                             where farm.FarmId == id
                             select farm).FirstOrDefault();
                    lUserFarm.User = userMapped;
                    lUserFarm.FarmId = id;
                    lUserFarm.Name = userMapped.Name + " - " + lfarm.Name;
                    lUserFarm.StartDate = DateTime.Now;

                    db.UserFarms.Add(lUserFarm);
                }


                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("~/Views/Security/Users/Wizard.cshtml", user);
        }


        //private MailMessage GetMailMessage(string subject, string body)
        //{
        //    MailMessage mail = new MailMessage();
        //    string emailFrom = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["emailFrom"]);
        //    string emailTo = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["emailTo"]);

        //    mail.From = new MailAddress(emailFrom);
        //    mail.To.Add(emailTo);
        //    mail.Subject = subject;
        //    body = body.Replace("[br]", "<br>");
        //    mail.Body = body;
        //    mail.IsBodyHtml = true;

        //    return mail;
        //}

        //private SmtpClient GetSmtpClient()
        //{
        //    string smtpAddress = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["smtpAddress"]);
        //    int portNumber = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["smtpPort"]);
        //    bool enableSSL = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["ssl"]);
        //    string emailFrom = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["emailFrom"]);
        //    string password = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["password"]);

        //    SmtpClient smtp = new SmtpClient(smtpAddress, portNumber);

        //    smtp.Credentials = new NetworkCredential(emailFrom, password);
        //    smtp.EnableSsl = enableSSL;

        //    return smtp;
        //}


        ///// <summary>
        ///// TODO: Description of SendEmails
        ///// </summary>
        ///// <param name="subject"></param>
        ///// <param name="body"></param>
        ///// <returns></returns>
        //public ActionResult SendEmails(string subject, string body)
        //{
        //    try
        //    {

        //        SmtpClient smtp = GetSmtpClient();
        //        MailMessage mail = GetMailMessage(subject, body);

        //        smtp.Send(mail);

        //    }
        //    catch (Exception ex)
        //    {
        //        Utils.LogError(ex, "Exception in HomeController.SendEmails ");
        //        return Content(ex.Message);
        //    }


        //    return Content("Ok");
        //}


        // POST: Users/Create;
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "UserId,Name,Surname,Phone,Address,UserName,UserName,Password")] User user)
        public ActionResult Create([Bind(Include = "UserId,Name,Surname,Phone,Address,Email,UserName,Password,ConfirmPassword,RoleId")] CreateUserViewModel user)
        {

            if (ModelState.IsValid)
            {

                MD5 md5Hash = MD5.Create();

                var userMapped = new User
                {
                    Address = user.Address,
                    Email = user.Email,
                    Name = user.Name,
                    Password = user.Password,
                    Phone = user.Phone,
                    RoleId = user.RoleId,
                    Surname = user.Surname,
                    UserName = user.UserName
                };


                userMapped.Password = CryptoUtils.GetMd5Hash(md5Hash, user.Password);

                db.Users.Add(userMapped);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("~/Views/Security/Users/Create.cshtml", user);
        }

        private List<string> Validation(CreateUserViewModel user)
        {
            List<string> messages = new List<string>();

            UserConfiguration uc = new UserConfiguration();

            User userExists = uc.GetUserByName(user.UserName);

            if (user != null)
                messages.Add(USERNAME_EXISTS_ERROR);

            return messages;

        }

        // GET: Users/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            EditUserViewModel userVM = new EditUserViewModel()
            {
                Address = user.Address,
                Email = user.Email,
                Name = user.Name,
                Password = user.Password,
                Phone = user.Phone,
                RoleId = user.RoleId,
                Surname = user.Surname,
                UserId = user.UserId,
                UserName = user.UserName
            };

            userVM.Roles = this.LoadRoles(user.RoleId, user);

            return View("~/Views/Security/Users/Edit.cshtml", userVM);
        }


        private List<System.Web.Mvc.SelectListItem> LoadFarms(long? farmId = null, User user = null)
        {
            FarmConfiguration fc = new FarmConfiguration();

            List<Farm> farms = fc.GetAllFarms();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in farms)
            {
                bool isSelected = false;
                if (user != null && farmId.HasValue)
                {
                    isSelected = (user.RoleId == farmId);
                }

                SelectListItem sl = new SelectListItem()
                {
                    Value = item.FarmId.ToString(),
                    Text = item.Name,
                    Selected = isSelected
                };

                result.Add(sl);
            }

            return result;
        }

        private List<System.Web.Mvc.SelectListItem> LoadRoles(long? roleId = null, User user = null)
        {

            RoleConfiguration rc = new RoleConfiguration();
            List<Role> roles = rc.GetAllRoles();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in roles)
            {

                bool isSelected = false;
                if (user != null && roleId.HasValue)
                {
                    isSelected = (user.RoleId == roleId);
                }

                SelectListItem sl = new SelectListItem()
                {
                    Value = item.RoleId.ToString(),
                    Text = item.Name,
                    Selected = isSelected
                };

                result.Add(sl);
            }

            return result;
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,Name,Surname,Phone,Address,Email,UserName,Password,RoleId")] EditUserViewModel user)
        {
            if (ModelState.IsValid)
            {

                MD5 md5Hash = MD5.Create();

                User updatedUser = db.Users.Find(user.UserId);

                if (updatedUser == null)
                {
                    return HttpNotFound();
                }

                //user.Password = CryptoUtils.GetMd5Hash(md5Hash, user.Password);
                updatedUser.Address = user.Address;

                updatedUser.Name = user.Name;
                updatedUser.Phone = user.Phone;
                updatedUser.RoleId = user.RoleId;
                updatedUser.Surname = user.Surname;

                db.Entry(updatedUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("~/Views/Security/Users/Edit.cshtml", user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Security/Users/Delete.cshtml", user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    db.Dispose();
            //}
            //base.Dispose(disposing);
        }
    }
}
