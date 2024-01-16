using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class PreAuthorizationView
    {
        public long Id { get; set; }
        public int MemberId { get; set; }
        public int ProviderId { get; set; }
        public int TreatmentId { get; set; }
        public decimal Cost { get; set; }
        public string Remarks { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public byte? Responded { get; set; }
        public byte? Authorized { get; set; }
        public string AuthorizedCode { get; set; }
        public string Authoriser { get; set; }
        public string FullPolicyNo { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public string Gender { get; set; }
        public string ProviderName { get; set; }
        public string TreatmentName { get; set; }
    }
}
