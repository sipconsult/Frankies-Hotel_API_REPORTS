using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.DB_Models
{
    public partial class Billing
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? RoomId { get; set; }
        public string Description { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public string CustomerBookingId { get; set; }
        public DateTime? Timestamp { get; set; }
        public string Currency { get; set; }
        public bool? IsPayment { get; set; }
        public string PaymentMethod { get; set; }
        public bool? IsAccomodation { get; set; }

        public virtual Guest Customer { get; set; }
        public virtual Room Room { get; set; }
    }
}
