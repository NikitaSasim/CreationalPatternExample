namespace CreationalPattern.Entity;

internal interface IAbstractTank : IAbstractCar
{
    int ProjectileCaliber { get; set; }

    int ShotsPerMinute { get; set; }

    int CrewSize { get; set; }
}