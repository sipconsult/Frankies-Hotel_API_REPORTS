using System;
using System.Collections.Generic;

#nullable disable

namespace HIMSDATA.Models
{
    public partial class RxInsCompanyProviderMap
    {
        public int Id { get; set; }
        public string RxProviderName { get; set; }
        public string RxProviderId { get; set; }
        public string InsCompanyProviderName { get; set; }
        public string InsCompanyProviderCode { get; set; }
    }
}
