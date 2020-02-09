using System.Collections.Generic;
using WeatherApp.Application.Interfaces;
using WeatherApp.Common;

namespace WeatherApp.Persistance
{
    public class WeatherCityRepository : IWeatherCityRepository
    {
        private static readonly Dictionary<string, string> Cities = new Dictionary<string, string> { // Mimicking kinda like a database for values
            { Constant.City.CapeTown , "3369157" }
        };

        public Result<string> GetOpenWeatherCityId(string cityName)
        {
            if (Cities.TryGetValue(cityName, out string value))
                return new Result<string>(value);

            return new Result<string>(false, "City was not Found");
        }
    }
}
