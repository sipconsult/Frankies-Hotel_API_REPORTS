﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ClientProduct
    {
        public int ProductId { get; set; }
        public int ClientId { get; set; }
        public int ProductItemId { get; set; }
        public decimal? Amount { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}