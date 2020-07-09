using System;
using System.ComponentModel.DataAnnotations;

namespace mvc_app.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
        public double IMDbScore { get; set; }
    }
}