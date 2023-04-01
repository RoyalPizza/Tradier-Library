using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class HistoryEventTrade
    {
        /// <summary>
        /// Commission
        /// </summary>
        [JsonPropertyName("commission")]
        public decimal Commission { get; set; }

        /// <summary>
        /// Text description of event
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Price
        /// </summary>
        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;

        /// <summary>
        /// ecurity type of the trade (Equity, Option)
        /// </summary>
        [JsonPropertyName("trade_type")]
        public string TradeType { get; set; } = string.Empty;
    }
}
