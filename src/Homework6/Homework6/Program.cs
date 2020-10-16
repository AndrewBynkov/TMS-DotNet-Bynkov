using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            GetData();
        }

        private static void GetData()
        {
            var currencyOperation = new CurrensyOperation();

            Predicate<string> predicateCurrensyOperation;
            predicateCurrensyOperation = currencyOperation.TypeOfUserCurrency;
        }
    }
}
