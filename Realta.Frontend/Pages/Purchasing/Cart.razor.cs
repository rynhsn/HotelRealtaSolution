using Microsoft.AspNetCore.Components;
using Realta.Contract.Models;
using Realta.Frontend.HttpRepository;

namespace Realta.Frontend.Pages.Purchasing;

public partial class Cart
{
    [Inject] public ICartHttpRepository? CartRepo { get; set; }
    public List<CartDto> CartList { get; set; } = new List<CartDto>();

    protected override async Task OnInitializedAsync()
    {
        CartList = await CartRepo.GetCarts();
    }
}