using Realta.Contract.Models;
using System.Text.Json;

namespace Realta.Frontend.HttpRepository
{
    public class StockRepository : IStocksRepository
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _options;

        public StockRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true};
        }

        public async Task<List<StocksDto>> GetStocks()
        {
            // call api end point e.g : http://localhost:7068/api/stocks
            var response = await _httpClient.GetAsync("stocks");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var stocks = JsonSerializer.Deserialize<List<StocksDto>>(content, _options);
            return stocks;
        }
    }
}
