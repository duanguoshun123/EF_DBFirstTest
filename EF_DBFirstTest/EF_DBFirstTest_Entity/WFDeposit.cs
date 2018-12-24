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
    
    public partial class WFDeposit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WFDeposit()
        {
            this.WFDepositContract = new HashSet<WFDepositContract>();
        }
    
        public int WFDepositId { get; set; }
        public int CustomerId { get; set; }
        public int DepositType { get; set; }
        public bool IsPay { get; set; }
        public int CurrencyId { get; set; }
        public string Notes { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountHappened { get; set; }
        public decimal AmountReturned { get; set; }
        public decimal AmountSettled { get; set; }
        public Nullable<decimal> AmountRemained { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<int> Saler { get; set; }
        public Nullable<int> Creator { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public System.DateTime ModifiedTime { get; set; }
        public Nullable<int> CorporationId { get; set; }
        public int TradeType { get; set; }
        public Nullable<int> AccountingEntityId { get; set; }
        public Nullable<int> CommodityId { get; set; }
        public Nullable<int> MigrateFromWFAmountRecordId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFDepositContract> WFDepositContract { get; set; }
    }
}