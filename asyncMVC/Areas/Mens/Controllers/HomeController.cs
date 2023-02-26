using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asyncMVC.Areas.Mens.Controllers
{
    public class HomeController : Controller
    {
        // GET: Mens/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}