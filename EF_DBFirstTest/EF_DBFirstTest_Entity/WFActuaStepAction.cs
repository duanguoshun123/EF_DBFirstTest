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
    
    public partial class WFActuaStepAction
    {
        public int WFActuaStepActionId { get; set; }
        public Nullable<int> WFActualApproverId { get; set; }
        public Nullable<int> WFActualApprovalStepId { get; set; }
        public Nullable<short> ActionType { get; set; }
        public Nullable<bool> IsPreStepAction { get; set; }
        public Nullable<short> StepResultType { get; set; }
    
        public virtual WFActualApprovalStep WFActualApprovalStep { get; set; }
        public virtual WFActualApprover WFActualApprover { get; set; }
    }
}
