using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeCheck.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenameRestaurantChoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Restaurant_Choice",
                table: "FoodRating",
                newName: "RestaurantChoice");

            migrationBuilder.RenameColumn(
                name: "Restaurant_Choice",
                table: "CoffeeRating",
                newName: "RestaurantChoice");

            migrationBuilder.RenameColumn(
                name: "Restaurant_Choice",
                table: "CandyRating",
                newName: "RestaurantChoice");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RestaurantChoice",
                table: "FoodRating",
                newName: "Restaurant_Choice");

            migrationBuilder.RenameColumn(
                name: "RestaurantChoice",
                table: "CoffeeRating",
                newName: "Restaurant_Choice");

            migrationBuilder.RenameColumn(
                name: "RestaurantChoice",
                table: "CandyRating",
                newName: "Restaurant_Choice");
        }
    }
}
