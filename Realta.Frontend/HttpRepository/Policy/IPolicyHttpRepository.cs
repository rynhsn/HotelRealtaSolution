using Realta.Contract.Models;

namespace Realta.Frontend.HttpRepository.Policy
{
    public interface IPolicyHttpRepository
    {
        Task<List<PolicyDto>> GetPolicy();
    }
}
