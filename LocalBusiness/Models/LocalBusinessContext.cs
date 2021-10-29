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
        new Business { BusinessId = 2, Name = "Millennium Music", Type = "Store", Genre = "Music", Address="3158 E Burnside St, Portland, OR 97214", Description = "The oldest record store in the Pacific Northwest, stocking LP, 45, reel-to-reel, 8-track, cassette, DAT, compact disc, mini-disc, DCC and CD-ROM. ", Price = 2 },
        new Business { BusinessId = 3, Name = "Kachka", Type = "Restaurant", Genre = "Russian", Address="960 SE 11th Ave, Portland, OR 97214", Description = "Upscale Russian food and house-infused vodkas. ", Price = 4 },
        new Business { BusinessId = 4, Name = "Nicholas", Type = "Restaurant", Genre = "Lebanese", Address="1109 SE Madison St, Portland, OR 97214", Description = "Family-run cafe serving kebabs, fresh pitas & other Lebanese dishes ", Price = 3 },
        new Business { BusinessId = 5, Name = "Thai Champa", Type = "Food Cart", Genre = "Thai", Address="938 E Burnside St, Portland, OR 97214", Description = "A food cart offering made-to-order Thai classics. ", Price = 2 },
        new Business { BusinessId = 6, Name = "Soro Soro", Type = "Coffee Shop", Genre = "Korean", Address="2250 E Burnside St, Portland, OR 97214", Description = "Cute aesthetic coffee shop with unique coffee flavors, cakes, and pastries", Price = 3 },
        new Business { BusinessId = 7, Name = "Artifact", Type = "Shop", Genre = "Thrift/Vintage", Address="3630 SE Division St, Portland, OR 97202", Description = "Curated vintage housewares, decor, art, clothing & accessories fill this hip, funky boutique.", Price = 2 },
        new Business { BusinessId = 8, Name = "Village Merchants", Type = "Shop", Genre = "Thrift/Vintage", Address="4035 SE Division St, Portland, OR 97202", Description = "Secondhand store with a bit of everything: clothes, antiques, art, housewares & collectibles.", Price = 1 },
        new Business { BusinessId = 9, Name = "FOMO Chicken", Type = "Food Cart", Genre = "Korean", Address="113 SE 28th Ave, Portland, OR 97214", Description = "Fried chicken with Korean or classic Southern flavors", Price = 2 },
        new Business { BusinessId = 10, Name = "Finnegan's", Type = "Shop", Genre = "Toy", Address="820 SW Washington St, Portland, OR 97205", Description = "Portland's largest independent toy store", Price = 3 },
        new Business { BusinessId = 11, Name = "Gaurdian Games", Type = "Shop", Genre = "Game", Address="820 SW Washington St, Portland, OR 97205", Description = "Large table top and card game store with a small video game selection.", Price = 3 },
        new Business { BusinessId = 12, Name = "Hawthorne Game Exchange", Type = "Shop", Genre = "Game", Address="1428 SE 36th Ave, Portland, OR 97214", Description = "Small video game/record store specializing in older game systems", Price = 3 },
        new Business { BusinessId = 13, Name = "Mox Boarding House", Type = "Shop", Genre = "Game", Address="1938 W Burnside St, Portland, OR 97209", Description = "A curated table top game store with a large gaming area and bar", Price = 4 },
        new Business { BusinessId = 14, Name = "Paxton Gate", Type = "Shop", Genre = "Gifts", Address="811 NW 23rd Ave, Portland, OR 97210", Description = "A curio shop offering high quality taxidermy, rocks/stones, plants, and general gift items", Price = 3 },
        new Business { BusinessId = 15, Name = "Anatomy Tattoo", Type = "Shop", Genre = "Tattoo", Address="2820 NE Sandy Blvd, Portland, OR 97232", Description = "A bright and open tattoo shop offering a variety of", Price = 3 },
        new Business { BusinessId = 16, Name = "Sideshow Alley", Type = "Shop", Genre = "Tattoo", Address="2504 SE 50th Ave unit e, Portland, OR 97206", Description = "A curio themed tattoo shop with a small selection of taxidermy for sale in the lobby", Price = 3 },
        new Business { BusinessId = 17, Name = "Sunee's Thai", Type = "Restaurant", Genre = "Thai", Address="1400 SE Stark St, Portland, OR 97214", Description = "Casual restaurant serving out noodles, curries & other classic Thai dishes", Price = 2 }
      );
    }
  }
}
