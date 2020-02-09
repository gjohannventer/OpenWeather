using WeatherApp.Common;

namespace WeatherApp.Infrastructure.Network
{
    public interface IWebClientWrapper
    {
        Result<string> Get(string address);
    }
}
