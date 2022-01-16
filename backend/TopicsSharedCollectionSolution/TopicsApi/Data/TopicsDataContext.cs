using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TopicsApi.Data
{
    public class TopicsDataContext : DbContext
    {
        public TopicsDataContext(DbContextOptions<TopicsDataContext> options) : base(options)
        {

        }
        public DbSet<Topic> Topics { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }


    public class Topic
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        public string AddedBy { get; set; } = string.Empty;
        [Required]
        public MediaTypes MediaType { get; set; }
        public string? OtherMediaTypeDescriptions { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Link { get; set; } = string.Empty;
        public bool Public { get; set; }
        public bool Archived { get; set; } = false;

    }

    public enum MediaTypes {  Other, Video, Book, Blog, Course, Site}
}
