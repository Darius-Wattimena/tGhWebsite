using System.ComponentModel.DataAnnotations.Schema;

namespace tGhWebsite.Models
{
    public class Reply
    {
        public int ReplyId { get; set; }
        public int TopicId { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]

        public string ReplyContext { get; set; }
        public int ReplyDateTime { get; set; }

        public virtual Topic Topic { get; set; }
        
        public ApplicationUser User { get; set; }
    }
}