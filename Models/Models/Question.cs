﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    public class Question
    {
        [Key]
        public virtual int QuestionId { get; set; }

        [Required]
        [ForeignKey("Test")]
        public virtual int TestId { get; set; }

        [Required]
        public virtual Test Test { get; set; }

        [Required]
        public virtual string Description { get; set; }

        [Required]
        public virtual string Answer { get; set; }
    }
}