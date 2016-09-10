using System.Linq;
using System.Web.Mvc;
using tGhWebsite.Models;

namespace tGhWebsite.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var vm = new HomeViewModel
            {
                NewsList = db.News.OrderByDescending(x => x.NewsDate).Take(4).ToList()
            };
            return View(vm);
        }
    }
}