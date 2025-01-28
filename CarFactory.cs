public class CarFactory : IVehicleFactory
{
    public IVehicle CreateVehicle(string model, int year, double mileage)
    {
        return new CarImpl { Model = model, Year = year, Mileage = mileage };
    }

    public CarImpl CreateCar(string make, string model, int year, double mileage, int doors)
    {
        return new CarImpl { Model = model, Year = year, Mileage = mileage, Doors = doors };
    }
}
