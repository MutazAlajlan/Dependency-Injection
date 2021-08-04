using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisApp.Services
{
    public class AmazingWeatherForecast : IWeatherForecaster
    {
        public AmazingWeatherForecast()
        {

        }
        WeatherResult IWeatherForecaster.GetCurrentWeather()
        {
            throw new NotImplementedException();
        }
    }
}
