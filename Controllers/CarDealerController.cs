﻿using Microsoft.AspNetCore.Mvc;
using webapi.Services;
using webapi.Schema;

namespace webapi.Controllers
{
    [Route("api/v1/[controller]")]
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

        [HttpGet(Name = "GetCarDealer")]
        public IActionResult GetCarDealer(string? dealer) 
        {
            List<Car> result = _mockDataService.GetCars(dealer);

            return Ok(result);
        }
    }
}