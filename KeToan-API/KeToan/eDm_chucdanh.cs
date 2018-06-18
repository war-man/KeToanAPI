namespace KeToan
{
    public class eDm_chucdanh
    {
        public int KeyID { get; set; }
        public string MaChucDanh { get; set; }
        public string DienGiai { get; set; }
        public bool AnHien { get; set; } = true;
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
    }
}
