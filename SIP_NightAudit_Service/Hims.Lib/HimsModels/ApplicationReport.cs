using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class ApplicationReport
    {
        public int Id { get; set; }
        public string QualifiedName { get; set; }
        public string ReportName { get; set; }
        public string CategoryName { get; set; }
        public string ReportOrder { get; set; }
    }
}
