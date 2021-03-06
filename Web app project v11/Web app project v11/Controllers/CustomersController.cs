﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_app_project_v11.Controllers
{
    public class CustomersController : Controller
    {
        private Manager m = new Manager();
        // GET: Customers
        public ActionResult Index()
        {
            var customers = m.CustomerGetAll();

            return View(customers);
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            var customer = m.CustomerGetById(id.GetValueOrDefault());

            if (customer == null)
                return HttpNotFound();
            else
                return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
<<<<<<< HEAD
        public ActionResult Create(CustomerAdd newCustomer)
        {
            if (!ModelState.IsValid)
            {
                return View(newCustomer);
            }

            var addedCustomer = m.CustomerAdd(newCustomer);

            if (addedCustomer == null)
            {
                return View(newCustomer);
            }
            else
            {
                return RedirectToAction("details", new { id = addedCustomer.CustomerId });
=======
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
>>>>>>> 784cf35933bec011f9dfc3ff0388ea983da893b5
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customers/Edit/5
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

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customers/Delete/5
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
