using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class Orders
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("order")]
        public List<Order> Order { get; set; }
    }
}
