using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class DosageFrequency
    {
        public int Id { get; set; }
        public string Frequency { get; set; }
        public string Ranking { get; set; }
    }
}
