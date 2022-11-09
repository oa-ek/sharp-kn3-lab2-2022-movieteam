using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesRepository;
using System;

namespace MoviesUI.Controllers
{
    [Authorize]
    public class BookmarkController : Controller
    {
        private readonly MoviesDbContext dbContext;
        public BookmarkController(MoviesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public ActionResult Index()
        {
            User currentUser = dbContext.Users.Include(x=>x.Bookmarks).ThenInclude(x=>x.Movie).FirstOrDefault(x => x.UserName == User.Identity.Name);

            return View(currentUser.Bookmarks.ToList());
        }
        public async Task Add(Movie movie)
        {
            if (BookmarkExists(movie) == null)
            {
                User currentUser = dbContext.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);
                Bookmark bookmark = new();
                bookmark.Movie = movie;
                bookmark.User = currentUser;

                await dbContext.Bookmarks.AddAsync(bookmark);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task Delete(Movie movie)
        {
            var bookmark = BookmarkExists(movie);

            if (bookmark != null)
            {
                dbContext.Bookmarks.Remove(bookmark);
                await dbContext.SaveChangesAsync();
            }
        }

        private Bookmark BookmarkExists(Movie movie)
        {
            User currentUser = dbContext.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);
            return dbContext.Bookmarks.Where(b => b.Movie == movie && b.User == currentUser).SingleOrDefault();
        }
    }
}
