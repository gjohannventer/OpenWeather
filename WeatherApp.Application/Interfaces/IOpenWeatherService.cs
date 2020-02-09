using WeatherApp.Common;

namespace WeatherApp.Application.Interfaces
{
    public interface IOpenWeatherService
    {
        Result<string> GetCityWeatherInformation(string cityId);
    }
}