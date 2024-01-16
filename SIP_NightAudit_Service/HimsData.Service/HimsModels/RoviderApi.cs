using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class RoviderApi
    {
        public double? Id { get; set; }
        public double? ServerId { get; set; }
        public string FacilityNumber { get; set; }
        public string FacilityName { get; set; }
        public string FacilityNameOld { get; set; }
        public string FacilityAddress { get; set; }
        public string FacilityLocation { get; set; }
        public string FacilityTelNumber { get; set; }
        public string FacilityTelNumber2 { get; set; }
        public string FacilityContactPerson { get; set; }
        public string FacilityContactTel { get; set; }
        public string FacilityRegion { get; set; }
        public string RxZone { get; set; }
        public string Area { get; set; }
        public string SubArea { get; set; }
        public string FacilityPhoto { get; set; }
        public string Cordinate { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public double? AverageRates { get; set; }
        public double? RatedSum { get; set; }
        public double? RatedTotal { get; set; }
        public string Ratings { get; set; }
        public string FacilityStatus { get; set; }
        public string FacilityType { get; set; }
        public string MedicalStatus { get; set; }
        public string PharmacyStatus { get; set; }
        public string DentalStatus { get; set; }
        public string LabStatus { get; set; }
        public string OpticalStatus { get; set; }
        public string PhysiotherapyStatus { get; set; }
        public string AdministrativeStatus { get; set; }
        public string PaymentType { get; set; }
        public double? ProviderId { get; set; }
        public double? ProviderIdMaster { get; set; }
        public string ProviderIdBranchHead { get; set; }
        public string Apikey { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public DateTime? DateAdded { get; set; }
        public string ActivationSalt { get; set; }
        public string TypeOfFacility { get; set; }
        public string ActivationPassSalt { get; set; }
        public string DatetimeActivated { get; set; }
        public string ActivationKey { get; set; }
        public string FacilityZone { get; set; }
        public string PreviousApikey { get; set; }
        public string PreviousUsername { get; set; }
        public string PreviousPassword { get; set; }
        public string LastTimeAccessed { get; set; }
        public string Version { get; set; }
        public string OutOfNetwork { get; set; }
        public string ApCode { get; set; }
        public string InsCompany { get; set; }
        public string UpdateDeleteStatus { get; set; }
        public string ProviderStatus { get; set; }
        public string FacilityContactEmail { get; set; }
        public string FacilitySite { get; set; }
        public string HmsFacilityStatus { get; set; }
        public string SyncBatchNo { get; set; }
        public string SyncBatchNoUpdate { get; set; }
        public string SyncBatchNoDelete { get; set; }
        public double? SyncInsert { get; set; }
        public double? SyncUpdate { get; set; }
        public double? SyncDelete { get; set; }
        public string IdInscompany { get; set; }
        public double? SyncInsertCounts { get; set; }
        public double? SyncUpdateCounts { get; set; }
        public string CustomerId { get; set; }
        public double? TaxRate { get; set; }
        public int? CategoryId { get; set; }
    }
}
