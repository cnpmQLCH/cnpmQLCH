//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLXM
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDonXuat
    {
        public HoaDonXuat()
        {
            this.ChitietHDXes = new HashSet<ChitietHDX>();
        }
    
        public string MaHDX { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public Nullable<System.DateTime> NgayXuat { get; set; }
    
        public virtual ICollection<ChitietHDX> ChitietHDXes { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}