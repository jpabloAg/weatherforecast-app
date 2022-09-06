using Microsoft.AspNetCore.Mvc;
using Weatherforecast.Domain.Ports;

namespace Weatherforecast.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICalculator _calculator;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICalculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("add/{number1}/{number2}")]
        public ActionResult add(int number1, int number2)
        {
            var result = _calculator.add(number1, number2);
            return Ok(result);
        }
    }
}