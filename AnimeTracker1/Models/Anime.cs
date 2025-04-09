// Models/Anime.cs
using System.ComponentModel.DataAnnotations;

namespace AnimeTracker1.Models
{
    public enum WatchStatus
    {
        PlanToWatch,
        Watching,
        Completed,
        Dropped
    }

    public class Anime
    {
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; } = string.Empty;
        
        public string? Description { get; set; }
        
        public int? Episodes { get; set; }
        
        public string? Studio { get; set; }
        
        public WatchStatus Status { get; set; }
        
        public int? EpisodesWatched { get; set; }
        
        [Range(0, 10)]
        public int? Rating { get; set; }
    }
}