namespace Domain.Entities.Flights;

public interface IFlightRepository
{
    List<Flight> GetAll();
    Flight? GetById(int id);
    void Add(Flight flight);
    void Update(Flight flight);
    void Delete(Flight flight);
}
