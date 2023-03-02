using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asyncMVC.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        // GET: Employee
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp) {

            if (ModelState.IsValid) {
                db.Employees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("index");

            }
            return View(emp);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (id > 0) {
                return View(db.Employees.Where(p=> p.EmployeeId == id).SingleOrDefault());
            }

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Employee emp)
        {

            if (ModelState.IsValid)
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("index");

            }
            return View(emp);
        }
    }
}