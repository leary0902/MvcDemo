using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class PlotController : Controller
    {
        // GET: Plot
        public ActionResult Index()
        {
            return View();
        }
    }
}