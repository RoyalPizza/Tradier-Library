namespace RoyalPizza.Tradier.DataLayer.Authentication
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthenticationScopeEnum
    {
        /// <summary>
        /// 	Read-only access to account data
        /// </summary>
        read,

        /// <summary>
        /// Write access to account data (does not include placing or updating trades)
        /// </summary>
        write,

        /// <summary>
        /// 	Access market data (does not include streaming)
        /// </summary>
        market,

        /// <summary>
        /// Update, cancel and place trades
        /// </summary>
        trade,

        /// <summary>
        /// Create streaming sessions for use with the Streaming API
        /// </summary>
        stream
    }
}
