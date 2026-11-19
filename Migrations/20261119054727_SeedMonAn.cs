using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuanCafe.Migrations
{
    /// <inheritdoc />
    public partial class SeedMonAn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MonAns",
                columns: new[] { "Id", "AnhUrl", "Gia", "MoTa", "Nhom", "Ten" },
                values: new object[,]
                {
                    { 1, "", 30000, "Bánh mì trứng chả xúc xích thịt", "Đồ ăn nhanh", "Bánh mì" },
                    { 2, "", 30000, "Phở thịt bò", "Đồ nước", "Phở bò" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MonAns",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MonAns",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
