﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnketorApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AnketSistemiEntities : DbContext
    {
        public AnketSistemiEntities()
            : base("name=AnketSistemiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Anketler> Anketler { get; set; }
        public virtual DbSet<Cevap> Cevap { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<Secenekler> Secenekler { get; set; }
        public virtual DbSet<Sorular> Sorular { get; set; }
        public virtual DbSet<Yoneticiler> Yoneticiler { get; set; }
    }
}
