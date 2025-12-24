namespace FactoryPattern;

public class Truck : IVehicle // class of vehicle that conforms to factory pattern
{
    public void Drive() // method to call when building new vehicle in main
    {
        Console.WriteLine("Building a new Truck!"); // message to console after calling method
    }
}