using Newtonsoft.Json;
using webapi.Schema;

namespace webapi.Services
{
    public class MockDataService
    {
        public MockDataService() 
        {
            CreateDealers();
            CreateCars();
        }

        public List<DealerBase>? dealers;

        private void CreateDealers()
        {
            dealers = new List<DealerBase>
            {
                new Dealer1 { Id = 1, Name = "Dealer 1", Status = "Active", Cars = new List<Car>() },
                new Dealer2 { Id = 2, Name = "Dealer 2", Status = "Active", Cars = new List<Car>() }
            };
        }


        private void CreateCars()
        {
            var dealer1 = dealers[0];
            dealer1.Cars.Add(new Car { Dealer = dealer1, Brand = "Ford", Model = "Bronco", Price = 34500, Mileage = 0, Color = "Red" });
            dealer1.Cars.Add(new Car { Dealer = dealer1, Brand = "Ford", Model = "Bronco", Price = 30000, Mileage = 10000, Color = "Blue" });
            dealer1.Cars.Add(new Car { Dealer = dealer1, Brand = "Ford", Model = "Ranger", Price = 27400, Mileage = 0, Color = "Silver" });
            dealer1.Cars.Add(new Car { Dealer = dealer1, Brand = "Chrysler", Model = "300", Price = 36640, Mileage = 0, Color = "Gray" });
            dealer1.Cars.Add(new Car { Dealer = dealer1, Brand = "Chrysler", Model = "Pacifica", Price = 25000, Mileage = 63000, Color = "Granite Crystal" });
            dealer1.Cars.Add(new Car { Dealer = dealer1, Brand = "Chevrolet", Model = "Camaro", Price = 29700, Mileage = 0, Color = "Rapid Blue" });



            var dealer2 = dealers[1];
            dealer2.Cars.Add(new Car { Dealer = dealer2, Brand = "Chevrolet", Model = "Camaro", Price = 29700, Mileage = 0, Color = "Rapid Blue" });
            dealer2.Cars.Add(new Car { Dealer = dealer2, Brand = "Chevrolet", Model = "Camaro", Price = 28500, Mileage = 27000, Color = "Gray" });
            dealer2.Cars.Add(new Car { Dealer = dealer2, Brand = "Chevrolet", Model = "Malibu", Price = 31450, Mileage = 0, Color = "Black" });
            dealer2.Cars.Add(new Car { Dealer = dealer2, Brand = "Ford", Model = "Ranger", Price = 27400, Mileage = 0, Color = "Silver" });
            dealer2.Cars.Add(new Car { Dealer = dealer2, Brand = "Chrysler", Model = "Pacifica", Price = 25000, Mileage = 63000, Color = "Granite Crystal" });
            dealer2.Cars.Add(new Car { Dealer = dealer2, Brand = "Chevrolet", Model = "Suburban", Price = 37000, Mileage = 0, Color = "Black" });
            dealer2.Cars.Add(new Car { Dealer = dealer2, Brand = "Buick", Model = "Verano", Price = 24000, Mileage = 15000, Color = "Silver" });
            dealer2.Cars.Add(new Car { Dealer = dealer2, Brand = "Buick", Model = "Enclave", Price = 35000, Mileage = 50000, Color = "White" });
            dealer2.Cars.Add(new Car { Dealer = dealer2, Brand = "Lincoln", Model = "Continental", Price = 75000, Mileage = 10000, Color = "Black" });
        }

        public string GetCars(int? dealerId) 
        {
            var carList = new List<Car>();
            var currentDealer = dealers.Find(d => d.Id == dealerId);

            if (currentDealer != null)
            {
                carList = currentDealer.Cars;
            }

            var jsonData = JsonConvert.SerializeObject(new { cars = carList }, Formatting.Indented, 
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });

            return jsonData;
        }
    }
}
