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
    
    public partial class WFCurrency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WFCurrency()
        {
            this.WFInstrumentCategory = new HashSet<WFInstrumentCategory>();
            this.WFPriceInfo = new HashSet<WFPriceInfo>();
        }
    
        public int WFCurrencyId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public string EnglishName { get; set; }
        public string Symbol { get; set; }
        public Nullable<int> TradingFlag { get; set; }
        public Nullable<int> DomesticIndex { get; set; }
        public Nullable<int> InterIndex { get; set; }
        public string ShortName { get; set; }
        public Nullable<short> Scale { get; set; }
        public string AccountingName { get; set; }
        public System.DateTime CreationTime { get; set; }
        public System.DateTime LastManipulationTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFInstrumentCategory> WFInstrumentCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFPriceInfo> WFPriceInfo { get; set; }
    }
}