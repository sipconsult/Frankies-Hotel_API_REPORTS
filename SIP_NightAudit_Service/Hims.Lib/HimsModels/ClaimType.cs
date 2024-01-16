using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class ClaimType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
        public byte Active { get; set; }
        public byte? Default { get; set; }
    }
}
