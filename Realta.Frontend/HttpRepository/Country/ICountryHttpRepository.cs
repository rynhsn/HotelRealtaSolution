using Realta.Contract.Models;

namespace Realta.Frontend.HttpRepository.Locations
{
    public interface ICountryHttpRepository
    {
        Task<List<CountryDto>> GetCountry();

    }
}
