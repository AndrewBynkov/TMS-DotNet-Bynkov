using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            (int month, DayOfWeek dayOfWeek) = UserInputData();
            GetDatesByDayOfWeek(month, DateTime.Now.Year, dayOfWeek);
        }

        private static (int month, DayOfWeek dayOfWeek) UserInputData()
        {
            DayOfWeek dayOfWeek = GetDayOfWeekByUserInput();
            int month = GetMonthByUserInput();

            return (month, dayOfWeek);
        }

        private static DayOfWeek GetDayOfWeekByUserInput()
        {
            bool canParse = false;
            DayOfWeek dayOfWeek = DayOfWeek.Monday;

            do
            {
                Console.Write("Enter name day (Monday only): ");
                string userInputWeekDay = Console.ReadLine().ToLowerInvariant();
                switch (userInputWeekDay)
                {
                    case "monday":
                        {
                            dayOfWeek = DayOfWeek.Monday;
                            canParse = true;
                        }
                        break;
                    case "tuesday":
                        {
                            dayOfWeek = DayOfWeek.Tuesday;
                            canParse = true;
                        }
                        break;
                    case "wednesday":
                        {
                            dayOfWeek = DayOfWeek.Wednesday;
                            canParse = true;
                        }
                        break;
                    case "thursday":
                        {
                            dayOfWeek = DayOfWeek.Thursday;
                            canParse = true;
                        }
                        break;
                    case "friday":
                        {
                            dayOfWeek = DayOfWeek.Friday;
                            canParse = true;
                        }
                        break;
                    case "saturday":
                        {
                            dayOfWeek = DayOfWeek.Saturday;
                            canParse = true;
                        }
                        break;
                    case "sunday":
                        {
                            dayOfWeek = DayOfWeek.Sunday;
                            canParse = true;
                        }
                        break;
                    default:
                        break;
                }

            } while (canParse == false);

            return dayOfWeek;
        }

        private static int GetMonthByUserInput()
        {
            bool canParse = false;
            int monthNumber = 0;
            do
            {
                Console.Write("Enter date of month int only: ");
                string userInputMonthNumber = Console.ReadLine();
                canParse = int.TryParse(userInputMonthNumber, out int parsedMonthNumber);
                monthNumber = parsedMonthNumber;
            }
            while (!canParse || monthNumber < 1 || monthNumber > 12);

            return monthNumber;
        }

        private static void GetDatesByDayOfWeek(int month, int year, DayOfWeek dayOfWeek)
        {
            int days = DateTime.DaysInMonth(year, month);

            DateTime[] dates = new DateTime[days];

            for (int i = 0; i < days; i++)
            {
                dates[i] = new DateTime(year, month, i + 1);
            }

            foreach (DateTime date in dates)
            {
                if (date.DayOfWeek == dayOfWeek)
                {
                    Console.WriteLine(date);
                }
            }
        }
    }
}

