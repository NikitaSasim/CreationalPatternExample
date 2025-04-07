using CreationalPattern.Entity;

namespace CreationalPattern.Factory;

internal class AbramsFactory : IAbstractCarFactory
{
    private const int DefaultProjectileCaliber = 40;
    private const int DefaultShotsPerMinute = 5;
    private const int DefaultCrewSize = 4;
    private const double DefaultWeight = 19000;
    private const double DefaultLength = 10;
    private const double DefaultMaxSpeed = 90;

    public IAbstractCar CreateCar()
    {
        var abrams = new Abrams()
        {
            ProjectileCaliber = DefaultProjectileCaliber,
            ShotsPerMinute = DefaultShotsPerMinute,
            CrewSize = DefaultCrewSize,
            Weight = DefaultWeight,
            Length = DefaultLength,
            MaxSpeed = DefaultMaxSpeed

        };
        return abrams;
    }
}