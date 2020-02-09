namespace WeatherApp.Application.Interfaces
{
    public interface IFormatFactory
    {
        IFormat CreateRawJsonFormat();
        IFormat CreateFormattedJsonFormat();
        IFormat CreatePublicFormat();
    }
}
