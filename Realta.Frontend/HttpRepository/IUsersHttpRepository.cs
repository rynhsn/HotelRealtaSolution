using Realta.Contract.Models;

namespace Realta.Frontend.HttpRepository
{
    public interface IUsersHttpRepository
    {
        Task<List<UsersDto>> GetUsers();
    }
}
