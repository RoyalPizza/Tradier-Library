using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class HistoryEventJournal
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
