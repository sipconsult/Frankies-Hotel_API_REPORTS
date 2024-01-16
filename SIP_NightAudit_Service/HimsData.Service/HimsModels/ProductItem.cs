using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ProductItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public byte? NeedAuthorization { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
