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
    public class RankController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Rank
        public ActionResult Index()
        {
            return View(db.Rank.ToList());
        }

        // GET: Rank/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rank rank = db.Rank.Find(id);
            if (rank == null)
            {
                return HttpNotFound();
            }
            return View(rank);
        }

        // GET: Rank/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rank/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RankId,RankName,RankMinPost")] Rank rank)
        {
            if (ModelState.IsValid)
            {
                db.Rank.Add(rank);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rank);
        }

        // GET: Rank/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rank rank = db.Rank.Find(id);
            if (rank == null)
            {
                return HttpNotFound();
            }
            return View(rank);
        }

        // POST: Rank/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RankId,RankName,RankMinPost")] Rank rank)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rank).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rank);
        }

        // GET: Rank/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rank rank = db.Rank.Find(id);
            if (rank == null)
            {
                return HttpNotFound();
            }
            return View(rank);
        }

        // POST: Rank/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rank rank = db.Rank.Find(id);
            db.Rank.Remove(rank);
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
