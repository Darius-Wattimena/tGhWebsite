using System;

namespace tGhWebsite.Models
{
    public class Reply
    {
        public int ReplyId { get; set; }
        public int TopicId { get; set; }
        public int UserId { get; set; }

        public string ReplyContext { get; set; }
        public DateTime ReplyDateTime { get; set; }

        public virtual Topic Topic { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}