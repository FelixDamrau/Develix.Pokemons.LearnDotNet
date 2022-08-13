using Develix.Pokemons.State.PokedexUseCase;
using Develix.Pokemons.UI.Blazor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using PokeApiNet;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddFluxor(op => op.ScanAssemblies(typeof(PokedexState).Assembly));
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<PokeApiClient>();
builder.Services.AddMudServices();

await builder.Build().RunAsync();
