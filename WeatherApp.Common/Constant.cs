namespace WeatherApp.Common
{
    public class Constant
    {
        public static string WeatherBaseUrl = "http://api.openweathermap.org/data/2.5/weather";
        public static string ApiKey = "108b11a0259601a3f430dfa5bc4957a4"; // In real world application should be stored in config file for different environments;
        
        public class City
        {
            public static string CapeTown = "Cape Town";
        }
    }
}
