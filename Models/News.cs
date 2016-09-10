using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace tGhWebsite.Models
{
    public class News
    {
        public int NewsId { get; set; }
        
        public string NewsTitel { get; set; }
        public string NewsContext { get; set; }
        public int? NewsDate { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}