using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DinnerMatcherNew.Migrations
{
    /// <inheritdoc />
    public partial class matchesfixnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LatitudeMain",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "LongitudeMain",
                table: "Games");

            migrationBuilder.AlterColumn<string>(
                name: "LikedRestaurant_Ids",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LikedRestaurant_Ids",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "LatitudeMain",
                table: "Games",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LongitudeMain",
                table: "Games",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LatitudeMain", "LongitudeMain" },
                values: new object[] { 0.0, 0.0 });
        }
    }
}
