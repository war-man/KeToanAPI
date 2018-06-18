namespace KeToan
{
    public class eTaiKhoan
    {
        public int KeyID { get; set; }
        public string AccCode { get; set; }
        public string AccName { get; set; }
        public string Password { get; set; }
        public int? PhanQuyenID { get; set; }
        public System.Guid NVID { get; set; }
        public int ChiNhanhID { get; set; }
        public bool AnHien { get; set; } = true;
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
    }
}
