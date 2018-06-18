namespace KeToan
{
    public partial class eDm_chucvu
    {
        public int KeyID { get; set; }
        public string MaChucVu { get; set; }
        public string DienGiai { get; set; }
        public bool AnHien { get; set; } = true;
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
    }
}
