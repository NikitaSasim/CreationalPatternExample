namespace CreationalPattern.Entity;

internal class Merkava : IAbstractTank
{
    public int ProjectileCaliber { get; set; }
    public int ShotsPerMinute { get; set; }
    public int CrewSize { get; set; }
    public double Weight { get; set; }
    public double Length { get; set; }
    public double MaxSpeed { get; set; }
}