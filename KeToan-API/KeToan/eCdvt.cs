namespace KeToan
{
    public class eCdvt
    {
        public int KeyID { get; set; }
        public int Nam { get; set; }
        public int VTHHID { get; set; }
        public int KhoID { get; set; }
        public decimal TonDau { get; set; } = 0;
        public decimal DuDau { get; set; } = 0;
        public decimal DuNT { get; set; } = 0;
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
    }
}
