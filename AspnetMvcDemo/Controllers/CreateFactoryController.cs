using AspnetMvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspnetMvcDemo.Controllers
{
    public class CreateFactoryController : Controller
    {
        QCEntities db = new QCEntities();

        // GET: CreateFactory
        public ActionResult CreateFactory()
        {
            return View("~/Views/CreateFactory/CreateFactory.cshtml");
        }

        [HttpPost]
        public ActionResult CreateFactory(Factory11 factory)
        {
            ObjectParameter statusCode = new ObjectParameter("StatusCode", typeof(int));
            ObjectParameter statusMessage = new ObjectParameter("StatusMessage", typeof(string));

            db.AddUpdateFactory(0,factory.Name,factory.Type,factory.ProductionCapacity,
                factory.DailyProductionRate,factory.NumberofMixers,factory.NumberofTrucks,
                factory.PhoneNumber,factory.FaxNumber,factory.MailBox,factory.Email,factory.Status,factory.Latitude,
                factory.Longitude,factory.OwnerName,factory.OwnerEmail,factory.OwnerPhoneNumber,
                factory.ManagerName,factory.ManagerEmail,factory.ManagerPhoneNumber,factory.ManagerExperience,
                factory.EngineerName,factory.EngineerEmail,factory.EngineerPhoneNumber,factory.EngineerExperience, factory.Comments,
                null,null,null,null,null, statusCode, statusMessage);
            db.SaveChanges();

            Console.Write(statusMessage);

            return View("~/Views/CreateFactory/CreateFactory.cshtml");
        }
    }
}