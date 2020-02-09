using Microsoft.Extensions.DependencyInjection;
using WeatherApp.Application;
using WeatherApp.Application.Formatters.Factory;
using WeatherApp.Application.Interfaces;
using WeatherApp.Infrastructure.Network;
using WeatherApp.Infrastructure.Weather;
using WeatherApp.Persistance;

namespace WeatherApp
{
    public class Setup
    {
        public static ServiceProvider InitDiContainers()
        {
            return new ServiceCollection()
            .AddSingleton<IFormatFactory, FormatFactory>()
            .AddSingleton<IOpenWeatherService, OpenWeatherService>()
            .AddSingleton<IWeatherCityRepository, WeatherCityRepository>()
            .AddSingleton<IWeatherQueryService, WeatherQueryService>()
            .AddSingleton<IWebClientWrapper, WebClientWrapper>()
            .BuildServiceProvider();
        }
    }
}
