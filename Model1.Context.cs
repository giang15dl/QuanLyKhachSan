﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKhachSan
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLKSEntities : DbContext
    {
        public QLKSEntities()
            : base("name=QLKSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tKhach> tKhaches { get; set; }
        public virtual DbSet<tPhong> tPhongs { get; set; }
        public virtual DbSet<tThietBi> tThietBis { get; set; }
        public virtual DbSet<tThuePhong> tThuePhongs { get; set; }
        public virtual DbSet<tTrangBi> tTrangBis { get; set; }
    }
}
