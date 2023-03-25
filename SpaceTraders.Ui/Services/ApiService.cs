using System.Net.Http.Json;

namespace SpaceTraders.Ui.Services
{
    public class ApiService
    {
        private const string BaseAddress = "https://api.spacetraders.io";

        /// <summary>
        /// The token to use in the Authorization header
        /// </summary>
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// Calls the API and attempts to parse the JSON response
        /// </summary>
        /// <typeparam name="T">The model that the response is expected to be</typeparam>
        /// <param name="path">The API endpoint path</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The API response as a parsed object <typeparamref name="T"/></returns>
        public async ValueTask<T?> Get<T>(string path, CancellationToken cancellationToken = default)
        {
            using HttpClient httpClient = GetHttpClient();
            return await httpClient.GetFromJsonAsync<T>(path, cancellationToken);
        }

        /// <summary>
        /// Posts to the API with no content
        /// </summary>
        /// <param name="path">The API endpoint path</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The API response message</returns>
        public async ValueTask<HttpResponseMessage> Post(string path, CancellationToken cancellationToken = default)
        {
            using HttpClient httpClient = GetHttpClient();
            return await httpClient.PostAsync(path, null, cancellationToken);
        }

        /// <summary>
        /// Posts to the API with JSON body payload
        /// </summary>
        /// <param name="path">The API endpoint path</param>
        /// <param name="value">The body payload</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The API response message</returns>
        public async ValueTask<HttpResponseMessage> PostContent<T>(string path, T value, CancellationToken cancellationToken = default)
        {
            using HttpClient httpClient = GetHttpClient();
            return await httpClient.PostAsJsonAsync<T>(path, value, cancellationToken);
        }

        /// <summary>
        /// Constructs the HttpClient for calling the API
        /// </summary>
        /// <returns>A configured HttpClient</returns>
        private HttpClient GetHttpClient()
        {
            HttpClient httpClient = new()
            {
                BaseAddress = new Uri(BaseAddress),
            };

            if (!string.IsNullOrEmpty(Token))
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {Token}");
            }

            return httpClient;
        }
    }
}
