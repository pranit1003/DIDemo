﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DIDemo.Models
{
   

        [Table("Product")]
        public class Product
        {
            [Key]
            [ScaffoldColumn(false)]
            public int Id { get; set; }
            [Required]
            public string? Name { get; set; }
            [Required]
            public string? Company { get; set; }
            [Required]
            public int Price { get; set; }
        }
    }


