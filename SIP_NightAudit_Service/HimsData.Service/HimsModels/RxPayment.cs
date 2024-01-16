using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class RxPayment
    {
        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public string ProviderName { get; set; }
        public int? MonthOfClaim { get; set; }
        public int? YearOfClaim { get; set; }
        public decimal? ProviderAmountClaimed { get; set; }
        public int? NberOfClaims { get; set; }
        public string SystemInvoiceNber { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateOfClaim { get; set; }
    }
}
