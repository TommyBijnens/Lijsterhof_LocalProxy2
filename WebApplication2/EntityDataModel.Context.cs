﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CVLoggerEntities : DbContext
    {
        public CVLoggerEntities()
            : base("name=CVLoggerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BS_H> BS_H { get; set; }
        public virtual DbSet<BS_M> BS_M { get; set; }
        public virtual DbSet<BS_TOT> BS_TOT { get; set; }
        public virtual DbSet<T_H> T_H { get; set; }
        public virtual DbSet<T_M> T_M { get; set; }
        public virtual DbSet<T_TOT> T_TOT { get; set; }
        public virtual DbSet<Temp_Tommy_Keuken> Temp_Tommy_Keuken { get; set; }
        public virtual DbSet<Temp1> Temp1 { get; set; }
        public virtual DbSet<Temp2> Temp2 { get; set; }
        public virtual DbSet<Temp3> Temp3 { get; set; }
        public virtual DbSet<TempB> TempB { get; set; }
        public virtual DbSet<Parameters> Parameters { get; set; }
    }
}