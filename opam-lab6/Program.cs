List<Applience> appliences = new List<Applience>()
{
    new Fridge(),
    new WashingMachine(),
    new Microwave()
};
foreach (var applience in appliences)
{
    applience.Work();
    
    if (applience is IWashingPowder powder)
    {
        powder.PourPowder();
    }
}

public interface IWashingPowder
{ 
    void PourPowder();
}

public abstract class Applience
{
    public string Brand;
    public double Power;
    public abstract void Work();
}


public class Fridge : Applience
{
    public override void Work()
    {
        Console.WriteLine("Холодильник працює!");
    }
}

public class WashingMachine : Applience, IWashingPowder
{
    public void PourPowder()
    {
        Console.WriteLine("Пральний порошок засипаний!");
    }

    public override void Work()
    {
        Console.WriteLine("Пральна машина працює!");
    }
}

public class Microwave : Applience
{
    public override void Work()
    {
        Console.WriteLine("Мікрохвильовка працює!");
    }
}