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
    public class FleetAssetsController : Controller
    {
        private VehicleSetupEntities db = new VehicleSetupEntities();

        // GET: FleetAssets
        public ActionResult Index()
        {
            var fleetAsset = db.FleetAsset.Include(f => f.AssetSubType).Include(f => f.AssetType).Include(f => f.FleetAssetMake).Include(f => f.FleetAssetModel).Include(f => f.FuelType);
            return View(fleetAsset.ToList());
        }

        // GET: FleetAssets/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FleetAsset fleetAsset = db.FleetAsset.Find(id);
            if (fleetAsset == null)
            {
                return HttpNotFound();
            }
            return View(fleetAsset);
        }

        // GET: FleetAssets/Create
        public ActionResult Create()
        {
            ViewBag.SubTypeID = new SelectList(db.AssetSubType, "ID", "SubType");
            ViewBag.TypeID = new SelectList(db.AssetType, "ID", "Type");
            ViewBag.FleetAssetMakeID = new SelectList(db.FleetAssetMake, "ID", "Manufacturer");
            ViewBag.FleetAssetModelID = new SelectList(db.FleetAssetModel, "ID", "Name");
            ViewBag.FuelTypeID = new SelectList(db.FuelType, "ID", "Fuel");
            return View();
        }

        // POST: FleetAssets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FleetNo,RegistrationNo,Depot,Year,Description,FleetAssetMakeID,FleetAssetModelID,TypeID,SubTypeID,AxelWeight1,AxelWeight2,AxelWeight3,FuelTypeID,IsVehicle")] FleetAsset fleetAsset)
        {
            if (ModelState.IsValid)
            {
                db.FleetAsset.Add(fleetAsset);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SubTypeID = new SelectList(db.AssetSubType, "ID", "SubType", fleetAsset.SubTypeID);
            ViewBag.TypeID = new SelectList(db.AssetType, "ID", "Type", fleetAsset.TypeID);
            ViewBag.FleetAssetMakeID = new SelectList(db.FleetAssetMake, "ID", "Manufacturer", fleetAsset.FleetAssetMakeID);
            ViewBag.FleetAssetModelID = new SelectList(db.FleetAssetModel, "ID", "Name", fleetAsset.FleetAssetModelID);
            ViewBag.FuelTypeID = new SelectList(db.FuelType, "ID", "Fuel", fleetAsset.FuelTypeID);
            return View(fleetAsset);
        }

        // GET: FleetAssets/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FleetAsset fleetAsset = db.FleetAsset.Find(id);
            if (fleetAsset == null)
            {
                return HttpNotFound();
            }
            ViewBag.SubTypeID = new SelectList(db.AssetSubType, "ID", "SubType", fleetAsset.SubTypeID);
            ViewBag.TypeID = new SelectList(db.AssetType, "ID", "Type", fleetAsset.TypeID);
            ViewBag.FleetAssetMakeID = new SelectList(db.FleetAssetMake, "ID", "Manufacturer", fleetAsset.FleetAssetMakeID);
            ViewBag.FleetAssetModelID = new SelectList(db.FleetAssetModel, "ID", "Name", fleetAsset.FleetAssetModelID);
            ViewBag.FuelTypeID = new SelectList(db.FuelType, "ID", "Fuel", fleetAsset.FuelTypeID);
            return View(fleetAsset);
        }

        // POST: FleetAssets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FleetNo,RegistrationNo,Depot,Year,Description,FleetAssetMakeID,FleetAssetModelID,TypeID,SubTypeID,AxelWeight1,AxelWeight2,AxelWeight3,FuelTypeID,IsVehicle")] FleetAsset fleetAsset)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fleetAsset).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SubTypeID = new SelectList(db.AssetSubType, "ID", "SubType", fleetAsset.SubTypeID);
            ViewBag.TypeID = new SelectList(db.AssetType, "ID", "Type", fleetAsset.TypeID);
            ViewBag.FleetAssetMakeID = new SelectList(db.FleetAssetMake, "ID", "Manufacturer", fleetAsset.FleetAssetMakeID);
            ViewBag.FleetAssetModelID = new SelectList(db.FleetAssetModel, "ID", "Name", fleetAsset.FleetAssetModelID);
            ViewBag.FuelTypeID = new SelectList(db.FuelType, "ID", "Fuel", fleetAsset.FuelTypeID);
            return View(fleetAsset);
        }

        // GET: FleetAssets/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FleetAsset fleetAsset = db.FleetAsset.Find(id);
            if (fleetAsset == null)
            {
                return HttpNotFound();
            }
            return View(fleetAsset);
        }

        // POST: FleetAssets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            FleetAsset fleetAsset = db.FleetAsset.Find(id);
            db.FleetAsset.Remove(fleetAsset);
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
