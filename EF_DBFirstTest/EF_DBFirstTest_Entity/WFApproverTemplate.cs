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
    
    public partial class WFApproverTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WFApproverTemplate()
        {
            this.WFApprovalWorkflowStepTemplate = new HashSet<WFApprovalWorkflowStepTemplate>();
            this.WFApprovalWorkflowTemplateRole = new HashSet<WFApprovalWorkflowTemplateRole>();
            this.WFRoleConditionConfiguration = new HashSet<WFRoleConditionConfiguration>();
            this.WFStepActionTemplate = new HashSet<WFStepActionTemplate>();
        }
    
        public int WFApproverTemplateId { get; set; }
        public Nullable<short> ApproverType { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFApprovalWorkflowStepTemplate> WFApprovalWorkflowStepTemplate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFApprovalWorkflowTemplateRole> WFApprovalWorkflowTemplateRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFRoleConditionConfiguration> WFRoleConditionConfiguration { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFStepActionTemplate> WFStepActionTemplate { get; set; }
    }
}
