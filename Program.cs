using VoyaQuest.Components;
using DotNetEnv;
using VoyaQuest.Interfaces;
using VoyaQuest.Services;

namespace VoyaQuest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Load environment variables from the .env file
            Env.Load();

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // Add HttpClient for Amadeus API Service
            builder.Services.AddHttpClient<IAirportAutocompleteService, AmadeusAutocompleteService>();

            //Register the FlightSearchService
            builder.Services.AddHttpClient<IFlightServiceSearch, FlightServiceSearch>();

            //Register the HotelbedsService
            builder.Services.AddHttpClient<IHotelbedsService, HotelbedsService>();

            //Register the CurrencyService
            builder.Services.AddHttpClient<ICurrencyService, CurrencyService>();

            //Register the cache service
            builder.Services.AddMemoryCache();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
