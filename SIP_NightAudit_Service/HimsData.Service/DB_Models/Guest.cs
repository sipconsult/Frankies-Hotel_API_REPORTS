using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.DB_Models
{
    public partial class Guest
    {
        public Guest()
        {
            Billings = new HashSet<Billing>();
            BillingsHistories = new HashSet<BillingsHistory>();
            Bookings = new HashSet<Booking>();
            GuestServices = new HashSet<GuestService>();
            Notes = new HashSet<Note>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Account { get; set; }
        public DateTime? Dob { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Idtype { get; set; }
        public string Idnumber { get; set; }
        public string DocUrl { get; set; }

        public virtual ICollection<Billing> Billings { get; set; }
        public virtual ICollection<BillingsHistory> BillingsHistories { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<GuestService> GuestServices { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
