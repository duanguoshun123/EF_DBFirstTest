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
    
    public partial class WFDeliveryInDetailQuantity
    {
        public int WFDeliveryInDetailQuantityId { get; set; }
        public Nullable<int> WFWarehouseEntryRecordDetailId { get; set; }
        public int QuantityTypeId { get; set; }
        public Nullable<int> PhysicalCategory { get; set; }
        public int UnitId { get; set; }
        public Nullable<int> ComponentId { get; set; }
        public decimal Quantity { get; set; }
        public Nullable<decimal> ActualQuantity { get; set; }
    
        public virtual WFWarehouseEntryRecordDetail WFWarehouseEntryRecordDetail { get; set; }
    }
}
