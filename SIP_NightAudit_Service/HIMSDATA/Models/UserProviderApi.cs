using System;
using System.Collections.Generic;

#nullable disable

namespace HIMSDATA.Models
{
    public partial class UserProviderApi
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ProviderApiId { get; set; }
    }
}
