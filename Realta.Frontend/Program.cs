using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Realta.Frontend;
using Realta.Frontend.HttpRepository.CategoryGroup;
using Realta.Frontend.HttpRepository.Locations;
using Realta.Frontend.HttpRepository.Policy;
using Realta.Frontend.HttpRepository.PriceItems;
using Realta.Frontend.HttpRepository.ServiceTask;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7068/api/") });

builder.Services.AddScoped<ICategoryGroupHttpRepository,CategoryGroupHttpRepository>();
builder.Services.AddScoped<IPriceItemsHttpRepository, PriceItemsHttpRepository>();
builder.Services.AddScoped<IPolicyHttpRepository, PolicyHttpRepository>();
builder.Services.AddScoped<IServiceTaskHttpRepository, ServiceTaskHttpRepository>();
builder.Services.AddScoped<IRegionsHttpRepository, RegionsHttpRepository>();
builder.Services.AddScoped<ICountryHttpRepository, CountryHttpRepository>();
builder.Services.AddScoped<IProvincesHttpRepository, ProvincesHttpRepository>();
builder.Services.AddScoped<IAddressHttpRepository, AddressHttpRepository>();
await builder.Build().RunAsync();
