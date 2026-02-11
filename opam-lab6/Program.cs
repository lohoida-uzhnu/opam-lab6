List<Vehicle> vehicles = new List<Vehicle>()
{
    new Car(),
    new Bicycle(),
    new Airplane()
};
foreach (var vehicle in vehicles)
{
    vehicle.Move();
}

public abstract class Vehicle
{
    public string Brand;
    public double speed;
    public abstract void Move();
}


public class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Машина їде!");
    }
}

public class Bicycle : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Велосипед їде!");
    }
}

public class Airplane : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Літак летить!");
    }
}