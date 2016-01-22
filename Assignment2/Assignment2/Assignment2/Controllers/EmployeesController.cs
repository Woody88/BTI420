using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class EmployeesController : Controller
    {
        private Manager m = new Manager();
     // GET: Employees
     public ActionResult Index()
        {
            var employees = m.EmployeeGetAll();

            return View(employees);
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            var employee = m.EmployeeDetails(id.GetValueOrDefault());

            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        public ActionResult Create(EmployeeAdd newEmployee)
        {
            if (!ModelState.IsValid)
                return View();

            var addedEmployee = m.EmployeeAdd(newEmployee);

            if (addedEmployee == null)
                return View(newEmployee);
            else
                return RedirectToAction("details", new { id = addedEmployee.EmployeeId });
       
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employees/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
