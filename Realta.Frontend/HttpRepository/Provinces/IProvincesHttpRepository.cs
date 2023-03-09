using Realta.Contract.Models;

namespace Realta.Frontend.HttpRepository.Locations
{
    public interface IProvincesHttpRepository
    {
        Task<List<ProvincesDto>> GetProvinces();
    }
}
