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
    
    public partial class WFCodeCustomization
    {
        public int WFCodeCustomizationId { get; set; }
        public int WFCodeTemplateDetailId { get; set; }
        public string Value { get; set; }
        public string Text { get; set; }
    
        public virtual WFCodeTemplateDetail WFCodeTemplateDetail { get; set; }
    }
}
