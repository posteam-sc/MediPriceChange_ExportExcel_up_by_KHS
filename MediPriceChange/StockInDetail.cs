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
    
    public partial class StockInDetail
    {
        public long Id { get; set; }
        public Nullable<long> StockInHeaderId { get; set; }
        public Nullable<long> ProductId { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<System.DateTime> experiedDate { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual StockInHeader StockInHeader { get; set; }
    }
}
