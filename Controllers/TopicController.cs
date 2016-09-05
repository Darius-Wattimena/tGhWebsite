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
    public class TopicController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Topic
        public ActionResult Index()
        {
            var topic = db.Topic.Include(t => t.SubCategory);
            return View(topic.ToList());
        }

        // GET: Topic/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Topic topic = db.Topic.Find(id);
            if (topic == null)
            {
                return HttpNotFound();
            }
            return View(topic);
        }

        // GET: Topic/Create
        public ActionResult Create()
        {
            ViewBag.SubCategoryId = new SelectList(db.SubCategory, "SubCategoryId", "SubCategoryName");
            return View();
        }

        // POST: Topic/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TopicId,UserId,SubCategoryId,TopicSubject,TopicContext,TopicCreateDate,TopicViews,ThreadReply,LastReplyUsername,LastReplyCreateDate")] Topic topic)
        {
            if (ModelState.IsValid)
            {
                db.Topic.Add(topic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SubCategoryId = new SelectList(db.SubCategory, "SubCategoryId", "SubCategoryName", topic.SubCategoryId);
            return View(topic);
        }

        // GET: Topic/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Topic topic = db.Topic.Find(id);
            if (topic == null)
            {
                return HttpNotFound();
            }
            ViewBag.SubCategoryId = new SelectList(db.SubCategory, "SubCategoryId", "SubCategoryName", topic.SubCategoryId);
            return View(topic);
        }

        // POST: Topic/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TopicId,UserId,SubCategoryId,TopicSubject,TopicContext,TopicCreateDate,TopicViews,ThreadReply,LastReplyUsername,LastReplyCreateDate")] Topic topic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(topic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SubCategoryId = new SelectList(db.SubCategory, "SubCategoryId", "SubCategoryName", topic.SubCategoryId);
            return View(topic);
        }

        // GET: Topic/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Topic topic = db.Topic.Find(id);
            if (topic == null)
            {
                return HttpNotFound();
            }
            return View(topic);
        }

        // POST: Topic/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Topic topic = db.Topic.Find(id);
            db.Topic.Remove(topic);
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
