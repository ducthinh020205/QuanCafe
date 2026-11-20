using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuanCafe.Migrations
{
    /// <inheritdoc />
    public partial class ThemMonAn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MonAns",
                columns: new[] { "Id", "AnhUrl", "Gia", "MoTa", "Nhom", "Ten" },
                values: new object[,]
                {
                    { 3, "", 30000, "Phở thịt gà", "Đồ nước", "Phở gà" },
                    { 4, "", 35000, "Phở thịt lợn", "Đồ nước", "Phở lợn" },
                    { 5, "", 40000, "Bún riêu cua", "Đồ nước", "Bún Riêu" },
                    { 6, "", 20000, "Cà phê thêm đã", "Thức uống", "Cà phê đá" },
                    { 7, "", 20000, "Cà phê đậm đặc", "Thức uống", "Cà phê đen" },
                    { 8, "", 30000, "Nước ép cam pha chế", "Thức uống", "Nước cam" },
                    { 9, "", 15000, "Nước tắc pha chế", "Thức uống", "Trà tắc" },
                    { 10, "", 15000, "Nước Chanh pha chế", "Thức uống", "Trà chanh" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MonAns",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MonAns",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MonAns",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MonAns",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MonAns",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MonAns",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MonAns",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MonAns",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
