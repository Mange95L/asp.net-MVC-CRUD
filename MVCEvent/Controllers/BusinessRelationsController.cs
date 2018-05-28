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
        private EventsDatabaseEntities db = new EventsDatabaseEntities();        
        private BusinessService.Service1Client businessClient = new BusinessService.Service1Client();

        public string getEventName(int eventId)
        {
            Events tmp = db.Events.Find(eventId);
            return tmp.name;
        }

        public string getBusinessName(int businessId)
        {
            return businessClient.GetBusinessNameById(businessId);
        }

        // GET: BusinessRelations
        public ActionResult Index()
        {
            List<BasicConnection> connections = new List<BasicConnection>();

            foreach (var item in db.BusinessConnections)
            {
                BasicConnection tmp = new BasicConnection();

                tmp.id = item.id;
                tmp.businessName = getBusinessName(item.businessId);
                tmp.eventName = getEventName(item.eventId);

                connections.Add(tmp);
            }

            return View(connections);
        }

        // GET: BusinessRelations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            BasicConnection connection = new BasicConnection();

            BusinessConnections tmp = db.BusinessConnections.Find(id);

            connection.id = tmp.id;
            connection.businessName = getBusinessName(tmp.businessId);
            connection.eventName = getEventName(tmp.eventId);

            return View(connection);
        }

        // GET: BusinessRelations/Create
        public ActionResult Create()
        {
            ViewBag.BusinessId = new SelectList(db.BusinessConnections, "eventId", "businessId");
            ViewBag.EventId = new SelectList(db.BusinessConnections, "businessId", "eventId");

            return View();
        }

        // POST: BusinessRelations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,businessId,eventId")] BusinessConnections businessRelations)
        {
            if (ModelState.IsValid)
            {
                db.BusinessConnections.Add(businessRelations);
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
            BusinessConnections businessRelations = db.BusinessConnections.Find(id);
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
        public ActionResult Edit([Bind(Include = "Id,businessId,eventId")] BusinessConnections businessRelations)
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

            BasicConnection connection = new BasicConnection();

            BusinessConnections tmp = db.BusinessConnections.Find(id);

            connection.id = tmp.id;
            connection.businessName = getBusinessName(tmp.businessId);
            connection.eventName = getEventName(tmp.eventId);

            return View(connection);
        }

        // POST: BusinessRelations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BusinessConnections businessRelations = db.BusinessConnections.Find(id);
            db.BusinessConnections.Remove(businessRelations);
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
