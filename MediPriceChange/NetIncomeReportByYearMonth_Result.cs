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
    
    public partial class NetIncomeReportByYearMonth_Result
    {
        public long Id { get; set; }
        public long Price { get; set; }
        public string ProductCode { get; set; }
        public Nullable<int> Purchase { get; set; }
        public Nullable<int> Refund { get; set; }
        public Nullable<int> Sale { get; set; }
        public Nullable<int> AdjustmentStockIn { get; set; }
        public Nullable<int> AdjustmentStockOut { get; set; }
        public Nullable<int> Consignment { get; set; }
        public Nullable<int> ConversionStockIn { get; set; }
        public Nullable<int> ConversionStockOut { get; set; }
        public Nullable<int> StockIn { get; set; }
        public Nullable<int> StockOut { get; set; }
        public Nullable<int> Opening { get; set; }
        public Nullable<int> Closing { get; set; }
    }
}
