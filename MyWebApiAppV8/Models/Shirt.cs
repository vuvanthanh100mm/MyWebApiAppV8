﻿using System.ComponentModel.DataAnnotations;
using MyWebApiAppV8.Models.Validations;

namespace MyWebApiAppV8.Models
{
    public class Shirt
    {
        public int ShirtId { get; set; }

        [Required]
        public string? Brand { get; set; }

        [Required]
        public string? Color { get; set; }

        [Shirt_EnsureCorrectSizing]
        public int Size { get; set; }

        [Required]
        public string? Gender { get; set; }

        public double Price { get; set; }

    }
}
