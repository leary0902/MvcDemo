using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class DefaultControllerController : Controller
    {
        // GET: /DefaultController/
        public ActionResult DefaultAction()
        {
            Simple s = new Simple();
            s.Name = "Slark";
            s.Email = "xxx@163.com";
            return View(s);
        }
    }
}