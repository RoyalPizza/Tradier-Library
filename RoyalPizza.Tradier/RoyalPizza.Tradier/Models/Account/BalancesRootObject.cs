using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class BalancesRootObject
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("balances")]
        public Balances? Balances { get; set; }
    }
}
