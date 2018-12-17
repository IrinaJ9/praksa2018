using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VehicleSetup3.Models;

namespace VehicleSetup3.Controllers
{
    public class FleetAssetsController : Controller
    {
        private VehicleSetupEntities db = new VehicleSetupEntities();

        // GET: FleetAssets
        public ActionResult Index()
        {
            var fleetAssets = db.FleetAssets.Include(f => f.AssetSubType).Include(f => f.AssetType).Include(f => f.FleetAssetMake).Include(f => f.FleetAssetModel).Include(f => f.FuelType);
            return View(fleetAssets.ToList());
        }

        // GET: FleetAssets/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FleetAsset fleetAsset = db.FleetAssets.Find(id);
            if (fleetAsset == null)
            {
                return HttpNotFound();
            }
            return View(fleetAsset);
        }

        // GET: FleetAssets/Create
        public ActionResult Create()
        {
            ViewBag.SubTypeID = new SelectList(db.AssetSubTypes, "ID", "SubType");
            ViewBag.TypeID = new SelectList(db.AssetTypes, "ID", "Type");
            ViewBag.FleetAssetMakeID = new SelectList(db.FleetAssetMakes, "ID", "Manufacturer");
            ViewBag.FleetAssetModelID = new SelectList(db.FleetAssetModels, "ID", "Name");
            ViewBag.FuelTypeID = new SelectList(db.FuelTypes, "ID", "Fuel");
            ViewBag.Capacity = db.Capacities;
            ViewBag.AdditionalFields = db.AdditionalFields;
            ViewBag.Attachments = db.Attachments;
            ViewBag.Compliences = db.Compliences;
            return View();
        }

        // POST: FleetAssets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FleetAsset fleetAsset, Capacity capacity, AdditionalField additionalField, Attachment attachment, Complience complience)
        {
            if (ModelState.IsValid)
            {
                db.FleetAssets.Add(fleetAsset);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SubTypeID = new SelectList(db.AssetSubTypes, "ID", "SubType", fleetAsset.SubTypeID);
            ViewBag.TypeID = new SelectList(db.AssetTypes, "ID", "Type", fleetAsset.TypeID);
            ViewBag.FleetAssetMakeID = new SelectList(db.FleetAssetMakes, "ID", "Manufacturer", fleetAsset.FleetAssetMakeID);
            ViewBag.FleetAssetModelID = new SelectList(db.FleetAssetModels, "ID", "Name", fleetAsset.FleetAssetModelID);
            ViewBag.FuelTypeID = new SelectList(db.FuelTypes, "ID", "Fuel", fleetAsset.FuelTypeID);
            return View(fleetAsset);
        }

        // GET: FleetAssets/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FleetAsset fleetAsset = db.FleetAssets.Find(id);
            if (fleetAsset == null)
            {
                return HttpNotFound();
            }
            ViewBag.SubTypeID = new SelectList(db.AssetSubTypes, "ID", "SubType", fleetAsset.SubTypeID);
            ViewBag.TypeID = new SelectList(db.AssetTypes, "ID", "Type", fleetAsset.TypeID);
            ViewBag.FleetAssetMakeID = new SelectList(db.FleetAssetMakes, "ID", "Manufacturer", fleetAsset.FleetAssetMakeID);
            ViewBag.FleetAssetModelID = new SelectList(db.FleetAssetModels, "ID", "Name", fleetAsset.FleetAssetModelID);
            ViewBag.FuelTypeID = new SelectList(db.FuelTypes, "ID", "Fuel", fleetAsset.FuelTypeID);
            return View(fleetAsset);
        }

        // POST: FleetAssets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FleetNo,RegistrationNo,Depot,Year,Description,FleetAssetMakeID,FleetAssetModelID,TypeID,SubTypeID,AxelWeight1,AxelWeight2,AxelWeight3,FuelTypeID")] FleetAsset fleetAsset)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fleetAsset).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SubTypeID = new SelectList(db.AssetSubTypes, "ID", "SubType", fleetAsset.SubTypeID);
            ViewBag.TypeID = new SelectList(db.AssetTypes, "ID", "Type", fleetAsset.TypeID);
            ViewBag.FleetAssetMakeID = new SelectList(db.FleetAssetMakes, "ID", "Manufacturer", fleetAsset.FleetAssetMakeID);
            ViewBag.FleetAssetModelID = new SelectList(db.FleetAssetModels, "ID", "Name", fleetAsset.FleetAssetModelID);
            ViewBag.FuelTypeID = new SelectList(db.FuelTypes, "ID", "Fuel", fleetAsset.FuelTypeID);
            return View(fleetAsset);
        }

        // GET: FleetAssets/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FleetAsset fleetAsset = db.FleetAssets.Find(id);
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
            FleetAsset fleetAsset = db.FleetAssets.Find(id);
            db.FleetAssets.Remove(fleetAsset);
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
