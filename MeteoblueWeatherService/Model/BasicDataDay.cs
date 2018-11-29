using System.Collections.Generic;

namespace MeteoblueWeatherService.Model
{
    public class BasicDataDay
    {
        public List<string> time { get; set; }
        public List<int?> pictocode { get; set; }
        public List<int?> uvindex { get; set; }
        public List<decimal?> temperature_max { get; set; }
        public List<decimal?> temperature_min { get; set; }
        public List<decimal?> temperature_mean { get; set; }
        public List<decimal?> felttemperature_max { get; set; }
        public List<decimal?> felttemperature_min { get; set; }
        public List<int?> winddirection { get; set; }
        public List<int?> precipitation_probability { get; set; }
        public List<string> rainspot { get; set; }
        public List<int?> predictability_class { get; set; }
        public List<int?> predictability { get; set; }
        public List<decimal?> precipitation { get; set; }
        public List<decimal?> snowfraction { get; set; }
        public List<int?> sealevelpressure_max { get; set; }
        public List<int?> sealevelpressure_min { get; set; }
        public List<int?> sealevelpressure_mean { get; set; }
        public List<decimal?> windspeed_max { get; set; }
        public List<decimal?> windspeed_mean { get; set; }
        public List<decimal?> windspeed_min { get; set; }
        public List<int?> relativehumidity_max { get; set; }
        public List<int?> relativehumidity_min { get; set; }
        public List<int?> relativehumidity_mean { get; set; }
        public List<decimal?> convective_precipitation { get; set; }
        public List<decimal?> precipitation_hours { get; set; }
        public List<decimal?> humiditygreater90_hours { get; set; }
    }
}