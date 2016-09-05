using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tGhWebsite.Models
{
    public class ForumViewModel
    {
        public List<ApplicationUser> GebruikerList { get; set; }
        public List<Ban> BanList { get; set; }
        public List<Category> CategoryList { get; set; }
        public List<Rank> RankList { get; set; }
        public List<Reply> ReplyList { get; set; }
        public List<Roles> Roles { get; set; }
        public List<SubCategory> SubCategories { get; set; }
        public List<Topic> Topics { get; set; }
    }
}