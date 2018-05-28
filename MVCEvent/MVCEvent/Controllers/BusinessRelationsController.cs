using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCEvent;

namespace MVCEvent.Controllers
{
    [Authorize]
    public class BusinessRelationsController : Controller
    {
        private dummydbEntities db = new dummydbEntities();

        // GET: BusinessRelations
        public ActionResult Index()
        {
            return View(db.BusinessRelations.ToList());
        }

        // GET: BusinessRelations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessRelations businessRelations = db.BusinessRelations.Find(id);
            if (businessRelations == null)
            {
                return HttpNotFound();
            }
            return View(businessRelations);
        }

        // GET: BusinessRelations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusinessRelations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,businessId,eventId")] BusinessRelations businessRelations)
        {
            if (ModelState.IsValid)
            {
                db.BusinessRelations.Add(businessRelations);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(businessRelations);
        }

        // GET: BusinessRelations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessRelations businessRelations = db.BusinessRelations.Find(id);
            if (businessRelations == null)
            {
                return HttpNotFound();
            }
            return View(businessRelations);
        }

        // POST: BusinessRelations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,businessId,eventId")] BusinessRelations businessRelations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(businessRelations).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(businessRelations);
        }

        // GET: BusinessRelations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessRelations businessRelations = db.BusinessRelations.Find(id);
            if (businessRelations == null)
            {
                return HttpNotFound();
            }
            return View(businessRelations);
        }

        // POST: BusinessRelations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BusinessRelations businessRelations = db.BusinessRelations.Find(id);
            db.BusinessRelations.Remove(businessRelations);
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
