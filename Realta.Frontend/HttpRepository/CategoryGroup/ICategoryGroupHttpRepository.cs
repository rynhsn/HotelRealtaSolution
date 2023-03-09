using Realta.Contract.Models;

namespace Realta.Frontend.HttpRepository.CategoryGroup
{
    public interface ICategoryGroupHttpRepository
    {
        Task<List<CategoryGroupDto>> GetCategoryGroup();

    }
}
