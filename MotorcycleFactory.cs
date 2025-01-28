public class MotorcycleFactory : IVehicleFactory
{
    public IVehicle CreateVehicle(string model, int year, double mileage)
    {
        return new MotorcycleImpl { Model = model, Year = year, Mileage = mileage };
    }

    public MotorcycleImpl CreateMotorcycle(string brand, string model, int year, double mileage, string engineType)
    {
        return new MotorcycleImpl { Model = model, Year = year, Mileage = mileage, EngineType = engineType };
    }
}
