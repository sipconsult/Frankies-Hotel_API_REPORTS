using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class Lead
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? Date { get; set; }
        public string PaymentMode { get; set; }
        public string TermsOfPayment { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
