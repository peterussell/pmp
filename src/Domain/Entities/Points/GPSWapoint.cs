namespace Domain.Entities.Points;

public class GPSWaypoint : Point
{
    public GPSWaypoint(string identifier, Latitude latitude, Longitude longitude) =>
        (Identifier, Latitude, Longitude) = (identifier, latitude, longitude);
}
