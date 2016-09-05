using System;

namespace tGhWebsite.Models
{
    public class News
    {
        public int NewsId { get; set; }
        public int UserId { get; set; }
        
        public string NewsTitel { get; set; }
        public string NewsContext { get; set; }
        public int NewsDate { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}