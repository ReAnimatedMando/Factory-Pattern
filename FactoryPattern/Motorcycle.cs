namespace FactoryPattern;

public class Motorcycle : IVehicle // class of vehicle that conforms to factory pattern
{
    public void Drive() // method to call when building new vehicle in main
    {
        Console.WriteLine("Building a new Motorcycle!"); // message to console after calling method
    }
}