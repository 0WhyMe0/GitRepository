﻿using System.ComponentModel.DataAnnotations;

namespace Web_1.Models
{
    public class Category
    {
        [Key]

        public int Id { get; set; }

        public string Name { get; set; }

        public string DisplayOrder { get; set; }
    }
}
