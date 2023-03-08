using Microsoft.AspNetCore.Components;
using Realta.Contract.Models;

namespace Realta.Frontend.Components
{
    public partial class SpecialOffersTable
    {
        [Parameter] 
        public List<SpecialOffersDto> SpecialOffers { get; set; }
    }
}
