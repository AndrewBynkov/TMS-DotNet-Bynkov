﻿using System;
using System.Collections.Generic;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter user name: ");
            var userName = Console.ReadLine();

            var userLanguage = new Language();
            userLanguage.Massage += userLanguage.MassageGoodMorning;

            var currencyOperation = new CurrensyOperation(userName);

            Func<string> getTypeOfCurrency;
            getTypeOfCurrency =  userLanguage.GetUserLanguage;
            getTypeOfCurrency += currencyOperation.TypeOfUserCurrency;

            Func<decimal> Operation;
            Operation = currencyOperation.GetMoney;
            Operation += currencyOperation.PutMoney;

            Action GetBallanceInfo;
            GetBallanceInfo = currencyOperation.UserAccauntBallanceInfo;

            getTypeOfCurrency?.Invoke();
            Operation?.Invoke();
            GetBallanceInfo?.Invoke();

            List<int> _stringer = new List<int>();
            _stringer.Add(14);

            //LINQ
            //Ananim obj
            //method rash
        }
    }
}
