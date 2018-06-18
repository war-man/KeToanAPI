namespace KeToan
{
    [System.Diagnostics.DebuggerDisplay("{Methods}\r\n{Route}")]
    public class xChucNang
    {
        public int KeyID { get; set; }
        public string ModuleName { get; set; }
        public string Route { get; set; }
        public string Methods { get; set; }
        public string ControllerName { get; set; }
        public virtual System.Collections.Generic.ICollection<eQuyen> eQuyen { get; set; } = new System.Collections.Generic.HashSet<eQuyen>();
    }
}
