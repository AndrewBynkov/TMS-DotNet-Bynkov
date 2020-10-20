using System;

namespace Homework6
{
    public class CurrensyOperation : AbstractATM, ICurrensyOperation
    {
        public CurrensyOperation(string name)
        {
            _userName = name;
        }

        private string _userName;

        public decimal SumOfPutMoney { get; private set; }

        public decimal SumOfGetMoney { get; private set; }

        public string TypeOfUserCurrency()
        {
            Console.Write("Enter type of currensy: ");
            Carrency = Console.ReadLine();

            return Carrency switch
            {
                "BYN" => EnumCurrency.BYN.ToString(),
                "USD" => EnumCurrency.USD.ToString(),
                "EUR" => EnumCurrency.EUR.ToString(),
                "RUB" => EnumCurrency.RUB.ToString(),
                _ => EnumCurrency.Unknown.ToString(),
            };
        }

        public decimal GetMoney()
        {
            Console.Write("Enter the sum of get money: ");
            var canParse = false;

            do
            {
                canParse = decimal.TryParse(Console.ReadLine(), out decimal val);
                SumOfGetMoney = val;
            }
            while (!canParse);

            return SumOfGetMoney;
        }

        public decimal PutMoney()
        {
            Console.Write("Enter the sum of put money: ");
            var canParse = false;

            do
            {
                canParse = decimal.TryParse(Console.ReadLine(), out decimal val);
                SumOfPutMoney = val;
            }
            while (!canParse);

            return SumOfPutMoney;
        }

        public void UserAccauntBallanceInfo()
        {
            var randBallance = new Random();
            AccountBallance = randBallance.Next(1, 15000);

            Console.WriteLine($"\n{_userName} balance before operation: {AccountBallance} {Carrency}");
            Console.WriteLine($"{_userName} balance after get money: {AccountBallance - SumOfGetMoney} {Carrency}");
            Console.WriteLine($"{_userName} balcnce after put money: {(AccountBallance - SumOfGetMoney) + SumOfPutMoney} {Carrency}");
        }
    }
}
