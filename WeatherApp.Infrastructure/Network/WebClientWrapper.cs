using System;
using System.Net;
using WeatherApp.Common;

namespace WeatherApp.Infrastructure.Network
{
    public class WebClientWrapper : IWebClientWrapper
    {
        public Result<string> Get(string address)
        {
            try
            {
                using var client = new WebClient();
                var result = client.DownloadString(address);
                return new Result<string>(result);
            }
            catch (Exception ex)
            {
                return new Result<string>(false, ex.Message);
            }           
        }
    }
}
