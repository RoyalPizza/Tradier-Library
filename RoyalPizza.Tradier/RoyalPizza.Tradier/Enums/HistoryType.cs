using System.ComponentModel;

namespace RoyalPizza.Tradier.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum HistoryType
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0,

        /// <summary>
        /// 
        /// </summary>
        [Description("trade")]
        Trade = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("option")]
        Option = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("ach")]
        Ach = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("wire")]
        Wire = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description("dividend")]
        Dividend = 16,

        /// <summary>
        /// 
        /// </summary>
        [Description("fee")]
        Fee = 32,

        /// <summary>
        /// 
        /// </summary>
        [Description("tax")]
        Tax = 64,

        /// <summary>
        /// 
        /// </summary>
        [Description("journal")]
        Journal = 128,

        /// <summary>
        /// 
        /// </summary>
        [Description("check")]
        Check = 256,

        /// <summary>
        /// 
        /// </summary>
        [Description("transfer")]
        Transfer = 512,

        /// <summary>
        /// 
        /// </summary>
        [Description("adjustment")]
        Adjustment = 1024,

        /// <summary>
        /// 
        /// </summary>
        [Description("interest")]
        Interest = 2048
    }
}
