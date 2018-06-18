using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API.Migrations
{
    public partial class Update007 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "xAccount");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "xCdtks",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "xAppctl",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "TKNganHang",
                table: "eKhachhang",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(int),
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eKhachhang",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_ytcp",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_vthh",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_ts",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_tk",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_tgtscd",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_pl_cc",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_phongban",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_nytcp",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_nv",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_nhomtscd",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_nhomhhvt",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_nhom_cc",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_nguonvon",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_nganhang",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_lytcp",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_loaitscd",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_ktbc",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_kho",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_httl",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_chucvu",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_chucdanh",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_cc",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eCt_ts",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eCdvt",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eCdnh",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eCdkh",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.CreateTable(
                name: "eDm_Gia",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gia = table.Column<decimal>(type: "decimal(15,4)", nullable: false),
                    GiaNT = table.Column<decimal>(type: "decimal(15,4)", nullable: false),
                    NgayAD = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    NhomKH3 = table.Column<decimal>(type: "decimal(1,0)", nullable: false),
                    VTID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_Gia", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_NhomKH",
                columns: table => new
                {
                    MaNhomKH = table.Column<string>(maxLength: 16, nullable: false),
                    LoaiNhKH = table.Column<decimal>(type: "decimal(1,0)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: false),
                    NgayTao = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    NguoiCapNhat = table.Column<int>(nullable: false),
                    NguoiTao = table.Column<int>(nullable: false),
                    TenNhomKH = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_NhomKH", x => x.MaNhomKH);
                    table.UniqueConstraint("AK_eDm_NhomKH_LoaiNhKH", x => x.LoaiNhKH);
                });

            migrationBuilder.CreateTable(
                name: "eDm_Thck",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GhiChu = table.Column<string>(nullable: true),
                    HanTT = table.Column<decimal>(type: "decimal(3,0)", nullable: false),
                    MaTHCK = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    THCK = table.Column<decimal>(type: "decimal(3,0)", nullable: false),
                    TenTHCK = table.Column<string>(maxLength: 250, nullable: false),
                    TyLe = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_Thck", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eTaiKhoan",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccCode = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    AccName = table.Column<string>(maxLength: 128, nullable: false),
                    AnHien = table.Column<bool>(nullable: false, defaultValue: true),
                    ChiNhanhID = table.Column<int>(nullable: false),
                    NVID = table.Column<Guid>(nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    PhanQuyenID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eTaiKhoan", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "xChucNang",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ControllerName = table.Column<string>(maxLength: 250, nullable: true),
                    Methods = table.Column<string>(maxLength: 250, nullable: true),
                    Route = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xChucNang", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eQuyen",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChucNangID = table.Column<int>(nullable: false),
                    PhanQuyenID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eQuyen", x => x.KeyID);
                    table.ForeignKey(
                        name: "FK_eQuyen_xChucNang_ChucNangID",
                        column: x => x.ChucNangID,
                        principalTable: "xChucNang",
                        principalColumn: "KeyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_eDm_Thck_MaTHCK",
                table: "eDm_Thck",
                column: "MaTHCK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eQuyen_ChucNangID",
                table: "eQuyen",
                column: "ChucNangID");

            migrationBuilder.CreateIndex(
                name: "IX_eTaiKhoan_AccCode",
                table: "eTaiKhoan",
                column: "AccCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eTaiKhoan_AccName",
                table: "eTaiKhoan",
                column: "AccName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eDm_Gia");

            migrationBuilder.DropTable(
                name: "eDm_NhomKH");

            migrationBuilder.DropTable(
                name: "eDm_Thck");

            migrationBuilder.DropTable(
                name: "eQuyen");

            migrationBuilder.DropTable(
                name: "eTaiKhoan");

            migrationBuilder.DropTable(
                name: "xChucNang");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "xCdtks",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "xAppctl",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<int>(
                name: "TKNganHang",
                table: "eKhachhang",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eKhachhang",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_ytcp",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_vthh",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_ts",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_tk",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_tgtscd",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_pl_cc",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_phongban",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_nytcp",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_nv",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_nhomtscd",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_nhomhhvt",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_nhom_cc",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_nguonvon",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_nganhang",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_lytcp",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_loaitscd",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_ktbc",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_kho",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_httl",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_chucvu",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_chucdanh",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eDm_cc",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eCt_ts",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eCdvt",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eCdnh",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "eCdkh",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.CreateTable(
                name: "xAccount",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccCode = table.Column<string>(unicode: false, nullable: false),
                    AccName = table.Column<string>(maxLength: 128, nullable: false),
                    AnHien = table.Column<bool>(nullable: false),
                    ChiNhanhID = table.Column<int>(nullable: false),
                    NVID = table.Column<Guid>(nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xAccount", x => x.KeyID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_xAccount_AccCode",
                table: "xAccount",
                column: "AccCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_xAccount_AccName",
                table: "xAccount",
                column: "AccName",
                unique: true);
        }
    }
}
