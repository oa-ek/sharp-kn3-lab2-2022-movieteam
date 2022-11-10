using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MoviesCore
{
    public class Reccomendation
    {
        [Key]
        public string Id { get; set; }
        public User? User { get; set; }
        public Movie? Movie { get; set; }
        public int? Rating { get; set; }

        public Reccomendation()
        {
            this.Movie = User.Movies.First();
        }
    }
}
