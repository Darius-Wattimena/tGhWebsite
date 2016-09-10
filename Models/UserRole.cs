using System.Collections.Generic;

namespace tGhWebsite.Models
{
    public class UserRole
    {
        public int UserRoleId { get; set; }
        
        public string UserRoleName { get; set; }

        public string UserRoleColorCode { get; set; }

        public virtual ICollection<ApplicationUser> UserCollection { get; set; }
        public virtual ICollection<ForumPerm> ForumPermCollection { get; set; }
    }
}