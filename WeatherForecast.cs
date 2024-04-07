using System;

namespace WebApplication1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
        public string num2 { get; set; }
        public string num1 { get; set; }

    }
    public class Calculator
    {
        

        public int num1 { get; set; }

      

        public string num12 { get; set; }
    }
}
