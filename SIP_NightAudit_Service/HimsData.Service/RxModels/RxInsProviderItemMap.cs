using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class RxInsProviderItemMap
    {
        public int Id { get; set; }
        public string InsItemCode { get; set; }
        public string RxItemName { get; set; }
        public string Item { get; set; }
        public string Service { get; set; }
        public string OtherCartegory { get; set; }
    }
}
