using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class ClientType
    {
        public ClientType()
        {
            Clients = new HashSet<Client>();
        }

        public int ClientTypeId { get; set; }
        public string ClientTypeName { get; set; }
        public string Active { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
