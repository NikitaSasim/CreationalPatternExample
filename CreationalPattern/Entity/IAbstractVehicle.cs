namespace CreationalPattern.Entity;

internal interface IAbstractVehicle : IAbstractCar
{
    WheelDrive WheelDrive { get; set; }

    VehicleClass Class { get; set; }

    string? Color { get; set; }
}