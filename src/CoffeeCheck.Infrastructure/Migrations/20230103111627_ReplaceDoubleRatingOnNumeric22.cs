using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeCheck.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ReplaceDoubleRatingOnNumeric22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "YandexLongitude",
                table: "Restaurant",
                type: "numeric(38,17)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal");

            migrationBuilder.AlterColumn<decimal>(
                name: "YandexLatitude",
                table: "Restaurant",
                type: "numeric(38,17)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal");

            migrationBuilder.AddColumn<decimal>(
                name: "OverallRating",
                table: "OverallRating",
                type: "numeric(2,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "FoodRating",
                table: "FoodRating",
                type: "numeric(2,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoffeeRating",
                table: "CoffeeRating",
                type: "numeric(2,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<decimal>(
                name: "CandyRating",
                table: "CandyRating",
                type: "numeric(2,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OverallRating",
                table: "OverallRating");

            migrationBuilder.AlterColumn<decimal>(
                name: "YandexLongitude",
                table: "Restaurant",
                type: "decimal",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(38,17)");

            migrationBuilder.AlterColumn<decimal>(
                name: "YandexLatitude",
                table: "Restaurant",
                type: "decimal",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(38,17)");

            migrationBuilder.AlterColumn<double>(
                name: "FoodRating",
                table: "FoodRating",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(2,2)");

            migrationBuilder.AlterColumn<double>(
                name: "CoffeeRating",
                table: "CoffeeRating",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(2,2)");

            migrationBuilder.AlterColumn<double>(
                name: "CandyRating",
                table: "CandyRating",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(2,2)");
        }
    }
}
