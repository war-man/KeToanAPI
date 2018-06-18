using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using API;

namespace API.Migrations
{
    [DbContext(typeof(zModel))]
    partial class zModelModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KeToan.eCdkh", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

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

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int?>("NguoiCapNhat");

                b.Property<int>("NguoiTao");

                b.Property<int>("TKID");

                b.HasKey("KeyID");

                b.ToTable("eCdkh");
            });

            modelBuilder.Entity("KeToan.eCdnh", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

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

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

                b.Property<decimal>("DuDau");

                b.Property<decimal>("DuNT");

                b.Property<int>("KhoID");

                b.Property<int>("Nam");

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

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
                    .ValueGeneratedOnAdd();

                b.Property<string>("DienGiai");

                b.Property<decimal>("GTCL")
                    .HasColumnType("decimal(16,2)");

                b.Property<decimal>("GT_Da_KH")
                    .HasColumnType("decimal(16,2)");

                b.Property<decimal>("GT_KH_Ky")
                    .HasColumnType("decimal(16,2)");

                b.Property<DateTime>("NgayCT");

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

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
                    .ValueGeneratedOnAdd();

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

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

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
                    .ValueGeneratedOnAdd();

                b.Property<bool>("AnHien");

                b.Property<string>("DienGiai")
                    .IsRequired()
                    .HasMaxLength(250);

                b.Property<string>("MaChucDanh")
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

                b.Property<bool>("AnHien");

                b.Property<string>("DienGiai")
                    .IsRequired()
                    .HasMaxLength(250);

                b.Property<string>("MaChucVu")
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int?>("NguoiCapNhat");

                b.Property<int>("NguoiTao");

                b.HasKey("KeyID");

                b.HasIndex("MaChucVu")
                    .IsUnique();

                b.ToTable("eDm_chucvu");
            });

            modelBuilder.Entity("KeToan.eDm_ct", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("MaCT")
                    .HasMaxLength(3);

                b.Property<string>("MaCTIn")
                    .HasMaxLength(3);

                b.Property<string>("MaCTMe")
                    .HasMaxLength(3);

                b.Property<string>("MaPH")
                    .HasMaxLength(8);

                b.Property<string>("MaPost")
                    .HasMaxLength(8);

                b.Property<DateTime>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int>("NguoiCapNhat");

                b.Property<int>("NguoiTao");

                b.Property<int>("NguyenTeID");

                b.Property<decimal>("SoCT")
                    .HasColumnType("decimal(12,0)");

                b.Property<decimal>("SoLien")
                    .HasColumnType("decimal(1,0)");

                b.Property<decimal>("SoLienXacMinh")
                    .HasColumnType("decimal(2,0)");

                b.Property<string>("TenCT")
                    .HasMaxLength(128);

                b.HasKey("KeyID");

                b.ToTable("eDm_ct");
            });

            modelBuilder.Entity("KeToan.eDm_cty", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("DiaChi");

                b.Property<string>("DienThoai");

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
                    .ValueGeneratedOnAdd();

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

            modelBuilder.Entity("KeToan.eDm_gia", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<decimal>("Gia")
                    .HasColumnType("decimal(15,4)");

                b.Property<decimal>("GiaNT")
                    .HasColumnType("decimal(15,4)");

                b.Property<DateTime>("NgayAD");

                b.Property<int>("NhomKH3");

                b.HasKey("KeyID");

                b.ToTable("eDm_gia");
            });

            modelBuilder.Entity("KeToan.eDm_giaodich", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("CTID")
                    .HasMaxLength(3);

                b.Property<string>("LoaiCT")
                    .HasMaxLength(128);

                b.Property<string>("MaGD")
                    .HasMaxLength(1);

                b.Property<DateTime>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int>("NguoiCapNhat");

                b.Property<int>("NguoiTao");

                b.Property<string>("TenGD")
                    .HasMaxLength(2);

                b.HasKey("KeyID");

                b.ToTable("eDm_giaodich");
            });

            modelBuilder.Entity("KeToan.eDm_httl", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("DienGiai")
                    .IsRequired()
                    .HasMaxLength(250);

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int?>("NguoiCapNhat");

                b.Property<int>("NguoiTao");

                b.HasKey("KeyID");

                b.ToTable("eDm_httl");
            });

            modelBuilder.Entity("KeToan.eDm_kheuoc", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("MaKU")
                    .HasMaxLength(16);

                b.Property<string>("SoKU")
                    .HasMaxLength(16);

                b.Property<string>("TenKU")
                    .HasMaxLength(128);

                b.HasKey("KeyID");

                b.ToTable("eDm_kheuoc");
            });

            modelBuilder.Entity("KeToan.eDm_kho", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<bool>("AnHien");

                b.Property<string>("MaKho")
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

                b.Property<int>("ChiNhanhID");

                b.Property<decimal?>("LoaiKC")
                    .HasColumnType("decimal(16,2)");

                b.Property<decimal>("Nam")
                    .HasColumnType("decimal(4,0)");

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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

            modelBuilder.Entity("KeToan.eDm_Loaict", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("LoaiCT")
                    .HasMaxLength(255);

                b.Property<int>("SapXep");

                b.Property<string>("TenLoaiCT")
                    .HasMaxLength(100);

                b.HasKey("KeyID");

                b.ToTable("eDm_Loaict");
            });

            modelBuilder.Entity("KeToan.eDm_loaitscd", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("MaLoaiTSCD")
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

                b.Property<string>("MaLoaiYTCP")
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

                b.Property<string>("DienThoai");

                b.Property<string>("Email")
                    .HasMaxLength(250);

                b.Property<string>("Fax");

                b.Property<string>("MaSoThue");

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

                b.Property<string>("MaNguonVon")
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

                b.Property<decimal?>("LoaiNhomDC")
                    .HasColumnType("decimal(1,0)");

                b.Property<string>("MaNhomCC")
                    .IsUnicode(false);

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

                b.Property<string>("MaNhomHHVT")
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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

            modelBuilder.Entity("KeToan.eDm_NhomKH", b =>
            {
                b.Property<string>("MaNhomKH")
                    .ValueGeneratedOnAdd()
                    .HasMaxLength(16);

                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<decimal>("LoaiNhKH")
                    .HasColumnType("decimal(1,0)");

                b.Property<DateTime>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int>("NguoiCapNhat");

                b.Property<int>("NguoiTao");

                b.Property<string>("TenNhomKH")
                    .IsRequired()
                    .HasMaxLength(128);

                b.HasKey("MaNhomKH");

                b.HasAlternateKey("KeyID");


                b.HasAlternateKey("LoaiNhKH");

                b.ToTable("eDm_NhomKH");
            });

            modelBuilder.Entity("KeToan.eDm_nhomtk", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

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
                    .ValueGeneratedOnAdd();

                b.Property<string>("MaNhomTSCD")
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

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

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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

            modelBuilder.Entity("KeToan.eDm_nx", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("MaNX")
                    .HasMaxLength(16);

                b.Property<int>("NTKID");

                b.Property<DateTime>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int>("NguoiCapNhat");

                b.Property<int>("NguoiTao");

                b.Property<int>("TKID");

                b.Property<string>("TenNX")
                    .HasMaxLength(128);

                b.HasKey("KeyID");

                b.ToTable("eDm_nx");
            });

            modelBuilder.Entity("KeToan.eDm_nytcp", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("MaNhomYTCPID")
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

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

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

                b.Property<string>("MaLoaiCC")
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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

            modelBuilder.Entity("KeToan.eDm_Post", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("MaCT")
                    .HasMaxLength(3);

                b.Property<string>("MaPost")
                    .HasMaxLength(8);

                b.Property<string>("TenPost")
                    .HasMaxLength(48);

                b.HasKey("KeyID");

                b.ToTable("eDm_Post");
            });

            modelBuilder.Entity("KeToan.eDm_px", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<int>("ChiNhanhID");

                b.Property<bool>("ChonBPHT");

                b.Property<string>("MaPX")
                    .HasMaxLength(20);

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int?>("NguoiCapNhat");

                b.Property<int>("NguoiTao");

                b.Property<int>("PhongBanID");

                b.Property<int?>("TKCPSXDD");

                b.Property<string>("TenPX")
                    .HasMaxLength(128);

                b.HasKey("KeyID");

                b.ToTable("eDm_px");
            });

            modelBuilder.Entity("KeToan.eDm_tgtscd", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<decimal>("LoaiTG")
                    .HasColumnType("decimal(1,0)");

                b.Property<string>("MaTGTSCD")
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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

            modelBuilder.Entity("KeToan.eDm_thck", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("GhiChu")
                    .HasMaxLength(2000);

                b.Property<decimal>("HanTT")
                    .HasColumnType("decimal(3,0)");

                b.Property<string>("MaTHCK")
                    .HasMaxLength(16);

                b.Property<DateTime>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int>("NguoiCapNhat");

                b.Property<int>("NguoiTao");

                b.Property<decimal>("THCK")
                    .HasColumnType("decimal(3,0)");

                b.Property<string>("TenTHCK")
                    .HasMaxLength(128);

                b.Property<decimal>("TyLe")
                    .HasColumnType("decimal(6,2)");

                b.HasKey("KeyID");

                b.ToTable("eDm_thck");
            });

            modelBuilder.Entity("KeToan.eDm_tk", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<int>("BacTK");

                b.Property<int>("NTKID");

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

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

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

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
                    .ValueGeneratedOnAdd();

                b.Property<int>("ChiNhanhID");

                b.Property<int>("DVTID");

                b.Property<decimal?>("GiaTon")
                    .HasColumnType("decimal(1,0)");

                b.Property<string>("MaVTHH")
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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

            modelBuilder.Entity("KeToan.eDm_vv", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("MaVV")
                    .HasMaxLength(16);

                b.HasKey("KeyID");

                b.ToTable("eDm_vv");
            });

            modelBuilder.Entity("KeToan.eDm_ytcp", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

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

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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

            modelBuilder.Entity("KeToan.eHD_bh", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<int>("ChiNhanhID");

                b.Property<int>("HD_PTID");

                b.Property<int>("KhachHangID");

                b.Property<string>("KyHieuHD")
                    .HasMaxLength(20);

                b.Property<string>("MST")
                    .HasMaxLength(100);

                b.Property<int>("MaSoHD");

                b.Property<DateTime>("NgayCapNhat");

                b.Property<DateTime>("NgayHD");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int>("NguoiCapNhat");

                b.Property<string>("NguoiMuaHang")
                    .HasMaxLength(128);

                b.Property<int>("NguoiTao");

                b.Property<string>("PTTT")
                    .HasMaxLength(20);

                b.Property<string>("SoHD")
                    .HasMaxLength(20);

                b.Property<string>("TKNH")
                    .HasMaxLength(50);

                b.Property<string>("TenKH")
                    .HasMaxLength(128);

                b.Property<decimal>("TongThue")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongThueXK")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongTienChietKhau")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongTienHang")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongTienThanhToan")
                    .HasColumnType("decimal(18,4)");

                b.HasKey("KeyID");

                b.ToTable("eHD_BH");
            });

            modelBuilder.Entity("KeToan.eHD_ctbh", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<int>("DVTChinh");

                b.Property<int>("DVTID");

                b.Property<string>("DienGiai")
                    .HasMaxLength(250);

                b.Property<decimal>("DonGiaQD")
                    .HasColumnType("decimal(20,6)");

                b.Property<decimal>("DonGiaST")
                    .HasColumnType("decimal(20,6)");

                b.Property<decimal>("DonGiaVon")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("FOB");

                b.Property<DateTime>("HanDung");

                b.Property<bool>("HangKM");

                b.Property<int>("HoaDonID");

                b.Property<string>("SoLo")
                    .HasMaxLength(50);

                b.Property<decimal>("SoLuong")
                    .HasColumnType("decimal(18,2)");

                b.Property<int>("TKCK");

                b.Property<int>("TKCo");

                b.Property<int>("TKNo");

                b.Property<int>("TKThueGTGT");

                b.Property<int>("TKThueXK");

                b.Property<decimal>("ThanhTien")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("ThanhTienQD")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("ThueXK")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TiLeCK")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TienCK")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TienCKQD")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TienThueXKQD")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TienVAT")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TienVATQD")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("VAT")
                    .HasColumnType("decimal(18,4)");

                b.Property<int>("VTHHID");

                b.HasKey("KeyID");

                b.ToTable("eHD_CTBH");
            });

            modelBuilder.Entity("KeToan.eHD_pt", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<int>("AccID");

                b.Property<int>("ChiNhanhID");

                b.Property<string>("DiaChi")
                    .HasMaxLength(250);

                b.Property<string>("DienGiai")
                    .HasMaxLength(250);

                b.Property<int>("GhiSo");

                b.Property<string>("KemTheo")
                    .HasMaxLength(250);

                b.Property<int>("KhachHangID");

                b.Property<int>("LoaiCT");

                b.Property<string>("MST")
                    .HasMaxLength(100);

                b.Property<DateTime>("NgayCT");

                b.Property<DateTime>("NgayCapNhat");

                b.Property<DateTime>("NgayHT");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int>("NguoiCapNhat");

                b.Property<string>("NguoiLienHe")
                    .HasMaxLength(128);

                b.Property<int>("NguoiTao");

                b.Property<int>("PTTT");

                b.Property<string>("SoPhieuThu")
                    .HasMaxLength(20);

                b.Property<string>("TenKH")
                    .HasMaxLength(128);

                b.Property<decimal>("TongThue")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongThueXK")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongTienChietKhau")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongTienHang")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongTienThanhToan")
                    .HasColumnType("decimal(18,4)");

                b.HasKey("KeyID");

                b.ToTable("eHD_pt");
            });

            modelBuilder.Entity("KeToan.eHD_TH", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<int>("AccID");

                b.Property<bool>("ConNo");

                b.Property<string>("DiaChiNN")
                    .HasMaxLength(250);

                b.Property<string>("DienGiai")
                    .HasMaxLength(250);

                b.Property<int>("GhiSo");

                b.Property<int>("KhachHangID");

                b.Property<string>("KyHieuHD")
                    .HasMaxLength(50);

                b.Property<bool>("LaHangNK");

                b.Property<int>("LoaiCT");

                b.Property<string>("MST")
                    .HasMaxLength(50);

                b.Property<int>("MaSoHD");

                b.Property<DateTime>("NgayCT");

                b.Property<DateTime>("NgayCapNhat");

                b.Property<DateTime>("NgayHD");

                b.Property<DateTime>("NgayHT");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int>("NguoiCapNhat");

                b.Property<int>("NguoiTao");

                b.Property<int>("NguyenTeID");

                b.Property<bool>("NhanKem");

                b.Property<string>("SoCTSoQT")
                    .HasMaxLength(250);

                b.Property<string>("SoCTSoTC")
                    .HasMaxLength(50);

                b.Property<string>("SoHD")
                    .HasMaxLength(250);

                b.Property<string>("TenKH");

                b.Property<decimal>("ThanhTienCT")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("ThanhTienCTQD")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TienVAT")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TienVATQD")
                    .HasColumnType("decimal(18,4)");

                b.Property<int>("TraHangID");

                b.Property<bool>("TrangThaiSoQuanTri");

                b.Property<bool>("TrangThaiSoTaiChinh");

                b.Property<decimal>("TyGia")
                    .HasColumnType("decimal(18,4)");

                b.HasKey("KeyID");

                b.ToTable("eHD_TH");
            });

            modelBuilder.Entity("KeToan.eKhachhang", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

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

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int?>("NguoiCapNhat");

                b.Property<int>("NguoiTao");

                b.Property<int>("TK");

                b.Property<string>("TKNganHang")
                    .HasMaxLength(20)
                    .IsUnicode(false);

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

            modelBuilder.Entity("KeToan.ePhanQuyen", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("TenQuyen")
                    .HasMaxLength(128);

                b.Property<int?>("eQuyenKeyID");

                b.HasKey("KeyID");

                b.HasIndex("eQuyenKeyID");

                b.ToTable("ePhanQuyen");
            });

            modelBuilder.Entity("KeToan.ePhieuNhap", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<int>("AccID");

                b.Property<string>("KemTheo")
                    .HasMaxLength(250);

                b.Property<int>("KhachHangID");

                b.Property<string>("LyDo")
                    .HasMaxLength(128);

                b.Property<DateTime>("NgayCT");

                b.Property<DateTime>("NgayCapNhat");

                b.Property<DateTime>("NgayGhiSoKho");

                b.Property<DateTime>("NgayHT");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int>("NguoiCapNhat");

                b.Property<string>("NguoiGiaoHang")
                    .HasMaxLength(128);

                b.Property<int>("NguoiTao");

                b.Property<int>("NguyenTeID");

                b.Property<int>("PTTinhDonGia");

                b.Property<string>("SoPhieuNhap")
                    .HasMaxLength(20);

                b.Property<string>("SoQuanTri")
                    .HasMaxLength(20);

                b.Property<string>("SoTaiChinh")
                    .HasMaxLength(20);

                b.Property<string>("TenKH")
                    .HasMaxLength(128);

                b.Property<decimal>("TongTienSoQuanTri")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongTienSoTaiChinh")
                    .HasColumnType("decimal(18,4)");

                b.Property<int>("TraHangID");

                b.Property<bool>("TrangThaiGhiSoThuKhoQT");

                b.Property<bool>("TrangThaiGhiSoThuKhoTC");

                b.Property<bool>("TrangThaiSoQuanTri");

                b.Property<bool>("TrangThaiSoTaiChinh");

                b.HasKey("KeyID");

                b.ToTable("ePhieuNhap");
            });

            modelBuilder.Entity("KeToan.ePhieuXuat", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<int>("AccID");

                b.Property<int>("ChiNhanhID");

                b.Property<bool>("DaXuatHD");

                b.Property<string>("DiaChi")
                    .HasMaxLength(250);

                b.Property<string>("DienGiai")
                    .HasMaxLength(250);

                b.Property<int>("HoaDonID");

                b.Property<string>("KemTheo")
                    .HasMaxLength(250);

                b.Property<int>("KhachHangID");

                b.Property<bool>("LapKemHD");

                b.Property<string>("LyDo")
                    .HasMaxLength(128);

                b.Property<DateTime>("NgayCT");

                b.Property<DateTime>("NgayCapNhat");

                b.Property<DateTime>("NgayHT");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int>("NguoiCapNhat");

                b.Property<string>("NguoiNhan")
                    .HasMaxLength(128);

                b.Property<int>("NguoiTao");

                b.Property<string>("NguoiThanhToan");

                b.Property<int>("NguyenTeID");

                b.Property<string>("SoPhieuXuat")
                    .HasMaxLength(20);

                b.Property<string>("TenKH")
                    .HasMaxLength(128);

                b.Property<decimal>("TongThue")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongThueXK")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongTienChietKhau")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongTienHang")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongTienThanhToan")
                    .HasColumnType("decimal(18,4)");

                b.Property<int>("XuatHang");

                b.HasKey("KeyID");

                b.ToTable("ePhieuXuat");
            });

            modelBuilder.Entity("KeToan.ePXBPHTXREF", b =>
            {
                b.Property<int>("BPID");

                b.Property<int>("KeyID");

                b.HasKey("BPID", "KeyID");

                b.ToTable("ePXBPHTXREF");
            });

            modelBuilder.Entity("KeToan.eQuyen", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<int>("ChucNangID");

                b.Property<int>("PhanQuyenID");

                b.HasKey("KeyID");

                b.HasIndex("ChucNangID");

                b.ToTable("eQuyen");
            });

            modelBuilder.Entity("KeToan.eTaiKhoan", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("AccCode")
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property<string>("AccName")
                    .IsRequired()
                    .HasMaxLength(128);

                b.Property<bool>("AnHien")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValue(true);

                b.Property<int>("ChiNhanhID");

                b.Property<Guid>("NVID");

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int?>("NguoiCapNhat");

                b.Property<int>("NguoiTao");

                b.Property<string>("Password");

                b.Property<int?>("PhanQuyenID");

                b.HasKey("KeyID");

                b.HasIndex("AccCode")
                    .IsUnique();

                b.HasIndex("AccName")
                    .IsUnique();

                b.ToTable("eTaiKhoan");
            });

            modelBuilder.Entity("KeToan.eTraHang", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<int>("AccID");

                b.Property<int>("ChiNhanhID");

                b.Property<string>("DiaChi")
                    .HasMaxLength(250);

                b.Property<string>("DienGiai")
                    .HasMaxLength(250);

                b.Property<string>("KemTheo")
                    .HasMaxLength(250);

                b.Property<int>("KhachHangID");

                b.Property<bool>("KiemPhieuNK");

                b.Property<int>("LoaiCT");

                b.Property<string>("MST")
                    .HasMaxLength(100);

                b.Property<DateTime>("NgayCT");

                b.Property<DateTime>("NgayCapNhat");

                b.Property<DateTime>("NgayHT");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

                b.Property<int>("NguoiCapNhat");

                b.Property<string>("NguoiLienHe")
                    .HasMaxLength(128);

                b.Property<int>("NguoiTao");

                b.Property<int>("PTID");

                b.Property<int>("PTTT");

                b.Property<string>("SoPhieuThu")
                    .HasMaxLength(20);

                b.Property<string>("TenKH")
                    .HasMaxLength(128);

                b.Property<decimal>("TongThue")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongThueXK")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongTienChietKhau")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongTienHang")
                    .HasColumnType("decimal(18,4)");

                b.Property<decimal>("TongTienThanhToan")
                    .HasColumnType("decimal(18,4)");

                b.HasKey("KeyID");

                b.ToTable("eTraHang");
            });

            modelBuilder.Entity("KeToan.eTU_Ph46", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("CTID")
                    .HasMaxLength(3);

                b.Property<int>("ChiNhanhID");

                b.Property<string>("DienGiaiCT")
                    .HasMaxLength(48);

                b.Property<string>("MaGD")
                    .HasMaxLength(1);

                b.Property<string>("MaNX")
                    .HasMaxLength(3);

                b.Property<DateTime>("NgayCT");

                b.Property<DateTime>("NgayLapCT");

                b.Property<string>("STT_REC")
                    .HasMaxLength(11);

                b.Property<string>("SoCT")
                    .HasMaxLength(12);

                b.Property<int>("TKID");

                b.HasKey("KeyID");

                b.ToTable("eTU_Ph46");
            });

            modelBuilder.Entity("KeToan.xAppctl", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("GiaTri");

                b.Property<DateTime?>("NgayCapNhat");

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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
                    .ValueGeneratedOnAdd();

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

                b.Property<DateTime>("NgayTao")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");

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

                b.ToTable("xCdtk");
            });

            modelBuilder.Entity("KeToan.xChucNang", b =>
            {
                b.Property<int>("KeyID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("ControllerName")
                    .HasMaxLength(250);

                b.Property<string>("Methods")
                    .HasMaxLength(250);

                b.Property<string>("Route")
                    .HasMaxLength(250);

                b.HasKey("KeyID");

                b.ToTable("xChucNang");
            });

            modelBuilder.Entity("KeToan.ePhanQuyen", b =>
            {
                b.HasOne("KeToan.eQuyen", "eQuyen")
                    .WithMany()
                    .HasForeignKey("eQuyenKeyID");
            });

            modelBuilder.Entity("KeToan.eQuyen", b =>
            {
                b.HasOne("KeToan.xChucNang", "xChucNang")
                    .WithMany("eQuyen")
                    .HasForeignKey("ChucNangID")
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
