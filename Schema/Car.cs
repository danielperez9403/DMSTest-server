namespace webapi.Schema

{
    public class Car
    {
        public Car() 
        {
            Brand = String.Empty;
            Model = String.Empty;
            Price = 0;
            Mileage = 0;
            Color = String.Empty;
            Dealer = new DealerBase();
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }
        public DealerBase Dealer { get; set; }
    }
}
