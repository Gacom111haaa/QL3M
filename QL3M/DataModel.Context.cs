﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL3M
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QL3MEntities : DbContext
    {
        public QL3MEntities()
            : base("name=QL3MEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<GoodsInfo> GoodsInfoes { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<InvoiceFileAttach> InvoiceFileAttaches { get; set; }
        public virtual DbSet<PrivateInvoice> PrivateInvoices { get; set; }
        public virtual DbSet<PrivateVault> PrivateVaults { get; set; }
        public virtual DbSet<StoreDetail> StoreDetails { get; set; }
        public virtual DbSet<StoreInfo> StoreInfoes { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
