using System;

namespace DebugWorkshop2022_1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        // Formula: x°C × 9 / 5 + 32
        public int TemperatureF => TemperatureC * (int)(9 / 5) + 32;

        public string Summary { get; set; }
    }
}
