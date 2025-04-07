namespace CreationalPattern.Entity;

internal interface IAbstractCargo : IAbstractCar
{
    double Tonnage { get; set; }

    double TankVolume { get; set; }

    int AxlesAmount { get; set; }
}