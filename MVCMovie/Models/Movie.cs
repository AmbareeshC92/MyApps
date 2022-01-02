﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [Display(Name ="Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Column(TypeName ="decimal(8,2)")]
        public decimal Price { get; set; }
    }
}
