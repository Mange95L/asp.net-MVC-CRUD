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
    public class ParticipantsController : Controller
    {        
        private EventsDatabaseEntities db = new EventsDatabaseEntities();
        private UserService.Service1Client userClient = new UserService.Service1Client();        

        // PROCSS: Data
        public string getUsername(int userId)
        {
            return userClient.GetUsername(userId);
        }

        public string getEventName(int eventId)
        {
            Events tmp = db.Events.Find(eventId);
            return tmp.name;
        }

        // GET: Participants
        public ActionResult Index()
        {
            List<BasicParticipant> participants = new List<BasicParticipant>();

            foreach (var item in db.Participants)
            {
                BasicParticipant tmp = new BasicParticipant();

                tmp.id = item.id;
                tmp.registered = item.registered;
                tmp.username = getUsername(item.userId);
                tmp.eventName = getEventName(item.eventId);

                participants.Add(tmp);
            }

            return View(participants);
        }

        // GET: Participants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Participants tmp = db.Participants.Find(id);

            BasicParticipant participant = new BasicParticipant();

            participant.id = tmp.id;
            participant.registered = tmp.registered;
            participant.username = getUsername(tmp.userId);
            participant.eventName = getEventName(tmp.eventId);                                   

            return View(participant);
        }

        // GET: Participants/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Participants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,registered,userId,eventId")] Participants participants)
        {
            if (ModelState.IsValid)
            {
                db.Participants.Add(participants);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(participants);
        }

        // GET: Participants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Participants participants = db.Participants.Find(id);
            if (participants == null)
            {
                return HttpNotFound();
            }
            return View(participants);
        }

        // POST: Participants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,registered,userId,eventId")] Participants participants)
        {
            if (ModelState.IsValid)
            {
                db.Entry(participants).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(participants);
        }

        // GET: Participants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Participants tmp = db.Participants.Find(id);

            BasicParticipant participant = new BasicParticipant();

            participant.id = tmp.id;
            participant.registered = tmp.registered;
            participant.username = getUsername(tmp.userId);
            participant.eventName = getEventName(tmp.eventId);

            return View(participant);
        }

        // POST: Participants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Participants participants = db.Participants.Find(id);
            db.Participants.Remove(participants);
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
