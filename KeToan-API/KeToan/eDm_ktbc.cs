namespace KeToan
{
    public class eDm_ktbc
    {
        public int KeyID { get; set; }
        public decimal Nam { get; set; }
        public decimal STT { get; set; }
        public string TenBT { get; set; }
        public int TKNo { get; set; }
        public int TKCo { get; set; }
        public decimal? LoaiKC { get; set; }
        public string STTKC { get; set; }
        public int ChiNhanhID { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
    }
}
