using KeToan; using Microsoft.EntityFrameworkCore;  namespace API {     public partial class zModel     {         public DbSet<eCdkh> eCdkh { get; set; }         public DbSet<eCdnh> eCdnh { get; set; }         public DbSet<eCdvt> eCdvt { get; set; }         public DbSet<eCt_ctts> eCt_ctts { get; set; }         public DbSet<eCt_ts> eCt_ts { get; set; }         public DbSet<eDm_bophan> eDm_bophan { get; set; }         public DbSet<eDm_cc> eDm_cc { get; set; }         public DbSet<eDm_chinhanh> eDm_chinhanh { get; set; }         public DbSet<eDm_chucdanh> eDm_chucdanh { get; set; }         public DbSet<eDm_chucvu> eDm_chucvu { get; set; }         public DbSet<eDm_ct> eDm_ct { get; set; }         public DbSet<eDm_cty> eDm_cty { get; set; }         public DbSet<eDm_dvt> eDm_dvt { get; set; }         public DbSet<eDm_gia> eDm_gia { get; set; }         public DbSet<eDm_giaodich> eDm_giaodich { get; set; }         public DbSet<eDm_httl> eDm_httl { get; set; }         public DbSet<eDm_kheuoc> eDm_kheuoc { get; set; }         public DbSet<eDm_kho> eDm_kho { get; set; }         public DbSet<eDm_ktbc> eDm_ktbc { get; set; }         public DbSet<eDm_Loaict> eDm_Loaict { get; set; }         public DbSet<eDm_loaitscd> eDm_loaitscd { get; set; }         public DbSet<eDm_lytcp> eDm_lytcp { get; set; }         public DbSet<eDm_nganhang> eDm_nganhang { get; set; }         public DbSet<eDm_nguonvon> eDm_nguonvon { get; set; }         public DbSet<eDm_nhomhhvt> eDm_nhomhhvt { get; set; }         public DbSet<eDm_NhomKH> eDm_NhomKH { get; set; }         public DbSet<eDm_nhomtk> eDm_nhomtk { get; set; }         public DbSet<eDm_nhomtscd> eDm_nhomtscd { get; set; }         public DbSet<eDm_nhom_cc> eDm_nhom_cc { get; set; }         public DbSet<eDm_nt> eDm_nt { get; set; }         public DbSet<eDm_nv> eDm_nv { get; set; }         public DbSet<eDm_nx> eDm_nx { get; set; }         public DbSet<eDm_nytcp> eDm_nytcp { get; set; }         public DbSet<eDm_phongban> eDm_phongban { get; set; }         public DbSet<eDm_pl_cc> eDm_pl_cc { get; set; }         public DbSet<eDm_Post> eDm_Post { get; set; }         public DbSet<eDm_px> eDm_px { get; set; }         public DbSet<eDm_tgtscd> eDm_tgtscd { get; set; }         public DbSet<eDm_thck> eDm_thck { get; set; }         public DbSet<eDm_tk> eDm_tk { get; set; }         public DbSet<eDm_ts> eDm_ts { get; set; }         public DbSet<eDm_tt> eDm_tt { get; set; }         public DbSet<eDm_vthh> eDm_vthh { get; set; }         public DbSet<eDm_vv> eDm_vv { get; set; }         public DbSet<eDm_ytcp> eDm_ytcp { get; set; }         public DbSet<eHD_bh> eHD_BH { get; set; }         public DbSet<eHD_ctbh> eHD_CTBH { get; set; }         public DbSet<eHD_pt> eHD_pt { get; set; }         public DbSet<ePhieuXuat> ePhieuXuat { get; set; }         public DbSet<eHD_TH> eHD_TH { get; set; }         public DbSet<eKhachhang> eKhachhang { get; set; }         public DbSet<eNhomhhvtxref> eNhomhhvtxref { get; set; }         public DbSet<ePhanQuyen> ePhanQuyen { get; set; }         public DbSet<ePhieuNhap> ePhieuNhap { get; set; }         public DbSet<ePXBPHTXREF> ePXBPHTXREF { get; set; }         public DbSet<eQuyen> eQuyen { get; set; }         public DbSet<eTaiKhoan> eTaiKhoan { get; set; }         public DbSet<eTraHang> eTraHang { get; set; }         public DbSet<eTU_Ph46> eTU_Ph46 { get; set; }         public DbSet<xAppctl> xAppctl { get; set; }         public DbSet<xCdtk> xCdtk { get; set; }         public DbSet<xChucNang> xChucNang { get; set; }         public DbSet<eCdtk> eCdtk { get; set; }         public DbSet<eDmph> eDmph { get; set; }         public DbSet<eDmctct> eDmctct { get; set; }         public DbSet<eTknd> eTknd { get; set; }      } } 