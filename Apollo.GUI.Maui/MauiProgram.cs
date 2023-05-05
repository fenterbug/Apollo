using Apollo.Counter.Domain;
using Apollo.GUI.Weather.Data;
using Apollo.Persistence.InMemory;
using Microsoft.Extensions.Logging;

namespace Apollo.GUI.Maui
{

    public static class MauiProgram
    {

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();
            builder.Services.AddScoped<IContext, InMemoryContext>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}