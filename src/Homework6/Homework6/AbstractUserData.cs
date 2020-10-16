using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    /// <summary>
    /// language selection
    /// </summary>
    public enum EnumLanguage
    {
        English,
        Russian,
        Dutch
    }

    /// <summary>
    /// Currency selection
    /// </summary>
    public enum EnumCurrency
    {
        USD,
        RUB,
        EUR,
        BYN
    }
    public abstract class AbstractUserData
    {
        /// <summary>
        /// User Language
        /// </summary>
        public string UserLanguage { get; set; }

        /// <summary>
        /// Carrency (RUB,USD,EUR)
        /// </summary>
        public string Carrency { get; set; }

        /// <summary>
        /// Account balance
        /// </summary>
        public decimal AccountBallance { get; set; }
    }
}
