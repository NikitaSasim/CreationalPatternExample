using CreationalPattern.Entity;

namespace CreationalPattern.Factory;

internal class TigerFactory : IAbstractCarFactory
{
    private const int DefaultProjectileCaliber = 42;
    private const int DefaultShotsPerMinute = 4;
    private const int DefaultCrewSize = 5;
    private const double DefaultWeight = 27000;
    private const double DefaultLength = 12;
    private const double DefaultMaxSpeed = 85;

    public IAbstractCar CreateCar()
    {
        var merkava = new Merkava()
        {
            ProjectileCaliber = DefaultProjectileCaliber,
            ShotsPerMinute = DefaultShotsPerMinute,
            CrewSize = DefaultCrewSize,
            Weight = DefaultWeight,
            Length = DefaultLength,
            MaxSpeed = DefaultMaxSpeed

        };
        return merkava;
    }
}