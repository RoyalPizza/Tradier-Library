using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class GainLossRootobject
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("gainloss")]
        public GainLoss? GainLoss { get; set; }
    }
}
