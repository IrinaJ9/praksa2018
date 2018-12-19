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
    
        public virtual DbSet<AdditionalField> AdditionalFields { get; set; }
        public virtual DbSet<AssetSubType> AssetSubTypes { get; set; }
        public virtual DbSet<AssetType> AssetTypes { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<Capacity> Capacities { get; set; }
        public virtual DbSet<Complience> Compliences { get; set; }
        public virtual DbSet<ComplienceSubType> ComplienceSubTypes { get; set; }
        public virtual DbSet<ComplienceType> ComplienceTypes { get; set; }
        public virtual DbSet<FleetAsset> FleetAssets { get; set; }
        public virtual DbSet<FleetAssetMake> FleetAssetMakes { get; set; }
        public virtual DbSet<FleetAssetModel> FleetAssetModels { get; set; }
        public virtual DbSet<FuelType> FuelTypes { get; set; }
        public virtual DbSet<AccredDriverView> AccredDriverViews { get; set; }
        public virtual DbSet<AccredSubcontView> AccredSubcontViews { get; set; }
        public virtual DbSet<AccredTrailerView> AccredTrailerViews { get; set; }
        public virtual DbSet<InductionDriverView> InductionDriverViews { get; set; }
        public virtual DbSet<InductionSubcontractorView> InductionSubcontractorViews { get; set; }
        public virtual DbSet<InsuranceView> InsuranceViews { get; set; }
        public virtual DbSet<LicenceView> LicenceViews { get; set; }
        public virtual DbSet<RatingTrailerView> RatingTrailerViews { get; set; }
        public virtual DbSet<RatingVehicleView> RatingVehicleViews { get; set; }
        public virtual DbSet<RegTrailerView> RegTrailerViews { get; set; }
        public virtual DbSet<RegVehicleView> RegVehicleViews { get; set; }
    }
}
