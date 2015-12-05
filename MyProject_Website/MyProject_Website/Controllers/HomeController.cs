using MyProject_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject_Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Calculator([Bind(Include = "Value")] TriangleCalculator Value)
        {



            if (ModelState.IsValid)
            {
                return View(TriangleCalculator.Calculate(Value.Value));
            }
            return View();
           
        }
    }
}