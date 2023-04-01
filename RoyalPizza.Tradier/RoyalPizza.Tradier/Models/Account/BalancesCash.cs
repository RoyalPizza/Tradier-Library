using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class BalancesCash
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("cash_available")]
        public decimal CashAvailable { get; set; }

        /// <summary>
        /// Sweep
        /// </summary>
        [JsonPropertyName("sweep")]
        public int Sweep { get; set; }

        /// <summary>
        /// Cash that is in the account from recent stock or option sales, but has not yet settled; cash from stock sales occurring during the last 2 trading days or from option sales occurring during the previous trading day
        /// </summary>
        [JsonPropertyName("unsettled_funds")]
        public decimal UnsettledFunds { get; set; }
    }
}
