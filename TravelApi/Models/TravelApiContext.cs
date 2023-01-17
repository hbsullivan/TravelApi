using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public DbSet<Review> Reviews {get; set;}

    public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Review>()
             .HasData(
              new Review { ReviewId = 1, Country = "Mexico", City = "Cabo San Lucas", Rating = 5, Description = "Great for spring break or empty nesters!"},
              new Review { ReviewId = 2, Country = "South Korea", City = "Busan", Rating = 5, Description = "City meets country! Great hiking, beach views, all with the convenience of big city public transit."},
              new Review { ReviewId = 3, Country = "Spain", City = "Barcelona", Rating = 5, Description = "Delicious food!"},
              new Review { ReviewId = 4, Country = "Australia", City = "Cairns", Rating = 4, Description = "Beautiful rainforest, but very hot!"}
             );
    }
  }
}