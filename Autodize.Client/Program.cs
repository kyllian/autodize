using Autodize.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<Notifier>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();
