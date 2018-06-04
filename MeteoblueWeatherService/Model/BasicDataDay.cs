using System.Collections.Generic;

namespace MeteoblueWeatherService.Model
{
    public class BasicDataDay
    {
        public List<string> time { get; set; }
        public List<int> pictocode { get; set; }
        public List<int?> uvindex { get; set; }
        public List<double> temperature_max { get; set; }
        public List<double> temperature_min { get; set; }
        public List<double> temperature_mean { get; set; }
        public List<double> felttemperature_max { get; set; }
        public List<double> felttemperature_min { get; set; }
        public List<int> winddirection { get; set; }
        public List<int> precipitation_probability { get; set; }
        public List<string> rainspot { get; set; }
        public List<int> predictability_class { get; set; }
        public List<int> predictability { get; set; }
        public List<double> precipitation { get; set; }
        public List<double> snowfraction { get; set; }
        public List<int> sealevelpressure_max { get; set; }
        public List<int> sealevelpressure_min { get; set; }
        public List<int> sealevelpressure_mean { get; set; }
        public List<double> windspeed_max { get; set; }
        public List<double> windspeed_mean { get; set; }
        public List<double> windspeed_min { get; set; }
        public List<int> relativehumidity_max { get; set; }
        public List<int> relativehumidity_min { get; set; }
        public List<int> relativehumidity_mean { get; set; }
        public List<double> convective_precipitation { get; set; }
        public List<double> precipitation_hours { get; set; }
        public List<double> humiditygreater90_hours { get; set; }
    }
}