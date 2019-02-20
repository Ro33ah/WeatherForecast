using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.Services;

namespace backend.Controllers
{
    public class ForecastController : Controller
    {
        //private readonly IHttpClientFactory _httpClientFactory;
        //public WeatherController(IHttpClientFactory httpClientFactory)
        //{
        //    _httpClientFactory = httpClientFactory;
        //}
        private readonly IWeatherService _weatherService;

        public ForecastController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        [Route("data/2.5/random/{CityID}")]
        public async Task<IActionResult> GetWeather(int CityID)
        {
            var result = await _weatherService.GetWeatherForecast(CityID);
            return Ok(result);
        }
        
    }
}
