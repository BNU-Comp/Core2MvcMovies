using System;
using System.ComponentModel.DataAnnotations;

namespace CoreMvcMovies2019.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public Genres Genre { get; set; }
        public decimal Price { get; set; }
    }

    public enum Genres
    {
        Romance,
        Comedy,
        Thriller,
        Action,
        Documentary,
        Western
    }
}
