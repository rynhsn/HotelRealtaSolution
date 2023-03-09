using Realta.Contract.Models;

namespace Realta.Frontend.HttpRepository.ServiceTask
{
    public interface IServiceTaskHttpRepository
    {
        Task<List<ServiceTaskDto>> GetServiceTask();
    }
}
