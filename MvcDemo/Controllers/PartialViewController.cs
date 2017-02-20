using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: PartialView
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult ChildAction(DateTime time, int num)
        {
            DateTime t = DateTime.Parse("2:2:2");
            string greetings = string.Empty;
            if (time.Hour > 18)
            {
                greetings = "Good evening. Now is " + time.ToString("HH:mm:ss");
            }
            else if (time.Hour > 12)
            {
                greetings = "Good afternoon. Now is " + time.ToString("HH:mm:ss");
            }
            else
            {
                greetings = "Good morning. Now is " + time.ToString("HH:mm:ss");
            }
            greetings += "! " + num;
            return PartialView("ChildAction", greetings);
        }
    }
}