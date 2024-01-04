namespace ScreamingSnakeCaseBug
{
    public class WeatherForecast
    {
        public DateTime DATE_TIME { get; set; }

        public int TEMPERATURE_CELSIUS { get; set; }

        public int Temperature_Farenheit => 32 + (int)(TEMPERATURE_CELSIUS / 0.5556);

        public string? some_summary { get; set; }
    }
}