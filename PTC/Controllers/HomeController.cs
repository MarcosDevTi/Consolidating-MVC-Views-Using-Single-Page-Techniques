using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTC.Data;

namespace PTC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vm = new TrainingProductViewModel();
            vm.HandleRequest();

            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(TrainingProductViewModel vm)
        {
            vm.IsValid = ModelState.IsValid;
            vm.HandleRequest();

            if (vm.IsValid)
            {
                ModelState.Clear();
            }
            else
            {
                vm.ValidationErrors.ForEach(_ => 
                    ModelState.AddModelError(_.Key, _.Value));
            }
            return View(vm);
        }
       
    }
}