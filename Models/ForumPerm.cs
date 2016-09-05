namespace tGhWebsite.Models
{
    public class ForumPerm
    {
        public int ForumPermId { get; set; }
        public int RolId { get; set; }
        public int SubCategoryId { get; set; }

        public int ReadForum { get; set; }
        public int PostReply { get; set; }
        public int PostThreads { get; set; }

        public virtual Roles Roles { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}