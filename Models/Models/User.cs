﻿using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class User
    {
        public User()
        {
            Tests = new List<UserTest>();
            Messages = new List<Message>();
        }

        [Key]
        public virtual int Id { get; set; }

        [Required]
        [MinLength(4), MaxLength(20)]
        public virtual string UserName { get; set; }
        
        [Required]
        public virtual Guid Password { get; set; }

        [Required]
        public virtual Role Role { get; set; }

        public virtual List<UserTest> Tests { get; set; }

        public virtual List<Message> Messages { get; set; }
    }
}
