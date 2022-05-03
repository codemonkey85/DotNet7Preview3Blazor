namespace DotNet7Preview3Blazor.Server.Endpoints;

public static class WeatherForecastEndpoints
{
    public static void MapWeatherForecastEndpoints(this IEndpointRouteBuilder app) => app.MapGet("WeatherForecast", Get);

    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public static IEnumerable<WeatherForecast> Get() => Enumerable.Range(1, 5).Select(index => new WeatherForecast
    {
        Date = DateTime.Now.AddDays(index),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    }).ToArray();
}
