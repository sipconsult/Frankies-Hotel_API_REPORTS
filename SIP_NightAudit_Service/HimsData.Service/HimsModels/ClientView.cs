using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ClientView
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientPrefix { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime? TermDate { get; set; }
        public int ClientTypeId { get; set; }
        public int? MaxNoOfDependants { get; set; }
        public DateTime StartDate { get; set; }
        public int? AgeLimit { get; set; }
        public byte Active { get; set; }
        public int NbMembers { get; set; }
        public int NbMainMembers { get; set; }
        public int NbDependants { get; set; }
        public string ActiveString { get; set; }
    }
}
