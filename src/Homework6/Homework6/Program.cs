using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter user name: ");
            var userName = Console.ReadLine();
            var currencyOperation = new CurrensyOperation(userName);

            Func <string> getTypeOfCurrency;
            getTypeOfCurrency = currencyOperation.TypeOfUserCurrency;

            Func <decimal> operation;
            operation = currencyOperation.GetMoney;
            operation += currencyOperation.PutMoney;

            Action GetBallanceInfo;
            GetBallanceInfo = currencyOperation.UserAccauntBallanceInfo;

            getTypeOfCurrency();
            operation();
            Console.WriteLine();
            GetBallanceInfo();
        }
    }
}
