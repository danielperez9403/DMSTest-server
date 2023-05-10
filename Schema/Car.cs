namespace webapi.Schema

{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }
        public virtual string Status { get; set; }
    }
}
