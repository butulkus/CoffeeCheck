using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeCheck.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveMainPictureIdFromRestaurant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_MainPicture_MainPictureId",
                table: "Restaurant");

            migrationBuilder.DropIndex(
                name: "IX_Restaurant_MainPictureId",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "MainPictureId",
                table: "Restaurant");

            migrationBuilder.AddColumn<Guid>(
                name: "RestaurantId",
                table: "MainPicture",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_MainPicture_RestaurantId",
                table: "MainPicture",
                column: "RestaurantId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MainPicture_Restaurant_RestaurantId",
                table: "MainPicture",
                column: "RestaurantId",
                principalTable: "Restaurant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainPicture_Restaurant_RestaurantId",
                table: "MainPicture");

            migrationBuilder.DropIndex(
                name: "IX_MainPicture_RestaurantId",
                table: "MainPicture");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "MainPicture");

            migrationBuilder.AddColumn<Guid>(
                name: "MainPictureId",
                table: "Restaurant",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_MainPictureId",
                table: "Restaurant",
                column: "MainPictureId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_MainPicture_MainPictureId",
                table: "Restaurant",
                column: "MainPictureId",
                principalTable: "MainPicture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
