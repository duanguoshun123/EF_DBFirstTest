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
    
    public partial class WFApprovalWorkflowTemplateRole
    {
        public Nullable<int> WFApproverTemplateId { get; set; }
        public Nullable<int> WFApprovalWorkflowTemplateId { get; set; }
        public int WFApprovalWorkflowTemplateRoleId { get; set; }
        public Nullable<short> UserType { get; set; }
    
        public virtual WFApprovalWorkflowTemplate WFApprovalWorkflowTemplate { get; set; }
        public virtual WFApproverTemplate WFApproverTemplate { get; set; }
    }
}
