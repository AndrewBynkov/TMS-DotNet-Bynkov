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
        public void UserAccauntBallance();

        /// <summary>
        /// Cash with draw almount
        /// </summary>
        public void CashWithDrawAlamount();
    }
}
