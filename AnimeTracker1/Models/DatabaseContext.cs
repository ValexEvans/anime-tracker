// Models/DatabaseContext.cs
using Microsoft.EntityFrameworkCore;

namespace AnimeTracker1.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        
        public DbSet<Anime> Animes { get; set; } = default!;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed some initial data
            modelBuilder.Entity<Anime>().HasData(
                new Anime { 
                    Id = 1, 
                    Title = "My Hero Academia", 
                    Studio = "Bones", 
                    Episodes = 113, 
                    Description = "A superhero-loving boy without any powers enrolls in a prestigious hero academy.",
                    Status = WatchStatus.Watching,
                    EpisodesWatched = 50
                },
                new Anime { 
                    Id = 2, 
                    Title = "Attack on Titan", 
                    Studio = "MAPPA", 
                    Episodes = 87, 
                    Description = "Humans fight against giant humanoid Titans that have brought humanity to the brink of extinction.",
                    Status = WatchStatus.Completed,
                    EpisodesWatched = 87,
                    Rating = 9
                },
                new Anime { 
                    Id = 3, 
                    Title = "Demon Slayer", 
                    Studio = "ufotable", 
                    Episodes = 44, 
                    Description = "A boy becomes a demon slayer after his family is slaughtered and his sister is turned into a demon.",
                    Status = WatchStatus.PlanToWatch
                }
            );
        }
    }
}