namespace KeToan
{
    public class eQuyen
    {
        public int KeyID { get; set; }
        public int PhanQuyenID { get; set; }
        public int ChucNangID { get; set; }
        public virtual xChucNang xChucNang { get; set; }
    }
}
