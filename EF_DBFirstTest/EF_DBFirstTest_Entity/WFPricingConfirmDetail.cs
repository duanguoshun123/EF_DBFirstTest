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
    
    public partial class WFPricingConfirmDetail
    {
        public int WFPricingConfirmDetailId { get; set; }
        public Nullable<int> WFTradePricingId { get; set; }
        public decimal ConfirmCargoQuantity { get; set; }
        public Nullable<int> ConfirmUserId { get; set; }
        public Nullable<System.DateTime> LastManipulationTime { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual WFTradePricing WFTradePricing { get; set; }
    }
}
