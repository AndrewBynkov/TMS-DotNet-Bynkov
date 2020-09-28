using System;

namespace Homework4
{
    public class DateDayWeek
    {
        public DateTime inpDate = UserInputDayOfWeek();
        static DateTime UserInputDayOfWeek()
        {
            DateTime inpDate = new DateTime();
            bool canParce = false;

            do
            {
                Console.Write("Enter a date to plan your day (day/month/year): ");
                canParce = DateTime.TryParse(Console.ReadLine(), out DateTime val1);
                inpDate = val1;
            }
            while (!canParce);

            return inpDate;
        }
    }
}
