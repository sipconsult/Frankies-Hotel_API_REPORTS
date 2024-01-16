using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class JuneDatum
    {
        public double? Id { get; set; }
        public string DateOfConsultation { get; set; }
        public string DateAddedShort { get; set; }
        public string DateAdded { get; set; }
        public string ProcessClaimNo { get; set; }
    }
}
