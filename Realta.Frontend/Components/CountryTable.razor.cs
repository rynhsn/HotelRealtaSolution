using Microsoft.AspNetCore.Components;
using Realta.Contract.Models;

namespace Realta.Frontend.Components
{
    public partial class CountryTable
    {
        [Parameter]
        public List<CountryDto> Country { get; set; }
    }
}
