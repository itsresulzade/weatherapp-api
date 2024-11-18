using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;
using System.Threading.Tasks;

namespace WeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        private readonly WeatherService _weatherService;

        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<IActionResult> Index(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                return View(null);
            }

            var weatherData = await _weatherService.GetWeatherAsync(city);
            return View(weatherData);
        }
    }
}
