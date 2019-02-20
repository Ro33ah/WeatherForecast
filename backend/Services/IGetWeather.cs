using backend.Models;
using System.Threading.Tasks;

namespace backend.Services
{
    public interface IGetWeather
    {
        Task<WeatherModel> ReturnWeatherForecast(int CityID);
    }
}
