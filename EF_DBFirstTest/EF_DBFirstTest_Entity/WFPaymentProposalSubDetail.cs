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
    
    public partial class WFPaymentProposalSubDetail
    {
        public int WFPaymentProposalSubDetailId { get; set; }
        public Nullable<int> WFPaymentProposalDetailId { get; set; }
        public Nullable<int> SubDetailType { get; set; }
        public Nullable<int> ObjectType { get; set; }
        public Nullable<int> ObjectId { get; set; }
        public Nullable<int> ObjectCurrencyId { get; set; }
        public Nullable<decimal> ObjectCurrencyFutureValue { get; set; }
        public Nullable<int> SapAmountTransaction { get; set; }
    
        public virtual WFPaymentProposalDetail WFPaymentProposalDetail { get; set; }
    }
}
