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

namespace IrrigationAdvisor.Controllers.Security
{
    public class UsersController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

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

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "UserId,Name,Surname,Phone,Address,UserName,UserName,Password")] User user)
        public ActionResult Create([Bind(Include = "UserId,Name,Surname,Phone,Address,Email,UserName,Password")] CreateUserViewModel user)
        {
            if (ModelState.IsValid)
            {
                MD5 md5Hash = MD5.Create();

                var userMapped = Mapper.Map<CreateUserViewModel, User>(user);


                user.Password = CryptoUtils.GetMd5Hash(md5Hash, user.Password);
                
                db.Users.Add(userMapped);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
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
