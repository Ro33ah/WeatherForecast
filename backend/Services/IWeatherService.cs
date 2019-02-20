using backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Services
{
    public interface IWeatherService
    {
        Task<WeatherModel> GetWeatherForecast(int CityID);
    }
}
