using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusiness.Migrations
{
    public partial class AddAddressAndInitialSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Businesses",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Description", "Genre", "Name", "Price", "Type" },
                values: new object[] { 1, "2137 E Burnside St, Portland, OR 97214", "A family owned mexican restaurant with good burritos. Cash only", "Mexican", "Ole Ole", 1, "Restaurant" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Description", "Genre", "Name", "Price", "Type" },
                values: new object[] { 2, "3158 E Burnside St. Portland, OR 97214", "The oldest record store in the Pacific Northwest, stocking LP, 45, reel-to-reel, 8-track, cassette, DAT, compact disc, mini-disc, DCC and CD-ROM. ", "Music", "Millennium Music", 2, "Store" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Businesses");
        }
    }
}
