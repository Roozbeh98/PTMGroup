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
    
    public partial class Tbl_Login
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Login()
        {
            this.Tbl_Client = new HashSet<Tbl_Client>();
            this.Tbl_Document = new HashSet<Tbl_Document>();
            this.Tbl_LoginToken = new HashSet<Tbl_LoginToken>();
            this.Tbl_Partner = new HashSet<Tbl_Partner>();
            this.Tbl_Product = new HashSet<Tbl_Product>();
            this.Tbl_Slider = new HashSet<Tbl_Slider>();
            this.Tbl_Video = new HashSet<Tbl_Video>();
        }
    
        public int Login_ID { get; set; }
        public System.Guid Login_Guid { get; set; }
        public Nullable<int> Login_UserID { get; set; }
        public int Login_BaseRoleID { get; set; }
        public string Login_Mobile { get; set; }
        public bool Login_MobileConfirmed { get; set; }
        public string Login_Email { get; set; }
        public string Login_PasswordHash { get; set; }
        public string Login_PasswordSalt { get; set; }
        public bool Login_IsActive { get; set; }
        public bool Login_IsBan { get; set; }
        public bool Login_IsDelete { get; set; }
        public System.DateTime Login_CreateDate { get; set; }
        public System.DateTime Login_ModifyDate { get; set; }
    
        public virtual Tbl_BaseRole Tbl_BaseRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Client> Tbl_Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Document> Tbl_Document { get; set; }
        public virtual Tbl_User Tbl_User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_LoginToken> Tbl_LoginToken { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Partner> Tbl_Partner { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Product> Tbl_Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Slider> Tbl_Slider { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Video> Tbl_Video { get; set; }
    }
}
