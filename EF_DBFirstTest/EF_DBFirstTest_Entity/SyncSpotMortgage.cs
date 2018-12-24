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
    
    public partial class SyncSpotMortgage
    {
        public int Id { get; set; }
        public string MortgageSequenceNumber { get; set; }
        public Nullable<System.DateTime> TradeDate { get; set; }
        public string AccountingEntity { get; set; }
        public string Corporation { get; set; }
        public string Currency { get; set; }
        public string Commodity { get; set; }
        public string Counterparty { get; set; }
        public string MortgageDirection { get; set; }
        public Nullable<decimal> MortgageVolume { get; set; }
        public Nullable<decimal> MortgageRate { get; set; }
        public Nullable<decimal> Volume { get; set; }
        public Nullable<decimal> MortgagePrice { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> MortgageInterestRate { get; set; }
        public Nullable<decimal> Interest { get; set; }
        public string RedemptionStatus { get; set; }
        public Nullable<System.DateTime> LastUpdateTime { get; set; }
        public Nullable<int> ObjectType { get; set; }
        public Nullable<int> ObjectId { get; set; }
        public string Unit { get; set; }
    }
}
