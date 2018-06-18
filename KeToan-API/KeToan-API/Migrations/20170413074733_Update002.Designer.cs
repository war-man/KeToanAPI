using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using API;

namespace API.Migrations
{
    [DbContext(typeof(zModel))]
    [Migration("20170413074733_Update002")]
    partial class Update002
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KeToan.eCdkh", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DuCo")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuCo1")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuCoNT")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuCoNT1")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuNo")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuNo1")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuNoNT")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuNoNT1")
                        .HasColumnType("decimal(16,2)");

                    b.Property<string>("KhachHangID")
                        .IsRequired();

                    b.Property<int>("Nam");

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<int>("TKID");

                    b.HasKey("KeyID");

                    b.ToTable("eCdkh");
                });

            modelBuilder.Entity("KeToan.eCdnh", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DuCo")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuCo1")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuCoNT")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuCoNT1")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuNo")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuNo1")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuNoNT")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuNoNT1")
                        .HasColumnType("decimal(16,2)");

                    b.Property<int>("Nam");

                    b.Property<int>("NganHangID")
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<int>("TKID")
                        .IsUnicode(false);

                    b.HasKey("KeyID");

                    b.ToTable("eCdnh");
                });

            modelBuilder.Entity("KeToan.eCdvt", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DuDau");

                    b.Property<decimal>("DuNT");

                    b.Property<int>("KhoID");

                    b.Property<int>("Nam");

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<decimal>("TonDau");

                    b.Property<int>("VTHHID");

                    b.HasKey("KeyID");

                    b.ToTable("eCdvt");
                });

            modelBuilder.Entity("KeToan.eCt_ctts", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DVTID");

                    b.Property<decimal>("GiaTri")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("SoLuong")
                        .HasColumnType("decimal(15,3)");

                    b.Property<int>("TSCDID");

                    b.HasKey("KeyID");

                    b.ToTable("eCt_ctts");
                });

            modelBuilder.Entity("KeToan.eCt_ts", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DienGiai");

                    b.Property<decimal>("GTCL")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("GT_Da_KH")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("GT_KH_Ky")
                        .HasColumnType("decimal(16,2)");

                    b.Property<DateTime>("NgayCT");

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<int>("NguonVonID");

                    b.Property<decimal>("NguyenGia")
                        .HasColumnType("decimal(16,2)");

                    b.Property<string>("SoCT")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int>("TSCDID");

                    b.Property<int>("Tang_Giam");

                    b.HasKey("KeyID");

                    b.ToTable("eCt_ts");
                });

            modelBuilder.Entity("KeToan.eDm_bophan", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaBP")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int>("PhongBanID");

                    b.Property<string>("TenBP")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyID");

                    b.HasIndex("MaBP")
                        .IsUnique();

                    b.ToTable("eDm_bophan");
                });

            modelBuilder.Entity("KeToan.eDm_cc", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BPHTID");

                    b.Property<int>("BPSDID");

                    b.Property<int>("ChiNhanhID");

                    b.Property<decimal>("GiaTriConLai")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("KieuPB")
                        .HasColumnType("decimal(16,2)");

                    b.Property<int>("LoaiCCID");

                    b.Property<string>("MaCC")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<decimal>("NgayPB")
                        .HasColumnType("decimal(16,2)");

                    b.Property<DateTime>("NgayTang");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<int>("NhomTSCDID");

                    b.Property<int>("PXID");

                    b.Property<decimal>("SoKyPB")
                        .HasColumnType("decimal(16,2)");

                    b.Property<int>("TGTSCDID");

                    b.Property<int?>("TKCC");

                    b.Property<int>("TKCP");

                    b.Property<int?>("TKPB");

                    b.Property<string>("TenCC")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("YTCPID");

                    b.HasKey("KeyID");

                    b.HasIndex("MaCC")
                        .IsUnique();

                    b.ToTable("eDm_cc");
                });

            modelBuilder.Entity("KeToan.eDm_chinhanh", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CongTyID");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("DienThoai")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<string>("MaCN")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("TenCN");

                    b.HasKey("KeyID");

                    b.HasIndex("MaCN")
                        .IsUnique();

                    b.ToTable("eDm_chinhanh");
                });

            modelBuilder.Entity("KeToan.eDm_chucdanh", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AnHien");

                    b.Property<string>("DienGiai")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("MaChucDanh")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.HasKey("KeyID");

                    b.HasIndex("MaChucDanh")
                        .IsUnique();

                    b.ToTable("eDm_chucdanh");
                });

            modelBuilder.Entity("KeToan.eDm_chucvu", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AnHien");

                    b.Property<string>("DienGiai")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("MaChucVu")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.HasKey("KeyID");

                    b.HasIndex("MaChucVu")
                        .IsUnique();

                    b.ToTable("eDm_chucvu");
                });

            modelBuilder.Entity("KeToan.eDm_cty", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("DienThoai")
                        .IsRequired();

                    b.Property<int>("MST");

                    b.Property<string>("MaCTy")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("TenCTy")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyID");

                    b.HasIndex("MaCTy")
                        .IsUnique();

                    b.ToTable("eDm_cty");
                });

            modelBuilder.Entity("KeToan.eDm_dvt", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaDVT")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("TenDVT")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyID");

                    b.HasIndex("MaDVT")
                        .IsUnique();

                    b.ToTable("eDm_dvt");
                });

            modelBuilder.Entity("KeToan.eDm_httl", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DienGiai")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.HasKey("KeyID");

                    b.ToTable("eDm_httl");
                });

            modelBuilder.Entity("KeToan.eDm_kho", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AnHien");

                    b.Property<string>("MaKho")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<int?>("TKDL");

                    b.Property<string>("TenKho")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyID");

                    b.HasIndex("MaKho")
                        .IsUnique();

                    b.ToTable("eDm_kho");
                });

            modelBuilder.Entity("KeToan.eDm_ktbc", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChiNhanhID");

                    b.Property<decimal?>("LoaiKC")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("Nam")
                        .HasColumnType("decimal(4,0)");

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<decimal>("STT")
                        .HasColumnType("decimal(3,0)");

                    b.Property<string>("STTKC")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int>("TKCo");

                    b.Property<int>("TKNo");

                    b.Property<string>("TenBT")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyID");

                    b.ToTable("eDm_ktbc");
                });

            modelBuilder.Entity("KeToan.eDm_loaitscd", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaLoaiTSCD")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyID");

                    b.HasIndex("MaLoaiTSCD")
                        .IsUnique();

                    b.HasIndex("TenLoai")
                        .IsUnique();

                    b.ToTable("eDm_loaitscd");
                });

            modelBuilder.Entity("KeToan.eDm_lytcp", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaLoaiYTCP")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<string>("TenLoaiYTCP")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyID");

                    b.HasIndex("MaLoaiYTCP")
                        .IsUnique();

                    b.ToTable("eDm_lytcp");
                });

            modelBuilder.Entity("KeToan.eDm_nganhang", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DienThoai");

                    b.Property<string>("Email")
                        .HasMaxLength(250);

                    b.Property<string>("MaSoThue");

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<string>("TKNganHang")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("TaiKhoanID");

                    b.Property<string>("TenNH")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("TinhThanhID");

                    b.HasKey("KeyID");

                    b.HasIndex("TKNganHang")
                        .IsUnique();

                    b.ToTable("eDm_nganhang");
                });

            modelBuilder.Entity("KeToan.eDm_nguonvon", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaNguonVon")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<string>("TenNguonVon")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyID");

                    b.HasIndex("MaNguonVon")
                        .IsUnique();

                    b.ToTable("eDm_nguonvon");
                });

            modelBuilder.Entity("KeToan.eDm_nhom_cc", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("LoaiNhomDC")
                        .HasColumnType("decimal(1,0)");

                    b.Property<string>("MaNhomCC")
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<string>("TenNhomCC");

                    b.HasKey("KeyID");

                    b.HasIndex("MaNhomCC")
                        .IsUnique();

                    b.ToTable("eDm_nhom_cc");
                });

            modelBuilder.Entity("KeToan.eDm_nhomhhvt", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaNhomHHVT")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<string>("TenNhom")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyID");

                    b.HasIndex("MaNhomHHVT")
                        .IsUnique();

                    b.ToTable("eDm_nhomhhvt");
                });

            modelBuilder.Entity("KeToan.eDm_nhomtk", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaNTK")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.HasKey("KeyID");

                    b.HasIndex("MaNTK")
                        .IsUnique();

                    b.ToTable("eDm_nhomtk");
                });

            modelBuilder.Entity("KeToan.eDm_nhomtscd", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaNhomTSCD")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<string>("TenNhom")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyID");

                    b.HasIndex("MaNhomTSCD")
                        .IsUnique();

                    b.ToTable("eDm_nhomtscd");
                });

            modelBuilder.Entity("KeToan.eDm_nt", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaNT")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("TenNT")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyID");

                    b.HasIndex("MaNT")
                        .IsUnique();

                    b.ToTable("eDm_nt");
                });

            modelBuilder.Entity("KeToan.eDm_nv", b =>
                {
                    b.Property<Guid>("KeyID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BaoHiem");

                    b.Property<int>("ChiNhanhID");

                    b.Property<int?>("DTDD");

                    b.Property<string>("DiaChiThuongTru")
                        .HasMaxLength(250);

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<bool>("GioiTinh");

                    b.Property<int>("HTTraLuongID");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<bool>("HonNhan");

                    b.Property<int>("LuongCoBan")
                        .HasMaxLength(10);

                    b.Property<string>("MaNV")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("MaSoThue")
                        .HasMaxLength(20);

                    b.Property<DateTime>("NgayCap")
                        .HasColumnType("date");

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<int>("NoiCap");

                    b.Property<string>("NoiSinh");

                    b.Property<string>("QueQuan")
                        .HasMaxLength(250);

                    b.Property<int>("SoCMND");

                    b.HasKey("KeyID");

                    b.HasIndex("MaNV")
                        .IsUnique();

                    b.ToTable("eDm_nv");
                });

            modelBuilder.Entity("KeToan.eDm_nytcp", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaNhomYTCPID")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<string>("TenNhomYTCPID")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyID");

                    b.HasIndex("MaNhomYTCPID")
                        .IsUnique();

                    b.ToTable("eDm_nytcp");
                });

            modelBuilder.Entity("KeToan.eDm_phongban", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AnHien");

                    b.Property<int>("ChiNhanhID");

                    b.Property<string>("DienGiai")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("MaPB")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.HasKey("KeyID");

                    b.HasIndex("MaPB")
                        .IsUnique();

                    b.ToTable("eDm_phongban");
                });

            modelBuilder.Entity("KeToan.eDm_pl_cc", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaLoaiCC")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<string>("TenLoaiCC")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyID");

                    b.HasIndex("MaLoaiCC")
                        .IsUnique();

                    b.ToTable("eDm_pl_cc");
                });

            modelBuilder.Entity("KeToan.eDm_tgtscd", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("LoaiTG")
                        .HasColumnType("decimal(1,0)");

                    b.Property<string>("MaTGTSCD")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<string>("TenTGTSCD")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyID");

                    b.HasIndex("MaTGTSCD")
                        .IsUnique();

                    b.ToTable("eDm_tgtscd");
                });

            modelBuilder.Entity("KeToan.eDm_tk", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BacTK");

                    b.Property<int>("NTKID");

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<int>("NguyenTeID");

                    b.Property<string>("TK")
                        .IsRequired()
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<bool>("TKCN");

                    b.Property<int?>("TKMe");

                    b.Property<bool>("TKSC");

                    b.Property<string>("TenTK")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyID");

                    b.HasIndex("TK")
                        .IsUnique();

                    b.ToTable("eDm_tk");
                });

            modelBuilder.Entity("KeToan.eDm_ts", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BPID");

                    b.Property<int>("BoPhanHT");

                    b.Property<int>("ChiNhanh");

                    b.Property<decimal>("GiaTriConLai")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("KieuKhauHao")
                        .HasColumnType("decimal(1,0)");

                    b.Property<int>("LoaiTSCDID");

                    b.Property<string>("MaTSCD")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayKhauHao")
                        .HasColumnType("date");

                    b.Property<DateTime>("NgayTang")
                        .HasColumnType("date");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<int>("NhomTSCDID");

                    b.Property<int>("PXID");

                    b.Property<decimal>("SoKyKhauHao")
                        .HasColumnType("decimal(3,0)");

                    b.Property<int>("TGTSCDID");

                    b.Property<int>("TKCP");

                    b.Property<int>("TKKH");

                    b.Property<int>("TKTS");

                    b.Property<string>("TenTSCD")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("YTCPID");

                    b.HasKey("KeyID");

                    b.HasIndex("MaTSCD")
                        .IsUnique();

                    b.ToTable("eDm_ts");
                });

            modelBuilder.Entity("KeToan.eDm_tt", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DienGiai")
                        .HasMaxLength(250);

                    b.Property<int?>("MaCha");

                    b.Property<int>("MaTinhThanh");

                    b.HasKey("KeyID");

                    b.HasIndex("DienGiai")
                        .IsUnique();

                    b.ToTable("eDm_tt");
                });

            modelBuilder.Entity("KeToan.eDm_vthh", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChiNhanhID");

                    b.Property<int>("DVTID");

                    b.Property<decimal?>("GiaTon")
                        .HasColumnType("decimal(1,0)");

                    b.Property<string>("MaVTHH")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<int>("SLMax");

                    b.Property<int>("SLMin");

                    b.Property<bool>("TDTK");

                    b.Property<int?>("TKDT");

                    b.Property<int?>("TKDTNB");

                    b.Property<int?>("TKGV");

                    b.Property<int?>("TKSPDD");

                    b.Property<int?>("TKTL");

                    b.Property<int?>("TKVT");

                    b.Property<string>("TenVTHH")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int?>("VTTonKho");

                    b.HasKey("KeyID");

                    b.HasIndex("MaVTHH")
                        .IsUnique();

                    b.ToTable("eDm_vthh");
                });

            modelBuilder.Entity("KeToan.eDm_ytcp", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("KieuTHCP")
                        .HasColumnType("decimal(1,0)");

                    b.Property<decimal>("LoaiPB")
                        .HasColumnType("decimal(1,0)");

                    b.Property<int>("LoaiYTCP");

                    b.Property<string>("MaYTCPID")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<int>("NhomYTCPID");

                    b.Property<int>("TKCo");

                    b.Property<int>("TKDD");

                    b.Property<int>("TKNo");

                    b.Property<string>("TenMaYTCPID")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyID");

                    b.HasIndex("MaYTCPID")
                        .IsUnique();

                    b.ToTable("eDm_ytcp");
                });

            modelBuilder.Entity("KeToan.eKhachhang", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChiNhanhID");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(250);

                    b.Property<string>("DienThoai");

                    b.Property<string>("Email");

                    b.Property<string>("Fax")
                        .HasMaxLength(20);

                    b.Property<int?>("HanThanhToan");

                    b.Property<string>("MaKH")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("MaSoThue");

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<int>("TK");

                    b.Property<int?>("TKNganHang");

                    b.Property<string>("TenKH")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("TenNganHang");

                    b.Property<int>("TinhThanhID");

                    b.HasKey("KeyID");

                    b.HasIndex("MaKH")
                        .IsUnique();

                    b.ToTable("eKhachhang");
                });

            modelBuilder.Entity("KeToan.eNhomhhvtxref", b =>
                {
                    b.Property<int>("NhomHHVTID");

                    b.Property<int>("VTHHID");

                    b.HasKey("NhomHHVTID", "VTHHID");

                    b.ToTable("eNhomhhvtxref");
                });

            modelBuilder.Entity("KeToan.ePXBPHTXREF", b =>
                {
                    b.Property<int>("BPID");

                    b.Property<int>("KeyID");

                    b.HasKey("BPID", "KeyID");

                    b.ToTable("ePXBPHTXREF");
                });

            modelBuilder.Entity("KeToan.xAccount", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccCode")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<string>("AccName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<bool>("AnHien");

                    b.Property<int>("ChiNhanhID");

                    b.Property<Guid>("NVID");

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<string>("Password");

                    b.HasKey("KeyID");

                    b.HasIndex("AccCode")
                        .IsUnique();

                    b.HasIndex("AccName")
                        .IsUnique();

                    b.ToTable("xAccount");
                });

            modelBuilder.Entity("KeToan.xAppctl", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GiaTri");

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<string>("Ten")
                        .IsUnicode(false);

                    b.HasKey("KeyID");

                    b.HasIndex("Ten")
                        .IsUnique();

                    b.ToTable("xAppctl");
                });

            modelBuilder.Entity("KeToan.xCdtk", b =>
                {
                    b.Property<int>("KeyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DuCo")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuCo1")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuCoNT")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuCoNT1")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuNo")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuNo1")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuNoNT")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("DuNoNT1")
                        .HasColumnType("decimal(16,2)");

                    b.Property<int>("Nam");

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime>("NgayTao");

                    b.Property<int?>("NguoiCapNhat");

                    b.Property<int>("NguoiTao");

                    b.Property<string>("TK")
                        .IsRequired()
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<int>("TKID");

                    b.HasKey("KeyID");

                    b.HasIndex("TK")
                        .IsUnique();

                    b.ToTable("xCdtks");
                });
        }
    }
}
