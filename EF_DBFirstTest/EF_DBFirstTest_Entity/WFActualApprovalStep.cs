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
    
    public partial class WFActualApprovalStep
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WFActualApprovalStep()
        {
            this.WFActualApprovalStepUser = new HashSet<WFActualApprovalStepUser>();
            this.WFActualStepCondition = new HashSet<WFActualStepCondition>();
            this.WFActualStepCondition1 = new HashSet<WFActualStepCondition>();
            this.WFActuaStepAction = new HashSet<WFActuaStepAction>();
            this.WFApprovalWorkflowLog = new HashSet<WFApprovalWorkflowLog>();
        }
    
        public int WFActualApprovalStepId { get; set; }
        public Nullable<int> WFActualApprovalWFId { get; set; }
        public Nullable<int> WFActualApproverId { get; set; }
        public Nullable<bool> IsHappened { get; set; }
        public Nullable<int> StepIndex { get; set; }
        public Nullable<int> ParentStepId { get; set; }
        public Nullable<short> StepType { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public Nullable<int> ActualNextStepId { get; set; }
        public Nullable<short> StepResult { get; set; }
    
        public virtual WFActualApprovalWF WFActualApprovalWF { get; set; }
        public virtual WFActualApprover WFActualApprover { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFActualApprovalStepUser> WFActualApprovalStepUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFActualStepCondition> WFActualStepCondition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFActualStepCondition> WFActualStepCondition1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFActuaStepAction> WFActuaStepAction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFApprovalWorkflowLog> WFApprovalWorkflowLog { get; set; }
    }
}
