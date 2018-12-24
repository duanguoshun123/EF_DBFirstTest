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
    
    public partial class WFTradePricingMatchRecord
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WFTradePricingMatchRecord()
        {
            this.WFTradePricingMatchDetail = new HashSet<WFTradePricingMatchDetail>();
        }
    
        public int WFTradePricingMatchRecordId { get; set; }
        public Nullable<decimal> VirtualHedgePrice { get; set; }
        public int CreatorId { get; set; }
        public System.DateTime CreationTime { get; set; }
        public bool IsDeleted { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> LastManipulateTime { get; set; }
        public Nullable<int> CorporationId { get; set; }
        public Nullable<int> AccountingEntityId { get; set; }
        public Nullable<int> CommodityTypeId { get; set; }
        public Nullable<System.DateTime> StartPringDate { get; set; }
        public Nullable<System.DateTime> EndPricingDate { get; set; }
        public Nullable<bool> IsCrossPricingDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFTradePricingMatchDetail> WFTradePricingMatchDetail { get; set; }
    }
}