using CreationalPattern.Entity;

namespace CreationalPattern.Factory;

internal class HondaFactory : IAbstractCarFactory
{
    private const WheelDrive DefaultWheelDrive = WheelDrive.Back;
    private const VehicleClass DefaultClass = VehicleClass.Hatchback;
    private const string DefaultColor = "Black";
    private const double DefaultWeight = 1300;
    private const double DefaultLength = 5.5;
    private const double DefaultMaxSpeed = 190;

    public IAbstractCar CreateCar()
    {
        var honda = new Honda
        {
            WheelDrive = DefaultWheelDrive,
            Class = DefaultClass,
            Color = DefaultColor,
            Weight = DefaultWeight,
            Length = DefaultLength,
            MaxSpeed = DefaultMaxSpeed

        };
        return honda;
    }
}