namespace MvcMovies.Migrations
{
    using MvcMovies.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovies.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
            new Movie
            {
                Title = "When Harry Met Sally",
                ReleaseDate = DateTime.Parse("1989-01-11"),
                Genre = "Romantic Comedy",
                Price = 7.99M,
                Rating = "PG"
            },
            new Movie
            {
                Title = "Ghostbusters",
                ReleaseDate = DateTime.Parse("1992-05-22"),
                Genre = "Comedy",
                Price = 9.99M,
                Rating = "PG"
            },

            new Movie
            {
                Title = "Ghostbusters 2",
                ReleaseDate = DateTime.Parse("1992-05-20"),
                Genre = "Comedy",
                Price = 9.99M,
                Rating = "PG"
            },
            new Movie
            {
                Title = "Rio Bravo",
                ReleaseDate = DateTime.Parse("2005-05-22"),
                Genre = "Western",
                Price = 3.99M,
                Rating = "PG"
            }
           );
        }
    }
}
