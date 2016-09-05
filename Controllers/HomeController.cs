using System.Web.Mvc;

namespace tGhWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}