using System.ComponentModel;
using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfileAccountType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("Margin")]
        [JsonPropertyName("margin")]
        Margin = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("Cash")]
        [JsonPropertyName("cash")]
        Cash,

        /// <summary>
        /// 
        /// </summary>
        [Description("Pattern Day Trader")]
        [JsonPropertyName("pdt")]
        PDT
    }
}
