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
    
    public partial class WFPostingInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WFPostingInfo()
        {
            this.WFPostingInfoDetail = new HashSet<WFPostingInfoDetail>();
        }
    
        public int WFPostingInfoId { get; set; }
        public decimal Weight { get; set; }
        public int UnitId { get; set; }
        public int ObjectId { get; set; }
        public System.DateTime PostingTime { get; set; }
        public string Note { get; set; }
        public bool IsDeleted { get; set; }
        public int ObjectType { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int Creator { get; set; }
        public Nullable<int> BusinessType { get; set; }
        public Nullable<int> PropertyType { get; set; }
        public Nullable<int> SAPStatus { get; set; }
        public bool InitialPosted { get; set; }
        public Nullable<System.DateTime> EntryOutDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFPostingInfoDetail> WFPostingInfoDetail { get; set; }
    }
}
