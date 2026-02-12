List<Vehicle> vehicles = new List<Vehicle>()
{
    new Car(),
    new Bicycle(),
    new Airplane()
};
foreach (var vehicle in vehicles)
{
    vehicle.Move();
    
    if (vehicle is IRefulable refulable)
    {
        refulable.Refill();
    }
}

public interface IRefulable
{ 
    void Refill();
}

public abstract class Vehicle
{
    public string Brand;
    public double Speed;
    public abstract void Move();
}


public class Car : Vehicle, IRefulable
{
    public void Refill()
    {
        Console.WriteLine("Машина заправлена!");
    }

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

public class Airplane : Vehicle, IRefulable
{
    public void Refill()
    {
        Console.WriteLine("Літак заправлений!");
    }

    public override void Move()
    {
        Console.WriteLine("Літак летить!");
    }
}