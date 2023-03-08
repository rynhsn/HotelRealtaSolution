using Realta.Contract;

namespace Realta.Frontend.HttpRepository
{
    public interface IStocksRepository
    {
        Task<List<StocksDto>> GetStocks();

    }
}
