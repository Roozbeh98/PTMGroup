//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PTMGroup.DataLayer.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_CodeGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_CodeGroup()
        {
            this.Tbl_Code = new HashSet<Tbl_Code>();
        }
    
        public int CG_ID { get; set; }
        public System.Guid CG_Guid { get; set; }
        public string CG_Name { get; set; }
        public string CG_Display { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Code> Tbl_Code { get; set; }
    }
}
