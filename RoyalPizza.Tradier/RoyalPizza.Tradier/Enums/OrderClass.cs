using System.ComponentModel;

namespace RoyalPizza.Tradier.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrderClass
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("equity")]
        Equity = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("option")]
        Option,

        /// <summary>
        /// 
        /// </summary>
        [Description("combo")]
        Combo,

        /// <summary>
        /// 
        /// </summary>
        [Description("multileg")]
        Multileg
    }
}
