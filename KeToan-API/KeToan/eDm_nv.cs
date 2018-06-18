namespace KeToan
{
    public class eDm_nv
    {
        public System.Guid KeyID { get; set; }
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public int SoCMND { get; set; }
        public System.DateTime NgayCap { get; set; }
        public int NoiCap { get; set; }
        public bool GioiTinh { get; set; } = true;
        public string QueQuan { get; set; }
        public bool HonNhan { get; set; } = false;
        public int? DTDD { get; set; }
        public string Email { get; set; }
        public string DiaChiThuongTru { get; set; }
        public int HTTraLuongID { get; set; }
        public string MaSoThue { get; set; }
        public int? BaoHiem { get; set; }
        public int LuongCoBan { get; set; } = 0;
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
        public int ChiNhanhID { get; set; }
    }
}
