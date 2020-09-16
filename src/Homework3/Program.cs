using System;
using System.Globalization;
using System.Data;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Homework3
{
    enum ListMyDays
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }
    class Program
    {
        static void Main(string[] args)
        {
            string userDay;
            var myYear = 0;
            var myAllDaysinMonth = 31;

            var userValMonth = UserDate(out userDay);
            UserDay(ref userDay);
            GetDate(ref myYear, ref userValMonth, ref myAllDaysinMonth);
            GetDateDay(userValMonth, myYear, userDay, myAllDaysinMonth);
        }

        private static void GetDateDay(int userValMonth, int myYear, string userDay, int myAllDaysInMonth)
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

        private static int UserDate(out string userDay)
        {
            Console.Write("Enter date of month int only: ");
            var userVal = Console.ReadLine();

            Console.Write("Enter name day (Mondey only): ");
            userDay = Console.ReadLine();

            while (int.TryParse(userVal, out int outIntResult).Equals(false))
            {
                Console.Write("Enter date of week int only: ");
                userVal = Console.ReadLine();
            }
            var userValResult = Convert.ToInt32(userVal);
            return userValResult;
        }

        private static string UserDay(ref string userDayComprasion)
        {
            for (int i = 0; i < (int)(ListMyDays)i; i++)
            {
                if (((ListMyDays)i).Equals(userDayComprasion))
                {
                    userDayComprasion = Convert.ToString((ListMyDays)i);
                    break;
                }
                else
                {
                    continue;
                }
            }
            return userDayComprasion;
        }

        private static void GetDate(ref int myYear, ref int userValMonth, ref int myAllDaysinMonth)
        {
            myYear = DateTime.Now.Date.Year;
            myAllDaysinMonth = DateTime.DaysInMonth(myYear, userValMonth);
        }

    }
}

