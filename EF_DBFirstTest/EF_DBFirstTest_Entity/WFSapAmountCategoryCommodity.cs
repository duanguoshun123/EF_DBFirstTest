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
    
    public partial class WFSapAmountCategoryCommodity
    {
        public int WFSapAmountCategoryCommodityId { get; set; }
        public Nullable<int> WFSapConfigurationId { get; set; }
        public Nullable<int> WFCommodityId { get; set; }
    
        public virtual WFSapConfiguration WFSapConfiguration { get; set; }
    }
}
