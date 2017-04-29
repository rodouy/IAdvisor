using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.DBContext.Security;
using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.ViewModels.Wizard;
//using IrrigationAdvisor.Models.Irrigation;


using IrrigationAdvisor.Models.Localization;

//using IrrigationAdvisor.Models.Utilities;



namespace IrrigationAdvisor.Controllers.Wizard
{
    public class WizardFarmController : Controller
    {

        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();


        public ActionResult Index()
        {
            return View("~/Views/Wizard/FarmBomb/Index.cshtml");

            //CreateUserViewModel userVM = new CreateUserViewModel();

            //userVM.Roles = this.LoadRoles();

            //return View("~/Views/Security/Users/Create.cshtml", userVM);
        }


        //// POST: UserFarms/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Name")] WizardFarmBombViewModel wizardFarmBombViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        var userMapped = new Farm
        //        {
        //            Name = wizardFarmBombViewModel.Name,
        //           // Phone = wizardFarmBombViewModel.Phone
        //        };
               


        //        //db.Bombs.Add(userMapped);
        //        db.SaveChanges();
        //        return View("~/Views/Wizard/Create.cshtml");
        //    }

        //    return View(wizardFarmBombViewModel);
        //}


    }
}
