﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class SecurityLevelRole
    {
        public int Id { get; set; }
        public string SecurityRole { get; set; }
        public double? AuthAmount { get; set; }
    }
}