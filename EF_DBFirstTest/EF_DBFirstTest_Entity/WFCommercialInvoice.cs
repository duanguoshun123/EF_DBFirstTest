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
    
    public partial class WFCommercialInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WFCommercialInvoice()
        {
            this.WFInvoiceRecord1 = new HashSet<WFInvoiceRecord>();
            this.WFCommercialInvoice1 = new HashSet<WFCommercialInvoice>();
        }
    
        public int WFInvoiceRecordId { get; set; }
        public Nullable<int> FinalInvoiceRecordId { get; set; }
        public bool IsBalance { get; set; }
        public bool IsFinal { get; set; }
        public Nullable<decimal> TotalGrossWeight { get; set; }
        public Nullable<int> TotalBundles { get; set; }
        public Nullable<decimal> AvgPrice { get; set; }
        public Nullable<decimal> TotalHappendAmount { get; set; }
        public Nullable<int> BeneficiaryBankAccountId { get; set; }
        public Nullable<int> CorrespondentBank { get; set; }
        public Nullable<int> WFContractInfoId { get; set; }
        public Nullable<decimal> FinalTotalAmount { get; set; }
        public Nullable<decimal> FinalDiscountCost { get; set; }
        public Nullable<decimal> TotalTempInvoicesHappendAmount { get; set; }
        public Nullable<short> ApprovalStatus { get; set; }
        public Nullable<int> PaymentCurrencyId { get; set; }
        public Nullable<decimal> PaymentCurrencyTotalAmount { get; set; }
        public Nullable<decimal> PaymentCurrencyAvgPrice { get; set; }
        public Nullable<int> PaymentExchangeRateId { get; set; }
        public Nullable<decimal> HappenedWeight { get; set; }
        public int BusinessSetting { get; set; }
    
        public virtual WFContractInfo WFContractInfo { get; set; }
        public virtual WFExchangeRate WFExchangeRate { get; set; }
        public virtual WFInvoiceRecord WFInvoiceRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFInvoiceRecord> WFInvoiceRecord1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFCommercialInvoice> WFCommercialInvoice1 { get; set; }
        public virtual WFCommercialInvoice WFCommercialInvoice2 { get; set; }
    }
}