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
    
    public partial class WFExchangeRate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WFExchangeRate()
        {
            this.WFCommercialInvoice = new HashSet<WFCommercialInvoice>();
        }
    
        public int WFExchangeRateId { get; set; }
        public System.DateTime LastModifiedTime { get; set; }
        public int DatasourceType { get; set; }
        public Nullable<int> DatasourceId { get; set; }
        public System.DateTime PriceDate { get; set; }
        public int WFCurrencyPairId { get; set; }
        public decimal BaseUnitAmount { get; set; }
        public decimal CounterAmount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFCommercialInvoice> WFCommercialInvoice { get; set; }
        public virtual WFCurrencyPair WFCurrencyPair { get; set; }
    }
}