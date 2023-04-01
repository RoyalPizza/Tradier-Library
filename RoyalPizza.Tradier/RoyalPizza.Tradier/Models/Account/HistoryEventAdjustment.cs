using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class HistoryEventAdjustment
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }
    }
}
