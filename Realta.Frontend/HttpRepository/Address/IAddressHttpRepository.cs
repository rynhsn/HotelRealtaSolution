using Realta.Contract.Models;

namespace Realta.Frontend.HttpRepository.Locations
{
    public interface IAddressHttpRepository
    {
        Task<List<AddressDto>> GetAddress();
    }
}
