using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API.Migrations
{
    public partial class Update001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "eCdkh",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DuCo = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuCo1 = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuCoNT = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuCoNT1 = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuNo = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuNo1 = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuNoNT = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuNoNT1 = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    KhachHangID = table.Column<string>(nullable: false),
                    Nam = table.Column<int>(nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    TKID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eCdkh", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eCdnh",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DuCo = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuCo1 = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuCoNT = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuCoNT1 = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuNo = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuNo1 = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuNoNT = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuNoNT1 = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    Nam = table.Column<int>(nullable: false),
                    NganHangID = table.Column<int>(unicode: false, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    TKID = table.Column<int>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eCdnh", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eCdvt",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DuDau = table.Column<decimal>(nullable: false),
                    DuNT = table.Column<decimal>(nullable: false),
                    KhoID = table.Column<int>(nullable: false),
                    Nam = table.Column<int>(nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    TonDau = table.Column<decimal>(nullable: false),
                    VTHHID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eCdvt", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eCt_ctts",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DVTID = table.Column<int>(nullable: false),
                    GiaTri = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    SoLuong = table.Column<decimal>(type: "decimal(15,3)", nullable: false),
                    TSCDID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eCt_ctts", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eCt_ts",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DienGiai = table.Column<string>(nullable: true),
                    GTCL = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    GT_Da_KH = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    GT_KH_Ky = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    NgayCT = table.Column<DateTime>(nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    NguonVonID = table.Column<int>(nullable: false),
                    NguyenGia = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    SoCT = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    TSCDID = table.Column<int>(nullable: false),
                    Tang_Giam = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eCt_ts", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_bophan",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaBP = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    PhongBanID = table.Column<int>(nullable: false),
                    TenBP = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_bophan", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_cc",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BPHTID = table.Column<int>(nullable: true),
                    BPSDID = table.Column<int>(nullable: false),
                    ChiNhanhID = table.Column<int>(nullable: false),
                    GiaTriConLai = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    KieuPB = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    LoaiCCID = table.Column<int>(nullable: false),
                    MaCC = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayPB = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    NgayTang = table.Column<DateTime>(nullable: false),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    NhomTSCDID = table.Column<int>(nullable: false),
                    PXID = table.Column<int>(nullable: false),
                    SoKyPB = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    TGTSCDID = table.Column<int>(nullable: false),
                    TKCC = table.Column<int>(nullable: true),
                    TKCP = table.Column<int>(nullable: false),
                    TKPB = table.Column<int>(nullable: true),
                    TenCC = table.Column<string>(maxLength: 250, nullable: false),
                    YTCPID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_cc", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_chinhanh",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CongTyID = table.Column<int>(nullable: false),
                    DiaChi = table.Column<string>(maxLength: 250, nullable: false),
                    DienThoai = table.Column<string>(unicode: false, nullable: false),
                    MaCN = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    TenCN = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_chinhanh", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_chucdanh",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnHien = table.Column<bool>(nullable: false),
                    DienGiai = table.Column<string>(maxLength: 250, nullable: false),
                    MaChucDanh = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_chucdanh", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_chucvu",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnHien = table.Column<bool>(nullable: false),
                    DienGiai = table.Column<string>(maxLength: 250, nullable: false),
                    MaChucVu = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_chucvu", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_cty",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DiaChi = table.Column<string>(maxLength: 250, nullable: false),
                    DienThoai = table.Column<string>(nullable: false),
                    MST = table.Column<int>(nullable: false),
                    MaCTy = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    TenCTy = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_cty", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_dvt",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaDVT = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    TenDVT = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_dvt", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_httl",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DienGiai = table.Column<string>(maxLength: 250, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_httl", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_kho",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnHien = table.Column<bool>(nullable: false),
                    MaKho = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    TKDL = table.Column<int>(nullable: true),
                    TenKho = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_kho", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_ktbc",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChiNhanhID = table.Column<int>(nullable: false),
                    LoaiKC = table.Column<decimal>(type: "decimal(16,2)", nullable: true),
                    Nam = table.Column<decimal>(type: "decimal(4,0)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    STT = table.Column<decimal>(type: "decimal(3,0)", nullable: false),
                    STTKC = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    TKCo = table.Column<int>(nullable: false),
                    TKNo = table.Column<int>(nullable: false),
                    TenBT = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_ktbc", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_loaitscd",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaLoaiTSCD = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    TenLoai = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_loaitscd", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_lytcp",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaLoaiYTCP = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    TenLoaiYTCP = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_lytcp", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_nganhang",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DienThoai = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 250, nullable: true),
                    MaSoThue = table.Column<string>(nullable: true),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    TKNganHang = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    TaiKhoanID = table.Column<int>(nullable: false),
                    TenNH = table.Column<string>(maxLength: 250, nullable: false),
                    TinhThanhID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_nganhang", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_nguonvon",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaNguonVon = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    TenNguonVon = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_nguonvon", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_nhom_cc",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoaiNhomDC = table.Column<decimal>(type: "decimal(1,0)", nullable: true),
                    MaNhomCC = table.Column<string>(unicode: false, nullable: true),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    TenNhomCC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_nhom_cc", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_nhomhhvt",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaNhomHHVT = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    TenNhom = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_nhomhhvt", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_nhomtk",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaNTK = table.Column<string>(unicode: false, maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_nhomtk", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_nhomtscd",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaNhomTSCD = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    TenNhom = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_nhomtscd", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_nt",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaNT = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    TenNT = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_nt", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_nv",
                columns: table => new
                {
                    KeyID = table.Column<Guid>(nullable: false),
                    BaoHiem = table.Column<int>(nullable: true),
                    ChiNhanhID = table.Column<int>(nullable: false),
                    DTDD = table.Column<int>(nullable: true),
                    DiaChiThuongTru = table.Column<string>(maxLength: 250, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    GioiTinh = table.Column<bool>(nullable: false),
                    HTTraLuongID = table.Column<int>(nullable: false),
                    HoTen = table.Column<string>(maxLength: 250, nullable: false),
                    HonNhan = table.Column<bool>(nullable: false),
                    LuongCoBan = table.Column<int>(maxLength: 10, nullable: false),
                    MaNV = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    MaSoThue = table.Column<string>(maxLength: 20, nullable: true),
                    NgayCap = table.Column<DateTime>(type: "date", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "date", nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    NoiCap = table.Column<int>(nullable: false),
                    NoiSinh = table.Column<string>(nullable: true),
                    QueQuan = table.Column<string>(maxLength: 250, nullable: true),
                    SoCMND = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_nv", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_nytcp",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaNhomYTCPID = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    TenNhomYTCPID = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_nytcp", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_phongban",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnHien = table.Column<bool>(nullable: false),
                    ChiNhanhID = table.Column<int>(nullable: false),
                    DienGiai = table.Column<string>(maxLength: 250, nullable: false),
                    MaPB = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_phongban", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_pl_cc",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaLoaiCC = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    TenLoaiCC = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_pl_cc", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_tgtscd",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoaiTG = table.Column<decimal>(type: "decimal(1,0)", nullable: false),
                    MaTGTSCD = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    TenTGTSCD = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_tgtscd", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_tk",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BacTK = table.Column<int>(nullable: false),
                    NTKID = table.Column<int>(nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    NguyenTeID = table.Column<int>(nullable: false),
                    TK = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    TKCN = table.Column<bool>(nullable: false),
                    TKMe = table.Column<int>(nullable: true),
                    TKSC = table.Column<bool>(nullable: false),
                    TenTK = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_tk", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_ts",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BPID = table.Column<int>(nullable: false),
                    BoPhanHT = table.Column<int>(nullable: false),
                    ChiNhanh = table.Column<int>(nullable: false),
                    GiaTriConLai = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    KieuKhauHao = table.Column<decimal>(type: "decimal(1,0)", nullable: false),
                    LoaiTSCDID = table.Column<int>(nullable: false),
                    MaTSCD = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayKhauHao = table.Column<DateTime>(type: "date", nullable: false),
                    NgayTang = table.Column<DateTime>(type: "date", nullable: false),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    NhomTSCDID = table.Column<int>(nullable: false),
                    PXID = table.Column<int>(nullable: false),
                    SoKyKhauHao = table.Column<decimal>(type: "decimal(3,0)", nullable: false),
                    TGTSCDID = table.Column<int>(nullable: false),
                    TKCP = table.Column<int>(nullable: false),
                    TKKH = table.Column<int>(nullable: false),
                    TKTS = table.Column<int>(nullable: false),
                    TenTSCD = table.Column<string>(maxLength: 250, nullable: false),
                    YTCPID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_ts", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_tt",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DienGiai = table.Column<string>(maxLength: 250, nullable: true),
                    MaCha = table.Column<int>(nullable: true),
                    MaTinhThanh = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_tt", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_vthh",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChiNhanhID = table.Column<int>(nullable: false),
                    DVTID = table.Column<int>(nullable: false),
                    GiaTon = table.Column<decimal>(type: "decimal(1,0)", nullable: true),
                    MaVTHH = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    SLMax = table.Column<int>(nullable: false),
                    SLMin = table.Column<int>(nullable: false),
                    TDTK = table.Column<bool>(nullable: false),
                    TKDT = table.Column<int>(nullable: true),
                    TKDTNB = table.Column<int>(nullable: true),
                    TKGV = table.Column<int>(nullable: true),
                    TKSPDD = table.Column<int>(nullable: true),
                    TKTL = table.Column<int>(nullable: true),
                    TKVT = table.Column<int>(nullable: true),
                    TenVTHH = table.Column<string>(maxLength: 250, nullable: false),
                    VTTonKho = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_vthh", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eDm_ytcp",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KieuTHCP = table.Column<decimal>(type: "decimal(1,0)", nullable: false),
                    LoaiPB = table.Column<decimal>(type: "decimal(1,0)", nullable: false),
                    LoaiYTCP = table.Column<int>(nullable: false),
                    MaYTCPID = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    NhomYTCPID = table.Column<int>(nullable: false),
                    TKCo = table.Column<int>(nullable: false),
                    TKDD = table.Column<int>(nullable: false),
                    TKNo = table.Column<int>(nullable: false),
                    TenMaYTCPID = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eDm_ytcp", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eKhachhang",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChiNhanhID = table.Column<int>(nullable: false),
                    DiaChi = table.Column<string>(maxLength: 250, nullable: true),
                    DienThoai = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(maxLength: 20, nullable: true),
                    HanThanhToan = table.Column<int>(nullable: true),
                    MaKH = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    MaSoThue = table.Column<string>(nullable: true),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    TKNganHang = table.Column<int>(nullable: true),
                    TenKH = table.Column<string>(maxLength: 250, nullable: false),
                    TenNganHang = table.Column<int>(nullable: true),
                    TinhThanhID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eKhachhang", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "eNhomhhvtxref",
                columns: table => new
                {
                    NhomHHVTID = table.Column<int>(nullable: false),
                    VTHHID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eNhomhhvtxref", x => new { x.NhomHHVTID, x.VTHHID });
                });

            migrationBuilder.CreateTable(
                name: "ePXBPHTXREF",
                columns: table => new
                {
                    BPID = table.Column<int>(nullable: false),
                    KeyID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ePXBPHTXREF", x => new { x.BPID, x.KeyID });
                });

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

            migrationBuilder.CreateTable(
                name: "xAppctl",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GiaTri = table.Column<string>(nullable: true),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    Ten = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xAppctl", x => x.KeyID);
                });

            migrationBuilder.CreateTable(
                name: "xCdtks",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DuCo = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuCo1 = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuCoNT = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuCoNT1 = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuNo = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuNo1 = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuNoNT = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DuNoNT1 = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    Nam = table.Column<int>(nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiCapNhat = table.Column<int>(nullable: true),
                    NguoiTao = table.Column<int>(nullable: false),
                    TK = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    TKID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xCdtks", x => x.KeyID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_eDm_bophan_MaBP",
                table: "eDm_bophan",
                column: "MaBP",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_cc_MaCC",
                table: "eDm_cc",
                column: "MaCC",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_chinhanh_MaCN",
                table: "eDm_chinhanh",
                column: "MaCN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_chucdanh_MaChucDanh",
                table: "eDm_chucdanh",
                column: "MaChucDanh",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_chucvu_MaChucVu",
                table: "eDm_chucvu",
                column: "MaChucVu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_cty_MaCTy",
                table: "eDm_cty",
                column: "MaCTy",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_dvt_MaDVT",
                table: "eDm_dvt",
                column: "MaDVT",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_kho_MaKho",
                table: "eDm_kho",
                column: "MaKho",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_loaitscd_MaLoaiTSCD",
                table: "eDm_loaitscd",
                column: "MaLoaiTSCD",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_loaitscd_TenLoai",
                table: "eDm_loaitscd",
                column: "TenLoai",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_lytcp_MaLoaiYTCP",
                table: "eDm_lytcp",
                column: "MaLoaiYTCP",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_nganhang_TKNganHang",
                table: "eDm_nganhang",
                column: "TKNganHang",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_nguonvon_MaNguonVon",
                table: "eDm_nguonvon",
                column: "MaNguonVon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_nhom_cc_MaNhomCC",
                table: "eDm_nhom_cc",
                column: "MaNhomCC",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_nhomhhvt_MaNhomHHVT",
                table: "eDm_nhomhhvt",
                column: "MaNhomHHVT",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_nhomtk_MaNTK",
                table: "eDm_nhomtk",
                column: "MaNTK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_nhomtscd_MaNhomTSCD",
                table: "eDm_nhomtscd",
                column: "MaNhomTSCD",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_nt_MaNT",
                table: "eDm_nt",
                column: "MaNT",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_nv_MaNV",
                table: "eDm_nv",
                column: "MaNV",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_nytcp_MaNhomYTCPID",
                table: "eDm_nytcp",
                column: "MaNhomYTCPID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_phongban_MaPB",
                table: "eDm_phongban",
                column: "MaPB",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_pl_cc_MaLoaiCC",
                table: "eDm_pl_cc",
                column: "MaLoaiCC",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_tgtscd_MaTGTSCD",
                table: "eDm_tgtscd",
                column: "MaTGTSCD",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_tk_TK",
                table: "eDm_tk",
                column: "TK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_ts_MaTSCD",
                table: "eDm_ts",
                column: "MaTSCD",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_tt_DienGiai",
                table: "eDm_tt",
                column: "DienGiai",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_vthh_MaVTHH",
                table: "eDm_vthh",
                column: "MaVTHH",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eDm_ytcp_MaYTCPID",
                table: "eDm_ytcp",
                column: "MaYTCPID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eKhachhang_MaKH",
                table: "eKhachhang",
                column: "MaKH",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_xAppctl_Ten",
                table: "xAppctl",
                column: "Ten",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_xCdtks_TK",
                table: "xCdtks",
                column: "TK",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eCdkh");

            migrationBuilder.DropTable(
                name: "eCdnh");

            migrationBuilder.DropTable(
                name: "eCdvt");

            migrationBuilder.DropTable(
                name: "eCt_ctts");

            migrationBuilder.DropTable(
                name: "eCt_ts");

            migrationBuilder.DropTable(
                name: "eDm_bophan");

            migrationBuilder.DropTable(
                name: "eDm_cc");

            migrationBuilder.DropTable(
                name: "eDm_chinhanh");

            migrationBuilder.DropTable(
                name: "eDm_chucdanh");

            migrationBuilder.DropTable(
                name: "eDm_chucvu");

            migrationBuilder.DropTable(
                name: "eDm_cty");

            migrationBuilder.DropTable(
                name: "eDm_dvt");

            migrationBuilder.DropTable(
                name: "eDm_httl");

            migrationBuilder.DropTable(
                name: "eDm_kho");

            migrationBuilder.DropTable(
                name: "eDm_ktbc");

            migrationBuilder.DropTable(
                name: "eDm_loaitscd");

            migrationBuilder.DropTable(
                name: "eDm_lytcp");

            migrationBuilder.DropTable(
                name: "eDm_nganhang");

            migrationBuilder.DropTable(
                name: "eDm_nguonvon");

            migrationBuilder.DropTable(
                name: "eDm_nhom_cc");

            migrationBuilder.DropTable(
                name: "eDm_nhomhhvt");

            migrationBuilder.DropTable(
                name: "eDm_nhomtk");

            migrationBuilder.DropTable(
                name: "eDm_nhomtscd");

            migrationBuilder.DropTable(
                name: "eDm_nt");

            migrationBuilder.DropTable(
                name: "eDm_nv");

            migrationBuilder.DropTable(
                name: "eDm_nytcp");

            migrationBuilder.DropTable(
                name: "eDm_phongban");

            migrationBuilder.DropTable(
                name: "eDm_pl_cc");

            migrationBuilder.DropTable(
                name: "eDm_tgtscd");

            migrationBuilder.DropTable(
                name: "eDm_tk");

            migrationBuilder.DropTable(
                name: "eDm_ts");

            migrationBuilder.DropTable(
                name: "eDm_tt");

            migrationBuilder.DropTable(
                name: "eDm_vthh");

            migrationBuilder.DropTable(
                name: "eDm_ytcp");

            migrationBuilder.DropTable(
                name: "eKhachhang");

            migrationBuilder.DropTable(
                name: "eNhomhhvtxref");

            migrationBuilder.DropTable(
                name: "ePXBPHTXREF");

            migrationBuilder.DropTable(
                name: "xAccount");

            migrationBuilder.DropTable(
                name: "xAppctl");

            migrationBuilder.DropTable(
                name: "xCdtks");
        }
    }
}
