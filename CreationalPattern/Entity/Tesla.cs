namespace CreationalPattern.Entity;

internal class Tesla : IAbstractVehicle
{
    public WheelDrive WheelDrive { get; set; }
    public VehicleClass Class { get; set; }
    public string? Color { get; set; }
    public double Weight { get; set; }
    public double Length { get; set; }
    public double MaxSpeed { get; set; }
}
