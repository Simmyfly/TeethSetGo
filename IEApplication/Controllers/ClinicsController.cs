using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IEApplication.Models;

namespace IEApplication.Controllers
{
    public class ClinicsController : Controller
    {
        private IEDatabaseEntities db = new IEDatabaseEntities();

        // GET: Clinics
        public ActionResult Index()
        {
            return View(db.google_map.ToList());
        }

        // GET: Clinics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            google_map google_map = db.google_map.Find(id);
            if (google_map == null)
            {
                return HttpNotFound();
            }
            return View(google_map);
        }

        // GET: Clinics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clinics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,clinicName,Lat,Long,contact,Region")] google_map google_map)
        {
            if (ModelState.IsValid)
            {
                db.google_map.Add(google_map);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(google_map);
        }

        // GET: Clinics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            google_map google_map = db.google_map.Find(id);
            if (google_map == null)
            {
                return HttpNotFound();
            }
            return View(google_map);
        }

        // POST: Clinics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,clinicName,Lat,Long,contact,Region")] google_map google_map)
        {
            if (ModelState.IsValid)
            {
                db.Entry(google_map).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(google_map);
        }

        // GET: Clinics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            google_map google_map = db.google_map.Find(id);
            if (google_map == null)
            {
                return HttpNotFound();
            }
            return View(google_map);
        }

        // POST: Clinics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            google_map google_map = db.google_map.Find(id);
            db.google_map.Remove(google_map);
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
