using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace tGhWebsite.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public int SubCategoryId { get; set; }
        
        public string TopicSubject { get; set; }
        public string TopicContext { get; set; }
        public int TopicCreateDate { get; set; }
        public int TopicViews { get; set; }
        public int ThreadReply { get; set; }

        public string LastReplyUsername { get; set; }
        public int LastReplyCreateDate { get; set; }

        public virtual SubCategory SubCategory { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Reply> ReplyCollection { get; set; }
    }
}