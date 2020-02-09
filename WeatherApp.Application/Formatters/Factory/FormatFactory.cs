using WeatherApp.Application.Interfaces;

namespace WeatherApp.Application.Formatters.Factory
{
    public class FormatFactory : IFormatFactory
    {
        public IFormat CreateRawJsonFormat()
        {
            return new JsonRawFormat();
        }

        public IFormat CreateFormattedJsonFormat()
        {
            return new JsonPrettyFormat();
        }

        public IFormat CreatePublicFormat()
        {
            return new PublicFormat(new JsonPrettyFormat());
        }
    }
}
