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
    
    public partial class UserRole
    {
        public UserRole()
        {
            this.RoleManagements = new HashSet<RoleManagement>();
            this.Users = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public string RoleName { get; set; }
    
        public virtual ICollection<RoleManagement> RoleManagements { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
