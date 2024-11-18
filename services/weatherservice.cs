using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private const string ApiKey = "YOUR_API_KEY"; // Add your own API key here
        private const string BaseUrl = "http://api.openweathermap.org/data/2.5/weather";

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public WeatherData GetWeatherData(string city)
        {
            var url = $"{BaseUrl}?q={city}&appid={ApiKey}&units=metric";
            var response = _httpClient.GetStringAsync(url).Result;
            var weatherData = JsonConvert.DeserializeObject<WeatherData>(response);
            return weatherData;
        }
    }
}
