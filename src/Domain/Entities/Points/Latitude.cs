namespace Domain.Entities.Points;

public class Latitude : Coordinate
{
    public LatitudeType Type { get; set; }

    public Latitude(int degrees, int minutes, int seconds, LatitudeType type) =>
        (Degrees, Minutes, Seconds, Type) = (degrees, minutes, seconds, type);
}
