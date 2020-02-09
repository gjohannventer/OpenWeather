using Newtonsoft.Json;
using WeatherApp.Application.Interfaces;
using WeatherApp.Application.Model;

namespace WeatherApp.Application.Formatters
{
    public class PublicFormat : IFormat
    {
        private readonly IFormat _format;
        public PublicFormat(IFormat format)
        {
            _format = format;
        }
        public string Format(string data)
        {
            var rawWeather = JsonConvert.DeserializeObject<OpenWeatherPublicModel>(data);
            var json = JsonConvert.SerializeObject(rawWeather);
            return _format.Format(json);
        }
    }
}
