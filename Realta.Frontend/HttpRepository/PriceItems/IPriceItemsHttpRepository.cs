using Realta.Contract.Models;

namespace Realta.Frontend.HttpRepository.PriceItems
{
    public interface IPriceItemsHttpRepository
    {
        Task<List<PriceItemsDto>> GetPriceItems();
    }
}
