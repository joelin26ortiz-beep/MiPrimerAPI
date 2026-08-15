using System.Net.Http;

namespace MiPrimerAPI.Services
{
    public class ExternalApiService
    {
        private readonly HttpClient _httpClient;

        public ExternalApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string?> GetUsersAsync()
        {
            // Consumir el endpoint público permitido para el proyecto y devolver el JSON como string
            return await _httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/users");
        }
    }
}
