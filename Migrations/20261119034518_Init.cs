using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanCafe.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LienHes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HoTen = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    SoDienThoai = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    NoiDung = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    NgayGui = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LienHes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonAns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ten = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Gia = table.Column<int>(type: "INTEGER", nullable: false),
                    MoTa = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    AnhUrl = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    Nhom = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonAns", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LienHes");

            migrationBuilder.DropTable(
                name: "MonAns");
        }
    }
}
