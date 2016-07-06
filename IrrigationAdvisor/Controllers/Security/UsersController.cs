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

namespace IrrigationAdvisor.Controllers.Security
{
    public class UsersController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

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
            return View("~/Views/Security/Users/Create.cshtml");
        }

        // POST: Users/Create;
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "UserId,Name,Surname,Phone,Address,Email,UserName,Password")] User user)
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
                    UserName =user.UserName 
                };

                
                user.Password = CryptoUtils.GetMd5Hash(md5Hash, user.Password);
                
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

            User userExists = uc.GetUserBy(user.UserName);

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
            return View("~/Views/Security/Users/Edit.cshtml", user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,Name,Surname,Phone,Address,Email,UserName,Password")] User user)
        {
            if (ModelState.IsValid)
            {

                MD5 md5Hash = MD5.Create();


                user.Password = CryptoUtils.GetMd5Hash(md5Hash, user.Password);

                db.Entry(user).State = EntityState.Modified;
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
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
