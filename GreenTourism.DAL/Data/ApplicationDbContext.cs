using GreenTourism.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenTourism.DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<PlaceAmenity> PlaceAmenity { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<PlacePhoto> PlacePhotos { get; set; }
        public DbSet<EventPhoto> EventPhotos { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<EventUser> EventUsers { get; set; }
        public DbSet<EventComment> EventComments { get; set; }
        public DbSet<PlaceComment> PlaceComments { get; set; }
        public DbSet<AmenityGroup> AmenityGroups { get; set; }
    }
}
