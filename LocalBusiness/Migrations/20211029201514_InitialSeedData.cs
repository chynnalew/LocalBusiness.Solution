using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusiness.Migrations
{
    public partial class InitialSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    BusinessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Type = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Genre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Address = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.BusinessId);
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Description", "Genre", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 1, "2137 E Burnside St, Portland, OR 97214", "A family owned mexican restaurant with good burritos. Cash only", "Mexican", "Ole Ole", 1, "Restaurant" },
                    { 15, "2820 NE Sandy Blvd, Portland, OR 97232", "A bright and open tattoo shop offering a variety of", "Tattoo", "Anatomy Tattoo", 3, "Shop" },
                    { 14, "811 NW 23rd Ave, Portland, OR 97210", "A curio shop offering high quality taxidermy, rocks/stones, plants, and general gift items", "Gifts", "Paxton Gate", 3, "Shop" },
                    { 13, "1938 W Burnside St, Portland, OR 97209", "A curated table top game store with a large gaming area and bar", "Game", "Mox Boarding House", 4, "Shop" },
                    { 12, "1428 SE 36th Ave, Portland, OR 97214", "Small video game/record store specializing in older game systems", "Game", "Hawthorne Game Exchange", 3, "Shop" },
                    { 11, "820 SW Washington St, Portland, OR 97205", "Large table top and card game store with a small video game selection.", "Game", "Gaurdian Games", 3, "Shop" },
                    { 10, "820 SW Washington St, Portland, OR 97205", "Portland's largest independent toy store", "Toy", "Finnegan's", 3, "Shop" },
                    { 16, "2504 SE 50th Ave unit e, Portland, OR 97206", "A curio themed tattoo shop with a small selection of taxidermy for sale in the lobby", "Tattoo", "Sideshow Alley", 3, "Shop" },
                    { 9, "113 SE 28th Ave, Portland, OR 97214", "Fried chicken with Korean or classic Southern flavors", "Korean", "FOMO Chicken", 2, "Food Cart" },
                    { 7, "3630 SE Division St, Portland, OR 97202", "Curated vintage housewares, decor, art, clothing & accessories fill this hip, funky boutique.", "Thrift/Vintage", "Artifact", 2, "Shop" },
                    { 6, "2250 E Burnside St, Portland, OR 97214", "Cute aesthetic coffee shop with unique coffee flavors, cakes, and pastries", "Korean", "Soro Soro", 3, "Coffee Shop" },
                    { 5, "938 E Burnside St, Portland, OR 97214", "A food cart offering made-to-order Thai classics. ", "Thai", "Thai Champa", 2, "Food Cart" },
                    { 4, "1109 SE Madison St, Portland, OR 97214", "Family-run cafe serving kebabs, fresh pitas & other Lebanese dishes ", "Lebanese", "Nicholas", 3, "Restaurant" },
                    { 3, "960 SE 11th Ave, Portland, OR 97214", "Upscale Russian food and house-infused vodkas. ", "Russian", "Kachka", 4, "Restaurant" },
                    { 2, "3158 E Burnside St, Portland, OR 97214", "The oldest record store in the Pacific Northwest, stocking LP, 45, reel-to-reel, 8-track, cassette, DAT, compact disc, mini-disc, DCC and CD-ROM. ", "Music", "Millennium Music", 2, "Store" },
                    { 8, "4035 SE Division St, Portland, OR 97202", "Secondhand store with a bit of everything: clothes, antiques, art, housewares & collectibles.", "Thrift/Vintage", "Village Merchants", 1, "Shop" },
                    { 17, "1400 SE Stark St, Portland, OR 97214", "Casual restaurant serving out noodles, curries & other classic Thai dishes", "Thai", "Sunee's Thai", 2, "Restaurant" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Businesses");
        }
    }
}
