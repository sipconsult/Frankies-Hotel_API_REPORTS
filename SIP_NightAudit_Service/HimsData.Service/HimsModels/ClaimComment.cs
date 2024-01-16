using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ClaimComment
    {
        public int Id { get; set; }
        public int? ServerId { get; set; }
        public string InsCompany { get; set; }
        public string ProviderId { get; set; }
        public string ProcessClaimNo { get; set; }
        public string Comment { get; set; }
        public byte[] DateTime { get; set; }
        public string Username { get; set; }
        public string Type { get; set; }
        public int? UserId { get; set; }
        public string SyncBatchNo { get; set; }
        public string SyncBatchNoUpdate { get; set; }
        public string SyncBatchDelete { get; set; }
        public int? SyncInsert { get; set; }
        public int? SyncUpdate { get; set; }
        public int? SyncDelete { get; set; }
        public string IdInscompany { get; set; }
        public string User { get; set; }
        public int? SyncInsertCounts { get; set; }
        public int? SyncUpdateCounts { get; set; }
    }
}
