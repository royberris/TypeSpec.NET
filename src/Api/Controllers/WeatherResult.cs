using System.ComponentModel.DataAnnotations;

namespace Api.Controllers;

public sealed class WeatherResult
{
    [Required]
    public required string Name { get; init; }

    public string? City { get; init; }

    public DateOnly GivenDate { get; init; }
}