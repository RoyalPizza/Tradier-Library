using RoyalPizza.Tradier.Enums;
using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class HistoryEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public HistoryType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("trade")]
        public HistoryEventTrade Trade { get; set; } = new HistoryEventTrade();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("adjustment")]
        public HistoryEventAdjustment Adjustment { get; set; } = new HistoryEventAdjustment();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("option")]
        public HistoryEventOption Option { get; set; } = new HistoryEventOption();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("journal")]
        public HistoryEventJournal Journal { get; set; } = new HistoryEventJournal();
    }
}
