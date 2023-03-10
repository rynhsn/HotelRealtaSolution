using Microsoft.AspNetCore.Components;
using Realta.Contract.Models;
using Realta.Frontend.HttpRepository;

namespace Realta.Frontend.Pages.Purchasing
{
    public partial class Stocks
    {
        public List<StocksDto> stocksList { get; set; } = new List<StocksDto>();

        [Inject]
        public IStocksRepository StocksRepo { get; set; } 


        protected async override Task OnInitializedAsync()
        {
            stocksList = await StocksRepo.GetStocks();

        }

        
    }
}
