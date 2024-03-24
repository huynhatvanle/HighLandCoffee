using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HighLandCoffee.Migrations
{
    /// <inheritdoc />
    public partial class Highland : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Tendn = table.Column<string>(type: "TEXT", nullable: false),
                    Pass = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Tendn);
                });

            migrationBuilder.CreateTable(
                name: "Khachhang",
                columns: table => new
                {
                    Makh = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tenkh = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Diachi = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    SoDT = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachhang", x => x.Makh);
                });

            migrationBuilder.CreateTable(
                name: "Loai",
                columns: table => new
                {
                    Maloai = table.Column<string>(type: "TEXT", nullable: false),
                    Tenloai = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loai", x => x.Maloai);
                });

            migrationBuilder.CreateTable(
                name: "Hoadon",
                columns: table => new
                {
                    Mahd = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ngaymua = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Makh = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoadon", x => x.Mahd);
                    table.ForeignKey(
                        name: "FK_Hoadon_Khachhang_Makh",
                        column: x => x.Makh,
                        principalTable: "Khachhang",
                        principalColumn: "Makh",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Monan",
                columns: table => new
                {
                    Mamon = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tenmon = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Soluong = table.Column<long>(type: "INTEGER", nullable: false),
                    Gia = table.Column<long>(type: "INTEGER", nullable: false),
                    Maloai = table.Column<string>(type: "TEXT", nullable: false),
                    Anh = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monan", x => x.Mamon);
                    table.ForeignKey(
                        name: "FK_Monan_Loai_Maloai",
                        column: x => x.Maloai,
                        principalTable: "Loai",
                        principalColumn: "Maloai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChitietHD",
                columns: table => new
                {
                    Machitiet = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Soluongmua = table.Column<long>(type: "INTEGER", nullable: false),
                    Gia = table.Column<long>(type: "INTEGER", nullable: false),
                    Mahd = table.Column<int>(type: "INTEGER", nullable: false),
                    Mamon = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChitietHD", x => x.Machitiet);
                    table.ForeignKey(
                        name: "FK_ChitietHD_Hoadon_Mahd",
                        column: x => x.Mahd,
                        principalTable: "Hoadon",
                        principalColumn: "Mahd",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChitietHD_Monan_Mamon",
                        column: x => x.Mamon,
                        principalTable: "Monan",
                        principalColumn: "Mamon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChitietHD_Mahd",
                table: "ChitietHD",
                column: "Mahd");

            migrationBuilder.CreateIndex(
                name: "IX_ChitietHD_Mamon",
                table: "ChitietHD",
                column: "Mamon");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadon_Makh",
                table: "Hoadon",
                column: "Makh");

            migrationBuilder.CreateIndex(
                name: "IX_Monan_Maloai",
                table: "Monan",
                column: "Maloai");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "ChitietHD");

            migrationBuilder.DropTable(
                name: "Hoadon");

            migrationBuilder.DropTable(
                name: "Monan");

            migrationBuilder.DropTable(
                name: "Khachhang");

            migrationBuilder.DropTable(
                name: "Loai");
        }
    }
}
