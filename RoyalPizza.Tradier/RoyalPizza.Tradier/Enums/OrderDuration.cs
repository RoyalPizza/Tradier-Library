using System.ComponentModel;

namespace RoyalPizza.Tradier.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrderDuration
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("day")]
        Day = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("gtc")]
        Gtc,

        /// <summary>
        /// 
        /// </summary>
        [Description("pre")]
        Pre,

        /// <summary>
        /// 
        /// </summary>
        [Description("post")]
        Post
    }
}
