using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class Setting
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string CompanyName { get; set; }
        public string Developers { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string EMail { get; set; }
        public string Website { get; set; }
        public string ContraAccount { get; set; }
        public string ClaimsContraAccount { get; set; }
        public int? Yes { get; set; }
        public string Date { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
