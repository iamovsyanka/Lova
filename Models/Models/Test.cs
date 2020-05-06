using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Test
    {
        [Key]
        public virtual int TestId { get; set; }

        [Required]
        [MaxLength(100)]
        public virtual string Name { get; set; }

        [MaxLength(300)]
        public virtual string Description { get; set; }

        public virtual List<Question> Questions { get; set; }

        public virtual List<UserTest> UserTests { get; set; }

        [Required]
        public virtual string Category { get; set; }
    }
}