using Microsoft.EntityFrameworkCore;
using DevsApi.Controllers;
using DevsApi.Data;
using DevsApi.Models;
using System.Net;

namespace DevsApi.Data
{
    public class DataContext : DbContext
    {
        internal HttpStatusCode StatusCode;

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<DevsHero> DevsHeroes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DevsHero>().HasData(
                new DevsHero
                {
                    Id = 1,
                    Name = "Emmanuel Foday Kamara",
                    ProgrammingLanguage = "Python",
                    Project = "AI EXPLORATION",
                    location = "Locust Junction, Quarry.",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "AbuBakarr Kamara",
                },
                new DevsHero
                {
                    Id = 2,
                    Name = "AbuBakarr Kamara",
                    ProgrammingLanguage = ".net",
                    Project = "AI EXPLORATION",
                    location = " Junction, Quarry.",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "AbuBakarr Kamara",
           
                });





        }

    }
}
