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
    
    public partial class Tbl_SMSProviderConfiguration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_SMSProviderConfiguration()
        {
            this.Tbl_SMSProviderNumber = new HashSet<Tbl_SMSProviderNumber>();
            this.Tbl_SMSSetting = new HashSet<Tbl_SMSSetting>();
        }
    
        public int SPC_ID { get; set; }
        public System.Guid SPC_Guid { get; set; }
        public string SPC_Username { get; set; }
        public string SPC_Password { get; set; }
        public string SPC_ApiKey { get; set; }
        public System.DateTime SPC_CreationDate { get; set; }
        public System.DateTime SPC_ModifiedDate { get; set; }
        public bool SPC_IsDelete { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_SMSProviderNumber> Tbl_SMSProviderNumber { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_SMSSetting> Tbl_SMSSetting { get; set; }
    }
}
