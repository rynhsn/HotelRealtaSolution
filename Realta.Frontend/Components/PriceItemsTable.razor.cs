using Microsoft.AspNetCore.Components;
using Realta.Contract.Models;

namespace Realta.Frontend.Components
{
    public partial class PriceItemsTable
    {
        [Parameter]
        public List<PriceItemsDto> priceItems { get; set; }
    }
}
