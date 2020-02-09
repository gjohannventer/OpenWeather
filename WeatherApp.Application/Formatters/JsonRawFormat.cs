using WeatherApp.Application.Interfaces;

namespace WeatherApp.Application.Formatters
{
    public class JsonRawFormat : IFormat 
    {
        public string Format(string data) // unnecessary but want to keep to the pattern
        {
            return data;
        }
    }
}
