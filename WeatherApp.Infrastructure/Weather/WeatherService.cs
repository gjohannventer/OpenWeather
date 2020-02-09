using WeatherApp.Application.Interfaces;
using WeatherApp.Common;
using WeatherApp.Infrastructure.Network;

namespace WeatherApp.Infrastructure.Weather
{
    public class OpenWeatherService : IOpenWeatherService
    {
        private readonly IWebClientWrapper _webClientWrapper;

        public OpenWeatherService(IWebClientWrapper webClientWrapper)
        {
            _webClientWrapper = webClientWrapper;
        }

        public Result<string> GetCityWeatherInformation(string cityId)
        {
            if (string.IsNullOrEmpty(cityId)) // Handle common conditions and design classes so that exceptions can be avoided
                return new Result<string>("city is not found");
            
            var address = $"{Constant.WeatherBaseUrl}?appid={Constant.ApiKey}&id={cityId}";
            return _webClientWrapper.Get(address);
        }
    }
}

