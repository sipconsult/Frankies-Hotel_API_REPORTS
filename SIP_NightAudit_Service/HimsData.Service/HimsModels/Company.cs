using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class Company
    {
        public double? Id { get; set; }
        public string Company1 { get; set; }
        public string CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public DateTime? PolicyStartDate { get; set; }
        public DateTime? PolicyEndDate { get; set; }
        public DateTime? StatusUpdateTime { get; set; }
        public string InsCompany { get; set; }
        public string CompanyType { get; set; }
        public double? GroupType { get; set; }
        public string PrefixCode { get; set; }
        public string ContactPerson { get; set; }
        public string ContactEmail { get; set; }
        public string CompanyStatus { get; set; }
        public string ExchangeRate { get; set; }
        public DateTime? ExchangeDateTime { get; set; }
        public string SyncBatchNo { get; set; }
        public string SyncBatchNoUpdate { get; set; }
        public string SyncBatchDelete { get; set; }
        public double? SyncInsert { get; set; }
        public double? SyncUpdate { get; set; }
        public string SyncDelete { get; set; }
        public string IdInscompany { get; set; }
        public string UsePin { get; set; }
        public string ShowLimit { get; set; }
        public double? LimitPercentage { get; set; }
        public double? SyncInsertCounts { get; set; }
        public double? SyncUpdateCounts { get; set; }
    }
}
