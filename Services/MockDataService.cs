using webapi.Schema;

namespace webapi.Services
{
    public class MockDataService
    {
        private readonly List<Car> _cars = new List<Car>
        {
            new Dealer1 { Brand = "Ford", Model = "Bronco", Price = 34500, Mileage = 0, Color = "Red", Status = "Inactive" },
            new Dealer1 { Brand = "Ford", Model = "Bronco", Price = 30000, Mileage = 10000, Color = "Blue", Status = "Active" },
            new Dealer1 { Brand = "Ford", Model = "Ranger", Price = 27400, Mileage = 0, Color = "Silver", Status = "Inactive" },
            new Dealer1 { Brand = "Ford", Model = "Maverick", Price = 16000, Mileage = 25000, Color = "White", Status = "Active" },
            new Dealer1 { Brand = "Chrysler", Model = "Pacifica", Price = 25000, Mileage = 63000, Color = "Granite Crystal", Status = "Active" },
            new Dealer1 { Brand = "Chrysler", Model = "300", Price = 36640, Mileage = 0, Color = "Gray", Status = "Inactive" },
            new Dealer2 { Brand = "Chevrolet", Model = "Camaro", Price = 29700, Mileage = 0, Color = "Rapid Blue", Status = "Inactive" },
            new Dealer2 { Brand = "Chevrolet", Model = "Camaro", Price = 28500, Mileage = 27000, Color = "Gray", Status = "Active" },
            new Dealer2 { Brand = "Chevrolet", Model = "Malibu", Price = 31450, Mileage = 0, Color = "Black", Status = "Active" },
            new Dealer2 { Brand = "Chevrolet", Model = "Blazer", Price = 37900, Mileage = 0, Color = "Blue Glow", Status = "Inactive" },
        };

        public List<Car> GetCars(string? dealer) 
        {
            List<Car> result;
            if (dealer == "Dealer1")
            {
                result = _cars.OfType<Dealer1>().ToList<Car>();
            }
            else if (dealer == "Dealer2")
            {
                result = _cars.OfType<Dealer2>().ToList<Car>();
            }
            else
            {
                result = new List<Car>();
            }

            return result;
        }
    }
}
