namespace Domain.Points;

public class VOR : Navaid
{
    public VOR(string identifier, string name, double frequency, Latitude latitude, Longitude longitude) =>
        (Identifier, Name, Frequency, Latitude, Longitude) = (identifier, name, frequency, latitude, longitude);
}
