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
    
    public partial class WFDeliveryContract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WFDeliveryContract()
        {
            this.WFContractInfo = new HashSet<WFContractInfo>();
        }
    
        public int WFDeliveryContractId { get; set; }
        public Nullable<int> InstrumentId { get; set; }
        public Nullable<int> ExchangeId { get; set; }
        public bool IsStandard { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFContractInfo> WFContractInfo { get; set; }
    }
}