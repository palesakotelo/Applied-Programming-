﻿using System.ComponentModel.DataAnnotations;

namespace DisasterAlleviationFoundation.Models
{
    public class UserLogin
    {
        [Key]

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
