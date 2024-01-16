using SIP_NightAudit_Service.Service.HimsModels;
using SIP_NightAudit_Service.Service.Interfaces;
using SIP_NightAudit_Service.Service.RxModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIP_NightAudit_Service.ServiceModels;

namespace SIP_NightAudit_Service.Service.ServiceModels
{
    public class AuditProcess : IAuditProcess
    {
        //private RxDBContext rxDBContext;

        //private HimsDBContext himsDBContext;
        private FrankiesHotelContext hotel;

        private readonly ILogger<AuditProcess> _logger;


        public AuditProcess(ILogger<AuditProcess> logger)
        {
            _logger = logger;

        }


        private DbContextOptions<FrankiesHotelContext> GetAllHotelOptions()
        {
            var optionBuilder = new DbContextOptionsBuilder<FrankiesHotelContext>();

            optionBuilder.UseSqlServer(AppSettings.HotelConnectionString);

            return optionBuilder.Options;
        }

        public void TimeChecker()
        {
            while (true)
            {
                // Calculate the time until midnight
                //DateTime now = DateTime.Now;
                //DateTime midnight = now.Date.AddDays(1); // Next midnight
                //TimeSpan timeUntilMidnight = midnight - now;

                //// Sleep until midnight
                //System.Threading.Thread.Sleep(timeUntilMidnight);

                // Run the code at midnight
                LoadServices();
            }
        }

        public void LoadServices()
        {
            using (hotel = new FrankiesHotelContext(GetAllHotelOptions()))
            {
                DateTime currentDate = DateTime.Now.Date; // Get the current date without time
                decimal? amount = 0;
                DB_Models.NightAudit n_audit = new DB_Models.NightAudit();
                int? n_auditCount = 0;

                var activeBookings = hotel.Bookings
                    .Where(x => x.CheckInTime != null && x.CheckOutTime == null && currentDate >= x.BookStart && currentDate <= x.BookEnd)
                    .ToList();

                foreach (var booking in activeBookings)
                {
                    var reservedRooms = hotel.Rooms.Where(x => x.Id == booking.RoomId).ToList();
                    foreach (var room in reservedRooms)
                    {
                        // Check if billing data already exists for the current day for this room
                        bool billingExists = hotel.Billings.Any(x => x.RoomId == room.Id && x.Timestamp.HasValue && x.Timestamp.Value.Date == currentDate);
                        if (billingExists)
                        {
                            // Billing data already exists for this room, skip it
                            continue;
                        }

                        var roomType = hotel.RoomTypes.Where(x => x.Id == room.TypeId).ToList();

                        // Accommodation
                        DB_Models.Billing billing = new DB_Models.Billing();
                        billing.Debit = roomType[0].Price;
                        billing.CustomerId = booking.GuestId;
                        billing.RoomId = room.Id;
                        billing.Description = "Accommodation for " + room.Name;
                        billing.Currency = "USD";
                        billing.Timestamp = DateTime.Now;

                        DB_Models.BillingsHistory billingsHistory = new DB_Models.BillingsHistory();
                        billingsHistory.Debit = roomType[0].Price;
                        billingsHistory.CustomerId = booking.GuestId;
                        billingsHistory.RoomId = room.Id;
                        billingsHistory.Description = "Accommodation for " + room.Name;
                        billingsHistory.Currency = "USD";
                        billingsHistory.Timestamp = DateTime.Now;

                        hotel.Billings.Add(billing);
                        hotel.BillingsHistories.Add(billingsHistory);

                        booking.IsNightAudited = true;
                        hotel.Bookings.UpdateRange(booking);
                        hotel.SaveChanges();
                        _logger.LogInformation("New room audited");

                        // Guest Services if any
                        var guestServices = hotel.GuestServices.Where(x => (x.IsNightAudited == false || x.IsNightAudited == null) && x.GuestId == booking.GuestId && x.RoomId == booking.RoomId).ToList();
                        if (guestServices.Any())
                        {
                            n_auditCount = n_auditCount + guestServices.Count;
                            foreach (var guestService in guestServices)
                            {
                                DB_Models.Billing billing_services = new DB_Models.Billing();
                                billing_services.Debit = guestService.UnitPrice;
                                billing_services.CustomerId = booking.GuestId;
                                billing_services.RoomId = room.Id;
                                billing_services.Description = guestService.Service;
                                billing_services.Currency = "GHS";
                                billing_services.Timestamp = DateTime.Now;

                                DB_Models.BillingsHistory billingsHistory_services = new DB_Models.BillingsHistory();
                                billingsHistory_services.Debit = guestService.UnitPrice;
                                billingsHistory_services.CustomerId = booking.GuestId;
                                billingsHistory_services.RoomId = room.Id;
                                billingsHistory_services.Description = guestService.Service;
                                billingsHistory_services.Currency = "GHS";
                                billingsHistory_services.Timestamp = DateTime.Now;

                                amount = amount + guestService.UnitPrice;
                                guestService.IsNightAudited = true;

                                hotel.Billings.Add(billing_services);
                                hotel.BillingsHistories.Add(billingsHistory_services);
                                hotel.SaveChanges();
                            }

                            DB_Models.GuestService g_services = new DB_Models.GuestService();
                            n_audit.Amount = amount;
                            n_audit.Timestamp = DateTime.Now;
                            n_audit.NumberOfTransaction = n_auditCount;
                            hotel.NightAudits.Add(n_audit);
                            hotel.GuestServices.UpdateRange(guestServices);
                            hotel.SaveChanges();
                            _logger.LogInformation("New Service audited");
                        }
                        else
                        {
                            _logger.LogInformation("No new service audited");
                        }
                    }
                }
               
                TimeChecker();
            }
        
        }

        //public void LoadServices()
        //{

        //    using (hotel = new FrankiesHotelContext(GetAllHotelOptions()))
        //    {
        //        DateTime currentDate = DateTime.Now.Date; // Get the current date without time
        //        decimal? amount = 0;
        //        DB_Models.NightAudit n_audit = new DB_Models.NightAudit();
        //        int? n_auditCount = 0;


        //        var activeBookings = hotel.Bookings
        //            .Where(x => x.CheckInTime != null && x.CheckOutTime == null && currentDate >= x.BookStart && currentDate <= x.BookEnd)
        //            .ToList();

        //        foreach (var booking in activeBookings)
        //        {
        //            var reservedRooms = hotel.Rooms.Where(x => x.Id == booking.RoomId).ToList();
        //            foreach (var room in reservedRooms)
        //            {

        //                var roomType = hotel.RoomTypes.Where(x => x.Id == room.TypeId).ToList();

        //                //Accomodation
        //                DB_Models.Billing billing = new DB_Models.Billing();
        //                billing.Debit = roomType[0].Price;
        //                billing.CustomerId = booking.GuestId;
        //                billing.RoomId = room.Id;
        //                billing.Description = "Accomodation for " + room.Name;
        //                billing.Currency = "USD";
        //                billing.Timestamp = DateTime.Now;

        //                DB_Models.BillingsHistory billingsHistory = new DB_Models.BillingsHistory();
        //                billingsHistory.Debit = roomType[0].Price;
        //                billingsHistory.CustomerId = booking.GuestId;
        //                billingsHistory.RoomId = room.Id;
        //                billingsHistory.Description = "Accomodation for " + room.Name;
        //                billingsHistory.Currency = "USD";
        //                billingsHistory.Timestamp = DateTime.Now;



        //                hotel.Billings.Add(billing);
        //                hotel.BillingsHistories.Add(billingsHistory);

        //                booking.IsNightAudited = true;
        //                hotel.Bookings.UpdateRange(booking);
        //                hotel.SaveChanges();
        //                _logger.LogInformation("New room audited");

        //                //Guest Services if any
        //                var guestServices = hotel.GuestServices.Where(x => (x.IsNightAudited == false || x.IsNightAudited == null) && x.GuestId == booking.GuestId && x.RoomId == booking.RoomId).ToList();
        //                if (guestServices.Any())
        //                {
        //                    n_auditCount = n_auditCount + guestServices.Count;
        //                    foreach (var guestService in guestServices)
        //                    {
        //                        DB_Models.Billing billing_services = new DB_Models.Billing();
        //                        billing_services.Debit = guestService.UnitPrice;
        //                        billing_services.CustomerId = booking.GuestId;
        //                        billing_services.RoomId = room.Id;
        //                        billing_services.Description = guestService.Service;
        //                        billing_services.Currency = "GHS";
        //                        billing_services.Timestamp = DateTime.Now;

        //                        DB_Models.BillingsHistory billingsHistory_services = new DB_Models.BillingsHistory();
        //                        billingsHistory_services.Debit = guestService.UnitPrice;
        //                        billingsHistory_services.CustomerId = booking.GuestId;
        //                        billingsHistory_services.RoomId = room.Id;
        //                        billingsHistory_services.Description = guestService.Service;
        //                        billingsHistory_services.Currency = "GHS";
        //                        billingsHistory_services.Timestamp = DateTime.Now;

        //                        amount = amount + guestService.UnitPrice;
        //                        guestService.IsNightAudited = true;

        //                        hotel.Billings.Add(billing_services);
        //                        hotel.BillingsHistories.Add(billingsHistory_services);
        //                        hotel.SaveChanges();
        //                    }

        //                    DB_Models.GuestService g_services = new DB_Models.GuestService();
        //                    n_audit.Amount = amount;
        //                    n_audit.Timestamp = DateTime.Now;
        //                    n_audit.NumberOfTransaction = n_auditCount;
        //                    hotel.NightAudits.Add(n_audit);
        //                    hotel.GuestServices.UpdateRange(guestServices);
        //                    hotel.SaveChanges();
        //                    _logger.LogInformation("New Service audited");
        //                }
        //                else
        //                {
        //                    _logger.LogInformation("No new service audited");

        //                }
        //            }


        //        }

        //    }
        //}


    }
}
