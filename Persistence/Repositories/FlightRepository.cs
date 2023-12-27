using Domain.Flights;
using Domain.Points;

namespace Persistence.Repositories;

public class FlightRepository : IFlightRepository
{
    public List<Flight> GetAll()
    {
        return generateMockFlights();
    }

    private List<Flight> generateMockFlights()
    {
        var flights = new List<Flight>();

        List<Point> route = new()
        {
            new Airport("KUGN", "Waukegan National Airport", new Latitude(42, 25, 33, LatitudeType.North), new Longitude(87, 52, 07, LongitudeType.West)),
            new VOR("OBK", "Northbrook", 113.0, new Latitude(42, 13, 17, LatitudeType.North), new Longitude(87, 57, 6, LongitudeType.West)),
            new Airport("KPWK", "Chicago Execuitve Airport", new Latitude(42, 6, 86, LatitudeType.North), new Longitude(87, 54, 9, LongitudeType.West))
        };

        flights.Add(new Flight("My first flight", route));

        return flights;
    }

    public Flight? GetById(int id) { throw new NotImplementedException(); }

    public void Add(Flight flight) { throw new NotImplementedException(); }

    public void Update(Flight flight) { throw new NotImplementedException(); }

    public void Delete(Flight flight) { throw new NotImplementedException(); }
}