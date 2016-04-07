using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicalJournals.Controllers
{
    //Onlyy registered users are allowed here. Any user should first go to the Logon/ Register page
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Landing Page for Publishers
        //[Authorize(Roles="Publisher")]
        public ActionResult Publishers()
        {
            return View();
        }

        //Landing Page for Public Users
        //[Authorize(Roles="Public")]
        public ActionResult Public()
        {
            return View();
        }

    }
}