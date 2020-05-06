using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    public class Message
    {
        [Key]
        public virtual int MessageId { get; set; }

        [Required]
        public virtual string Text { get; set; }

        [ForeignKey("Discussion")]
        [Required]
        public virtual int DiscussionId { get; set; }

        [Required]
        public virtual Discussion Discussion { get; set; }

        public virtual User User { get; set; }

        [ForeignKey("User")]
        public virtual int UserId { get; set; }

        [Required]
        public virtual string UserName { get; set; }

        [Required]
        public virtual DateTime When { get; set; }
    }
}
