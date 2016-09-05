using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
                SubCategories = db.SubCategory.ToList(),
                Roles = db.MyRoles.ToList(),
                Topics = db.Topic.ToList()
            };
            return View(adminViewModel);
        }
    }
}