using MyProject_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        
        public ActionResult Calculator()
        {
            return View();
           
        }

        public ActionResult CalculationResult(TriangleCalculator calc)
        {
            TriangleCalculator.Calculate(calc);

            return PartialView("CalculationResult", calc);
        }
    }
}