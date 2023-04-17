using CallingExternalAPIs.Services;

var builder = WebApplication.CreateBuilder(args);

#region Default

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#endregion

#region 

builder.Services.AddHttpClient<IWeatherService, WeatherService>(
    client =>
    {
        client.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/weather/");
    });

#endregion

var app = builder.Build();

#region Middlewares

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

#endregion
