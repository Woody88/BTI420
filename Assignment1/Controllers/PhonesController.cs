using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1.Controllers
{
    public class PhonesController : Controller
    {
        // Collection of phones
        private List<PhoneBase> Phones;
        public PhonesController()
        {
            // Initialize the collection
            Phones = new List<PhoneBase>();

            // Add to the collection
            var priv = new PhoneBase();
            priv.Id = 1;
            priv.PhoneName = "Priv";
            priv.Manufacturer = "BlackBerry";
            priv.DateReleased = new DateTime(2015, 11, 6);
            priv.MSRP = 799;
            priv.ScreenSize = 5.43;
            Phones.Add(priv);

            // Add to the collection, using the newer object initializer syntax
            var galaxy = new PhoneBase
            {
                Id = 2,
                PhoneName = "Galaxy S6",
                Manufacturer = "Samsung",
                DateReleased = new DateTime(2015, 4, 10),
                MSRP = 649,
                ScreenSize = 5.1
            };
            Phones.Add(galaxy);

            // Add to the collection, using the newer object initializer syntax
            // directly as the argument to the Phones.Add() method
            Phones.Add(new PhoneBase {
                Id = 3,
                PhoneName = "iPhone 6s",
                Manufacturer = "Apple",
                DateReleased = new DateTime(2015, 9, 25),
                MSRP = 649,
                ScreenSize = 4.7
            });

        }
        // GET: Phones
        public ActionResult Index()
        {
            return View(Phones);
        }

        // GET: Phones/Details/5
        public ActionResult Details(int id)
        {
            var phone = Phones.Find(p => p.Id == id);
            return View(phone);
        }

        // GET: Phones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Phones/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                var newPhone = new PhoneBase();
                newPhone.Id = Phones.Count + 1;

                newPhone.PhoneName = collection["PhoneName"];
                newPhone.Manufacturer = collection["Manufacturer"];
                newPhone.DateReleased = Convert.ToDateTime(collection["DateReleased"]);

                int msrp;
                double ss;
                bool isNumber;

                isNumber = Int32.TryParse(collection["MRSP"], out msrp);
                newPhone.MSRP = msrp;
    
                isNumber = double.TryParse(collection["ScreenSize"], out ss);
                newPhone.ScreenSize = ss;

                Phones.Add(newPhone);

                //return RedirectToAction("Index");
                return View("Details", newPhone);
            }
            catch
            {
                return View();
            }
        }

        // GET: Phones/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Phones/Edit/5
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

        // GET: Phones/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Phones/Delete/5
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
