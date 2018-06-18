namespace KeToan
{
    public class eDm_thck
    {
        public int KeyID { get; set; }
        public string MaTHCK { get; set; }
        public string TenTHCK { get; set; }
        public decimal HanTT { get; set; }
        public decimal THCK { get; set; }
        public decimal TyLe { get; set; }
        public string GhiChu { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
    }
}