﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BaoXinEntities : DbContext
    {
        public BaoXinEntities()
            : base("name=BaoXinEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<SendFile> SendFile { get; set; }
        public DbSet<SpeechInfo> SpeechInfo { get; set; }
        public DbSet<UsersFriend> UsersFriend { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<ChatInfo> ChatInfo { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Shop_Photo> Shop_Photo { get; set; }
        public DbSet<Shop_Store> Shop_Store { get; set; }
    }
}
