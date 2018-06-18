using API.Model.Extenstion;
using KeToan;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public partial class zModel
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region xAppctl
            modelBuilder.Entity<xAppctl>().HasKey(c => c.KeyID);
            modelBuilder.Entity<xAppctl>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<xAppctl>().Property(e => e.Ten).IsUnicode(false);
            modelBuilder.Entity<xAppctl>().HasIndex(e => e.Ten).IsUnique();
            modelBuilder.Entity<xAppctl>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<xAppctl>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<xAppctl>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eCdvt
            modelBuilder.Entity<eCdvt>().HasKey(c => c.KeyID);
            modelBuilder.Entity<eCdvt>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eCdvt>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eCdvt>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eCdvt>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region Dm_CHUCDANH
            modelBuilder.Entity<eDm_chucdanh>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_chucdanh>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_chucdanh>().Property(e => e.MaChucDanh).IsRequired();
            modelBuilder.Entity<eDm_chucdanh>().Property(e => e.MaChucDanh).HasMaxLength(20);
            modelBuilder.Entity<eDm_chucdanh>().Property(e => e.MaChucDanh).IsUnicode(false);
            modelBuilder.Entity<eDm_chucdanh>().HasIndex(e => e.MaChucDanh).IsUnique();
            modelBuilder.Entity<eDm_chucdanh>().Property(e => e.DienGiai).IsRequired();
            modelBuilder.Entity<eDm_chucdanh>().Property(e => e.DienGiai).HasMaxLength(250);
            modelBuilder.Entity<eDm_chucdanh>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_chucdanh>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_chucdanh>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region dm_CHINHANH
            modelBuilder.Entity<eDm_chinhanh>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_chinhanh>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_chinhanh>().Property(e => e.MaCN).IsUnicode(false);
            modelBuilder.Entity<eDm_chinhanh>().Property(e => e.MaCN).IsRequired();
            modelBuilder.Entity<eDm_chinhanh>().Property(e => e.MaCN).HasMaxLength(20);
            modelBuilder.Entity<eDm_chinhanh>().HasIndex(e => e.MaCN).IsUnique();
            modelBuilder.Entity<eDm_chinhanh>().Property(e => e.DienThoai).IsUnicode(false);
            modelBuilder.Entity<eDm_chinhanh>().Property(e => e.DienThoai).IsRequired();
            modelBuilder.Entity<eDm_chinhanh>().Property(e => e.DiaChi).IsRequired();
            modelBuilder.Entity<eDm_chinhanh>().Property(e => e.DiaChi).HasMaxLength(250);
            #endregion

            #region DM_ChucVu
            modelBuilder.Entity<eDm_chucvu>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_chucvu>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_chucvu>().Property(e => e.MaChucVu).IsUnicode(false);
            modelBuilder.Entity<eDm_chucvu>().Property(e => e.MaChucVu).IsRequired();
            modelBuilder.Entity<eDm_chucvu>().Property(e => e.MaChucVu).HasMaxLength(20);
            modelBuilder.Entity<eDm_chucvu>().HasIndex(e => e.MaChucVu).IsUnique();
            modelBuilder.Entity<eDm_chucvu>().Property(e => e.DienGiai).IsRequired();
            modelBuilder.Entity<eDm_chucvu>().Property(e => e.DienGiai).HasMaxLength(250);
            modelBuilder.Entity<eDm_chucvu>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_chucvu>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_chucvu>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region Dm_dvt
            modelBuilder.Entity<eDm_dvt>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_dvt>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_dvt>().Property(e => e.MaDVT).IsUnicode(false);
            modelBuilder.Entity<eDm_dvt>().Property(e => e.MaDVT).IsRequired();
            modelBuilder.Entity<eDm_dvt>().Property(e => e.MaDVT).HasMaxLength(20);
            modelBuilder.Entity<eDm_dvt>().HasIndex(e => e.MaDVT).IsUnique();
            modelBuilder.Entity<eDm_dvt>().Property(e => e.TenDVT).IsRequired();
            modelBuilder.Entity<eDm_dvt>().Property(e => e.TenDVT).HasMaxLength(250);
            #endregion

            #region Dm_httl
            modelBuilder.Entity<eDm_httl>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_httl>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_httl>().Property(e => e.DienGiai).IsRequired();
            modelBuilder.Entity<eDm_httl>().Property(e => e.DienGiai).HasMaxLength(250);
            modelBuilder.Entity<eDm_httl>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_httl>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_httl>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region Dm_nhomtscd
            modelBuilder.Entity<eDm_nhomtscd>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_nhomtscd>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_nhomtscd>().Property(e => e.MaNhomTSCD).IsUnicode(false);
            modelBuilder.Entity<eDm_nhomtscd>().Property(e => e.MaNhomTSCD).IsRequired();
            modelBuilder.Entity<eDm_nhomtscd>().Property(e => e.MaNhomTSCD).HasMaxLength(20);
            modelBuilder.Entity<eDm_nhomtscd>().HasIndex(e => e.MaNhomTSCD).IsUnique();
            modelBuilder.Entity<eDm_nhomtscd>().Property(e => e.TenNhom).IsRequired();
            modelBuilder.Entity<eDm_nhomtscd>().Property(e => e.TenNhom).HasMaxLength(250);
            modelBuilder.Entity<eDm_nhomtscd>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_nhomtscd>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_nhomtscd>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region Dm_loaitscd
            modelBuilder.Entity<eDm_loaitscd>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_loaitscd>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_loaitscd>().Property(e => e.MaLoaiTSCD).IsUnicode(false);
            modelBuilder.Entity<eDm_loaitscd>().Property(e => e.MaLoaiTSCD).IsRequired();
            modelBuilder.Entity<eDm_loaitscd>().Property(e => e.MaLoaiTSCD).HasMaxLength(20);
            modelBuilder.Entity<eDm_loaitscd>().HasIndex(e => e.MaLoaiTSCD).IsUnique();
            modelBuilder.Entity<eDm_loaitscd>().Property(e => e.TenLoai).IsRequired();
            modelBuilder.Entity<eDm_loaitscd>().Property(e => e.TenLoai).HasMaxLength(250);
            modelBuilder.Entity<eDm_loaitscd>().HasIndex(e => e.TenLoai).IsUnique();
            modelBuilder.Entity<eDm_loaitscd>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_loaitscd>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_loaitscd>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region  eDm_nganhang
            modelBuilder.Entity<eDm_nganhang>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_nganhang>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_nganhang>().Property(e => e.TKNganHang).IsUnicode(false);
            modelBuilder.Entity<eDm_nganhang>().Property(e => e.TKNganHang).IsRequired();
            modelBuilder.Entity<eDm_nganhang>().Property(e => e.TKNganHang).HasMaxLength(50);
            modelBuilder.Entity<eDm_nganhang>().HasIndex(e => e.TKNganHang).IsUnique();
            modelBuilder.Entity<eDm_nganhang>().Property(e => e.Email).HasMaxLength(250);
            modelBuilder.Entity<eDm_nganhang>().Property(e => e.TenNH).HasMaxLength(250);
            modelBuilder.Entity<eDm_nganhang>().Property(e => e.TenNH).IsRequired();
            modelBuilder.Entity<eDm_nganhang>().Property(e => e.TenNH).HasMaxLength(250);
            modelBuilder.Entity<eDm_nganhang>().Property(e => e.TKNganHang).IsUnicode(false);
            modelBuilder.Entity<eDm_nganhang>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_nganhang>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_nganhang>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_nhomhhvt
            modelBuilder.Entity<eDm_nhomhhvt>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_nhomhhvt>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_nhomhhvt>().Property(e => e.MaNhomHHVT).IsUnicode(false);
            modelBuilder.Entity<eDm_nhomhhvt>().Property(e => e.MaNhomHHVT).IsRequired();
            modelBuilder.Entity<eDm_nhomhhvt>().Property(e => e.MaNhomHHVT).HasMaxLength(20);
            modelBuilder.Entity<eDm_nhomhhvt>().HasIndex(e => e.MaNhomHHVT).IsUnique();
            modelBuilder.Entity<eDm_nhomhhvt>().Property(e => e.TenNhom).IsRequired();
            modelBuilder.Entity<eDm_nhomhhvt>().Property(e => e.TenNhom).HasMaxLength(250);
            modelBuilder.Entity<eDm_nhomhhvt>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_nhomhhvt>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_nhomhhvt>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_nt
            modelBuilder.Entity<eDm_nt>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_nt>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_nt>().Property(e => e.MaNT).IsUnicode(false);
            modelBuilder.Entity<eDm_nt>().Property(e => e.MaNT).IsRequired();
            modelBuilder.Entity<eDm_nt>().Property(e => e.MaNT).HasMaxLength(20);
            modelBuilder.Entity<eDm_nt>().HasIndex(e => e.MaNT).IsUnique();
            modelBuilder.Entity<eDm_nt>().Property(e => e.MaNT).HasMaxLength(20);
            modelBuilder.Entity<eDm_nt>().Property(e => e.TenNT).IsRequired();
            modelBuilder.Entity<eDm_nt>().Property(e => e.TenNT).HasMaxLength(250);
            #endregion

            #region dm_nv
            modelBuilder.Entity<eDm_nv>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_nv>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_nv>().Property(e => e.MaNV).IsUnicode(false);
            modelBuilder.Entity<eDm_nv>().Property(e => e.MaNV).IsRequired();
            modelBuilder.Entity<eDm_nv>().Property(e => e.MaNV).HasMaxLength(50);
            modelBuilder.Entity<eDm_nv>().HasIndex(e => e.MaNV).IsUnique();
            modelBuilder.Entity<eDm_nv>().Property(e => e.HoTen).IsRequired();
            modelBuilder.Entity<eDm_nv>().Property(e => e.HoTen).HasMaxLength(250);
            modelBuilder.Entity<eDm_nv>().Property(e => e.NgaySinh).HasColumnType("date");
            modelBuilder.Entity<eDm_nv>().Property(e => e.NgayCap).HasColumnType("date");
            modelBuilder.Entity<eDm_nv>().Property(e => e.QueQuan).HasMaxLength(250);
            modelBuilder.Entity<eDm_nv>().Property(e => e.Email).HasMaxLength(100);
            modelBuilder.Entity<eDm_nv>().Property(e => e.DiaChiThuongTru).HasMaxLength(250);
            modelBuilder.Entity<eDm_nv>().Property(e => e.MaSoThue).HasMaxLength(20);
            modelBuilder.Entity<eDm_nv>().Property(e => e.LuongCoBan).HasMaxLength(10);
            modelBuilder.Entity<eDm_nv>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_nv>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_nv>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region Dm_nguonvon
            modelBuilder.Entity<eDm_nguonvon>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_nguonvon>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_nguonvon>().Property(e => e.MaNguonVon).IsUnicode(false);
            modelBuilder.Entity<eDm_nguonvon>().Property(e => e.MaNguonVon).IsRequired();
            modelBuilder.Entity<eDm_nguonvon>().Property(e => e.MaNguonVon).HasMaxLength(20);
            modelBuilder.Entity<eDm_nguonvon>().HasIndex(e => e.MaNguonVon).IsUnique();
            modelBuilder.Entity<eDm_nguonvon>().Property(e => e.TenNguonVon).IsRequired();
            modelBuilder.Entity<eDm_nguonvon>().Property(e => e.TenNguonVon).HasMaxLength(250);
            modelBuilder.Entity<eDm_nguonvon>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_nguonvon>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_nguonvon>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region Dm_tt
            modelBuilder.Entity<eDm_tt>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_tt>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_tt>().Property(e => e.MaTinhThanh).HasMaxLength(20);
            modelBuilder.Entity<eDm_tt>().Property(e => e.DienGiai).HasMaxLength(250);
            modelBuilder.Entity<eDm_tt>().HasIndex(e => e.DienGiai).IsUnique();
            #endregion

            #region Dm_vthh
            modelBuilder.Entity<eDm_vthh>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_vthh>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_vthh>().Property(e => e.MaVTHH).IsUnicode(false);
            modelBuilder.Entity<eDm_vthh>().Property(e => e.MaVTHH).IsRequired();
            modelBuilder.Entity<eDm_vthh>().Property(e => e.MaVTHH).HasMaxLength(20);
            modelBuilder.Entity<eDm_vthh>().HasIndex(e => e.MaVTHH).IsUnique();
            modelBuilder.Entity<eDm_vthh>().Property(e => e.TenVTHH).IsRequired();
            modelBuilder.Entity<eDm_vthh>().Property(e => e.TenVTHH).HasMaxLength(250);
            modelBuilder.Entity<eDm_vthh>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_vthh>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_vthh>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_NhomKH
            modelBuilder.Entity<eDm_NhomKH>().HasKey(e => new { e.LoaiNhKH, e.MaNhomKH });//2 khóa chính
            modelBuilder.Entity<eDm_NhomKH>().Property(e => e.LoaiNhKH).HasPrecision(1, 0);
            modelBuilder.Entity<eDm_NhomKH>().Property(e => e.MaNhomKH).HasMaxLength(16);
            modelBuilder.Entity<eDm_NhomKH>().Property(e => e.TenNhomKH).IsRequired();
            modelBuilder.Entity<eDm_NhomKH>().Property(e => e.TenNhomKH).HasMaxLength(128);
            modelBuilder.Entity<eDm_NhomKH>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_NhomKH>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_NhomKH>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eKhachhang
            modelBuilder.Entity<eKhachhang>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eKhachhang>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eKhachhang>().Property(e => e.MaKH).IsUnicode(false);
            modelBuilder.Entity<eKhachhang>().Property(e => e.MaKH).IsRequired();
            modelBuilder.Entity<eKhachhang>().Property(e => e.MaKH).HasMaxLength(20);
            modelBuilder.Entity<eKhachhang>().HasIndex(e => e.MaKH).IsUnique();
            modelBuilder.Entity<eKhachhang>().Property(e => e.TenKH).IsRequired();
            modelBuilder.Entity<eKhachhang>().Property(e => e.TenKH).HasMaxLength(250);
            modelBuilder.Entity<eKhachhang>().Property(e => e.DiaChi).HasMaxLength(250);
            modelBuilder.Entity<eKhachhang>().Property(e => e.Fax).HasMaxLength(20);
            modelBuilder.Entity<eKhachhang>().Property(e => e.TKNganHang).HasMaxLength(20);
            modelBuilder.Entity<eKhachhang>().Property(e => e.TKNganHang).IsUnicode(false);
            modelBuilder.Entity<eKhachhang>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eKhachhang>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eKhachhang>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_cty
            modelBuilder.Entity<eDm_cty>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_cty>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_cty>().Property(e => e.MaCTy).IsUnicode(false);
            modelBuilder.Entity<eDm_cty>().Property(e => e.MaCTy).IsRequired();
            modelBuilder.Entity<eDm_cty>().Property(e => e.MaCTy).HasMaxLength(20);
            modelBuilder.Entity<eDm_cty>().HasIndex(e => e.MaCTy).IsUnique();
            modelBuilder.Entity<eDm_cty>().Property(e => e.TenCTy).IsRequired();
            modelBuilder.Entity<eDm_cty>().Property(e => e.TenCTy).HasMaxLength(250);
            #endregion

            #region xCdtk
            modelBuilder.Entity<xCdtk>().HasKey(e => e.KeyID);
            modelBuilder.Entity<xCdtk>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<xCdtk>().Property(e => e.TK).IsUnicode(false);
            modelBuilder.Entity<xCdtk>().HasIndex(e => e.TK).IsUnique();
            modelBuilder.Entity<xCdtk>().Property(e => e.TK).IsRequired();
            modelBuilder.Entity<xCdtk>().Property(e => e.TK).HasMaxLength(16);
            modelBuilder.Entity<xCdtk>().Property(e => e.DuNo).HasPrecision(16, 2);
            modelBuilder.Entity<xCdtk>().Property(e => e.DuCo).HasPrecision(16, 2);
            modelBuilder.Entity<xCdtk>().Property(e => e.DuNo1).HasPrecision(16, 2);
            modelBuilder.Entity<xCdtk>().Property(e => e.DuCo1).HasPrecision(16, 2);
            modelBuilder.Entity<xCdtk>().Property(e => e.DuNoNT).HasPrecision(16, 2);
            modelBuilder.Entity<xCdtk>().Property(e => e.DuCoNT).HasPrecision(16, 2);
            modelBuilder.Entity<xCdtk>().Property(e => e.DuNoNT1).HasPrecision(16, 2);
            modelBuilder.Entity<xCdtk>().Property(e => e.DuCoNT1).HasPrecision(16, 2);
            modelBuilder.Entity<xCdtk>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<xCdtk>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<xCdtk>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_phongban
            modelBuilder.Entity<eDm_phongban>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_phongban>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_phongban>().Property(e => e.MaPB).IsUnicode(false);
            modelBuilder.Entity<eDm_phongban>().Property(e => e.MaPB).IsRequired();
            modelBuilder.Entity<eDm_phongban>().Property(e => e.MaPB).HasMaxLength(20);
            modelBuilder.Entity<eDm_phongban>().HasIndex(e => e.MaPB).IsUnique();
            modelBuilder.Entity<eDm_phongban>().Property(e => e.DienGiai).IsRequired();
            modelBuilder.Entity<eDm_phongban>().Property(e => e.DienGiai).HasMaxLength(250);
            modelBuilder.Entity<eDm_phongban>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_phongban>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_phongban>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_tgtscd
            modelBuilder.Entity<eDm_tgtscd>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_tgtscd>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_tgtscd>().Property(e => e.MaTGTSCD).IsUnicode(false);
            modelBuilder.Entity<eDm_tgtscd>().Property(e => e.MaTGTSCD).IsRequired();
            modelBuilder.Entity<eDm_tgtscd>().Property(e => e.MaTGTSCD).HasMaxLength(20);
            modelBuilder.Entity<eDm_tgtscd>().HasIndex(e => e.MaTGTSCD).IsUnique();
            modelBuilder.Entity<eDm_tgtscd>().Property(e => e.TenTGTSCD).IsRequired();
            modelBuilder.Entity<eDm_tgtscd>().Property(e => e.TenTGTSCD).HasMaxLength(250);
            modelBuilder.Entity<eDm_tgtscd>().Property(e => e.LoaiTG).HasPrecision(1, 0);
            modelBuilder.Entity<eDm_tgtscd>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_tgtscd>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_tgtscd>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_tk
            modelBuilder.Entity<eDm_tk>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_tk>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_tk>().Property(e => e.TK).IsUnicode(false);
            modelBuilder.Entity<eDm_tk>().Property(e => e.TK).IsRequired();
            modelBuilder.Entity<eDm_tk>().Property(e => e.TK).HasMaxLength(16);
            modelBuilder.Entity<eDm_tk>().HasIndex(e => e.TK).IsUnique();
            modelBuilder.Entity<eDm_tk>().Property(e => e.TenTK).IsRequired();
            modelBuilder.Entity<eDm_tk>().Property(e => e.TenTK).HasMaxLength(250);
            modelBuilder.Entity<eDm_tk>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_tk>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_tk>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_lytcp
            modelBuilder.Entity<eDm_lytcp>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_lytcp>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_lytcp>().Property(e => e.MaLoaiYTCP).IsUnicode(false);
            modelBuilder.Entity<eDm_lytcp>().Property(e => e.MaLoaiYTCP).IsRequired();
            modelBuilder.Entity<eDm_lytcp>().Property(e => e.MaLoaiYTCP).HasMaxLength(20);
            modelBuilder.Entity<eDm_lytcp>().HasIndex(e => e.MaLoaiYTCP).IsUnique();
            modelBuilder.Entity<eDm_lytcp>().Property(e => e.TenLoaiYTCP).IsRequired();
            modelBuilder.Entity<eDm_lytcp>().Property(e => e.TenLoaiYTCP).HasMaxLength(250);
            modelBuilder.Entity<eDm_lytcp>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_lytcp>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_lytcp>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_nytcp
            modelBuilder.Entity<eDm_nytcp>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_nytcp>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_nytcp>().Property(e => e.MaNhomYTCPID).IsUnicode(false);
            modelBuilder.Entity<eDm_nytcp>().Property(e => e.MaNhomYTCPID).IsRequired();
            modelBuilder.Entity<eDm_nytcp>().Property(e => e.MaNhomYTCPID).HasMaxLength(20);
            modelBuilder.Entity<eDm_nytcp>().HasIndex(e => e.MaNhomYTCPID).IsUnique();
            modelBuilder.Entity<eDm_nytcp>().Property(e => e.TenNhomYTCPID).IsRequired();
            modelBuilder.Entity<eDm_nytcp>().Property(e => e.TenNhomYTCPID).HasMaxLength(250);
            modelBuilder.Entity<eDm_nytcp>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_nytcp>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_nytcp>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_ytcp
            modelBuilder.Entity<eDm_ytcp>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_ytcp>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_ytcp>().Property(e => e.MaYTCP).IsUnicode(false);
            modelBuilder.Entity<eDm_ytcp>().Property(e => e.MaYTCP).IsRequired();
            modelBuilder.Entity<eDm_ytcp>().Property(e => e.MaYTCP).HasMaxLength(20);
            modelBuilder.Entity<eDm_ytcp>().HasIndex(e => e.MaYTCP).IsUnique();
            modelBuilder.Entity<eDm_ytcp>().Property(e => e.TenYTCP).IsRequired();
            modelBuilder.Entity<eDm_ytcp>().Property(e => e.TenYTCP).HasMaxLength(250);
            modelBuilder.Entity<eDm_ytcp>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_ytcp>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_ytcp>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_nhomtk        
            modelBuilder.Entity<eDm_nhomtk>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_nhomtk>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_nhomtk>().HasIndex(e => e.MaNTK).IsUnique();
            modelBuilder.Entity<eDm_nhomtk>().Property(e => e.MaNTK).IsUnicode(false);
            modelBuilder.Entity<eDm_nhomtk>().Property(e => e.MaNTK).HasMaxLength(16);
            #endregion

            #region eDm_bophan         
            modelBuilder.Entity<eDm_bophan>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_bophan>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_bophan>().Property(e => e.MaBP).IsUnicode(false);
            modelBuilder.Entity<eDm_bophan>().Property(e => e.MaBP).IsRequired();
            modelBuilder.Entity<eDm_bophan>().Property(e => e.MaBP).HasMaxLength(20);
            modelBuilder.Entity<eDm_bophan>().HasIndex(e => e.MaBP).IsUnique();
            modelBuilder.Entity<eDm_bophan>().Property(e => e.TenBP).IsRequired();
            modelBuilder.Entity<eDm_bophan>().Property(e => e.TenBP).HasMaxLength(250);
            #endregion

            #region eDm_pl_cc           
            modelBuilder.Entity<eDm_pl_cc>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_pl_cc>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_pl_cc>().Property(e => e.MaLoaiCC).IsUnicode(false);
            modelBuilder.Entity<eDm_pl_cc>().Property(e => e.MaLoaiCC).IsRequired();
            modelBuilder.Entity<eDm_pl_cc>().Property(e => e.MaLoaiCC).HasMaxLength(20);
            modelBuilder.Entity<eDm_pl_cc>().HasIndex(e => e.MaLoaiCC).IsUnique();
            modelBuilder.Entity<eDm_pl_cc>().Property(e => e.TenLoaiCC).IsRequired();
            modelBuilder.Entity<eDm_pl_cc>().Property(e => e.TenLoaiCC).HasMaxLength(250);
            modelBuilder.Entity<eDm_pl_cc>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_pl_cc>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_pl_cc>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_nhom_cc       
            modelBuilder.Entity<eDm_nhom_cc>().HasKey(c => c.KeyID);
            modelBuilder.Entity<eDm_nhom_cc>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_nhom_cc>().Property(e => e.MaNhomCC).IsUnicode(false);
            modelBuilder.Entity<eDm_nhom_cc>().HasIndex(e => e.MaNhomCC).IsUnique();
            modelBuilder.Entity<eDm_nhom_cc>().Property(e => e.LoaiNhomDC).HasPrecision(1, 0);
            modelBuilder.Entity<eDm_nhom_cc>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_nhom_cc>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_nhom_cc>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_cc          
            modelBuilder.Entity<eDm_cc>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_cc>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_cc>().Property(e => e.MaCC).IsUnicode(false);
            modelBuilder.Entity<eDm_cc>().Property(e => e.MaCC).IsRequired();
            modelBuilder.Entity<eDm_cc>().Property(e => e.MaCC).HasMaxLength(20);
            modelBuilder.Entity<eDm_cc>().HasIndex(e => e.MaCC).IsUnique();
            modelBuilder.Entity<eDm_cc>().Property(e => e.TenCC).IsRequired();
            modelBuilder.Entity<eDm_cc>().Property(e => e.TenCC).HasMaxLength(250);
            modelBuilder.Entity<eDm_cc>().Property(e => e.SoKyPB).HasPrecision(16, 2);
            modelBuilder.Entity<eDm_cc>().Property(e => e.GiaTriConLai).HasPrecision(16, 2);
            modelBuilder.Entity<eDm_cc>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_cc>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_cc>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_ts            
            modelBuilder.Entity<eDm_ts>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_ts>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_ts>().Property(e => e.MaTSCD).IsUnicode(false);
            modelBuilder.Entity<eDm_ts>().Property(e => e.MaTSCD).IsRequired();
            modelBuilder.Entity<eDm_ts>().Property(e => e.MaTSCD).HasMaxLength(20);
            modelBuilder.Entity<eDm_ts>().HasIndex(e => e.MaTSCD).IsUnique();
            modelBuilder.Entity<eDm_ts>().Property(e => e.TenTSCD).IsRequired();
            modelBuilder.Entity<eDm_ts>().Property(e => e.TenTSCD).HasMaxLength(250);
            modelBuilder.Entity<eDm_ts>().Property(e => e.NgayTang).HasColumnType("date");
            modelBuilder.Entity<eDm_ts>().Property(e => e.NgayKhauHao).HasColumnType("date");
            modelBuilder.Entity<eDm_ts>().Property(e => e.KieuKhauHao).HasPrecision(1, 0);
            modelBuilder.Entity<eDm_ts>().Property(e => e.SoKyKhauHao).HasPrecision(3, 0);
            modelBuilder.Entity<eDm_ts>().Property(e => e.GiaTriConLai).HasPrecision(16, 2);
            modelBuilder.Entity<eDm_ts>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_ts>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_ts>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eCdkh
            modelBuilder.Entity<eCdkh>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eCdkh>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eCdkh>().Property(e => e.KhachHangID).IsRequired();
            modelBuilder.Entity<eCdkh>().Property(e => e.DuNo).HasPrecision(16, 2);
            modelBuilder.Entity<eCdkh>().Property(e => e.DuCo).HasPrecision(16, 2);
            modelBuilder.Entity<eCdkh>().Property(e => e.DuNo1).HasPrecision(16, 2);
            modelBuilder.Entity<eCdkh>().Property(e => e.DuCo1).HasPrecision(16, 2);
            modelBuilder.Entity<eCdkh>().Property(e => e.DuNoNT).HasPrecision(16, 2);
            modelBuilder.Entity<eCdkh>().Property(e => e.DuCoNT).HasPrecision(16, 2);
            modelBuilder.Entity<eCdkh>().Property(e => e.DuNoNT1).HasPrecision(16, 2);
            modelBuilder.Entity<eCdkh>().Property(e => e.DuCoNT1).HasPrecision(16, 2);
            modelBuilder.Entity<eCdkh>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eCdkh>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eCdkh>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eCdnh
            modelBuilder.Entity<eCdnh>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eCdnh>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eCdnh>().Property(e => e.NganHangID).IsUnicode(false);
            modelBuilder.Entity<eCdnh>().Property(e => e.TKID).IsUnicode(false);
            modelBuilder.Entity<eCdnh>().Property(e => e.DuNo).HasPrecision(16, 2);
            modelBuilder.Entity<eCdnh>().Property(e => e.DuCo).HasPrecision(16, 2);
            modelBuilder.Entity<eCdnh>().Property(e => e.DuNo1).HasPrecision(16, 2);
            modelBuilder.Entity<eCdnh>().Property(e => e.DuCo1).HasPrecision(16, 2);
            modelBuilder.Entity<eCdnh>().Property(e => e.DuNoNT).HasPrecision(16, 2);
            modelBuilder.Entity<eCdnh>().Property(e => e.DuCoNT).HasPrecision(16, 2);
            modelBuilder.Entity<eCdnh>().Property(e => e.DuNoNT1).HasPrecision(16, 2);
            modelBuilder.Entity<eCdnh>().Property(e => e.DuCoNT1).HasPrecision(16, 2);
            modelBuilder.Entity<eCdnh>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eCdnh>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eCdnh>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_kho
            modelBuilder.Entity<eDm_kho>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_kho>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_kho>().Property(e => e.MaKho).IsUnicode(false);
            modelBuilder.Entity<eDm_kho>().Property(e => e.MaKho).IsRequired();
            modelBuilder.Entity<eDm_kho>().Property(e => e.MaKho).HasMaxLength(20);
            modelBuilder.Entity<eDm_kho>().HasIndex(e => e.MaKho).IsUnique();
            modelBuilder.Entity<eDm_kho>().Property(e => e.TenKho).IsRequired();
            modelBuilder.Entity<eDm_kho>().Property(e => e.TenKho).HasMaxLength(250);
            modelBuilder.Entity<eDm_kho>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_kho>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_kho>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eCt_ctts
            modelBuilder.Entity<eCt_ctts>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eCt_ctts>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eCt_ctts>().Property(e => e.SoLuong).HasPrecision(18, 2);
            modelBuilder.Entity<eCt_ctts>().Property(e => e.GiaTri).HasPrecision(16, 2);
            #endregion

            #region eCt_ts
            modelBuilder.Entity<eCt_ts>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eCt_ts>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eCt_ts>().Property(e => e.SoCT).HasMaxLength(20);
            modelBuilder.Entity<eCt_ts>().Property(e => e.SoCT).IsUnicode(false);
            modelBuilder.Entity<eCt_ts>().Property(e => e.NguyenGia).HasPrecision(16, 2);
            modelBuilder.Entity<eCt_ts>().Property(e => e.GT_Da_KH).HasPrecision(16, 2);
            modelBuilder.Entity<eCt_ts>().Property(e => e.GTCL).HasPrecision(16, 2);
            modelBuilder.Entity<eCt_ts>().Property(e => e.GT_KH_Ky).HasPrecision(16, 2);
            modelBuilder.Entity<eCt_ts>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eCt_ts>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eCt_ts>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_ktbc
            modelBuilder.Entity<eDm_ktbc>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_ktbc>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_ktbc>().Property(e => e.TenBT).IsRequired();
            modelBuilder.Entity<eDm_ktbc>().Property(e => e.TenBT).HasMaxLength(250);
            modelBuilder.Entity<eDm_ktbc>().Property(e => e.STTKC).HasMaxLength(20);
            modelBuilder.Entity<eDm_ktbc>().Property(e => e.Nam).HasPrecision(4, 0);
            modelBuilder.Entity<eDm_ktbc>().Property(e => e.STT).HasPrecision(3, 0);
            modelBuilder.Entity<eDm_ktbc>().Property(e => e.LoaiKC).HasPrecision(16, 2);
            modelBuilder.Entity<eDm_ktbc>().Property(e => e.STTKC).IsUnicode(false);
            modelBuilder.Entity<eDm_ktbc>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_ktbc>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_ktbc>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region ePXBPHTXREF
            modelBuilder.Entity<ePXBPHTXREF>().HasKey(e => new { e.BPID, e.PXID });
            #endregion

            #region eNhomhhvtxref
            modelBuilder.Entity<eNhomhhvtxref>().HasKey(e => new { e.NhomHHVTID, e.VTHHID });
            #endregion

            #region eDm_kheuoc
            modelBuilder.Entity<eDm_kheuoc>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_kheuoc>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_kheuoc>().Property(e => e.MaKU).HasMaxLength(16);
            modelBuilder.Entity<eDm_kheuoc>().Property(e => e.SoKU).HasMaxLength(16);
            modelBuilder.Entity<eDm_kheuoc>().Property(e => e.TenKU).HasMaxLength(128);
            #endregion

            #region eQuyen
            modelBuilder.Entity<eQuyen>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eQuyen>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            #endregion

            #region eTaiKhoan
            modelBuilder.Entity<eTaiKhoan>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eTaiKhoan>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eTaiKhoan>().HasIndex(e => e.AccCode).IsUnique();
            modelBuilder.Entity<eTaiKhoan>().Property(e => e.AccCode).IsRequired();
            modelBuilder.Entity<eTaiKhoan>().Property(e => e.AccCode).IsUnicode(false);
            modelBuilder.Entity<eTaiKhoan>().Property(e => e.AccCode).HasMaxLength(20);
            modelBuilder.Entity<eTaiKhoan>().HasIndex(e => e.AccName).IsUnique();
            modelBuilder.Entity<eTaiKhoan>().Property(e => e.AccName).IsRequired();
            modelBuilder.Entity<eTaiKhoan>().Property(e => e.AccName).HasMaxLength(128);
            modelBuilder.Entity<eTaiKhoan>().Property(e => e.AnHien).HasDefaultValue(true);
            modelBuilder.Entity<eTaiKhoan>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eTaiKhoan>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eTaiKhoan>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region xChucNang
            modelBuilder.Entity<xChucNang>().HasKey(e => e.KeyID);
            modelBuilder.Entity<xChucNang>().HasMany(e => e.eQuyen).WithOne(e => e.xChucNang).HasForeignKey(e => e.ChucNangID);
            modelBuilder.Entity<xChucNang>().Property(e => e.Route).HasMaxLength(250);
            modelBuilder.Entity<xChucNang>().Property(e => e.Methods).HasMaxLength(250);
            modelBuilder.Entity<xChucNang>().Property(e => e.ControllerName).HasMaxLength(250);
            #endregion

            #region eDm_gia
            modelBuilder.Entity<eDm_gia>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_gia>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_gia>().Property(e => e.Gia).HasPrecision(15, 4);
            modelBuilder.Entity<eDm_gia>().Property(e => e.GiaNT).HasPrecision(15, 4);
            #endregion

            #region eHD_pt
            modelBuilder.Entity<eHD_pt>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eHD_pt>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eHD_pt>().Property(e => e.SoPhieuThu).HasMaxLength(20);
            modelBuilder.Entity<eHD_pt>().Property(e => e.TenKH).HasMaxLength(128);
            modelBuilder.Entity<eHD_pt>().Property(e => e.MST).HasMaxLength(100);
            modelBuilder.Entity<eHD_pt>().Property(e => e.NguoiLienHe).HasMaxLength(128);
            modelBuilder.Entity<eHD_pt>().Property(e => e.DiaChi).HasMaxLength(250);
            modelBuilder.Entity<eHD_pt>().Property(e => e.KemTheo).HasMaxLength(250);
            modelBuilder.Entity<eHD_pt>().Property(e => e.DienGiai).HasMaxLength(250);
            modelBuilder.Entity<eHD_pt>().Property(e => e.TongTienHang).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_pt>().Property(e => e.TongTienThanhToan).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_pt>().Property(e => e.TongTienChietKhau).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_pt>().Property(e => e.TongThue).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_pt>().Property(e => e.TongThueXK).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_pt>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eHD_pt>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eHD_pt>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eHD_bh
            modelBuilder.Entity<eHD_bh>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eHD_bh>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eHD_bh>().Property(e => e.TenKH).HasMaxLength(128);
            modelBuilder.Entity<eHD_bh>().Property(e => e.MST).HasMaxLength(100);
            modelBuilder.Entity<eHD_bh>().Property(e => e.TKNH).HasMaxLength(50);
            modelBuilder.Entity<eHD_bh>().Property(e => e.NguoiMuaHang).HasMaxLength(128);
            modelBuilder.Entity<eHD_bh>().Property(e => e.PTTT).HasMaxLength(20);
            modelBuilder.Entity<eHD_bh>().Property(e => e.KyHieuHD).HasMaxLength(20);
            modelBuilder.Entity<eHD_bh>().Property(e => e.SoHD).HasMaxLength(20);
            modelBuilder.Entity<eHD_bh>().Property(e => e.TongTienHang).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_bh>().Property(e => e.TongTienThanhToan).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_bh>().Property(e => e.TongTienChietKhau).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_bh>().Property(e => e.TongThue).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_bh>().Property(e => e.TongThueXK).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_bh>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eHD_bh>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eHD_bh>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eHD_ctbh
            modelBuilder.Entity<eHD_ctbh>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.DienGiai).HasMaxLength(250);
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.SoLo).HasMaxLength(50);
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.SoLuong).HasPrecision(18, 2);
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.DonGiaQD).HasPrecision(20, 6);
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.DonGiaST).HasPrecision(20, 6);
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.ThanhTien).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.ThanhTienQD).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.TiLeCK).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.TienCK).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.TienCKQD).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.VAT).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.TienVAT).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.TienVATQD).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.ThueXK).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.TienThueXKQD).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_ctbh>().Property(e => e.DonGiaVon).HasPrecision(18, 4);
            #endregion

            #region eTraHang
            modelBuilder.Entity<eTraHang>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eTraHang>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eTraHang>().Property(e => e.SoPhieuThu).HasMaxLength(20);
            modelBuilder.Entity<eTraHang>().Property(e => e.TenKH).HasMaxLength(128);
            modelBuilder.Entity<eTraHang>().Property(e => e.MST).HasMaxLength(100);
            modelBuilder.Entity<eTraHang>().Property(e => e.NguoiLienHe).HasMaxLength(128);
            modelBuilder.Entity<eTraHang>().Property(e => e.DiaChi).HasMaxLength(250);
            modelBuilder.Entity<eTraHang>().Property(e => e.KemTheo).HasMaxLength(250);
            modelBuilder.Entity<eTraHang>().Property(e => e.DienGiai).HasMaxLength(250);
            modelBuilder.Entity<eTraHang>().Property(e => e.TongTienHang).HasPrecision(18, 4);
            modelBuilder.Entity<eTraHang>().Property(e => e.TongTienThanhToan).HasPrecision(18, 4);
            modelBuilder.Entity<eTraHang>().Property(e => e.TongTienChietKhau).HasPrecision(18, 4);
            modelBuilder.Entity<eTraHang>().Property(e => e.TongThue).HasPrecision(18, 4);
            modelBuilder.Entity<eTraHang>().Property(e => e.TongThueXK).HasPrecision(18, 4);
            modelBuilder.Entity<eTraHang>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eTraHang>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eTraHang>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eHD_TH
            modelBuilder.Entity<eHD_TH>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eHD_TH>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eHD_TH>().Property(e => e.SoCTSoQT).HasMaxLength(250);
            modelBuilder.Entity<eHD_TH>().Property(e => e.SoCTSoTC).HasMaxLength(50);
            modelBuilder.Entity<eHD_TH>().Property(e => e.DiaChiNN).HasMaxLength(250);
            modelBuilder.Entity<eHD_TH>().Property(e => e.MST).HasMaxLength(50);
            modelBuilder.Entity<eHD_TH>().Property(e => e.DienGiai).HasMaxLength(250);
            modelBuilder.Entity<eHD_TH>().Property(e => e.KyHieuHD).HasMaxLength(50);
            modelBuilder.Entity<eHD_TH>().Property(e => e.SoHD).HasMaxLength(250);
            modelBuilder.Entity<eHD_TH>().Property(e => e.TyGia).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_TH>().Property(e => e.ThanhTienCT).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_TH>().Property(e => e.ThanhTienCTQD).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_TH>().Property(e => e.TienVATQD).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_TH>().Property(e => e.TienVAT).HasPrecision(18, 4);
            modelBuilder.Entity<eHD_TH>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eHD_TH>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eHD_TH>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_thck
            modelBuilder.Entity<eDm_thck>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_thck>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_thck>().Property(e => e.MaTHCK).HasMaxLength(16);
            modelBuilder.Entity<eDm_thck>().Property(e => e.TenTHCK).HasMaxLength(128);
            modelBuilder.Entity<eDm_thck>().Property(e => e.GhiChu).HasMaxLength(2000);
            modelBuilder.Entity<eDm_thck>().Property(e => e.HanTT).HasPrecision(3, 0);
            modelBuilder.Entity<eDm_thck>().Property(e => e.THCK).HasPrecision(3, 0);
            modelBuilder.Entity<eDm_thck>().Property(e => e.TyLe).HasPrecision(6, 2);
            modelBuilder.Entity<eDm_thck>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_thck>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_thck>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region ePhieuXuat
            modelBuilder.Entity<ePhieuXuat>().HasKey(e => e.KeyID);
            modelBuilder.Entity<ePhieuXuat>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<ePhieuXuat>().Property(e => e.SoPhieuXuat).HasMaxLength(20);
            modelBuilder.Entity<ePhieuXuat>().Property(e => e.TenKH).HasMaxLength(128);
            modelBuilder.Entity<ePhieuXuat>().Property(e => e.NguoiNhan).HasMaxLength(128);
            modelBuilder.Entity<ePhieuXuat>().Property(e => e.DiaChi).HasMaxLength(250);
            modelBuilder.Entity<ePhieuXuat>().Property(e => e.LyDo).HasMaxLength(128);
            modelBuilder.Entity<ePhieuXuat>().Property(e => e.KemTheo).HasMaxLength(250);
            modelBuilder.Entity<ePhieuXuat>().Property(e => e.DienGiai).HasMaxLength(250);
            modelBuilder.Entity<ePhieuXuat>().Property(e => e.TongTienHang).HasPrecision(18, 4);
            modelBuilder.Entity<ePhieuXuat>().Property(e => e.TongTienThanhToan).HasPrecision(18, 4);
            modelBuilder.Entity<ePhieuXuat>().Property(e => e.TongTienChietKhau).HasPrecision(18, 4);
            modelBuilder.Entity<ePhieuXuat>().Property(e => e.TongThue).HasPrecision(18, 4);
            modelBuilder.Entity<ePhieuXuat>().Property(e => e.TongThueXK).HasPrecision(18, 4);
            modelBuilder.Entity<ePhieuXuat>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<ePhieuXuat>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<ePhieuXuat>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region ePhieuNhap
            modelBuilder.Entity<ePhieuNhap>().HasKey(e => e.KeyID);
            modelBuilder.Entity<ePhieuNhap>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<ePhieuNhap>().Property(e => e.SoPhieuNhap).HasMaxLength(20);
            modelBuilder.Entity<ePhieuNhap>().Property(e => e.TenKH).HasMaxLength(128);
            modelBuilder.Entity<ePhieuNhap>().Property(e => e.NguoiGiaoHang).HasMaxLength(128);
            modelBuilder.Entity<ePhieuNhap>().Property(e => e.LyDo).HasMaxLength(128);
            modelBuilder.Entity<ePhieuNhap>().Property(e => e.SoQuanTri).HasMaxLength(20);
            modelBuilder.Entity<ePhieuNhap>().Property(e => e.SoTaiChinh).HasMaxLength(20);
            modelBuilder.Entity<ePhieuNhap>().Property(e => e.KemTheo).HasMaxLength(250);
            modelBuilder.Entity<ePhieuNhap>().Property(e => e.TongTienSoQuanTri).HasPrecision(18, 4);
            modelBuilder.Entity<ePhieuNhap>().Property(e => e.TongTienSoTaiChinh).HasPrecision(18, 4);
            modelBuilder.Entity<ePhieuNhap>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<ePhieuNhap>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<ePhieuNhap>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eTU_Ph46
            modelBuilder.Entity<eTU_Ph46>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eTU_Ph46>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eTU_Ph46>().Property(e => e.STT_REC).HasMaxLength(11);
            modelBuilder.Entity<eTU_Ph46>().Property(e => e.CTID).HasMaxLength(3);
            modelBuilder.Entity<eTU_Ph46>().Property(e => e.MaNX).HasMaxLength(3);
            modelBuilder.Entity<eTU_Ph46>().Property(e => e.MaGD).HasMaxLength(1);
            modelBuilder.Entity<eTU_Ph46>().Property(e => e.DienGiaiCT).HasMaxLength(48);
            modelBuilder.Entity<eTU_Ph46>().Property(e => e.SoCT).HasMaxLength(12);
            #endregion

            #region eDm_Loaict
            modelBuilder.Entity<eDm_Loaict>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_Loaict>().Property(e => e.LoaiCT).HasMaxLength(255);
            modelBuilder.Entity<eDm_Loaict>().Property(e => e.TenLoaiCT).HasMaxLength(100);
            #endregion

            #region eDm_Post
            modelBuilder.Entity<eDm_Post>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_Post>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_Post>().Property(e => e.MaCT).HasMaxLength(3);
            modelBuilder.Entity<eDm_Post>().Property(e => e.MaPost).HasMaxLength(8);
            modelBuilder.Entity<eDm_Post>().Property(e => e.TenPost).HasMaxLength(48);
            #endregion

            #region eDm_ct
            modelBuilder.Entity<eDm_ct>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_ct>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_ct>().Property(e => e.MaPH).HasMaxLength(8);
            modelBuilder.Entity<eDm_ct>().Property(e => e.MaCT).HasMaxLength(3);
            modelBuilder.Entity<eDm_ct>().Property(e => e.TenCT).HasMaxLength(128);
            modelBuilder.Entity<eDm_ct>().Property(e => e.MaCTMe).HasMaxLength(3);
            modelBuilder.Entity<eDm_ct>().Property(e => e.MaCTIn).HasMaxLength(3);
            modelBuilder.Entity<eDm_ct>().Property(e => e.MaPost).HasMaxLength(8);
            modelBuilder.Entity<eDm_ct>().Property(e => e.SoCT).HasPrecision(12, 0);
            modelBuilder.Entity<eDm_ct>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_ct>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_ct>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_giaodich
            modelBuilder.Entity<eDm_giaodich>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_giaodich>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_giaodich>().Property(e => e.CTID).HasMaxLength(3);
            modelBuilder.Entity<eDm_giaodich>().Property(e => e.MaGD).HasMaxLength(1);
            modelBuilder.Entity<eDm_giaodich>().Property(e => e.TenGD).HasMaxLength(2);
            modelBuilder.Entity<eDm_giaodich>().Property(e => e.LoaiCT).HasMaxLength(128);
            modelBuilder.Entity<eDm_giaodich>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_giaodich>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_giaodich>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_vv
            modelBuilder.Entity<eDm_vv>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_vv>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_vv>().Property(e => e.MaVV).HasMaxLength(16);
            #endregion

            #region eDm_nx
            modelBuilder.Entity<eDm_nx>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_nx>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_nx>().Property(e => e.MaNX).HasMaxLength(16);
            modelBuilder.Entity<eDm_nx>().Property(e => e.TenNX).HasMaxLength(128);
            modelBuilder.Entity<eDm_nx>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_nx>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_nx>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDm_px
            modelBuilder.Entity<eDm_px>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDm_px>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDm_px>().Property(e => e.MaPX).HasMaxLength(20);
            modelBuilder.Entity<eDm_px>().Property(e => e.TenPX).HasMaxLength(128);
            modelBuilder.Entity<eDm_px>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_px>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eDm_px>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region ePhanQuyen
            modelBuilder.Entity<ePhanQuyen>().HasKey(e => e.KeyID);
            modelBuilder.Entity<ePhanQuyen>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<ePhanQuyen>().Property(e => e.TenQuyen).HasMaxLength(128);
            #endregion

            #region eCdtk
            modelBuilder.Entity<eCdtk>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eCdtk>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eCdtk>().Property(e => e.TK).IsRequired();
            modelBuilder.Entity<eCdtk>().Property(e => e.TK).HasColumnType("char(20)");
            modelBuilder.Entity<eCdtk>().Property(e => e.DuNo).HasPrecision(16, 2);
            modelBuilder.Entity<eCdtk>().Property(e => e.DuCo).HasPrecision(16, 2);
            modelBuilder.Entity<eCdtk>().Property(e => e.DuNo1).HasPrecision(16, 2);
            modelBuilder.Entity<eCdtk>().Property(e => e.DuCo1).HasPrecision(16, 2);
            modelBuilder.Entity<eCdtk>().Property(e => e.DuNoNT).HasPrecision(16, 2);
            modelBuilder.Entity<eCdtk>().Property(e => e.DuCoNT).HasPrecision(16, 2);
            modelBuilder.Entity<eCdtk>().Property(e => e.DuNoNT1).HasPrecision(16, 2);
            modelBuilder.Entity<eCdtk>().Property(e => e.DuCoNT1).HasPrecision(16, 2);
            modelBuilder.Entity<eCdtk>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eCdtk>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eCdtk>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region eDmph
            modelBuilder.Entity<eDmph>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDmph>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDmph>().Property(e => e.TenPhanHe).IsRequired();
            #endregion

            #region eDmctct
            modelBuilder.Entity<eDmctct>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eDmctct>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eDmctct>().Property(e => e.TenCT).HasMaxLength(128);
            modelBuilder.Entity<eDmctct>().Property(e => e.MasterTableName).HasMaxLength(50);
            modelBuilder.Entity<eDmctct>().Property(e => e.DetailTableName).HasMaxLength(50);
            #endregion

            #region eTknd
            modelBuilder.Entity<eTknd>().HasKey(e => e.KeyID);
            modelBuilder.Entity<eTknd>().Property(e => e.KeyID).ValueGeneratedOnAdd();
            modelBuilder.Entity<eTknd>().Property(e => e.TenCT).HasMaxLength(128);
            modelBuilder.Entity<eTknd>().Property(e => e.MaCT).HasColumnType("char(3)");
            modelBuilder.Entity<eTknd>().Property(e => e.TenCot).HasMaxLength(50);
            modelBuilder.Entity<eTknd>().Property(e => e.TieuDeCot).HasMaxLength(100);
            modelBuilder.Entity<eTknd>().Property(e => e.NguoiTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eTknd>().Property(e => e.NgayTao).Metadata.IsReadOnlyAfterSave = true;
            modelBuilder.Entity<eTknd>().Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
            #endregion
        }
    }
}