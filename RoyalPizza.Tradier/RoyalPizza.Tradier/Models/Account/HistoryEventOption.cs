using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class HistoryEventOption
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("option_type")]
        public string OptionType { get; set; } = string.Empty;

        /// <summary>
        /// Text description of event
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }
    }
}
