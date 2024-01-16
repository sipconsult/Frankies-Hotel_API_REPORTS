using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class staff
    {
        public int Id { get; set; }
        public string StaffCode { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string License { get; set; }
        public string Address { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
