using CallingExternalAPIs.Models;

namespace CallingExternalAPIs.Services;

public interface IWeatherService
{
    Task<WeatherResponse> GetWeatherForCity(string city);
}
