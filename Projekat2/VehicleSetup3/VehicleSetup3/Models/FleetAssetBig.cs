﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleSetup3.Models
{
    public class FleetAssetBig
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FleetAssetBig()
        {

            this.FleetAssets = new HashSet<FleetAsset>();
            this.AdditionalFields = new HashSet<AdditionalField>();
            this.Capacities = new HashSet<Capacity>();
            this.Compliences = new HashSet<Complience>();
        }
        #region Fields
    //  FleetAsset
        public string FleetNo { get; set; }
        public string RegistrationNo { get; set; }
        public string Depot { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
        public int FleetAssetMakeID { get; set; }
        public int FleetAssetModelID { get; set; }
        public int FleetAssetTypeID { get; set; }
        public int FleetAssetSubTypeID { get; set; }
        public int FuelTypeID { get; set; }
    //---------------------------------------------------

    //  Capacities
        public int? Pallets { get; set; }
        public int? Spaces { get; set; }
        public decimal? CubicSpace { get; set; }
        public decimal? InternalHeight { get; set; }
        public decimal? InternalWidht { get; set; }
        public decimal? InternalLenght { get; set; }
        public decimal? Tare { get; set; }
        public decimal? GVM { get; set; }
        public decimal? GCM { get; set; }
        public bool IsMainCapacity { get; set; }
        public decimal? AxelWeight1 { get; set; }
        public decimal? AxelWeight2 { get; set; }
        public decimal? AxelWeight3 { get; set; }
    //---------------------------------------------------
    //  Complineces
        public int ComplienceTypeID { get; set; }
        public int ComplienceSubTypeID { get; set; }
        public string LicenceClass { get; set; }
        public string LicenseNo { get; set; }
        public DateTime? DateObtained { get; set; }
        public DateTime? ValidFromDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string AlertOperation { get; set; }
        //---------------------------------------------------
        //  AdditionalFields
        public string AdditionalFieldName { get; set; }
        public string AdditionalFieldValue { get; set; }
        //---------------------------------------------------

        #endregion

        #region Virtual
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdditionalField> AdditionalFields { get; set; }
        public virtual AssetSubType AssetSubType { get; set; }
        public virtual AssetType AssetType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Capacity> Capacities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Complience> Compliences { get; set; }
        public virtual FleetAssetMake FleetAssetMake { get; set; }
        public virtual FleetAssetModel FleetAssetModel { get; set; }
        public virtual FuelType FuelType { get; set; }
        public virtual FleetAsset FleetAsset { get; set; }
        public virtual ComplienceSubType ComplienceSubType { get; set; }
        public virtual ComplienceType ComplienceType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FleetAsset> FleetAssets { get; set; }
        #endregion
    }
}