using System;
using System.ComponentModel.DataAnnotations;

namespace webapi_jwt
{
    public class WeatherForecast
    {
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
