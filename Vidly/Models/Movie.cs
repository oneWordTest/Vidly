﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        public string ReleaseDate { get; set; }

        public string DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1, 30)]
        public int NumberInStock { get; set; }
    }
}