using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ProductPrefix { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
        public string Active { get; set; }
    }
}
