using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(actor_movie => new
            {
                actor_movie.ActorId,
                actor_movie.MovieId
            });

            // Menu builder for movies
            modelBuilder.Entity<Actor_Movie>().HasOne(movie => movie.Movie)
                .WithMany(actors_movies => actors_movies.Actors_Movies)
                .HasForeignKey(movie => movie.MovieId);

            // Menu builder for Actors
            modelBuilder.Entity<Actor_Movie>().HasOne(actor => actor.Movie)
                .WithMany(actors_movies => actors_movies.Actors_Movies)
                .HasForeignKey(actor => actor.ActorId);

            base.OnModelCreating(modelBuilder);

        }

            public DbSet<Actor> Actors { get; set; }
            public DbSet<Movie> Movies { get; set; }
            public DbSet<Actor_Movie> Actors_Movies { get; set; }
            public DbSet<Cinema> Cinemas { get; set; }
            public DbSet<Producer> Producers { get; set; }


    }

        
 }

