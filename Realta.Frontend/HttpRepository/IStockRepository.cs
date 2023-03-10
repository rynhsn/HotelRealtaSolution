using Realta.Contract.Models;

namespace Realta.Frontend.HttpRepository
{
    public interface IStocksRepository
    {
        Task<List<StocksDto>> GetStocks();

    }
}
