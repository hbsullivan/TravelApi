using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Author", "City", "Country", "Description", "Rating" },
                values: new object[,]
                {
                    { 1, null, "Cabo San Lucas", "Mexico", "Great for spring break or empty nesters!", 5 },
                    { 2, null, "Busan", "South Korea", "City meets country! Great hiking, beach views, all with the convenience of big city public transit.", 5 },
                    { 3, null, "Barcelona", "Spain", "Delicious food!", 5 },
                    { 4, null, "Cairns", "Australia", "Beautiful rainforest, but very hot!", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);
        }
    }
}
