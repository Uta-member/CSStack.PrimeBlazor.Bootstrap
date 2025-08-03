using CSStack.PrimeBlazor.Bootstrap;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddPrimeBlazorBootstrap();

await builder.Build().RunAsync();