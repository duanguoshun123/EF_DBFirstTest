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
    
    public partial class WFInstrumentSettlementPrice
    {
        public int WFInstrumentSettlementPriceId { get; set; }
        public Nullable<int> InstrumentId { get; set; }
        public Nullable<System.DateTime> PriceDate { get; set; }
        public Nullable<decimal> SettlementPrice { get; set; }
        public Nullable<decimal> TradeWeight { get; set; }
        public Nullable<int> PriceMarket { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<decimal> FullDaySettlementPrice { get; set; }
        public Nullable<decimal> FullDayTradeWeight { get; set; }
        public Nullable<int> CommodityId { get; set; }
        public Nullable<System.DateTime> LastUpdatedTime { get; set; }
        public int MarketQuotePriceType { get; set; }
        public Nullable<decimal> FixingPrice { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<decimal> PremiumDiscount { get; set; }
    
        public virtual WFInstrument WFInstrument { get; set; }
    }
}