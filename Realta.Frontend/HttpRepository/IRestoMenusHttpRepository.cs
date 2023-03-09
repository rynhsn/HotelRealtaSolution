using Realta.Contract.Models;

namespace Realta.Frontend.HttpRepository
{
    public interface IRestoMenusHttpRepository
    {
        Task<List<RestoMenusDto>> GetProducts();
    }
}
