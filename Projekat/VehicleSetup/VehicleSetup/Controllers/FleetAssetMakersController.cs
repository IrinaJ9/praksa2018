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
    public class FleetAssetMakersController : Controller
    {
        private VehicleSetupEntities db = new VehicleSetupEntities();

        // GET: FleetAssetMakers
        public ActionResult Index()
        {
            return View(db.FleetAssetMake.ToList());
        }

        // GET: FleetAssetMakers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FleetAssetMake fleetAssetMake = db.FleetAssetMake.Find(id);
            if (fleetAssetMake == null)
            {
                return HttpNotFound();
            }
            return View(fleetAssetMake);
        }

        // GET: FleetAssetMakers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FleetAssetMakers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Manufacturer")] FleetAssetMake fleetAssetMake)
        {
            if (ModelState.IsValid)
            {
                db.FleetAssetMake.Add(fleetAssetMake);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fleetAssetMake);
        }

        // GET: FleetAssetMakers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FleetAssetMake fleetAssetMake = db.FleetAssetMake.Find(id);
            if (fleetAssetMake == null)
            {
                return HttpNotFound();
            }
            return View(fleetAssetMake);
        }

        // POST: FleetAssetMakers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Manufacturer")] FleetAssetMake fleetAssetMake)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fleetAssetMake).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fleetAssetMake);
        }

        // GET: FleetAssetMakers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FleetAssetMake fleetAssetMake = db.FleetAssetMake.Find(id);
            if (fleetAssetMake == null)
            {
                return HttpNotFound();
            }
            return View(fleetAssetMake);
        }

        // POST: FleetAssetMakers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FleetAssetMake fleetAssetMake = db.FleetAssetMake.Find(id);
            db.FleetAssetMake.Remove(fleetAssetMake);
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
