using System.Linq;
using System.Net;
using System.Web.Mvc;
using tGhWebsite.Models;

namespace tGhWebsite.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        public ActionResult Details(string name)
        {
            var user = db.Users.Where(x => x.UserName == name);
            return View(user.FirstOrDefault());
        }
        
        public ActionResult Delete(string name)
        {
            var user = db.Users.Where(x => x.UserName == name);
            return View(user.FirstOrDefault());
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();

                return RedirectToAction("Index", "Admin");
            }
            catch
            {
                return View();
            }
        }
    }
}
