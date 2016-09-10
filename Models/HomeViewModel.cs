using System.Collections.Generic;

namespace tGhWebsite.Models
{
    public class HomeViewModel
    {
        public List<News> NewsList { get; set; }
        public List<ApplicationUser> GebruikerList { get; set; }
    }
}