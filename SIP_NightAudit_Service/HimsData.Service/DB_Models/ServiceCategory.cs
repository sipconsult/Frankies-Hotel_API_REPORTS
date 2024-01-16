using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.DB_Models
{
    public partial class ServiceCategory
    {
        public ServiceCategory()
        {
            HouseKeepingItems = new HashSet<HouseKeepingItem>();
            ServiceDetails = new HashSet<ServiceDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<HouseKeepingItem> HouseKeepingItems { get; set; }
        public virtual ICollection<ServiceDetail> ServiceDetails { get; set; }
    }
}
