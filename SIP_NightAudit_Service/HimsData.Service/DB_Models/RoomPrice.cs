using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.DB_Models
{
    public partial class RoomPrice
    {
        public int Id { get; set; }
        public int? RoomId { get; set; }
        public decimal? Price { get; set; }
    }
}
