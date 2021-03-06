﻿using backend.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace backend.Services
{
    public class GetWeather: IGetWeather
    {
        public async Task<WeatherModel> ReturnWeatherForecast(int CityID)
        {
            const string appid = "fcadd28326c90c3262054e0e6ca599cd";

            using (var client = new HttpClient())
            {
                var url = new Uri($"http://api.openweathermap.org/data/2.5/forecast?id={CityID}&appid={appid}&units=imperial");
                var response = await client.GetAsync(url);
                string json;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }
                return JsonConvert.DeserializeObject<WeatherModel>(json);
            }

        }
    }
}
