using MyProject_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace MyProject_Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TextReminder(System.Web.Mvc.FormCollection formData)
        {
            Text.SetTimer();

            if (formData["datetime"] != null)
            {
                var message = formData["message"];
                var time = formData["datetime"];

                InsertInfo.InsertText(message, time);
            }
            return View();
        }

        public ActionResult Library()
        {
            return View();
        }

        public ActionResult Email(System.Web.Mvc.FormCollection formData)
        {
            EmailInfo email = new EmailInfo();

            email.name = formData["name"];
            email.message = formData["message"];
            email.email = formData["email"];

            EmailInfo.SendEmail(email);

            return View(email);
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