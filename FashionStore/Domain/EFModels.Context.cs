﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EFDBContext : DbContext
    {
        public EFDBContext()
            : base("name=EFDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AttrContents> AttrContents { get; set; }
        public DbSet<AttrTitles> AttrTitles { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartProducts> CartProducts { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<FiltCatagories> FiltCatagories { get; set; }
        public DbSet<NavCatagories> NavCatagories { get; set; }
        public DbSet<OrderProducts> OrderProducts { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<PaymentMethods> PaymentMethods { get; set; }
        public DbSet<Pictures> Pictures { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Shipping> Shipping { get; set; }
        public DbSet<ShippingMethods> ShippingMethods { get; set; }
        public DbSet<Sizes> Sizes { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<BrandCata> BrandCata { get; set; }
    }
}
