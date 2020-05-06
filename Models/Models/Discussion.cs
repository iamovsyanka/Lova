using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Discussion
    {
        [Key]
        public virtual int DiscussionId { get; set; }

        [Required]
        public virtual string DiscussionName { get; set; }

        [Required]
        public virtual string Text { get; set; }

        public virtual List<Message> Messages { get; set; }
    }
}
