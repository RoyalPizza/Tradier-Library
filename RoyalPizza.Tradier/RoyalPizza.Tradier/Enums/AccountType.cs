using System.ComponentModel;

namespace RoyalPizza.Tradier.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum AccountType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("Margin")]
        Margin = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("Cash")]
        Cash,

        /// <summary>
        /// 
        /// </summary>
        [Description("Pattern Day Trader")]
        PDT
    }
}
