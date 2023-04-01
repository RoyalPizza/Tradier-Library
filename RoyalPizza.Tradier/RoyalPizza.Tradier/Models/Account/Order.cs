using RoyalPizza.Tradier.Enums;
using System.Text.Json.Serialization;

namespace RoyalPizza.Tradier.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Unique identifier for the order
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Single-leg, One of: market, limit, stop, stop_limit, Multi-leg, One of: market, debit, credit, even
        /// </summary>
        [JsonPropertyName("type")]
        public OrderType Type { get; set; }

        /// <summary>
        /// Security symbol or underlying security symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;

        /// <summary>
        /// Equity, One of: buy, buy_to_cover, sell, sell_short, Option, One of: buy_to_open, buy_to_close, sell_to_open, sell_to_close
        /// </summary>
        [JsonPropertyName("side")]
        public OrderSide Side { get; set; }

        /// <summary>
        /// Number of shares or contracts
        /// </summary>
        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// One of: open, partially_filled, filled, expired, canceled, pending, rejected, error
        /// </summary>
        [JsonPropertyName("status")]
        public OrderStatus Status { get; set; }

        /// <summary>
        /// One of: day, pre, post, gtc
        /// </summary>
        [JsonPropertyName("duration")]
        public OrderDuration Duration { get; set; }

        /// <summary>
        /// Limit price
        /// </summary>
        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Average fill price
        /// </summary>
        [JsonPropertyName("avg_fill_price")]
        public decimal AverageFillPrice { get; set; }

        /// <summary>
        /// Total number of shares/contracts filled
        /// </summary>
        [JsonPropertyName("exec_quantity")]
        public decimal ExecutedQuantity { get; set; }

        /// <summary>
        /// Last fill price
        /// </summary>
        [JsonPropertyName("last_fill_price")]
        public decimal LastFillPrice { get; set; }

        /// <summary>
        /// Last fill quantity
        /// </summary>
        [JsonPropertyName("last_fill_quantity")]
        public decimal LastFillQuantity { get; set; }

        /// <summary>
        /// Number of shares/contracts remaining
        /// </summary>
        [JsonPropertyName("remaining_quantity")]
        public decimal RemainingQuantity { get; set; }

        /// <summary>
        /// Date the order was created
        /// </summary>
        [JsonPropertyName("create_date")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Date the order was last updated
        /// </summary>
        [JsonPropertyName("transaction_date")]
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// One of: equity, option, combo, multileg
        /// </summary>
        [JsonPropertyName("class")]
        public OrderClass Class { get; set; }

        /// <summary>
        /// OCC option symbol
        /// </summary>
        [JsonPropertyName("option_symbol")]
        public string OptionSymbol { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("num_legs")]
        public int? NumberOfLegs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("strategy")]
        public string Strategy { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("leg")]
        public List<OrderLeg> Legs { get; set; } = new List<OrderLeg>();
    }
}
