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
    
    public partial class WFGeneralModificationDetail
    {
        public int WFGeneralModificationDetailId { get; set; }
        public Nullable<int> WFGeneralModificationId { get; set; }
        public int TableType { get; set; }
        public int ObjectId { get; set; }
        public string ColumnName { get; set; }
        public string OldValue { get; set; }
        public string OldDisplayValue { get; set; }
        public string NewValue { get; set; }
        public string NewDisplayValue { get; set; }
        public string Note { get; set; }
    
        public virtual WFGeneralModification WFGeneralModification { get; set; }
    }
}