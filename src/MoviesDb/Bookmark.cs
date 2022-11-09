using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesCore
{
	public class Bookmark
	{
        [Key]
        public int Id { get; set; }
        public User? User { get; set; }
        public Movie? Movie { get; set; }
    }
}
