﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleSetup.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VehicleSetupEntities : DbContext
    {
        public VehicleSetupEntities()
            : base("name=VehicleSetupEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdditionalFields> AdditionalFields { get; set; }
        public virtual DbSet<AssetSubType> AssetSubType { get; set; }
        public virtual DbSet<AssetType> AssetType { get; set; }
        public virtual DbSet<Attachments> Attachments { get; set; }
        public virtual DbSet<Capacity> Capacity { get; set; }
        public virtual DbSet<Complience> Complience { get; set; }
        public virtual DbSet<ComplienceSubType> ComplienceSubType { get; set; }
        public virtual DbSet<ComplienceType> ComplienceType { get; set; }
        public virtual DbSet<FleetAsset> FleetAsset { get; set; }
        public virtual DbSet<FleetAssetMake> FleetAssetMake { get; set; }
        public virtual DbSet<FleetAssetModel> FleetAssetModel { get; set; }
        public virtual DbSet<FuelType> FuelType { get; set; }
    }
}