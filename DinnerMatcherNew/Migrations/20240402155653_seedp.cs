using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DinnerMatcherNew.Migrations
{
    /// <inheritdoc />
    public partial class seedp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "GoogleMapsUri", "IsOpen", "Name", "PhoneNumber", "Rating", "Summary" },
                values: new object[,]
                {
                    { 1, "32 Bridge St, Manchester M3 3BT, UK", "https://maps.google.com/?cid=7531015505938905277", false, "Dishoom", 1615373737, 4.7000000000000002, "Trendy restaurant serving modern Indian cuisine amid elegant surroundings & stained glass windows." },
                    { 2, "88 Portland St, Manchester M1 4GX, UK", "https://maps.google.com/?cid=14636860895556749090", false, "Fat Pat’s", 0, 4.2000000000000002, "Buzzy take-out window dispensing hefty sub sandwiches like cheesesteaks & hot honey chicken." },
                    { 3, "48-58 Deansgate, Manchester M3 2EG, UK", "https://maps.google.com/?cid=15890343035137462782", false, "Cosmo", 1619891388, 4.0999999999999996, "Stylish, modern chain dining room with cooking stations producing a range of global dishes." },
                    { 4, "42 King St W, Manchester M3 2WY, UK", "https://maps.google.com/?cid=6290816004385542980", false, "San Carlo", 1618346226, 4.2000000000000002, "Sleek, high-end Italian destination restaurant known for its sceney, celebrity-studded clientele." },
                    { 5, "Petersfield House, Peter St, Manchester M2 5QJ, UK", "https://maps.google.com/?cid=11185039208312255219", false, "Rudy's Pizza Napoletana - Peter Street", 1616608040, 4.7000000000000002, null },
                    { 6, "52 King St, Manchester M2 4LY, UK", "https://maps.google.com/?cid=18426442113561219475", false, "El Gato Negro Tapas Manchester", 1616948585, 4.5999999999999996, "Tapas & drinks are provided in this 3-storey converted townhouse that has stylish interiors." },
                    { 7, "20 York St, Manchester M2 2BB, UK", "https://maps.google.com/?cid=6408130840566072891", false, "Moose Coffee", 1612287994, 4.5, "Elegant, traditional diner serving hearty American-style breakfasts, brunches and coffee." },
                    { 8, "Basement, 100 Barbirolli Square, Manchester M2 3BD, UK", "https://maps.google.com/?cid=991045946514577218", false, "Society", 0, 4.5, "Chill destination featuring stands doling out global street foods, plus craft beer & cocktails." },
                    { 9, "2A St Mary's St, Manchester M3 2LB, UK", "https://maps.google.com/?cid=1253734206550260659", false, "Gaucho Manchester", 2079253900, 4.5, "Designer furnishings & cowhide fabrics create a lavish backdrop for Argentine food & wine." },
                    { 10, "30 Portland St, Manchester M1 4GS, UK", "https://maps.google.com/?cid=10486315685157041285", false, "Rudy's Pizza Napoletana - Portland Street", 1615322922, 4.7000000000000002, null },
                    { 11, "4 Lloyd St, Manchester M2 5AB, UK", "https://maps.google.com/?cid=13638348935372707988", false, "Gusto Italian", 1616411120, 4.4000000000000004, "Polished Sicilian restaurant serving char-grilled dishes, stone-baked pizzas & seafood." },
                    { 12, "60 Spring Gardens, Manchester M2 2BQ, UK", "https://maps.google.com/?cid=4984268512638993458", false, "Six by Nico Spring Gardens", 1618321815, 4.5999999999999996, null },
                    { 13, "18-19 The Avenue, Manchester M3 3HF, UK", "https://maps.google.com/?cid=8092230557133234279", false, "Comptoir Libanais", 1616723999, 4.2999999999999998, null },
                    { 14, "52a Faulkner St, Manchester M1 4FH, UK", "https://maps.google.com/?cid=9678613109120993862", false, "Pho Cue", 1612375664, 4.5999999999999996, "Straightforward restaurant specialising in Vietnamese cuisine, including soups & sandwiches." },
                    { 15, "unit 1, 58 W Mosley St, Manchester M2 3HZ, UK", "https://maps.google.com/?cid=604196843788206545", false, "American Pies Mcr", 1616376776, 4.5, "Restaurant with a laid-back vibe serving American-style pizzas, calzones & dessert pies." },
                    { 16, "2 St Peter's Sq, Manchester M2 3LQ, UK", "https://maps.google.com/?cid=16250524245534901885", false, "wagamama manchester st peters square", 1613024630, 4.2999999999999998, "Casual restaurant serving Asian dishes in a Japanese-inspired setting with long communal benches." },
                    { 17, "11 York St, Manchester M2 2AW, UK", "https://maps.google.com/?cid=10526132420135364650", false, "Maki & Ramen", 1614707019, 4.7000000000000002, null },
                    { 18, "The Avenue Spinningfields, Manchester M3 3HF, UK", "https://maps.google.com/?cid=8641579490415565491", false, "Thaikhun", 1614140264, 4.4000000000000004, "Lively, ephemera-packed Thai joint with street-market furniture and an open kitchen, plus a tuk-tuk." },
                    { 19, "36 Bridge St, Manchester M3 3BT, UK", "https://maps.google.com/?cid=4741104865423632753", false, "Honest Burgers Manchester", 1616763890, 4.5, null },
                    { 20, "Barton Arcade, Manchester M3 2BW, UK", "https://maps.google.com/?cid=5724952766288945264", false, "POT KETTLE BLACK Barton Arcade", 0, 4.5, "Airy cafe with reclaimed floorboards, in Victorian arcade, for gourmet coffee, tea and snacks." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
