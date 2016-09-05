using System.Collections.Generic;

namespace tGhWebsite.Models
{
    public class Roles
    {
        public int RolesId { get; set; }
        
        public string RoleName { get; set; }

        public virtual ICollection<ApplicationUser> UserCollection { get; set; }
        public virtual ICollection<ForumPerm> ForumPermCollection { get; set; }
    }
}