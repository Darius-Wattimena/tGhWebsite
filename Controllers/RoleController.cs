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
    public class RoleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        public ActionResult Index()
        {
            return View(db.MyRoles.ToList());
        }
        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RolesId,RoleName")] Roles roles)
        {
            if (ModelState.IsValid)
            {
                db.MyRoles.Add(roles);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(roles);
        }
        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Roles roles = db.MyRoles.Find(id);
            if (roles == null)
            {
                return HttpNotFound();
            }
            return View(roles);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RolesId,RoleName")] Roles roles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(roles);
        }
        
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Roles roles = db.MyRoles.Find(id);
            if (roles == null)
            {
                return HttpNotFound();
            }
            return View(roles);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Roles roles = db.MyRoles.Find(id);
            db.MyRoles.Remove(roles);
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
