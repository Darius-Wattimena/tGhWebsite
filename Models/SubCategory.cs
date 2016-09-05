using System.Collections.Generic;

namespace tGhWebsite.Models
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        
        public string SubCategoryName { get; set; }
        public string SubCategoryDescription { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Topic> TopicCollection { get; set; }
        public virtual ICollection<ForumPerm> ForumPermeCollection { get; set; }
    }
}