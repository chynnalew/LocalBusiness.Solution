using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Models
{
  public class LocalBusinessContext : DbContext
  {
    public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options) : base(options) { }

    public DbSet<Business> Businesses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>().HasData(
        new Business { BusinessId = 1, Name = "Ole Ole", Type = "Restaurant", Genre = "Mexican", Address="2137 E Burnside St, Portland, OR 97214", Description = "A family owned mexican restaurant with good burritos. Cash only", Price = 1 },
        new Business { BusinessId = 2, Name = "Millennium Music", Type = "Store", Genre = "Music", Address="3158 E Burnside St. Portland, OR 97214", Description = "The oldest record store in the Pacific Northwest, stocking LP, 45, reel-to-reel, 8-track, cassette, DAT, compact disc, mini-disc, DCC and CD-ROM. ", Price = 2 }
      );
    }
  }
}
