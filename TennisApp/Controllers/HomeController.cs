using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TennisApp.Models;
using TennisApp.Services;

namespace TennisApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWeatherForecaster _weatherForecaster;

        public HomeController(IWeatherForecaster weatherForecaster ,
            ILogger<HomeController> logger)
        {
            _logger = logger;
            _weatherForecaster = weatherForecaster;
        }

        public IActionResult Index()
        {

            var viewModel = new HomeViewModel();

            
            var currentWeather = _weatherForecaster.GetCurrentWeather();

            switch (currentWeather.WeatherCondition)
            {
                case WeatherCondition.Sun:
                    viewModel.WeatherDescription = "It's sunny right now. A great day for tennis.";
                    break;

                case WeatherCondition.Rain:
                    viewModel.WeatherDescription = "We're sorry but it's raining here. No outdoor courts in use.";
                    break;

                default:
                    viewModel.WeatherDescription = "We don't have the latest weather information right now, please check again later.";
                    break;
            }

            return View(viewModel);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
