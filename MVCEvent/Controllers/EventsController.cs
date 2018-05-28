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
    public class EventsController : Controller
    {
        private EventsDatabaseEntities db = new EventsDatabaseEntities();
        private UserService.Service1Client userClient = new UserService.Service1Client();

        // PROCSS: Data
        public string getUsername(int userId)
        {
            return userClient.GetUsername(userId);
        }

        // GET: Events
        public ActionResult Index()
        {            
            List<BasicEvent> events = new List<BasicEvent>();

            

            foreach (var item in db.Events.Include(e => e.Categories))
            {
                BasicEvent format = new BasicEvent();
                format.id = item.id;
                format.name = item.name;
                format.description = item.description;
                format.creator = getUsername(item.userId);
                format.category = item.Categories.name;

                events.Add(format);
            }

            return View(events);
        }

        // GET: Events/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            BasicEvent basicEvent = new BasicEvent();

            Events tmp = db.Events.Find(id);

            basicEvent.id = tmp.id;
            basicEvent.name = tmp.name;
            basicEvent.description = tmp.description;
            basicEvent.date = tmp.date;
            basicEvent.creator = getUsername(tmp.userId);
            basicEvent.category = tmp.Categories.name;


            return View(basicEvent);
        }

        // GET: Events/Create
        public ActionResult Create()
        {
            ViewBag.categoryId = new SelectList(db.Categories, "Id", "name");
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,name,description,date,userId,categoryId")] Events events)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(events);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.categoryId = new SelectList(db.Categories, "Id", "name", events.categoryId);
            return View(events);
        }

        // GET: Events/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Events events = db.Events.Find(id);
            if (events == null)
            {
                return HttpNotFound();
            }
            ViewBag.categoryId = new SelectList(db.Categories, "Id", "name", events.categoryId);
            return View(events);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,name,description,date,userId,categoryId")] Events events)
        {
            if (ModelState.IsValid)
            {
                db.Entry(events).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.categoryId = new SelectList(db.Categories, "Id", "name", events.categoryId);
            return View(events);
        }

        // GET: Events/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            BasicEvent basicEvent = new BasicEvent();

            Events tmp = db.Events.Find(id);

            basicEvent.id = tmp.id;
            basicEvent.name = tmp.name;
            basicEvent.description = tmp.description;
            basicEvent.date = tmp.date;
            basicEvent.creator = getUsername(tmp.userId);
            basicEvent.category = tmp.Categories.name;


            return View(basicEvent);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Events events = db.Events.Find(id);
            db.Events.Remove(events);
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
