using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MoviesCore
{
    public class MoviesDbContext : IdentityDbContext<User>
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options)
         : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Movie>()
                .HasMany(x => x.Genres)
                .WithMany(x => x.Movies);

            builder.Entity<Movie>()
                .HasMany(x => x.Directors)
                .WithMany(x => x.Movies);

            builder.Entity<Movie>()
                .HasMany(x => x.Actors)
                .WithMany(x => x.Movies);

            builder.Entity<Course>()
                .HasMany(c => c.Students)
                .WithMany(s => s.Courses);

            builder.Seed();
            base.OnModelCreating(builder);
        }

        public DbSet<Student>? Students { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Movie>? Movies { get; set; }
        public DbSet<Genre>? Genres { get; set; }
        public DbSet<Director>? Directors { get; set; }
        public DbSet<PublisherCountry>? PublisherCountries { get; set; }
        public DbSet<Actor>? Actors { get; set; }
    }
}