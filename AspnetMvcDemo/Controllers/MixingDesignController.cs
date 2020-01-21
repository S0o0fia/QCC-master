using AspnetMvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspnetMvcDemo.Controllers
{
    public class MixingDesignController : Controller
    {
        QCEntities db = new QCEntities();

        ConcreteMixingDesign addDesign = new ConcreteMixingDesign();

        AddMixDesign addMix = new AddMixDesign();

        List<ApproveMixingDesign> approveMix = new List<ApproveMixingDesign>();

        // GET: MixingDesign
        public ActionResult MixingDesign()
        {
            return View(db.ConcreteMixingDesigns.ToList());
        }

        public ActionResult ApproveMixingDesign()
        {
            var result = (from m in db.ConcreteMixingDesigns
                          join f in db.Factory11 on m.FactoryId equals f.Id
                          select new ApproveMixingDesign
                          {
                              FactoryName = f.Name,
                              Latitude = f.Latitude,
                              Longitude = f.Longitude,
                              OwnerName = f.OwnerName,
                              Id = m.Id,
                              FactoryId = m.FactoryId,
                              ConcreteRank = m.ConcreteRank,
                              CementWeight = m.CementWeight,
                              WaterWeight = m.WaterWeight,
                              WashedSand = m.WashedSand,
                              WhiteSand = m.WhiteSand,
                              Rubble3by4 = m.Rubble3by4,
                              Rubble3by8 = m.Rubble3by8,
                              Status = m.Status,
                              Comments = m.Comments
                          }).ToList();
            return View(result);
        }

        // GET: MixingDesign/Details/5
        public ActionResult Details(int id)
        {
            var result = (from m in db.ConcreteMixingDesigns
                          join f in db.Factory11 on m.FactoryId equals f.Id
                          select new ApproveMixingDesign
                          {
                              FactoryName = f.Name,
                              Latitude = f.Latitude,
                              Longitude = f.Longitude,
                              OwnerName = f.OwnerName,
                              Id = m.Id,
                              FactoryId = m.FactoryId,
                              ConcreteRank = m.ConcreteRank,
                              CementWeight = m.CementWeight,
                              WaterWeight = m.WaterWeight,
                              WashedSand = m.WashedSand,
                              WhiteSand = m.WhiteSand,
                              Rubble3by4 = m.Rubble3by4,
                              Rubble3by8 = m.Rubble3by8,
                              Status = m.Status,
                              Comments = m.Comments
                          }).Where(x=>x.Id==id).FirstOrDefault();
            return PartialView(result);
        }

        // GET: MixingDesign/Create
        public ActionResult AddMixingDesign()
        {
            addMix.Factories = db.Factory11.Select(x => new Fact { FactoryId = x.Id, FactoryName = x.Name }).ToList();
            return PartialView(addMix);
        }

        // POST: MixingDesign/Create
        [HttpPost]
        public ActionResult AddMixingDesign(AddMixDesign mix)
        {
            try
            {
                // TODO: Add insert logic here

                ObjectParameter statusCode = new ObjectParameter("StatusCode", typeof(int));
                ObjectParameter statusMessage = new ObjectParameter("StatusMessage", typeof(string));

                db.AddUpdateConcMixDesing(0, mix.FactoryId, mix.ConcreteRank, mix.CementWeight, mix.WaterWeight, mix.WashedSand, 
                                            mix.Rubble3by4, mix.Rubble3by8, mix.WhiteSand, "Pending", null, mix.Comments,
                                            null, null, null, null, statusCode, statusMessage);


                return View("MixingDesign");
            }
            catch
            {
                return View();
            }
        }

        // GET: MixingDesign/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MixingDesign/Edit/5
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

        // GET: MixingDesign/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MixingDesign/Delete/5
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
