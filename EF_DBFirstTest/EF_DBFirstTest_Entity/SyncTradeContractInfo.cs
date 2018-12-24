//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_DBFirstTest_Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class SyncTradeContractInfo
    {
        public long Id { get; set; }
        public Nullable<int> ContractId { get; set; }
        public string ContractNumber { get; set; }
        public string ERPContractNumber { get; set; }
        public string Direction { get; set; }
        public string TradeType { get; set; }
        public string ContractType { get; set; }
        public string TransactionType { get; set; }
        public Nullable<int> ObjectId { get; set; }
        public string AccountingEntity { get; set; }
        public string Corporation { get; set; }
        public string Counterparty { get; set; }
        public string Commodity { get; set; }
        public Nullable<decimal> Volume { get; set; }
        public string Unit { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> MortgageInterestRate { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public bool Unavailable { get; set; }
        public Nullable<System.DateTime> SignDate { get; set; }
        public Nullable<System.DateTime> CommodityCompletedDate { get; set; }
        public Nullable<System.DateTime> PriceCompletedDate { get; set; }
        public Nullable<System.DateTime> AmountCompletedDate { get; set; }
        public Nullable<System.DateTime> InvoiceCompletedDate { get; set; }
        public Nullable<System.DateTime> ContractCompletedDate { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.DateTime> LastUpdateTime { get; set; }
        public Nullable<decimal> UnitExchangeRate { get; set; }
        public string PricingUnit { get; set; }
        public string PricingCurrency { get; set; }
        public Nullable<decimal> PricingTempExchangeRate { get; set; }
        public Nullable<decimal> PricingFinalExchangeRate { get; set; }
        public Nullable<System.DateTime> FinalExchangeRateConfirmDate { get; set; }
        public Nullable<int> PlegeDetailNumber { get; set; }
        public string Department { get; set; }
        public string Saler { get; set; }
        public string PriceMarket { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string PurposeType { get; set; }
        public Nullable<decimal> MortgageRate { get; set; }
    }
}
