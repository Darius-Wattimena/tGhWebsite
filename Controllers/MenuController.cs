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

        public PartialViewResult _AdminNavbar()
        {
            return PartialView("~/Views/Shared/_AdminNavbar.cshtml");
        }
        
        public PartialViewResult _AdminHeader()
        {
            return PartialView("~/Views/Shared/_AdminHeader.cshtml");
        }

        public PartialViewResult _AdminFooter()
        {
            return PartialView("~/Views/Shared/_AdminFooter.cshtml");
        }
    }
}