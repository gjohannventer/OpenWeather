using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WeatherApp.Application.Interfaces;

namespace WeatherApp.Application.Formatters
{
    class JsonPrettyFormat : IFormat
    {
        public string Format(string data)
        {
            return JValue.Parse(data).ToString(Formatting.Indented);
        }
    }
}
