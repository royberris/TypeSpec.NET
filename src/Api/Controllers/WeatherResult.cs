namespace Api.Controllers;

public sealed class WeatherResult
{
    public required string Name { get; init; }

    public string? City { get; init; }

    public DateOnly GivenDate { get; init; }
}