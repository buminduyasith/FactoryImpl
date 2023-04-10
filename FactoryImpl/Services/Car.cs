using FactoryImpl.Interfaces;

namespace FactoryImpl.Services
{
    public class Car : IVehicle
    {
        public string VehicleType { get; set; } = "Car";

        public void Excute()
        {
            Console.WriteLine("Car");
        }
    }
}
