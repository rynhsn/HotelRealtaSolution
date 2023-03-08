using Microsoft.AspNetCore.Components;
using Realta.Contract.Models;
using Realta.Frontend.HttpRepository;
using System.Diagnostics.Contracts;

namespace Realta.Frontend.Pages.Booking
{
    public partial class Special_Offers
    {
        public List<SpecialOffersDto> SpecialOffersList { get; set; } = new List<SpecialOffersDto>();
        [Inject]
        public ISpecialOffersHttpRepo SpecialOffersRepo { get; set; }


        protected async override Task OnInitializedAsync()
        {
            
            SpecialOffersList = await SpecialOffersRepo.GetSpecialOffers();

            foreach (var item in SpecialOffersList)
            {
                Console.WriteLine(item.SpofId);
            }
        }
    }
}
