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
    
    public partial class Transaction
    {
        public Transaction()
        {
            this.DeleteLogs = new HashSet<DeleteLog>();
            this.ExchangeRateForTransactions = new HashSet<ExchangeRateForTransaction>();
            this.GiftCardInTransactions = new HashSet<GiftCardInTransaction>();
            this.GiftSystemInTransactions = new HashSet<GiftSystemInTransaction>();
            this.Transaction1 = new HashSet<Transaction>();
            this.TransactionDetails = new HashSet<TransactionDetail>();
            this.UsePrePaidDebts = new HashSet<UsePrePaidDebt>();
            this.UsePrePaidDebts1 = new HashSet<UsePrePaidDebt>();
        }
    
        public string Id { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> CounterId { get; set; }
        public string Type { get; set; }
        public Nullable<bool> IsPaid { get; set; }
        public Nullable<bool> IsComplete { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> PaymentTypeId { get; set; }
        public Nullable<int> TaxAmount { get; set; }
        public Nullable<int> DiscountAmount { get; set; }
        public Nullable<long> TotalAmount { get; set; }
        public Nullable<long> RecieveAmount { get; set; }
        public string ParentId { get; set; }
        public Nullable<int> GiftCardId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<decimal> MCDiscountAmt { get; set; }
        public Nullable<decimal> BDDiscountAmt { get; set; }
        public Nullable<int> MemberTypeId { get; set; }
        public Nullable<decimal> MCDiscountPercent { get; set; }
        public Nullable<int> ReceivedCurrencyId { get; set; }
        public Nullable<bool> IsSettlement { get; set; }
        public string TranVouNos { get; set; }
        public Nullable<bool> IsWholeSale { get; set; }
        public Nullable<decimal> GiftCardAmount { get; set; }
        public Nullable<int> ShopId { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string Note { get; set; }
        public Nullable<int> TableIdOrQue { get; set; }
        public Nullable<int> ServiceFee { get; set; }
    
        public virtual Counter Counter { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<DeleteLog> DeleteLogs { get; set; }
        public virtual ICollection<ExchangeRateForTransaction> ExchangeRateForTransactions { get; set; }
        public virtual GiftCard GiftCard { get; set; }
        public virtual ICollection<GiftCardInTransaction> GiftCardInTransactions { get; set; }
        public virtual ICollection<GiftSystemInTransaction> GiftSystemInTransactions { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual ICollection<Transaction> Transaction1 { get; set; }
        public virtual Transaction Transaction2 { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
        public virtual ICollection<UsePrePaidDebt> UsePrePaidDebts { get; set; }
        public virtual ICollection<UsePrePaidDebt> UsePrePaidDebts1 { get; set; }
    }
}
