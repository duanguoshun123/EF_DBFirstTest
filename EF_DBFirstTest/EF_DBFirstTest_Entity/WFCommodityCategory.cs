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
    
    public partial class WFCommodityCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WFCommodityCategory()
        {
            this.WFCommodityType = new HashSet<WFCommodityType>();
        }
    
        public int WFCommodityCategoryId { get; set; }
        public string QctKey { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreationTime { get; set; }
        public System.DateTime LastManipulationTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFCommodityType> WFCommodityType { get; set; }
    }
}
