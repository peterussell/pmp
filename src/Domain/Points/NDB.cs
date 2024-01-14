namespace Domain.Points;

public class NDB : Navaid
{
    public NDB(string identifier, string name, double frequency, Latitude latitude, Longitude longitude) =>
        (Identifier, Name, Frequency, Latitude, Longitude) = (identifier, name, frequency, latitude, longitude);
}
