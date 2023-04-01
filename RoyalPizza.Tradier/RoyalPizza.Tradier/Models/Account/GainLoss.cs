using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class GainLoss
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("closed_position")]
        public List<GainLossClosedPosition> ClosedPosition { get; set; }
    }
}
