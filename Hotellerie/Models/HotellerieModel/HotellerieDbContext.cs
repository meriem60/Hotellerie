using Microsoft.EntityFrameworkCore;

namespace Hotellerie.Models.HotellerieModel
{
    public class HotellerieDbContext : DbContext
    {
        public HotellerieDbContext(DbContextOptions options) : base(options) { }

        public HotellerieDbContext(DbSet<Hotel> hotels)
        {
            Hotels = hotels;
        }

        public DbSet<Hotel> Hotels { get; set; } = null!;
        public DbSet<Appreciation> Appreciations { get; set; } = null !;

    }
}
