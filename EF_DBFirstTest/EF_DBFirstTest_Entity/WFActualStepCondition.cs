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
    
    public partial class WFActualStepCondition
    {
        public int WFActualStepConditionId { get; set; }
        public Nullable<int> SourceWFActualApprovalStepId { get; set; }
        public Nullable<int> TargetWFActualApprovalStepId { get; set; }
        public string Condition { get; set; }
        public Nullable<short> Action { get; set; }
        public Nullable<short> Result { get; set; }
        public string ConditionNote { get; set; }
        public Nullable<short> MemberPassType { get; set; }
    
        public virtual WFActualApprovalStep WFActualApprovalStep { get; set; }
        public virtual WFActualApprovalStep WFActualApprovalStep1 { get; set; }
    }
}