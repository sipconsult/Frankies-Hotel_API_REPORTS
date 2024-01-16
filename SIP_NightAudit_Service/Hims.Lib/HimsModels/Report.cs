using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class Report
    {
        public int Id { get; set; }
        public string ReportName { get; set; }
        public string ReportHeader { get; set; }
        public string Grouping { get; set; }
        public bool Available { get; set; }
        public int Tag { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
