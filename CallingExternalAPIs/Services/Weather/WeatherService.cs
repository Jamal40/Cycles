using CallingExternalAPIs.Models;
using System.Text.Json;

namespace CallingExternalAPIs.Services;

public class WeatherService : IWeatherService
{
    private readonly HttpClient _client;
    private readonly IConfiguration _configuration;

    JsonSerializerOptions serializerOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public WeatherService(HttpClient client,
        IConfiguration configuration)
    {
        _client = client;
        _configuration = configuration;
    }

    public async Task<WeatherResponse> GetWeatherForCity(string city)
    {
        var apiKey = _configuration.GetValue<string>("APIKey");

        var queryParams = new List<KeyValuePair<string, string?>>
        {
            new("q",city),
            new("units","metric"),
            new("appid",apiKey)
        };
        var query = QueryString.Create(queryParams);

        var response = await _client.GetStringAsync(query.Value);
        var weatherData = JsonSerializer.Deserialize<WeatherResponse>(response, serializerOptions);
        return weatherData ?? new();
    }
}
