using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PersianDateTime
{
    public static class PersianDateTimeExtenstion
    {
        public static DateTime PersianNow(this DateTime dt)
        {
            var date = DateTime.Now;
            var calendar = new PersianCalendar();
            var persianDate = new DateTime(calendar.GetYear(date), calendar.GetMonth(date), calendar.GetDayOfMonth(date), calendar.GetHour(date), calendar.GetMinute(date), calendar.GetSecond(date));
            return persianDate;
        }

        public static DateTime PersianDateOnly(this DateTime dt)
        {
            var date = DateTime.Now;
            var calendar = new PersianCalendar();
            var persianDate = new DateTime(calendar.GetYear(date), calendar.GetMonth(date), calendar.GetDayOfMonth(date));
            return persianDate;
        }

        public static int PersianYear(this DateTime date)
        {
            var calendar = new PersianCalendar();
            var year = calendar.GetYear(date);
            return year;
        }

        public static int PersianMonth(this DateTime date)
        {
            var calendar = new PersianCalendar();
            var month = calendar.GetMonth(date);
            return month;
        }

        public static int PersianDay(this DateTime date)
        {
            var calendar = new PersianCalendar();
            var day = calendar.GetDayOfMonth(date);
            return day;
        }

        public static string PersianDate(this DateTime date)
        {
            var calendar = new PersianCalendar();
            var persianDate = new DateTime(calendar.GetYear(date), calendar.GetMonth(date), calendar.GetDayOfMonth(date));
            var result = persianDate.ToString("yyyy MMM ddd", CultureInfo.GetCultureInfo("fa-Ir"));
            return result;
        }
    }
}
