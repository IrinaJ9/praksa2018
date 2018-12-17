using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleSetup3.Models
{
    public class FleetAssetBig
    {
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
        public int ID { get; set; }
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
        public int ComplienceTypeID { get; set; }
        public int ComplienceSubTypeID { get; set; }
        public string LicenceClass { get; set; }
        public string LicenseNo { get; set; }
        public DateTime? DateObtained { get; set; }
        public DateTime? ValidFromDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string AlertOperation { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Size { get; set; }
        public string Path { get; set; }
        public byte[] Image { get; set; }
        public bool IsDefaultImage { get; set; }

    }
}