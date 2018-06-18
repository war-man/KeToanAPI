namespace KeToan
{
    public class eDm_cc
    {
        public int KeyID { get; set; }
        public string MaCC { get; set; }
        public string TenCC { get; set; }
        public int LoaiCCID { get; set; }
        public int TGTSCDID { get; set; }
        public System.DateTime NgayTang { get; set; }
        public int NgayPB { get; set; }
        public decimal SoKyPB { get; set; }
        public decimal GiaTriConLai { get; set; } = 0;
        public int KieuPB { get; set; }
        public int PXID { get; set; }
        public int YTCPID { get; set; }
        public int BPSDID { get; set; }
        public int BPHTID { get; set; }
        public int TKCC { get; set; }
        public int TKPB { get; set; }
        public int TKCP { get; set; }
        public int NhomTSCDID { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
        public int ChiNhanhID { get; set; }
    }
}
