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
    
    public partial class WFContractFee
    {
        public int WFContractFeeId { get; set; }
        public Nullable<int> WFContractInfoId { get; set; }
        public Nullable<int> WFFeeRecordId { get; set; }
        public Nullable<int> WFSystemFeeId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> CommodityId { get; set; }
        public string FeeName { get; set; }
        public int CurrencyId { get; set; }
        public string Note { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreatorId { get; set; }
        public bool IsAdjust { get; set; }
        public bool IsSystemAutoGenerate { get; set; }
        public Nullable<int> FeeConfigurationId { get; set; }
        public Nullable<int> WarehouseStorageId { get; set; }
        public bool HasPaid { get; set; }
        public Nullable<int> FeeType { get; set; }
        public Nullable<int> FinanceAccount { get; set; }
        public Nullable<System.DateTime> FinanceTime { get; set; }
        public Nullable<short> Type { get; set; }
        public Nullable<int> CorporationId { get; set; }
        public short TradeType { get; set; }
    
        public virtual WFContractInfo WFContractInfo { get; set; }
        public virtual WFFeeRecord WFFeeRecord { get; set; }
        public virtual WFSystemFee WFSystemFee { get; set; }
    }
}