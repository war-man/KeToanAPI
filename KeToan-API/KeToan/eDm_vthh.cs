namespace KeToan
{
    public class eDm_vthh
    {
        public int KeyID { get; set; }
        public string MaVTHH { get; set; }
        public string TenVTHH { get; set; }
        public int DVTID { get; set; }
        public bool TDTK { get; set; }
        public int? VTTonKho { get; set; } = 0;
        public int? GiaTon { get; set; }
        public int? TKVT { get; set; }
        public int? TKDT { get; set; }
        public int? TKDTNB { get; set; }
        public int? TKGV { get; set; }
        public int? TKTL { get; set; }
        public int? TKSPDD { get; set; }
        public int? TKKM { get; set; }
        public int SLMin { get; set; } = 0;
        public int SLMax { get; set; } = 0;
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
        public int ChiNhanhID { get; set; }
    }
}
