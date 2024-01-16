using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class Provider
    {
        public int ProviderId { get; set; }
        public int? ProviderCategoryId { get; set; }
        public int? ProviderGroupId { get; set; }
        public int? ProviderCode { get; set; }
        public string ProviderName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime? TermDate { get; set; }
        public int? RegionId { get; set; }
        public decimal? TaxRate { get; set; }
        public byte? Active { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public string ImageUrl { get; set; }
    }
}
