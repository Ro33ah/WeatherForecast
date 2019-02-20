using backend.Models;
using System.Threading.Tasks;
using backend.Services;

namespace backend
{
     public class WeatherService : IWeatherService
    {
        private static IGetWeather _getWeather;
        public WeatherService(IGetWeather getWeather)
        {
            _getWeather = getWeather;
        }
        public async Task<WeatherModel> GetWeatherForecast(int CityID)
        {
            return await _getWeather.ReturnWeatherForecast(CityID);
        }
    }
}