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
    
    public partial class WFLoginHistory
    {
        public int WFLoginHistoryId { get; set; }
        public Nullable<int> WFUserId { get; set; }
        public string IP { get; set; }
        public Nullable<System.DateTime> LoginTime { get; set; }
        public Nullable<bool> IsSuccess { get; set; }
        public string DeviceInfo { get; set; }
    }
}
