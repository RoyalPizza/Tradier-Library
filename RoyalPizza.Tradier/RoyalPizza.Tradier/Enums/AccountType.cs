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
        None,

        /// <summary>
        /// 
        /// </summary>
        [Description("Margin")]
        Margin,

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
