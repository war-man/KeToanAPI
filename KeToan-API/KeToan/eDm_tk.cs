namespace KeToan
{
    public class eDm_tk
    {
        public int KeyID { get; set; }
        public string TK { get; set; }
        public string TenTK { get; set; }
        public int NguyenTeID { get; set; }
        public bool TKCN { get; set; } = false;
        public bool TKSC { get; set; } = false;
        public int? TKMe { get; set; }
        public int BacTK { get; set; } = 1;
        public int NTKID { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime? NgayCapNhat { get; set; }
        public int NguoiTao { get; set; }
        public int? NguoiCapNhat { get; set; }
    }
}
