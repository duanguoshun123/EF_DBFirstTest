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
    
    public partial class WFStorageAssistantMeasureInfo
    {
        public int WFWarehouseStorageId { get; set; }
        public decimal Quantity { get; set; }
        public int UnitId { get; set; }
        public int WFStorageAssistantMeasureInfoId { get; set; }
        public Nullable<decimal> PledgeQuantity { get; set; }
        public Nullable<decimal> TempHoldQuantity { get; set; }
        public Nullable<decimal> AvailableQuantity { get; set; }
        public int QuantityId { get; set; }
        public Nullable<int> ComponentId { get; set; }
        public Nullable<int> PhysicalCategory { get; set; }
    
        public virtual WFWarehouseStorage WFWarehouseStorage { get; set; }
    }
}