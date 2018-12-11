﻿using System;
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
    public class CompliencesController : Controller
    {
        private VehicleSetupEntities db = new VehicleSetupEntities();

        // GET: Compliences
        public ActionResult Index()
        {
            var compliences = db.Compliences.Include(c => c.ComplienceSubType).Include(c => c.ComplienceType).Include(c => c.FleetAsset);
            return View(compliences.ToList());
        }
        #region views
        public ActionResult License()
        {
            var license = db.LicenseViews;
            return View(license.ToList());
        }
        public ActionResult Insurance()
        {
            var insurance = db.InsuranceViews;
            return View(insurance.ToList());
        }
        public ActionResult AccredDriver()
        {
            var accDrv = db.AccredDriverViews;
            return View("AccreditationDriverView",accDrv.ToList());
        }
        public ActionResult AccredTrailer()
        {
            var accTrl = db.AccredTrailerViews;
            return View("AccreditationTrailerView",accTrl.ToList());
        }

        public ActionResult AccredSubCon()
        {
            var accSuB = db.AccredSubcontViews;
            return View("AccreditationSubContractorView", accSuB.ToList());
        }
        public ActionResult InductionDriver()
        {
            var indDrv = db.InductionDriverViews;
            return View("InductionDriverView", indDrv.ToList());
        }
        public ActionResult InductionSubCon()
        {
            var indSuC = db.InductionSubcontractorViews;
            return View("InductionSubContractorView", indSuC.ToList());
        }
        public ActionResult RatingVehicle()
        {
            var rtVeh = db.RatingVehicleViews;
            return View("RatingVehicleView", rtVeh.ToList());
        }
        public ActionResult RatingTrailer()
        {
            var rtVeh = db.RatingTrailerViews;
            return View("RatingTrailerView", rtVeh.ToList());
        }
        public ActionResult RegVehicle()
        {
            var regVeh = db.RegVehicleVIews;
            return View("RegistrationVehicleView", regVeh.ToList());
        }
        public ActionResult RegTrailer()
        {
            var regVeh = db.RegTrailerViews;
            return View("RegistrationTrailerView", regVeh.ToList());
        }
        #endregion
        // GET: Compliences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Complience complience = db.Compliences.Find(id);
            if (complience == null)
            {
                return HttpNotFound();
            }
            return View(complience);
        }

        // GET: Compliences/Create
        public ActionResult Create()
        {
            ViewBag.TypeID = new SelectList(db.ComplienceSubTypes, "ID", "Name");
            ViewBag.ComplienceTypeID = new SelectList(db.ComplienceTypes, "ID", "Class");
            ViewBag.FleetNo = new SelectList(db.FleetAssets, "FleetNo", "RegistrationNo");
            return View();
        }

        // POST: Compliences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FleetNo,ComplienceTypeID,TypeID,LicenceClass,LicenseNo,DateObtained,ValidFromDate,ExpiryDate,AlertOperation")] Complience complience)
        {
            if (ModelState.IsValid)
            {
                db.Compliences.Add(complience);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TypeID = new SelectList(db.ComplienceSubTypes, "ID", "Name", complience.TypeID);
            ViewBag.ComplienceTypeID = new SelectList(db.ComplienceTypes, "ID", "Class", complience.ComplienceTypeID);
            ViewBag.FleetNo = new SelectList(db.FleetAssets, "FleetNo", "RegistrationNo", complience.FleetNo);
            return View(complience);
        }

        // GET: Compliences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Complience complience = db.Compliences.Find(id);
            if (complience == null)
            {
                return HttpNotFound();
            }
            ViewBag.TypeID = new SelectList(db.ComplienceSubTypes, "ID", "Name", complience.TypeID);
            ViewBag.ComplienceTypeID = new SelectList(db.ComplienceTypes, "ID", "Class", complience.ComplienceTypeID);
            ViewBag.FleetNo = new SelectList(db.FleetAssets, "FleetNo", "RegistrationNo", complience.FleetNo);
            return View(complience);
        }

        // POST: Compliences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FleetNo,ComplienceTypeID,TypeID,LicenceClass,LicenseNo,DateObtained,ValidFromDate,ExpiryDate,AlertOperation")] Complience complience)
        {
            if (ModelState.IsValid)
            {
                db.Entry(complience).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TypeID = new SelectList(db.ComplienceSubTypes, "ID", "Name", complience.TypeID);
            ViewBag.ComplienceTypeID = new SelectList(db.ComplienceTypes, "ID", "Class", complience.ComplienceTypeID);
            ViewBag.FleetNo = new SelectList(db.FleetAssets, "FleetNo", "RegistrationNo", complience.FleetNo);
            return View(complience);
        }

        // GET: Compliences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Complience complience = db.Compliences.Find(id);
            if (complience == null)
            {
                return HttpNotFound();
            }
            return View(complience);
        }

        // POST: Compliences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Complience complience = db.Compliences.Find(id);
            db.Compliences.Remove(complience);
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