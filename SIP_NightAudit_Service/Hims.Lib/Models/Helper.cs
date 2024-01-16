using System;
using System.Collections.Generic;
using System.Text;

namespace Hims.Lib.Models
{
    public static class Helper
    {

        public static DateTime? ParseDate(string joinDate)
        {
            if (String.IsNullOrWhiteSpace(joinDate))
            {
                return null;
            }

            return DateTime.ParseExact(joinDate, "dd-MM-yyyy", null);
        }

        public static String ParseDate(DateTime? joinDate)
        {
            try
            {
                return joinDate.HasValue ? joinDate.Value.ToString("dd-MM-yyyy") : "";

            }
            catch (Exception)
            {
                return "";
            }
        }


        public static DateTime? ParseMonth(string date)
        {
            string actualDate = "01-" + date;
            if (String.IsNullOrWhiteSpace(date))
            {
                return null;
            }

            return DateTime.ParseExact(actualDate, "dd-MM-yyyy", null);
        }

        public static String ParseMonth(DateTime date)
        {
            try
            {
                return date.ToString("MM-yyyy");

            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
