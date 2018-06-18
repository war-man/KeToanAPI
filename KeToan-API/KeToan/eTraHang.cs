namespace KeToan
{
    public class eTraHang
    {
        public int KeyID { get; set; }
        public int PTID { get; set; }
        public System.DateTime NgayHT { get; set; }
        public System.DateTime NgayCT { get; set; }
        public string SoPhieuThu { get; set; }
        public int KhachHangID { get; set; }
        public string TenKH { get; set; }
        public string MST { get; set; }
        public string NguoiLienHe { get; set; }
        public string DiaChi { get; set; }
        public int AccID { get; set; }
        public string KemTheo { get; set; }
        public int PTTT { get; set; }
        public string DienGiai { get; set; }
        public int LoaiCT { get; set; }
        public decimal TongTienHang { get; set; }
        public decimal TongTienThanhToan { get; set; }
        public decimal TongTienChietKhau { get; set; }
        public decimal TongThue { get; set; }
        public decimal TongThueXK { get; set; }
        public bool KiemPhieuNK { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int NguoiCapNhat { get; set; }
        public int ChiNhanhID { get; set; }
    }
}