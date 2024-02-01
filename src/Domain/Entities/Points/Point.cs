namespace Domain.Entities.Points;

public abstract class Point
{
    public int Id { get; set; }
    public string Identifier { get; set; } = string.Empty;
    public Latitude? Latitude { get; set; }
    public Longitude? Longitude { get; set; }
}
