using SpaceTraders.Ui.Models;
using System.Net.Http.Json;

namespace SpaceTraders.Ui.Services
{
    public class ApiService : IDisposable
    {
        private readonly HttpClient _httpClient;
        private bool disposedValue;
        private Actor _actor = new();

        public Actor Actor 
        {
            get
            {
                return _actor;
            }

            set
            {
                _actor = value;

                if (value.Token != null)
                {
                    _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {value}");
                }
            }
        }

        /// <summary>
        /// Configure the API service
        /// </summary>
        public ApiService()
        {
            _httpClient = new()
            {
                BaseAddress = new Uri("https://api.spacetraders.io")
            };
        }

        /// <summary>
        /// Calls the API and attempts to parse the JSON response
        /// </summary>
        /// <typeparam name="T">The model that the response is expected to be</typeparam>
        /// <param name="path">The API endpoint path</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The API response as a parsed object <typeparamref name="T"/></returns>
        public async ValueTask<T?> Get<T>(string path, CancellationToken cancellationToken = default)
            => await _httpClient.GetFromJsonAsync<T>(path, cancellationToken);

        /// <summary>
        /// Posts to the API with no content
        /// </summary>
        /// <param name="path">The API endpoint path</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The API response message</returns>
        public async ValueTask<HttpResponseMessage> Post(string path, CancellationToken cancellationToken = default)
            => await _httpClient.PostAsync(path, null, cancellationToken);

        /// <summary>
        /// Posts to the API with JSON body payload
        /// </summary>
        /// <param name="path">The API endpoint path</param>
        /// <param name="value">The body payload</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The API response message</returns>
        public async ValueTask<HttpResponseMessage> PostContent<T>(string path, T value, CancellationToken cancellationToken = default)
            => await _httpClient.PostAsJsonAsync<T>(path, value, cancellationToken);

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _httpClient.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
