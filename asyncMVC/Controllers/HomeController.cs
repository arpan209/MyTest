using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using asyncMVC.Models;
namespace asyncMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(EmployeeModel emp)
        {
            if (emp.id == 0) {

                emp.id = 101;
                emp.name = "Arpan";
                emp.salary = 180000;
            }

            return View(emp);
        }
        
        public ActionResult Create() {

            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            try
            {
                return RedirectToAction("Index",emp);
            }
            catch
            {

                return View();
            }
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

        public ActionResult GetList() {
            var watch = new Stopwatch();
            watch.Start();
            var country = GetCountry();
            var state = GetState();
            var city = GetCity();
            watch.Stop();
            ViewBag.WatchMilliseconds = watch.ElapsedMilliseconds;
            return View();

        }

        public async Task<ActionResult> GetListAsync() {
            //Create a stopwatch for getting excution time  
            var watch = new Stopwatch();
            watch.Start();
            var country = GetCountryAsync();
            var state = GetStateAsync();
            var city = GetCityAsync();
            var content = await country;
            var count = await state;
            var name = await city;
            watch.Stop();
            ViewBag.WatchMilliseconds = watch.ElapsedMilliseconds;
            return View();

        }

        #region-- > GetCountry Methods  for GetList && GetListAsync
        public string GetCountry()
        {
            Thread.Sleep(3000); //Use - when you want to block the current thread.  
            return "India";
        }
        public async Task<string> GetCountryAsync()
        {
            await Task.Delay(3000); //Use - when you want a logical delay without blocking the current thread.  
            return "India";
        }
        #endregion  
        # region-- > GetState Methods for GetList && GetListAsync

        public string GetState()
        {
            Thread.Sleep(5000); //Use - when you want to block the current thread.  
            return "Gujarat";
        }
        public async Task<string> GetStateAsync()
        {
            await Task.Delay(5000); //Use - when you want a logical delay without blocking the current thread.  
            return "Gujarat";
        }
        #endregion
        
        # region-- > GetCity Methods for GetList && GetListAsync
        public string GetCity()
        {
            Thread.Sleep(6000); //Use - when you want to block the current thread.  
            return "Junagadh";
        }
        public async Task<string> GetCityAsync()
        {
            await Task.Delay(6000); //Use - when you want a logical delay without blocking the current thread.  
            return "Junagadh";
        }
        #endregion


    }
}