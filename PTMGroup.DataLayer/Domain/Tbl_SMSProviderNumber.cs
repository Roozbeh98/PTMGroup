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
    
    public partial class Tbl_SMSProviderNumber
    {
        public int SPN_ID { get; set; }
        public System.Guid SPN_Guid { get; set; }
        public int SPN_SPCID { get; set; }
        public string SPN_Number { get; set; }
        public System.DateTime SPN_CreationDate { get; set; }
        public System.DateTime SPN_ModifiedDate { get; set; }
        public bool SPN_IsDelete { get; set; }
    
        public virtual Tbl_SMSProviderConfiguration Tbl_SMSProviderConfiguration { get; set; }
    }
}