using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class FilesForUpload
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Type { get; set; }
    }
}
