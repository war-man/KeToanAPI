namespace KeToan
{
    public class eDm_tgtscd
    {
        public int KeyID { get; set; }
        public string MaTGTSCD { get; set; }
        public string TenTGTSCD { get; set; }
        public decimal LoaiTG { get; set; } = 1;
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
    }
}
