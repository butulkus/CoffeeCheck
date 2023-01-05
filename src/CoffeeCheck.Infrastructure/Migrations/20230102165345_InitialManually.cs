using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoffeeCheck.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialManually : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CityName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainPicture",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Picture = table.Column<byte[]>(type: "bytea", nullable: false),
                    Format = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainPicture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    RestaurantName = table.Column<string>(type: "text", nullable: false),
                    MainPictureId = table.Column<Guid>(type: "uuid", nullable: false),
                    YandexLatitude = table.Column<double>(type: "double precision", nullable: false),
                    YandexLongitude = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurant_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Restaurant_MainPicture_MainPictureId",
                        column: x => x.MainPictureId,
                        principalTable: "MainPicture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandyRating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false),
                    CandyRating = table.Column<double>(type: "double precision", nullable: false),
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false),
                    CoffeeRating = table.Column<double>(type: "double precision", nullable: false),
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false),
                    FoodRating = table.Column<double>(type: "double precision", nullable: false),
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "RestaurantPicture",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Picture = table.Column<byte[]>(type: "bytea", nullable: false),
                    Format = table.Column<string>(type: "text", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantPicture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantPicture_Restaurant_RestaurantId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_CityId",
                table: "Restaurant",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_MainPictureId",
                table: "Restaurant",
                column: "MainPictureId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantPicture_RestaurantId",
                table: "RestaurantPicture",
                column: "RestaurantId");
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

            migrationBuilder.DropTable(
                name: "OverallRating");

            migrationBuilder.DropTable(
                name: "RestaurantPicture");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "MainPicture");
        }
    }
}
