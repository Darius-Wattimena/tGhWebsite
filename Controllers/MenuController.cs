using System.Web.Mvc;

namespace tGhWebsite.Controllers
{
    public class MenuController : Controller
    {
        public PartialViewResult _Navbar()
        {
            return PartialView("~/Views/Shared/_Navbar.cshtml");
        }

        public PartialViewResult _Footer()
        {
            return PartialView("~/Views/Shared/_Footer.cshtml");
        }

        public PartialViewResult _Header()
        {
            return PartialView("~/Views/Shared/_Header.cshtml");
        }
    }
}