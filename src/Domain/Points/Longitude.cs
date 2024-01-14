namespace Domain.Points;

public class Longitude : Coordinate
{
    public LongitudeType Type { get; set; }

    public Longitude(int degrees, int minutes, int seconds, LongitudeType type) =>
        (Degrees, Minutes, Seconds, Type) = (degrees, minutes, seconds, type);
}
