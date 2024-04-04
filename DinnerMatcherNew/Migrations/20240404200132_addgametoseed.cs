using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DinnerMatcherNew.Migrations
{
    /// <inheritdoc />
    public partial class addgametoseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Friendships",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "LatitudeMain", "LikedRestaurant_Ids", "LongitudeMain" },
                values: new object[] { 1, 0.0, "[1]", 0.0 });

            migrationBuilder.InsertData(
                table: "GameUsers",
                columns: new[] { "Id", "GameId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_UserId",
                table: "Friendships",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Friendships_Users_UserId",
                table: "Friendships",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friendships_Users_UserId",
                table: "Friendships");

            migrationBuilder.DropIndex(
                name: "IX_Friendships_UserId",
                table: "Friendships");

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Friendships");
        }
    }
}
