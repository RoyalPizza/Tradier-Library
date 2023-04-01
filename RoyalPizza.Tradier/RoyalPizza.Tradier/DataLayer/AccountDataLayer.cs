using RoyalPizza.Tradier.Models.Account;

namespace RoyalPizza.Tradier.DataLayer
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountDataLayer : DataLayerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="httpClient"></param>
        public AccountDataLayer(HttpClient httpClient) : base(httpClient)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<Profile?> GetProfileAsync()
        {
            string url = "user/profile";
            var profileRootObject = await GetFromJsonAsync<ProfileRootObject>(url);
            return profileRootObject?.Profile;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId">Account number</param>
        /// <returns></returns>
        public async Task<Balances?> GetBalancesAsync(string accountId)
        {
            if (string.IsNullOrEmpty(accountId))
                throw new ArgumentNullException(nameof(accountId));

            string url = $"accounts/{accountId}/balances";
            var balancesRootObject = await GetFromJsonAsync<BalancesRootObject>(url);
            return balancesRootObject?.Balances;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId">Account number</param>
        /// <returns></returns>
        public async Task<Positions?> GetPositionsAsync(string accountId)
        {
            if (string.IsNullOrEmpty(accountId))
                throw new ArgumentNullException(nameof(accountId));

            string url = $"accounts/{accountId}/positions";
            var positionsRootobject = await GetFromJsonAsync<PositionsRootobject>(url);
            return positionsRootobject?.Positions;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId">Account number</param>
        /// <returns></returns>
        public async Task<History?> GetHistoryAsync(string accountId)
        {
            if (string.IsNullOrEmpty(accountId))
                throw new ArgumentNullException(nameof(accountId));

            string url = $"accounts/{accountId}/history";
            var historyRootobject = await GetFromJsonAsync<HistoryRootobject>(url);
            return historyRootobject?.History;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="type"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="symbol"></param>
        /// <param name="exactMatch"></param>
        /// <returns></returns>
        public async Task<History?> GetHistoryAsync(string accountId, int page = 1, int limit = 25, string? type = null, DateTime? startDate = null, DateTime? endDate = null, string? symbol = null, bool exactMatch = false)
        {
            if (string.IsNullOrEmpty(accountId))
                throw new ArgumentNullException(nameof(accountId));

            if (type == null)
                type = "trade, option, ach, wire, dividend, fee, tax, journal, check, transfer, adjustment, interest";
            if (startDate == null)
                startDate = DateTime.Now.Date;
            if (endDate == null)
                endDate = DateTime.Now.Date.AddDays(1);

            string url = $"accounts/{accountId}/history?page={page}&limit={limit}&type={type}&start={startDate}&end={endDate}";

            if (symbol != null)
                url += $"&symbol={symbol}";

            url += $"exactMatch={exactMatch}";

            var historyRootobject = await GetFromJsonAsync<HistoryRootobject>(url);
            return historyRootobject?.History;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId">Account number</param>
        /// <returns></returns>
        public async Task<GainLoss?> GetGainLossAsync(string accountId)
        {
            if (string.IsNullOrEmpty(accountId))
                throw new ArgumentNullException(nameof(accountId));

            string url = $"accounts/{accountId}/gainloss";
            var gainLossRootobject = await GetFromJsonAsync<GainLossRootobject>(url);
            return gainLossRootobject?.GainLoss;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="sortBy"></param>
        /// <param name="sort"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="symbol"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<GainLoss?> GetGainLossAsync(string accountId, int page = 1, int limit = 25, string? sortBy = "closeDate", string? sort = "desc", DateTime? startDate = null, DateTime? endDate = null, string? symbol = null)
        {
            if (string.IsNullOrEmpty(accountId))
                throw new ArgumentNullException(nameof(accountId));

            if (startDate == null)
                startDate = DateTime.Now.Date;
            if (endDate == null)
                endDate = DateTime.Now.Date.AddDays(1);

            string url = $"accounts/{accountId}/gainloss?page={page}&limit={limit}&sortBy={sortBy}&sort={sort}&start={startDate}&end={endDate}";

            if (symbol != null)
                url += $"&symbol={symbol}";

            var gainLossRootobject = await GetFromJsonAsync<GainLossRootobject>(url);
            return gainLossRootobject?.GainLoss;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId">Account number</param>
        /// <param name="includeTags">Include order tag on response</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<Orders?> GetOrdersAsync(string accountId, bool includeTags = false)
        {
            if (string.IsNullOrEmpty(accountId))
                throw new ArgumentNullException(nameof(accountId));

            string url = $"accounts/{accountId}/orders?includeTags={includeTags}";
            var ordersRootobject = await GetFromJsonAsync<OrdersRootobject>(url);
            return ordersRootobject?.Orders;
        }
    }
}
