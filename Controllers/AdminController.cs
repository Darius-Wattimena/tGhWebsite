using System.Linq;
using System.Web.Mvc;
using tGhWebsite.Models;

namespace tGhWebsite.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var adminViewModel = new AdminViewModel()
            {
                BanList = db.Ban.ToList(),
                CategoryList = db.Category.ToList(),
                GebruikerList = db.Users.ToList(),
                NewsList = db.News.ToList(),
                RankList = db.Rank.ToList(),
                ReplyList = db.Reply.ToList(),
                SubCategoryList = db.SubCategory.ToList(),
                RoleList = db.MyRoles.ToList(),
                TopicLists = db.Topic.ToList()
            };
            return View(adminViewModel);
        }
    }
}