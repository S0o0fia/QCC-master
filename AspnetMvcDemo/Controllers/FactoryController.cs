using AspnetMvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspnetMvcDemo.Controllers
{
    public class FactoryController : Controller
    {
        QCEntities db = new QCEntities();
        // GET: Factory
        public ActionResult FactoriesList()
        {
            return View(db.Factory11.ToList());
        }

        public ActionResult CreateFactory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateFactory(Factory11 factory)
        {
            ObjectParameter statusCode = new ObjectParameter("StatusCode", typeof(int));
            ObjectParameter statusMessage = new ObjectParameter("StatusMessage", typeof(string));

            db.AddUpdateFactory(0, factory.Name, factory.Type, factory.ProductionCapacity,
                factory.DailyProductionRate, factory.NumberofMixers, factory.NumberofTrucks,
                factory.PhoneNumber, factory.FaxNumber, factory.MailBox, factory.Email, factory.Status, factory.Latitude,
                factory.Longitude, factory.OwnerName, factory.OwnerEmail, factory.OwnerPhoneNumber,
                factory.ManagerName, factory.ManagerEmail, factory.ManagerPhoneNumber, factory.ManagerExperience,
                factory.EngineerName, factory.EngineerEmail, factory.EngineerPhoneNumber, factory.EngineerExperience, factory.Comments,
                null, null, null, null, null, statusCode, statusMessage);


            return View("FactoriesList");
        }

        // GET: Factory/Details/5
        public ActionResult FactoryDetails(int id)
        {
            Factory11 factory = db.Factory11.Where(u => u.Id == id).FirstOrDefault();
            return PartialView(factory);
        }

        // GET: Factory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Factory/Create
        [HttpPost]
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
            }
        }

        // GET: Factory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Factory/Edit/5
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

        // GET: Factory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Factory/Delete/5
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
