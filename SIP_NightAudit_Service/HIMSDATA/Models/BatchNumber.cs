using System;
using System.Collections.Generic;

#nullable disable

namespace HIMSDATA.Models
{
    public partial class BatchNumber
    {
        public int Id { get; set; }
        public string BatchNo { get; set; }
        public string InsCompany { get; set; }
        public int? ProviderId { get; set; }
        public int? UserId { get; set; }
        public string UserIdFullname { get; set; }
    }
}
