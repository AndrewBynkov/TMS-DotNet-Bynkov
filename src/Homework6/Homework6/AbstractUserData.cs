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
        BYN,
        Unknown
    }
    public abstract class AbstractATM
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
