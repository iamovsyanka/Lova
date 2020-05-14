using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    public class UserTest
    {
        [Key]
        public virtual int UserTestId { get; set; }

        [Required]
        [ForeignKey("User")]
        public virtual int UserId { get; set; }

        [Required]
        public virtual User User { get; set; }

        [Required]
        public virtual string UserName { get; set; }

        [Required]
        [ForeignKey("Test")]
        public virtual int TestId { get; set; }

        [Required]
        public virtual Test Test { get; set; }

        [Required]
        public virtual string TestName { get; set; }

        [Required]
        public virtual DateTime SolvedTime { get; set; }

        [Required]
        public virtual string Result { get; set; }
    }
}