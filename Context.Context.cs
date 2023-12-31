﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JPGame
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<CardLevel> CardLevels { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Gift> Gifts { get; set; }
        public virtual DbSet<LiveCard> LiveCards { get; set; }
        public virtual DbSet<MemberCardChargeRecord> MemberCardChargeRecords { get; set; }
        public virtual DbSet<MemberCardLevel> MemberCardLevels { get; set; }
        public virtual DbSet<MemberCard> MemberCards { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<PersonalGift> PersonalGifts { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SettingGame> SettingGames { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<SpecialMemory> SpecialMemories { get; set; }
        public virtual DbSet<TypeSlider> TypeSliders { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VIPGift> VIPGifts { get; set; }
        public virtual DbSet<Cashier> Cashiers { get; set; }
        public virtual DbSet<NFCReader> NFCReaders { get; set; }
    }
}
