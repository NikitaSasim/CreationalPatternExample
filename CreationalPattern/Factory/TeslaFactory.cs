using CreationalPattern.Entity;

namespace CreationalPattern.Factory;

internal class TeslaFactory : IAbstractCarFactory
{
    private const WheelDrive DefaultWheelDrive = WheelDrive.Front;
    private const VehicleClass DefaultClass = VehicleClass.Coupe;
    private const string DefaultColor = "White";
    private const double DefaultWeight = 1900;
    private const double DefaultLength = 5.9;
    private const double DefaultMaxSpeed = 220;

    public IAbstractCar CreateCar()
    {
        var tesla = new Tesla
        {
            WheelDrive = DefaultWheelDrive,
            Class = DefaultClass,
            Color = DefaultColor,
            Weight = DefaultWeight,
            Length = DefaultLength,
            MaxSpeed = DefaultMaxSpeed

        };
        return tesla;
    }
}