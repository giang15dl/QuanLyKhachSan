//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tHoaDon
    {
        public string MaHoaDon { get; set; }
        public string MaKhach { get; set; }
        public string MaDichVu { get; set; }
        public string SoPhong { get; set; }
        public Nullable<System.DateTime> NgayTraPhong { get; set; }
    
        public virtual tDichVu tDichVu { get; set; }
        public virtual tKhach tKhach { get; set; }
        public virtual tPhong tPhong { get; set; }
    }
}
