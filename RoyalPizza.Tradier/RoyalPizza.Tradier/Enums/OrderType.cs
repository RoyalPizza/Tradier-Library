using System.ComponentModel;

namespace RoyalPizza.Tradier.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrderType
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Single or multi leg
        /// </remarks>
        [Description("market")]
        Market = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("limit")]
        SingleLeg_Limit = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("stop")]
        SingleLeg_Stop = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("stop_limit")]
        SingleLeg_Stop_Limit = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description("debit")]
        MultiLeg_Debit = 16,

        /// <summary>
        /// 
        /// </summary>
        [Description("credit")]
        MultiLeg_Credit = 32,

        /// <summary>
        /// 
        /// </summary>
        [Description("even")]
        MultiLeg_Even = 64
    }
}
