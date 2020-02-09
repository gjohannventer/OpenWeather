using WeatherApp.Application.Interfaces;

namespace WeatherApp.Application
{
    public class WeatherQueryService : IWeatherQueryService
    {
        private readonly IWeatherCityRepository _weatherCityRepository;
        private readonly IOpenWeatherService _weatherCityService;
        public WeatherQueryService(IWeatherCityRepository weatherCityRepository,
            IOpenWeatherService weatherCityService)
        {
            _weatherCityRepository = weatherCityRepository;
            _weatherCityService = weatherCityService;
        }

        public string Execute(string cityName, IFormat formatter)
        {
            var cityResult = _weatherCityRepository.GetOpenWeatherCityId(cityName);
            if (cityResult.IsFailure)
                return cityResult.Error;
            
            var weatherInformationResult = _weatherCityService.GetCityWeatherInformation(cityResult.Value);
            return weatherInformationResult.IsSuccess ? formatter.Format(weatherInformationResult.Value) : weatherInformationResult.Error;
        }
    }
}
