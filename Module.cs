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
    
    public partial class Module
    {
        public int ModulesID { get; set; }
        public string Address { get; set; }
        public string Hotline { get; set; }
        public string Email { get; set; }
        public string AboutMe { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual User CreateUser { get; set; }
        public virtual User ModifyUser { get; set; }
    }
}
