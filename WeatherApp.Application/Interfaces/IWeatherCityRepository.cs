using WeatherApp.Common;

namespace WeatherApp.Application.Interfaces
{
    public interface IWeatherCityRepository
    {
        Result<string> GetOpenWeatherCityId(string cityName);
    }
}
