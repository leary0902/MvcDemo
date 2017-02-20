using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class FirstController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Number = 8;
            ViewBag.Message = "This is index Page";
            ViewBag.Slarks = new List<string> { "Slark1", "Slark2", "Slark3" };
            return View();
        }

    }
}