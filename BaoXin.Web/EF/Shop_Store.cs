//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaoXin.Web.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shop_Store
    {
        public int StoreId { get; set; }
        public string StoreNum { get; set; }
        public string StoreName { get; set; }
        public Nullable<int> PhotoId { get; set; }
        public string LicenseNumber { get; set; }
        public string Agreement { get; set; }
        public Nullable<bool> BoolYX { get; set; }
        public string StoreUser { get; set; }
        public Nullable<int> PeopleId { get; set; }
        public Nullable<bool> BoolPass { get; set; }
        public Nullable<System.DateTime> AddTime { get; set; }
        public Nullable<System.DateTime> PassTime { get; set; }
        public Nullable<int> StoreOrde { get; set; }
    }
}