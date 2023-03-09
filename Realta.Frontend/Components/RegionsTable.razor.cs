using Microsoft.AspNetCore.Components;
using Realta.Contract.Models;

namespace Realta.Frontend.Components
{
    public partial class RegionsTable
    {
        [Parameter]
        public List<RegionsDto> Regions { get; set; }

    }
}
