using MarvelHerores.Services.HeroesServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace MarvelHerores
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddHttpClient( "API", client =>
            {
                client.BaseAddress = new Uri(builder.Configuration["ApiBaseUrl"]!);
            });
            builder.Services.AddSingleton<IMarvelService<Hero>, HeroesService>();
            await builder.Build().RunAsync();
        }
    }
}
