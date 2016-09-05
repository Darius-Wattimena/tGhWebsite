using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace tGhWebsite.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string UserDisplayName { get; set; }
        public string UserTitel { get; set; }
        public string UserSignature { get; set; }
        public string UserTimezone { get; set; }
        public string UserLocation { get; set; }
        public string UserRealName { get; set; }
        public string UserUrl { get; set; }
        public string UserSteam { get; set; }
        public string UserRegistrationIp { get; set; }

        public int UserDateOfBirth { get; set; }
        public int UserNumPosts { get; set; }
        public int UserKarma { get; set; }
        public int UserLastVisit { get; set; }
        public int UserRegistrationDate { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Ban> Ban { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ForumPerm> ForumPerm { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Rank> Rank { get; set; }
        public DbSet<Reply> Reply { get; set; }
        public DbSet<Roles> MyRoles { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<Topic> Topic { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}