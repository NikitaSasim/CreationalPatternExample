// See https://aka.ms/new-console-template for more information

using CreationalPattern.Entity;
using CreationalPattern.Factory;

List<IAbstractCar> garage = new List<IAbstractCar>();

var audiFactory = new AudiFactory();
var hondaFactory = new HondaFactory();
var volvoFactory = new VolvoFactory();
var abramsFactory = new AbramsFactory();
var tigerFactory = new TigerFactory();

garage.Add(audiFactory.CreateCar());
garage.Add(hondaFactory.CreateCar());
garage.Add(volvoFactory.CreateCar());
garage.Add(audiFactory.CreateCar());
garage.Add(abramsFactory.CreateCar());
garage.Add(tigerFactory.CreateCar());

foreach (var car in garage)
{
    if (car is IAbstractTank tank)
    {
        Console.WriteLine($"Tank need {tank.CrewSize} persons to take part in a battle");
    }
    else if (car is IAbstractCargo cargo)
    {
        Console.WriteLine($"Tank volume of cargo is {cargo.TankVolume}" );
    }
    else
        Console.WriteLine($"MaxSpeed is {car.MaxSpeed}" );
}


