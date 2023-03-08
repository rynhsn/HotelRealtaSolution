using Realta.Contract.Models;

namespace Realta.Frontend.HttpRepository
{
    public interface ICategoryGroupHttpRepository
    {
        Task<List<CategoryGroupDto>> GetCategoryGroup();

    }
}
