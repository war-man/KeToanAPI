namespace KeToan
{
    public class eDm_nguonvon
    {
        public int KeyID { get; set; }
        public string MaNguonVon { get; set; }
        public string TenNguonVon { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
    }
}
