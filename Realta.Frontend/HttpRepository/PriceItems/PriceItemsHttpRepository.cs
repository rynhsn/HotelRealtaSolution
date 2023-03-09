using Realta.Contract.Models;
using System.Text.Json;

namespace Realta.Frontend.HttpRepository.PriceItems
{
    public class PriceItemsHttpRepository : IPriceItemsHttpRepository
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _options;

        public PriceItemsHttpRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<List<PriceItemsDto>> GetPriceItems()
        {
            //AsyncCallback api end point e.g https://localhost:7068/api/priceitems  
            var response = await _httpClient.GetAsync("priceitems");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var prit = JsonSerializer.Deserialize<List<PriceItemsDto>>(content, _options);
            return prit;
        }
    }
}
