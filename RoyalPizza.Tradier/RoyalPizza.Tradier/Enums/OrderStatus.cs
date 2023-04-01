using System.ComponentModel;

namespace RoyalPizza.Tradier.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("ok")]
        Ok = 0,

        /// <summary>
        /// 
        /// </summary>
        [Description("open")]
        Open = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("partially_filled")]
        Partially_Filled = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("filled")]
        Filled = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("expired")]
        Expired = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description("canceled")]
        Canceled = 16,

        /// <summary>
        /// 
        /// </summary>
        [Description("pending")]
        Pending = 32,

        /// <summary>
        /// 
        /// </summary>
        [Description("rejected")]
        Rejected = 64,

        /// <summary>
        /// 
        /// </summary>
        [Description("error")]
        Error = 128
    }
}
