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
    
    public partial class WFWarehouseStorageHistory
    {
        public int WFWarehouseStorageHistoryId { get; set; }
        public System.DateTime StorageDate { get; set; }
        public int CorporationId { get; set; }
        public int AccountingEntityId { get; set; }
        public int WarehouseId { get; set; }
        public int CommodityId { get; set; }
        public int BrandId { get; set; }
        public int SpecificationId { get; set; }
        public short CommodityType { get; set; }
        public short CommodityStatus { get; set; }
        public System.DateTime LatestModifiedDate { get; set; }
        public string Currency { get; set; }
        public decimal Weight { get; set; }
        public Nullable<int> ExchangeId { get; set; }
        public short TradeType { get; set; }
        public int UnitId { get; set; }
        public Nullable<decimal> InQuantity { get; set; }
        public Nullable<decimal> OutQuantity { get; set; }
    
        public virtual WFCommodity WFCommodity { get; set; }
    }
}