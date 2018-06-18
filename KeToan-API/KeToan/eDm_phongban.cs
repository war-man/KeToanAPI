namespace KeToan
{
    public class eDm_phongban
    {
        public int KeyID { get; set; }
        public string MaPB { get; set; }
        public string DienGiai { get; set; }
        public int ChiNhanhID { get; set; }
        public bool AnHien { get; set; } = true;
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
    }
}
