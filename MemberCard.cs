//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JPGame
{
    using System;
    using System.Collections.Generic;
    
    public partial class MemberCard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MemberCard()
        {
            this.Accounts = new HashSet<Account>();
            this.MemberCardChargeRecords = new HashSet<MemberCardChargeRecord>();
        }
    
        public string MemberCardID { get; set; }
        public Nullable<int> MemberCardLevelID { get; set; }
        public Nullable<double> Points { get; set; }
        public Nullable<double> Balance { get; set; }
        public string ModifyBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> MultipliedMoney { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberCardChargeRecord> MemberCardChargeRecords { get; set; }
        public virtual MemberCardLevel MemberCardLevel { get; set; }
    }
}
