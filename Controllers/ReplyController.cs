using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using tGhWebsite.Models;

namespace tGhWebsite.Controllers
{
    public class ReplyController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Reply
        public ActionResult Index()
        {
            var reply = db.Reply.Include(r => r.Topic);
            return View(reply.ToList());
        }

        // GET: Reply/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reply reply = db.Reply.Find(id);
            if (reply == null)
            {
                return HttpNotFound();
            }
            return View(reply);
        }

        // GET: Reply/Create
        public ActionResult Create()
        {
            ViewBag.TopicId = new SelectList(db.Topic, "TopicId", "TopicSubject");
            return View();
        }

        // POST: Reply/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReplyId,TopicId,UserId,ReplyContext,ReplyDateTime")] Reply reply)
        {
            if (ModelState.IsValid)
            {
                db.Reply.Add(reply);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TopicId = new SelectList(db.Topic, "TopicId", "TopicSubject", reply.TopicId);
            return View(reply);
        }

        // GET: Reply/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reply reply = db.Reply.Find(id);
            if (reply == null)
            {
                return HttpNotFound();
            }
            ViewBag.TopicId = new SelectList(db.Topic, "TopicId", "TopicSubject", reply.TopicId);
            return View(reply);
        }

        // POST: Reply/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReplyId,TopicId,UserId,ReplyContext,ReplyDateTime")] Reply reply)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reply).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TopicId = new SelectList(db.Topic, "TopicId", "TopicSubject", reply.TopicId);
            return View(reply);
        }

        // GET: Reply/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reply reply = db.Reply.Find(id);
            if (reply == null)
            {
                return HttpNotFound();
            }
            return View(reply);
        }

        // POST: Reply/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reply reply = db.Reply.Find(id);
            db.Reply.Remove(reply);
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
