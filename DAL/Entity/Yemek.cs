//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant.DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    public partial class Yemek
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Yemek()
        {
            this.YemekAraTablo = new HashSet<YemekAraTablo>();
        }
        
        public int YemekID { get; set; }
        public virtual string YemekAdi { get; set; }
        public decimal YemekFiyati { get; set; }
        public int YemekKategorisi { get; set; }
        public string YemekResmi { get; set; }
        public decimal YemekMaliyeti { get; set; }
        public int YemekMevcutAdet { get; set; }
        public bool isDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YemekAraTablo> YemekAraTablo { get; set; }
    }
}
