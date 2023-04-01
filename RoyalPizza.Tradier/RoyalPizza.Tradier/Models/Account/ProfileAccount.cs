using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class ProfileAccount
    {
        /// <summary>
        /// Account number
        /// </summary>
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; } = string.Empty;

        /// <summary>
        /// Class of account. One of: individual, entity, individual, joint_survivor, joint_survivor, traditional_ira, roth_ira, rollover_ira, entity, sep_ira
        /// </summary>
        [JsonPropertyName("classification")]
        public string Classification { get; set; } = string.Empty;

        /// <summary>
        /// Date account was created
        /// </summary>
        [JsonPropertyName("date_created")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Marked as day trader
        /// </summary>
        [JsonPropertyName("day_trader")]
        public bool DayTrader { get; set; }

        /// <summary>
        /// Account option level (1-6)
        /// </summary>
        [JsonPropertyName("option_level")]
        public int OptionLevel { get; set; }

        /// <summary>
        /// Current status of the account: One of: active, closed
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Type of the account. One of: cash, margin
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Date account was last updated
        /// </summary>
        [JsonPropertyName("last_update_date")]
        public DateTime LastUpdateDate { get; set; }
    }
}
