using System.Net.Http.Json;

namespace MiPrimerAPI.Services
{
    public class ExternalApiService
    {
        private readonly HttpClient _httpClient;

        public ExternalApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<object?> GetUsersAsync()
        {
            // Consume el endpoint público de JsonPlaceholder
            var response = await _httpClient.GetFromJsonAsync<object>("https://jsonplaceholder.typicode.com/users");
            return response;
        }
    }
}