//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaoXin.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChatInfo
    {
        public int id { get; set; }
        public string user_from { get; set; }
        public string user_to { get; set; }
        public string content { get; set; }
        public string expression { get; set; }
        public string color { get; set; }
        public Nullable<bool> ispublic { get; set; }
        public Nullable<System.DateTime> sendtime { get; set; }
        public Nullable<bool> IsOpen { get; set; }
    }
}
