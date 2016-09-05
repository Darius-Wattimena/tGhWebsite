using System.Collections.Generic;

namespace tGhWebsite.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        
        public string CategoryName { get; set; }
        public int CategoryDisplayPosition { get; set; }

        public virtual ICollection<SubCategory> SubCategoryCollection { get; set; }
    }
}