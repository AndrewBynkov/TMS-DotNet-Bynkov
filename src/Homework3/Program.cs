using System;
using System.Globalization;
using System.Data;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Homework3
{
    enum ListMyMonth
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class Program
    {
        static void Main(string[] args)
        {
            var userValMonth = UserDate();
            var myYear = 0;
            GetDate(ref myYear);
            GetWensday(userValMonth, ref myYear);
        }

        private static void GetWensday(int userValMonth, ref int myYear)
        {
            DateTime date = new DateTime(myYear, userValMonth, 1);
            while (true)
            {
                if (date.DayOfWeek == DayOfWeek.Monday)
                {
                    Console.WriteLine($"Monday - {date.Date}");
                }
                date = date.AddDays(1.0);
                if (date.Month != userValMonth)
                {
                    break;
                }
            }
        }

        private static int UserDate()
        {
            Console.Write("Enter date of month int only: ");
            var userVal = Console.ReadLine();
            while (int.TryParse(userVal, out int outIntResult).Equals(false))
            {
                Console.Write("Enter date of week int only: ");
                userVal = Console.ReadLine();
            }
            var userValResult = Convert.ToInt32(userVal);
            return userValResult;
        }

        private static void GetDate(ref int myYear)
        {
            int myYears = DateTime.Now.Date.Year;
            myYear = myYears;
        }

    }
}

