namespace KeToan
{
    public class ePhieuNhap
    {
        public int KeyID { get; set; }
        public int TraHangID { get; set; }
        public System.DateTime NgayHT { get; set; }
        public System.DateTime NgayCT { get; set; }
        public string SoPhieuNhap { get; set; }
        public int KhachHangID { get; set; }
        public string TenKH { get; set; }
        public string NguoiGiaoHang { get; set; }
        public string LyDo { get; set; }
        public int AccID { get; set; }
        public string SoQuanTri { get; set; }
        public string SoTaiChinh { get; set; }
        public bool TrangThaiSoQuanTri { get; set; }
        public bool TrangThaiSoTaiChinh { get; set; }
        public string KemTheo { get; set; }
        public decimal TongTienSoTaiChinh { get; set; }
        public decimal TongTienSoQuanTri { get; set; }
        public int PTTinhDonGia { get; set; }
        public bool TrangThaiGhiSoThuKhoTC { get; set; }
        public bool TrangThaiGhiSoThuKhoQT { get; set; }
        public System.DateTime NgayGhiSoKho { get; set; }
        public int NguyenTeID { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int NguoiCapNhat { get; set; }
    }
}