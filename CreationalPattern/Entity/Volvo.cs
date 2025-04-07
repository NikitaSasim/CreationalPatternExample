namespace CreationalPattern.Entity;

internal class Volvo : IAbstractCargo
{
    public double Tonnage { get; set; }
    public double TankVolume { get; set; }
    public int AxlesAmount { get; set; }
    public double Weight { get; set; }
    public double Length { get; set; }
    public double MaxSpeed { get; set; }
}
