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
    
    public partial class Tbl_ContactUs
    {
        public int CU_ID { get; set; }
        public System.Guid CU_Guid { get; set; }
        public string CU_Name { get; set; }
        public string CU_Email { get; set; }
        public string CU_Subject { get; set; }
        public string CU_Massage { get; set; }
        public System.DateTime CU_CreateData { get; set; }
        public bool CU_Read { get; set; }
    }
}
