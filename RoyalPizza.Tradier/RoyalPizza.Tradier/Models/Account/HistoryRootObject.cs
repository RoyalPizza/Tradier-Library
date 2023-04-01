using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class HistoryRootobject
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("history")]
        public History? History { get; set; }
    }
}
