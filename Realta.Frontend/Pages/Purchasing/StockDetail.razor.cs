using Microsoft.AspNetCore.Components;
using Realta.Contract.Models;
using Realta.Frontend.HttpRepository;

namespace Realta.Frontend.Pages.Purchasing
{
    public partial class StockDetail
    {
        [Parameter] public int Id { get; set; }
        public List<StockDetailDto> stockDetailList { get; set; } = new List<StockDetailDto>();

        [Inject]
        public IStockDetailRepository StockDetailRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            stockDetailList = await StockDetailRepo.GetStockDetail(Id);
        }
    }
}
