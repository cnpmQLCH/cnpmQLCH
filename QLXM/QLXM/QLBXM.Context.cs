﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLXMEntities : DbContext
    {
        public QLXMEntities()
            : base("name=QLXMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Admin> Admins { get; set; }
        public DbSet<BaoHanh> BaoHanhs { get; set; }
        public DbSet<ChitietHDN> ChitietHDNs { get; set; }
        public DbSet<ChitietHDX> ChitietHDXes { get; set; }
        public DbSet<HoaDonNhap> HoaDonNhaps { get; set; }
        public DbSet<HoaDonXuat> HoaDonXuats { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<Loaixe> Loaixes { get; set; }
        public DbSet<NCC> NCCs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Xe> Xes { get; set; }
        public DbSet<solanban> solanbans { get; set; }
        public DbSet<xebanchaynhat> xebanchaynhats { get; set; }
        public DbSet<xetonkho> xetonkhoes { get; set; }
    }
}
