using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class Balance
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public string Mid { get; set; }
        public decimal InPatient { get; set; }
        public decimal OutPatient { get; set; }
        public decimal Dental { get; set; }
        public decimal Cancer { get; set; }
        public decimal InLimit { get; set; }
        public decimal OutLimit { get; set; }
        public decimal OpticalLimit { get; set; }
        public decimal DentalLimit { get; set; }
        public string Plan { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
