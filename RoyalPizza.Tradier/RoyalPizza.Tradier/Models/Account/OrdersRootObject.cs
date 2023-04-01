using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class OrdersRootobject
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("orders")]
        public Orders? Orders { get; set; }
    }
}
