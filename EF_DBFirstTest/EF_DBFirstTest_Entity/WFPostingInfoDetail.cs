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
    
    public partial class WFPostingInfoDetail
    {
        public int WFPostingInfoDetailId { get; set; }
        public Nullable<int> WFPostingInfoId { get; set; }
        public int ObjectType { get; set; }
        public int ObjectId { get; set; }
        public decimal PostingWeight { get; set; }
        public Nullable<decimal> HappenedInvoiceWeight { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Nullable<int> SpecificationId { get; set; }
        public string GroupCode { get; set; }
        public string StorageCode { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int CreatorId { get; set; }
        public Nullable<int> WFFinancialBatchId { get; set; }
    
        public virtual WFFinancialBatch WFFinancialBatch { get; set; }
        public virtual WFPostingInfo WFPostingInfo { get; set; }
    }
}
