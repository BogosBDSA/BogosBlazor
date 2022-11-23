using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWebAssembly;
using System.Net.Http;
using System.Net.Http.Json;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");



builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});



await builder.Build().RunAsync();
