using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class Positions
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("position")]
        public List<Position> Position { get; set; } = new List<Position>();
    }
}
