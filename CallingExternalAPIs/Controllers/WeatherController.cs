using CallingExternalAPIs.Models;
using CallingExternalAPIs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CallingExternalAPIs.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WeatherController : ControllerBase
{
    private readonly IWeatherService _weatherService;

    public WeatherController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpGet]
    [Route("{city}")]
    public async Task<ActionResult<WeatherDto>> GetWeather(string city)
    {
        var response = await _weatherService.GetWeatherForCity(city);
        var weatherDto = new WeatherDto(city, response?.Main?.Temp);
        return weatherDto;
    }
}
