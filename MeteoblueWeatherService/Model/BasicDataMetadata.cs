namespace MeteoblueWeatherService.Model
{
    public class BasicDataMetadata
    {
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int height { get; set; }
        public string timezone_abbrevation { get; set; }
        public double utc_timeoffset { get; set; }
        public string modelrun_utc { get; set; }
        public string modelrun_updatetime_utc { get; set; }
    }
}