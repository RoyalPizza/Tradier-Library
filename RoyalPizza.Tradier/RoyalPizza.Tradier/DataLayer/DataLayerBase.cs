using System.Text.Json;

namespace RoyalPizza.Tradier.DataLayer
{
    public abstract class DataLayerBase
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly HttpClient HttpClient;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="httpClient"></param>
        public DataLayerBase(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="uri"></param>
        /// <returns></returns>
        protected async Task<T?> GetFromJsonAsync<T>(string uri)
        {
            var response = await HttpClient.GetAsync(uri);
            var content = await response.Content.ReadAsStringAsync();
            content = ProcessContent(content);
            var result = JsonSerializer.Deserialize<T>(content);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        private string ProcessContent(string content)
        {
            // Tradier returns null with quotes in their JSON. Newtonsoft and System.Text.Json do not support this. Replace with just null
            content = content.Replace("\"null\"", "null");
            return content;
        }
    }
}
