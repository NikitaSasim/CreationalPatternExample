using CreationalPattern.Entity;

namespace CreationalPattern.Factory;
internal class AudiFactory : IAbstractCarFactory
{
    private const WheelDrive DefaultWheelDrive = WheelDrive.Front;
    private const VehicleClass DefaultClass = VehicleClass.Sedan;
    private const string DefaultColor = "Red";
    private const double DefaultWeight = 1500;
    private const double DefaultLength = 6.5;
    private const double DefaultMaxSpeed = 200;

    public IAbstractCar CreateCar()
    {
        var audi = new Audi
        {
            WheelDrive = DefaultWheelDrive,
            Class = DefaultClass,
            Color = DefaultColor,
            Weight = DefaultWeight,
            Length = DefaultLength,
            MaxSpeed = DefaultMaxSpeed

        };
        return audi;
    }
}