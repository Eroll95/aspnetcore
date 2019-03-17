namespace aspnetcore.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int PricePerHour { get; set; }
        public int PricePerDay { get; set; }
        public int PriceForWeekend { get; set; }
        public int PricePerWeek { get; set; }
        public string Acceleration { get; set; }
        public string Power { get; set; }
        public string Torque { get; set; }
        public string MaxSpeed { get; set; }
        public string Image { get; set; }
    }
}
