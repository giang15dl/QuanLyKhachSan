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
    
    public partial class tThuePhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tThuePhong()
        {
            this.tHoaDons = new HashSet<tHoaDon>();
        }
    
        public string MaThuePhong { get; set; }
        public string SoPhong { get; set; }
        public string MaKhach { get; set; }
        public System.DateTime NgayNhanPhong { get; set; }
        public System.DateTime NgayTraPhong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tHoaDon> tHoaDons { get; set; }
        public virtual tKhach tKhach { get; set; }
        public virtual tPhong tPhong { get; set; }
    }
}
