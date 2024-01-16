using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class Notification
    {
        public int Rid { get; set; }
        public string Mid { get; set; }
        public string Client { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
