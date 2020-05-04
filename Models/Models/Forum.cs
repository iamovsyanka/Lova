using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Forum
    {
        [Key]
        public virtual int ForumId { get; set; }
        public virtual List<Discussion> Discussions { get; set; }
    }
}
