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
    
    public partial class MemberType
    {
        public MemberType()
        {
            this.MemberCardRules = new HashSet<MemberCardRule>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    
        public virtual ICollection<MemberCardRule> MemberCardRules { get; set; }
    }
}
