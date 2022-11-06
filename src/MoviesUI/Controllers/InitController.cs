using Microsoft.AspNetCore.Mvc;
using MoviesCore;

namespace MoviesUI.Controllers
{
    public class InitController : Controller
    {
        private readonly MoviesDbContext dbContext;
        public InitController(MoviesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {

            var Chris = new Actor { FirstName = "Chris", LastName = " Evans", PhotoPath = "https://upload.wikimedia.org/wikipedia/commons/8/89/Chris_Evans_2020_%28cropped%29.jpg" };
            var Ryan = new Actor { FirstName = "Ryan", LastName = "Reynolds", PhotoPath = "https://upload.wikimedia.org/wikipedia/commons/1/14/Deadpool_2_Japan_Premiere_Red_Carpet_Ryan_Reynolds_%28cropped%29.jpg" };

            var USA = new PublisherCountry { CountryName = "USA" };
            var Germany = new PublisherCountry { CountryName = "Germany" };

            var James = new Director { FirstName = "James", LastName = "Cameron" };

            var Comedy = new Genre { GenreName = "Comedy" };
            var Drama = new Genre { GenreName = "Drama" };

            var AceVentura = new Movie
            {
                Title = "Ace Ventura",
                Description = "movie about funny guy",
                Duration = 90,
                Rating = 9.2f,
                ReleaseYear = 1990,
                PosterPath = "https://m.media-amazon.com/images/M/MV5BYmVhNmFmOGYtZjgwNi00ZGQ0LThiMmQtOGZjMDUzNzJhMGIzXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_FMjpg_UX1000_.jpg",
                Directors = new List<Director> { James },
                Actors = new List<Actor> { Chris, Ryan },
                Genres = new List<Genre> { Drama, Comedy },
            };

            var Avengers = new Movie
            {
                Title = "Avengers",
                Description = "Superhero movie",
                Duration = 200,
                Rating = 9.3f,
                ReleaseYear = 2020,
                PosterPath = "https://m.media-amazon.com/images/M/MV5BNDYxNjQyMjAtNTdiOS00NGYwLWFmNTAtNThmYjU5ZGI2YTI1XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg",
                Directors = new List<Director> { James },
                Actors = new List<Actor> { Chris, Ryan },
                Genres = new List<Genre> { Drama, Comedy },
            };

            USA.Movies = new List<Movie> { AceVentura };
            Germany.Movies = new List<Movie> { Avengers };

            Chris.Movies = new List<Movie> { AceVentura, Avengers };
            Ryan.Movies = new List<Movie> { AceVentura, Avengers };


            dbContext.AddRange(Chris, Ryan, USA, Germany, James, Comedy, Drama, AceVentura, Avengers);
            Student s1 = new Student { Name = "Егор", Surname = "Иванов" };
            Student s2 = new Student {  Name = "Мария", Surname = "Васильева" };
            Student s3 = new Student { Name = "Олег", Surname = "Кузнецов" };
            Student s4 = new Student { Name = "Ольга", Surname = "Петрова" };



            Course c1 = new Course
            {

                Name = "Операционные системы",
                Students = new List<Student>() { s1, s2, s3 }
            };
            Course c2 = new Course
            {
                Name = "Алгоритмы и структуры данных",
                Students = new List<Student>() { s2, s4 }
            };
            Course c3 = new Course
            {

                Name = "Основы HTML и CSS",
                Students = new List<Student>() { s3, s4, s1 }
            };


            dbContext.AddRange(s1, s2, s3, s4, c1, c2, c3);
            dbContext.SaveChanges();

            return Redirect("/Home/Index");
        }
    }
}
