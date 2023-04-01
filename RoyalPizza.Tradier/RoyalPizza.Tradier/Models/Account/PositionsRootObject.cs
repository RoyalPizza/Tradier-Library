using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class PositionsRootobject
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("positions")]
        public Positions? Positions { get; set; }
    }
}
