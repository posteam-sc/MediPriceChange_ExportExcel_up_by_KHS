//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediPriceChange
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoleManagement
    {
        public int Id { get; set; }
        public string RuleFeature { get; set; }
        public int UserRoleId { get; set; }
        public bool IsAllowed { get; set; }
    
        public virtual UserRole UserRole { get; set; }
    }
}
