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
    
    public partial class WFExchangeBill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WFExchangeBill()
        {
            this.WFAmountRecord = new HashSet<WFAmountRecord>();
        }
    
        public int WFExchangeBillId { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> WFLetterOfCreditId { get; set; }
        public int Type { get; set; }
        public string Code { get; set; }
        public int CurrencyId { get; set; }
        public decimal Amount { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<int> DrawerId { get; set; }
        public Nullable<int> DraweeId { get; set; }
        public Nullable<int> PayeeId { get; set; }
        public Nullable<int> HolderId { get; set; }
        public Nullable<bool> IsTransferable { get; set; }
        public int BillAmountUseStatus { get; set; }
        public Nullable<int> CorporationId { get; set; }
        public Nullable<int> AccountingEntityId { get; set; }
        public string Notes { get; set; }
        public short PurposeStatus { get; set; }
        public int BillUseStatus { get; set; }
        public bool IsDrawer { get; set; }
        public bool IsRights { get; set; }
        public bool IsObligation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFAmountRecord> WFAmountRecord { get; set; }
        public virtual WFLetterOfCredit WFLetterOfCredit { get; set; }
    }
}
