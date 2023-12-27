namespace Domain.Points;

public abstract class Navaid : Point
{
    public double Frequency { get; set; }
    public string Name { get; set; } = string.Empty;
}
