using Realta.Contract.Models;

namespace Realta.Frontend.HttpRepository.Locations
{
    public interface IRegionsHttpRepository
    {
        Task<List<RegionsDto>> GetRegions();

    }
}
