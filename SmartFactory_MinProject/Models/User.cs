﻿using System.ComponentModel.DataAnnotations;

namespace SmartFactory_MinProject.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string AccountId { get; set; } = null!;
        public string AccountPassword { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}
