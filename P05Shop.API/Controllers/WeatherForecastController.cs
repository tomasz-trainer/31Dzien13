using Microsoft.AspNetCore.Mvc;

namespace P05Shop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        //https://localhost:7127/api/WeatherForecast
  
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //https://localhost:7127/api/WeatherForecast/onlyTwo
        [HttpGet("onlyTwo")]
        public IEnumerable<WeatherForecast> GetOnlyTwoWeatherForeceast()
        {
            return new WeatherForecast[2]
            {
                new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now),
                    TemperatureC = 25,
                    Summary = "Sunny"
                },
                new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                    TemperatureC = 22,
                    Summary = "Cloudy"
                }

            };
        }

        //https://localhost:7127/api/WeatherForecast/search?number=3
        [HttpGet("search")]
        public IEnumerable<WeatherForecast> GetWeatherForecasts([FromQuery] int number)
        {
            return Enumerable.Range(1, number).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }


        //https://localhost:7127/api/WeatherForecast/test/hello?number=3
        [HttpGet("test/{routeParam}")]
        public string GetValueFromPatch([FromQuery] int number,[FromRoute] string routeParam)
        {
            return $"Route parameter: {routeParam}, Query parameter: {number}";
        }

        //https://localhost:7127/api/WeatherForecast/filter?cityName=New%20York&country=USA
        [HttpGet("filter")]
        public string GetValueFromPatch([FromQuery] string cityName, [FromQuery] string country)
        {
            return $"City: {cityName}, Country: {country}";
        }


    } 
}
