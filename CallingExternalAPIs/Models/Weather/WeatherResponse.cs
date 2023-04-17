namespace CallingExternalAPIs.Models;

public record WeatherResponse
{
    public Coord? Coord { get; init; }
    public List<Weather>? Weather { get; init; }
    public string? Base { get; init; }
    public Main? Main { get; init; }
    public int? Visibility { get; init; }
    public Wind? Wind { get; init; }
    public Clouds? Clouds { get; init; }
    public int? Dt { get; init; }
    public Sys? Sys { get; init; }
    public int? Timezone { get; init; }
    public int? Id { get; init; }
    public string? Name { get; init; }
    public int? Cod { get; init; }
}

public record Clouds
{
    public int? All { get; init; }
}

public record Coord
{
    public double? Lon { get; init; }
    public double? Lat { get; init; }
}

public record Main
{
    public double? Temp { get; init; }
    public double? FeelsLike { get; init; }
    public double? TempMin { get; init; }
    public double? TempMax { get; init; }
    public int? Pressure { get; init; }
    public int? Humidity { get; init; }
}

public record Sys
{
    public int? Type { get; init; }
    public int? Id { get; init; }
    public string? Country { get; init; }
    public int? Sunrise { get; init; }
    public int? Suninit { get; init; }
}

public record Weather
{
    public int? Id { get; init; }
    public string? Main { get; init; }
    public string? Description { get; init; }
    public string? Icon { get; init; }
}

public record Wind
{
    public double? Speed { get; init; }
    public int? Deg { get; init; }
}