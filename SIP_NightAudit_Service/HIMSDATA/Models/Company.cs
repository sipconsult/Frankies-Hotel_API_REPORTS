using System;
using System.Collections.Generic;

#nullable disable

namespace HIMSDATA.Models
{
    public partial class Company
    {
        public int Id { get; set; }
        public string Company1 { get; set; }
        public string CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public DateTime? PolicyStartDate { get; set; }
        public DateTime? PolicyEndDate { get; set; }
        public DateTime? StatusUpdateTime { get; set; }
        public string InsCompany { get; set; }
        public string CompanyType { get; set; }
        public int? GroupType { get; set; }
        public string PrefixCode { get; set; }
        public string ContactPerson { get; set; }
        public string ContactEmail { get; set; }
        public string CompanyStatus { get; set; }
        public double? ExchangeRate { get; set; }
        public string SyncBatchNo { get; set; }
        public string SyncBatchNoUpdate { get; set; }
        public string SyncBatchDelete { get; set; }
        public bool? SyncInsert { get; set; }
        public bool? SyncUpdate { get; set; }
        public bool? SyncDelete { get; set; }
        public string IdInscompany { get; set; }
        public string UsePin { get; set; }
        public string ShowLimit { get; set; }
        public float? LimitPercentage { get; set; }
        public int? SyncInsertCounts { get; set; }
        public int? SyncUpdateCounts { get; set; }
    }
}
