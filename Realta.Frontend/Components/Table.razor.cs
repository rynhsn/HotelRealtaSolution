using Microsoft.AspNetCore.Components;
using Realta.Contract;

namespace Realta.Frontend.Components
{
    public partial class Table
    {
        [Parameter]public List<StocksDto> Stocks { get; set; }
    }
}
