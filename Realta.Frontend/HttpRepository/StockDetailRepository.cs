using Realta.Contract.Models;
using System.Text.Json;

namespace Realta.Frontend.HttpRepository
{
    public class StockDetailRepository : IStockDetailRepository
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _options;

        public StockDetailRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true};
        }

        public async Task<List<StockDetailDto>> GetStockDetail(int id)
        {
            // call api end point e.g : http://localhost:7068/api/stock/{id}
            var url = Path.Combine("stock", id.ToString());
            var response = await _httpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var stockDetail = JsonSerializer.Deserialize<List<StockDetailDto>>(content, _options);
            return stockDetail;
        }
    }
}
