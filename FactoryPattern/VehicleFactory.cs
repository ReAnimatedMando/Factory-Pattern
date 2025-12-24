namespace FactoryPattern;

public class VehicleFactory // class that will convert user input and use factory pattern to build new vehicles
{
    public static IVehicle GetVehicle(int numberOfTires) // method to serve as blueprint for building new vehicle
    {
        switch (numberOfTires) // switch case
        {
            case 2: // in the case of user input 2 tires
                return new Motorcycle(); // build new Motorcycle
            case 4: // in case of user input 4 tires
                return new Truck(); // build new Truck
            default: // default case to hold all other user input
                return new Truck(); // build new Truck
        }
    }
}