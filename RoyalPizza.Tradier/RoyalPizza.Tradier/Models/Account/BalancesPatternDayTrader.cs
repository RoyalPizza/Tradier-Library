using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class BalancesPatternDayTrader
    {
        /// <summary>
        /// Amount that the account is in deficit for trades that have occurred but not been paid for
        /// </summary>
        [JsonPropertyName("fed_call")]
        public int FedCall { get; set; }

        /// <summary>
        ///  	Amount that the account is under the minimum equity required in the account to support the current positions
        /// </summary>
        [JsonPropertyName("maintenance_call")]
        public int MaintenanceCall { get; set; }

        /// <summary>
        /// Amount of funds available to purchase non-marginable securities
        /// </summary>
        [JsonPropertyName("option_buying_power")]
        public decimal OptionBuyingPower { get; set; }

        /// <summary>
        /// Amount of funds available to purchase fully marginable securities
        /// </summary>
        [JsonPropertyName("stock_buying_power")]
        public decimal StockBuyingPower { get; set; }

        /// <summary>
        /// Value of short stocks
        /// </summary>
        [JsonPropertyName("stock_short_value")]
        public int StockShortValue { get; set; }
    }
}
