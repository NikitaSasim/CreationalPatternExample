using CreationalPattern.Entity;

namespace CreationalPattern.Factory;

internal class MerkavaFactory : IAbstractCarFactory
{
    private const int DefaultProjectileCaliber = 35;
    private const int DefaultShotsPerMinute = 6;
    private const int DefaultCrewSize = 4;
    private const double DefaultWeight = 22000;
    private const double DefaultLength = 11;
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