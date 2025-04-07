using CreationalPattern.Entity;

namespace CreationalPattern.Factory;

internal class VolvoFactory : IAbstractCarFactory
{
    private const double DefaultTonnage = 20;
    private const double DefaultTankVolume = 200;
    private const int DefaultAxlesAmount = 4;
    private const double DefaultWeight = 20000;
    private const double DefaultLength = 20;
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