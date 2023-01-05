using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeCheck.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ReplaceDoubleRatingOnNumeric42 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "OverallRating",
                table: "OverallRating",
                type: "numeric(4,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(2,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FoodRating",
                table: "FoodRating",
                type: "numeric(4,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(2,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoffeeRating",
                table: "CoffeeRating",
                type: "numeric(4,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(2,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CandyRating",
                table: "CandyRating",
                type: "numeric(4,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(2,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "OverallRating",
                table: "OverallRating",
                type: "numeric(2,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(4,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FoodRating",
                table: "FoodRating",
                type: "numeric(2,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(4,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoffeeRating",
                table: "CoffeeRating",
                type: "numeric(2,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(4,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CandyRating",
                table: "CandyRating",
                type: "numeric(2,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(4,2)");
        }
    }
}
