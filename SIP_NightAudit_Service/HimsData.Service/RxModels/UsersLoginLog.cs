using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class UsersLoginLog
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Status { get; set; }
        public string IpAddress { get; set; }
    }
}
