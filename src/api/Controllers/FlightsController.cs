using Domain.Flights;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly ILogger<FlightsController> _logger;

        private readonly IFlightRepository _flightRepository;

        public FlightsController(ILogger<FlightsController> logger, IFlightRepository flightRepository)
        {
            _logger = logger;
            _flightRepository = flightRepository;
        }

        [HttpGet(Name = "GetFlights")]
        public IEnumerable<Flight> Get()
        {
            return _flightRepository.GetAll();
        }
    }
}