using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class UserProviderApi
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ProviderApiId { get; set; }
    }
}
