using System.Collections.Generic;

namespace tGhWebsite.Models
{
    public class AdminViewModel
    {
        public List<ApplicationUser> GebruikerList { get; set; }
        public List<Ban> BanList { get; set; }
        public List<Category> CategoryList { get; set; }
        public List<News> NewsList { get; set; }
        public List<Rank> RankList { get; set; }
        public List<Reply> ReplyList { get; set; }
        public List<Roles> RoleList { get; set; }
        public List<SubCategory> SubCategoryList { get; set; }
        public List<Topic> TopicLists { get; set; }
    }
}