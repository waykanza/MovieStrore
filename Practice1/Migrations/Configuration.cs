namespace Practice1.Migrations
{
    using Practice1.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Practice1.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Practice1.Models.MovieDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleasDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Rating = "PG",
                    Price = 7.99M                    
                },

                 new Movie
                 {
                     Title = "Ghostbusters ",
                     ReleasDate = DateTime.Parse("1984-3-13"),
                     Genre = "Comedy",
                     Rating = "P",
                     Price = 8.99M
                 },

                 new Movie
                 {
                     Title = "Ghostbusters 2",
                     ReleasDate = DateTime.Parse("1986-2-23"),
                     Genre = "Comedy",
                     Rating = "G",
                     Price = 9.99M
                 },

               new Movie
               {
                   Title = "Rio Bravo",
                   ReleasDate = DateTime.Parse("1959-4-15"),
                   Genre = "Western",
                   Rating = "PG",
                   Price = 3.99M
               }
           );
        }
    }
}
