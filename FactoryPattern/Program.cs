namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does your vehicle have?"); // message to user
            var tires = int.Parse(Console.ReadLine()); // take user input

            var vehicle = VehicleFactory.GetVehicle(tires); // variable to hold vehicle build

            vehicle.Drive(); // call factory pattern method
        }
    }
}
