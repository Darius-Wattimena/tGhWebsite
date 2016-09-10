using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using tGhWebsite.Models;

namespace tGhWebsite.Controllers
{
    public class UserRoleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        public ActionResult Index()
        {
            return View(db.UserRole.ToList());
        }
        
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserRolesId,UserRoleName,UserRoleColorCode")] UserRole userRoles)
        {
            if (ModelState.IsValid)
            {
                db.UserRole.Add(userRoles);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userRoles);
        }
        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var userRoles = db.UserRole.Find(id);
            if (userRoles == null)
            {
                return HttpNotFound();
            }
            return View(userRoles);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserRolesId,UserRoleName,UserRoleColorCode")] UserRole userRoles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userRoles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userRoles);
        }
        
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var userRoles = db.UserRole.Find(id);
            if (userRoles == null)
            {
                return HttpNotFound();
            }
            return View(userRoles);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserRole UserRoles = db.UserRole.Find(id);
            db.UserRole.Remove(UserRoles);
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
