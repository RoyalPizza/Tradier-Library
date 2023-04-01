using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class History
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("event")]
        public List<HistoryEvent> Events { get; set; } = new List<HistoryEvent>();
    }
}
