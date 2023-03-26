using Blazored.LocalStorage;

namespace SpaceTraders.Ui.Services
{
    public class LocalStorageService
    {
        private readonly ILocalStorageService _localStorageService;


        public LocalStorageService(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        /// <summary>
        /// Save a string value to the local browsers storage
        /// </summary>
        /// <param name="name">The identity key</param>
        /// <param name="value">The value to store</param>
        public async ValueTask Save(string name, string value)
            => await _localStorageService.SetItemAsStringAsync(name, value);

        /// <summary>
        /// Fetches a value from the browsers storage
        /// </summary>
        /// <param name="name">The identity key to return</param>
        /// <returns>The string value that matched the identity key</returns>
        public async ValueTask<string> Load(string name)
            => await _localStorageService.GetItemAsStringAsync(name);

        /// <summary>
        /// Removes a value based on the provided identity from the browser storage
        /// </summary>
        /// <param name="name">The identity key to remove</param>
        public async ValueTask Delete(string name)
            => await _localStorageService.RemoveItemAsync(name);
    }
}
