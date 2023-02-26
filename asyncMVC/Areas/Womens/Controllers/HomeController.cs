using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asyncMVC.Areas.Womens.Controllers
{
    public class HomeController : Controller
    {
        // GET: Womens/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}