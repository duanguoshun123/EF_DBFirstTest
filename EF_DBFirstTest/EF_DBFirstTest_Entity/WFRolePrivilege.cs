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
    
    public partial class WFRolePrivilege
    {
        public int WFRolePrivilegeId { get; set; }
        public int Privilege { get; set; }
        public int WFRoleInfoId { get; set; }
        public Nullable<int> CorporationId { get; set; }
        public Nullable<short> TradeType { get; set; }
        public Nullable<int> Module { get; set; }
    
        public virtual WFRoleInfo WFRoleInfo { get; set; }
    }
}
