using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class Bsheet
    {
        public double? BatchId { get; set; }
        public string BookNo { get; set; }
        public string BatchDate { get; set; }
        public string PayDate { get; set; }
        public double? ClaimType { get; set; }
        public double? AmountReceived { get; set; }
        public double? AmountPaid { get; set; }
        public string Remarks { get; set; }
        public string ClaimMonth { get; set; }
        public double? Status { get; set; }
        public string DateOfCompletion { get; set; }
        public string AccountDate { get; set; }
        public string AssignedTo { get; set; }
        public string PaidBy { get; set; }
        public double? Resubmitted { get; set; }
        public double? ProviderId { get; set; }
        public string ClientId { get; set; }
        public string UserId { get; set; }
        public string LastDateModified { get; set; }
    }
}
