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
        None,

        /// <summary>
        /// 
        /// </summary>
        [Description("equity")]
        Equity,

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
