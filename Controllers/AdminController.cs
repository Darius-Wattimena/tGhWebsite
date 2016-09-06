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
            var vm = new AdminViewModel
            {
                BanList = db.Ban.ToList(),
                CategoryList = db.Category.ToList(),
                GebruikerList = db.Users.ToList(),
                NewsList = db.News.ToList(),
                RankList = db.Rank.ToList(),
                ReplyList = db.Reply.ToList(),
                SubCategoryList = db.SubCategory.ToList(),
                UserRoleList = db.UserRole.ToList(),
                TopicLists = db.Topic.ToList(),
            };

            return View(vm);
        }

        public ActionResult UserManagement()
        {
            return View(db.Users.ToList());
        }
    }
}
/*
 * @foreach (var item in Model)
                    {
                        <tr>
                            <td>@Html.DisplayFor(modelItem => item.UserName)</td>
                            <td>@Html.DisplayFor(modelItem => item.UserDisplayName)</td>
                            <td>@Html.DisplayFor(modelItem => item.UserDateOfBirth)</td>
                        </tr>
                    }
*/