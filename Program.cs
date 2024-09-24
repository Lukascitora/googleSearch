using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using GoogleSearchApp;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

// P�id�n� HttpClient s z�kladn� adresou (pokud je pot�eba)
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Pokud pou��v�te serverovou aplikaci, nemus� b�t pot�eba WebAssemblyHostBuilder

await builder.Build().RunAsync();
