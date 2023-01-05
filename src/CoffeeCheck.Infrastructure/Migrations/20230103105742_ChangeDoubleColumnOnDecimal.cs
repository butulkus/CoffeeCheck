using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeCheck.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDoubleColumnOnDecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "YandexLongitude",
                table: "Restaurant",
                type: "numeric(38,17)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<decimal>(
                name: "YandexLatitude",
                table: "Restaurant",
                type: "numeric(38,17)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "YandexLongitude",
                table: "Restaurant",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(38,17)");

            migrationBuilder.AlterColumn<double>(
                name: "YandexLatitude",
                table: "Restaurant",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(38,17)");
        }
    }
}
