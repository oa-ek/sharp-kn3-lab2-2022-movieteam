using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesRepository;
using System.Diagnostics;

namespace MoviesUI.Controllers
{
    [Authorize]
    public class MoviesController : Controller
    {
        private readonly MoviesDbContext dbContext;
        public MoviesController(MoviesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET: MovieController
        public ActionResult Index()
        {
            var MoviesWithEv = dbContext.Movies
                .Include(x => x.Genres)
                .Include(x => x.Directors)
                .ToList();

            return View(MoviesWithEv);
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var movie = dbContext.Movies
                .Include(x => x.Directors)
                .Include(x => x.Actors)
                .Include(x => x.Genres)
                .FirstOrDefault(x => x.Id == id);
            if (movie == null) return NotFound();

            return View(movie);
        }

        // GET: MovieController/Create
        [HttpGet]
        public ActionResult Create()
        {

            ViewBag.Genres = dbContext.Genres.ToList();
            ViewBag.Directors = new SelectList(dbContext.Directors.ToList());
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        public ActionResult Create(Movie movie, int[] selectedGenres)
        {
            //var genre = dbContext.Genres.FirstOrDefault(x => x.Id == 1);
            //movie.Genres = new List<Genre> { genre };

            //var director = dbContext.Directors.FirstOrDefault(x => x.Id == 1);
            //movie.Directors = new List<Director> { director };

            //var actor = dbContext.Actors.FirstOrDefault(x => x.Id == 1);
            //movie.Actors = new List<Actor> { actor };
            if (selectedGenres != null)
            {
                foreach (var g in dbContext.Genres.Where(ge => selectedGenres.Contains(ge.Id)))
                {
                    movie.Genres.Add(g);
                }
            }
            dbContext.Entry(movie).State = EntityState.Modified;
            // dbContext.Add(movie);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            Movie movie = dbContext.Movies.Include(x => x.Genres).FirstOrDefault(x => x.Id == id); ;
            if (movie == null) return NotFound();
            ViewBag.Genres = dbContext.Genres.ToList();
            return View(movie);
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        public ActionResult Edit(Movie movie, int[] selectedGenres)
        {
              
            Movie edited = dbContext.Movies.Include(x => x.Genres).FirstOrDefault(x => x.Id == movie.Id);
            edited.Title = movie.Title;
            edited.Description = movie.Description;
            edited.Rating = movie.Rating;
            edited.PosterPath = movie.PosterPath;
            edited.Duration = movie.Duration;
            edited.ReleaseYear = movie.ReleaseYear;

            edited.Genres.Clear();
            if (selectedGenres != null)
            {
                foreach (var g in dbContext.Genres.Where(ge => selectedGenres.Contains(ge.Id)))
                {
                    edited.Genres.Add(g);
                }
            }
            dbContext.Entry(edited).State = EntityState.Modified;
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: MovieController/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            return View(dbContext.Movies.Find(id));
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            dbContext.Movies.Remove(dbContext.Movies.Find(id));
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
