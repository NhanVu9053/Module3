using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookHouse.Migrations
{
    public partial class AddDBSach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChuyenNganhs",
                columns: table => new
                {
                    ChuyenNganhId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChuyenNganh = table.Column<string>(nullable: true),
                    Mota = table.Column<string>(nullable: true),
                    _IdDauSach = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenNganhs", x => x.ChuyenNganhId);
                });

            migrationBuilder.CreateTable(
                name: "Lops",
                columns: table => new
                {
                    LopId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLop = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lops", x => x.LopId);
                });

            migrationBuilder.CreateTable(
                name: "DauSachs",
                columns: table => new
                {
                    DauSachID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDauSach = table.Column<string>(nullable: true),
                    SoTrang = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    SoLuongCon = table.Column<int>(nullable: false),
                    NXB = table.Column<string>(nullable: true),
                    _ChuyenNganhId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DauSachs", x => x.DauSachID);
                    table.ForeignKey(
                        name: "FK_DauSachs_ChuyenNganhs__ChuyenNganhId",
                        column: x => x._ChuyenNganhId,
                        principalTable: "ChuyenNganhs",
                        principalColumn: "ChuyenNganhId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocGias",
                columns: table => new
                {
                    DocGiaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(nullable: true),
                    QueQuan = table.Column<string>(nullable: true),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    _LopId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocGias", x => x.DocGiaId);
                    table.ForeignKey(
                        name: "FK_DocGias_Lops__LopId",
                        column: x => x._LopId,
                        principalTable: "Lops",
                        principalColumn: "LopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sachs",
                columns: table => new
                {
                    SachId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSach = table.Column<string>(nullable: true),
                    TacGia = table.Column<string>(nullable: true),
                    NgayNhap = table.Column<DateTime>(nullable: false),
                    TinhTrang = table.Column<int>(nullable: false),
                    _DauSachId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sachs", x => x.SachId);
                    table.ForeignKey(
                        name: "FK_Sachs_DauSachs__DauSachId",
                        column: x => x._DauSachId,
                        principalTable: "DauSachs",
                        principalColumn: "DauSachID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DauSachs__ChuyenNganhId",
                table: "DauSachs",
                column: "_ChuyenNganhId");

            migrationBuilder.CreateIndex(
                name: "IX_DocGias__LopId",
                table: "DocGias",
                column: "_LopId");

            migrationBuilder.CreateIndex(
                name: "IX_Sachs__DauSachId",
                table: "Sachs",
                column: "_DauSachId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocGias");

            migrationBuilder.DropTable(
                name: "Sachs");

            migrationBuilder.DropTable(
                name: "Lops");

            migrationBuilder.DropTable(
                name: "DauSachs");

            migrationBuilder.DropTable(
                name: "ChuyenNganhs");
        }
    }
}
