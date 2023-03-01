using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asyncMVC.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult student() {
            string[] arr = { "CS Student", "ME Student", "PH Student", "EC Student", "EE Student" };
            return PartialView("_student", arr);
        }
    }
}