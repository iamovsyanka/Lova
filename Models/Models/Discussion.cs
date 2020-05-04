using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    public class Discussion
    {
        [Key]
        public virtual int DiscussionId { get; set; }

        [Required]
        public virtual string DiscussionName { get; set; }
        public virtual string Text { get; set; }

        public virtual List<Message> Messages { get; set; }

        [Required]
        public virtual Forum Forum { get; set; }

        [Required]
        [ForeignKey("Forum")]
        public virtual int ForumId { get; set; }

    }
}
