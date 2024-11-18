namespace WeatherApp.Models
{
    public class WeatherData
    {
        public Main Main { get; set; }
        public List<Weather> Weather { get; set; }
    }

    public class Main
    {
        public double Temp { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }
    }

    public class Weather
    {
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
