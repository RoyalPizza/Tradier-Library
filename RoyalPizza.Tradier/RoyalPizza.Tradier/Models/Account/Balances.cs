using RoyalPizza.Tradier.Enums;
using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class Balances
    {
        /// <summary>
        /// Value of short option positions
        /// </summary>
        [JsonPropertyName("option_short_value")]
        public decimal OptionShortValue { get; set; }

        /// <summary>
        /// Total account value
        /// </summary>
        [JsonPropertyName("total_equity")]
        public decimal TotalEquity { get; set; }

        /// <summary>
        /// Account number
        /// </summary>
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; } = string.Empty;

        /// <summary>
        /// Type of the account
        /// </summary>
        [JsonPropertyName("account_type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public AccountType AccountType { get; set; }

        /// <summary>
        /// Gain/Loss of current session's closed positions
        /// </summary>
        [JsonPropertyName("close_pl")]
        public decimal ClosePL { get; set; }

        /// <summary>
        /// Account's maintenance margin
        /// </summary>
        [JsonPropertyName("current_requirement")]
        public decimal CurrentRequirement { get; set; }

        /// <summary>
        /// Equity value
        /// </summary>
        [JsonPropertyName("equity")]
        public int Equity { get; set; }

        /// <summary>
        /// Long market value
        /// </summary>
        [JsonPropertyName("long_market_value")]
        public decimal LongMarketValue { get; set; }

        /// <summary>
        /// Market value
        /// </summary>
        [JsonPropertyName("market_value")]
        public decimal MarketValue { get; set; }

        /// <summary>
        /// Total gain/loss of current account's positions
        /// </summary>
        [JsonPropertyName("open_pl")]
        public decimal OpenPL { get; set; }

        /// <summary>
        /// Value of long option positions
        /// </summary>
        [JsonPropertyName("option_long_value")]
        public decimal OptionLongValue { get; set; }

        /// <summary>
        /// Account's total option requirement
        /// </summary>
        [JsonPropertyName("option_requirement")]
        public decimal OptionRequirement { get; set; }

        /// <summary>
        /// Count of all pending/open orders
        /// </summary>
        [JsonPropertyName("pending_orders_count")]
        public int PendingOrdersCount { get; set; }

        /// <summary>
        /// Short market value
        /// </summary>
        [JsonPropertyName("short_market_value")]
        public decimal ShortMarketValue { get; set; }

        /// <summary>
        /// Value of long equity positions
        /// </summary>
        [JsonPropertyName("stock_long_value")]
        public decimal StockLongValue { get; set; }

        /// <summary>
        /// Total cash in the account
        /// </summary>
        [JsonPropertyName("total_cash")]
        public decimal TotalCash { get; set; }

        /// <summary>
        /// Cash unavailable for trading in the account
        /// </summary>
        [JsonPropertyName("uncleared_funds")]
        public decimal UnclearedFunds { get; set; }

        /// <summary>
        /// Amount of cash being held for open orders
        /// </summary>
        [JsonPropertyName("pending_cash")]
        public decimal PendingCash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("margin")]
        public BalancesMargin Margin { get; set; } = new BalancesMargin();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("cash")]
        public BalancesCash Cash { get; set; } = new BalancesCash();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("pdt")]
        public BalancesPatternDayTrader PatternDayTrader { get; set; } = new BalancesPatternDayTrader();
    }
}
