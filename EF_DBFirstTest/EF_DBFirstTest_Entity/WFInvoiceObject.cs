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
    
    public partial class WFInvoiceObject
    {
        public int WFInvoiceObjectId { get; set; }
        public Nullable<int> WFInvoiceRecordId { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public string Note { get; set; }
        public Nullable<int> ObjectType { get; set; }
        public Nullable<int> ObjectId { get; set; }
        public Nullable<System.Guid> WholeInvoiceObjectUid { get; set; }
        public Nullable<int> ObjectCurrencyId { get; set; }
        public Nullable<int> ExchangeRateId { get; set; }
        public Nullable<decimal> ObjectCurrencyPresentValue { get; set; }
        public Nullable<decimal> ObjectCurrencyFutureValue { get; set; }
        public Nullable<decimal> FinalObjectCurrencyPresentValue { get; set; }
        public Nullable<decimal> FinalObjectCurrencyFutureValue { get; set; }
        public Nullable<int> WFContractInvoiceId { get; set; }
    
        public virtual WFContractInvoice WFContractInvoice { get; set; }
        public virtual WFInvoiceRecord WFInvoiceRecord { get; set; }
    }
}
