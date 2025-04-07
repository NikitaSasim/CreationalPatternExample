using CreationalPattern.Entity;

namespace CreationalPattern.Factory;

internal class ManFactory : IAbstractCarFactory
{
    private const double DefaultTonnage = 22;
    private const double DefaultTankVolume = 220;
    private const int DefaultAxlesAmount = 3;
    private const double DefaultWeight = 22000;
    private const double DefaultLength = 21;
    private const double DefaultMaxSpeed = 130;

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