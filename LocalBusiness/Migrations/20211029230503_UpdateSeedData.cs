using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusiness.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 15,
                column: "Description",
                value: "A bright and open tattoo shop offering a variety of styles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 15,
                column: "Description",
                value: "A bright and open tattoo shop offering a variety of");
        }
    }
}
