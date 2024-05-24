using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Api.Controllers;

[ApiController]
[Route("/api/weather")]
[Produces("application/json")]
public class WeatherController : ControllerBase
{
    [HttpGet("weather")]
    public ActionResult<WeatherResult> GetWeather(
        [Required, FromQuery] string location,
        [FromQuery] DateOnly? date)
    {
        var result = new WeatherResult
        {
            Name = location,
            City = Guid.NewGuid().ToString(),
            GivenDate = date ?? DateOnly.FromDateTime(DateTime.Today),
        };

        return Ok(result);
    }
}
