using Domain.Flights;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : ControllerBase
    {

        private readonly ILogger<FlightController> _logger;

        private readonly IFlightRepository _flightRepository;

        public FlightController(ILogger<FlightController> logger, IFlightRepository flightRepository)
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