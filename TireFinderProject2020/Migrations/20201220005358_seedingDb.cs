using Microsoft.EntityFrameworkCore.Migrations;

namespace TireFinderProject2020.Migrations
{
    public partial class seedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 1, null, "By Vehicle" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 2, null, "By Brand" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 3, null, "By Size" });

            migrationBuilder.InsertData(
                table: "Tires",
                columns: new[] { "TireId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.", "\\Images\\thumbnails\\chocolateCandy-small.jpg", "\\Images\\chocolateCandy.jpg", true, false, "Assorted Chocolate Candy", 4.95m },
                    { 2, 1, "Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Quisque egestas diam in arcu cursus. Sed viverra tellus in hac. Quis commodo odio aenean sed adipiscing diam donec adipiscing.", "\\Images\\thumbnails\\chocolateCandy2-small.jpg", "\\Images\\chocolateCandy2.jpg", true, true, "Another Assorted Chocolate Candy", 3.95m },
                    { 3, 1, "Turpis egestas pretium aenean pharetra magna ac placerat vestibulum. Sed faucibus turpis in eu mi bibendum neque egestas. At in tellus integer feugiat scelerisque. Elementum integer enim neque volutpat ac tincidunt.", "\\Images\\thumbnails\\chocolateCandy3-small.jpg", "\\Images\\chocolateCandy3.jpg", true, false, "Another Chocolate Candy", 5.75m },
                    { 4, 2, "Vitae congue eu consequat ac felis donec et. Praesent semper feugiat nibh sed pulvinar proin gravida hendrerit. Vel eros donec ac odio. A lacus vestibulum sed arcu non odio euismod lacinia at. Nisl suscipit adipiscing bibendum est ultricies integer. Nec tincidunt praesent semper feugiat nibh.", "\\Images\\thumbnails\\fruitCandy-small.jpg", "\\Images\\fruitCandy.jpg", true, false, "Assorted Fruit Candy", 3.95m },
                    { 5, 2, "Purus sit amet luctus venenatis lectus magna fringilla. Consectetur lorem donec massa sapien faucibus et molestie ac. Sagittis nisl rhoncus mattis rhoncus urna neque viverra.", "\\Images\\thumbnails\\fruitCandy2-small.jpg", "\\Images\\fruitCandy2.jpg", true, true, "Fruit Candy", 7.00m },
                    { 6, 2, "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ", "\\Images\\thumbnails\\fruitCandy3-small.jpg", "\\Images\\fruitCandy3.jpg", true, true, "Another Assorted Fruit Candy", 11.25m },
                    { 7, 3, "Diam sit amet nisl suscipit adipiscing bibendum est ultricies integer. Molestie at elementum eu facilisis sed odio morbi quis commodo. Odio facilisis mauris sit amet massa vitae tortor condimentum lacinia. Urna porttitor rhoncus dolor purus non enim praesent elementum facilisis.", "\\Images\\thumbnails\\gummyCandy-small.jpg", "\\Images\\gummyCandy.jpg", true, true, "Assorted Gummy Candy", 3.95m },
                    { 8, 3, "Posuere ac ut consequat semper viverra nam libero justo laoreet. Ultrices dui sapien eget mi proin sed libero enim. Etiam non quam lacus suspendisse faucibus interdum. Amet nisl suscipit adipiscing bibendum est ultricies integer quis.", "\\Images\\thumbnails\\gummyCandy2-small.jpg", "\\Images\\gummyCandy2.jpg", true, false, "Another Assorted Gummy Candy", 1.95m },
                    { 9, 3, "Ut ornare lectus sit amet est placerat in egestas. Iaculis nunc sed augue lacus viverra vitae. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida. Accumsan tortor posuere ac ut consequat semper viverra.", "\\Images\\thumbnails\\gummyCandy3-small.jpg", "\\Images\\gummyCandy3.jpg", true, false, "Gummy Candy", 13.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tires",
                keyColumn: "TireId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tires",
                keyColumn: "TireId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tires",
                keyColumn: "TireId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tires",
                keyColumn: "TireId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tires",
                keyColumn: "TireId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tires",
                keyColumn: "TireId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tires",
                keyColumn: "TireId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tires",
                keyColumn: "TireId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tires",
                keyColumn: "TireId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
