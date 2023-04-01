using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Cost of the position
        /// </summary>
        [JsonPropertyName("cost_basis")]
        public decimal CostBasis { get; set; }

        /// <summary>
        /// Date position was acquired (or most recently updated)
        /// </summary>
        [JsonPropertyName("date_acquired")]
        public DateTime DateAcquired { get; set; }

        /// <summary>
        /// Unique position identifier
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        ///  	Number of shares/contracts (positive numbers indicate long positions, negative numbers indicate short positions)
        /// </summary>
        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Security symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
    }
}