using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class GainLossClosedPosition
    {
        /// <summary>
        /// Date the position was closed
        /// </summary>
        [JsonPropertyName("close_date")]
        public DateTime CloseDate { get; set; }

        /// <summary>
        /// Total cost of the position
        /// </summary>
        [JsonPropertyName("cost")]
        public decimal Cost { get; set; }

        /// <summary>
        /// Gain or loss on the position
        /// </summary>
        [JsonPropertyName("gain_loss")]
        public decimal GainLoss { get; set; }

        /// <summary>
        /// Gain or loss represented as percent
        /// </summary>
        [JsonPropertyName("gain_loss_percent")]
        public decimal GainLossPercent { get; set; }

        /// <summary>
        /// Date the position was opened
        /// </summary>
        [JsonPropertyName("open_date")]
        public DateTime OpenDate { get; set; }

        /// <summary>
        /// Total amount received for the position
        /// </summary>
        [JsonPropertyName("proceeds")]
        public decimal Proceeds { get; set; }

        /// <summary>
        /// Quantity of shares/contracts
        /// </summary>
        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Symbol of the security held
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;

        /// <summary>
        /// Term in months position was held
        /// </summary>
        [JsonPropertyName("term")]
        public int Term { get; set; }
    }
}
