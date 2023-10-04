namespace Laboratorio.DesignPattern;

interface ICar
{
    public void Drive();
}

class Suv: ICar
{
    public Suv(int capacity) 
    {
        Capacity = capacity;
    }
    public int Capacity { get; set; }
    public void Drive()
    {
        Console.WriteLine($"I drive an {Capacity}");
    }
}
class Sedan: ICar
{
    public Sedan(string model) 
    {
        Model = model;
    }
    public string Model { get; set; }
    public void Drive()
    {
        Console.WriteLine($"I drive an {Model}");
    }
}

interface ICarFactory
{
    ICar Create();
}

class SuvFactory: ICarFactory
{
    public int Capacity { get; set; }
    public SuvFactory(int capacity)
    {
        Capacity = capacity;
    }
    public ICar Create()
    {
        return new Suv(Capacity);
    }
}
class SedanFactory: ICarFactory
{
    public string Model { get; set; }
    public SedanFactory(string model)
    {
        Model = model;
    }
    public ICar Create()
    {
        return new Sedan(Model);
    }
}

public class Factory
{

    public static void Executar()
    {
        var fabricaDeSuv = new SuvFactory(10);
        var suvCar = fabricaDeSuv.Create();
        suvCar.Drive();

        SedanFactory FabricaDeSedan = new("cerato");
        ICar cerato = FabricaDeSedan.Create();
        cerato.Drive();
        
    }
}
