using BlazorWasm.Component;
using System.Text.Json;

namespace Realta.Frontend.HttpRepository
{
    public class SpecialOffersHttpRepo : ISpecialOffersHttpRepo
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _options;


        public SpecialOffersHttpRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<List<SpecialOffersDto>>GetSpecialOffers()
        {
            // CALL API END POINT, e.g : http://localhost:7068/api/SpecialOffers
            var response = await _httpClient.GetAsync("SpecialOffers");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var specialOffers = JsonSerializer.Deserialize<List<SpecialOffersDto>>(content,_options);
            return specialOffers;
        }

    }
}
