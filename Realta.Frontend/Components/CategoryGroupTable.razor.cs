using Microsoft.AspNetCore.Components;
using Realta.Contract.Models;

namespace Realta.Frontend.Components
{
    public partial class CategoryGroupTable
    {
        [Parameter]
        public List<CategoryGroupDto> CategoryGroups { get; set; }
    }
}
