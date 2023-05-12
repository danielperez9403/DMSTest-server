using Microsoft.AspNetCore.Mvc;
using webapi.Services;
using webapi.Schema;
using Newtonsoft.Json;

namespace webapi.Controllers
{
    [ApiController]
    public class CarDealerController : ControllerBase
    {
        private readonly MockDataService _mockDataService;
        private readonly ILogger<CarDealerController> _logger;

        public CarDealerController(ILogger<CarDealerController> logger)
        {
            _mockDataService = new MockDataService();
            _logger = logger;
        }

        [HttpGet]
        [Route("api/v1/Cars")]
        public IActionResult Cars(int? dealerId) 
        {
            string result = _mockDataService.GetCars(dealerId);

            return Ok(result);
        }

        [HttpGet]
        [Route("api/v1/Dealers")]
        public IActionResult Dealers()
        {
            string result = _mockDataService.GetDealers();

            return Ok(result);
        }
    }
}
