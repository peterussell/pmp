using Domain.Entities.Points;

namespace Domain.Entities.Flights;

public class Flight
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Point> Route { get; set; } = new();

    public Flight(string name, List<Point> route) =>
        (Name, Route) = (name, route);
}
