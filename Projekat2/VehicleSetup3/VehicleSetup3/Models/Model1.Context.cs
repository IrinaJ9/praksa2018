﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleSetup3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdditionalField> AdditionalFields { get; set; }
        public virtual DbSet<AssetSubType> AssetSubTypes { get; set; }
        public virtual DbSet<AssetType> AssetTypes { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<Complience> Compliences { get; set; }
        public virtual DbSet<ComplienceSubType> ComplienceSubTypes { get; set; }
        public virtual DbSet<ComplienceType> ComplienceTypes { get; set; }
        public virtual DbSet<FleetAssetMake> FleetAssetMakes { get; set; }
        public virtual DbSet<FleetAssetModel> FleetAssetModels { get; set; }
        public virtual DbSet<FuelType> FuelTypes { get; set; }
		public virtual DbSet<Capacity> Capacities { get; set; } 
        public virtual DbSet<FleetAsset> FleetAssets { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

        public System.Data.Entity.DbSet<VehicleSetup3.Models.UserList> UserLists { get; set; }
    }
}
