﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Phoebe.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PhoebeContext : DbContext
    {
        public PhoebeContext()
            : base("name=PhoebeContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GroupCustomer> GroupCustomers { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<ScatterCustomer> ScatterCustomers { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<FirstCategory> FirstCategories { get; set; }
        public virtual DbSet<SecondCategory> SecondCategories { get; set; }
        public virtual DbSet<Cargo> Cargoes { get; set; }
    }
}
