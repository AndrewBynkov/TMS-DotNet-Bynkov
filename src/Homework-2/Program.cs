using System;
using System.Globalization;

namespace Homework_2
{
    enum MyMonth
    {
        January = 1,
        February,
        Marth,
        April,
        May,
        Jun,
        Jul,
        August,
        Septemer,
        October,
        Nowember,
        December
    }

    class Program
    {
        static void Main()
        {
            CultureInfo myCult = new CultureInfo("en-EN");
            Console.Write("Enter number month: ");

            var Number = Console.ReadLine();
            int NumberMonth = 0;

            while (Number.GetType().Equals(typeof(string)))
            {
                try
                {
                    NumberMonth = Convert.ToInt32(Number);
                    break;
                }
                catch (Exception)
                {
                    Console.Write("Exсeption: return incorrect format, try input int value: ");
                    Number = Console.ReadLine();
                }
            }
            NumberMonth = Convert.ToInt32(Number);

            while (NumberMonth <= 0 || NumberMonth > (int)MyMonth.December)
            {
                Console.Write($"You entered incorrect data, please try again: ");
                NumberMonth = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i <= (int)MyMonth.December; i++)
            {
                if (NumberMonth == (int)(MyMonth)i)
                {
                    Console.WriteLine($"\nGreat! Your choose is: { (MyMonth)i }, but month today is: {myCult.DateTimeFormat.GetMonthName(DateTime.Now.Month)} =)");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
