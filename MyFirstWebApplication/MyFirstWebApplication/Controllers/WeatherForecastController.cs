using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApplication.Models;

namespace MyFirstWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {

        private WeatherForecastHolder _weatherForecastHolder;

        public WeatherForecastController(WeatherForecastHolder weatherForecastHolder)
        {
            _weatherForecastHolder = weatherForecastHolder;
        }


        [HttpPost("add")]
        public IActionResult Add([FromQuery] DateTime date, [FromQuery] int temperatureC)
        {
            _weatherForecastHolder.Add(date, temperatureC); 
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult Update([FromQuery] DateTime date, [FromQuery] int temperatureC)
        {
            return Ok(_weatherForecastHolder.Update(date, temperatureC));
        }

        [HttpGet("get-all")]
        public IActionResult GetAll([FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo)
        {
            return Ok(_weatherForecastHolder.Get(dateFrom, dateTo));
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] DateTime date)
        {
            return Ok();
        }

    }
}
