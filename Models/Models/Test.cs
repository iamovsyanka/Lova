using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Test
    {
        [Key]
        public int TestId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        public List<Question> Questions { get; set; }
        public List<UserTest> UserTests { get; set; }
        [Required]
        public string Category { get; set; }
    }
}