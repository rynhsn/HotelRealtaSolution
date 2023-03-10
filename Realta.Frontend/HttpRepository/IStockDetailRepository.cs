using Realta.Contract.Models;

namespace Realta.Frontend.HttpRepository
{
    public interface IStockDetailRepository
    {
        Task<List<StockDetailDto>> GetStockDetail(int id);
    }
}
