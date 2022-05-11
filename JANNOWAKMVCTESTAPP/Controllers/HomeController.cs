using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using JANNOWAKMVCTESTAPP.Models;

namespace JANNOWAKMVCTESTAPP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name, string emailAddress)
        {
            return ModelState.IsValid ? (ActionResult) RedirectToAction("Summary", new {name, emailAddress}) : View();
        }

        public ActionResult Summary(string name, string emailAddress)
        {
            var person = new PersonViewModel{ Name = name, EmailAddress = emailAddress };
            return View(person);
        }

        public ActionResult CultureManagement(bool? culture)
        {
            if (culture != null)
            {
                if ((bool)culture)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
                    Session["culture"] = "en-GB";
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");
                    Session["culture"] = "pl-PL";
                }
            }
            return View("index");
        }
    }
}