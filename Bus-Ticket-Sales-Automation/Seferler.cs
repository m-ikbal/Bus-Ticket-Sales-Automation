//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bus_Ticket_Sales_Automation
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seferler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seferler()
        {
            this.Biletler = new HashSet<Biletler>();
        }
    
        public int seferId { get; set; }
        public Nullable<System.TimeSpan> seferSaati { get; set; }
        public Nullable<System.DateTime> seferTarihi { get; set; }
        public string seferKalkis { get; set; }
        public string seferVaris { get; set; }
        public Nullable<int> aracId { get; set; }
        public Nullable<int> sehirId { get; set; }
    
        public virtual Araclar Araclar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Biletler> Biletler { get; set; }
        public virtual Sehirler Sehirler { get; set; }
    }
}