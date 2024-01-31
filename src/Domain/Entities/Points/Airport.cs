namespace Domain.Entities.Points;

public class Airport : Point
{
    public string Name { get; set; } = string.Empty;

    public Airport(string identifier, string name, Latitude latitude, Longitude longitude) =>
        (Identifier, Name, Latitude, Longitude) = (identifier, name, latitude, longitude);
}
