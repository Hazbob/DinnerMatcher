using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DinnerMatcherNew.Migrations
{
    /// <inheritdoc />
    public partial class restauranttogame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LikedRestaurant_Ids",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.CreateTable(
                name: "GameRestaurant",
                columns: table => new
                {
                    GamesId = table.Column<int>(type: "int", nullable: false),
                    RestaurantsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameRestaurant", x => new { x.GamesId, x.RestaurantsId });
                    table.ForeignKey(
                        name: "FK_GameRestaurant_Games_GamesId",
                        column: x => x.GamesId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameRestaurant_Restaurants_RestaurantsId",
                        column: x => x.RestaurantsId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameRestaurant_RestaurantsId",
                table: "GameRestaurant",
                column: "RestaurantsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameRestaurant");

            migrationBuilder.DropColumn(
                name: "LikedRestaurant_Ids",
                table: "Games");
        }
    }
}
