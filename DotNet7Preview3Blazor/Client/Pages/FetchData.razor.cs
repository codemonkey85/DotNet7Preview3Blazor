namespace DotNet7Preview3Blazor.Client.Pages;

public partial class FetchData
{
    private WeatherForecast[]? forecasts;

    protected override async Task OnInitializedAsync() => forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
}
