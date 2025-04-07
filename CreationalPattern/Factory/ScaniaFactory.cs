using CreationalPattern.Entity;

namespace CreationalPattern.Factory;

internal class ScaniaFactory : IAbstractCarFactory
{
    private const double DefaultTonnage = 21;
    private const double DefaultTankVolume = 210;
    private const int DefaultAxlesAmount = 4;
    private const double DefaultWeight = 19000;
    private const double DefaultLength = 22;
    private const double DefaultMaxSpeed = 140;

    public IAbstractCar CreateCar()
    {
        var volvo = new Volvo()
        {
            Tonnage = DefaultTonnage,
            TankVolume = DefaultTankVolume,
            AxlesAmount = DefaultAxlesAmount,
            Weight = DefaultWeight,
            Length = DefaultLength,
            MaxSpeed = DefaultMaxSpeed

        };
        return volvo;
    }
}