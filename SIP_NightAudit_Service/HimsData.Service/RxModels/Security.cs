using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class Security
    {
        public int SecurityId { get; set; }
        public string SecurityName { get; set; }
        public string SecuritySymbol { get; set; }
        public string Remarks { get; set; }
        public string DateAdded { get; set; }
        public string AddedBy { get; set; }
        public string Status { get; set; }
    }
}
