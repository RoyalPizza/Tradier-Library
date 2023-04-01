using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class ProfileRootObject
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("profile")]
        public Profile? Profile { get; set; }
    }
}
