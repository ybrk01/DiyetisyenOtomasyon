//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiyetProgrami.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiyetisyenTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiyetisyenTbl()
        {
            this.KisiTbl = new HashSet<KisiTbl>();
        }
    
        public int diyetisyenID { get; set; }
        public string diyetisyenAdi { get; set; }
        public string diyetisyenSifre { get; set; }
        public bool diyetisyenTipi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KisiTbl> KisiTbl { get; set; }
    }
}