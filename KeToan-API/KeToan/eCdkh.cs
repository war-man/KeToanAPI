namespace KeToan
{
    public class eCdkh
    {
        public int KeyID { get; set; }
        public int Nam { get; set; }
        public int TKID { get; set; }
        public string KhachHangID { get; set; }
        public decimal DuNo { get; set; } = 0;
        public decimal DuCo { get; set; } = 0;
        public decimal DuNo1 { get; set; } = 0;
        public decimal DuCo1 { get; set; } = 0;
        public decimal DuNoNT { get; set; } = 0;
        public decimal DuCoNT { get; set; } = 0;
        public decimal DuNoNT1 { get; set; } = 0;
        public decimal DuCoNT1 { get; set; } = 0;
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
    }
}
