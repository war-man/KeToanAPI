namespace KeToan
{
    public class eDm_ts
    {
        public int KeyID { get; set; }
        public string MaTSCD { get; set; }
        public string TenTSCD { get; set; }
        public int LoaiTSCDID { get; set; }
        public int TGTSCDID { get; set; }
        public System.DateTime NgayTang { get; set; }
        public decimal KieuKhauHao { get; set; }
        public decimal SoKyKhauHao { get; set; }
        public System.DateTime NgayKhauHao { get; set; }
        public decimal GiaTriConLai { get; set; } = 0;
        public int BoPhanHT { get; set; }
        public int PXID { get; set; }
        public int YTCPID { get; set; }
        public int BPID { get; set; }
        public int TKTS { get; set; }
        public int TKKH { get; set; }
        public int TKCP { get; set; }
        public int NhomTSCDID { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
        public int ChiNhanh { get; set; }
    }
}
