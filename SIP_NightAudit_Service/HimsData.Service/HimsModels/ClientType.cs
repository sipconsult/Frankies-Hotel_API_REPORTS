using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ClientType
    {
        public ClientType()
        {
            Clients = new HashSet<Client>();
        }

        public int ClientTypeId { get; set; }
        public string ClientTypeName { get; set; }
        public string Tpa { get; set; }
        public string Active { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
