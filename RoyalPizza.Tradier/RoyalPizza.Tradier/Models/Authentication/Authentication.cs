using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Authentication
{
    /// <summary>
    /// 
    /// </summary>
    public class Token
    {
        /// <summary>
        /// Your access token
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Time in seconds before token expires
        /// </summary>
        [JsonPropertyName("expires_in")]
        public DateTime ExpiresIn { get; set; }

        /// <summary>
        /// Date timestamp when the token was issued
        /// </summary>
        [JsonPropertyName("issued_at")]
        public DateTime IssuedAt { get; set; }

        /// <summary>
        /// Your refresh token (if enabled)
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public int RefreshToken { get; set; }

        /// <summary>
        /// 	Authorized scope of the token
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Current status of the token -- this is for future use only
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}