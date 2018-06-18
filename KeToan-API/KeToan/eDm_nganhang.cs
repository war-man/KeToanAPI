namespace KeToan
{
    public class eDm_nganhang
    {
       public int KeyID { get; set; }
        public string TKNganHang { get; set; }
        public int TaiKhoanID { get; set; }
        public string TenNH { get; set; }
        public int TinhThanhID { get; set; }
        public string DienThoai { get; set; }
		public string Fax {get;set;}
        public string Email { get; set; }
        public string MaSoThue { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
    }
}
