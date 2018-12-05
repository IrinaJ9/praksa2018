using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VehicleSetup.Models;

namespace VehicleSetup.Controllers
{
    public class FleetAssetModelsController : Controller
    {
        private VehicleSetupEntities db = new VehicleSetupEntities();

        // GET: FleetAssetModels
        public ActionResult Index()
        {
            var fleetAssetModel = db.FleetAssetModel.Include(f => f.FleetAssetMake);
            return View(fleetAssetModel.ToList());
        }

        // GET: FleetAssetModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FleetAssetModel fleetAssetModel = db.FleetAssetModel.Find(id);
            if (fleetAssetModel == null)
            {
                return HttpNotFound();
            }
            return View(fleetAssetModel);
        }

        // GET: FleetAssetModels/Create
        public ActionResult Create()
        {
            ViewBag.FleetAssetMakeID = new SelectList(db.FleetAssetMake, "ID", "Manufacturer");
            return View();
        }

        // POST: FleetAssetModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,FleetAssetMakeID")] FleetAssetModel fleetAssetModel)
        {
            if (ModelState.IsValid)
            {
                db.FleetAssetModel.Add(fleetAssetModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FleetAssetMakeID = new SelectList(db.FleetAssetMake, "ID", "Manufacturer", fleetAssetModel.FleetAssetMakeID);
            return View(fleetAssetModel);
        }

        // GET: FleetAssetModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FleetAssetModel fleetAssetModel = db.FleetAssetModel.Find(id);
            if (fleetAssetModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.FleetAssetMakeID = new SelectList(db.FleetAssetMake, "ID", "Manufacturer", fleetAssetModel.FleetAssetMakeID);
            return View(fleetAssetModel);
        }

        // POST: FleetAssetModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,FleetAssetMakeID")] FleetAssetModel fleetAssetModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fleetAssetModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FleetAssetMakeID = new SelectList(db.FleetAssetMake, "ID", "Manufacturer", fleetAssetModel.FleetAssetMakeID);
            return View(fleetAssetModel);
        }

        // GET: FleetAssetModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FleetAssetModel fleetAssetModel = db.FleetAssetModel.Find(id);
            if (fleetAssetModel == null)
            {
                return HttpNotFound();
            }
            return View(fleetAssetModel);
        }

        // POST: FleetAssetModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FleetAssetModel fleetAssetModel = db.FleetAssetModel.Find(id);
            db.FleetAssetModel.Remove(fleetAssetModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
