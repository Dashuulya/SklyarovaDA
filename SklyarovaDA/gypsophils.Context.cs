﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SklyarovaDA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ЖурналEntities : DbContext
    {
        public ЖурналEntities()
            : base("name=ЖурналEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
