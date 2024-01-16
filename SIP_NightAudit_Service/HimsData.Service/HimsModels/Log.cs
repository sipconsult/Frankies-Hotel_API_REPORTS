using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class Log
    {
        public long EntryNo { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime DateLog { get; set; }
        public string TableName { get; set; }
        public long TransactionId { get; set; }
        public DateTime LastDateModified { get; set; }
    }
}
