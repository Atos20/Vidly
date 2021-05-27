using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("customers")]
        public ActionResult customers()
        {
            var movie = new Movie() { Name = "Shrek!" };

            return View(movie);
        }

        [Route("Movies")]
        public ActionResult Movies()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("Register")]
        public ActionResult Register()
        {
            return View();
        }

        [Route("Login")]
        public ActionResult Login()
        {
            return View();
        }
    }
}