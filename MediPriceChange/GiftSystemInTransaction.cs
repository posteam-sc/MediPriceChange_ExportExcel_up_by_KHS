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
    
    public partial class GiftSystemInTransaction
    {
        public int Id { get; set; }
        public int GiftSystemId { get; set; }
        public string TransactionId { get; set; }
    
        public virtual GiftSystem GiftSystem { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
