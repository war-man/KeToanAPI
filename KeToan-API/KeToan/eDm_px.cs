namespace KeToan
{
    public class eDm_px
    {
        public int KeyID { get; set; }
        public string MaPX { get; set; }
        public string TenPX { get; set; }
        public int PhongBanID { get; set; }
        public bool ChonBPHT { get; set; } = false;
        public int? TKCPSXDD { get; set; }
        public int ChiNhanhID { get; set; }        
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
    }
}
