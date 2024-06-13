﻿using System.ComponentModel.DataAnnotations;

namespace HeavenHome.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //relationships
        public List<Company> Companies { get; set; }
    }
}
