using Realta.Contract.Models;

namespace Realta.Frontend.HttpRepository
{
    public interface ISpecialOffersHttpRepo
    {
        Task<List<SpecialOffersDto>> GetSpecialOffers();
    }
}
