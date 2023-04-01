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
        None,

        /// <summary>
        /// 
        /// </summary>
        [Description("day")]
        Day,

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
