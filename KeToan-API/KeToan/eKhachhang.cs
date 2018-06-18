namespace KeToan
{
    public class eKhachhang
    {
        public int KeyID { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string MaSoThue { get; set; }
        public int? HanThanhToan { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string TKNganHang { get; set; }
        public int TK { get; set; } = 0;
        public string TenNganHang { get; set; }
        public int TinhThanhID { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
        public int ChiNhanhID { get; set; }
    }
}
