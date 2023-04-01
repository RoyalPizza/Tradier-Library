using System.ComponentModel;

namespace RoyalPizza.Tradier.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrderSide
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0,

        /// <summary>
        /// 
        /// </summary>
        [Description("buy")]
        Equity_Buy = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("buy_to_cover")]
        Equity_Buy_To_Cover = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("sell")]
        Equity_Sell = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("sell_short")]
        Equity_Sell_Short = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description("buy_to_open")]
        Option_Buy_To_Open = 16,

        /// <summary>
        /// 
        /// </summary>
        [Description("buy_to_close")]
        Option_Buy_To_Close = 32,

        /// <summary>
        /// 
        /// </summary>
        [Description("sell_to_open")]
        Option_Sell_To_Open = 64,

        /// <summary>
        /// 
        /// </summary>
        [Description("sell_to_close")]
        Option_Sell_To_Close = 128
    }
}
