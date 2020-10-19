using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    public interface ICurrensyOperation
    {
        /// <summary>
        /// Type of currency
        /// </summary>
        public string TypeOfUserCurrency();

        /// <summary>
        /// User accaunt ballance
        /// </summary>
        public void UserAccauntBallanceInfo();

        /// <summary>
        /// User get money
        /// </summary>
        public decimal GetMoney();

        /// <summary>
        /// User put maney
        /// </summary>
        public decimal PutMoney();
    }
}
