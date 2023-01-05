using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoffeeCheck.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class GuidForIdReplacingManually : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CandyRating",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false),
                    CandyRating = table.Column<decimal>(type: "numeric(4,2)", nullable: false),
                    CandyVotesQuantity = table.Column<int>(type: "integer", nullable: false),
                    ClientChoice = table.Column<string>(type: "text", nullable: false),
                    RestaurantChoice = table.Column<string>(name: "Restaurant_Choice", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandyRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CandyRating_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoffeeRating",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false),
                    CoffeeRating = table.Column<decimal>(type: "numeric(4,2)", nullable: false),
                    CoffeeVotesQuantity = table.Column<int>(type: "integer", nullable: false),
                    ClientChoice = table.Column<string>(type: "text", nullable: false),
                    RestaurantChoice = table.Column<string>(name: "Restaurant_Choice", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeeRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoffeeRating_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodRating",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false),
                    FoodRating = table.Column<decimal>(type: "numeric(4,2)", nullable: false),
                    FoodVotesQuantity = table.Column<int>(type: "integer", nullable: false),
                    ClientChoice = table.Column<string>(type: "text", nullable: false),
                    RestaurantChoice = table.Column<string>(name: "Restaurant_Choice", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodRating_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OverallRating",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false),
                    OverallRating = table.Column<decimal>(type: "numeric(4,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverallRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OverallRating_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandyRating_RestaurantId",
                table: "CandyRating",
                column: "RestaurantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CoffeeRating_RestaurantId",
                table: "CoffeeRating",
                column: "RestaurantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FoodRating_RestaurantId",
                table: "FoodRating",
                column: "RestaurantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OverallRating_RestaurantId",
                table: "OverallRating",
                column: "RestaurantId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandyRating");

            migrationBuilder.DropTable(
                name: "CoffeeRating");

            migrationBuilder.DropTable(
                name: "FoodRating");
        }
    }
}
