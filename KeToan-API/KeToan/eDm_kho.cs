namespace KeToan
{
    public class eDm_kho
    {
        public int KeyID { get; set; }
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public int? TKDL { get; set; }
        public bool AnHien { get; set; } = true;
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
    }
}
