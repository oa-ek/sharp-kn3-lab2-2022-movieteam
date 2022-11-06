﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesCore
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? PosterPath { get; set; }

        public float? Rating { get; set; }
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }

        public virtual ICollection<Genre>? Genres { get; set; } = new List<Genre>();
        public virtual ICollection<Director>? Directors { get; set; } = new List<Director>();
        public virtual ICollection<Actor>? Actors { get; set; } = new List<Actor>();
        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
