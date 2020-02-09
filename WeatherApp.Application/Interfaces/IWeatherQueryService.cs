using WeatherApp.Application.Formatters;

namespace WeatherApp.Application.Interfaces
{
    public interface IWeatherQueryService
    {
        string Execute(string cityName, IFormat format);
    }
}