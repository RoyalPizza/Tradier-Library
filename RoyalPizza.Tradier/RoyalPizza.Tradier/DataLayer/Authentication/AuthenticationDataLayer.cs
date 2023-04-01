namespace RoyalPizza.Tradier.DataLayer.Authentication
{
    /// <summary>
    /// 
    /// </summary>
    public class AuthenticationDataLayer
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly HttpClient HttpClient;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="httpClient"></param>
        public AuthenticationDataLayer(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task GetAuthorizationCode(string clientId, AuthenticationScopeEnum authenticationScopeEnum, string query)
        {
            string baseUrl = $"https://api.tradier.com/";
            string url = $"/v1/oauth/authorize?client_id={clientId}&scope={authenticationScopeEnum.ToString()}&state={query}";
            HttpClient.BaseAddress = new Uri(baseUrl);
            var response = await HttpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
        }
    }
}
