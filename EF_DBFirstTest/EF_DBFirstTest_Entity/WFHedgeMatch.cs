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
    
    public partial class WFHedgeMatch
    {
        public int WFHedgeMatchId { get; set; }
        public Nullable<int> TradePricingId { get; set; }
        public Nullable<int> FutureTradeRecordId { get; set; }
        public int HedgeMatchType { get; set; }
        public decimal MatchCargoQuantity { get; set; }
        public Nullable<int> CreatorId { get; set; }
        public Nullable<System.DateTime> CreationTime { get; set; }
        public Nullable<decimal> VirtualHedgePrice { get; set; }
    }
}