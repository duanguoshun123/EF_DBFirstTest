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
    
    public partial class WFOtherBill
    {
        public int WFOtherBillId { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public Nullable<int> ApprovalTemplate { get; set; }
        public Nullable<int> SalerId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<short> OperationType { get; set; }
        public Nullable<short> ApprovalStatus { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> Creator { get; set; }
        public Nullable<int> CorporationId { get; set; }
        public Nullable<int> CommodityId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<int> SpotAmountType { get; set; }
        public Nullable<bool> IsBuy { get; set; }
        public Nullable<short> TransactionType { get; set; }
        public short TradeType { get; set; }
        public Nullable<int> WFBusinessApprovalFlowTemplateId { get; set; }
        public Nullable<int> ApprovalType { get; set; }
        public bool IsDeleted { get; set; }
    }
}
